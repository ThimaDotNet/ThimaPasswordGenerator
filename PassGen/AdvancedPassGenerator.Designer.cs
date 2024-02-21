namespace PassGen
{
    partial class AdvancedPassGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedPassGenerator));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nudLengh = new DevExpress.XtraEditors.SpinEdit();
            this.lblStrengh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnShowPass = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.btnUseSpecial = new DevExpress.XtraEditors.CheckButton();
            this.btnUseNumbers = new DevExpress.XtraEditors.CheckButton();
            this.btnUseLowercase = new DevExpress.XtraEditors.CheckButton();
            this.btnUseUppercase = new DevExpress.XtraEditors.CheckButton();
            this.txtUpper = new DevExpress.XtraEditors.TextEdit();
            this.txtLower = new DevExpress.XtraEditors.TextEdit();
            this.txtNumbers = new DevExpress.XtraEditors.TextEdit();
            this.txtSpecial = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLower.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Password lengh";
            // 
            // nudLengh
            // 
            this.nudLengh.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLengh.Location = new System.Drawing.Point(154, 26);
            this.nudLengh.Name = "nudLengh";
            this.nudLengh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudLengh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.nudLengh.Size = new System.Drawing.Size(138, 20);
            this.nudLengh.TabIndex = 22;
            // 
            // lblStrengh
            // 
            this.lblStrengh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStrengh.Location = new System.Drawing.Point(279, 366);
            this.lblStrengh.Name = "lblStrengh";
            this.lblStrengh.Size = new System.Drawing.Size(77, 24);
            this.lblStrengh.TabIndex = 20;
            this.lblStrengh.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(164, 366);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 24);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Password Strengh is :";
            // 
            // btnShowPass
            // 
            this.btnShowPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowPass.ImageOptions.SvgImage")));
            this.btnShowPass.Location = new System.Drawing.Point(446, 334);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(41, 32);
            this.btnShowPass.TabIndex = 19;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCopyToClipboard.ImageOptions.SvgImage")));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(12, 396);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(475, 52);
            this.btnCopyToClipboard.TabIndex = 18;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 340);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.ReadOnly = true;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(428, 20);
            this.txtPass.TabIndex = 17;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 287);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(475, 47);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate password";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnUseSpecial
            // 
            this.btnUseSpecial.Location = new System.Drawing.Point(12, 223);
            this.btnUseSpecial.Name = "btnUseSpecial";
            this.btnUseSpecial.Size = new System.Drawing.Size(138, 47);
            this.btnUseSpecial.TabIndex = 12;
            this.btnUseSpecial.Text = "Use special charcters";
            this.btnUseSpecial.CheckedChanged += new System.EventHandler(this.btnUseSpecial_CheckedChanged);
            // 
            // btnUseNumbers
            // 
            this.btnUseNumbers.Location = new System.Drawing.Point(12, 170);
            this.btnUseNumbers.Name = "btnUseNumbers";
            this.btnUseNumbers.Size = new System.Drawing.Size(138, 47);
            this.btnUseNumbers.TabIndex = 13;
            this.btnUseNumbers.Text = "Use numbers";
            this.btnUseNumbers.CheckedChanged += new System.EventHandler(this.btnUseNumbers_CheckedChanged);
            // 
            // btnUseLowercase
            // 
            this.btnUseLowercase.Location = new System.Drawing.Point(12, 117);
            this.btnUseLowercase.Name = "btnUseLowercase";
            this.btnUseLowercase.Size = new System.Drawing.Size(138, 47);
            this.btnUseLowercase.TabIndex = 14;
            this.btnUseLowercase.Text = "Use lowercase";
            this.btnUseLowercase.CheckedChanged += new System.EventHandler(this.btnUseLowercase_CheckedChanged);
            // 
            // btnUseUppercase
            // 
            this.btnUseUppercase.Location = new System.Drawing.Point(12, 64);
            this.btnUseUppercase.Name = "btnUseUppercase";
            this.btnUseUppercase.Size = new System.Drawing.Size(138, 47);
            this.btnUseUppercase.TabIndex = 15;
            this.btnUseUppercase.Text = "Use uppercase";
            this.btnUseUppercase.CheckedChanged += new System.EventHandler(this.btnUseUppercase_CheckedChanged_1);
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(156, 78);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUpper.Size = new System.Drawing.Size(331, 20);
            this.txtUpper.TabIndex = 24;
            this.txtUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpper_KeyPress);
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(154, 131);
            this.txtLower.Name = "txtLower";
            this.txtLower.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLower.Size = new System.Drawing.Size(331, 20);
            this.txtLower.TabIndex = 24;
            this.txtLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLower_KeyPress);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(154, 184);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(331, 20);
            this.txtNumbers.TabIndex = 24;
            this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(154, 237);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(331, 20);
            this.txtSpecial.TabIndex = 24;
            this.txtSpecial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpecial_KeyPress);
            // 
            // AdvancedPassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 472);
            this.Controls.Add(this.txtSpecial);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.txtUpper);
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
            this.Name = "AdvancedPassGenerator";
            this.Text = "AdvancedPassGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.nudLengh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLower.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumbers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpecial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit nudLengh;
        private DevExpress.XtraEditors.LabelControl lblStrengh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnShowPass;
        private DevExpress.XtraEditors.SimpleButton btnCopyToClipboard;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.CheckButton btnUseSpecial;
        private DevExpress.XtraEditors.CheckButton btnUseNumbers;
        private DevExpress.XtraEditors.CheckButton btnUseLowercase;
        private DevExpress.XtraEditors.CheckButton btnUseUppercase;
        private DevExpress.XtraEditors.TextEdit txtUpper;
        private DevExpress.XtraEditors.TextEdit txtLower;
        private DevExpress.XtraEditors.TextEdit txtNumbers;
        private DevExpress.XtraEditors.TextEdit txtSpecial;
    }
}