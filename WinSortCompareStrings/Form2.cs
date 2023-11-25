using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSortCompareStrings
{
    public partial class Form2 : Form
    {
        public string strMsg;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string init)
        {
            strMsg = init;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(strMsg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = strMsg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strMsg = textBox1.Text;
        }
    }
}
