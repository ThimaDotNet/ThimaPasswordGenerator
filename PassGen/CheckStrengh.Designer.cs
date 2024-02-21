namespace PassGen
{
    partial class CheckStrengh
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel6 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tkbStrengh = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblStrengh = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStrengh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStrengh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(24, 3);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(381, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(24, 29);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(381, 51);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Check strengh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tkbStrengh
            // 
            this.tkbStrengh.Location = new System.Drawing.Point(24, 86);
            this.tkbStrengh.Name = "tkbStrengh";
            this.tkbStrengh.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tkbStrengh.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "0";
            trackBarLabel2.Label = "100";
            trackBarLabel2.Value = 100;
            trackBarLabel3.Label = "200";
            trackBarLabel3.Value = 200;
            trackBarLabel4.Label = "300";
            trackBarLabel4.Value = 300;
            trackBarLabel5.Label = "400";
            trackBarLabel5.Value = 400;
            trackBarLabel6.Label = "500";
            trackBarLabel6.Value = 500;
            trackBarLabel7.Label = "600";
            trackBarLabel7.Value = 600;
            trackBarLabel8.Label = "700";
            trackBarLabel8.Value = 700;
            trackBarLabel9.Label = "800";
            trackBarLabel9.Value = 800;
            trackBarLabel10.Label = "900";
            trackBarLabel10.Value = 900;
            trackBarLabel11.Label = "1000";
            trackBarLabel11.Value = 1000;
            this.tkbStrengh.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5,
            trackBarLabel6,
            trackBarLabel7,
            trackBarLabel8,
            trackBarLabel9,
            trackBarLabel10,
            trackBarLabel11});
            this.tkbStrengh.Properties.Maximum = 1000;
            this.tkbStrengh.Properties.ShowLabels = true;
            this.tkbStrengh.Size = new System.Drawing.Size(381, 72);
            this.tkbStrengh.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 164);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(278, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Your password strengh is:";
            // 
            // lblStrengh
            // 
            this.lblStrengh.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblStrengh.Appearance.Options.UseFont = true;
            this.lblStrengh.Location = new System.Drawing.Point(308, 164);
            this.lblStrengh.Name = "lblStrengh";
            this.lblStrengh.Size = new System.Drawing.Size(13, 29);
            this.lblStrengh.TabIndex = 4;
            this.lblStrengh.Text = "0";
            // 
            // CheckStrengh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 224);
            this.Controls.Add(this.lblStrengh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tkbStrengh);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Name = "CheckStrengh";
            this.Text = "CheckStrengh";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStrengh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbStrengh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TrackBarControl tkbStrengh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblStrengh;
    }
}