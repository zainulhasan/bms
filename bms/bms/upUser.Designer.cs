namespace bms
{
    partial class upUser
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
            this.components = new System.ComponentModel.Container();
            this.error = new MetroFramework.Controls.MetroLabel();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.email_lab = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.address_lab = new MetroFramework.Controls.MetroTextBox();
            this.phone_lab = new MetroFramework.Controls.MetroTextBox();
            this.age_lab = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.password_lab = new MetroFramework.Controls.MetroTextBox();
            this.name_lab = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dbDataSet7 = new bms.dbDataSet7();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new bms.dbDataSet7TableAdapters.userTableAdapter();
            this.username_lab = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(307, 153);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 0);
            this.error.TabIndex = 36;
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(401, 367);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(131, 29);
            this.metroTextButton2.TabIndex = 35;
            this.metroTextButton2.Text = "Close";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(199, 367);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(131, 29);
            this.metroTextButton1.TabIndex = 34;
            this.metroTextButton1.Text = "Update User";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // email_lab
            // 
            // 
            // 
            // 
            this.email_lab.CustomButton.Image = null;
            this.email_lab.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.email_lab.CustomButton.Name = "";
            this.email_lab.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.email_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email_lab.CustomButton.TabIndex = 1;
            this.email_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email_lab.CustomButton.UseSelectable = true;
            this.email_lab.CustomButton.Visible = false;
            this.email_lab.Lines = new string[0];
            this.email_lab.Location = new System.Drawing.Point(149, 304);
            this.email_lab.MaxLength = 32767;
            this.email_lab.Name = "email_lab";
            this.email_lab.PasswordChar = '\0';
            this.email_lab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email_lab.SelectedText = "";
            this.email_lab.SelectionLength = 0;
            this.email_lab.SelectionStart = 0;
            this.email_lab.Size = new System.Drawing.Size(195, 23);
            this.email_lab.TabIndex = 33;
            this.email_lab.UseSelectable = true;
            this.email_lab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email_lab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(62, 308);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(44, 19);
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "Email:";
            // 
            // address_lab
            // 
            // 
            // 
            // 
            this.address_lab.CustomButton.Image = null;
            this.address_lab.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.address_lab.CustomButton.Name = "";
            this.address_lab.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.address_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address_lab.CustomButton.TabIndex = 1;
            this.address_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address_lab.CustomButton.UseSelectable = true;
            this.address_lab.CustomButton.Visible = false;
            this.address_lab.Lines = new string[0];
            this.address_lab.Location = new System.Drawing.Point(484, 263);
            this.address_lab.MaxLength = 32767;
            this.address_lab.Name = "address_lab";
            this.address_lab.PasswordChar = '\0';
            this.address_lab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address_lab.SelectedText = "";
            this.address_lab.SelectionLength = 0;
            this.address_lab.SelectionStart = 0;
            this.address_lab.Size = new System.Drawing.Size(195, 23);
            this.address_lab.TabIndex = 31;
            this.address_lab.UseSelectable = true;
            this.address_lab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address_lab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phone_lab
            // 
            // 
            // 
            // 
            this.phone_lab.CustomButton.Image = null;
            this.phone_lab.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.phone_lab.CustomButton.Name = "";
            this.phone_lab.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phone_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phone_lab.CustomButton.TabIndex = 1;
            this.phone_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phone_lab.CustomButton.UseSelectable = true;
            this.phone_lab.CustomButton.Visible = false;
            this.phone_lab.Lines = new string[0];
            this.phone_lab.Location = new System.Drawing.Point(484, 229);
            this.phone_lab.MaxLength = 32767;
            this.phone_lab.Name = "phone_lab";
            this.phone_lab.PasswordChar = '\0';
            this.phone_lab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phone_lab.SelectedText = "";
            this.phone_lab.SelectionLength = 0;
            this.phone_lab.SelectionStart = 0;
            this.phone_lab.Size = new System.Drawing.Size(195, 23);
            this.phone_lab.TabIndex = 30;
            this.phone_lab.UseSelectable = true;
            this.phone_lab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phone_lab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // age_lab
            // 
            // 
            // 
            // 
            this.age_lab.CustomButton.Image = null;
            this.age_lab.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.age_lab.CustomButton.Name = "";
            this.age_lab.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.age_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.age_lab.CustomButton.TabIndex = 1;
            this.age_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.age_lab.CustomButton.UseSelectable = true;
            this.age_lab.CustomButton.Visible = false;
            this.age_lab.Lines = new string[0];
            this.age_lab.Location = new System.Drawing.Point(484, 194);
            this.age_lab.MaxLength = 32767;
            this.age_lab.Name = "age_lab";
            this.age_lab.PasswordChar = '\0';
            this.age_lab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.age_lab.SelectedText = "";
            this.age_lab.SelectionLength = 0;
            this.age_lab.SelectionStart = 0;
            this.age_lab.Size = new System.Drawing.Size(195, 23);
            this.age_lab.TabIndex = 29;
            this.age_lab.UseSelectable = true;
            this.age_lab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.age_lab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(397, 267);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Address:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(397, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Phone:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(402, 194);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(36, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Age:";
            // 
            // password_lab
            // 
            // 
            // 
            // 
            this.password_lab.CustomButton.Image = null;
            this.password_lab.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.password_lab.CustomButton.Name = "";
            this.password_lab.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_lab.CustomButton.TabIndex = 1;
            this.password_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_lab.CustomButton.UseSelectable = true;
            this.password_lab.CustomButton.Visible = false;
            this.password_lab.Lines = new string[0];
            this.password_lab.Location = new System.Drawing.Point(149, 268);
            this.password_lab.MaxLength = 32767;
            this.password_lab.Name = "password_lab";
            this.password_lab.PasswordChar = '\0';
            this.password_lab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_lab.SelectedText = "";
            this.password_lab.SelectionLength = 0;
            this.password_lab.SelectionStart = 0;
            this.password_lab.Size = new System.Drawing.Size(195, 23);
            this.password_lab.TabIndex = 25;
            this.password_lab.UseSelectable = true;
            this.password_lab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_lab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // name_lab
            // 
            // 
            // 
            // 
            this.name_lab.CustomButton.Image = null;
            this.name_lab.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.name_lab.CustomButton.Name = "";
            this.name_lab.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_lab.CustomButton.TabIndex = 1;
            this.name_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_lab.CustomButton.UseSelectable = true;
            this.name_lab.CustomButton.Visible = false;
            this.name_lab.Lines = new string[0];
            this.name_lab.Location = new System.Drawing.Point(149, 229);
            this.name_lab.MaxLength = 32767;
            this.name_lab.Name = "name_lab";
            this.name_lab.PasswordChar = '\0';
            this.name_lab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_lab.SelectedText = "";
            this.name_lab.SelectionLength = 0;
            this.name_lab.SelectionStart = 0;
            this.name_lab.Size = new System.Drawing.Size(195, 23);
            this.name_lab.TabIndex = 23;
            this.name_lab.UseSelectable = true;
            this.name_lab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_lab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(62, 272);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Password:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 194);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 229);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(318, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Update User Info";
            // 
            // dbDataSet7
            // 
            this.dbDataSet7.DataSetName = "dbDataSet7";
            this.dbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.dbDataSet7;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // username_lab
            // 
            // 
            // 
            // 
            this.username_lab.CustomButton.Image = null;
            this.username_lab.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.username_lab.CustomButton.Name = "";
            this.username_lab.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username_lab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username_lab.CustomButton.TabIndex = 1;
            this.username_lab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username_lab.CustomButton.UseSelectable = true;
            this.username_lab.CustomButton.Visible = false;
            this.username_lab.Lines = new string[0];
            this.username_lab.Location = new System.Drawing.Point(149, 194);
            this.username_lab.MaxLength = 32767;
            this.username_lab.Name = "username_lab";
            this.username_lab.PasswordChar = '\0';
            this.username_lab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username_lab.SelectedText = "";
            this.username_lab.SelectionLength = 0;
            this.username_lab.SelectionStart = 0;
            this.username_lab.Size = new System.Drawing.Size(195, 23);
            this.username_lab.TabIndex = 37;
            this.username_lab.UseSelectable = true;
            this.username_lab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username_lab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // upUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 515);
            this.Controls.Add(this.username_lab);
            this.Controls.Add(this.error);
            this.Controls.Add(this.metroTextButton2);
            this.Controls.Add(this.metroTextButton1);
            this.Controls.Add(this.email_lab);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.address_lab);
            this.Controls.Add(this.phone_lab);
            this.Controls.Add(this.age_lab);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.password_lab);
            this.Controls.Add(this.name_lab);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "upUser";
            this.Text = "Blood Bank Management System";
            this.Load += new System.EventHandler(this.upUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel error;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroTextBox email_lab;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox address_lab;
        private MetroFramework.Controls.MetroTextBox phone_lab;
        private MetroFramework.Controls.MetroTextBox age_lab;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox password_lab;
        private MetroFramework.Controls.MetroTextBox name_lab;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private dbDataSet7 dbDataSet7;
        private System.Windows.Forms.BindingSource userBindingSource;
        private dbDataSet7TableAdapters.userTableAdapter userTableAdapter;
        private MetroFramework.Controls.MetroTextBox username_lab;
    }
}