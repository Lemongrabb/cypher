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
                default:
                    break;
            }
        }

        private void CeasarCypher()
        {
            StringBuilder stringBuilder = new StringBuilder(inputText.Text);
            string Alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < inputText.Text.Length; i++)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                {
                    if (inputText.Text[i] == Alphabet[j])
                    {
                        stringBuilder.Remove(i,1);
                        stringBuilder.Insert(i,Alphabet[(j+3)%Alphabet.Length]);
                        break;
                    }
                }
            }
            outputText.Text = stringBuilder.ToString();
        }
    }
}
