using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;

using OpticalWire.Resource;
using OpticalWire.Presenter;
using System.Runtime.InteropServices;
using OpticalWire.Forms;
using OpticalWire.Logic;

namespace OpticalWire
{
    partial class LoadImageForm : Form
    {

        LoadImageFormPresenter presenter;

        PictureBox areaBorder;
        Bitmap bmp;
        private int begin_x;
        private int begin_y;
        bool resize;


        public LoadImageForm(Storage.Storage storage, ConfigFile configFile)
        {
            InitializeComponent();
            Init(storage,configFile);
        }


        #region Events

        #region Top menu

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           // openFileDialog1.InitialDirectory = "c:\\";
            ofd.Title = "select necessary image";
            ofd.Filter = " (*.png)|*.png| (*.bmp)|*.bmp";
            ofd.Multiselect = false;

            if ((ofd.ShowDialog() == DialogResult.OK))
            {
                pbLoadImage.ImageLocation = ofd.FileName;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingForm = new SettingsForm(presenter.GetStorage(), presenter.GetConfig());
            settingForm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.LounchHelper();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Create selected Area

        [DllImport("user32.dll")]
        public static extern int SendMessage(
            int hWnd,      // handle to destination window
            uint Msg,       // message
            long wParam,  // first message parameter
            long lParam   // second message parameter
       );

       


        private void pbLoadImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                begin_x = e.X;
                begin_y = e.Y;
                areaBorder.Left = e.X;
                areaBorder.Top = e.Y;
                areaBorder.Width = 0;
                areaBorder.Height = 0;
                areaBorder.Visible = true;
                resize = true;
            }
        }
        private void pbLoadImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                areaBorder.Width = e.X - begin_x;
                areaBorder.Height = e.Y - begin_y;
            }
        }
        private void pbLoadImage_MouseUp(object sender, MouseEventArgs e)
        {

            areaBorder.Width = 0;
            areaBorder.Height = 0;
            areaBorder.Visible = false;


            if (resize == true)
            {
                if ((e.X > begin_x + 10) && (e.Y > begin_y))
                {
                    Rectangle rec = new Rectangle(begin_x, begin_y, e.X - begin_x, e.Y - begin_y);
                    pbSelectedArea.Image = CopyImage(pbLoadImage.Image, rec);
                    bmp = new Bitmap(pbSelectedArea.Image, new Size(rec.Width, rec.Height));

                    presenter.SaveSelectedArea(CopyImage(pbLoadImage.Image, rec),
                                               CopyBitmap(pbLoadImage.Image, rec),
                                               begin_x,
                                               begin_y);


                    // obmp.GetBrightness(bmp);

                    //#region Set getting values to baseElement values

                    ////Image
                    //baseElement.SizeOfbrightnessMass_width = obmp.SizeMassOfBrightness[0, 1];
                    //baseElement.SizeOfbrightnessMass_height = obmp.SizeMassOfBrightness[0, 0];                   
                    //baseElement.borderOfBMP = rec;
                    //baseElement.middlePoint[0] = obmp.middle_X;
                    //baseElement.middlePoint[1] = obmp.middle_Y;
                    ////Brightness
                    //baseElement.OdinaryBrightness = obmp.brightness;
                    //baseElement.MiddleBrightness = obmp.normBrightness;
                    //#endregion
                }
            }
            resize = false;

        }


        static public Image CopyImage(Image srcBitmap, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }

            return bmp;
        }
        static public Bitmap CopyBitmap(Image srcBitmap, Rectangle section)
        {            
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            }            
            return bmp;
        }


        #endregion


        private void bnSelectImage_Click(object sender, EventArgs e)
        {

            var status = presenter.PreparationSelectedImage();

            if (status == "OK")
            {
                this.Close();
            }           

        }

        private void cbZoom_CheckedChanged(object sender, EventArgs e)
        {

        }

      
        #endregion

        public void ShowMessage(string textMessage)
        {
            MessageBox.Show(textMessage);
        }

       


        #region Start Config

        private void Init(Storage.Storage storage, ConfigFile configFile)
        {
            presenter = new LoadImageFormPresenter(this);
            presenter.SetConfig(configFile);
            presenter.SetStorage(storage);
            SetLanguage(typeof(LoadImageForm), presenter.GetCurrentLanguage());

            ImagePanel.AutoScroll = true;
            pbLoadImage.SizeMode = PictureBoxSizeMode.AutoSize;


            areaBorder = new PictureBox();
            areaBorder.Parent = pbLoadImage;            
            areaBorder.BackColor = Color.Transparent;
            areaBorder.SizeMode = PictureBoxSizeMode.AutoSize;
            areaBorder.BorderStyle = BorderStyle.FixedSingle;
            areaBorder.Visible = false;
            resize = false;
        }


        public void SetLanguage(Type type, string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

            this.Text = SetImage.FormText;
            lbSelectedArea.Text = SetImage.SelectedArea;
            cbZoom.Text = SetImage.Zoom;
            bnSelectImage.Text = SetImage.Select;


            ComponentResourceManager resources = new ComponentResourceManager(type);
            foreach (ToolStripItem item in msTopMenu.Items)
            {

                if (item is ToolStripDropDownItem)
                    foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)item).DropDownItems)
                    {
                        dropDownItem.Text = LocalizatedName(dropDownItem.Name);
                    }
                item.Text = LocalizatedName(item.Name);
            }
        }
        private string LocalizatedName(string name)
        {
            string localizName = Resource.MenuStrip.ResourceManager.GetString(name);
            return localizName;
        }







        #endregion

      
    }
}
