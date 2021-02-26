using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_de__saisie
{
    public partial class dialogWindow : Form
    {
        public string text1;
        public string text2;
        public dialogWindow()
        {
            InitializeComponent();
        }

        private void dialogWindow_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label5.Text = text1;
            label6.Text = text2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Environment.Exit(0); it will put end up to whole application not just this form
            // Application.Exit(); this line is doing the same which previous

            this.Close();// this one it works fine
        }
    }
}
