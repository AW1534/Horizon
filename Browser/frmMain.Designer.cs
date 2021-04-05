namespace Horizon
{
    partial class frmMain
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
            this.btnGo = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.ThemeSelector = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Theme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pContainer.SuspendLayout();
            this.ThemeSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(750, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(38, 20);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Controls.Add(this.ThemeSelector);
            this.pContainer.ForeColor = System.Drawing.Color.Black;
            this.pContainer.Location = new System.Drawing.Point(-1, 38);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(802, 413);
            this.pContainer.TabIndex = 1;
            // 
            // ThemeSelector
            // 
            this.ThemeSelector.AutoScroll = true;
            this.ThemeSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ThemeSelector.Controls.Add(this.label1);
            this.ThemeSelector.Dock = System.Windows.Forms.DockStyle.Right;
            this.ThemeSelector.Location = new System.Drawing.Point(489, 0);
            this.ThemeSelector.Name = "ThemeSelector";
            this.ThemeSelector.Size = new System.Drawing.Size(313, 413);
            this.ThemeSelector.TabIndex = 0;
            this.ThemeSelector.Visible = false;
            this.ThemeSelector.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(113, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(572, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(4, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(28, 20);
            this.Back.TabIndex = 3;
            this.Back.Text = "<";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(79, 11);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(28, 21);
            this.Forward.TabIndex = 4;
            this.Forward.Text = ">";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(39, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(29, 20);
            this.Refresh.TabIndex = 5;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Theme
            // 
            this.Theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Theme.Location = new System.Drawing.Point(691, 12);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(53, 20);
            this.Theme.TabIndex = 6;
            this.Theme.Text = "Theme";
            this.Theme.UseVisualStyleBackColor = true;
            this.Theme.Click += new System.EventHandler(this.Theme_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(97, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "YEah i may or may not have not finished this theme menu...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Theme);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.btnGo);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pContainer.ResumeLayout(false);
            this.ThemeSelector.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Panel ThemeSelector;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Theme;
        private System.Windows.Forms.Label label1;
    }
}

