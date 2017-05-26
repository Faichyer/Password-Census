using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Password_Census
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = "C:\\Users\\Miki\\Desktop\\tg.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("The very first line!");
                    sw.WriteLine("From the StreamWriter class");
                    sw.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String line;
            String path = "C:\\Users\\Miki\\Desktop\\tg.txt";
        try{
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
               
            }
        }
    }
}
