using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalWire.Storage
{
    class GraphicDescription
    {
        private Color graphicsColor;
        private string graphicsName;
        private List<double> graphicsPoints;
        private GraphicsType graphicsInfluence;



        public Color GraphicsColor { get => graphicsColor; set => graphicsColor = value; }
        public string GraphicsName { get => graphicsName; }
        public List<double> GraphicsPoints { get => graphicsPoints; }
        public GraphicsType GraphicsInfluence { get => graphicsInfluence; set => graphicsInfluence = value; }

        public GraphicDescription(string name, List<double> points)
        {
            graphicsName = name;
            graphicsPoints = points;
            graphicsInfluence = new GraphicsType();
        }
        public GraphicDescription(string name)
        {
            graphicsName = name;
            graphicsInfluence = new GraphicsType();
        }

    }
}
