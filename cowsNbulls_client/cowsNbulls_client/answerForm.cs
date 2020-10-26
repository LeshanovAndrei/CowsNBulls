using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cowsNbulls_client
{
    public partial class answerForm : Form
    {
        GameLogic g;
        public answerForm(GameLogic g)
        {
            InitializeComponent();
            this.g = g;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Empty answer!");
            }
            else if (textBox1.Text.Length != 4)
            {
                MessageBox.Show("Wrong answer format");
            }
            else if (!answerNumbersIsUniq())
            {
                MessageBox.Show("Numbers should not be repeated!");
            }
            else
            {
                g.SendMsg(textBox1.Text);
                Close();
            }
        }

        private bool answerNumbersIsUniq()
        {
            bool isUnique = true;
            string answ = textBox1.Text;
            int length = 4;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (answ[i] == answ[j])
                    {
                        isUnique = false;
                    }
                }
            }

            return isUnique;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
