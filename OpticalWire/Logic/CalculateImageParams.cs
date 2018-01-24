using OpticalWire.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalWire.Logic
{
    class CalculateImageParams
    {
        private Point middlePointOfArea;
        public Point MiddlePointOfArea { get => middlePointOfArea; }
        public double MaxIntensity { get; private set; }
        public double MaxDiametr { get; private set; }
        public int MaxAngle { get; private set; }


        public CalculateImageParams()
        {
            middlePointOfArea = new Point(0,0);
        }

     

        public double[,] GetBrightness(Bitmap bitmap)
        {
            if (bitmap.Width % 2 == 0)
            {
                middlePointOfArea.X = bitmap.Width / 2;
            }
            else {
                middlePointOfArea.X = bitmap.Width / 2 + 1;
            }
            if (bitmap.Height % 2 == 0)
            {
                middlePointOfArea.Y = bitmap.Height / 2;
            }
            else {
                middlePointOfArea.Y = bitmap.Height / 2 + 1;
            }
            
            double[,] brightness = new double[bitmap.Width, bitmap.Height];      
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var color = bitmap.GetPixel(i, j);
                    brightness[i, j] = 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;
                }
            }
            return brightness;
        }             
        public double[,]  Normalization(double[,] brightness, int widthMass,int heightMass)
        {
            double[,] normBrightness = new double[widthMass, heightMass];
            double prom = 0;
            double middlePointBrightness = brightness[middlePointOfArea.X, middlePointOfArea.Y];
            MaxIntensity = middlePointBrightness;

            for (int i = 0; i < widthMass; i++)
            {
                for (int j = 0; j < heightMass; j++)
                {
                    prom = brightness[i, j];
                    if (prom != 0)
                    {
                        normBrightness[i, j] = prom / middlePointBrightness;
                    }
                }
            }
            return normBrightness;
        }              

        public List<Point> FindeBorderCoordinats(double[,] brightness, int widthMass, int heightMass)
        {
            var bordersPosition = new List<Point>();

            for (int i=1;i<widthMass-1;i++)
            {
                for(int j=1;j<heightMass-1;j++)
                {
                    if (CheckPoint(brightness, i, j))
                    {
                        bordersPosition.Add(new Point(i, j));
                    }                   
                }
            }

            return bordersPosition;

        }
        public List<double> GetPointsAtAngle(List<Point> borderLocation, Image imageWithAngle,Image originalImage, double[,] brightness)
        {
            List<double> returnedPoints = new List<double>();
            var startPoint = new Point(0, 0);
            var endPoint = new Point(0, 0);
            Bitmap image = new Bitmap(imageWithAngle);
            Bitmap orginal = new Bitmap(originalImage);

            var pixel = GetBrightness(image);

            foreach (var point in borderLocation)
            {               
                var pixelOriginal = brightness[point.X, point.Y];

                if (pixel[point.X, point.Y] != pixelOriginal)
                {
                    if (startPoint.X+startPoint.Y == 0)
                    {
                        startPoint = point;
                    }
                    else
                    {
                        endPoint = point;                        
                    }
                }
            }

            var min = 0;
            var max = 0;
            var findeByX = true;

            if (Math.Abs(startPoint.X-endPoint.X)> Math.Abs(startPoint.Y - endPoint.Y))
            {
                if (startPoint.X < endPoint.X)
                {
                    min = startPoint.X;
                    max = endPoint.X;
                }
                else
                {
                    min = endPoint.X;
                    max = startPoint.X;
                }
            }
            else
            {
                findeByX = false;
                if (startPoint.Y < endPoint.Y)
                {
                    min = startPoint.Y;
                    max = endPoint.Y;
                }
                else
                {
                    min = endPoint.Y;
                    max = startPoint.Y;
                }
            }
            

            var koefficientX = endPoint.Y - startPoint.Y;
            var koefficientY = endPoint.X - startPoint.X;

            if (findeByX)
            {
                for (int i = min + 1; i < max; i++)
                {
                    var point = new Point(i,
                                          ((koefficientX * (i - startPoint.X) + koefficientY * startPoint.Y) / koefficientY));
                    returnedPoints.Add(brightness[point.X, point.Y]);
                }
            }
            else
            {
                for (int i = min + 1; i < max; i++)
                {
                    var point = new Point( ((koefficientY * (i - startPoint.Y) + koefficientX * startPoint.X) / koefficientX),
                                            i);
                    returnedPoints.Add(brightness[point.X, point.Y]);
                }
            }

            return returnedPoints;
        }
        public GraphicDescription GetDiametr(int fromAngle, int toAngle, List<Point> borderLocation,Image image, Point middlePoint, bool ShouldNormalise)
        {
            var returnedValue = new GraphicDescription("From " + fromAngle + " to " + toAngle);
            returnedValue.GraphicsColor = Color.Blue;
                      
            List<double> parametrs = new List<double>();
            List<int> position = new List<int>();
            var max = 0.0;

            for (int angle = fromAngle; angle <= toAngle; angle++)
            {           
                var diametr = GetDiametrAtAngle(angle, borderLocation, image.Size, middlePoint);
                parametrs.Add(diametr);
                position.Add(angle);

                if (diametr > max)
                {
                    max = diametr;
                    MaxAngle = angle;
                }
            }

            MaxDiametr = max;

            if (ShouldNormalise)
            {
                for (int i = 0; i < parametrs.Count; i++)
                {
                    parametrs[i] = parametrs[i] / max;
                }
            }           


            returnedValue.GraphicsInfluence.Parametrs = parametrs;
            returnedValue.GraphicsInfluence.Position = position;

            return returnedValue;
        }
        public GraphicDescription GetDiametr(int fromAngle, int toAngle, GraphicDescription allDiametrs, bool ShouldNormalise)
        {
            var returnedValue = new GraphicDescription("From " + fromAngle + " to " + toAngle);
            returnedValue.GraphicsColor = Color.Blue;

            List<double> parametrs = new List<double>();
            List<int> position = new List<int>();
            var max = 0.0;

            for (int angle = fromAngle; angle <= toAngle; angle++)
            {               
                var diametr = Diametr(angle, allDiametrs);
                parametrs.Add(diametr);
                position.Add(angle);

                if (diametr > max)
                {
                    max = diametr;
                    MaxAngle = angle;
                }
            }            
            if (ShouldNormalise)
            {
                for (int i = 0; i < parametrs.Count; i++)
                {
                    parametrs[i] = parametrs[i] / max;
                }
            }
            returnedValue.GraphicsInfluence.Parametrs = parametrs;
            returnedValue.GraphicsInfluence.Position = position;

            return returnedValue;
        }

        public double Diametr(int angle,GraphicDescription allDiametrs)
        {
            var diametr = 0.0;
            for (int i=0;i<allDiametrs.GraphicsInfluence.Parametrs.Count;i++)
            {
                if (allDiametrs.GraphicsInfluence.Position[i] == angle)
                {
                    diametr = allDiametrs.GraphicsInfluence.Parametrs[i];
                    break;
                }
            }
            return diametr;
        }
        public double Assimetry(List<double> brightnessAtAngle)
        {
            var delta = new List<double>();
            var middleValue = 0.0;
            var sum = 0.0;
            var MSD = 0.0;

            foreach (var item in brightnessAtAngle)
            {
                middleValue += item;
            }
            middleValue = middleValue / brightnessAtAngle.Count;

            foreach (var item in brightnessAtAngle)
            {
                var deltaAtDegree = Math.Pow((item - middleValue), 3);
                sum += deltaAtDegree;
                MSD += Math.Pow((item - middleValue), 2);
                delta.Add(deltaAtDegree);
            }
            MSD = Math.Sqrt(MSD / brightnessAtAngle.Count);
            var assimetry = (sum / delta.Count) / (Math.Pow(MSD, 3));

            return assimetry;
        }
        public double Excess(List<double> brightnessAtAngle)
        {
            var delta = new List<double>();
            var middleValue = 0.0;
            var sum = 0.0;
            var MSD = 0.0;

            foreach (var item in brightnessAtAngle)
            {
                middleValue += item;
            }
            middleValue = middleValue / brightnessAtAngle.Count;

            foreach (var item in brightnessAtAngle)
            {
                var deltaAtDegree = Math.Pow((item - middleValue), 4);
                sum += deltaAtDegree;
                MSD += Math.Pow((item - middleValue), 2);
                delta.Add(deltaAtDegree);
            }
            MSD = Math.Sqrt(MSD / brightnessAtAngle.Count);
            var excess = (sum / delta.Count) / (Math.Pow(MSD, 4));

            return excess;
        }

        public GraphicDescription GetTemperatureInfluence(int fromValue,int toValue,double widthWall, double coefficientOut,double coefficientIn)
        {
            var graphic = new GraphicDescription(" ");
            var points = new List<double>();
            var position = new List<int>();


            for (int i=fromValue; i<=toValue;i++)
            {
                var calculate = (4*widthWall * Math.Sqrt(Math.Pow(coefficientOut,2) - Math.Pow(coefficientIn, 2)) ) / (2*i+1);
                points.Add(calculate);
                position.Add(i);
            }
            graphic.GraphicsInfluence.Position = position;
            graphic.GraphicsInfluence.Parametrs = points;

            return graphic;
        }
        
       

        private double GetDiametrAtAngle(int angle, List<Point> borderLocation,Size imageSize, Point middlePoint)
        {
            var diametr = 0.0;

            var startPoint = new Point();
            var endPoint = new Point();

            var nesossaryAngle = angle * Math.PI / 180;
            var Radius = 0.0;
            if (angle != 90 && angle != 270)
            {
                Radius = (imageSize.Width / 2) / Math.Cos(nesossaryAngle);
            }
            else
            {
                Radius = imageSize.Height / 2;
            }
            startPoint.X = middlePoint.X + Convert.ToInt32(Radius * Math.Cos(nesossaryAngle));
            startPoint.Y = middlePoint.Y - Convert.ToInt32(Radius * Math.Sin(nesossaryAngle));

            endPoint.X = middlePoint.X - Convert.ToInt32(Radius * Math.Cos(nesossaryAngle));
            endPoint.Y = middlePoint.Y + Convert.ToInt32(Radius * Math.Sin(nesossaryAngle));

            var min = 0;
            var max = 0;
            var findeByX = true;
            if (Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                if (startPoint.X < endPoint.X)
                {
                    min = startPoint.X;
                    max = endPoint.X;
                }
                else
                {
                    min = endPoint.X;
                    max = startPoint.X;
                }
            }
            else
            {
                findeByX = false;
                if (startPoint.Y < endPoint.Y)
                {
                    min = startPoint.Y;
                    max = endPoint.Y;
                }
                else
                {
                    min = endPoint.Y;
                    max = startPoint.Y;
                }
            }
            var koefficientX = endPoint.Y - startPoint.Y;
            var koefficientY = endPoint.X - startPoint.X;
            var allPointAtAngle = new List<Point>();
            if (findeByX)
            {
                for (int i = min + 1; i < max; i++)
                {
                    var point = new Point(i,
                                          ((koefficientX * (i - startPoint.X) + koefficientY * startPoint.Y) / koefficientY));
                    allPointAtAngle.Add(point);
                }
            }
            else
            {
                for (int i = min + 1; i < max; i++)
                {
                    var point = new Point(((koefficientY * (i - startPoint.Y) + koefficientX * startPoint.X) / koefficientX),
                                            i);
                    allPointAtAngle.Add(point);
                }
            }

            var firstPoint = new Point();
            var secondPoint = new Point();
           
            for (int bPoint = 0;bPoint<borderLocation.Count;bPoint++)
            {
                for(int aPoint = 0; aPoint<allPointAtAngle.Count;aPoint++)
                {
                    if (borderLocation[bPoint] == allPointAtAngle[aPoint])
                    {
                        if (firstPoint.X==0)
                        {
                            firstPoint = allPointAtAngle[aPoint];
                        }
                        else
                        {
                            secondPoint = allPointAtAngle[aPoint];
                        }                                       
                    }
                }              
            }
          
          
            diametr = Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2));


            return diametr;
        }        
        private bool CheckPoint(double[,] mass, int xPosition, int yPosition)
        {
            var answer = false;

            if (mass[xPosition, yPosition] != 0 )
            {
                if (mass[xPosition +1, yPosition] == 0 || mass[xPosition, yPosition - 1] == 0 ||
                    mass[xPosition - 1, yPosition] == 0 || mass[xPosition, yPosition + 1] == 0)
                {
                    answer = true;
                }
            }
            return answer;
        }       
      
    }
}
