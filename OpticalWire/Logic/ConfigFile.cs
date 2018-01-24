using OpticalWire.Resource;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpticalWire.Logic
{
    class ConfigFile
    {
        private string language;
        private List<string> existLanguags;
        private List<string> langKey;
        private int stepMovingAverage;
        private int stepMedianFiltr;


        public string Language { get => language; }
        public List<string> ExistLanguags { get => existLanguags; }
        public int StepMovingAverage { get => stepMovingAverage; }
        public int StepMedianFiltr { get => stepMedianFiltr;}



        public ConfigFile()
        {
            existLanguags = new List<string>();
            langKey = new List<string>();
        }


        public string ReadConfigFile()
        {
            string returnedStatus = "OK";

            if (File.Exists("config.config"))
            {
                StreamReader reader = new StreamReader("config.config");
                string line;

                while ((line = reader.ReadLine())!=null)
                {
                    var mass = line.Split(':');

                    if (mass[0]== "Lang")
                    {
                        language = mass[1];
                    }
                    else if (mass[0] == "Languages")
                    {
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                        for (int i=1;i<mass.Length;i++)
                        {
                            langKey.Add(mass[i]);
                            existLanguags.Add(SetImage.ResourceManager.GetString(mass[i]));
                        }                        
                    }
                    else if (mass[0] == "stepMovingAverage")
                    {
                        var done = Int32.TryParse(mass[1],out stepMovingAverage);
                        if (!done)
                        {
                            stepMovingAverage = 3;
                        }
                    }
                    else if (mass[0] == "stepMedianFiltr")
                    {
                        var done = Int32.TryParse(mass[1], out stepMedianFiltr);
                        if (!done)
                        {
                            stepMedianFiltr = 3;
                        }
                    }

                }

                reader.Close();
            }
            else
            {
                returnedStatus = "Can`t finde config file";
            }


            return returnedStatus;
        }

        public string SetConfigFile(int newLang, int newStepMedianFiltr, int newStepMovingAverage)
        {
            string returnedStatus = "OK";
            bool reWrite = false;
            string lang = "";
            if (newLang != -1)
            {
                lang = langKey[newLang];
            }



            if (File.Exists("config.config"))
            {
                StreamWriter writer = new StreamWriter("config.config",reWrite,Encoding.Default);
                writer.WriteLine("Lang:"+ lang);
                string lin = "Languages";
                foreach (var item in langKey)
                {
                    lin += ":" + item;
                }
                writer.WriteLine(lin);
                writer.WriteLine("stepMedianFiltr:"+ newStepMedianFiltr);
                writer.WriteLine("stepMovingAverage:" + newStepMovingAverage);


                writer.Close();
            }
            else
            {
                returnedStatus = "Can`t finde config file";
            }


            return returnedStatus;
        }



    }
}
