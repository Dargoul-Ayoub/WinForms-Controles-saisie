using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_de__saisie
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider1,errorProvider2,errorProvider3;
        dialogWindow dialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, @"\d"))
                errorProvider2.SetError(textBox2, "the LastName is incorrect");
            else
                errorProvider2.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in textBox4.Text)
                if (!char.IsDigit(c) || textBox4.Text.Length < 5)
                    errorProvider3.SetError(textBox4, "the Code Postal must has at least 5 numbers");
                else
                    errorProvider3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog = new dialogWindow();
            dialog.text1 = textBox2.Text + " " + textBox1.Text;
            dialog.text2 = textBox3.Text;
            dialog.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d"))
            {
                errorProvider1.SetError(textBox1, "the FirstName is incorrect");
            }
        }


     /*  
      *  if you want to check the validation when has been finished in this case it's  recommended to use validating event
      *  private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // if (textBox1.Text.All(char.IsDigit))
            if (Regex.IsMatch(textBox1.Text, @"\d"))
            {
                errorProvider1.SetError(textBox1, "the name is incorrect");
            }
           // else
                //errorProvider1.Icon= new Icon(SystemIcons.WinLogo,16,16);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1 = new ErrorProvider();
            errorProvider2 = new ErrorProvider();
            errorProvider3 = new ErrorProvider();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.MaxDate = DateTime.Now;

        }


    }
}
