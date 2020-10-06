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

namespace zapistxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\users\\Michał\\Projekty\\zapis.txt");
            txt.Write(richTextBox1.Text);
            txt.Close();
        }
    }
}
