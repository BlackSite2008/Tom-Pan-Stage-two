using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CameraShop
{   //Tom-Pan :edit and add each brand, and list cameras of each specific brand, able to take us to form where add cameras
    public partial class frmBrand : Form
    {
        private clsBrand _Brand;

        private static Dictionary<string, frmBrand> _BrandFormList =
            new Dictionary<string, frmBrand>();

        public frmBrand()
        {
            InitializeComponent();
        }

        public static void Run(string prBrandName)
        {
            frmBrand lcBrandForm;

            if (string.IsNullOrEmpty(prBrandName) ||

            !_BrandFormList.TryGetValue(prBrandName, out lcBrandForm))

            {
                lcBrandForm = new frmBrand();

                if (string.IsNullOrEmpty(prBrandName))
                    lcBrandForm.SetDetails(new clsBrand());
                else
                {
                    _BrandFormList.Add(prBrandName, lcBrandForm);
                    lcBrandForm.refreshFormFromDB(prBrandName);
                }
            }
            else
            {
                lcBrandForm.Show();
                lcBrandForm.Activate();
            }            
        }

        private async void refreshFormFromDB(string prBrandName)
        {
            SetDetails(await ServiceClient.GetBrandAsync(prBrandName));
        }

        private void updateTitle(string prCamSName)
        {
            if (!string.IsNullOrEmpty(prCamSName))
                Text = "Brand Details - " + prCamSName;
        }

        private void UpdateDisplay()
        {
            listCameras.DataSource = null;
            if (_Brand.CamerasList != null)
                listCameras.DataSource = _Brand.CamerasList;
                listCameras.ValueMember = "Camera_ID";
                listCameras.DisplayMember = "_DisplayMember";            
        }

        public void UpdateForm()
        {           
            txtBrand_Name.Text = _Brand.Brand_Name;
            txtBrand_ID.Text = _Brand.Brand_ID;
            txtBrand_Descrip.Text = _Brand.Brand_Descrip;            
        }

        public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;
            txtBrand_Name.Enabled = string.IsNullOrEmpty(_Brand.Brand_Name);
            UpdateForm();
            UpdateDisplay();
            frmMain.Instance.CameraShopNameChanged += new frmMain.Notify(updateTitle);
            Show();
        }

        private void pushData()
        {            
            _Brand.Brand_Name = txtBrand_Name.Text;
            _Brand.Brand_ID = txtBrand_ID.Text;
            _Brand.Brand_Descrip = txtBrand_Descrip.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNUType NUCamera = new frmNUType();
            NUCamera.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = listCameras.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting camera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
        }

        private async void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtBrand_Name.Enabled)

                    {
                        MessageBox.Show(await ServiceClient.InsertBrandAsync(_Brand));

                        frmMain.Instance.UpdateDisplay();

                        txtBrand_Name.Enabled = false;
                    }

                    else
                        MessageBox.Show(await ServiceClient.UpdateBrandAsync(_Brand));
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private Boolean isValid()
        {
                return true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbByID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void listCameras_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmBrand.Run(Convert.ToString(listCameras.SelectedItem));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
