using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_number
{
    public partial class Form1 : Form
    {
        string a;
        string b;

        public Form1()
        {
            InitializeComponent();
        }

        private int getA()
        {
            int iR = 0;
            for (int k = 0; k < a.Length; k++)
                if (b[k] == a[k]) iR++;
            return iR;
        }
        private int getB()
        {
            int x = 0;
            for (int i = 0; i < b.Length; i++)
                if (a.IndexOf(b[i]) != -1) x++;
            return x;
        }

        protected string getResult()
        {
            return getA() + "A" + (getB() - getA()) + "B";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            a = string.Empty;
            while (a.Length < 4)
            {
                Random random = new Random();
                string s = random.Next(0, 10).ToString();
                if (a.Contains(s) == false)
                {
                    a += s;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("答案為：" + a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isWin = false;

            while (!isWin)
            {
                b = textBox1.Text.ToString();
                if (b.Length == 4)
                {
                    if (getResult() == "4A0B")
                    {
                        listBox1.Items.Add("恭喜你答对了"); isWin = true;
                    }
                    else
                    {
                        listBox1.Items.Add("回答錯誤返回结果:" + getResult()); isWin = true;
                    }
                }
                else
                {
                    MessageBox.Show("請正確輸入！"); isWin = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("您認輸了!!!" + "\n" + "請重新開始");
        }
    }
}
