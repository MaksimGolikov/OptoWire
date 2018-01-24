using OpticalWire.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpticalWire.Forms;
using System.Threading;
using System.Globalization;
using OpticalWire.Resource;
using OpticalWire.Storage;
using ZedGraph;
using form = System.Windows.Forms;

namespace OpticalWire.Forms
{
    partial class MainForm : Form
    {
        Presenter.MainFormPresenter presenter;
        int currentAngle;

        string TitleZGintensity;
        string YZGIntensity;
        string XZGintensity;

        string TitleZGDiametr;
        string YZGDiametr;
        string XZGDiametr;

        string TitleZGtemperture;
        string YZGtemperture;
        string XZGtemperture;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }



        #region Menu
      
        private void Loadlmagems_Click(object sender, EventArgs e)
        {           
            LoadImageForm loadImageForm = new LoadImageForm(presenter.GetStorage(), presenter.GetConfig());
            loadImageForm.ShowDialog();
            presenter.GetSelectedImage();
            presenter.GetMaxParameters();
        }

        private void loadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadImageForm loadImageForm = new LoadImageForm(presenter.GetStorage(), presenter.GetConfig());
            loadImageForm.ShowDialog();
            presenter.GetSelectedImage();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsForm settingForm = new SettingsForm(presenter.GetStorage(), presenter.GetConfig());
            settingForm.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {           
            presenter.LounchHelper();
        }



        #endregion

        #region Angle


        private void chb0_CheckedChanged(object sender, EventArgs e)
        {            
            chb45.Checked = false;
            chb90.Checked = false;
            currentAngle = 0;
        }
        private void chb45_CheckedChanged(object sender, EventArgs e)
        {
            chb0.Checked = false;
            chb90.Checked = false;
            currentAngle = 45;
        }
        private void chb90_CheckedChanged(object sender, EventArgs e)
        {            
            chb45.Checked = false;
            chb0.Checked = false;
            currentAngle = 90;
        }
        private void numericFreeAngle_ValueChanged(object sender, EventArgs e)
        {
            chb90.Checked = false;
            chb45.Checked = false;
            chb0.Checked = false;
            currentAngle = (int)numericFreeAngle.Value;
        }


        private void bnHideGraphic_Click(object sender, EventArgs e)
        {
            if(cbExistIntenistyGraphics.SelectedItem !=null)
            {
                presenter.Hide(cbExistIntenistyGraphics.SelectedItem.ToString());
            }
           
        }

        private void bnShowGraphic_Click(object sender, EventArgs e)
        {
            if (cbExistIntenistyGraphics.SelectedItem != null)
            {
                presenter.Show(cbExistIntenistyGraphics.SelectedItem.ToString());
            }
        }

        private void bnRemoveFromgraphic_Click(object sender, EventArgs e)
        {
            if (cbExistIntenistyGraphics.SelectedItem !=null)
            {
                presenter.DeleteIntensity(cbExistIntenistyGraphics.SelectedItem.ToString());
            }           
        }

        private void bnRemoveAll_Click(object sender, EventArgs e)
        {
            presenter.DeleteIntensityAll();
        }

        private void bnDrawAngle_Click(object sender, EventArgs e)
        {
            presenter.BuildAngle(currentAngle);
        }

        private void bnClear_Click(object sender, EventArgs e)
        {
            presenter.GetSelectedImage();
        }

        private void bnAddIntensityOngraphic_Click(object sender, EventArgs e)
        {
            presenter.CreateGraphic();
        }
        #endregion

        #region Parametric of graphics

        private void cbAllExistGraphics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAllExistGraphics.SelectedItem != null)
            {
                presenter.Description(cbAllExistGraphics.SelectedItem.ToString());
            }
        }       

        #endregion
        
        #region Diametr

        private void bnBuildDiametr_Click(object sender, EventArgs e)
        {
            presenter.BuildDiametr((int)numericFromDiametr.Value,(int)numericToDiametr.Value,chBShouldNormalise.Checked);
        }

        private void bnBuildAllDiametr_Click(object sender, EventArgs e)
        {
            presenter.BuildDiametr(chBShouldNormalise.Checked);
        }
        #endregion

        #region Filtrs

        private void bnAppliedFiltr_Click(object sender, EventArgs e)
        {                        
            presenter.Filtr(cbFiltr.SelectedIndex);
        }

        #endregion

        #region Influence by temperature

        private void bnBuildSelectinfluence_Click(object sender, EventArgs e)
        {
            presenter.GetTemperatureInfluence((int)numericFromInfluence.Value,(int)numericToInfluence.Value,
                                              tbWidthWall.Text,tbCorfficientOut.Text,tbCorfficientIn.Text);
        }

        private void bnBuildAllInfluence_Click(object sender, EventArgs e)
        {
            presenter.GetTemperatureInfluence(tbWidthWall.Text, tbCorfficientOut.Text, tbCorfficientIn.Text);
        }

        #endregion

        #region Work with graphics

        private void bnWriteToExcel_Click(object sender, EventArgs e)
        {
            presenter.WriteToExcel();
        }

        private void bnClearGraphic_Click(object sender, EventArgs e)
        {
            presenter.ClearGraphics();
        }

        #endregion


        #region Start config 


        private void Init()
        {
            presenter = new Presenter.MainFormPresenter(this);
            SetLanguage(typeof(LoadImageForm), presenter.GetCurrentLanguage());

            presenter.GetListOfExistFiltrs();
        }


        public void SetLanguage(Type type, string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(type);

            string f = Resource.MainForm.FormText;
            this.Text = Resource.MainForm.FormText;

            foreach (var item in this.Controls)
            {
                if (item is Button) { ((Button)item).Text = LocalizatedName(((Button)item).Name); }
                if (item is form.Label) { ((form.Label)item).Text = LocalizatedName(((form.Label)item).Name); }                
                if(item is GroupBox)
                {
                    ((GroupBox)item).Text = LocalizatedName(((GroupBox)item).Name);
                    foreach (var itm in ((GroupBox)item).Controls)
                    {
                        if (itm is Button) { ((Button)itm).Text = LocalizatedName(((Button)itm).Name); }
                        if (itm is form.Label) { ((form.Label)itm).Text = LocalizatedName(((form.Label)itm).Name); }
                        if (itm is CheckBox) { ((CheckBox)itm).Text = LocalizatedName(((CheckBox)itm).Name); }
                    }
                }
            }            

            foreach (ToolStripItem item in msTopMenu.Items)
            {

                if (item is ToolStripDropDownItem)
                    foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)item).DropDownItems)
                    {
                        dropDownItem.Text = LocalizatedMenuName(dropDownItem.Name);
                    }
                item.Text = LocalizatedMenuName(item.Name);
            }


            TitleZGintensity = LocalizatedName("ZGintencityTop");
            XZGintensity =    LocalizatedName("ZGintencityX");
            YZGIntensity =    LocalizatedName("ZGintencityY");

            TitleZGDiametr = LocalizatedName("ZGDiametrTop");
            YZGDiametr = LocalizatedName("ZGDiametrX"); ;
            XZGDiametr = LocalizatedName("ZGDiametrY");

            TitleZGtemperture= LocalizatedName("ZGTemperatureTopic");
            YZGtemperture= LocalizatedName("ZGTemperatureY");
            XZGtemperture= LocalizatedName("ZGTemperatureX");

        }
        private string LocalizatedName(string name)
        {
            string localizName = Resource.MainForm.ResourceManager.GetString(name);
            return localizName;
        }
        private string LocalizatedMenuName(string name)
        {
            string localizName = Resource.MenuStrip.ResourceManager.GetString(name);
            return localizName;
        }


        #endregion
        
       


        public void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }
        public void SetSelectedArea(Image imageArea)
        {
            if (pbShowAngle.Image != null)
            {
                pbShowAngle.Image = null;
            }
            pbShowAngle.Image = imageArea;
        }
        public void SetMaxParameters(double intensity,double diametr,int angle)
        {
            if (intensity>0 && diametr >0)
            {
                lbMaxDiametrValue.Text = diametr.ToString();
                lbMaxintensityValue.Text = intensity.ToString();
                lbAnglemaxDaimetrValue.Text = angle.ToString();
            }
            
        }
       
        public void SetCurrentParametrs(double diametr,double assimerty, double excess)
        {
            tbAssimetry.Text = assimerty.ToString();
            tbDiam.Text = diametr.ToString();
            tbExcess.Text = excess.ToString();
        }

        public void ShowIntensityGraphics(List<GraphicDescription> graphics)
        {
            GraphPane pane = ZGIntensity.GraphPane;
            pane.CurveList.Clear();           

            foreach (var item in graphics)
            {

                PointPairList list = new PointPairList();
                if(item.GraphicsPoints.Count > 0)
                for (int itm=0; itm<item.GraphicsPoints.Count;itm++)
                {
                    list.Add(itm,item.GraphicsPoints[itm]);
                }

                LineItem myCurve = pane.AddCurve(item.GraphicsName, list,item.GraphicsColor , SymbolType.Diamond);
            }


            pane.Title.Text = TitleZGintensity;
            pane.XAxis.Title.Text = XZGintensity;
            pane.YAxis.Title.Text = YZGIntensity;

            ZGIntensity.AxisChange();
            ZGIntensity.Invalidate();
            
        }
        public void SetValueIntensityComboBox(List<GraphicDescription> graphics)
        {
            if (cbExistIntenistyGraphics.Items != null)
            {
                cbExistIntenistyGraphics.DataSource = null;
                cbExistIntenistyGraphics.Items.Clear();
                cbAllExistGraphics.DataSource = null;
                cbAllExistGraphics.Items.Clear();
            }
            var nameGraphics = new List<string>();
            foreach (var item in graphics)
            {
                nameGraphics.Add(item.GraphicsName);
            }
            cbExistIntenistyGraphics.DataSource = nameGraphics;
            cbAllExistGraphics.DataSource = nameGraphics;
        }

        public void ShowDiametrGraphics(GraphicDescription graphic)
        {
            GraphPane pane = ZGDiametr.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            for (int i=0; i<graphic.GraphicsInfluence.Parametrs.Count;i++)
            {
              list.Add(graphic.GraphicsInfluence.Position[i], graphic.GraphicsInfluence.Parametrs[i]);
            }
            LineItem myCurve = pane.AddCurve(graphic.GraphicsName, list, graphic.GraphicsColor, SymbolType.Diamond);

            pane.Title.Text = TitleZGDiametr;
            pane.XAxis.Title.Text = XZGDiametr;
            pane.YAxis.Title.Text = YZGDiametr;

            ZGDiametr.PerformAutoScale();
            ZGDiametr.AxisChange();
            ZGDiametr.Invalidate();

        }

        public void SetValueFiltrComboBox(List<string> existFiltrs)
        {
            if (cbFiltr.Items!=null)
            {
                cbFiltr.DataSource = null;
                cbFiltr.Items.Clear();
            }

            var filtrName = new List<string>();
            foreach (var item in existFiltrs)
            {
                filtrName.Add(Filtrs.ResourceManager.GetString(item));
            }

            cbFiltr.DataSource = filtrName;

        }

        public void BuildTemperatureInfluence(GraphicDescription graphic)
        {
            GraphPane pane = ZGTemperature.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            for (int i = 0; i < graphic.GraphicsInfluence.Parametrs.Count; i++)
            {
                list.Add(graphic.GraphicsInfluence.Position[i], graphic.GraphicsInfluence.Parametrs[i]);
            }
            LineItem myCurve = pane.AddCurve(graphic.GraphicsName, list, graphic.GraphicsColor, SymbolType.Diamond);

           
            pane.Title.Text = TitleZGtemperture;
            pane.XAxis.Title.Text = XZGtemperture;
            pane.YAxis.Title.Text = YZGtemperture;

            ZGTemperature.PerformAutoScale();
            ZGTemperature.AxisChange();
            ZGTemperature.Invalidate();
        }

    }
}
