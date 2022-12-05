namespace MedicalCenter
{
    partial class Registr
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr));
            this.passwordlTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.lastnameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.firstnameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.patronymicsTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.addressTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.noticeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.registrButton = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numberTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.passMaskedTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordlTextBox
            // 
            this.passwordlTextBox.AnimateReadOnly = false;
            this.passwordlTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordlTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordlTextBox.Depth = 0;
            this.passwordlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordlTextBox.HideSelection = true;
            this.passwordlTextBox.Hint = "Пароль*";
            this.passwordlTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("passwordlTextBox.LeadingIcon")));
            this.passwordlTextBox.Location = new System.Drawing.Point(46, 359);
            this.passwordlTextBox.MaxLength = 20;
            this.passwordlTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordlTextBox.Name = "passwordlTextBox";
            this.passwordlTextBox.PasswordChar = '●';
            this.passwordlTextBox.PrefixSuffixText = null;
            this.passwordlTextBox.ReadOnly = false;
            this.passwordlTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordlTextBox.SelectedText = "";
            this.passwordlTextBox.SelectionLength = 0;
            this.passwordlTextBox.SelectionStart = 0;
            this.passwordlTextBox.ShortcutsEnabled = true;
            this.passwordlTextBox.Size = new System.Drawing.Size(250, 48);
            this.passwordlTextBox.TabIndex = 1;
            this.passwordlTextBox.TabStop = false;
            this.passwordlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordlTextBox.TrailingIcon = null;
            this.passwordlTextBox.UseSystemPasswordChar = true;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.AnimateReadOnly = false;
            this.lastnameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lastnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastnameTextBox.Depth = 0;
            this.lastnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastnameTextBox.HideSelection = true;
            this.lastnameTextBox.Hint = "Фамилия*";
            this.lastnameTextBox.LeadingIcon = null;
            this.lastnameTextBox.Location = new System.Drawing.Point(46, 152);
            this.lastnameTextBox.MaxLength = 20;
            this.lastnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.PasswordChar = '\0';
            this.lastnameTextBox.PrefixSuffixText = null;
            this.lastnameTextBox.ReadOnly = false;
            this.lastnameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastnameTextBox.SelectedText = "";
            this.lastnameTextBox.SelectionLength = 0;
            this.lastnameTextBox.SelectionStart = 0;
            this.lastnameTextBox.ShortcutsEnabled = true;
            this.lastnameTextBox.Size = new System.Drawing.Size(250, 48);
            this.lastnameTextBox.TabIndex = 6;
            this.lastnameTextBox.TabStop = false;
            this.lastnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastnameTextBox.TrailingIcon = null;
            this.lastnameTextBox.UseSystemPasswordChar = false;
            this.lastnameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastnameTextBox_Validating);
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.AnimateReadOnly = false;
            this.firstnameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.firstnameTextBox.Depth = 0;
            this.firstnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstnameTextBox.HideSelection = true;
            this.firstnameTextBox.Hint = "Имя*";
            this.firstnameTextBox.LeadingIcon = null;
            this.firstnameTextBox.Location = new System.Drawing.Point(46, 206);
            this.firstnameTextBox.MaxLength = 20;
            this.firstnameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.PasswordChar = '\0';
            this.firstnameTextBox.PrefixSuffixText = null;
            this.firstnameTextBox.ReadOnly = false;
            this.firstnameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.firstnameTextBox.SelectedText = "";
            this.firstnameTextBox.SelectionLength = 0;
            this.firstnameTextBox.SelectionStart = 0;
            this.firstnameTextBox.ShortcutsEnabled = true;
            this.firstnameTextBox.Size = new System.Drawing.Size(250, 48);
            this.firstnameTextBox.TabIndex = 7;
            this.firstnameTextBox.TabStop = false;
            this.firstnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstnameTextBox.TrailingIcon = null;
            this.firstnameTextBox.UseSystemPasswordChar = false;
            this.firstnameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstnameTextBox_Validating);
            // 
            // patronymicsTextBox
            // 
            this.patronymicsTextBox.AnimateReadOnly = false;
            this.patronymicsTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patronymicsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.patronymicsTextBox.Depth = 0;
            this.patronymicsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.patronymicsTextBox.HideSelection = true;
            this.patronymicsTextBox.Hint = "Отчество (если есть)";
            this.patronymicsTextBox.LeadingIcon = null;
            this.patronymicsTextBox.Location = new System.Drawing.Point(46, 260);
            this.patronymicsTextBox.MaxLength = 32767;
            this.patronymicsTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.patronymicsTextBox.Name = "patronymicsTextBox";
            this.patronymicsTextBox.PasswordChar = '\0';
            this.patronymicsTextBox.PrefixSuffixText = null;
            this.patronymicsTextBox.ReadOnly = false;
            this.patronymicsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.patronymicsTextBox.SelectedText = "";
            this.patronymicsTextBox.SelectionLength = 0;
            this.patronymicsTextBox.SelectionStart = 0;
            this.patronymicsTextBox.ShortcutsEnabled = true;
            this.patronymicsTextBox.Size = new System.Drawing.Size(250, 48);
            this.patronymicsTextBox.TabIndex = 8;
            this.patronymicsTextBox.TabStop = false;
            this.patronymicsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.patronymicsTextBox.TrailingIcon = null;
            this.patronymicsTextBox.UseSystemPasswordChar = false;
            this.patronymicsTextBox.TextChanged += new System.EventHandler(this.patronymicsTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 330);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // genderComboBox
            // 
            this.genderComboBox.AutoResize = false;
            this.genderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.genderComboBox.Depth = 0;
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.genderComboBox.DropDownHeight = 174;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.DropDownWidth = 121;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.genderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Hint = "Пол";
            this.genderComboBox.IntegralHeight = false;
            this.genderComboBox.ItemHeight = 43;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(46, 413);
            this.genderComboBox.MaxDropDownItems = 4;
            this.genderComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(250, 49);
            this.genderComboBox.StartIndex = 0;
            this.genderComboBox.TabIndex = 11;
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
            this.addressTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("addressTextBox.LeadingIcon")));
            this.addressTextBox.Location = new System.Drawing.Point(46, 468);
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
            this.addressTextBox.Size = new System.Drawing.Size(250, 48);
            this.addressTextBox.TabIndex = 12;
            this.addressTextBox.TabStop = false;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTextBox.TrailingIcon = null;
            this.addressTextBox.UseSystemPasswordChar = false;
            // 
            // noticeLabel
            // 
            this.noticeLabel.Depth = 0;
            this.noticeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noticeLabel.Location = new System.Drawing.Point(49, 582);
            this.noticeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(247, 48);
            this.noticeLabel.TabIndex = 14;
            this.noticeLabel.Text = "Поля помеченные \"*\" обязательны для заполнения";
            this.noticeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registrButton
            // 
            this.registrButton.AutoSize = false;
            this.registrButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registrButton.Depth = 0;
            this.registrButton.HighEmphasis = true;
            this.registrButton.Icon = null;
            this.registrButton.Location = new System.Drawing.Point(46, 636);
            this.registrButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrButton.Name = "registrButton";
            this.registrButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registrButton.Size = new System.Drawing.Size(250, 36);
            this.registrButton.TabIndex = 15;
            this.registrButton.Text = "Зарегистрироваться";
            this.registrButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registrButton.UseAccentColor = false;
            this.registrButton.UseVisualStyleBackColor = true;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(46, 681);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(250, 3);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = false;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(46, 693);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(250, 36);
            this.loginButton.TabIndex = 17;
            this.loginButton.Text = "Войти в аккаунт";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(46, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Дата рождения*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.numberTextBox.Hint = "Номер телефона*";
            this.numberTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.numberTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("numberTextBox.LeadingIcon")));
            this.numberTextBox.Location = new System.Drawing.Point(49, 522);
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
            this.numberTextBox.Size = new System.Drawing.Size(250, 48);
            this.numberTextBox.SkipLiterals = true;
            this.numberTextBox.TabIndex = 19;
            this.numberTextBox.TabStop = false;
            this.numberTextBox.Text = "+7";
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numberTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.numberTextBox.TrailingIcon = null;
            this.numberTextBox.UseSystemPasswordChar = false;
            this.numberTextBox.ValidatingType = null;
            this.numberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numberTextBox_Validating_1);
            // 
            // passMaskedTextBox
            // 
            this.passMaskedTextBox.AllowPromptAsInput = true;
            this.passMaskedTextBox.AnimateReadOnly = false;
            this.passMaskedTextBox.AsciiOnly = false;
            this.passMaskedTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passMaskedTextBox.BeepOnError = false;
            this.passMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passMaskedTextBox.Depth = 0;
            this.passMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passMaskedTextBox.HidePromptOnLeave = false;
            this.passMaskedTextBox.HideSelection = true;
            this.passMaskedTextBox.Hint = "Серия и номер паспорта*";
            this.passMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.passMaskedTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("passMaskedTextBox.LeadingIcon")));
            this.passMaskedTextBox.Location = new System.Drawing.Point(46, 98);
            this.passMaskedTextBox.Mask = "0000 000000";
            this.passMaskedTextBox.MaxLength = 32767;
            this.passMaskedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passMaskedTextBox.Name = "passMaskedTextBox";
            this.passMaskedTextBox.PasswordChar = '\0';
            this.passMaskedTextBox.PrefixSuffixText = null;
            this.passMaskedTextBox.PromptChar = '_';
            this.passMaskedTextBox.ReadOnly = false;
            this.passMaskedTextBox.RejectInputOnFirstFailure = false;
            this.passMaskedTextBox.ResetOnPrompt = true;
            this.passMaskedTextBox.ResetOnSpace = true;
            this.passMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passMaskedTextBox.SelectedText = "";
            this.passMaskedTextBox.SelectionLength = 0;
            this.passMaskedTextBox.SelectionStart = 0;
            this.passMaskedTextBox.ShortcutsEnabled = true;
            this.passMaskedTextBox.Size = new System.Drawing.Size(250, 48);
            this.passMaskedTextBox.SkipLiterals = true;
            this.passMaskedTextBox.TabIndex = 20;
            this.passMaskedTextBox.TabStop = false;
            this.passMaskedTextBox.Text = "     ";
            this.passMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passMaskedTextBox.TrailingIcon = null;
            this.passMaskedTextBox.UseSystemPasswordChar = false;
            this.passMaskedTextBox.ValidatingType = null;
            this.passMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passMaskedTextBox_Validating);
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(340, 750);
            this.Controls.Add(this.passMaskedTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.registrButton);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.patronymicsTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.passwordlTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(340, 750);
            this.MinimumSize = new System.Drawing.Size(340, 750);
            this.Name = "Registr";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника. Регистрация";
            this.Load += new System.EventHandler(this.Registr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 passwordlTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 lastnameTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 firstnameTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 patronymicsTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialComboBox genderComboBox;
        private MaterialSkin.Controls.MaterialTextBox2 addressTextBox;
        private MaterialSkin.Controls.MaterialLabel noticeLabel;
        private MaterialSkin.Controls.MaterialButton registrButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialMaskedTextBox numberTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox passMaskedTextBox;
    }
}

