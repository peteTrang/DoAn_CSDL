namespace UI_BenhVien.UserControls
{
    partial class UC_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.uC_Info1 = new UI_BenhVien.UserControls.UC_Info();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txbSearch.HintText = "";
            this.txbSearch.isPassword = false;
            this.txbSearch.LineFocusedColor = System.Drawing.Color.PaleGreen;
            this.txbSearch.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.txbSearch.LineMouseHoverColor = System.Drawing.Color.PaleGreen;
            this.txbSearch.LineThickness = 3;
            this.txbSearch.Location = new System.Drawing.Point(30, -1);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(185, 27);
            this.txbSearch.TabIndex = 10;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Green;
            this.btnSearch.Location = new System.Drawing.Point(249, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 24);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.AutoScroll = true;
            this.pnlShow.Controls.Add(this.uC_Info1);
            this.pnlShow.Location = new System.Drawing.Point(4, 32);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(522, 382);
            this.pnlShow.TabIndex = 14;
            // 
            // uC_Info1
            // 
            this.uC_Info1.BackColor = System.Drawing.Color.White;
            this.uC_Info1.Location = new System.Drawing.Point(10, 3);
            this.uC_Info1.Name = "uC_Info1";
            this.uC_Info1.Size = new System.Drawing.Size(509, 73);
            this.uC_Info1.TabIndex = 13;
            this.uC_Info1.Load += new System.EventHandler(this.uC_Info1_Load);
            // 
            // UC_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Admin";
            this.Size = new System.Drawing.Size(530, 415);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private UC_Info uC_Info1;
        private System.Windows.Forms.Panel pnlShow;
    }
}
