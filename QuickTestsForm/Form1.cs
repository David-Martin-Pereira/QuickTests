using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace QuickTestsForm
{
    public partial class Form1 : Form
    {
        private List<string> listToProces;

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

            if(!pathFileText.Text.Equals(""))
            {
                label2.Visible = true;
                progressBar1.Visible = true;
                listToProces = File.ReadAllLines(pathFileText.Text).ToList();
                progressBar1.Maximum = listToProces.Count;
                
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please, enter a valid file path");
            }
        }

        private bool ValuesAreRepetead(List<string> list)
        {
            var result = false;

            var resultString = "";

            var contador = new int[list.Count];

            for (int i = 0; i < contador.Length; i++)
            {
                contador[i]++;
            }

            const string pattern = @"\([0-9]*\)";

            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count; j++)
                {
                    if (list[j].Equals(list[i]) && j != i)
                    {
                        contador[j]++;
                        if (resultString.Contains(list[j]))
                        {

                            resultString = new Regex(list[j] + pattern).Replace(resultString,
                                list[j] + "(" + contador[j] + ")");
                        }
                        else
                        {
                            resultString += list[j] + "(" + contador[j] + ")\n";
                        }
                        result = true;
                    }
                    
                }
                backgroundWorker1.ReportProgress(i + 1);
            }

            if(!resultString.Equals("") && !backgroundWorker1.IsBusy)
                MessageBox.Show("Values repeated\n---------\n"+resultString,@"Results");

            return result;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pathFileText.Text != null)
                if (!ValuesAreRepetead(listToProces))
                    MessageBox.Show("--------------------\nNo values repeated\n--------------------", @"Result");
                
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
