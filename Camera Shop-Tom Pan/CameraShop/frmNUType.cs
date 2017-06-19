using System;
using System.Windows.Forms;

namespace CameraShop
{   //Tom-Pan :selcet button of New or Used camera type to specific new or used form
    public partial class frmNUType : Form
    {
        public frmNUType()
        {
            InitializeComponent();
        }

        private void btnNewCamera_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNCamera NewCamera = new frmNCamera();
            NewCamera.Show();
        }

        private void btnUsedCamera_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUCamera UsedCamera = new frmUCamera();
            UsedCamera.Show();
        }
    }
}
