using System.Collections.Generic;

namespace UI_BenhVien.UserControls
{
    partial class UC_Action
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Action));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbObject = new System.Windows.Forms.ComboBox();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Green;
            this.btnSearch.Location = new System.Drawing.Point(398, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txbSearch.Location = new System.Drawing.Point(68, 7);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(219, 33);
            this.txbSearch.TabIndex = 5;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearch.OnValueChanged += new System.EventHandler(this.txbSearch_OnValueChanged);
            // 
            // cbObject
            // 
            this.cbObject.AllowDrop = true;
            this.cbObject.BackColor = System.Drawing.Color.PaleGreen;
            this.cbObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbObject.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbObject.FormattingEnabled = true;
            this.cbObject.Items.AddRange(new object[] {
            "Bác sỹ",
            "Bệnh nhân"});
            this.cbObject.Location = new System.Drawing.Point(306, 13);
            this.cbObject.Name = "cbObject";
            this.cbObject.Size = new System.Drawing.Size(89, 24);
            this.cbObject.TabIndex = 7;
            // 
            // pnlShow
            // 
            this.pnlShow.AutoScroll = true;
            this.pnlShow.Location = new System.Drawing.Point(0, 56);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(529, 358);
            this.pnlShow.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Action
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.cbObject);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Location = new System.Drawing.Point(240, 0);
            this.Name = "UC_Action";
            this.Size = new System.Drawing.Size(530, 415);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbSearch;
        private System.Windows.Forms.ComboBox cbObject;
        public System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        public static List<UC_Info> uc_Infos;
    }
}
