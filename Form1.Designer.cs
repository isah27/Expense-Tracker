namespace Budget_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.inputExpenseBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.costtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.exptxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BALANCE = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.Label();
            this.budgetValue = new System.Windows.Forms.Label();
            this.BALC = new System.Windows.Forms.Label();
            this.acctSetting = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccoutntoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.IDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.updateBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.budgetErrorLabel = new System.Windows.Forms.Label();
            this.inputbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.budgettxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costError = new System.Windows.Forms.Label();
            this.budgetError = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.acctSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineChart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Budget_App.Properties.Resources.red;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Budget_App.Properties.Resources.yellow;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::Budget_App.Properties.Resources.yellow;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Budget_App.Properties.Resources.blue;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = global::Budget_App.Properties.Resources.green;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::Budget_App.Properties.Resources.green;
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
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.costError);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.inputExpenseBtn);
            this.panel2.Controls.Add(this.costtxt);
            this.panel2.Controls.Add(this.exptxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(400, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 316);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(16, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 44);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter your Expenses Here";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputExpenseBtn
            // 
            this.inputExpenseBtn.Location = new System.Drawing.Point(243, 250);
            this.inputExpenseBtn.Name = "inputExpenseBtn";
            this.inputExpenseBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.inputExpenseBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.inputExpenseBtn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputExpenseBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.inputExpenseBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.inputExpenseBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputExpenseBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputExpenseBtn.OverrideDefault.Border.Rounding = 18;
            this.inputExpenseBtn.OverrideDefault.Border.Width = 1;
            this.inputExpenseBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.inputExpenseBtn.Size = new System.Drawing.Size(184, 43);
            this.inputExpenseBtn.StateCommon.Back.Color1 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StateCommon.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.inputExpenseBtn.StateCommon.Border.Color1 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StateCommon.Border.Color2 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StateCommon.Border.ColorAngle = 45F;
            this.inputExpenseBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputExpenseBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputExpenseBtn.StateCommon.Border.Rounding = 18;
            this.inputExpenseBtn.StateCommon.Border.Width = 1;
            this.inputExpenseBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.inputExpenseBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.inputExpenseBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputExpenseBtn.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrchid;
            this.inputExpenseBtn.StatePressed.Back.Color2 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StatePressed.Back.ColorAngle = 130F;
            this.inputExpenseBtn.StatePressed.Border.Color1 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrchid;
            this.inputExpenseBtn.StatePressed.Border.ColorAngle = 130F;
            this.inputExpenseBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputExpenseBtn.StatePressed.Border.Rounding = 18;
            this.inputExpenseBtn.StatePressed.Border.Width = 1;
            this.inputExpenseBtn.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StateTracking.Back.Color2 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StateTracking.Back.ColorAngle = 45F;
            this.inputExpenseBtn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputExpenseBtn.StateTracking.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.inputExpenseBtn.StateTracking.Border.Color2 = System.Drawing.Color.Indigo;
            this.inputExpenseBtn.StateTracking.Border.ColorAngle = 45F;
            this.inputExpenseBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputExpenseBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputExpenseBtn.StateTracking.Border.Rounding = 18;
            this.inputExpenseBtn.StateTracking.Border.Width = 1;
            this.inputExpenseBtn.TabIndex = 2;
            this.inputExpenseBtn.Values.Text = "INPUT EXPENSE";
            this.inputExpenseBtn.Click += new System.EventHandler(this.inputExpenseBtn_Click);
            // 
            // costtxt
            // 
            this.costtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.costtxt.Location = new System.Drawing.Point(57, 178);
            this.costtxt.Name = "costtxt";
            this.costtxt.Palette = this.kryptonPalette1;
            this.costtxt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.costtxt.Size = new System.Drawing.Size(360, 33);
            this.costtxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.costtxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costtxt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.costtxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.costtxt.StateCommon.Border.Rounding = 18;
            this.costtxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.costtxt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.costtxt.TabIndex = 1;
            this.costtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costtxt_KeyPress_1);
            // 
            // exptxt
            // 
            this.exptxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.exptxt.Location = new System.Drawing.Point(57, 106);
            this.exptxt.Name = "exptxt";
            this.exptxt.Palette = this.kryptonPalette1;
            this.exptxt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.exptxt.Size = new System.Drawing.Size(360, 33);
            this.exptxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.exptxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exptxt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exptxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exptxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.exptxt.StateCommon.Border.Rounding = 18;
            this.exptxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.exptxt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exptxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.exptxt.TabIndex = 0;
            this.exptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exptxt_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(63, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expense name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(63, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expense cost";
            // 
            // BALANCE
            // 
            this.BALANCE.AutoSize = true;
            this.BALANCE.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BALANCE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BALANCE.Location = new System.Drawing.Point(7, 12);
            this.BALANCE.Name = "BALANCE";
            this.BALANCE.Size = new System.Drawing.Size(96, 21);
            this.BALANCE.TabIndex = 4;
            this.BALANCE.Text = "BALANCE";
            this.BALANCE.Visible = false;
            // 
            // budget
            // 
            this.budget.AutoSize = true;
            this.budget.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.budget.Location = new System.Drawing.Point(126, 12);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(85, 21);
            this.budget.TabIndex = 5;
            this.budget.Text = "BUDGET";
            this.budget.Visible = false;
            // 
            // budgetValue
            // 
            this.budgetValue.AutoSize = true;
            this.budgetValue.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.budgetValue.Location = new System.Drawing.Point(140, 40);
            this.budgetValue.Name = "budgetValue";
            this.budgetValue.Size = new System.Drawing.Size(0, 22);
            this.budgetValue.TabIndex = 6;
            this.budgetValue.Visible = false;
            // 
            // BALC
            // 
            this.BALC.AutoSize = true;
            this.BALC.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BALC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BALC.Location = new System.Drawing.Point(20, 40);
            this.BALC.Name = "BALC";
            this.BALC.Size = new System.Drawing.Size(0, 22);
            this.BALC.TabIndex = 8;
            this.BALC.Visible = false;
            // 
            // acctSetting
            // 
            this.acctSetting.AllowDrop = true;
            this.acctSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acctSetting.BackColor = System.Drawing.Color.Navy;
            this.acctSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acctSetting.Dock = System.Windows.Forms.DockStyle.None;
            this.acctSetting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.acctSetting.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.acctSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip});
            this.acctSetting.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.acctSetting.Location = new System.Drawing.Point(1058, 9);
            this.acctSetting.Name = "acctSetting";
            this.acctSetting.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.acctSetting.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.acctSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.acctSetting.Size = new System.Drawing.Size(134, 47);
            this.acctSetting.TabIndex = 12;
            this.acctSetting.Text = "Account settings";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoToolTip = true;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ModifyToolStripMenuItem,
            this.createAccoutntoolStripMenuItem1,
            this.deleteAccountToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.toolStrip.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolStrip.MergeIndex = 0;
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(134, 24);
            this.toolStrip.Text = "Account Settings";
            this.toolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ModifyToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.ModifyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Blue;
            this.ModifyToolStripMenuItem.Margin = new System.Windows.Forms.Padding(-2, 0, 0, 0);
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ModifyToolStripMenuItem.Text = "Modify Budget";
            this.ModifyToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ModifyToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createAccoutntoolStripMenuItem1
            // 
            this.createAccoutntoolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.createAccoutntoolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccoutntoolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createAccoutntoolStripMenuItem1.Name = "createAccoutntoolStripMenuItem1";
            this.createAccoutntoolStripMenuItem1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.createAccoutntoolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.createAccoutntoolStripMenuItem1.Text = "Create Account";
            this.createAccoutntoolStripMenuItem1.Click += new System.EventHandler(this.createAccoutntoolStripMenuItem1_Click);
            // 
            // deleteAccountToolStripMenuItem1
            // 
            this.deleteAccountToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.deleteAccountToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAccountToolStripMenuItem1.Name = "deleteAccountToolStripMenuItem1";
            this.deleteAccountToolStripMenuItem1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.deleteAccountToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteAccountToolStripMenuItem1.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem1.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(-5, 0, 0, 0);
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0);
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // PieChart
            // 
            this.PieChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PieChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PieChart.BorderlineColor = System.Drawing.Color.Black;
            this.PieChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.PieChart.BorderSkin.BackColor = System.Drawing.Color.Maroon;
            this.PieChart.BorderSkin.PageColor = System.Drawing.SystemColors.Desktop;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(845, 99);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.PieChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Indigo,
        System.Drawing.Color.Red};
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "s1";
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(382, 217);
            this.PieChart.TabIndex = 14;
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title1.BorderWidth = 0;
            title1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "Balance Vs Expense";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.PieChart.Titles.Add(title1);
            // 
            // spineChart
            // 
            this.spineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.spineChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.spineChart.Legends.Add(legend2);
            this.spineChart.Location = new System.Drawing.Point(405, 322);
            this.spineChart.Name = "spineChart";
            series2.BackSecondaryColor = System.Drawing.Color.Red;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.Name = "s2";
            this.spineChart.Series.Add(series2);
            this.spineChart.Size = new System.Drawing.Size(824, 270);
            this.spineChart.TabIndex = 15;
            title2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            title2.Text = "Expense Trends in respect to dates";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.spineChart.Titles.Add(title2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.budget);
            this.panel3.Controls.Add(this.BALANCE);
            this.panel3.Controls.Add(this.budgetValue);
            this.panel3.Controls.Add(this.BALC);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(837, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 83);
            this.panel3.TabIndex = 16;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDS,
            this.userid,
            this.expDesc,
            this.cost,
            this.date,
            this.deleteBtn,
            this.updateBtn});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Palette = this.kryptonPalette1;
            this.DataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(398, 594);
            this.DataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.DataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.StateCommon.Background.ColorAngle = 45F;
            this.DataGridView1.StateCommon.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.DataGridView1.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.DataGridView1.StateCommon.DataCell.Back.ColorAngle = 5F;
            this.DataGridView1.StateCommon.DataCell.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.SystemColors.Desktop;
            this.DataGridView1.StateCommon.DataCell.Border.Color2 = System.Drawing.SystemColors.Desktop;
            this.DataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridView1.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.DataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Indigo;
            this.DataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.DataGridView1.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.DataGridView1.StateCommon.HeaderColumn.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Indigo;
            this.DataGridView1.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Indigo;
            this.DataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridView1.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DataGridView1.StateCommon.HeaderColumn.Border.Rounding = 2;
            this.DataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridView1.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.DataGridView1.StateCommon.HeaderColumn.Content.ColorAngle = 25F;
            this.DataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridView1.StateNormal.Background.Color1 = System.Drawing.Color.MediumOrchid;
            this.DataGridView1.TabIndex = 17;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // IDS
            // 
            this.IDS.DataPropertyName = "id";
            this.IDS.HeaderText = "IDS";
            this.IDS.Name = "IDS";
            this.IDS.ReadOnly = true;
            this.IDS.Visible = false;
            this.IDS.Width = 53;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userId";
            this.userid.HeaderText = "userid";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Visible = false;
            this.userid.Width = 68;
            // 
            // expDesc
            // 
            this.expDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expDesc.DataPropertyName = "expDesc";
            this.expDesc.HeaderText = "Expense Names";
            this.expDesc.Name = "expDesc";
            this.expDesc.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "expCost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 64;
            // 
            // date
            // 
            this.date.DataPropertyName = "dates";
            this.date.HeaderText = "Dates";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 72;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.ToolTipText = "Delete";
            this.dataGridViewImageColumn1.Width = 23;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 23;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deleteBtn.HeaderText = "";
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteBtn.ToolTipText = "Delete";
            this.deleteBtn.Width = 23;
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.updateBtn.HeaderText = "";
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ReadOnly = true;
            this.updateBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updateBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.updateBtn.Width = 23;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.budgetError);
            this.panel1.Controls.Add(this.budgetErrorLabel);
            this.panel1.Controls.Add(this.inputbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.budgettxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(403, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 201);
            this.panel1.TabIndex = 1;
            // 
            // budgetErrorLabel
            // 
            this.budgetErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetErrorLabel.AutoSize = true;
            this.budgetErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.budgetErrorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.budgetErrorLabel.Location = new System.Drawing.Point(192, 131);
            this.budgetErrorLabel.Name = "budgetErrorLabel";
            this.budgetErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.budgetErrorLabel.TabIndex = 17;
            // 
            // inputbtn
            // 
            this.inputbtn.Location = new System.Drawing.Point(240, 150);
            this.inputbtn.Name = "inputbtn";
            this.inputbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.Indigo;
            this.inputbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.inputbtn.OverrideDefault.Back.ColorAngle = 45F;
            this.inputbtn.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputbtn.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.inputbtn.OverrideDefault.Border.Color2 = System.Drawing.Color.Indigo;
            this.inputbtn.OverrideDefault.Border.ColorAngle = 45F;
            this.inputbtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputbtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputbtn.OverrideDefault.Border.Rounding = 18;
            this.inputbtn.OverrideDefault.Border.Width = 1;
            this.inputbtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.inputbtn.Size = new System.Drawing.Size(176, 44);
            this.inputbtn.StateCommon.Back.Color1 = System.Drawing.Color.Indigo;
            this.inputbtn.StateCommon.Back.Color2 = System.Drawing.Color.DarkOrchid;
            this.inputbtn.StateCommon.Border.Color1 = System.Drawing.Color.Indigo;
            this.inputbtn.StateCommon.Border.Color2 = System.Drawing.Color.Indigo;
            this.inputbtn.StateCommon.Border.ColorAngle = 45F;
            this.inputbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputbtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputbtn.StateCommon.Border.Rounding = 18;
            this.inputbtn.StateCommon.Border.Width = 1;
            this.inputbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.inputbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.inputbtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbtn.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrchid;
            this.inputbtn.StatePressed.Back.Color2 = System.Drawing.Color.Indigo;
            this.inputbtn.StatePressed.Back.ColorAngle = 130F;
            this.inputbtn.StatePressed.Border.Color1 = System.Drawing.Color.Indigo;
            this.inputbtn.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrchid;
            this.inputbtn.StatePressed.Border.ColorAngle = 130F;
            this.inputbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputbtn.StatePressed.Border.Rounding = 18;
            this.inputbtn.StatePressed.Border.Width = 1;
            this.inputbtn.StateTracking.Back.Color1 = System.Drawing.Color.Indigo;
            this.inputbtn.StateTracking.Back.Color2 = System.Drawing.Color.Indigo;
            this.inputbtn.StateTracking.Back.ColorAngle = 45F;
            this.inputbtn.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputbtn.StateTracking.Border.Color1 = System.Drawing.Color.DarkOrchid;
            this.inputbtn.StateTracking.Border.Color2 = System.Drawing.Color.Indigo;
            this.inputbtn.StateTracking.Border.ColorAngle = 45F;
            this.inputbtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputbtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputbtn.StateTracking.Border.Rounding = 18;
            this.inputbtn.StateTracking.Border.Width = 1;
            this.inputbtn.TabIndex = 1;
            this.inputbtn.Values.Text = "INPUT BUDGET";
            this.inputbtn.Click += new System.EventHandler(this.inputbtn_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(55, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Budget";
            // 
            // budgettxt
            // 
            this.budgettxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.budgettxt.Location = new System.Drawing.Point(55, 97);
            this.budgettxt.Name = "budgettxt";
            this.budgettxt.Palette = this.kryptonPalette1;
            this.budgettxt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.budgettxt.Size = new System.Drawing.Size(360, 33);
            this.budgettxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.budgettxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.budgettxt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.budgettxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.budgettxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.budgettxt.StateCommon.Border.Rounding = 18;
            this.budgettxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.budgettxt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgettxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.budgettxt.TabIndex = 0;
            this.budgettxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.budgettxt_KeyPress_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(30, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 77);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter the amount you want to work with..";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costError
            // 
            this.costError.AutoSize = true;
            this.costError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costError.ForeColor = System.Drawing.Color.Red;
            this.costError.Location = new System.Drawing.Point(199, 214);
            this.costError.Name = "costError";
            this.costError.Size = new System.Drawing.Size(0, 19);
            this.costError.TabIndex = 18;
            // 
            // budgetError
            // 
            this.budgetError.AutoSize = true;
            this.budgetError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetError.ForeColor = System.Drawing.Color.Red;
            this.budgetError.Location = new System.Drawing.Point(179, 131);
            this.budgetError.Name = "budgetError";
            this.budgetError.Size = new System.Drawing.Size(0, 19);
            this.budgetError.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 594);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.spineChart);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.acctSetting);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUDGET APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.acctSetting.ResumeLayout(false);
            this.acctSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spineChart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BALANCE;
        private System.Windows.Forms.Label budget;
        private System.Windows.Forms.Label budgetValue;
        private System.Windows.Forms.Label BALC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip acctSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem createAccoutntoolStripMenuItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart spineChart;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox budgettxt;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox exptxt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton inputbtn;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton inputExpenseBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox costtxt;
        private System.Windows.Forms.Label budgetErrorLabel;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewImageColumn deleteBtn;
        private System.Windows.Forms.DataGridViewImageColumn updateBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label costError;
        private System.Windows.Forms.Label budgetError;
    }
}

