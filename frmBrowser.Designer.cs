namespace BuckyNav_Browser
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_back = new System.Windows.Forms.ToolStripButton();
            this.btn_forward = new System.Windows.Forms.ToolStripButton();
            this.btn_home = new System.Windows.Forms.ToolStripButton();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.searchUrlBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_back,
            this.btn_forward,
            this.btn_home,
            this.btn_refresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 48);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_back
            // 
            this.btn_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_back.Margin = new System.Windows.Forms.Padding(15, 10, 5, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(28, 28);
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_forward.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(28, 28);
            this.btn_forward.Text = "Forward";
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_home
            // 
            this.btn_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_home.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(28, 28);
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(28, 28);
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // searchUrlBox
            // 
            this.searchUrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchUrlBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchUrlBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUrlBox.Location = new System.Drawing.Point(166, 12);
            this.searchUrlBox.Name = "searchUrlBox";
            this.searchUrlBox.Size = new System.Drawing.Size(542, 27);
            this.searchUrlBox.TabIndex = 1;
            this.searchUrlBox.Text = "Enter URL";
            this.searchUrlBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchUrlBox_KeyUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 45);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 407);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.searchUrlBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_back;
        private System.Windows.Forms.ToolStripButton btn_forward;
        private System.Windows.Forms.ToolStripButton btn_home;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.TextBox searchUrlBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}