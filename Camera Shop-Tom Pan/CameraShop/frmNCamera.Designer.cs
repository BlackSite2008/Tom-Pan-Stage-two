namespace CameraShop
{
    partial class frmNCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtCamera_Warranty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Camera_Warranty";
            // 
            // txtCamera_Warranty
            // 
            this.txtCamera_Warranty.Location = new System.Drawing.Point(168, 216);
            this.txtCamera_Warranty.Name = "txtCamera_Warranty";
            this.txtCamera_Warranty.Size = new System.Drawing.Size(177, 22);
            this.txtCamera_Warranty.TabIndex = 9;
            // 
            // frmNCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 353);
            this.Controls.Add(this.txtCamera_Warranty);
            this.Controls.Add(this.label5);
            this.Name = "frmNCamera";
            this.Text = "frmNCamera";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCamera_Warranty, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCamera_Warranty;
    }
}