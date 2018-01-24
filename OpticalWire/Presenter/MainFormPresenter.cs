using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpticalWire.Storage;
using OpticalWire.Logic;
using System.Drawing;
using OpticalWire.Forms;

namespace OpticalWire.Presenter
{
    class MainFormPresenter
    {

        private Storage.Storage storage;
        private ConfigFile configFile;        
        private CalculateImageParams calculateParams;
        private WriteToFile writer;
        private WorkWithImage workWithImage;
        private GraphicsBuilder graphicBuilder;
        private Filters filtres;

        private MainForm formWindow;
               
        private string erroreMessage;


        public MainFormPresenter(MainForm form)
        {           
            storage = new Storage.Storage();
            configFile = new ConfigFile();
            calculateParams = new CalculateImageParams();
            writer = new WriteToFile();
            workWithImage = new WorkWithImage();
            graphicBuilder = new GraphicsBuilder();

            configFile.ReadConfigFile();
            filtres = new Filters(configFile.StepMedianFiltr,configFile.StepMovingAverage);

            formWindow = form;
            erroreMessage = "";
        }




        public string GetCurrentLanguage()
        {
            var status = configFile.ExistLanguags.Count;

            if (status != 0)
            {
                storage.Language = configFile.Language;
            }
            else
            {
                storage.Language = "en";
            }           

            return storage.Language;
        }
        public void GetSelectedImage()
        {
            if (storage.selectedAreaOfImage != null)
            {
                formWindow.SetSelectedArea( storage.selectedAreaOfImage.loadedImage);               
            }           
        }
        public void GetMaxParameters()
        {
            if (storage.selectedAreaOfImage != null)
            {
                formWindow.SetMaxParameters(storage.MaxIntensity,
                                            storage.MaxDiametr,
                                            storage.MaxAngle);
            }   
        }




        public void BuildAngle(int angle)
        {
            if (storage.selectedAreaOfImage != null)
            {
                var imageForDrawingAngle = new Bitmap(storage.selectedAreaOfImage.loadedImage); 
                var FiltredimageForDrawingAngle = new Bitmap(storage.selectedAreaOfImage.filtredImage);
                var imageWithAngle = workWithImage.GetImageWithAngle(angle,
                                                                     imageForDrawingAngle,
                                                                     storage.selectedAreaOfImage.middlePointOfArea);
                var FiltredimageWithAngle = workWithImage.GetImageWithAngle(angle,
                                                                     FiltredimageForDrawingAngle,
                                                                     storage.selectedAreaOfImage.middlePointOfArea);
               

                storage.ImageWithAngle = imageWithAngle;
                storage.selectedAreaOfImage.filtredImageWithAngle = FiltredimageWithAngle;

                storage.currentAngle = angle;
                formWindow.SetSelectedArea(imageWithAngle);
            }            
            else
            {
                erroreMessage = "You don`t load image";
                formWindow.ShowMessage(erroreMessage);
            }

            
        }
        public void CreateGraphic()
        {
            if (storage.selectedAreaOfImage != null && storage.ImageWithAngle != null && storage.IntensityGraphics.Count < 6)
            {                               
                storage.IntensityGraphics.Add((graphicBuilder.CreateNewGraphics(storage.currentAngle,
                                                                                calculateParams.GetPointsAtAngle(storage.selectedAreaOfImage.borderImageFigureCoordinat,
                                                                                                                 storage.ImageWithAngle,
                                                                                                                 storage.selectedAreaOfImage.loadedImage,
                                                                                                                 storage.selectedAreaOfImage.brightness),
                                                                                graphicBuilder.GetFreeColor(storage.IntensityGraphics,
                                                                                                            storage.Colors))));

                storage.ShownIntensityGraphics = new List<GraphicDescription>();                
                storage.ShownIntensityGraphics.AddRange(storage.IntensityGraphics);
                
                formWindow.ShowIntensityGraphics(storage.ShownIntensityGraphics);
                formWindow.SetValueIntensityComboBox(storage.IntensityGraphics);
            }
            else
            {
                if (storage.selectedAreaOfImage == null)
                {
                    erroreMessage = "You don`t load image";
                }
                else if (storage.ImageWithAngle == null)
                {
                    erroreMessage = "You don`t draw any angle";
                }
                else
                {
                    erroreMessage = "You can`t create more then 6 graphics";
                }
                formWindow.ShowMessage(erroreMessage);
            }
        }
        public void DeleteIntensityAll()
        {
            if (storage.selectedAreaOfImage != null)
            {
                storage.IntensityGraphics.Clear();
                storage.ShownIntensityGraphics.Clear();


                formWindow.ShowIntensityGraphics(storage.ShownIntensityGraphics);
                formWindow.SetValueIntensityComboBox(storage.IntensityGraphics);
                formWindow.SetCurrentParametrs(0,0,0);
            }
            else
            {
                erroreMessage = "You don`t load image";
                formWindow.ShowMessage(erroreMessage);
            }
           
        }
        public void DeleteIntensity(string nameGraphics)
        {
            if (storage.selectedAreaOfImage != null)
            {
                var idGraphics = -1;
                for (int i=0;i< storage.IntensityGraphics.Count;i++)
                {
                    if (storage.IntensityGraphics[i].GraphicsName == nameGraphics)
                    {
                        idGraphics = i;
                        break;
                    }
                }

                if (idGraphics>=0 && idGraphics<6)
                {
                    storage.IntensityGraphics.RemoveAt(idGraphics);
                    storage.ShownIntensityGraphics = storage.IntensityGraphics;

                  
                    formWindow.ShowIntensityGraphics(storage.ShownIntensityGraphics);
                    formWindow.SetValueIntensityComboBox(storage.IntensityGraphics);
                }
                else
                {
                    erroreMessage = "Graphics with this name absent";
                    formWindow.ShowMessage(erroreMessage);
                }

            }
            else
            {
                erroreMessage = "You don`t load image";
                formWindow.ShowMessage(erroreMessage);
            }
        }



        public void Hide(string nameGraphics)
        {
            if (storage.selectedAreaOfImage != null)
            {
                var idGraphics = -1;
                for (int i = 0; i < storage.ShownIntensityGraphics.Count; i++)
                {
                    if (storage.ShownIntensityGraphics[i].GraphicsName == nameGraphics)
                    {
                        idGraphics = i;
                        break;
                    }
                }

                if (idGraphics >= 0 && idGraphics < 6)
                {
                  
                    storage.ShownIntensityGraphics.RemoveAt(idGraphics);                   
                    formWindow.ShowIntensityGraphics(storage.ShownIntensityGraphics);
                    formWindow.SetValueIntensityComboBox(storage.IntensityGraphics);
                }
            }
            else
            {
                erroreMessage = "You don`t load image";
                formWindow.ShowMessage(erroreMessage);
            }
        }
        public void Show(string nameGraphics)
        {
            if (storage.selectedAreaOfImage != null)
            {
                var idGraphics = -1;
                for (int i = 0; i < storage.IntensityGraphics.Count; i++)
                {
                    if (storage.IntensityGraphics[i].GraphicsName == nameGraphics)
                    {
                        idGraphics = i;
                        break;
                    }
                }

                if (idGraphics >= 0 && idGraphics < 6)
                {
                    if (!storage.ShownIntensityGraphics.Exists(x=>x.GraphicsName == storage.IntensityGraphics[idGraphics].GraphicsName) )
                    {
                        storage.ShownIntensityGraphics.Add(storage.IntensityGraphics[idGraphics]);
                    }

                    
                    formWindow.ShowIntensityGraphics(storage.ShownIntensityGraphics);
                    formWindow.SetValueIntensityComboBox(storage.IntensityGraphics);
                }
            }
            else
            {
                erroreMessage = "You don`t load image";
                formWindow.ShowMessage(erroreMessage);
            }
        }


        public void BuildDiametr(int fromAngle,int toAngle,bool shouldNodmalise)
        {
            if (storage.selectedAreaOfImage != null)
            {               
                var diametr = calculateParams.GetDiametr(fromAngle,
                                                         toAngle,
                                                         storage.AllDiametrs,
                                                         shouldNodmalise);
                storage.CurrentDiametrsGraphic = diametr;
                formWindow.ShowDiametrGraphics(diametr);
            }
            else
            {
                if (storage.selectedAreaOfImage == null)
                {
                    erroreMessage = "You don`t load image";
                }                            
                formWindow.ShowMessage(erroreMessage);
            }
        }
        public void BuildDiametr(bool shouldNodmalise)
        {
            if (storage.selectedAreaOfImage != null)
            {
                var diametr = calculateParams.GetDiametr(0,
                                                         360,
                                                         storage.AllDiametrs,
                                                         shouldNodmalise);
                storage.CurrentDiametrsGraphic = diametr;
                formWindow.ShowDiametrGraphics(diametr);
            }
            else
            {
                if (storage.selectedAreaOfImage == null)
                {
                    erroreMessage = "You don`t load image";
                }               
                formWindow.ShowMessage(erroreMessage);
            }
        }
        public void Description(string nameGraphics)
        {
            if (storage.selectedAreaOfImage != null)
            {
                var idGraphics = -1;
                for (int i = 0; i < storage.IntensityGraphics.Count; i++)
                {
                    if (storage.IntensityGraphics[i].GraphicsName == nameGraphics)
                    {
                        idGraphics = i;
                        break;
                    }
                }

                if (idGraphics >= 0 && idGraphics < 6)
                {
                    var diametr = calculateParams.Diametr(Int32.Parse(nameGraphics),
                                                          storage.AllDiametrs);

                    var assimetry = calculateParams.Assimetry(storage.IntensityGraphics[idGraphics].GraphicsPoints);
                    var excess = calculateParams.Excess(storage.IntensityGraphics[idGraphics].GraphicsPoints);

                    formWindow.SetCurrentParametrs(diametr,assimetry,excess);
                }
            }
            else
            {
                erroreMessage = "You don`t load image";
                formWindow.ShowMessage(erroreMessage);
            }
        }
         
        
        public void Filtr(int idFiltr)
        {
            if (storage.selectedAreaOfImage != null && storage.CurrentDiametrsGraphic != null && idFiltr >= 0 && idFiltr < storage.Filtres.Count)
            {
                var filtrName = storage.Filtres[idFiltr];

                var filtredGraphics = new GraphicDescription("");
                if (filtrName == "Median")
                {
                    filtredGraphics = filtres.MedianFiltr(storage.CurrentDiametrsGraphic);
                }
                if (filtrName == "MovingAverage")
                {
                    filtredGraphics = filtres.MovingAverageFiltr(storage.CurrentDiametrsGraphic);
                }
                if (filtrName == "NON")
                {
                    formWindow.ShowDiametrGraphics(storage.CurrentDiametrsGraphic);
                }
                formWindow.ShowDiametrGraphics(filtredGraphics);               
            }
            else
            {
                if (storage.CurrentDiametrsGraphic == null)
                {
                    erroreMessage = "You didn't build any graphic of diameter";
                }
                if (idFiltr < 0 || idFiltr > storage.Filtres.Count)
                {
                    erroreMessage = "Filtr not exist";
                }
                else
                {
                    erroreMessage = "You don`t load image";
                }
                formWindow.ShowMessage(erroreMessage);
            }
        }
        public void GetListOfExistFiltrs()
        {
           formWindow.SetValueFiltrComboBox(storage.Filtres);
        }


        public void GetTemperatureInfluence(int fromValue,int toValue,string widthwall,string coefficientout,string coeffisientin)
        {
            var widthWall = 0.0;
            var coefficientOut = 0.0;
            var coeffisientIn = 0.0;

            var widthOk = Double.TryParse(widthwall, out widthWall);
            var outOk = Double.TryParse(coefficientout, out coefficientOut);
            var inOk = Double.TryParse(coeffisientin, out coeffisientIn);


            if (widthOk && outOk && inOk &&
                fromValue >= 0 && fromValue < toValue && toValue > 0 && fromValue < toValue && widthWall > 0 &&
                coefficientOut>0 && coeffisientIn>0 && coeffisientIn !=coefficientOut)
            {
                var graphic = graphicBuilder.CreateNewGraphics("Temperature influence",
                                                               calculateParams.GetTemperatureInfluence(fromValue,
                                                                                                       toValue,
                                                                                                       widthWall,
                                                                                                       coefficientOut,
                                                                                                       coeffisientIn),
                                                               graphicBuilder.GetFreeColor(storage.IntensityGraphics,
                                                                                           storage.Colors));
                formWindow.BuildTemperatureInfluence(graphic);
            }
            else
            {

                if (fromValue < 0 || fromValue > toValue)
                {
                    erroreMessage = "Incorrect value 'from'";
                }
                if (toValue < 0 || fromValue > toValue)
                {
                    erroreMessage = "Incorrect value 'to'";
                }
                if (!widthOk || widthWall < 0)
                {
                    erroreMessage = "Incorrect value 'width wall'";
                }
                if (!outOk || coefficientOut < 0)
                {
                    erroreMessage = "Incorrect value 'coefficient Out'";
                }
                if (!inOk || coeffisientIn < 0)
                {
                    erroreMessage = "Incorrect value 'coefficient In'";
                }
                if (coeffisientIn == coefficientOut)
                {
                    erroreMessage = "Incorrect 'coefficient In' can`t be equal 'coefficient Out'";
                }
                formWindow.ShowMessage(erroreMessage);
            }
        }
        public void GetTemperatureInfluence(string widthwall, string coefficientout, string coeffisientin)
        {
            var widthWall = 0.0;
            var coefficientOut = 0.0;
            var coeffisientIn = 0.0;

            var widthOk = Double.TryParse(widthwall, out widthWall);
            var outOk = Double.TryParse(coefficientout, out coefficientOut);
            var inOk = Double.TryParse(coeffisientin, out coeffisientIn);


            if (widthOk && outOk && inOk &&
                widthWall > 0 && coefficientOut > 0 && coeffisientIn > 0 && coeffisientIn != coefficientOut)
            {
                var graphic = graphicBuilder.CreateNewGraphics("Temperature influence",
                                                               calculateParams.GetTemperatureInfluence(0,
                                                                                                       360,
                                                                                                       widthWall,
                                                                                                       coefficientOut,
                                                                                                       coeffisientIn),
                                                               graphicBuilder.GetFreeColor(storage.IntensityGraphics,
                                                                                           storage.Colors));
                storage.TemperatureInfluenceGraphic = graphic;
                formWindow.BuildTemperatureInfluence(graphic);
            }
            else
            {                               
                if (!widthOk || widthWall < 0)
                {
                    erroreMessage = "Incorrect value 'width wall'";
                }
                if (!outOk || coefficientOut < 0)
                {
                    erroreMessage = "Incorrect value 'coefficient Out'";
                }
                if (!inOk || coeffisientIn < 0)
                {
                    erroreMessage = "Incorrect value 'coefficient In'";
                }
                if (coeffisientIn == coefficientOut)
                {
                    erroreMessage = "Incorrect 'coefficient In' can`t be equal 'coefficient Out'";
                }
                formWindow.ShowMessage(erroreMessage);
            }
        }



        public void WriteToExcel()
        {
            if (storage.selectedAreaOfImage != null && storage.CurrentDiametrsGraphic != null && storage.TemperatureInfluenceGraphic!=null)
            {
                writer.WriteToExcel(storage.IntensityGraphics,
                                    calculateParams.GetDiametr(0,
                                                               360,
                                                               storage.AllDiametrs,
                                                               false),
                                    storage.TemperatureInfluenceGraphic);
                erroreMessage = "File created";
                formWindow.ShowMessage(erroreMessage);
            }
            else
            {

                if (storage.selectedAreaOfImage == null)
                {
                    erroreMessage = "You don`t load image";
                }
                if (storage.CurrentDiametrsGraphic == null)
                {
                    erroreMessage = "You don`t build any diametr graphic";
                }
                if (storage.TemperatureInfluenceGraphic ==null)
                {
                    erroreMessage = "You don`t build temperature influence";
                }
                formWindow.ShowMessage(erroreMessage);
            }
        }
        public void ClearGraphics()
        {
            var  graphic = new List<GraphicDescription>() { new GraphicDescription("")};           

            formWindow.BuildTemperatureInfluence(graphic[0]);
            formWindow.ShowDiametrGraphics(graphic[0]);
            formWindow.ShowIntensityGraphics(graphic);
        }

        public ConfigFile GetConfig()
        {
            return configFile;
        }
        public Storage.Storage GetStorage()
        {
            return storage;
        }



        public void ShowBoarder()
        {        
            Image bmp = new Bitmap(storage.selectedAreaOfImage.loadedImage);
            var img = workWithImage.GetImageMix(workWithImage.GetImageWithDrawedBorder(bmp, storage.selectedAreaOfImage.borderImageFigureCoordinat),
                                                storage.currentAngle,
                                                storage.selectedAreaOfImage.middlePointOfArea );  

            formWindow.SetSelectedArea(img);
        }
        
        public void LounchHelper()
        {
            System.Diagnostics.Process.Start("Helper.exe");
        }

    }
}
