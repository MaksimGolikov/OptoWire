using OpticalWire.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalWire.Logic
{
    class Filters
    {
        private int stepMedianFiltr;
        private int stepMovingAverage;

        public Filters(int stepMedianFiltr, int stepMovingAverage)
        {
            this.stepMedianFiltr = stepMedianFiltr;
            this.stepMovingAverage = stepMovingAverage;
        }


        public GraphicDescription MedianFiltr(GraphicDescription graphics)
        {
            var correctCoordinats = new List<double>();
            var windows = new List<double>();


            for (int i=0; i<graphics.GraphicsInfluence.Parametrs.Count;i++)
            {
                if (windows.Count< stepMedianFiltr)
                {
                    windows.Add(graphics.GraphicsInfluence.Parametrs[i]);
                }
                else 
                {
                    var withoutSort = new List<double>();
                    withoutSort.AddRange(windows);

                    windows.Sort();
                    var middle = stepMedianFiltr / 2;
                    correctCoordinats.Add(windows[middle]);

                    windows = withoutSort;
                    windows.RemoveAt(0);                    
                }
            }

            GraphicDescription changedGraphics = new GraphicDescription(graphics.GraphicsName);
            changedGraphics.GraphicsColor = graphics.GraphicsColor;
            changedGraphics.GraphicsInfluence.Position = graphics.GraphicsInfluence.Position;
            changedGraphics.GraphicsInfluence.Parametrs = correctCoordinats;

            return changedGraphics;
        }

        public GraphicDescription MovingAverageFiltr(GraphicDescription graphics)
        {
            var correctCoordinats = new List<double>();
            var windows = new List<double>();

            var max = 0.0;
            for (int i = 0; i < graphics.GraphicsInfluence.Parametrs.Count; i++)
            {
                if (windows.Count < stepMedianFiltr)
                {
                    windows.Add(graphics.GraphicsInfluence.Parametrs[i]);
                    max += graphics.GraphicsInfluence.Parametrs[i];
                }
                else
                {                      
                    correctCoordinats.Add( max/stepMovingAverage );
                    max -= windows[0];
                    windows.RemoveAt(0);
                }
            }

            GraphicDescription changedGraphics = new GraphicDescription(graphics.GraphicsName);
            changedGraphics.GraphicsColor = graphics.GraphicsColor;
            changedGraphics.GraphicsInfluence.Position = graphics.GraphicsInfluence.Position;
            changedGraphics.GraphicsInfluence.Parametrs = correctCoordinats;

            return changedGraphics;
        }



    }
}
