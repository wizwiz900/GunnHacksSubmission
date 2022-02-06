namespace WindowsFormsApp1
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
            System.Windows.Forms.GroupBox gbxTheme;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radGunn = new System.Windows.Forms.RadioButton();
            this.radModern = new System.Windows.Forms.RadioButton();
            this.radSimple = new System.Windows.Forms.RadioButton();
            this.radClassy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddy = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.gbxColor = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGold = new System.Windows.Forms.RadioButton();
            gbxTheme = new System.Windows.Forms.GroupBox();
            gbxTheme.SuspendLayout();
            this.gbxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTheme
            // 
            gbxTheme.Controls.Add(this.radGunn);
            gbxTheme.Controls.Add(this.radModern);
            gbxTheme.Controls.Add(this.radSimple);
            gbxTheme.Controls.Add(this.radClassy);
            gbxTheme.Location = new System.Drawing.Point(127, 169);
            gbxTheme.Name = "gbxTheme";
            gbxTheme.Size = new System.Drawing.Size(190, 113);
            gbxTheme.TabIndex = 0;
            gbxTheme.TabStop = false;
            gbxTheme.Text = "Theme:";
            // 
            // radGunn
            // 
            this.radGunn.Location = new System.Drawing.Point(14, 88);
            this.radGunn.Name = "radGunn";
            this.radGunn.Size = new System.Drawing.Size(94, 17);
            this.radGunn.TabIndex = 6;
            this.radGunn.Text = "Gunn Hacks";
            this.radGunn.UseVisualStyleBackColor = true;
            this.radGunn.CheckedChanged += new System.EventHandler(this.radGunn_CheckedChanged);
            // 
            // radModern
            // 
            this.radModern.Location = new System.Drawing.Point(14, 42);
            this.radModern.Name = "radModern";
            this.radModern.Size = new System.Drawing.Size(94, 17);
            this.radModern.TabIndex = 5;
            this.radModern.Text = "Modern";
            this.radModern.UseVisualStyleBackColor = true;
            // 
            // radSimple
            // 
            this.radSimple.Location = new System.Drawing.Point(14, 19);
            this.radSimple.Name = "radSimple";
            this.radSimple.Size = new System.Drawing.Size(58, 17);
            this.radSimple.TabIndex = 4;
            this.radSimple.Text = "Simple";
            this.radSimple.UseVisualStyleBackColor = true;
            // 
            // radClassy
            // 
            this.radClassy.Checked = true;
            this.radClassy.Location = new System.Drawing.Point(14, 65);
            this.radClassy.Name = "radClassy";
            this.radClassy.Size = new System.Drawing.Size(58, 17);
            this.radClassy.TabIndex = 3;
            this.radClassy.TabStop = true;
            this.radClassy.Text = "Classy";
            this.radClassy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Name (First, Last):";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact Info:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Website URL:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Company Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(78, 52);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(239, 20);
            this.txtContact.TabIndex = 11;
            // 
            // txtAddy
            // 
            this.txtAddy.Location = new System.Drawing.Point(58, 81);
            this.txtAddy.Name = "txtAddy";
            this.txtAddy.Size = new System.Drawing.Size(259, 20);
            this.txtAddy.TabIndex = 12;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(87, 108);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(230, 20);
            this.txtUrl.TabIndex = 13;
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(97, 137);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(220, 20);
            this.txtComp.TabIndex = 14;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 288);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(302, 84);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create!";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // radBlue
            // 
            this.radBlue.Checked = true;
            this.radBlue.Location = new System.Drawing.Point(11, 29);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(58, 17);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // gbxColor
            // 
            this.gbxColor.Controls.Add(this.radRed);
            this.gbxColor.Controls.Add(this.radGold);
            this.gbxColor.Controls.Add(this.radBlue);
            this.gbxColor.Location = new System.Drawing.Point(15, 169);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(106, 113);
            this.gbxColor.TabIndex = 16;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "Color:";
            // 
            // radRed
            // 
            this.radRed.Location = new System.Drawing.Point(11, 78);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(58, 17);
            this.radRed.TabIndex = 2;
            this.radRed.Text = "Pink";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radGold
            // 
            this.radGold.Location = new System.Drawing.Point(11, 54);
            this.radGold.Name = "radGold";
            this.radGold.Size = new System.Drawing.Size(58, 17);
            this.radGold.TabIndex = 1;
            this.radGold.Text = "Gold";
            this.radGold.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 385);
            this.Controls.Add(gbxTheme);
            this.Controls.Add(this.gbxColor);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtAddy);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Business Card Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            gbxTheme.ResumeLayout(false);
            this.gbxColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddy;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton radGunn;
        private System.Windows.Forms.RadioButton radModern;
        private System.Windows.Forms.RadioButton radSimple;
        private System.Windows.Forms.RadioButton radClassy;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.GroupBox gbxColor;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radGold;
    }
}

