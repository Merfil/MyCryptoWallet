namespace MyCryptoWallet.WF
{
    partial class MainForm
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonCoins = new System.Windows.Forms.Button();
            this.buttonWallet = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReview = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelNavigation.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonAdmin);
            this.panelNavigation.Controls.Add(this.buttonCoins);
            this.panelNavigation.Controls.Add(this.buttonWallet);
            this.panelNavigation.Controls.Add(this.buttonExit);
            this.panelNavigation.Controls.Add(this.buttonReview);
            this.panelNavigation.Controls.Add(this.panelImage);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 20);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(169, 436);
            this.panelNavigation.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 240);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(169, 40);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Админ";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonCoins
            // 
            this.buttonCoins.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCoins.FlatAppearance.BorderSize = 0;
            this.buttonCoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCoins.Location = new System.Drawing.Point(0, 200);
            this.buttonCoins.Name = "buttonCoins";
            this.buttonCoins.Size = new System.Drawing.Size(169, 40);
            this.buttonCoins.TabIndex = 1;
            this.buttonCoins.Text = "Торговля";
            this.buttonCoins.UseVisualStyleBackColor = true;
            this.buttonCoins.Click += new System.EventHandler(this.buttonCoins_Click);
            // 
            // buttonWallet
            // 
            this.buttonWallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWallet.FlatAppearance.BorderSize = 0;
            this.buttonWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWallet.Location = new System.Drawing.Point(0, 160);
            this.buttonWallet.Name = "buttonWallet";
            this.buttonWallet.Size = new System.Drawing.Size(169, 40);
            this.buttonWallet.TabIndex = 1;
            this.buttonWallet.Text = "Портфель";
            this.buttonWallet.UseVisualStyleBackColor = true;
            this.buttonWallet.Click += new System.EventHandler(this.buttonWallet_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(0, 396);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(169, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReview
            // 
            this.buttonReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReview.FlatAppearance.BorderSize = 0;
            this.buttonReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReview.Location = new System.Drawing.Point(0, 120);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(169, 40);
            this.buttonReview.TabIndex = 1;
            this.buttonReview.Text = "Обзор";
            this.buttonReview.UseVisualStyleBackColor = true;
            // 
            // panelImage
            // 
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(169, 120);
            this.panelImage.TabIndex = 0;
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.buttonExit2);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(825, 20);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // buttonExit2
            // 
            this.buttonExit2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit2.FlatAppearance.BorderSize = 0;
            this.buttonExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit2.Location = new System.Drawing.Point(785, 0);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(40, 20);
            this.buttonExit2.TabIndex = 0;
            this.buttonExit2.Text = "X";
            this.buttonExit2.UseVisualStyleBackColor = true;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(169, 66);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(656, 390);
            this.panelMain.TabIndex = 2;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(175, 23);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(77, 30);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Обзор";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 456);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelNavigation.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelNavigation;
        private Button buttonCoins;
        private Button buttonWallet;
        private Button buttonExit;
        private Button buttonReview;
        private Panel panelImage;
        private Panel TitleBar;
        private Panel panelMain;
        private Button buttonExit2;
        private Label labelHeader;
        private Button buttonAdmin;
    }
}