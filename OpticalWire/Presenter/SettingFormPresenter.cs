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
    class SettingFormPresenter
    {

        private Storage.Storage storage;
        private ConfigFile configFile;       
                      
        private string erroreMessage;

        SettingsForm formWindows;


        public SettingFormPresenter(Storage.Storage existStorage,
                                    ConfigFile cnfFile,
                                    SettingsForm form)
        {
            this.formWindows = form;
            storage = existStorage;
            configFile = cnfFile;
            erroreMessage = "";
        }

       


        public string GetCurrentLanguage()
        {            
           storage.Language = configFile.Language;
           
           return storage.Language;
        }
        public void SetParametr(int idLang,string newStepMedian, string newStepAvarage)
        {
            var medianStep = 0;
            var avarageStep = 0;

            var avarageCorrent = Int32.TryParse(newStepAvarage,out avarageStep);
            var medianCorrect= Int32.TryParse(newStepMedian, out medianStep);

            if ( avarageCorrent && medianCorrect && medianStep > 1 && avarageStep > 1 )
            {
                configFile.SetConfigFile(idLang, medianStep, avarageStep);
            }
            else
            {
                if (!avarageCorrent)
                {
                    erroreMessage = "Value of avarage step incorret";
                }
                else if (!medianCorrect)
                {
                    erroreMessage = "Value of median step incorret";
                }               
                formWindows.ShowMessage(erroreMessage);
            }
                      
        }
        public void SetParametr(string Lang, string newStepMedian, string newStepAvarage)
        {
            var medianStep = 0;
            var avarageStep = 0;

            var avarageCorrent = Int32.TryParse(newStepAvarage, out avarageStep);
            var medianCorrect = Int32.TryParse(newStepMedian, out medianStep);

            var Langs = configFile.ExistLanguags;
            var idLang = 0;
            for (int i=0;i<Langs.Count;i++)
            {
                if (Lang == Langs[i])
                {
                    idLang = i;
                    break;
                }
            }

            if (avarageCorrent && medianCorrect && medianStep > 1 && avarageStep > 1)
            {
                configFile.SetConfigFile(idLang, medianStep, avarageStep);
                formWindows.ShowMessage("Done. pleace reload");
            }
            
            else
            {
                if (!avarageCorrent)
                {
                    erroreMessage = "Value of avarage step incorret";
                }
                else if (!medianCorrect)
                {
                    erroreMessage = "Value of median step incorret";
                }
                formWindows.ShowMessage(erroreMessage);
            }

        }

        public List<string> GetExistLanguage()
        {
           return configFile.ExistLanguags;
        }
        public string GetStepMedian()
        {
            return configFile.StepMedianFiltr.ToString();
        }
        public string GetStepAvarage()
        {
            return configFile.StepMovingAverage.ToString();
        }


    }
}
