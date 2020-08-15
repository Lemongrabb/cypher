using System;
using System.Text;
using System.Windows.Forms;

namespace Cypher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cypherSelector.DataSource = Enum.GetValues(typeof(Program.Cypher));
            onCypherSelected(null,null);
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            switch (cypherSelector.SelectedValue)
            {
                //TODO here i'll add more cyphers
                case Program.Cypher.Ceasar:
                    CeasarCypher();
                    break;
                case Program.Cypher.RailFence:
                    RailFenceCypher();
                    break;
            }
        }

        private void onCypherSelected(object sender, EventArgs e)
        {
            switch (cypherSelector.SelectedValue)
            {   
                //Those cyphers require a key to run
                case Program.Cypher.Ceasar:
                case Program.Cypher.RailFence:
                    optionalInputText.PlaceholderText = "Enter key here";
                    optionalInputText.Visible = true;
                    break;
            }
        }

        private void CeasarCypher()
        {
            //Check if key is entered correctly
            bool parseSuccess = Int32.TryParse(optionalInputText.Text, out int key);
            if (!parseSuccess) return;

            StringBuilder stringBuilder = new StringBuilder(inputText.Text);
            string Alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < inputText.Text.Length; i++)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    if (inputText.Text[i] == Alphabet[j])
                    {
                        stringBuilder.Remove(i,1);
                        stringBuilder.Insert(i,Alphabet[(j+key)%Alphabet.Length]);
                        break;
                    }
                }
            }
            outputText.Text = stringBuilder.ToString();
        }

        private void RailFenceCypher()
        {
            //Check if key is entered correctly
            bool parseSuccess = Int32.TryParse(optionalInputText.Text, out int key);
            if (!parseSuccess) return;

            StringBuilder stringBuilder = new StringBuilder();
            char[,] characters = new char[inputText.Text.Length,key];
            int x = 0, y = 0;
            bool yDirection = true; //true means that "y" index should increment, false means "y" should decrement

            foreach (char ch in inputText.Text)
            {
                characters[x,y] = ch;
                x++;

                if (y == key - 1) yDirection = false;
                if (y == 0) yDirection = true;

                if (yDirection) y++;
                else y--;
            }

            for (int i = 0; i < characters.GetLength(1); i++)
            {
                for (int j = 0; j < characters.GetLength(0); j++)
                {
                    if (characters[j,i] != char.MinValue) stringBuilder.Append(characters[j,i]);
                }
            }

            outputText.Text = stringBuilder.ToString();
        }
    }
}
