namespace CameraShop
{
    partial class frmCamera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCamera_ID = new System.Windows.Forms.TextBox();
            this.txtBrand_Name = new System.Windows.Forms.TextBox();
            this.txtCamera_Price = new System.Windows.Forms.TextBox();
            this.txtCamera_Num = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Camera_Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Camera_Num";
            // 
            // txtCamera_ID
            // 
            this.txtCamera_ID.Location = new System.Drawing.Point(168, 31);
            this.txtCamera_ID.Name = "txtCamera_ID";
            this.txtCamera_ID.Size = new System.Drawing.Size(177, 22);
            this.txtCamera_ID.TabIndex = 6;
            // 
            // txtBrand_Name
            // 
            this.txtBrand_Name.Location = new System.Drawing.Point(168, 80);
            this.txtBrand_Name.Name = "txtBrand_Name";
            this.txtBrand_Name.Size = new System.Drawing.Size(177, 22);
            this.txtBrand_Name.TabIndex = 7;
            // 
            // txtCamera_Price
            // 
            this.txtCamera_Price.Location = new System.Drawing.Point(168, 123);
            this.txtCamera_Price.Name = "txtCamera_Price";
            this.txtCamera_Price.Size = new System.Drawing.Size(177, 22);
            this.txtCamera_Price.TabIndex = 8;
            // 
            // txtCamera_Num
            // 
            this.txtCamera_Num.Location = new System.Drawing.Point(168, 173);
            this.txtCamera_Num.Name = "txtCamera_Num";
            this.txtCamera_Num.Size = new System.Drawing.Size(177, 22);
            this.txtCamera_Num.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(50, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 37);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 345);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCamera_Num);
            this.Controls.Add(this.txtCamera_Price);
            this.Controls.Add(this.txtBrand_Name);
            this.Controls.Add(this.txtCamera_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCamera";
            this.Text = "frmCamera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCamera_ID;
        private System.Windows.Forms.TextBox txtBrand_Name;
        private System.Windows.Forms.TextBox txtCamera_Price;
        private System.Windows.Forms.TextBox txtCamera_Num;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}