namespace TestingANDQuality
{
    partial class Form1
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
            this.btnTransform = new System.Windows.Forms.Button();
            this.textBoxInitialArray = new System.Windows.Forms.TextBox();
            this.textBoxResultArray = new System.Windows.Forms.TextBox();
            this.buttonRandGenerate = new System.Windows.Forms.Button();
            this.buttonLoadArray = new System.Windows.Forms.Button();
            this.buttonHandwritingArray = new System.Windows.Forms.Button();
            this.radioButtonOnTheScreen = new System.Windows.Forms.RadioButton();
            this.radioButtonToFile = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransform
            // 
            this.btnTransform.Enabled = false;
            this.btnTransform.Location = new System.Drawing.Point(201, 346);
            this.btnTransform.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(190, 45);
            this.btnTransform.TabIndex = 0;
            this.btnTransform.Text = "Преобразовать";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // textBoxInitialArray
            // 
            this.textBoxInitialArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInitialArray.Location = new System.Drawing.Point(9, 44);
            this.textBoxInitialArray.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxInitialArray.Multiline = true;
            this.textBoxInitialArray.Name = "textBoxInitialArray";
            this.textBoxInitialArray.ReadOnly = true;
            this.textBoxInitialArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInitialArray.Size = new System.Drawing.Size(351, 200);
            this.textBoxInitialArray.TabIndex = 1;
            // 
            // textBoxResultArray
            // 
            this.textBoxResultArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultArray.Location = new System.Drawing.Point(15, 17);
            this.textBoxResultArray.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxResultArray.Multiline = true;
            this.textBoxResultArray.Name = "textBoxResultArray";
            this.textBoxResultArray.ReadOnly = true;
            this.textBoxResultArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultArray.Size = new System.Drawing.Size(350, 200);
            this.textBoxResultArray.TabIndex = 2;
            // 
            // buttonRandGenerate
            // 
            this.buttonRandGenerate.Location = new System.Drawing.Point(274, 12);
            this.buttonRandGenerate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRandGenerate.Name = "buttonRandGenerate";
            this.buttonRandGenerate.Size = new System.Drawing.Size(116, 45);
            this.buttonRandGenerate.TabIndex = 3;
            this.buttonRandGenerate.Text = "Сгенерировать случайно";
            this.buttonRandGenerate.UseVisualStyleBackColor = true;
            this.buttonRandGenerate.Click += new System.EventHandler(this.buttonRandGenerate_Click);
            // 
            // buttonLoadArray
            // 
            this.buttonLoadArray.Location = new System.Drawing.Point(24, 12);
            this.buttonLoadArray.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLoadArray.Name = "buttonLoadArray";
            this.buttonLoadArray.Size = new System.Drawing.Size(113, 45);
            this.buttonLoadArray.TabIndex = 4;
            this.buttonLoadArray.Text = "Загрузить из файла";
            this.buttonLoadArray.UseVisualStyleBackColor = true;
            this.buttonLoadArray.Click += new System.EventHandler(this.buttonLoadArray_Click);
            // 
            // buttonHandwritingArray
            // 
            this.buttonHandwritingArray.Location = new System.Drawing.Point(141, 13);
            this.buttonHandwritingArray.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonHandwritingArray.Name = "buttonHandwritingArray";
            this.buttonHandwritingArray.Size = new System.Drawing.Size(129, 45);
            this.buttonHandwritingArray.TabIndex = 5;
            this.buttonHandwritingArray.Text = "Ручной ввод";
            this.buttonHandwritingArray.UseVisualStyleBackColor = true;
            this.buttonHandwritingArray.Click += new System.EventHandler(this.buttonHandwritingArray_Click);
            // 
            // radioButtonOnTheScreen
            // 
            this.radioButtonOnTheScreen.AutoSize = true;
            this.radioButtonOnTheScreen.Checked = true;
            this.radioButtonOnTheScreen.Location = new System.Drawing.Point(22, 346);
            this.radioButtonOnTheScreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonOnTheScreen.Name = "radioButtonOnTheScreen";
            this.radioButtonOnTheScreen.Size = new System.Drawing.Size(170, 17);
            this.radioButtonOnTheScreen.TabIndex = 6;
            this.radioButtonOnTheScreen.TabStop = true;
            this.radioButtonOnTheScreen.Text = "Запись результата на экран";
            this.radioButtonOnTheScreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonToFile
            // 
            this.radioButtonToFile.AutoSize = true;
            this.radioButtonToFile.Location = new System.Drawing.Point(22, 369);
            this.radioButtonToFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonToFile.Name = "radioButtonToFile";
            this.radioButtonToFile.Size = new System.Drawing.Size(159, 17);
            this.radioButtonToFile.TabIndex = 7;
            this.radioButtonToFile.Text = "Запить результата в файл";
            this.radioButtonToFile.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(24, 64);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(366, 23);
            this.progressBar.TabIndex = 12;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxInitialArray);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox.Location = new System.Drawing.Point(22, 90);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(369, 250);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Исходный массив(Источник не выбран)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxResultArray);
            this.groupBox2.Location = new System.Drawing.Point(16, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 223);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.radioButtonToFile);
            this.Controls.Add(this.radioButtonOnTheScreen);
            this.Controls.Add(this.buttonHandwritingArray);
            this.Controls.Add(this.buttonLoadArray);
            this.Controls.Add(this.buttonRandGenerate);
            this.Controls.Add(this.btnTransform);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Качество и тестирование ПО";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.TextBox textBoxInitialArray;
        private System.Windows.Forms.TextBox textBoxResultArray;
        private System.Windows.Forms.Button buttonRandGenerate;
        private System.Windows.Forms.Button buttonLoadArray;
        private System.Windows.Forms.Button buttonHandwritingArray;
        private System.Windows.Forms.RadioButton radioButtonOnTheScreen;
        private System.Windows.Forms.RadioButton radioButtonToFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

