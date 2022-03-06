
namespace Budget_App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clickLabel = new System.Windows.Forms.LinkLabel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.passwordtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nametxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.forgetpasswordbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.loginbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(56, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(56, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(197, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Don\'t have accoun yet?";
            // 
            // clickLabel
            // 
            this.clickLabel.AutoSize = true;
            this.clickLabel.LinkColor = System.Drawing.Color.Indigo;
            this.clickLabel.Location = new System.Drawing.Point(185, 293);
            this.clickLabel.Name = "clickLabel";
            this.clickLabel.Size = new System.Drawing.Size(71, 21);
            this.clickLabel.TabIndex = 4;
            this.clickLabel.TabStop = true;
            this.clickLabel.Text = "Sign Up";
            this.clickLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickLabel_LinkClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Budget_App.Properties.Resources.red;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Budget_App.Properties.Resources.yellow;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::Budget_App.Properties.Resources.yellow;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Budget_App.Properties.Resources.blue;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // passwordtxt
            // 
            this.passwordtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.passwordtxt.Location = new System.Drawing.Point(56, 168);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Palette = this.kryptonPalette1;
            this.passwordtxt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.passwordtxt.Size = new System.Drawing.Size(360, 33);
            this.passwordtxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordtxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordtxt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordtxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordtxt.StateCommon.Border.Rounding = 18;
            this.passwordtxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordtxt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passwordtxt.TabIndex = 1;
            // 
            // nametxt
            // 
            this.nametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nametxt.Location = new System.Drawing.Point(56, 98);
            this.nametxt.Name = "nametxt";
            this.nametxt.Palette = this.kryptonPalette1;
            this.nametxt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.nametxt.Size = new System.Drawing.Size(360, 33);
            this.nametxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nametxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nametxt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nametxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nametxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nametxt.StateCommon.Border.Rounding = 18;
            this.nametxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.nametxt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nametxt.TabIndex = 0;
            // 
            // forgetpasswordbtn
            // 
            this.forgetpasswordbtn.Location = new System.Drawing.Point(28, 232);
            this.forgetpasswordbtn.Name = "forgetpasswordbtn";
            this.forgetpasswordbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.forgetpasswordbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.forgetpasswordbtn.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.forgetpasswordbtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.OverrideDefault.Border.ColorAngle = 45F;
            this.forgetpasswordbtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.forgetpasswordbtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.forgetpasswordbtn.OverrideDefault.Border.Rounding = 18;
            this.forgetpasswordbtn.OverrideDefault.Border.Width = 1;
            this.forgetpasswordbtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.OverrideFocus.Back.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.OverrideFocus.Back.Color2 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.OverrideFocus.Back.ColorAngle = 130F;
            this.forgetpasswordbtn.OverrideFocus.Border.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.OverrideFocus.Border.Color2 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.forgetpasswordbtn.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.forgetpasswordbtn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.forgetpasswordbtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.forgetpasswordbtn.Size = new System.Drawing.Size(179, 44);
            this.forgetpasswordbtn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.forgetpasswordbtn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.forgetpasswordbtn.StateCommon.Border.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StateCommon.Border.Color2 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StateCommon.Border.ColorAngle = 45F;
            this.forgetpasswordbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.forgetpasswordbtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.forgetpasswordbtn.StateCommon.Border.Rounding = 18;
            this.forgetpasswordbtn.StateCommon.Border.Width = 1;
            this.forgetpasswordbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpasswordbtn.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.forgetpasswordbtn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.forgetpasswordbtn.StatePressed.Border.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrchid;
            this.forgetpasswordbtn.StatePressed.Border.ColorAngle = 130F;
            this.forgetpasswordbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.forgetpasswordbtn.StatePressed.Border.Rounding = 18;
            this.forgetpasswordbtn.StatePressed.Border.Width = 1;
            this.forgetpasswordbtn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.forgetpasswordbtn.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.forgetpasswordbtn.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.forgetpasswordbtn.StateTracking.Back.ColorAngle = 45F;
            this.forgetpasswordbtn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.forgetpasswordbtn.StateTracking.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.forgetpasswordbtn.StateTracking.Border.Color2 = System.Drawing.Color.Indigo;
            this.forgetpasswordbtn.StateTracking.Border.ColorAngle = 45F;
            this.forgetpasswordbtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.forgetpasswordbtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.forgetpasswordbtn.StateTracking.Border.Rounding = 18;
            this.forgetpasswordbtn.StateTracking.Border.Width = 1;
            this.forgetpasswordbtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.forgetpasswordbtn.TabIndex = 3;
            this.forgetpasswordbtn.Values.Text = "Forget password";
            this.forgetpasswordbtn.Click += new System.EventHandler(this.forgetpasswordbtn_Click_1);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(260, 232);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.Indigo;
            this.loginbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.loginbtn.OverrideDefault.Back.ColorAngle = 45F;
            this.loginbtn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginbtn.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.loginbtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Indigo;
            this.loginbtn.OverrideDefault.Border.ColorAngle = 45F;
            this.loginbtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginbtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginbtn.OverrideDefault.Border.Rounding = 18;
            this.loginbtn.OverrideDefault.Border.Width = 1;
            this.loginbtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.loginbtn.Size = new System.Drawing.Size(160, 44);
            this.loginbtn.StateCommon.Back.Color1 = System.Drawing.Color.Indigo;
            this.loginbtn.StateCommon.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.loginbtn.StateCommon.Border.Color1 = System.Drawing.Color.Indigo;
            this.loginbtn.StateCommon.Border.Color2 = System.Drawing.Color.Indigo;
            this.loginbtn.StateCommon.Border.ColorAngle = 45F;
            this.loginbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginbtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginbtn.StateCommon.Border.Rounding = 18;
            this.loginbtn.StateCommon.Border.Width = 1;
            this.loginbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.loginbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.loginbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrchid;
            this.loginbtn.StatePressed.Back.Color2 = System.Drawing.Color.Indigo;
            this.loginbtn.StatePressed.Back.ColorAngle = 130F;
            this.loginbtn.StatePressed.Border.Color1 = System.Drawing.Color.Indigo;
            this.loginbtn.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrchid;
            this.loginbtn.StatePressed.Border.ColorAngle = 130F;
            this.loginbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginbtn.StatePressed.Border.Rounding = 18;
            this.loginbtn.StatePressed.Border.Width = 1;
            this.loginbtn.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.loginbtn.StateTracking.Back.Color2 = System.Drawing.Color.Indigo;
            this.loginbtn.StateTracking.Back.ColorAngle = 45F;
            this.loginbtn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginbtn.StateTracking.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.loginbtn.StateTracking.Border.Color2 = System.Drawing.Color.Indigo;
            this.loginbtn.StateTracking.Border.ColorAngle = 45F;
            this.loginbtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.loginbtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.loginbtn.StateTracking.Border.Rounding = 18;
            this.loginbtn.StateTracking.Border.Width = 1;
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Values.Text = "Login";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 325);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.forgetpasswordbtn);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.clickLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel clickLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nametxt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton forgetpasswordbtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton loginbtn;
    }
}