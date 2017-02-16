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
            bool hasError = false;

            if (sodukuPlayfield.RandomGrid == 0)
            {
                IDictionary<int, int> test = new Dictionary<int, int>();
                for (int i = 0; i < 9; i++)
                {
                    test.Clear();
                    for (int j = 0; j < 9; j++)
                    {
                        
                        int value= sodukuPlayfield.grid[j, i];
                        if (!test.ContainsKey(value))
                        {
                            if (value == 0)
                            {
                                hasError = true;
                            }
                            test.Add(value, 1);
                        }
                        else
                        {
                            test[value] += 1;
                            hasError = true;
                        }
                    }

                }
            }
            if (sodukuPlayfield.RandomGrid == 1)
            {
                IDictionary<int, int> test = new Dictionary<int, int>();
                for (int i = 0; i < 9; i++)
                {
                    test.Clear();
                    for (int j = 0; j < 9; j++)
                    {

                        int value = sodukuPlayfield.grid2[j, i];
                        if (!test.ContainsKey(value))
                        {
                            if (value == 0)
                            {
                                hasError = true;
                            }
                            test.Add(value, 1);
                        }
                        else
                        {
                            test[value] += 1;
                            hasError = true;
                        }
                    }

                }
            }
            if (sodukuPlayfield.RandomGrid == 2)
            {
                IDictionary<int, int> test = new Dictionary<int, int>();
                for (int i = 0; i < 9; i++)
                {
                    test.Clear();
                    for (int j = 0; j < 9; j++)
                    {

                        int value = sodukuPlayfield.grid3[j, i];
                        if (!test.ContainsKey(value))
                        {
                            if (value == 0)
                            {
                                hasError = true;
                            }
                            test.Add(value, 1);
                        }
                        else
                        {
                            test[value] += 1;
                            hasError = true;
                        }
                    }

                }
            }

            if (hasError == false)
            {
                MessageBox.Show("++ Es wurden keine Fehler gefunden ++");
            }
            if (hasError == true)
            {
                MessageBox.Show("-- Einer oder mehrere Fehler wurden gefunden --");
            }
        }

        public bool checkForError(int[,] grid)
        {
            bool hasError = false;

            IDictionary<int, int> test = new Dictionary<int, int>();

            if (sodukuPlayfield.RandomGrid == 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    test.Clear();
                    for (int j = 0; j < 9; j++)
                    {

                        int value = sodukuPlayfield.grid[j, i];
                        if (!test.ContainsKey(value))
                        {
                            if (value == 0)
                            {
                                hasError = true;
                            }
                            test.Add(value, 1);
                        }
                        else
                        {
                            test[value] += 1;
                            hasError = true;
                        }
                    }

                }
            }
            return hasError;
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
