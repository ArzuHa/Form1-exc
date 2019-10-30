using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormExc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProvider1.SetError(textBoxName, "Ad bos buraxila bilmez");
            }

            if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                errorProvider1.SetError(textBoxSurname, "Soyad bos buraxila bilmez");
            }

            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;

            richTextBox.Text+=($"{name} {surname}{Environment.NewLine}");

            textBoxName.Clear();
            textBoxSurname.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string text1 = richTextBox.Text;
            File.WriteAllText("Test.txt", text1);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            richTextBox.Text = File.ReadAllText("Test.txt");

        }
    }

    

}
