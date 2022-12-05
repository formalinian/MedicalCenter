namespace MedicalCenter
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordlTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.registrarionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.registrButton = new MaterialSkin.Controls.MaterialButton();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.AnimateReadOnly = false;
            this.loginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginTextBox.Depth = 0;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTextBox.HideSelection = true;
            this.loginTextBox.Hint = "Серия и номер паспорта";
            this.loginTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.loginTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("loginTextBox.LeadingIcon")));
            this.loginTextBox.Location = new System.Drawing.Point(46, 101);
            this.loginTextBox.MaxLength = 10;
            this.loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PrefixSuffixText = null;
            this.loginTextBox.ReadOnly = false;
            this.loginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.SelectionLength = 0;
            this.loginTextBox.SelectionStart = 0;
            this.loginTextBox.ShortcutsEnabled = true;
            this.loginTextBox.Size = new System.Drawing.Size(250, 48);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.TabStop = false;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTextBox.TrailingIcon = null;
            this.loginTextBox.UseSystemPasswordChar = false;
            // 
            // passwordlTextBox
            // 
            this.passwordlTextBox.AnimateReadOnly = false;
            this.passwordlTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordlTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordlTextBox.Depth = 0;
            this.passwordlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordlTextBox.HideSelection = true;
            this.passwordlTextBox.Hint = "Пароль";
            this.passwordlTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("passwordlTextBox.LeadingIcon")));
            this.passwordlTextBox.Location = new System.Drawing.Point(46, 155);
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
            // loginButton
            // 
            this.loginButton.AutoSize = false;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(46, 212);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(250, 32);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вход";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(46, 266);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(250, 3);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // registrarionLabel
            // 
            this.registrarionLabel.AutoSize = true;
            this.registrarionLabel.Depth = 0;
            this.registrarionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registrarionLabel.Location = new System.Drawing.Point(57, 286);
            this.registrarionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrarionLabel.Name = "registrarionLabel";
            this.registrarionLabel.Size = new System.Drawing.Size(230, 19);
            this.registrarionLabel.TabIndex = 4;
            this.registrarionLabel.Text = "Вы еще не зарегистрированы?";
            // 
            // registrButton
            // 
            this.registrButton.AutoSize = false;
            this.registrButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registrButton.Depth = 0;
            this.registrButton.HighEmphasis = true;
            this.registrButton.Icon = null;
            this.registrButton.Location = new System.Drawing.Point(46, 311);
            this.registrButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrButton.Name = "registrButton";
            this.registrButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registrButton.Size = new System.Drawing.Size(250, 36);
            this.registrButton.TabIndex = 5;
            this.registrButton.Text = "РЕГИСТРАЦИЯ";
            this.registrButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.registrButton.UseAccentColor = false;
            this.registrButton.UseVisualStyleBackColor = true;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(46, 344);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitButton.Size = new System.Drawing.Size(250, 36);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "ВЫХОД";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(340, 400);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registrButton);
            this.Controls.Add(this.registrarionLabel);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordlTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(340, 400);
            this.MinimumSize = new System.Drawing.Size(340, 400);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника. Авторизация";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 loginTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 passwordlTextBox;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel registrarionLabel;
        private MaterialSkin.Controls.MaterialButton registrButton;
        private MaterialSkin.Controls.MaterialButton exitButton;
    }
}

