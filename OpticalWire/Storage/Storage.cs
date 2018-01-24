using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalWire.Storage
{
    class Storage
    {

        public string Language { get; set; }
        public List<Color> Colors = new List<Color>() {Color.Red,
                                                       Color.Green,
                                                       Color.Yellow,
                                                       Color.Blue,
                                                       Color.Orange};
        public List<string> Filtres = new List<string>(){"NON",
                                                         "Median",
                                                         "MovingAverage"};


        public SaveImageObject selectedAreaOfImage { get; set; }
        public Image ImageWithAngle { get; set; }
        public int currentAngle { get; set; }

        public double MaxIntensity { get; set; }
        public double MaxDiametr { get; set; }
        public int MaxAngle { get; set; }

        public List<GraphicDescription> IntensityGraphics {get;set;}
        public List<GraphicDescription> ShownIntensityGraphics { get; set; }
        public GraphicDescription AllDiametrs { get; set; }
        public GraphicDescription CurrentDiametrsGraphic { get; set; }
        public GraphicDescription TemperatureInfluenceGraphic { get; set; }



        public Storage()
        {
            IntensityGraphics = new List<GraphicDescription>();
        }
    }
}
