namespace CameraShop
{
    partial class frmBrand
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
            this.txtBrand_Name = new System.Windows.Forms.TextBox();
            this.txtBrand_ID = new System.Windows.Forms.TextBox();
            this.txtBrand_Descrip = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbByID = new System.Windows.Forms.RadioButton();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.listCameras = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrip";
            // 
            // txtBrand_Name
            // 
            this.txtBrand_Name.Location = new System.Drawing.Point(160, 22);
            this.txtBrand_Name.Name = "txtBrand_Name";
            this.txtBrand_Name.Size = new System.Drawing.Size(160, 22);
            this.txtBrand_Name.TabIndex = 3;
            // 
            // txtBrand_ID
            // 
            this.txtBrand_ID.Location = new System.Drawing.Point(160, 64);
            this.txtBrand_ID.Name = "txtBrand_ID";
            this.txtBrand_ID.Size = new System.Drawing.Size(160, 22);
            this.txtBrand_ID.TabIndex = 4;
            // 
            // txtBrand_Descrip
            // 
            this.txtBrand_Descrip.Location = new System.Drawing.Point(160, 114);
            this.txtBrand_Descrip.Name = "txtBrand_Descrip";
            this.txtBrand_Descrip.Size = new System.Drawing.Size(160, 22);
            this.txtBrand_Descrip.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbByID);
            this.groupBox1.Controls.Add(this.rbByName);
            this.groupBox1.Location = new System.Drawing.Point(127, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // rbByID
            // 
            this.rbByID.AutoSize = true;
            this.rbByID.Location = new System.Drawing.Point(112, 35);
            this.rbByID.Name = "rbByID";
            this.rbByID.Size = new System.Drawing.Size(42, 21);
            this.rbByID.TabIndex = 1;
            this.rbByID.TabStop = true;
            this.rbByID.Text = "ID";
            this.rbByID.UseVisualStyleBackColor = true;
            this.rbByID.CheckedChanged += new System.EventHandler(this.rbByID_CheckedChanged);
            // 
            // rbByName
            // 
            this.rbByName.AutoSize = true;
            this.rbByName.Location = new System.Drawing.Point(20, 35);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(66, 21);
            this.rbByName.TabIndex = 0;
            this.rbByName.TabStop = true;
            this.rbByName.Text = "Name";
            this.rbByName.UseVisualStyleBackColor = true;
            this.rbByName.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listCameras
            // 
            this.listCameras.FormattingEnabled = true;
            this.listCameras.ItemHeight = 16;
            this.listCameras.Location = new System.Drawing.Point(33, 296);
            this.listCameras.Name = "listCameras";
            this.listCameras.Size = new System.Drawing.Size(239, 180);
            this.listCameras.TabIndex = 7;
            this.listCameras.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listCameras.DoubleClick += new System.EventHandler(this.listCameras_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cameras";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(314, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(314, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 42);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(314, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 48);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listCameras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBrand_Descrip);
            this.Controls.Add(this.txtBrand_ID);
            this.Controls.Add(this.txtBrand_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBrand";
            this.Text = "frmCamera";
            this.Load += new System.EventHandler(this.frmBrand_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand_Name;
        private System.Windows.Forms.TextBox txtBrand_ID;
        private System.Windows.Forms.TextBox txtBrand_Descrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbByID;
        private System.Windows.Forms.RadioButton rbByName;
        private System.Windows.Forms.ListBox listCameras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}