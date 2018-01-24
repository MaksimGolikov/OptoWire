using OpticalWire.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalWire.Logic
{
    class GraphicsBuilder
    {

        public GraphicsBuilder()
        {

        }



        public GraphicDescription CreateNewGraphics(int angle,List<double> points,Color graphicsColor)
        {
            GraphicDescription newGraphics = new GraphicDescription(angle.ToString(),points);
            newGraphics.GraphicsColor = graphicsColor;

            return newGraphics;
        }
        public GraphicDescription CreateNewGraphics(string name, GraphicDescription graphicParametr, Color graphicsColor)
        {
            GraphicDescription newGraphics = new GraphicDescription(name);
            newGraphics.GraphicsInfluence.Position = graphicParametr.GraphicsInfluence.Position;
            newGraphics.GraphicsInfluence.Parametrs = graphicParametr.GraphicsInfluence.Parametrs;
            newGraphics.GraphicsColor = graphicsColor;

            return newGraphics;
        }

        public Color GetFreeColor(List<GraphicDescription> createdGraphics, List<Color> allColors)
        {
            Color freeColor = Color.Black;
            List<Color> usedColor = new List<Color>();

            foreach (var itm in createdGraphics)
            {
                usedColor.Add(itm.GraphicsColor);
            }

            
            foreach (var item in allColors)
            {
                var shouldUseColor = true;
                foreach (var itm in usedColor)
                {
                    if (itm == item)
                    {
                        shouldUseColor = false;
                    }                   
                }
                if (shouldUseColor)
                {
                    freeColor = item;
                    break;
                }
            }
            return freeColor;
        }

    }
}
