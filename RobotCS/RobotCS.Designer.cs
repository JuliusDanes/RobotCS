namespace RobotCS
{
    partial class RobotCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotCS));
            this.lblEncDegR = new System.Windows.Forms.Label();
            this.lblEncCommaR = new System.Windows.Forms.Label();
            this.lblEncoderR = new System.Windows.Forms.Label();
            this.lblPipeR = new System.Windows.Forms.Label();
            this.lblPipeBS = new System.Windows.Forms.Label();
            this.lblConnectionBS = new System.Windows.Forms.Label();
            this.lblBaseStation = new System.Windows.Forms.Label();
            this.grpBaseStation = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbxEncAngleR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxEncYR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxEncXR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxPortR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxIPR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxPortBS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxIPBS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbxMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbxStatus = new System.Windows.Forms.RichTextBox();
            this.lblRobot = new System.Windows.Forms.Label();
            this.lblConnectionR = new System.Windows.Forms.Label();
            this.lblGotoCommaR = new System.Windows.Forms.Label();
            this.lblGoto = new System.Windows.Forms.Label();
            this.tbxGotoY = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxGotoX = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.grpRobot = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblPipe2R = new System.Windows.Forms.Label();
            this.lblPipe3R = new System.Windows.Forms.Label();
            this.tbxGotoAngleR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblGotoDegR = new System.Windows.Forms.Label();
            this.chkR3 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkR2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkR1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnTO = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblEncDegR
            // 
            this.lblEncDegR.BackColor = System.Drawing.Color.Transparent;
            this.lblEncDegR.Enabled = false;
            this.lblEncDegR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblEncDegR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEncDegR.Location = new System.Drawing.Point(196, 54);
            this.lblEncDegR.Name = "lblEncDegR";
            this.lblEncDegR.Size = new System.Drawing.Size(10, 20);
            this.lblEncDegR.TabIndex = 186;
            this.lblEncDegR.Text = "o";
            this.lblEncDegR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEncCommaR
            // 
            this.lblEncCommaR.BackColor = System.Drawing.Color.Transparent;
            this.lblEncCommaR.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblEncCommaR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEncCommaR.Location = new System.Drawing.Point(118, 60);
            this.lblEncCommaR.Name = "lblEncCommaR";
            this.lblEncCommaR.Size = new System.Drawing.Size(12, 20);
            this.lblEncCommaR.TabIndex = 181;
            this.lblEncCommaR.Text = ",";
            // 
            // lblEncoderR
            // 
            this.lblEncoderR.BackColor = System.Drawing.Color.Transparent;
            this.lblEncoderR.Enabled = false;
            this.lblEncoderR.Font = new System.Drawing.Font("Arial", 9F);
            this.lblEncoderR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEncoderR.Location = new System.Drawing.Point(22, 62);
            this.lblEncoderR.Name = "lblEncoderR";
            this.lblEncoderR.Size = new System.Drawing.Size(58, 20);
            this.lblEncoderR.TabIndex = 176;
            this.lblEncoderR.Text = "Encoder:";
            // 
            // lblPipeR
            // 
            this.lblPipeR.BackColor = System.Drawing.Color.Transparent;
            this.lblPipeR.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPipeR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPipeR.Location = new System.Drawing.Point(117, 39);
            this.lblPipeR.Name = "lblPipeR";
            this.lblPipeR.Size = new System.Drawing.Size(12, 20);
            this.lblPipeR.TabIndex = 175;
            this.lblPipeR.Text = "|";
            // 
            // lblPipeBS
            // 
            this.lblPipeBS.BackColor = System.Drawing.Color.Transparent;
            this.lblPipeBS.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPipeBS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPipeBS.Location = new System.Drawing.Point(117, 141);
            this.lblPipeBS.Name = "lblPipeBS";
            this.lblPipeBS.Size = new System.Drawing.Size(12, 20);
            this.lblPipeBS.TabIndex = 190;
            this.lblPipeBS.Text = "|";
            // 
            // lblConnectionBS
            // 
            this.lblConnectionBS.BackColor = System.Drawing.Color.Firebrick;
            this.lblConnectionBS.Font = new System.Drawing.Font("Arial", 9F);
            this.lblConnectionBS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConnectionBS.Location = new System.Drawing.Point(177, 115);
            this.lblConnectionBS.Name = "lblConnectionBS";
            this.lblConnectionBS.Size = new System.Drawing.Size(85, 20);
            this.lblConnectionBS.TabIndex = 189;
            this.lblConnectionBS.Text = "Disconnected";
            this.lblConnectionBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConnectionBS.TextChanged += new System.EventHandler(this.lblConnection_TextChanged);
            this.lblConnectionBS.Click += new System.EventHandler(this.Disconnect_byDistinct);
            // 
            // lblBaseStation
            // 
            this.lblBaseStation.BackColor = System.Drawing.Color.Transparent;
            this.lblBaseStation.Enabled = false;
            this.lblBaseStation.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblBaseStation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBaseStation.Location = new System.Drawing.Point(22, 121);
            this.lblBaseStation.Name = "lblBaseStation";
            this.lblBaseStation.Size = new System.Drawing.Size(100, 15);
            this.lblBaseStation.TabIndex = 188;
            this.lblBaseStation.Text = "BaseStation";
            // 
            // grpBaseStation
            // 
            this.grpBaseStation.AutoSize = true;
            this.grpBaseStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBaseStation.Depth = 0;
            this.grpBaseStation.Icon = null;
            this.grpBaseStation.Location = new System.Drawing.Point(12, 114);
            this.grpBaseStation.MinimumSize = new System.Drawing.Size(270, 100);
            this.grpBaseStation.MouseState = MaterialSkin.MouseState.HOVER;
            this.grpBaseStation.Name = "grpBaseStation";
            this.grpBaseStation.Primary = true;
            this.grpBaseStation.Size = new System.Drawing.Size(270, 100);
            this.grpBaseStation.TabIndex = 187;
            this.grpBaseStation.UseVisualStyleBackColor = true;
            this.grpBaseStation.Click += new System.EventHandler(this.grpBaseStation_Click);
            // 
            // tbxEncAngleR
            // 
            this.tbxEncAngleR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxEncAngleR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEncAngleR.Enabled = false;
            this.tbxEncAngleR.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxEncAngleR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEncAngleR.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEncAngleR.HintText = "deg";
            this.tbxEncAngleR.isPassword = false;
            this.tbxEncAngleR.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxEncAngleR.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxEncAngleR.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxEncAngleR.LineThickness = 1;
            this.tbxEncAngleR.Location = new System.Drawing.Point(165, 53);
            this.tbxEncAngleR.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEncAngleR.Name = "tbxEncAngleR";
            this.tbxEncAngleR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxEncAngleR.Size = new System.Drawing.Size(35, 25);
            this.tbxEncAngleR.TabIndex = 197;
            this.tbxEncAngleR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxEncAngleR.OnValueChanged += new System.EventHandler(this.tbxXY_TextChanged);
            this.tbxEncAngleR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeCounter);
            // 
            // tbxEncYR
            // 
            this.tbxEncYR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxEncYR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEncYR.Enabled = false;
            this.tbxEncYR.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxEncYR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEncYR.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEncYR.HintText = "Y";
            this.tbxEncYR.isPassword = false;
            this.tbxEncYR.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxEncYR.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxEncYR.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxEncYR.LineThickness = 1;
            this.tbxEncYR.Location = new System.Drawing.Point(126, 53);
            this.tbxEncYR.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEncYR.Name = "tbxEncYR";
            this.tbxEncYR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxEncYR.Size = new System.Drawing.Size(45, 25);
            this.tbxEncYR.TabIndex = 194;
            this.tbxEncYR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxEncYR.OnValueChanged += new System.EventHandler(this.tbxXY_TextChanged);
            this.tbxEncYR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeCounter);
            // 
            // tbxEncXR
            // 
            this.tbxEncXR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxEncXR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEncXR.Enabled = false;
            this.tbxEncXR.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxEncXR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEncXR.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEncXR.HintText = "X";
            this.tbxEncXR.isPassword = false;
            this.tbxEncXR.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxEncXR.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxEncXR.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxEncXR.LineThickness = 1;
            this.tbxEncXR.Location = new System.Drawing.Point(76, 53);
            this.tbxEncXR.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEncXR.Name = "tbxEncXR";
            this.tbxEncXR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxEncXR.Size = new System.Drawing.Size(45, 25);
            this.tbxEncXR.TabIndex = 193;
            this.tbxEncXR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxEncXR.OnValueChanged += new System.EventHandler(this.tbxXY_TextChanged);
            this.tbxEncXR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeCounter);
            // 
            // tbxPortR
            // 
            this.tbxPortR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxPortR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPortR.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxPortR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxPortR.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxPortR.HintText = "Port";
            this.tbxPortR.isPassword = false;
            this.tbxPortR.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxPortR.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxPortR.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxPortR.LineThickness = 1;
            this.tbxPortR.Location = new System.Drawing.Point(126, 34);
            this.tbxPortR.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPortR.Name = "tbxPortR";
            this.tbxPortR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxPortR.Size = new System.Drawing.Size(45, 25);
            this.tbxPortR.TabIndex = 192;
            this.tbxPortR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPortR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxOpenServer_KeyDown);
            // 
            // tbxIPR
            // 
            this.tbxIPR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxIPR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxIPR.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxIPR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxIPR.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxIPR.HintText = "IP Address";
            this.tbxIPR.isPassword = false;
            this.tbxIPR.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxIPR.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxIPR.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxIPR.LineThickness = 1;
            this.tbxIPR.Location = new System.Drawing.Point(18, 34);
            this.tbxIPR.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIPR.Name = "tbxIPR";
            this.tbxIPR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxIPR.Size = new System.Drawing.Size(100, 25);
            this.tbxIPR.TabIndex = 191;
            this.tbxIPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxIPR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxOpenServer_KeyDown);
            // 
            // tbxPortBS
            // 
            this.tbxPortBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxPortBS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPortBS.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxPortBS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxPortBS.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxPortBS.HintText = "Port";
            this.tbxPortBS.isPassword = false;
            this.tbxPortBS.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxPortBS.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxPortBS.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxPortBS.LineThickness = 1;
            this.tbxPortBS.Location = new System.Drawing.Point(126, 136);
            this.tbxPortBS.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPortBS.Name = "tbxPortBS";
            this.tbxPortBS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxPortBS.Size = new System.Drawing.Size(45, 25);
            this.tbxPortBS.TabIndex = 199;
            this.tbxPortBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPortBS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connection_KeyEnter);
            // 
            // tbxIPBS
            // 
            this.tbxIPBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxIPBS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxIPBS.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxIPBS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxIPBS.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxIPBS.HintText = "IP Address";
            this.tbxIPBS.isPassword = false;
            this.tbxIPBS.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxIPBS.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxIPBS.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxIPBS.LineThickness = 1;
            this.tbxIPBS.Location = new System.Drawing.Point(18, 136);
            this.tbxIPBS.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIPBS.Name = "tbxIPBS";
            this.tbxIPBS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxIPBS.Size = new System.Drawing.Size(100, 25);
            this.tbxIPBS.TabIndex = 198;
            this.tbxIPBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxIPBS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connection_KeyEnter);
            // 
            // btnSend
            // 
            this.btnSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.BorderRadius = 0;
            this.btnSend.ButtonText = "Send";
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledColor = System.Drawing.Color.Gray;
            this.btnSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSend.Iconimage")));
            this.btnSend.Iconimage_right = null;
            this.btnSend.Iconimage_right_Selected = null;
            this.btnSend.Iconimage_Selected = null;
            this.btnSend.IconMarginLeft = 0;
            this.btnSend.IconMarginRight = 0;
            this.btnSend.IconRightVisible = true;
            this.btnSend.IconRightZoom = 0D;
            this.btnSend.IconVisible = true;
            this.btnSend.IconZoom = 90D;
            this.btnSend.IsTab = false;
            this.btnSend.Location = new System.Drawing.Point(689, 131);
            this.btnSend.Name = "btnSend";
            this.btnSend.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSend.selected = false;
            this.btnSend.Size = new System.Drawing.Size(80, 25);
            this.btnSend.TabIndex = 201;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Textcolor = System.Drawing.Color.White;
            this.btnSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMessage
            // 
            this.tbxMessage.Depth = 0;
            this.tbxMessage.Hint = "@SendMessage";
            this.tbxMessage.Location = new System.Drawing.Point(473, 121);
            this.tbxMessage.MaxLength = 32767;
            this.tbxMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.PasswordChar = '\0';
            this.tbxMessage.SelectedText = "";
            this.tbxMessage.SelectionLength = 0;
            this.tbxMessage.SelectionStart = 0;
            this.tbxMessage.Size = new System.Drawing.Size(243, 23);
            this.tbxMessage.TabIndex = 200;
            this.tbxMessage.TabStop = false;
            this.tbxMessage.UseSystemPasswordChar = false;
            this.tbxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMessage_KeyDown);
            // 
            // tbxStatus
            // 
            this.tbxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbxStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.tbxStatus.Location = new System.Drawing.Point(292, 14);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(480, 100);
            this.tbxStatus.TabIndex = 202;
            this.tbxStatus.Text = "";
            this.tbxStatus.TextChanged += new System.EventHandler(this.tbxStatus_TextChanged);
            // 
            // lblRobot
            // 
            this.lblRobot.BackColor = System.Drawing.Color.Transparent;
            this.lblRobot.Enabled = false;
            this.lblRobot.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblRobot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRobot.Location = new System.Drawing.Point(22, 19);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(65, 15);
            this.lblRobot.TabIndex = 173;
            this.lblRobot.Text = "Robot";
            // 
            // lblConnectionR
            // 
            this.lblConnectionR.BackColor = System.Drawing.Color.Firebrick;
            this.lblConnectionR.Font = new System.Drawing.Font("Arial", 9F);
            this.lblConnectionR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConnectionR.Location = new System.Drawing.Point(222, 13);
            this.lblConnectionR.Name = "lblConnectionR";
            this.lblConnectionR.Size = new System.Drawing.Size(40, 20);
            this.lblConnectionR.TabIndex = 208;
            this.lblConnectionR.Text = "Close";
            this.lblConnectionR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConnectionR.TextChanged += new System.EventHandler(this.lblConnection_TextChanged);
            this.lblConnectionR.Click += new System.EventHandler(this.Disconnect_byDistinct);
            // 
            // lblGotoCommaR
            // 
            this.lblGotoCommaR.BackColor = System.Drawing.Color.Transparent;
            this.lblGotoCommaR.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblGotoCommaR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGotoCommaR.Location = new System.Drawing.Point(118, 77);
            this.lblGotoCommaR.Name = "lblGotoCommaR";
            this.lblGotoCommaR.Size = new System.Drawing.Size(12, 20);
            this.lblGotoCommaR.TabIndex = 182;
            this.lblGotoCommaR.Text = ",";
            // 
            // lblGoto
            // 
            this.lblGoto.BackColor = System.Drawing.Color.Transparent;
            this.lblGoto.Enabled = false;
            this.lblGoto.Font = new System.Drawing.Font("Arial", 9F);
            this.lblGoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGoto.Location = new System.Drawing.Point(22, 79);
            this.lblGoto.Name = "lblGoto";
            this.lblGoto.Size = new System.Drawing.Size(58, 20);
            this.lblGoto.TabIndex = 177;
            this.lblGoto.Text = "Goto       :";
            // 
            // tbxGotoY
            // 
            this.tbxGotoY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxGotoY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxGotoY.Enabled = false;
            this.tbxGotoY.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxGotoY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxGotoY.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxGotoY.HintText = "Y";
            this.tbxGotoY.isPassword = false;
            this.tbxGotoY.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxGotoY.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxGotoY.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxGotoY.LineThickness = 1;
            this.tbxGotoY.Location = new System.Drawing.Point(126, 70);
            this.tbxGotoY.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGotoY.Name = "tbxGotoY";
            this.tbxGotoY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxGotoY.Size = new System.Drawing.Size(45, 25);
            this.tbxGotoY.TabIndex = 196;
            this.tbxGotoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxGotoY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxGoto_KeyDown);
            // 
            // tbxGotoX
            // 
            this.tbxGotoX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxGotoX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxGotoX.Enabled = false;
            this.tbxGotoX.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxGotoX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxGotoX.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxGotoX.HintText = "X";
            this.tbxGotoX.isPassword = false;
            this.tbxGotoX.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxGotoX.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxGotoX.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxGotoX.LineThickness = 1;
            this.tbxGotoX.Location = new System.Drawing.Point(76, 70);
            this.tbxGotoX.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGotoX.Name = "tbxGotoX";
            this.tbxGotoX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxGotoX.Size = new System.Drawing.Size(45, 25);
            this.tbxGotoX.TabIndex = 195;
            this.tbxGotoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxGotoX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxGoto_KeyDown);
            // 
            // grpRobot
            // 
            this.grpRobot.AutoSize = true;
            this.grpRobot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpRobot.Depth = 0;
            this.grpRobot.Icon = null;
            this.grpRobot.Location = new System.Drawing.Point(12, 12);
            this.grpRobot.MinimumSize = new System.Drawing.Size(270, 100);
            this.grpRobot.MouseState = MaterialSkin.MouseState.HOVER;
            this.grpRobot.Name = "grpRobot";
            this.grpRobot.Primary = true;
            this.grpRobot.Size = new System.Drawing.Size(270, 100);
            this.grpRobot.TabIndex = 172;
            this.grpRobot.UseVisualStyleBackColor = true;
            this.grpRobot.Click += new System.EventHandler(this.grpRobot_Click);
            // 
            // lblPipe2R
            // 
            this.lblPipe2R.BackColor = System.Drawing.Color.Transparent;
            this.lblPipe2R.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPipe2R.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPipe2R.Location = new System.Drawing.Point(160, 58);
            this.lblPipe2R.Name = "lblPipe2R";
            this.lblPipe2R.Size = new System.Drawing.Size(10, 20);
            this.lblPipe2R.TabIndex = 185;
            this.lblPipe2R.Text = "|";
            this.lblPipe2R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPipe3R
            // 
            this.lblPipe3R.BackColor = System.Drawing.Color.Transparent;
            this.lblPipe3R.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPipe3R.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPipe3R.Location = new System.Drawing.Point(160, 79);
            this.lblPipe3R.Name = "lblPipe3R";
            this.lblPipe3R.Size = new System.Drawing.Size(10, 20);
            this.lblPipe3R.TabIndex = 210;
            this.lblPipe3R.Text = "|";
            this.lblPipe3R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxGotoAngleR
            // 
            this.tbxGotoAngleR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxGotoAngleR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxGotoAngleR.Enabled = false;
            this.tbxGotoAngleR.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbxGotoAngleR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxGotoAngleR.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxGotoAngleR.HintText = "deg";
            this.tbxGotoAngleR.isPassword = false;
            this.tbxGotoAngleR.LineFocusedColor = System.Drawing.Color.Yellow;
            this.tbxGotoAngleR.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbxGotoAngleR.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.tbxGotoAngleR.LineThickness = 1;
            this.tbxGotoAngleR.Location = new System.Drawing.Point(165, 74);
            this.tbxGotoAngleR.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGotoAngleR.Name = "tbxGotoAngleR";
            this.tbxGotoAngleR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxGotoAngleR.Size = new System.Drawing.Size(35, 25);
            this.tbxGotoAngleR.TabIndex = 212;
            this.tbxGotoAngleR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxGotoAngleR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxGoto_KeyDown);
            // 
            // lblGotoDegR
            // 
            this.lblGotoDegR.BackColor = System.Drawing.Color.Transparent;
            this.lblGotoDegR.Enabled = false;
            this.lblGotoDegR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblGotoDegR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGotoDegR.Location = new System.Drawing.Point(196, 75);
            this.lblGotoDegR.Name = "lblGotoDegR";
            this.lblGotoDegR.Size = new System.Drawing.Size(10, 20);
            this.lblGotoDegR.TabIndex = 211;
            this.lblGotoDegR.Text = "o";
            this.lblGotoDegR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkR3
            // 
            this.chkR3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkR3.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkR3.Checked = false;
            this.chkR3.CheckedOnColor = System.Drawing.Color.Black;
            this.chkR3.Enabled = false;
            this.chkR3.ForeColor = System.Drawing.Color.White;
            this.chkR3.Location = new System.Drawing.Point(344, 115);
            this.chkR3.Name = "chkR3";
            this.chkR3.Size = new System.Drawing.Size(20, 20);
            this.chkR3.TabIndex = 215;
            this.chkR3.OnChange += new System.EventHandler(this.ChkRobot_OnChange);
            // 
            // chkR2
            // 
            this.chkR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkR2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkR2.Checked = false;
            this.chkR2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.chkR2.Enabled = false;
            this.chkR2.ForeColor = System.Drawing.Color.White;
            this.chkR2.Location = new System.Drawing.Point(318, 115);
            this.chkR2.Name = "chkR2";
            this.chkR2.Size = new System.Drawing.Size(20, 20);
            this.chkR2.TabIndex = 214;
            this.chkR2.OnChange += new System.EventHandler(this.ChkRobot_OnChange);
            // 
            // chkR1
            // 
            this.chkR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkR1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkR1.Checked = false;
            this.chkR1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(236)))));
            this.chkR1.Enabled = false;
            this.chkR1.ForeColor = System.Drawing.Color.White;
            this.chkR1.Location = new System.Drawing.Point(292, 115);
            this.chkR1.Name = "chkR1";
            this.chkR1.Size = new System.Drawing.Size(20, 20);
            this.chkR1.TabIndex = 213;
            this.chkR1.OnChange += new System.EventHandler(this.ChkRobot_OnChange);
            // 
            // btnTO
            // 
            this.btnTO.ActiveBorderThickness = 1;
            this.btnTO.ActiveCornerRadius = 20;
            this.btnTO.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.btnTO.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTO.ActiveLineColor = System.Drawing.Color.Firebrick;
            this.btnTO.BackColor = System.Drawing.SystemColors.Control;
            this.btnTO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTO.BackgroundImage")));
            this.btnTO.ButtonText = "Try Out";
            this.btnTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTO.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTO.IdleBorderThickness = 1;
            this.btnTO.IdleCornerRadius = 40;
            this.btnTO.IdleFillColor = System.Drawing.Color.Maroon;
            this.btnTO.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.btnTO.IdleLineColor = System.Drawing.Color.Firebrick;
            this.btnTO.Location = new System.Drawing.Point(292, 164);
            this.btnTO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTO.Name = "btnTO";
            this.btnTO.Size = new System.Drawing.Size(80, 50);
            this.btnTO.TabIndex = 216;
            this.btnTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTO.Click += new System.EventHandler(this.btnTO_Click);
            // 
            // RobotCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 236);
            this.Controls.Add(this.btnTO);
            this.Controls.Add(this.chkR3);
            this.Controls.Add(this.chkR2);
            this.Controls.Add(this.chkR1);
            this.Controls.Add(this.lblPipe3R);
            this.Controls.Add(this.tbxGotoAngleR);
            this.Controls.Add(this.lblGotoDegR);
            this.Controls.Add(this.lblPipe2R);
            this.Controls.Add(this.lblConnectionR);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxPortBS);
            this.Controls.Add(this.tbxIPBS);
            this.Controls.Add(this.tbxEncAngleR);
            this.Controls.Add(this.tbxGotoY);
            this.Controls.Add(this.tbxGotoX);
            this.Controls.Add(this.tbxEncYR);
            this.Controls.Add(this.tbxEncXR);
            this.Controls.Add(this.tbxPortR);
            this.Controls.Add(this.tbxIPR);
            this.Controls.Add(this.lblPipeBS);
            this.Controls.Add(this.lblConnectionBS);
            this.Controls.Add(this.lblBaseStation);
            this.Controls.Add(this.grpBaseStation);
            this.Controls.Add(this.lblEncDegR);
            this.Controls.Add(this.lblGotoCommaR);
            this.Controls.Add(this.lblEncCommaR);
            this.Controls.Add(this.lblGoto);
            this.Controls.Add(this.lblEncoderR);
            this.Controls.Add(this.lblPipeR);
            this.Controls.Add(this.lblRobot);
            this.Controls.Add(this.grpRobot);
            this.Name = "RobotCS";
            this.Text = "RobotCS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblEncDegR;
        protected System.Windows.Forms.Label lblEncCommaR;
        protected System.Windows.Forms.Label lblEncoderR;
        protected System.Windows.Forms.Label lblPipeR;
        protected System.Windows.Forms.Label lblPipeBS;
        protected System.Windows.Forms.Label lblConnectionBS;
        protected System.Windows.Forms.Label lblBaseStation;
        protected MaterialSkin.Controls.MaterialRaisedButton grpBaseStation;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxEncAngleR;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxEncYR;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxEncXR;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxPortR;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxIPR;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxPortBS;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxIPBS;
        protected Bunifu.Framework.UI.BunifuFlatButton btnSend;
        protected MaterialSkin.Controls.MaterialSingleLineTextField tbxMessage;
        private System.Windows.Forms.RichTextBox tbxStatus;
        protected System.Windows.Forms.Label lblRobot;
        protected System.Windows.Forms.Label lblConnectionR;
        protected System.Windows.Forms.Label lblGotoCommaR;
        protected System.Windows.Forms.Label lblGoto;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxGotoY;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxGotoX;
        protected MaterialSkin.Controls.MaterialRaisedButton grpRobot;
        protected System.Windows.Forms.Label lblPipe2R;
        protected System.Windows.Forms.Label lblPipe3R;
        protected Bunifu.Framework.UI.BunifuMaterialTextbox tbxGotoAngleR;
        protected System.Windows.Forms.Label lblGotoDegR;
        protected Bunifu.Framework.UI.BunifuCheckbox chkR3;
        protected Bunifu.Framework.UI.BunifuCheckbox chkR2;
        protected Bunifu.Framework.UI.BunifuCheckbox chkR1;
        protected Bunifu.Framework.UI.BunifuThinButton2 btnTO;
    }
}

