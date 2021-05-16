using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAsyncAwaitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader("Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        private void btnProcessFileSync_Click(object sender, EventArgs e)
        {
            labelCount1.Text = "Processing File. Please wait...";
            int count = CountCharacters();
            labelCount1.Text = count.ToString() + " characters in file";
        }

        private async void btnProcessFileAsync_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            labelCount2.Text = "Processing File. Please wait...";
            int count = await task;
            labelCount2.Text = count.ToString() + " characters in file";
        }
    }
}
