﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = textBox1.Text.Split(',');
            MyCompare<string> myCompare = new MyCompare<string>();
            Array.Sort(array, myCompare);

            foreach (string str in array)
            {
                textBox2.Text += str + ",";
            }
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
        }
        class MyCompare<T> : IComparer<T>
        {
            int IComparer<T>.Compare(T x, T y)
            {
                string a = x as string;//"Ivanov Petya - 5"
                String b = y as String;
                int score_x = int.Parse((a.Split('-'))[1]);
                int score_y = int.Parse((b.Split('-'))[1]);

                return (score_x > score_y) ? -1 : 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = textBox2.Text + "This is Diana's update 12/01/23 of a new feature";
            Form2 form2 = new Form2(msg);
            form2.ShowDialog(this);
	        
            int test = 80;//bug fixed
            textBox2.Text = form2.strMsg + test.ToString();
	    
        
        }
    }
}
