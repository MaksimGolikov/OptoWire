using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpticalWire.Storage;
using OpticalWire.Logic;
using System.Drawing;
using OpticalWire.Logic.ImageFiltr;

namespace OpticalWire.Presenter
{
    class LoadImageFormPresenter
    {

        private Storage.Storage storage;
        private ConfigFile configFile;        
        private CalculateImageParams calculateParams;
        private WriteToFile writer;
        private LoadImageForm formWindow;

        private string incorrectCharacter = " ,.!@#$%^&*()_-+=<>";
        private string erroreMessage;


        public LoadImageFormPresenter(LoadImageForm form)
        {          
            
            calculateParams = new CalculateImageParams();
            writer = new WriteToFile();

            formWindow = form;
            erroreMessage = "";
        }

        public string GetErroreMessage()
        {
            var temp = erroreMessage;
            erroreMessage = "";
            return temp;
        }
        


        public string GetCurrentLanguage()
        {
            storage.Language = configFile.Language;               
           
            return storage.Language;
        }
        public void SaveSelectedArea(Image image, Bitmap bitmap, int startPositionX, int startPositionY)
        {
            SaveImageObject imgObject = new SaveImageObject();
            imgObject.loadedImage = image;
            imgObject.selectedArea = bitmap;

            imgObject.areaStartPosition = new Point(startPositionX, startPositionY);

            imgObject.filtredImage = bitmap.KirschFilter(false);

            storage.selectedAreaOfImage = imgObject;
        }
        
        public string PreparationSelectedImage()
        {
            string statusAction = "OK";


            if (storage.selectedAreaOfImage != null)
            {
                storage.selectedAreaOfImage.brightness = calculateParams.GetBrightness(storage.selectedAreaOfImage.selectedArea);
                storage.selectedAreaOfImage.normalizedBrightness = calculateParams.Normalization(storage.selectedAreaOfImage.brightness,
                                                                                                 storage.selectedAreaOfImage.selectedArea.Width,
                                                                                                 storage.selectedAreaOfImage.selectedArea.Height);
                storage.selectedAreaOfImage.borderImageFigureCoordinat = calculateParams.FindeBorderCoordinats(storage.selectedAreaOfImage.brightness,
                                                                                                               storage.selectedAreaOfImage.selectedArea.Width,
                                                                                                               storage.selectedAreaOfImage.selectedArea.Height);
                storage.selectedAreaOfImage.middlePointOfArea = calculateParams.MiddlePointOfArea;

               var allDiametr =  calculateParams.GetDiametr(0,
                                                            360,
                                                            storage.selectedAreaOfImage.borderImageFigureCoordinat,
                                                            storage.selectedAreaOfImage.loadedImage,                                                            
                                                            storage.selectedAreaOfImage.middlePointOfArea,
                                                            false);

                storage.AllDiametrs = allDiametr;
                storage.MaxIntensity = calculateParams.MaxIntensity;
                storage.MaxDiametr = calculateParams.MaxDiametr;
                storage.MaxAngle = calculateParams.MaxAngle;



                writer.WriteBrightnessToFile(storage.selectedAreaOfImage.brightness,
                                             storage.selectedAreaOfImage.selectedArea.Width,
                                             storage.selectedAreaOfImage.selectedArea.Height);
            }
            else
            {
                statusAction = "Errore";
                erroreMessage = "You dont select any picture";
                formWindow.ShowMessage(erroreMessage);
            }
           


            //  writer.wr(storage.selectedAreaOfImage.borderImageFigureCoordinat);
            

            return statusAction;
        }

        public void LounchHelper()
        {
            System.Diagnostics.Process.Start("Helper.exe");
        }










        private bool IsLineCorrect(string line)
        {
            var returnStatus = true;

            if (line == "" || line == null)
            {
                returnStatus = false;
            }

            if (returnStatus)
            {
                foreach (char c in incorrectCharacter)
                {
                    if (line == c.ToString())
                    {
                        returnStatus = false;
                        break;
                    }
                }
            }

            return returnStatus;


        }
        



        public void SetConfig(ConfigFile newConfig)
        {
            this.configFile = newConfig;
        }
        public void SetStorage(Storage.Storage newStorage)
        {
            this.storage = newStorage;
        }
        public ConfigFile GetConfig()
        {
            return configFile;
        }
        public Storage.Storage GetStorage()
        {
            return storage;
        }






    }
}
