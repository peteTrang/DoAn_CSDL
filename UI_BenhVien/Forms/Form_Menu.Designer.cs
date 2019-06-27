﻿namespace UI_BenhVien.Forms
{
    partial class Form_Menu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlPlaceHolder = new System.Windows.Forms.Panel();
            this.uC_Action1 = new UI_BenhVien.UserControls.UC_Action();
            this.transition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlPlaceHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnAuthor);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnAction);
            this.pnlMenu.Controls.Add(this.lblHello);
            this.pnlMenu.Controls.Add(this.ptbLogo);
            this.transition2.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.Location = new System.Drawing.Point(0, 43);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 511);
            this.pnlMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "FETEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transition.SetDecoration(this.btnAuthor, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.btnAuthor, BunifuAnimatorNS.DecorationType.None);
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.Gray;
            this.btnAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthor.Image")));
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.Location = new System.Drawing.Point(0, 410);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(240, 82);
            this.btnAuthor.TabIndex = 5;
            this.btnAuthor.Text = "Tác giả";
            this.btnAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transition.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Gray;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 327);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(240, 82);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Quyền Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAction
            // 
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transition.SetDecoration(this.btnAction, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.btnAction, BunifuAnimatorNS.DecorationType.None);
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.Gray;
            this.btnAction.Image = ((System.Drawing.Image)(resources.GetObject("btnAction.Image")));
            this.btnAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAction.Location = new System.Drawing.Point(0, 245);
            this.btnAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(240, 82);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Thao tác dữ liệu";
            this.btnAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblHello
            // 
            this.transition.SetDecoration(this.lblHello, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.lblHello, BunifuAnimatorNS.DecorationType.None);
            this.lblHello.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHello.Location = new System.Drawing.Point(7, 206);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(217, 27);
            this.lblHello.TabIndex = 2;
            this.lblHello.Text = "Xin chào";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transition.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(67, 75);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(108, 107);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlControl.Controls.Add(this.btnMinimize);
            this.pnlControl.Controls.Add(this.btnExit);
            this.transition2.SetDecoration(this.pnlControl, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.pnlControl, BunifuAnimatorNS.DecorationType.None);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(947, 43);
            this.pnlControl.TabIndex = 0;
            this.pnlControl.TabStop = true;
            // 
            // btnMinimize
            // 
            this.transition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(840, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(53, 43);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.transition.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(893, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 43);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlControl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // transition
            // 
            this.transition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation1;
            this.transition.Interval = 2;
            // 
            // pnlPlaceHolder
            // 
            this.pnlPlaceHolder.BackColor = System.Drawing.Color.White;
            this.pnlPlaceHolder.Controls.Add(this.uC_Action1);
            this.transition2.SetDecoration(this.pnlPlaceHolder, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.pnlPlaceHolder, BunifuAnimatorNS.DecorationType.None);
            this.pnlPlaceHolder.Location = new System.Drawing.Point(240, 43);
            this.pnlPlaceHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlaceHolder.Name = "pnlPlaceHolder";
            this.pnlPlaceHolder.Size = new System.Drawing.Size(707, 511);
            this.pnlPlaceHolder.TabIndex = 1;
            // 
            // uC_Action1
            // 
            this.uC_Action1.BackColor = System.Drawing.Color.White;
            this.transition2.SetDecoration(this.uC_Action1, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.uC_Action1, BunifuAnimatorNS.DecorationType.None);
            this.uC_Action1.Dem = 0;
            this.uC_Action1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Action1.Location = new System.Drawing.Point(0, 0);
            this.uC_Action1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Action1.Name = "uC_Action1";
            this.uC_Action1.Size = new System.Drawing.Size(707, 511);
            this.uC_Action1.TabIndex = 0;
            // 
            // transition2
            // 
            this.transition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transition2.DefaultAnimation = animation2;
            this.transition2.Interval = 2;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(947, 554);
            this.Controls.Add(this.pnlPlaceHolder);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlMenu);
            this.transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FETEL";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlPlaceHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlControl;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private BunifuAnimatorNS.BunifuTransition transition;
        private System.Windows.Forms.Panel pnlPlaceHolder;
        private BunifuAnimatorNS.BunifuTransition transition2;
        public UserControls.UC_Action uC_Action1;
    }
}