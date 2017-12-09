namespace groupsRings
{
    partial class FormForCoefficients
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
            this.NLabel = new System.Windows.Forms.Label();
            this.valN = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.startDegreeBut = new System.Windows.Forms.Button();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.valDegree = new System.Windows.Forms.TextBox();
            this.outputType = new System.Windows.Forms.Label();
            this.outputFile = new System.Windows.Forms.CheckBox();
            this.outputScreen = new System.Windows.Forms.CheckBox();
            this.degreeU = new System.Windows.Forms.Button();
            this.multiplicationU = new System.Windows.Forms.Button();
            this.LabelfileName = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NLabel
            // 
            this.NLabel.Location = new System.Drawing.Point(12, 9);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(199, 20);
            this.NLabel.TabIndex = 5;
            this.NLabel.Text = "количество коэфициентов:";
            // 
            // valN
            // 
            this.valN.Location = new System.Drawing.Point(217, 9);
            this.valN.Multiline = true;
            this.valN.Name = "valN";
            this.valN.Size = new System.Drawing.Size(100, 20);
            this.valN.TabIndex = 4;
            this.valN.Text = "27";
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Location = new System.Drawing.Point(12, 89);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(980, 283);
            this.resultBox.TabIndex = 9;
            // 
            // startDegreeBut
            // 
            this.startDegreeBut.Location = new System.Drawing.Point(12, 32);
            this.startDegreeBut.Name = "startDegreeBut";
            this.startDegreeBut.Size = new System.Drawing.Size(164, 51);
            this.startDegreeBut.TabIndex = 11;
            this.startDegreeBut.Text = "Возвести в степень";
            this.startDegreeBut.UseVisualStyleBackColor = true;
            this.startDegreeBut.Click += new System.EventHandler(this.startDegreeBut_Click);
            // 
            // degreeLabel
            // 
            this.degreeLabel.Location = new System.Drawing.Point(394, 9);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(106, 20);
            this.degreeLabel.TabIndex = 13;
            this.degreeLabel.Text = "в какую степень:";
            // 
            // valDegree
            // 
            this.valDegree.Location = new System.Drawing.Point(506, 9);
            this.valDegree.Multiline = true;
            this.valDegree.Name = "valDegree";
            this.valDegree.Size = new System.Drawing.Size(100, 20);
            this.valDegree.TabIndex = 12;
            this.valDegree.Text = "9";
            // 
            // outputType
            // 
            this.outputType.Location = new System.Drawing.Point(657, 9);
            this.outputType.Name = "outputType";
            this.outputType.Size = new System.Drawing.Size(63, 20);
            this.outputType.TabIndex = 14;
            this.outputType.Text = "вывод в:";
            // 
            // outputFile
            // 
            this.outputFile.AutoSize = true;
            this.outputFile.Location = new System.Drawing.Point(713, 8);
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(52, 17);
            this.outputFile.TabIndex = 16;
            this.outputFile.Text = "файл";
            this.outputFile.UseVisualStyleBackColor = true;
            // 
            // outputScreen
            // 
            this.outputScreen.AutoSize = true;
            this.outputScreen.Checked = true;
            this.outputScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outputScreen.Location = new System.Drawing.Point(771, 8);
            this.outputScreen.Name = "outputScreen";
            this.outputScreen.Size = new System.Drawing.Size(56, 17);
            this.outputScreen.TabIndex = 17;
            this.outputScreen.Text = "экран";
            this.outputScreen.UseVisualStyleBackColor = true;
            // 
            // degreeU
            // 
            this.degreeU.Location = new System.Drawing.Point(182, 32);
            this.degreeU.Name = "degreeU";
            this.degreeU.Size = new System.Drawing.Size(164, 51);
            this.degreeU.TabIndex = 18;
            this.degreeU.Text = "Ui * Uj в степень";
            this.degreeU.UseVisualStyleBackColor = true;
            this.degreeU.Click += new System.EventHandler(this.degreeU_Click);
            // 
            // multiplicationU
            // 
            this.multiplicationU.Location = new System.Drawing.Point(352, 32);
            this.multiplicationU.Name = "multiplicationU";
            this.multiplicationU.Size = new System.Drawing.Size(164, 51);
            this.multiplicationU.TabIndex = 19;
            this.multiplicationU.Text = "U в степень";
            this.multiplicationU.UseVisualStyleBackColor = true;
            this.multiplicationU.Click += new System.EventHandler(this.multiplicationU_Click);
            // 
            // LabelfileName
            // 
            this.LabelfileName.Location = new System.Drawing.Point(657, 28);
            this.LabelfileName.Name = "LabelfileName";
            this.LabelfileName.Size = new System.Drawing.Size(94, 20);
            this.LabelfileName.TabIndex = 20;
            this.LabelfileName.Text = "название файла";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(757, 25);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(118, 20);
            this.fileName.TabIndex = 21;
            // 
            // FormForCoefficients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 384);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.LabelfileName);
            this.Controls.Add(this.multiplicationU);
            this.Controls.Add(this.degreeU);
            this.Controls.Add(this.outputScreen);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.outputType);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.valDegree);
            this.Controls.Add(this.startDegreeBut);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.valN);
            this.MinimumSize = new System.Drawing.Size(900, 300);
            this.Name = "FormForCoefficients";
            this.Text = "Programm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.TextBox valN;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button startDegreeBut;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.TextBox valDegree;
        private System.Windows.Forms.Label outputType;
        private System.Windows.Forms.CheckBox outputFile;
        private System.Windows.Forms.CheckBox outputScreen;
        private System.Windows.Forms.Button degreeU;
        private System.Windows.Forms.Button multiplicationU;
        private System.Windows.Forms.Label LabelfileName;
        private System.Windows.Forms.TextBox fileName;
    }
}

