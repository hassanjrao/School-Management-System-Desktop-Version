namespace Lab5_Act_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblStdLastName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblAddres = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.BackColor = System.Drawing.Color.Transparent;
            this.lblStdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStdName.Location = new System.Drawing.Point(41, 49);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(124, 20);
            this.lblStdName.TabIndex = 0;
            this.lblStdName.Text = "Student Name";
            // 
            // lblStdLastName
            // 
            this.lblStdLastName.AutoSize = true;
            this.lblStdLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblStdLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStdLastName.Location = new System.Drawing.Point(41, 88);
            this.lblStdLastName.Name = "lblStdLastName";
            this.lblStdLastName.Size = new System.Drawing.Size(177, 20);
            this.lblStdLastName.TabIndex = 1;
            this.lblStdLastName.Text = "Student\'s Last Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCity.Location = new System.Drawing.Point(41, 170);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(225, 49);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(144, 20);
            this.txtFName.TabIndex = 0;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(225, 131);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(144, 20);
            this.txtAdd.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(225, 170);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(144, 20);
            this.txtCity.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(282, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnShowInfo.Location = new System.Drawing.Point(168, 327);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(144, 23);
            this.btnShowInfo.TabIndex = 7;
            this.btnShowInfo.Text = "Show Student Info";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(121, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(225, 88);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(144, 20);
            this.txtLName.TabIndex = 1;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.BackColor = System.Drawing.Color.Transparent;
            this.lblAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddres.Location = new System.Drawing.Point(41, 131);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(75, 20);
            this.lblAddres.TabIndex = 9;
            this.lblAddres.Text = "Address";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(225, 209);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(144, 20);
            this.txtMobile.TabIndex = 4;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.BackColor = System.Drawing.Color.Transparent;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMobile.Location = new System.Drawing.Point(41, 209);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(93, 20);
            this.lblMobile.TabIndex = 11;
            this.lblMobile.Text = "Mobile No.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(374, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStdLastName);
            this.Controls.Add(this.lblStdName);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblStdLastName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.Label lblMobile;
        public System.Windows.Forms.TextBox txtFName;
        public System.Windows.Forms.TextBox txtAdd;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.TextBox txtLName;
        public System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button button1;
    }
}

