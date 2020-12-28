using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace _20163168_제성덕
{
    public partial class Form1 : Form
    {
        int[,] answer1 = new int[5, 5] {
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 } };
        int[,] answer2 = new int[5, 5]{
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 1 } };
        int[,] answer3 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 1 } };
        int[,] answer4 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 1 } };

        int[,] x1 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { -1, -1, -1, -1, 1 },
            { -1, -1, -1, -1, 1 },
            { -1, -1, -1, -1, 1 },
            { -1, -1, -1, -1, 1 } };
        int[,] x1T = new int[5, 5];

        int[,] x2 = new int[5, 5]{
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x2T = new int[5, 5];

        int[,] x3 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, -1, -1, -1, -1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x3T = new int[5, 5];

        int[,] x4 = new int[5, 5]{
            { 1, 1, 1, 1, 1 },
            { -1, -1, -1, -1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, -1, -1, -1, -1 },
            { 1, 1, 1, 1, 1 } };
        int[,] x4T = new int[5, 5];

        int[,] W = new int[5, 5];
        int[,] B = new int[5, 5];
        int[,] Answer = new int[5, 5];

        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tag = int.Parse(btn.Tag.ToString());

            if (tag <= 5)
            {
                if (B[0, tag - 1] == 1)
                {
                    btn.Text = " ";
                    B[0, tag - 1] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[0, tag - 1] = 1;
                }
            }
            else if(tag <= 10)
            {
                if (B[1, tag - 6] == 1)
                {
                    btn.Text = " ";
                    B[1, tag - 6] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[1, tag - 6] = 1;
                }
            }
            else if(tag <= 15)
            {
                if (B[2, tag - 11] == 1)
                {
                    btn.Text = " ";
                    B[2, tag - 11] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[2, tag - 11] = 1;
                }
            }
            else if(tag <= 20)
            {
                if (B[3, tag - 16] == 1)
                {
                    btn.Text = " ";
                    B[3, tag - 16] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[3, tag - 16] = 1;
                }
            }
            else if(tag <= 25)
            {
                if (B[4, tag - 21] == 1)
                {
                    btn.Text = " ";
                    B[4, tag - 21] = 0;
                }
                else
                {
                    btn.Text = "O";
                    B[4, tag - 21] = 1;
                }
            }
        }

        public bool CheckArr(int[,] arr)
        {
            bool result = false;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (Answer[i, j] != arr[i, j])
                    {
                        result = true;
                        return result;
                    }
                }
            return false;
        }
        public void clean()
        {
            for(int i = 0; i < 5; i++)
                for(int j = 0; j < 5; j++)
                {
                    W[i, j] = 0;
                    B[i, j] = 0;
                    Answer[i, j] = 0;
                }
            this.button10.Text = "";
            this.button11.Text = "";
            this.button12.Text = "";
            this.button13.Text = "";
            this.button14.Text = "";
            this.button15.Text = "";
            this.button16.Text = "";
            this.button17.Text = "";
            this.button18.Text = "";
            this.button20.Text = "";
            this.button21.Text = "";
            this.button22.Text = "";
            this.button23.Text = "";
            this.button24.Text = "";
            this.button25.Text = "";
            this.button26.Text = "";
            this.button27.Text = "";
            this.button28.Text = "";
            this.button29.Text = "";
            this.button30.Text = "";
            this.button31.Text = "";
            this.button32.Text = "";
            this.button33.Text = "";
            this.button34.Text = "";
            this.button35.Text = "";
        }
        private void Result_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //X의 전치행렬 채우고
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    x1T[i, j] = x1[j, i];
                    x2T[i, j] = x2[j, i];
                    x3T[i, j] = x3[j, i];
                    x4T[i, j] = x4[j, i];
                }
            //x * xT 
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        W[i, j] += (x1[i, k] * x1T[k, j]) + (x2[i, k] * x2T[k, j]) + (x3[i, k] * x3T[k, j]) + (x4[i, k] * x4T[k, j]);
                    }
                    if (i == j)
                        W[i, j] = W[i, j] - 4;
                }

            // 가중치를 통해 인공지능 실행
            bool result = true;
            while (result)
            {
                // 입력값 * 가중치
                int i, j,k;
                for (i = 0; i < 5; i++)
                    for (j = 0; j < 5; j++)
                    {
                        for (k = 0; k < 5; k++)
                        {
                            B[i, j] += B[i, k] * W[k, j];
                        }
                       
                    }
                // 활성화 함수
                for (i = 0; i < 5; i++)
                    for (j = 0; j < 5; j++)
                    {
                        if (B[i, j] >= 0)
                            Answer[i, j] = 1;
                        else
                            Answer[i, j] = 0;
                    }
                //체크
                if (CheckArr(answer1) == false)
                    result = false;
                else if (CheckArr(answer2) == false)
                    result = false;
                else if (CheckArr(answer3) == false)
                    result = false;
                else if (CheckArr(answer4) == false)
                    result = false;
            }


            // 값 표시하기
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Answer[i, j] == 1)
                        textBox1.Text += "1  ";
                    else
                        textBox1.Text += "0  ";
                }
                textBox1.Text += "\r\n";
            }
            clean();
        }
    }
}
