using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SudokuForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static int buttonNumber;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sodukuPlayfield1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            bool active = true;
            //label1.Text = buttonNumber;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            buttonNumber = 1;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonNumber = 2;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonNumber = 3;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonNumber = 4;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonNumber = 5;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonNumber = 6;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonNumber = 7;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonNumber = 8;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonNumber = 9;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SodukuPlayfield sodukuPlayfield = new SodukuPlayfield();
            bool noError = false;
            int error = 0;
            int correct = 0;
            int x = sodukuPlayfield.grid.GetLength(0) - 1;
            int y = sodukuPlayfield.grid.GetLength(1) - 1;

            var d = 1;
            var r = 2;
            var t = 3;
            var z = 4;
            var u = 5;
            var o = 6;
            var p = 7;
            var a = 8;
            var s = 9;

            List<int> list = new List<int>();

            bool exists = list.Exists(element => element < 1);
            var multi1 = list.Contains(d);
            var multi2 = list.Contains(r);
            var multi3 = list.Contains(t);
            var multi4 = list.Contains(z);
            var multi5 = list.Contains(u);
            var multi6 = list.Contains(o);
            var multi7 = list.Contains(p);
            var multi8 = list.Contains(a);
            var multi9 = list.Contains(s);

            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if (multi1 == true && multi2 == true && multi3 == true && multi4 == true && multi5 == true && multi6 == true && multi7 == true && multi8 == true && multi9 == true)
                    {
                        noError = true;
                    }
                    list.Add(sodukuPlayfield.grid[i, j]);
                }
            }



            

            if (exists == true)
            {
                noError = false;
            }
            else
            {
                noError = true;
            }
            if (noError == true)
            {
                MessageBox.Show("++ Es wurden keine Fehler gefunden ++");
                correct = 0;

            }
            if (noError == false)
            {
                MessageBox.Show("-- Einer oder mehrere Fehler wurden gefunden --");
            }
            label4.Text = Convert.ToString(correct);
            correct = 0;
        }

        public bool checkForZero(int value)
        {
            if (value == 0)
            {
                return false;
            }else
            {
                return true;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            buttonNumber = 0;
            label2.Font = new Font(label2.Font.FontFamily.Name, 20);
            label2.Text = Convert.ToString(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton(object sender, EventArgs e)
        {
            Form1 freset = new Form1();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }



        // Used things

        //        if () {
        //    label3.ForeColor = System.Drawing.Color.Green;
        //label3.Text = "Richtig !!!";
        //}else
        //{
        //label3.ForeColor = System.Drawing.Color.Red;
        //label3.Text = "Fehler vorhanden ?!";
        //}


    }
}
