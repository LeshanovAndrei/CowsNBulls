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
            g.SendMsg(textBox1.Text);
            Close();
        }
    }
}
