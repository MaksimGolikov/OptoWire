using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticalWire.Logic
{
    class WorkWithImage
    {

        public WorkWithImage()
        {

        }


        public Image GetImageWithAngle(int angleForCalculate, Image fonImage, Point middleOfImage)
        {
            var tmpPictureBox = new PictureBox();
            tmpPictureBox.Image = fonImage;

            var endPoint = new Point();
            var startPoint = new Point();


            double nesossaryAngle = angleForCalculate * Math.PI / 180;                 
            double Radius=0.0;
            if (angleForCalculate!=90 && angleForCalculate != 270)
            {
                Radius = (fonImage.Size.Width / 2) / Math.Cos(nesossaryAngle);
            }
            else
            {               
                Radius = fonImage.Size.Height / 2;
            }
            

            startPoint.X = middleOfImage.X + Convert.ToInt32(Radius * Math.Cos(nesossaryAngle));
            startPoint.Y = middleOfImage.Y - Convert.ToInt32(Radius * Math.Sin(nesossaryAngle));
           
            endPoint.X = middleOfImage.X- Convert.ToInt32(Radius * Math.Cos(nesossaryAngle));
            endPoint.Y = middleOfImage.Y + Convert.ToInt32(Radius * Math.Sin(nesossaryAngle));

           
            Graphics g = tmpPictureBox.CreateGraphics();
            g = Graphics.FromImage(fonImage);
            Pen pen = new Pen(Color.Blue, 3.0f);
            g.DrawLine(pen,startPoint,endPoint);
            g.Dispose();

            return fonImage;

        }


        public Image GetImageWithDrawedBorder( Image fonImage,List<Point> border)
        {
            var tmpPictureBox = new PictureBox();
            tmpPictureBox.Image = fonImage;

           

            Graphics g = tmpPictureBox.CreateGraphics();
            g = Graphics.FromImage(fonImage);
            Pen pen = new Pen(Color.Brown, 3.0f);
            for (int i=0;i<border.Count;i++)
            {
                g.DrawEllipse(pen,new RectangleF(border[i].X, border[i].Y, 1,1));                
            }           
            g.Dispose();

            return fonImage;
        }

        public Image GetImageMix(Image borderImage, int angleForCalculate, Point middleOfImage)
        {
            var tmpPictureBox = new PictureBox();
            tmpPictureBox.Image = borderImage;

            var endPoint = new Point();
            var startPoint = new Point();


            double nesossaryAngle = angleForCalculate * Math.PI / 180;
            double Radius = borderImage.Size.Width / 2;


            startPoint.X = middleOfImage.X + Convert.ToInt32(Radius * Math.Cos(nesossaryAngle));
            startPoint.Y = middleOfImage.Y - Convert.ToInt32(Radius * Math.Sin(nesossaryAngle));

            endPoint.X = middleOfImage.X - Convert.ToInt32(Radius * Math.Cos(nesossaryAngle));
            endPoint.Y = middleOfImage.Y + Convert.ToInt32(Radius * Math.Sin(nesossaryAngle));


            Graphics g = tmpPictureBox.CreateGraphics();
            g = Graphics.FromImage(borderImage);
            Pen pen = new Pen(Color.Blue, 3.0f);
            g.DrawLine(pen, startPoint, endPoint);
            g.Dispose();

            return borderImage;
        }

    }
}
