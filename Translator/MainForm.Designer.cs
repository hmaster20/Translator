namespace Translator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enRuRadioButton = new System.Windows.Forms.RadioButton();
            this.ruEnRadioButton = new System.Windows.Forms.RadioButton();
            this.cBoxTranslatDirect = new System.Windows.Forms.ComboBox();
            this.tabC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(400, 100);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.outputTextBox.Location = new System.Drawing.Point(12, 199);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(400, 100);
            this.outputTextBox.TabIndex = 1;
            // 
            // translateButton
            // 
            this.translateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.translateButton.Location = new System.Drawing.Point(12, 136);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(155, 39);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "ПЕРЕВЕСТИ";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enRuRadioButton);
            this.groupBox1.Controls.Add(this.ruEnRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Направление перевода";
            // 
            // enRuRadioButton
            // 
            this.enRuRadioButton.AutoSize = true;
            this.enRuRadioButton.Location = new System.Drawing.Point(33, 64);
            this.enRuRadioButton.Name = "enRuRadioButton";
            this.enRuRadioButton.Size = new System.Drawing.Size(84, 22);
            this.enRuRadioButton.TabIndex = 1;
            this.enRuRadioButton.Text = "Eng-Rus";
            this.enRuRadioButton.UseVisualStyleBackColor = true;
            // 
            // ruEnRadioButton
            // 
            this.ruEnRadioButton.AutoSize = true;
            this.ruEnRadioButton.Checked = true;
            this.ruEnRadioButton.Location = new System.Drawing.Point(33, 32);
            this.ruEnRadioButton.Name = "ruEnRadioButton";
            this.ruEnRadioButton.Size = new System.Drawing.Size(84, 22);
            this.ruEnRadioButton.TabIndex = 0;
            this.ruEnRadioButton.TabStop = true;
            this.ruEnRadioButton.Text = "Rus-Eng";
            this.ruEnRadioButton.UseVisualStyleBackColor = true;
            // 
            // cBoxTranslatDirect
            // 
            this.cBoxTranslatDirect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTranslatDirect.FormattingEnabled = true;
            this.cBoxTranslatDirect.Location = new System.Drawing.Point(27, 48);
            this.cBoxTranslatDirect.Name = "cBoxTranslatDirect";
            this.cBoxTranslatDirect.Size = new System.Drawing.Size(205, 21);
            this.cBoxTranslatDirect.TabIndex = 4;
            // 
            // tabC
            // 
            this.tabC.Controls.Add(this.tabPage1);
            this.tabC.Controls.Add(this.tabPage2);
            this.tabC.Location = new System.Drawing.Point(432, 12);
            this.tabC.Name = "tabC";
            this.tabC.SelectedIndex = 0;
            this.tabC.Size = new System.Drawing.Size(261, 144);
            this.tabC.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(253, 118);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Простой";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cBoxTranslatDirect);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(253, 118);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расширенный";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите направление перевода";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 308);
            this.Controls.Add(this.tabC);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MainForm";
            this.Text = "Переводчик (Yandex API)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton enRuRadioButton;
        private System.Windows.Forms.RadioButton ruEnRadioButton;
        private System.Windows.Forms.ComboBox cBoxTranslatDirect;
        private System.Windows.Forms.TabControl tabC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
    }
}

