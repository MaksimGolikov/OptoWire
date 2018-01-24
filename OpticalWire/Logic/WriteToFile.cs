using OpticalWire.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;



namespace OpticalWire.Logic
{
    class WriteToFile
    {
        public WriteToFile()
        {

        }


        public void WriteBrightnessToFile(double[,] brightness,int widthMass,int heightMass)
        {
            StreamWriter writer = new StreamWriter("Brighntess.txt");
          
            for (int i=0;i<heightMass;i++)
            {
                string line = "";
                for (int j=0;j<widthMass;j++)
                {
                    line +=" "+ brightness[j,i].ToString();
                }
                writer.WriteLine(line);
            }
            writer.Close();


        }
        
        
        public void WriteToExcel(List<GraphicDescription> allIntensityGraphics, GraphicDescription allAngleDiametrGraphic,GraphicDescription temperaturegraphic)
        {
            Excel.Application ObjExcel = new Excel.Application();
            Excel.Workbook ObjWorkBook;
            Excel.Worksheet ObjWorkSheet;
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];
            
            ObjWorkSheet.Cells[1, 1] = "Intensity graphics";
            var step = 0;
            for (int i=0;i< allIntensityGraphics.Count;i++)
            {
                
                ObjWorkSheet.Cells[2+step, 1] = allIntensityGraphics[i].GraphicsName;
                ObjWorkSheet.Cells[3 + step, 2] = "Angle:";
                ObjWorkSheet.Cells[4 + step, 2] = "Intensity:";               
                for (int j = 0; j < allIntensityGraphics[i].GraphicsPoints.Count; j++)
                {
                    ObjWorkSheet.Cells[3 + step, 3 + j] = j;
                    ObjWorkSheet.Cells[4 + step, 3 + j] = allIntensityGraphics[i].GraphicsPoints[j];
                }
                step += 3;
            }

            step += 2;

            ObjWorkSheet.Cells[4 + step, 1] = "Diametr graphic";
            ObjWorkSheet.Cells[5 + step, 1] = "Angle:";
            ObjWorkSheet.Cells[6 + step, 1] = "Diametr:";
            for (int i = 0; i < allAngleDiametrGraphic.GraphicsInfluence.Parametrs.Count; i++)
            {
                ObjWorkSheet.Cells[5 + step, 2 + i] = allAngleDiametrGraphic.GraphicsInfluence.Position[i];
                ObjWorkSheet.Cells[6 + step, 2 + i] = allAngleDiametrGraphic.GraphicsInfluence.Parametrs[i];
            }

            step += 5;
            ObjWorkSheet.Cells[2 + step, 1] = "Temperature graphic";
            ObjWorkSheet.Cells[3 + step, 1] = "Angle:";
            ObjWorkSheet.Cells[4 + step, 1] = "Value:";
            for (int i = 0; i < temperaturegraphic.GraphicsInfluence.Parametrs.Count; i++)
            {
                ObjWorkSheet.Cells[3 + step, 2 + i] = allAngleDiametrGraphic.GraphicsInfluence.Position[i];
                ObjWorkSheet.Cells[4 + step, 2 + i] = allAngleDiametrGraphic.GraphicsInfluence.Parametrs[i];
            }


            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;

        }

    }
}
