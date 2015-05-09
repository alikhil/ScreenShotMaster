using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot_Master
{
    public partial class TakeAreaWindows : Form
    {
        public Rectangle ReturnRectangle
        {
            get;
            private set;
        }
        private Point start = new Point(0, 0);    // точка для создания прямоугольника
        private bool recta = false;     //буль нажата ли кнопка мыши
        private Point end = new Point(0, 0);
        public TakeAreaWindows()
        {
            InitializeComponent();
        }
        private void drawRect(int x, int y, int height, int weight, Graphics gr, Pen pen, MouseEventArgs e)
        {
            Rectangle rec = new Rectangle(x, y, weight, height);
            if (recta)
            {
                gr.Clear(Color.LightSteelBlue);
                gr.DrawLine(Pens.Red, new Point(0, e.Y), e.Location);
                gr.DrawLine(Pens.Red, new Point(e.X, 0), e.Location);
                gr.DrawLine(Pens.Red, new Point(Screen.PrimaryScreen.Bounds.Width, e.Y), e.Location);
                gr.DrawLine(Pens.Red, new Point(e.X, Screen.PrimaryScreen.Bounds.Height), e.Location);

                gr.DrawRectangle(pen, rec);//

            }
        }
        private void TakeAreaWindows_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;  //
            recta = true;   //кнопка нажата
        }

        private void TakeAreaWindows_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.Location; //записываем положение мыши (правый нижний угол прямоугольника)
            recta = false;  // отжата

            if (end != start)
            {
                if (end.X > start.X && end.Y < start.Y)//правый верхний
                {
                    Point sstart = new Point(start.X, end.Y);
                    Size screenShotSize = new System.Drawing.Size(end.X - start.X, start.Y - end.Y);
                    ReturnRectangle = new Rectangle(sstart, screenShotSize);
                }

                if (end.Y < start.Y && end.X < start.X)//левый верхний
                {

                    Point sstart = new Point(end.X, end.Y);
                    Size screenShotSize = new Size(start.X - end.X, start.Y - end.Y);
                    ReturnRectangle = new Rectangle(sstart, screenShotSize);
                }

                if (end.Y > start.Y && end.X < start.X)
                {
                    Point sstart = new Point(end.X, start.Y);
                    Size screenShotSize = new Size(start.X - end.X, end.Y - start.Y);
                    ReturnRectangle = new Rectangle(sstart, screenShotSize);
                }
                if (start.X < end.X && start.Y < end.Y)
                {
                    Point sstart = new Point(start.X, start.Y);
                    Size screenShotSize = new Size(end.X - start.X, end.Y - start.Y);
                    ReturnRectangle = new Rectangle(sstart, screenShotSize);
                }

                // Program.forma.screenShotSize = new Size(Math.Abs(Program.forma.start.X - Program.forma.end.X), Math.Abs(Program.forma.start.Y - Program.forma.end.Y)); //создаем размеры этого прямоугольника
            }



        }

        private void TakeAreaWindows_MouseMove(object sender, MouseEventArgs e)
        {
            if (recta) end = e.Location;
            Pen pen = Pens.Blue;
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.LightSteelBlue);
            gr.DrawLine(Pens.Red, new Point(0, e.Y), e.Location);
            gr.DrawLine(Pens.Red, new Point(e.X, 0), e.Location);
            gr.DrawLine(Pens.Red, new Point(Screen.PrimaryScreen.Bounds.Width, e.Y), e.Location);
            gr.DrawLine(Pens.Red, new Point(e.X, Screen.PrimaryScreen.Bounds.Height), e.Location);


            // при джижении мыши чертим прямоугольник 
            if (e.Location != start)
            {

                if (end.X > start.X && end.Y < start.Y)//правый верхний
                {
                    drawRect(start.X, end.Y, start.Y - end.Y, end.X - start.X, gr, pen, e);
                }

                if (end.Y < start.Y && end.X < start.X)//левый верхний
                {

                    drawRect(end.X, end.Y, start.Y - end.Y, start.X - end.X, gr, pen, e);
                }

                if (end.Y > start.Y && end.X < start.X)
                {

                    drawRect(end.X, start.Y, end.Y - start.Y, start.X - end.X, gr, pen, e);
                }
                if (start.X < end.X && start.Y < end.Y)
                {
                    drawRect(start.X, start.Y, end.Y - start.Y, end.X - start.X, gr, pen, e);
                }

            }


        }

        private void TakeAreaWindows_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void TakeAreaWindows_MouseMove_1(object sender, MouseEventArgs e)
        {
            TakeAreaWindows_MouseMove(sender, e);
        }

        private void TakeAreaWindows_Load(object sender, EventArgs e)
        {

        }
    }
}
