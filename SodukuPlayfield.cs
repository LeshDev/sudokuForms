using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuForms
{
    public partial class SodukuPlayfield : UserControl
    {
        private List<Point> _clickedLocations = new List<Point>();
        public int[,] grid;
        public int[,] grid2;
        public int[,] grid3;

        public Random random = new Random();
        public int RandomGrid; /* { get; set; }*/
        public SodukuPlayfield()
        {
            Random rdm = new Random();
            RandomGrid = random.Next(3);

            grid = new int[,]
                {
                { 7, 4, 1, 3, 8, 6, 5, 2, 9},
                { 3, 8, 2, 7, 9, 5, 1, 4, 6},
                { 5, 6, 9, 2, 4, 1, 3, 7, 8},
                { 8, 1, 5, 6, 7, 4, 2, 9, 3},
                { 2, 7, 4, 9, 5, 3, 8, 6, 1},
                { 9, 3, 6, 1, 2, 8, 4, 5, 7},
                { 4, 2, 3, 8, 6, 7, 9, 1, 5},
                { 1, 9, 7, 5, 3, 2, 6, 8, 4},
                { 6, 5, 8, 4, 1, 9, 7, 3, 2}
            };

            grid2 = new int[,]
            {
                { 2, 1, 9, 8, 7, 5, 6, 4, 3},
                { 8, 7, 6, 4, 3, 2, 1, 9, 5},
                { 5, 4, 3, 6, 1, 9, 2, 8, 7},
                { 7, 3, 8, 5, 2, 4, 9, 1, 6},
                { 6, 2, 1, 9, 8, 3, 7, 5, 4},
                { 4, 9, 5, 7, 6, 1, 3, 2, 8},
                { 1, 8, 2, 3, 4, 7, 5, 6, 9},
                { 9, 6, 7, 2, 5, 8, 4, 3, 1},
                { 3, 5, 4, 1, 9, 6, 8, 7, 2}
            };

            grid3 = new int[,]
            {
                { 4, 1, 7, 9, 2, 5, 8, 3, 6},
                { 3, 2, 9, 6, 7, 8, 1, 5, 4},
                { 6, 8, 5, 3, 4, 1, 7, 9, 2},
                { 2, 9, 1, 5, 6, 4, 3, 7, 8},
                { 5, 6, 3, 2, 8, 7, 9, 4, 1},
                { 8, 7, 4, 1, 3, 9, 2, 6, 5},
                { 9, 4, 2, 7, 1 ,6, 5, 8, 3},
                { 1, 5, 8, 4, 9, 3, 6, 2, 7},
                { 7, 3, 6, 8, 5, 2, 4, 1, 9}
            };

            InitializeComponent();
            int startUpnumber = 68;                 // 50 null
            int rowGrid = grid.GetLength(0);
            int colGrid = grid.GetLength(1);


            if (RandomGrid == 0)
            {
                for (int i = 0; i < startUpnumber; i++)
                {

                    int x = rdm.Next(9);
                    int y = rdm.Next(9);

                    if (grid[x, y] > 0)
                    {
                        grid[x, y] = rdm.Next(1);
                    }
                    else if (grid[x, y] == 0)
                    {
                        i--;
                    }
                }
            }
            if (RandomGrid == 1)
            {
                for (int i = 0; i < startUpnumber; i++)
                {

                    int x = rdm.Next(9);
                    int y = rdm.Next(9);

                    if (grid2[x, y] > 0)
                    {
                        grid2[x, y] = rdm.Next(1);
                    }
                    else if (grid2[x, y] == 0)
                    {
                        i--;
                    }
                }
            }
            if (RandomGrid == 2)
            {
                for (int i = 0; i < startUpnumber; i++)
                {
                    int x = rdm.Next(9);
                    int y = rdm.Next(9);
                    if (grid3[x, y] > 0)
                    {
                        grid3[x, y] = rdm.Next(1);
                    }
                    else if (grid3[x, y] == 0)
                    {
                        i--;
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen penB = new Pen(Color.FromArgb(100, 0, 0, 0), 2);
            Pen penThick = new Pen(Color.FromArgb(100, 0, 0, 0), 4);
            e.Graphics.Clear(Color.White);

            // Horizontal

            e.Graphics.DrawLine(penB, 50, 0, 50, 1205);
            e.Graphics.DrawLine(penB, 100, 0, 100, 1205);
            e.Graphics.DrawLine(penThick, 150, 0, 150, 1205);
            e.Graphics.DrawLine(penB, 200, 0, 200, 1205);
            e.Graphics.DrawLine(penB, 250, 0, 250, 1205);
            e.Graphics.DrawLine(penThick, 300, 0, 300, 1205);
            e.Graphics.DrawLine(penB, 350, 0, 350, 1205);
            e.Graphics.DrawLine(penB, 400, 0, 400, 1205);

            // Waagerecht

            e.Graphics.DrawLine(penB, 0, 50, 1000, 50);
            e.Graphics.DrawLine(penB, 0, 100, 1000, 100);
            e.Graphics.DrawLine(penThick, 0, 150, 1000, 150);
            e.Graphics.DrawLine(penB, 0, 200, 1000, 200);
            e.Graphics.DrawLine(penB, 0, 250, 1000, 250);
            e.Graphics.DrawLine(penThick, 0, 300, 1000, 300);
            e.Graphics.DrawLine(penB, 0, 350, 1000, 350);
            e.Graphics.DrawLine(penB, 0, 400, 1000, 400);

            if (RandomGrid == 0) { 
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        e.Graphics.DrawString(grid[x, y].ToString(), SystemFonts.DefaultFont, SystemBrushes.ControlText, x * 50 + 20, y * 50 + 20);
                    }
                }
            }
            if(RandomGrid == 1)
            {
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        e.Graphics.DrawString(grid2[x, y].ToString(), SystemFonts.DefaultFont, SystemBrushes.ControlText, x * 50 + 20, y * 50 + 20);
                    }
                }
            }
            if(RandomGrid == 2)
            {
                for (int y = 0; y < 9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        e.Graphics.DrawString(grid3[x, y].ToString(), SystemFonts.DefaultFont, SystemBrushes.ControlText, x * 50 + 20, y * 50 + 20);
                    }
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            _clickedLocations.Add(e.Location);
            int x = e.Location.X / 50;

            int y = e.Location.Y / 50;
            if(RandomGrid == 0)
            {
                grid[x, y] = Form1.buttonNumber;
            }
            if (RandomGrid == 1)
            {
                grid2[x, y] = Form1.buttonNumber;
            }
            if(RandomGrid == 2)
            {
                grid3[x, y] = Form1.buttonNumber;
            }
            Invalidate();
        }
    }
}
