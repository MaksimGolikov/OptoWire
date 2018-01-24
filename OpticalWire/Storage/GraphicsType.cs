using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalWire.Storage
{
    class GraphicsType
    {
        List<double> parametrs;
        List<int> position;

        public List<double> Parametrs { get => parametrs; set => parametrs = value; }
        public List<int> Position { get => position; set => position = value; }

        public GraphicsType()
        {
            parametrs = new List<double>();
            position = new List<int>();
        }
    }
}
