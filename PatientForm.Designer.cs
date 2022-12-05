namespace MedicalCenter
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.menuTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.dataButton = new MaterialSkin.Controls.MaterialButton();
            this.recordsButton = new MaterialSkin.Controls.MaterialButton();
            this.ticketButton = new MaterialSkin.Controls.MaterialButton();
            this.appointmentButton = new MaterialSkin.Controls.MaterialButton();
            this.helloLabel = new System.Windows.Forms.Label();
            this.appointmentTabPage = new System.Windows.Forms.TabPage();
            this.noteMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.backButton = new MaterialSkin.Controls.MaterialButton();
            this.enrollButton = new MaterialSkin.Controls.MaterialButton();
            this.costLabel = new MaterialSkin.Controls.MaterialLabel();
            this.parlorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.docktorComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.typeServiceComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.specialityComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ticketTabPage = new System.Windows.Forms.TabPage();
            this.backButton2 = new MaterialSkin.Controls.MaterialButton();
            this.fillButton = new MaterialSkin.Controls.MaterialButton();
            this.checkOutButton = new MaterialSkin.Controls.MaterialButton();
            this.ticketListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sicknessRecordTabPage = new System.Windows.Forms.TabPage();
            this.backButton3 = new MaterialSkin.Controls.MaterialButton();
            this.fillIncButton = new MaterialSkin.Controls.MaterialButton();
            this.sicknessListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personalDataTabPage = new System.Windows.Forms.TabPage();
            this.exitButton1 = new MaterialSkin.Controls.MaterialButton();
            this.deactivateButton = new MaterialSkin.Controls.MaterialButton();
            this.activateButton = new MaterialSkin.Controls.MaterialButton();
            this.changeButton = new MaterialSkin.Controls.MaterialButton();
            this.passportTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.numberTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.addressTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.passTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.birthTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.fullnamelTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.fiveButton = new MaterialSkin.Controls.MaterialButton();
            this.menuTabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.appointmentTabPage.SuspendLayout();
            this.ticketTabPage.SuspendLayout();
            this.sicknessRecordTabPage.SuspendLayout();
            this.personalDataTabPage.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.mainTabPage);
            this.menuTabControl.Controls.Add(this.appointmentTabPage);
            this.menuTabControl.Controls.Add(this.ticketTabPage);
            this.menuTabControl.Controls.Add(this.sicknessRecordTabPage);
            this.menuTabControl.Controls.Add(this.personalDataTabPage);
            this.menuTabControl.Controls.Add(this.infoTabPage);
            this.menuTabControl.Depth = 0;
            this.menuTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTabControl.ImageList = this.imageList1;
            this.menuTabControl.Location = new System.Drawing.Point(3, 64);
            this.menuTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuTabControl.Multiline = true;
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(1039, 540);
            this.menuTabControl.TabIndex = 0;
            // 
            // mainTabPage
            // 
            this.mainTabPage.BackColor = System.Drawing.Color.White;
            this.mainTabPage.Controls.Add(this.exitButton);
            this.mainTabPage.Controls.Add(this.dataButton);
            this.mainTabPage.Controls.Add(this.recordsButton);
            this.mainTabPage.Controls.Add(this.ticketButton);
            this.mainTabPage.Controls.Add(this.appointmentButton);
            this.mainTabPage.Controls.Add(this.helloLabel);
            this.mainTabPage.ImageKey = "baseline_home_black_24dp.png";
            this.mainTabPage.Location = new System.Drawing.Point(4, 31);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(1031, 505);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Главный экран";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(346, 406);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitButton.Size = new System.Drawing.Size(256, 66);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataButton
            // 
            this.dataButton.AutoSize = false;
            this.dataButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.dataButton.Depth = 0;
            this.dataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataButton.HighEmphasis = true;
            this.dataButton.Icon = null;
            this.dataButton.Location = new System.Drawing.Point(346, 328);
            this.dataButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.dataButton.Name = "dataButton";
            this.dataButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dataButton.Size = new System.Drawing.Size(256, 66);
            this.dataButton.TabIndex = 4;
            this.dataButton.Text = "Личные данные";
            this.dataButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.dataButton.UseAccentColor = false;
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // recordsButton
            // 
            this.recordsButton.AutoSize = false;
            this.recordsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recordsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.recordsButton.Depth = 0;
            this.recordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordsButton.HighEmphasis = true;
            this.recordsButton.Icon = null;
            this.recordsButton.Location = new System.Drawing.Point(346, 250);
            this.recordsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.recordsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.recordsButton.Size = new System.Drawing.Size(256, 66);
            this.recordsButton.TabIndex = 3;
            this.recordsButton.Text = "Записи о заболеваниях";
            this.recordsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.recordsButton.UseAccentColor = false;
            this.recordsButton.UseVisualStyleBackColor = true;
            this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
            // 
            // ticketButton
            // 
            this.ticketButton.AutoSize = false;
            this.ticketButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ticketButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ticketButton.Depth = 0;
            this.ticketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketButton.HighEmphasis = true;
            this.ticketButton.Icon = null;
            this.ticketButton.Location = new System.Drawing.Point(346, 172);
            this.ticketButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ticketButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ticketButton.Size = new System.Drawing.Size(256, 66);
            this.ticketButton.TabIndex = 2;
            this.ticketButton.Text = "Просмотр талонов";
            this.ticketButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ticketButton.UseAccentColor = false;
            this.ticketButton.UseVisualStyleBackColor = true;
            this.ticketButton.Click += new System.EventHandler(this.ticketButton_Click);
            // 
            // appointmentButton
            // 
            this.appointmentButton.AutoSize = false;
            this.appointmentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appointmentButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.appointmentButton.Depth = 0;
            this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentButton.HighEmphasis = true;
            this.appointmentButton.Icon = null;
            this.appointmentButton.Location = new System.Drawing.Point(346, 94);
            this.appointmentButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.appointmentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.appointmentButton.Size = new System.Drawing.Size(256, 66);
            this.appointmentButton.TabIndex = 1;
            this.appointmentButton.Text = "Запись к врачу";
            this.appointmentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.appointmentButton.UseAccentColor = false;
            this.appointmentButton.UseVisualStyleBackColor = true;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoEllipsis = true;
            this.helloLabel.BackColor = System.Drawing.Color.DarkGray;
            this.helloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.helloLabel.Location = new System.Drawing.Point(3, 3);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(1025, 55);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.BackColor = System.Drawing.Color.White;
            this.appointmentTabPage.Controls.Add(this.noteMultiLineTextBox);
            this.appointmentTabPage.Controls.Add(this.backButton);
            this.appointmentTabPage.Controls.Add(this.enrollButton);
            this.appointmentTabPage.Controls.Add(this.costLabel);
            this.appointmentTabPage.Controls.Add(this.parlorLabel);
            this.appointmentTabPage.Controls.Add(this.timeComboBox);
            this.appointmentTabPage.Controls.Add(this.monthCalendar);
            this.appointmentTabPage.Controls.Add(this.docktorComboBox);
            this.appointmentTabPage.Controls.Add(this.typeServiceComboBox);
            this.appointmentTabPage.Controls.Add(this.specialityComboBox);
            this.appointmentTabPage.ImageKey = "baseline_event_black_24dp.png";
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 31);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentTabPage.Size = new System.Drawing.Size(1031, 505);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Запись к врачу";
            // 
            // noteMultiLineTextBox
            // 
            this.noteMultiLineTextBox.AnimateReadOnly = false;
            this.noteMultiLineTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.noteMultiLineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.noteMultiLineTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noteMultiLineTextBox.Depth = 0;
            this.noteMultiLineTextBox.HideSelection = true;
            this.noteMultiLineTextBox.Hint = "Примечание (если нужно)";
            this.noteMultiLineTextBox.Location = new System.Drawing.Point(638, 320);
            this.noteMultiLineTextBox.MaxLength = 32767;
            this.noteMultiLineTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.noteMultiLineTextBox.Name = "noteMultiLineTextBox";
            this.noteMultiLineTextBox.PasswordChar = '\0';
            this.noteMultiLineTextBox.ReadOnly = false;
            this.noteMultiLineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noteMultiLineTextBox.SelectedText = "";
            this.noteMultiLineTextBox.SelectionLength = 0;
            this.noteMultiLineTextBox.SelectionStart = 0;
            this.noteMultiLineTextBox.ShortcutsEnabled = true;
            this.noteMultiLineTextBox.Size = new System.Drawing.Size(250, 100);
            this.noteMultiLineTextBox.TabIndex = 9;
            this.noteMultiLineTextBox.TabStop = false;
            this.noteMultiLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.noteMultiLineTextBox.UseSystemPasswordChar = false;
            // 
            // backButton
            // 
            this.backButton.AutoSize = false;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backButton.Depth = 0;
            this.backButton.HighEmphasis = true;
            this.backButton.Icon = null;
            this.backButton.Location = new System.Drawing.Point(272, 479);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backButton.Size = new System.Drawing.Size(313, 38);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "На главный экран";
            this.backButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.backButton.UseAccentColor = false;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // enrollButton
            // 
            this.enrollButton.AutoSize = false;
            this.enrollButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enrollButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.enrollButton.Depth = 0;
            this.enrollButton.HighEmphasis = true;
            this.enrollButton.Icon = null;
            this.enrollButton.Location = new System.Drawing.Point(272, 429);
            this.enrollButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enrollButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.enrollButton.Size = new System.Drawing.Size(313, 38);
            this.enrollButton.TabIndex = 7;
            this.enrollButton.Text = "Записаться";
            this.enrollButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.enrollButton.UseAccentColor = false;
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Depth = 0;
            this.costLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costLabel.Location = new System.Drawing.Point(448, 207);
            this.costLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(47, 19);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = "Цена: ";
            // 
            // parlorLabel
            // 
            this.parlorLabel.AutoSize = true;
            this.parlorLabel.Depth = 0;
            this.parlorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.parlorLabel.Location = new System.Drawing.Point(448, 226);
            this.parlorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.parlorLabel.Name = "parlorLabel";
            this.parlorLabel.Size = new System.Drawing.Size(71, 19);
            this.parlorLabel.TabIndex = 5;
            this.parlorLabel.Text = "Кабинет: ";
            // 
            // timeComboBox
            // 
            this.timeComboBox.AutoResize = false;
            this.timeComboBox.BackColor = System.Drawing.Color.White;
            this.timeComboBox.Depth = 0;
            this.timeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.timeComboBox.DropDownHeight = 174;
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.DropDownWidth = 121;
            this.timeComboBox.Enabled = false;
            this.timeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.timeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Hint = "Время";
            this.timeComboBox.IntegralHeight = false;
            this.timeComboBox.ItemHeight = 43;
            this.timeComboBox.Location = new System.Drawing.Point(272, 371);
            this.timeComboBox.MaxDropDownItems = 4;
            this.timeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(313, 49);
            this.timeComboBox.StartIndex = 0;
            this.timeComboBox.TabIndex = 4;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(272, 197);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // docktorComboBox
            // 
            this.docktorComboBox.AutoResize = false;
            this.docktorComboBox.BackColor = System.Drawing.Color.White;
            this.docktorComboBox.Depth = 0;
            this.docktorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.docktorComboBox.DropDownHeight = 174;
            this.docktorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docktorComboBox.DropDownWidth = 121;
            this.docktorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.docktorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.docktorComboBox.FormattingEnabled = true;
            this.docktorComboBox.Hint = "Врач";
            this.docktorComboBox.IntegralHeight = false;
            this.docktorComboBox.ItemHeight = 43;
            this.docktorComboBox.Location = new System.Drawing.Point(272, 136);
            this.docktorComboBox.MaxDropDownItems = 4;
            this.docktorComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.docktorComboBox.Name = "docktorComboBox";
            this.docktorComboBox.Size = new System.Drawing.Size(313, 49);
            this.docktorComboBox.StartIndex = 0;
            this.docktorComboBox.TabIndex = 2;
            this.docktorComboBox.Enter += new System.EventHandler(this.docktorComboBox_Enter);
            this.docktorComboBox.Leave += new System.EventHandler(this.docktorComboBox_Leave);
            // 
            // typeServiceComboBox
            // 
            this.typeServiceComboBox.AutoResize = false;
            this.typeServiceComboBox.BackColor = System.Drawing.Color.White;
            this.typeServiceComboBox.Depth = 0;
            this.typeServiceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeServiceComboBox.DropDownHeight = 174;
            this.typeServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeServiceComboBox.DropDownWidth = 121;
            this.typeServiceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.typeServiceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typeServiceComboBox.FormattingEnabled = true;
            this.typeServiceComboBox.Hint = "Услуга";
            this.typeServiceComboBox.IntegralHeight = false;
            this.typeServiceComboBox.ItemHeight = 43;
            this.typeServiceComboBox.Location = new System.Drawing.Point(272, 81);
            this.typeServiceComboBox.MaxDropDownItems = 4;
            this.typeServiceComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.typeServiceComboBox.Name = "typeServiceComboBox";
            this.typeServiceComboBox.Size = new System.Drawing.Size(313, 49);
            this.typeServiceComboBox.StartIndex = 0;
            this.typeServiceComboBox.TabIndex = 1;
            this.typeServiceComboBox.Enter += new System.EventHandler(this.typeServiceComboBox_Enter);
            this.typeServiceComboBox.Leave += new System.EventHandler(this.typeServiceComboBox_Leave);
            // 
            // specialityComboBox
            // 
            this.specialityComboBox.AutoResize = false;
            this.specialityComboBox.BackColor = System.Drawing.Color.White;
            this.specialityComboBox.Depth = 0;
            this.specialityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.specialityComboBox.DropDownHeight = 174;
            this.specialityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityComboBox.DropDownWidth = 121;
            this.specialityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.specialityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.specialityComboBox.FormattingEnabled = true;
            this.specialityComboBox.Hint = "Специальность врача";
            this.specialityComboBox.IntegralHeight = false;
            this.specialityComboBox.ItemHeight = 43;
            this.specialityComboBox.Items.AddRange(new object[] {
            "Врач общей практики",
            "Врач-гастроэнтеролог",
            "Врач-дерматовенеролог",
            "Врач-инфекционист",
            "Врач-кардиолог",
            "Врач-колопроктолог",
            "Врач-невролог",
            "Врач-нефролог",
            "Врач-онколог",
            "Врач-ревматолог",
            "Врач-офтальмолог",
            "Врач-рентгенолог",
            "Врач-терапевт",
            "Врач-уролог",
            "Врач-хирург",
            "Врач-эндокринолог"});
            this.specialityComboBox.Location = new System.Drawing.Point(272, 26);
            this.specialityComboBox.MaxDropDownItems = 4;
            this.specialityComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.specialityComboBox.Name = "specialityComboBox";
            this.specialityComboBox.Size = new System.Drawing.Size(313, 49);
            this.specialityComboBox.StartIndex = 0;
            this.specialityComboBox.TabIndex = 0;
            this.specialityComboBox.Enter += new System.EventHandler(this.specialityComboBox_Enter);
            this.specialityComboBox.Leave += new System.EventHandler(this.specialityComboBox_Leave);
            // 
            // ticketTabPage
            // 
            this.ticketTabPage.BackColor = System.Drawing.Color.White;
            this.ticketTabPage.Controls.Add(this.backButton2);
            this.ticketTabPage.Controls.Add(this.fillButton);
            this.ticketTabPage.Controls.Add(this.checkOutButton);
            this.ticketTabPage.Controls.Add(this.ticketListView);
            this.ticketTabPage.ImageKey = "baseline_list_black_24dp.png";
            this.ticketTabPage.Location = new System.Drawing.Point(4, 31);
            this.ticketTabPage.Name = "ticketTabPage";
            this.ticketTabPage.Size = new System.Drawing.Size(1031, 505);
            this.ticketTabPage.TabIndex = 2;
            this.ticketTabPage.Text = "Просмотр талонов";
            // 
            // backButton2
            // 
            this.backButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backButton2.Depth = 0;
            this.backButton2.HighEmphasis = true;
            this.backButton2.Icon = null;
            this.backButton2.Location = new System.Drawing.Point(25, 473);
            this.backButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton2.Name = "backButton2";
            this.backButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backButton2.Size = new System.Drawing.Size(169, 36);
            this.backButton2.TabIndex = 3;
            this.backButton2.Text = "На главный экран";
            this.backButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.backButton2.UseAccentColor = false;
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // fillButton
            // 
            this.fillButton.AutoSize = false;
            this.fillButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fillButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.fillButton.Depth = 0;
            this.fillButton.HighEmphasis = true;
            this.fillButton.Icon = null;
            this.fillButton.Location = new System.Drawing.Point(794, 473);
            this.fillButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fillButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillButton.Name = "fillButton";
            this.fillButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.fillButton.Size = new System.Drawing.Size(147, 36);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Обновить";
            this.fillButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.fillButton.UseAccentColor = false;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.AutoSize = false;
            this.checkOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkOutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.checkOutButton.Depth = 0;
            this.checkOutButton.HighEmphasis = true;
            this.checkOutButton.Icon = null;
            this.checkOutButton.Location = new System.Drawing.Point(639, 473);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.checkOutButton.Size = new System.Drawing.Size(147, 36);
            this.checkOutButton.TabIndex = 1;
            this.checkOutButton.Text = "Выписаться";
            this.checkOutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.checkOutButton.UseAccentColor = false;
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // ticketListView
            // 
            this.ticketListView.AutoSizeTable = false;
            this.ticketListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticketListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ticketListView.Depth = 0;
            this.ticketListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketListView.FullRowSelect = true;
            this.ticketListView.HideSelection = false;
            this.ticketListView.Location = new System.Drawing.Point(3, 0);
            this.ticketListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ticketListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ticketListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ticketListView.Name = "ticketListView";
            this.ticketListView.OwnerDraw = true;
            this.ticketListView.Size = new System.Drawing.Size(1025, 366);
            this.ticketListView.TabIndex = 0;
            this.ticketListView.UseCompatibleStateImageBehavior = false;
            this.ticketListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер талона";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО врача";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Время";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Кабинет";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Услуга";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Стоимость";
            this.columnHeader7.Width = 120;
            // 
            // sicknessRecordTabPage
            // 
            this.sicknessRecordTabPage.BackColor = System.Drawing.Color.White;
            this.sicknessRecordTabPage.Controls.Add(this.backButton3);
            this.sicknessRecordTabPage.Controls.Add(this.fillIncButton);
            this.sicknessRecordTabPage.Controls.Add(this.sicknessListView);
            this.sicknessRecordTabPage.ImageKey = "baseline_assignment_black_24dp.png";
            this.sicknessRecordTabPage.Location = new System.Drawing.Point(4, 31);
            this.sicknessRecordTabPage.Name = "sicknessRecordTabPage";
            this.sicknessRecordTabPage.Size = new System.Drawing.Size(1031, 505);
            this.sicknessRecordTabPage.TabIndex = 3;
            this.sicknessRecordTabPage.Text = "Записи о заболеваниях";
            // 
            // backButton3
            // 
            this.backButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backButton3.Depth = 0;
            this.backButton3.HighEmphasis = true;
            this.backButton3.Icon = null;
            this.backButton3.Location = new System.Drawing.Point(83, 473);
            this.backButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton3.Name = "backButton3";
            this.backButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backButton3.Size = new System.Drawing.Size(161, 36);
            this.backButton3.TabIndex = 2;
            this.backButton3.Text = "На главный экран";
            this.backButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.backButton3.UseAccentColor = false;
            this.backButton3.UseVisualStyleBackColor = true;
            this.backButton3.Click += new System.EventHandler(this.backButton3_Click);
            // 
            // fillIncButton
            // 
            this.fillIncButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fillIncButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.fillIncButton.Depth = 0;
            this.fillIncButton.HighEmphasis = true;
            this.fillIncButton.Icon = null;
            this.fillIncButton.Location = new System.Drawing.Point(791, 473);
            this.fillIncButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fillIncButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillIncButton.Name = "fillIncButton";
            this.fillIncButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.fillIncButton.Size = new System.Drawing.Size(100, 36);
            this.fillIncButton.TabIndex = 1;
            this.fillIncButton.Text = "Обновить";
            this.fillIncButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.fillIncButton.UseAccentColor = false;
            this.fillIncButton.UseVisualStyleBackColor = true;
            this.fillIncButton.Click += new System.EventHandler(this.fillIncButton_Click);
            // 
            // sicknessListView
            // 
            this.sicknessListView.AutoSizeTable = false;
            this.sicknessListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sicknessListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sicknessListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.sicknessListView.Depth = 0;
            this.sicknessListView.FullRowSelect = true;
            this.sicknessListView.HideSelection = false;
            this.sicknessListView.Location = new System.Drawing.Point(3, 3);
            this.sicknessListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.sicknessListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sicknessListView.MouseState = MaterialSkin.MouseState.OUT;
            this.sicknessListView.Name = "sicknessListView";
            this.sicknessListView.OwnerDraw = true;
            this.sicknessListView.Size = new System.Drawing.Size(1025, 461);
            this.sicknessListView.TabIndex = 0;
            this.sicknessListView.UseCompatibleStateImageBehavior = false;
            this.sicknessListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Номер записи";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Врач";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Тип заболевания";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 300;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Дата заключения";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Диагноз";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 280;
            // 
            // personalDataTabPage
            // 
            this.personalDataTabPage.BackColor = System.Drawing.Color.White;
            this.personalDataTabPage.Controls.Add(this.exitButton1);
            this.personalDataTabPage.Controls.Add(this.deactivateButton);
            this.personalDataTabPage.Controls.Add(this.activateButton);
            this.personalDataTabPage.Controls.Add(this.changeButton);
            this.personalDataTabPage.Controls.Add(this.passportTextBox);
            this.personalDataTabPage.Controls.Add(this.numberTextBox);
            this.personalDataTabPage.Controls.Add(this.addressTextBox);
            this.personalDataTabPage.Controls.Add(this.passTextBox);
            this.personalDataTabPage.Controls.Add(this.birthTextBox);
            this.personalDataTabPage.Controls.Add(this.fullnamelTextBox);
            this.personalDataTabPage.ImageKey = "baseline_manage_accounts_black_24dp.png";
            this.personalDataTabPage.Location = new System.Drawing.Point(4, 31);
            this.personalDataTabPage.Name = "personalDataTabPage";
            this.personalDataTabPage.Size = new System.Drawing.Size(1031, 505);
            this.personalDataTabPage.TabIndex = 5;
            this.personalDataTabPage.Text = "Личные данные";
            // 
            // exitButton1
            // 
            this.exitButton1.AutoSize = false;
            this.exitButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton1.Depth = 0;
            this.exitButton1.HighEmphasis = true;
            this.exitButton1.Icon = null;
            this.exitButton1.Location = new System.Drawing.Point(318, 441);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitButton1.Size = new System.Drawing.Size(269, 36);
            this.exitButton1.TabIndex = 10;
            this.exitButton1.Text = "Выйти из аккаунта";
            this.exitButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.exitButton1.UseAccentColor = false;
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // deactivateButton
            // 
            this.deactivateButton.AutoSize = false;
            this.deactivateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deactivateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deactivateButton.Depth = 0;
            this.deactivateButton.Enabled = false;
            this.deactivateButton.HighEmphasis = true;
            this.deactivateButton.Icon = null;
            this.deactivateButton.Location = new System.Drawing.Point(703, 100);
            this.deactivateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deactivateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deactivateButton.Size = new System.Drawing.Size(227, 36);
            this.deactivateButton.TabIndex = 9;
            this.deactivateButton.Text = "Деактивировать аккаунт";
            this.deactivateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.deactivateButton.UseAccentColor = false;
            this.deactivateButton.UseVisualStyleBackColor = true;
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);
            // 
            // activateButton
            // 
            this.activateButton.AutoSize = false;
            this.activateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.activateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.activateButton.Depth = 0;
            this.activateButton.Enabled = false;
            this.activateButton.HighEmphasis = true;
            this.activateButton.Icon = null;
            this.activateButton.Location = new System.Drawing.Point(703, 52);
            this.activateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.activateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.activateButton.Name = "activateButton";
            this.activateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.activateButton.Size = new System.Drawing.Size(227, 36);
            this.activateButton.TabIndex = 8;
            this.activateButton.Text = "Активировать аккаунт";
            this.activateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.activateButton.UseAccentColor = false;
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.AutoSize = false;
            this.changeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.changeButton.Depth = 0;
            this.changeButton.HighEmphasis = true;
            this.changeButton.Icon = null;
            this.changeButton.Location = new System.Drawing.Point(318, 393);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeButton.Name = "changeButton";
            this.changeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.changeButton.Size = new System.Drawing.Size(269, 36);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Изменить данные";
            this.changeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.changeButton.UseAccentColor = false;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // passportTextBox
            // 
            this.passportTextBox.AllowPromptAsInput = true;
            this.passportTextBox.AnimateReadOnly = false;
            this.passportTextBox.AsciiOnly = false;
            this.passportTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passportTextBox.BeepOnError = false;
            this.passportTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passportTextBox.Depth = 0;
            this.passportTextBox.Enabled = false;
            this.passportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passportTextBox.HidePromptOnLeave = false;
            this.passportTextBox.HideSelection = true;
            this.passportTextBox.Hint = "Серия и номер паспорта";
            this.passportTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.passportTextBox.LeadingIcon = null;
            this.passportTextBox.Location = new System.Drawing.Point(318, 56);
            this.passportTextBox.Mask = "0000 000000";
            this.passportTextBox.MaxLength = 32767;
            this.passportTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.PasswordChar = '\0';
            this.passportTextBox.PrefixSuffixText = null;
            this.passportTextBox.PromptChar = '_';
            this.passportTextBox.ReadOnly = false;
            this.passportTextBox.RejectInputOnFirstFailure = false;
            this.passportTextBox.ResetOnPrompt = true;
            this.passportTextBox.ResetOnSpace = true;
            this.passportTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passportTextBox.SelectedText = "";
            this.passportTextBox.SelectionLength = 0;
            this.passportTextBox.SelectionStart = 0;
            this.passportTextBox.ShortcutsEnabled = true;
            this.passportTextBox.Size = new System.Drawing.Size(269, 48);
            this.passportTextBox.SkipLiterals = true;
            this.passportTextBox.TabIndex = 6;
            this.passportTextBox.TabStop = false;
            this.passportTextBox.Text = "     ";
            this.passportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passportTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passportTextBox.TrailingIcon = null;
            this.passportTextBox.UseSystemPasswordChar = false;
            this.passportTextBox.ValidatingType = null;
            // 
            // numberTextBox
            // 
            this.numberTextBox.AllowPromptAsInput = true;
            this.numberTextBox.AnimateReadOnly = false;
            this.numberTextBox.AsciiOnly = false;
            this.numberTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numberTextBox.BeepOnError = false;
            this.numberTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.numberTextBox.Depth = 0;
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numberTextBox.HidePromptOnLeave = false;
            this.numberTextBox.HideSelection = true;
            this.numberTextBox.Hint = "Номер телефона";
            this.numberTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.numberTextBox.LeadingIcon = null;
            this.numberTextBox.Location = new System.Drawing.Point(318, 326);
            this.numberTextBox.Mask = "+70000000000";
            this.numberTextBox.MaxLength = 32767;
            this.numberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.PasswordChar = '\0';
            this.numberTextBox.PrefixSuffixText = null;
            this.numberTextBox.PromptChar = '_';
            this.numberTextBox.ReadOnly = false;
            this.numberTextBox.RejectInputOnFirstFailure = false;
            this.numberTextBox.ResetOnPrompt = true;
            this.numberTextBox.ResetOnSpace = true;
            this.numberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numberTextBox.SelectedText = "";
            this.numberTextBox.SelectionLength = 0;
            this.numberTextBox.SelectionStart = 0;
            this.numberTextBox.ShortcutsEnabled = true;
            this.numberTextBox.Size = new System.Drawing.Size(269, 48);
            this.numberTextBox.SkipLiterals = true;
            this.numberTextBox.TabIndex = 5;
            this.numberTextBox.TabStop = false;
            this.numberTextBox.Text = "+7";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numberTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.numberTextBox.TrailingIcon = null;
            this.numberTextBox.UseSystemPasswordChar = false;
            this.numberTextBox.ValidatingType = null;
            this.numberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numberTextBox_Validating);
            // 
            // addressTextBox
            // 
            this.addressTextBox.AnimateReadOnly = false;
            this.addressTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressTextBox.Depth = 0;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressTextBox.HideSelection = true;
            this.addressTextBox.Hint = "Адрес";
            this.addressTextBox.LeadingIcon = null;
            this.addressTextBox.Location = new System.Drawing.Point(318, 272);
            this.addressTextBox.MaxLength = 35;
            this.addressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PrefixSuffixText = null;
            this.addressTextBox.ReadOnly = false;
            this.addressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.SelectionLength = 0;
            this.addressTextBox.SelectionStart = 0;
            this.addressTextBox.ShortcutsEnabled = true;
            this.addressTextBox.Size = new System.Drawing.Size(269, 48);
            this.addressTextBox.TabIndex = 4;
            this.addressTextBox.TabStop = false;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTextBox.TrailingIcon = null;
            this.addressTextBox.UseSystemPasswordChar = false;
            // 
            // passTextBox
            // 
            this.passTextBox.AnimateReadOnly = false;
            this.passTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passTextBox.Depth = 0;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passTextBox.HideSelection = true;
            this.passTextBox.Hint = "Пароль";
            this.passTextBox.LeadingIcon = null;
            this.passTextBox.Location = new System.Drawing.Point(318, 218);
            this.passTextBox.MaxLength = 20;
            this.passTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.PrefixSuffixText = null;
            this.passTextBox.ReadOnly = false;
            this.passTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionLength = 0;
            this.passTextBox.SelectionStart = 0;
            this.passTextBox.ShortcutsEnabled = true;
            this.passTextBox.Size = new System.Drawing.Size(269, 48);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.TabStop = false;
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passTextBox.TrailingIcon = null;
            this.passTextBox.UseSystemPasswordChar = false;
            // 
            // birthTextBox
            // 
            this.birthTextBox.AnimateReadOnly = false;
            this.birthTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.birthTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.birthTextBox.Depth = 0;
            this.birthTextBox.Enabled = false;
            this.birthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.birthTextBox.HideSelection = true;
            this.birthTextBox.Hint = "Дата рождения";
            this.birthTextBox.LeadingIcon = null;
            this.birthTextBox.Location = new System.Drawing.Point(318, 164);
            this.birthTextBox.MaxLength = 32767;
            this.birthTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.birthTextBox.Name = "birthTextBox";
            this.birthTextBox.PasswordChar = '\0';
            this.birthTextBox.PrefixSuffixText = null;
            this.birthTextBox.ReadOnly = true;
            this.birthTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birthTextBox.SelectedText = "";
            this.birthTextBox.SelectionLength = 0;
            this.birthTextBox.SelectionStart = 0;
            this.birthTextBox.ShortcutsEnabled = true;
            this.birthTextBox.Size = new System.Drawing.Size(269, 48);
            this.birthTextBox.TabIndex = 2;
            this.birthTextBox.TabStop = false;
            this.birthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.birthTextBox.TrailingIcon = null;
            this.birthTextBox.UseSystemPasswordChar = false;
            // 
            // fullnamelTextBox
            // 
            this.fullnamelTextBox.AnimateReadOnly = false;
            this.fullnamelTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fullnamelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fullnamelTextBox.Depth = 0;
            this.fullnamelTextBox.Enabled = false;
            this.fullnamelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fullnamelTextBox.HideSelection = true;
            this.fullnamelTextBox.Hint = "ФИО";
            this.fullnamelTextBox.LeadingIcon = null;
            this.fullnamelTextBox.Location = new System.Drawing.Point(318, 110);
            this.fullnamelTextBox.MaxLength = 32767;
            this.fullnamelTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.fullnamelTextBox.Name = "fullnamelTextBox";
            this.fullnamelTextBox.PasswordChar = '\0';
            this.fullnamelTextBox.PrefixSuffixText = null;
            this.fullnamelTextBox.ReadOnly = true;
            this.fullnamelTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fullnamelTextBox.SelectedText = "";
            this.fullnamelTextBox.SelectionLength = 0;
            this.fullnamelTextBox.SelectionStart = 0;
            this.fullnamelTextBox.ShortcutsEnabled = true;
            this.fullnamelTextBox.Size = new System.Drawing.Size(269, 48);
            this.fullnamelTextBox.TabIndex = 1;
            this.fullnamelTextBox.TabStop = false;
            this.fullnamelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fullnamelTextBox.TrailingIcon = null;
            this.fullnamelTextBox.UseSystemPasswordChar = false;
            // 
            // infoTabPage
            // 
            this.infoTabPage.BackColor = System.Drawing.Color.White;
            this.infoTabPage.Controls.Add(this.fiveButton);
            this.infoTabPage.Controls.Add(this.linkLabel1);
            this.infoTabPage.Controls.Add(this.materialLabel6);
            this.infoTabPage.Controls.Add(this.materialLabel5);
            this.infoTabPage.Controls.Add(this.materialLabel4);
            this.infoTabPage.Controls.Add(this.materialLabel3);
            this.infoTabPage.Controls.Add(this.materialLabel2);
            this.infoTabPage.Controls.Add(this.materialLabel1);
            this.infoTabPage.Controls.Add(this.label1);
            this.infoTabPage.ImageKey = "baseline_info_black_24dp.png";
            this.infoTabPage.Location = new System.Drawing.Point(4, 31);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Size = new System.Drawing.Size(1031, 505);
            this.infoTabPage.TabIndex = 4;
            this.infoTabPage.Text = "Информация о программе";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "baseline_accessibility_black_24dp.png");
            this.imageList1.Images.SetKeyName(1, "baseline_account_circle_black_24dp.png");
            this.imageList1.Images.SetKeyName(2, "baseline_assignment_black_24dp.png");
            this.imageList1.Images.SetKeyName(3, "baseline_event_black_24dp.png");
            this.imageList1.Images.SetKeyName(4, "baseline_home_black_24dp.png");
            this.imageList1.Images.SetKeyName(5, "baseline_info_black_24dp.png");
            this.imageList1.Images.SetKeyName(6, "baseline_key_black_24dp.png");
            this.imageList1.Images.SetKeyName(7, "baseline_list_black_24dp.png");
            this.imageList1.Images.SetKeyName(8, "baseline_manage_accounts_black_24dp.png");
            this.imageList1.Images.SetKeyName(9, "baseline_phone_iphone_black_24dp.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поликлиника";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(34, 70);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(169, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Версия: 0.0.1 (BUILD 1)";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(34, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(368, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Автор: Макаров Олег Александрович группа 945";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(34, 119);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(130, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Лицензия: РГРТУ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(34, 147);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(398, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "ЭТА ПРОГРАММА РАСПРОСТРАНЯЕТСЯ БЕСПЛАТНО";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(34, 166);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(186, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "ВСЕ ПРАВА ЗАЩИЩЕНЫ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(34, 200);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(38, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "WEB:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(78, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://vk.com/soppeallod";
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSize = false;
            this.fiveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.fiveButton.Depth = 0;
            this.fiveButton.HighEmphasis = true;
            this.fiveButton.Icon = null;
            this.fiveButton.Location = new System.Drawing.Point(789, 463);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fiveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.fiveButton.Size = new System.Drawing.Size(163, 36);
            this.fiveButton.TabIndex = 8;
            this.fiveButton.Text = "Поставить 5";
            this.fiveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.fiveButton.UseAccentColor = false;
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1045, 607);
            this.Controls.Add(this.menuTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.menuTabControl;
            this.DrawerWidth = 260;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1045, 607);
            this.MinimumSize = new System.Drawing.Size(1045, 607);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.menuTabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.appointmentTabPage.ResumeLayout(false);
            this.appointmentTabPage.PerformLayout();
            this.ticketTabPage.ResumeLayout(false);
            this.ticketTabPage.PerformLayout();
            this.sicknessRecordTabPage.ResumeLayout(false);
            this.sicknessRecordTabPage.PerformLayout();
            this.personalDataTabPage.ResumeLayout(false);
            this.infoTabPage.ResumeLayout(false);
            this.infoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl menuTabControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage appointmentTabPage;
        private System.Windows.Forms.TabPage ticketTabPage;
        private System.Windows.Forms.TabPage sicknessRecordTabPage;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage personalDataTabPage;
        private MaterialSkin.Controls.MaterialButton exitButton;
        private MaterialSkin.Controls.MaterialButton dataButton;
        private MaterialSkin.Controls.MaterialButton recordsButton;
        private MaterialSkin.Controls.MaterialButton ticketButton;
        private MaterialSkin.Controls.MaterialButton appointmentButton;
        private System.Windows.Forms.Label helloLabel;
        private MaterialSkin.Controls.MaterialComboBox typeServiceComboBox;
        private MaterialSkin.Controls.MaterialComboBox specialityComboBox;
        private MaterialSkin.Controls.MaterialComboBox docktorComboBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private MaterialSkin.Controls.MaterialComboBox timeComboBox;
        private MaterialSkin.Controls.MaterialLabel costLabel;
        private MaterialSkin.Controls.MaterialLabel parlorLabel;
        private MaterialSkin.Controls.MaterialButton enrollButton;
        private MaterialSkin.Controls.MaterialButton backButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 noteMultiLineTextBox;
        private MaterialSkin.Controls.MaterialListView ticketListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialButton checkOutButton;
        private MaterialSkin.Controls.MaterialButton fillButton;
        private MaterialSkin.Controls.MaterialButton backButton2;
        private MaterialSkin.Controls.MaterialListView sicknessListView;
        private MaterialSkin.Controls.MaterialButton backButton3;
        private MaterialSkin.Controls.MaterialButton fillIncButton;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private MaterialSkin.Controls.MaterialTextBox2 passTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 birthTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 fullnamelTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 addressTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox numberTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox passportTextBox;
        private MaterialSkin.Controls.MaterialButton changeButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialButton deactivateButton;
        private MaterialSkin.Controls.MaterialButton activateButton;
        private MaterialSkin.Controls.MaterialButton exitButton1;
        private MaterialSkin.Controls.MaterialButton fiveButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
    }
}