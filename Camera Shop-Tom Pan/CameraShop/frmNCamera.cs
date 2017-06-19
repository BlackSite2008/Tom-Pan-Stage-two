using System;

namespace CameraShop
{   //Tom-Pan :this is a form for new camera, which has common fields and warranty that only to new camera
    public sealed partial class frmNCamera : CameraShop.frmCamera
    {
        private static readonly frmNCamera Instance = new frmNCamera();
        
        public frmNCamera()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
