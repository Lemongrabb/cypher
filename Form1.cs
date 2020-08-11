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
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            switch (cypherSelector.SelectedValue)
            {
                //TODO here i'll add more cyphers
                case Program.Cypher.Ceasar:
                    CeasarCypher();
                    break;
            }
        }

        private void onCypherSelected(object sender, EventArgs e)
        {
            switch (cypherSelector.SelectedValue)
            {
                case Program.Cypher.Ceasar:
                    optionalInputText.PlaceholderText = "Enter step here";
                    optionalInputText.Visible = true;
                    break;
            }
        }

        private void CeasarCypher()
        {
            //Check if step is entered correctly
            bool parseSuccess = Int32.TryParse(optionalInputText.Text, out int step);
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
                        stringBuilder.Insert(i,Alphabet[(j+step)%Alphabet.Length]);
                        break;
                    }
                }
            }
            outputText.Text = stringBuilder.ToString();
        }
    }
}
