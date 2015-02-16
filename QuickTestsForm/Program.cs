using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace QuickTestsForm
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //public static bool ValuesAreRepetead(List<string> list)
        //{
        //    var result = false;

        //    var resultString = "";

        //    var contador = new int[list.Count];

        //    for (int i = 0; i < contador.Length; i++)
        //    {
        //        contador[i]++;
        //    }

        //    const string pattern = @"\([0-9]*\)";
        //    var progressCount = 0;

        //    for (var i = 0; i < list.Count; i++)
        //    {
        //        progressCount = (i/list.Count)*100;
        //        for (var j = 0; j < list.Count; j++)
        //        {
        //            if (list[j].Equals(list[i]) && j != i)
        //            {
        //                contador[j]++;
        //                if (resultString.Contains(list[j]))
        //                {

        //                    resultString = new Regex(list[j] + pattern).Replace(resultString,
        //                        list[j] + "(" + contador[j] + ")");
        //                }
        //                else
        //                {
        //                    resultString += list[j] + "(" + contador[j] + ")\n";
        //                }
        //                result = true;
        //            }
        //        }
        //        pro
        //    }

        //    if(!resultString.Equals(""))
        //        MessageBox.Show("Values repeated\n---------\n"+resultString,@"Results");

        //    return result;
        //}
    }
}
