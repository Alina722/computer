﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//程式開始便執行
            //text.Text = "0";
        }
        Calculate Ca = new Calculate();
        int operators = -1;//紀錄選擇的運算符號 0:+ 1:- 2:* 3:/ -1:重設

        private void ac_Click(object sender, EventArgs e)
        {
            text.Text = "0";
            Ca.Reset();
        }

        private void one_Click(object sender, EventArgs e)
        {
            add_number("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            add_number("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            add_number("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            add_number("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            add_number("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            add_number("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            add_number("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            add_number("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            add_number("9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            add_number("0");
        }

        private void add_Click(object sender, EventArgs e)
        {
            calculate(0);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            calculate(2);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            calculate(1);
        }

        private void divided_Click(object sender, EventArgs e)
        {
            calculate(3);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            Ca.secondNumber = Convert.ToSingle(text.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = Ca.Add(); // 執行加法
                    break;
                case 1:
                    finalResults = Ca.Subtract(); // 執行減法
                    break;
                case 2:
                    finalResults = Ca.Multiply(); // 執行乘法
                    break;
                case 3:
                    finalResults = Ca.Divide(); // 執行除法
                    break;
                case 4:
                    finalResults = Ca.Percent();
                    break;
            }

            text.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容
                                     //限制小數點後十位
            operators = -1;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!text.Text.Contains("."))
            {
                text.Text += ".";
            }
        }

        //在輸入框疊加數字
        private void add_number(string _num)
        {
            if (text.Text == "0")
            {
                text.Text = "";
            }
            text.Text += _num;
        }
        private void calculate(int _oper)
        {
            Ca.firstNumber = Convert.ToSingle(text.Text);
            text.Text = "0";
            operators = _oper;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text.Text))
            {
                text.Text = text.Text.Substring(0, text.Text.Length - 1);
                text.SelectionStart = text.Text.Length; // 游標移到最後
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            calculate(4);
        }
    }
}
