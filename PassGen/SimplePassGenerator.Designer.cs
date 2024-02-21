namespace PassGen
{
    partial class SimplePassGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplePassGenerator));
            this.btnGeneratePass = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.btnCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowPass = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblStrengh = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneratePass
            // 
            this.btnGeneratePass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGeneratePass.ImageOptions.SvgImage")));
            this.btnGeneratePass.Location = new System.Drawing.Point(12, 12);
            this.btnGeneratePass.Name = "btnGeneratePass";
            this.btnGeneratePass.Size = new System.Drawing.Size(192, 52);
            this.btnGeneratePass.TabIndex = 0;
            this.btnGeneratePass.Text = "Give me a Password";
            this.btnGeneratePass.Click += new System.EventHandler(this.btnGeneratePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 76);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.ReadOnly = true;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(145, 20);
            this.txtPass.TabIndex = 1;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCopyToClipboard.ImageOptions.SvgImage")));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(12, 138);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(192, 52);
            this.btnCopyToClipboard.TabIndex = 2;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowPass.ImageOptions.SvgImage")));
            this.btnShowPass.Location = new System.Drawing.Point(163, 70);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(41, 32);
            this.btnShowPass.TabIndex = 3;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 108);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Password Strengh is :";
            // 
            // lblStrengh
            // 
            this.lblStrengh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStrengh.Location = new System.Drawing.Point(127, 108);
            this.lblStrengh.Name = "lblStrengh";
            this.lblStrengh.Size = new System.Drawing.Size(77, 24);
            this.lblStrengh.TabIndex = 4;
            this.lblStrengh.Text = "0";
            // 
            // SimplePassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 201);
            this.Controls.Add(this.lblStrengh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnGeneratePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimplePassGenerator";
            this.Text = "SimplePassGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGeneratePass;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.SimpleButton btnCopyToClipboard;
        private DevExpress.XtraEditors.SimpleButton btnShowPass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblStrengh;
    }
}