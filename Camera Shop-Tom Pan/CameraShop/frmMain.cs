using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace CameraShop
{   //Tom-Pan :Main form of WinForm, to list brands, and able to get access to next form which is frmBrand
    public sealed partial class frmMain : Form
    {   
        private static readonly frmMain _Instance = new frmMain();

        public delegate void Notify(string prCamSName);

        public event Notify CameraShopNameChanged;

        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        private void updateTitle(string prCamSName)
        {
            if (!string.IsNullOrEmpty(prCamSName))
                Text = "Camera Shop " + prCamSName;
        }

        public async void UpdateDisplay()
        {
            lstBrands.DataSource = null;
            Debug.Print("Called Service Getbrandnamesasync");
            lstBrands.DataSource = await ServiceClient.GetBrandNamesAsync();
            Debug.Print("Should have got camera brands list..");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrand.Run(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new brand");
            }
        }

        private void lstBrands_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstBrands.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmBrand.Run(lcKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCamSName_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
