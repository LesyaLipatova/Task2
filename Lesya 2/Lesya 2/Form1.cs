using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesya_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initFalePath();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static string Read_from_file(string file_path)
        {
            try
            {
                string text = "";
                using (StreamReader sr = new StreamReader(file_path, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        text += line;
                    }
                }
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        private void initFalePath()
        {
            File_pth.Text = @"C:\Users\lesya\Downloads\Lesya 2\Lesya 2\in.txt";
        }

        private Dictionary<string, int> countVords(string[] text)
        {
            var map = new Dictionary<string, int>();
            foreach (var str in text)
            {
                if (!map.ContainsKey(str.ToString()))
                {
                    map.Add(str.ToString(), 1);
                }
                else
                {
                    int k;
                    map.TryGetValue(str.ToString(), out k);
                    k++;
                    map[str.ToString()] = k;
                }
            }
            return map;
        }

        private void Task_button_Click(object sender, EventArgs e)
        {
            File_text.Text = "";
            string text = Read_from_file(File_pth.Text);
            File_text.Text += text;
            try
            {
                string[] split = text.Split(' ', '!', '\'');
                foreach (KeyValuePair<string, int> kvp in countVords(split))
                {
                    File_text.Text += (kvp.Key, kvp.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
