using OpticalWire.Logic;
using OpticalWire.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticalWire.Forms
{
    partial class SettingsForm : Form
    {
        Presenter.SettingFormPresenter presenter;
        
        public SettingsForm(Storage.Storage existStorage,
                            ConfigFile cnfFile)
        {
            InitializeComponent();

            Init(existStorage, cnfFile);
        }


        private void bnAppliedChange_Click(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedIndex != -1)
            {
                presenter.SetParametr(cbLanguage.SelectedIndex,tbStepMedian.Text,tbStepAvarage.Text);
            }

            this.Close();
        }
        private void bnChangeStep_Click(object sender, EventArgs e)
        {
            presenter.SetParametr(presenter.GetCurrentLanguage(), tbStepMedian.Text, tbStepAvarage.Text);
        }






        private void Init(Storage.Storage existStorage,
                          ConfigFile cnfFile)
        {
            presenter = new Presenter.SettingFormPresenter(existStorage,
                                                           cnfFile,
                                                           this);
            SetLanguage(typeof(LoadImageForm), presenter.GetCurrentLanguage());

            cbLanguage.DataSource = null;
            cbLanguage.Items.Clear();
            cbLanguage.DataSource = presenter.GetExistLanguage();
            cbLanguage.SelectedIndex = -1;

            tbStepAvarage.Text = presenter.GetStepAvarage();
            tbStepMedian.Text = presenter.GetStepMedian();
        }


        public void SetLanguage(Type type, string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

            this.Text = Settings.FormText;

            foreach (var item in this.Controls)
            {
                if (item is Button) { ((Button)item).Text = LocalizatedName(((Button)item).Name); }
                if (item is Label) { ((Label)item).Text = LocalizatedName(((Label)item).Name); }
            }

            lbLanguage.Text = Settings.lbLanguage;
            bnAppliedChange.Text = Settings.bnAppliedChange;
        }
        private string LocalizatedName(string name)
        {
            string localizName = Resource.Settings.ResourceManager.GetString(name);
            return localizName;
        }

        public void ShowMessage(string text)
        {
            if (text !="")
            {
                MessageBox.Show(text);
            }
        }

      
    }
}
