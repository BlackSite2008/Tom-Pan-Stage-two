namespace CameraShop
{
    partial class frmNUType
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
            this.btnNewCamera = new System.Windows.Forms.Button();
            this.btnUsedCamera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewCamera
            // 
            this.btnNewCamera.Location = new System.Drawing.Point(50, 71);
            this.btnNewCamera.Name = "btnNewCamera";
            this.btnNewCamera.Size = new System.Drawing.Size(108, 40);
            this.btnNewCamera.TabIndex = 0;
            this.btnNewCamera.Text = "NewCamera";
            this.btnNewCamera.UseVisualStyleBackColor = true;
            this.btnNewCamera.Click += new System.EventHandler(this.btnNewCamera_Click);
            // 
            // btnUsedCamera
            // 
            this.btnUsedCamera.Location = new System.Drawing.Point(262, 71);
            this.btnUsedCamera.Name = "btnUsedCamera";
            this.btnUsedCamera.Size = new System.Drawing.Size(113, 40);
            this.btnUsedCamera.TabIndex = 1;
            this.btnUsedCamera.Text = "UsedCamera";
            this.btnUsedCamera.UseVisualStyleBackColor = true;
            this.btnUsedCamera.Click += new System.EventHandler(this.btnUsedCamera_Click);
            // 
            // frmNUType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 206);
            this.Controls.Add(this.btnUsedCamera);
            this.Controls.Add(this.btnNewCamera);
            this.Name = "frmNUType";
            this.Text = "frmNUType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCamera;
        private System.Windows.Forms.Button btnUsedCamera;
    }
}