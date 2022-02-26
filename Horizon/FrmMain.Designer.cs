using System.Drawing;

namespace Horizon {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnRld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(100, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(672, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged_1);
            this.txtUrl.Enter += new System.EventHandler(this.TxtUrl_Click);
            this.txtUrl.GotFocus += new System.EventHandler(this.TxtUrl_GotFocus);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyPress);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Location = new System.Drawing.Point(-2, 38);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(787, 425);
            this.pContainer.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 20);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Location = new System.Drawing.Point(38, 12);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(25, 20);
            this.btnFwd.TabIndex = 4;
            this.btnFwd.Text = "->";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnRld
            // 
            this.btnRld.Location = new System.Drawing.Point(69, 12);
            this.btnRld.Name = "btnRld";
            this.btnRld.Size = new System.Drawing.Size(25, 20);
            this.btnRld.TabIndex = 5;
            this.btnRld.UseVisualStyleBackColor = true;
            this.btnRld.Click += new System.EventHandler(this.btnRld_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRld);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.txtUrl);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtUrl_TextChanged(object sender, System.EventArgs e) {
            //throw new System.NotImplementedException();
        }

        private void BtnGo_Click(object sender, System.EventArgs e) {
            //throw new System.NotImplementedException();
        }

        private void TxtUrl_Click(object sender, System.EventArgs e) {
            //throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnRld;
    }
}