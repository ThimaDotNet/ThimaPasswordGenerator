namespace PassGen
{
    partial class CustomPassGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPassGenerator));
            this.btnUseLowercase = new DevExpress.XtraEditors.CheckButton();
            this.btnUseNumbers = new DevExpress.XtraEditors.CheckButton();
            this.btnUseSpecial = new DevExpress.XtraEditors.CheckButton();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.lblStrengh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnShowPass = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.btnUseUppercase = new DevExpress.XtraEditors.CheckButton();
            this.nudLengh = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUseLowercase
            // 
            this.btnUseLowercase.Location = new System.Drawing.Point(156, 38);
            this.btnUseLowercase.Name = "btnUseLowercase";
            this.btnUseLowercase.Size = new System.Drawing.Size(138, 47);
            this.btnUseLowercase.TabIndex = 0;
            this.btnUseLowercase.Text = "Use lowercase";
            // 
            // btnUseNumbers
            // 
            this.btnUseNumbers.Location = new System.Drawing.Point(12, 91);
            this.btnUseNumbers.Name = "btnUseNumbers";
            this.btnUseNumbers.Size = new System.Drawing.Size(138, 47);
            this.btnUseNumbers.TabIndex = 0;
            this.btnUseNumbers.Text = "Use numbers";
            // 
            // btnUseSpecial
            // 
            this.btnUseSpecial.Location = new System.Drawing.Point(156, 91);
            this.btnUseSpecial.Name = "btnUseSpecial";
            this.btnUseSpecial.Size = new System.Drawing.Size(138, 47);
            this.btnUseSpecial.TabIndex = 0;
            this.btnUseSpecial.Text = "Use special charcters";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 144);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(282, 47);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate password";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblStrengh
            // 
            this.lblStrengh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStrengh.Location = new System.Drawing.Point(178, 229);
            this.lblStrengh.Name = "lblStrengh";
            this.lblStrengh.Size = new System.Drawing.Size(77, 24);
            this.lblStrengh.TabIndex = 8;
            this.lblStrengh.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(63, 229);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 24);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Password Strengh is :";
            // 
            // btnShowPass
            // 
            this.btnShowPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowPass.ImageOptions.SvgImage")));
            this.btnShowPass.Location = new System.Drawing.Point(253, 197);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(41, 32);
            this.btnShowPass.TabIndex = 7;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCopyToClipboard.ImageOptions.SvgImage")));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(12, 259);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(282, 52);
            this.btnCopyToClipboard.TabIndex = 6;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 203);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.ReadOnly = true;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(235, 20);
            this.txtPass.TabIndex = 5;
            // 
            // btnUseUppercase
            // 
            this.btnUseUppercase.Location = new System.Drawing.Point(12, 38);
            this.btnUseUppercase.Name = "btnUseUppercase";
            this.btnUseUppercase.Size = new System.Drawing.Size(138, 47);
            this.btnUseUppercase.TabIndex = 0;
            this.btnUseUppercase.Text = "Use uppercase";
            // 
            // nudLengh
            // 
            this.nudLengh.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLengh.Location = new System.Drawing.Point(156, 12);
            this.nudLengh.Name = "nudLengh";
            this.nudLengh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudLengh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.nudLengh.Size = new System.Drawing.Size(138, 20);
            this.nudLengh.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Password lengh";
            // 
            // CustomPassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 331);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.nudLengh);
            this.Controls.Add(this.lblStrengh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnUseSpecial);
            this.Controls.Add(this.btnUseNumbers);
            this.Controls.Add(this.btnUseLowercase);
            this.Controls.Add(this.btnUseUppercase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomPassGenerator";
            this.Text = "CustomPassGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.CheckButton btnUseLowercase;
        private DevExpress.XtraEditors.CheckButton btnUseNumbers;
        private DevExpress.XtraEditors.CheckButton btnUseSpecial;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.LabelControl lblStrengh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnShowPass;
        private DevExpress.XtraEditors.SimpleButton btnCopyToClipboard;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.CheckButton btnUseUppercase;
        private DevExpress.XtraEditors.SpinEdit nudLengh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}