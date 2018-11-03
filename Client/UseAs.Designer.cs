namespace Client
{
    partial class UseAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseAs));
            this.lblUseAs = new System.Windows.Forms.Label();
            this.cmbxUseAs = new System.Windows.Forms.ComboBox();
            this.pbxRobot = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUseAs
            // 
            this.lblUseAs.AutoSize = true;
            this.lblUseAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(50)), true);
            this.lblUseAs.Location = new System.Drawing.Point(145, 21);
            this.lblUseAs.Name = "lblUseAs";
            this.lblUseAs.Size = new System.Drawing.Size(51, 13);
            this.lblUseAs.TabIndex = 0;
            this.lblUseAs.Text = "Use As:";
            // 
            // cmbxUseAs
            // 
            this.cmbxUseAs.FormattingEnabled = true;
            this.cmbxUseAs.Location = new System.Drawing.Point(148, 51);
            this.cmbxUseAs.Name = "cmbxUseAs";
            this.cmbxUseAs.Size = new System.Drawing.Size(125, 21);
            this.cmbxUseAs.TabIndex = 1;
            // 
            // pbxRobot
            // 
            this.pbxRobot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxRobot.BackgroundImage")));
            this.pbxRobot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRobot.Location = new System.Drawing.Point(35, 21);
            this.pbxRobot.Name = "pbxRobot";
            this.pbxRobot.Size = new System.Drawing.Size(75, 100);
            this.pbxRobot.TabIndex = 2;
            this.pbxRobot.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(223, 98);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 98);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UseAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbxRobot);
            this.Controls.Add(this.cmbxUseAs);
            this.Controls.Add(this.lblUseAs);
            this.Name = "UseAs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UseAs";
            this.Load += new System.EventHandler(this.UseAs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRobot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUseAs;
        private System.Windows.Forms.ComboBox cmbxUseAs;
        private System.Windows.Forms.PictureBox pbxRobot;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
    }
}