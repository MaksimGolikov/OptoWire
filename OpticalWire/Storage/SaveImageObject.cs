using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalWire.Storage
{
    class SaveImageObject
    {


        public Image loadedImage { get; set; }
        public Bitmap selectedArea { get; set; }


        public Bitmap filtredImage { get; set; }
        public Image filtredImageWithAngle { get; set; }

        public int widthArea { get; set; }
        public int heightAsrea { get; set; }



        public List<Point> borderImageFigureCoordinat { get; set; }

        public double[,] brightness { get; set; }
        public double[,] normalizedBrightness { get; set; }
        public Point  middlePointOfArea { get; set; }


        public Point areaStartPosition { get; set; } // x,y
      

        public SaveImageObject()
        {
                  
        }

    }
}
