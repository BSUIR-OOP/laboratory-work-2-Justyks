using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTPISP1
{
    public partial class Form1 : Form
    {

        int x1, y1;
        Graphics graphic;
        int figureName;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            graphic = CreateGraphics();

            int top = 10;
            int left = 10;
            foreach (Figure figure in FigureList.listIn)
            {
                Button button = new Button();
                button.Left = left;
                button.Height = 40;
                button.Width = 150;
                button.Top = top;
                button.Name = "btn" +i;
                button.Tag = i;
                button.Text = figure.getFigureName();
                button.Click += ButtonOnClick;
                this.Controls.Add(button);
                top+=button.Height;
                i++;

            }


        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            figureName = (int)button.Tag;
        }
        

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphic.Clear(DefaultBackColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            FigureList figureList = new FigureList(x1, y1, e.X, e.Y, graphic);
            foreach (Figure figure in figureList.list)
            {
                if (figureList.list.IndexOf(figure) == figureName)
                {
                    figure.Draw();
                }
            }
        }

       
    }
}