using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickTestsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFileText.Text = openFileDialog.FileName;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if(pathFileText.Text!=null)
                if (!Program.ValuesAreRepetead(File.ReadAllLines(pathFileText.Text).ToList()))
                {
                    //MessageBox.Show(@"No values repeated");
                    MessageBox.Show("--------------------\nNo values repeated\n--------------------", @"Result");
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
