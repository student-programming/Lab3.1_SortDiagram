namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCountNumbers = new System.Windows.Forms.TextBox();
            this.tbNums = new System.Windows.Forms.TextBox();
            this.btnGenerateNums = new System.Windows.Forms.Button();
            this.bthSort = new System.Windows.Forms.Button();
            this.bthNextStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chGraph
            // 
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Name = "ChartArea1";
            this.chGraph.ChartAreas.Add(chartArea4);
            this.chGraph.Location = new System.Drawing.Point(40, 77);
            this.chGraph.Name = "chGraph";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chGraph.Series.Add(series4);
            this.chGraph.Size = new System.Drawing.Size(394, 329);
            this.chGraph.TabIndex = 0;
            this.chGraph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Числа";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbCountNumbers
            // 
            this.tbCountNumbers.Location = new System.Drawing.Point(116, 5);
            this.tbCountNumbers.Name = "tbCountNumbers";
            this.tbCountNumbers.Size = new System.Drawing.Size(100, 20);
            this.tbCountNumbers.TabIndex = 3;
            // 
            // tbNums
            // 
            this.tbNums.Location = new System.Drawing.Point(69, 31);
            this.tbNums.Name = "tbNums";
            this.tbNums.Size = new System.Drawing.Size(100, 20);
            this.tbNums.TabIndex = 4;
            // 
            // btnGenerateNums
            // 
            this.btnGenerateNums.Location = new System.Drawing.Point(454, 51);
            this.btnGenerateNums.Name = "btnGenerateNums";
            this.btnGenerateNums.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateNums.TabIndex = 5;
            this.btnGenerateNums.Text = "Сгенерировать";
            this.btnGenerateNums.UseVisualStyleBackColor = true;
            this.btnGenerateNums.Click += new System.EventHandler(this.btnGenerateNums_Click);
            // 
            // bthSort
            // 
            this.bthSort.Location = new System.Drawing.Point(454, 81);
            this.bthSort.Name = "bthSort";
            this.bthSort.Size = new System.Drawing.Size(75, 23);
            this.bthSort.TabIndex = 6;
            this.bthSort.Text = "Сортировать";
            this.bthSort.UseVisualStyleBackColor = true;
            this.bthSort.Click += new System.EventHandler(this.bthSort_Click);
            // 
            // bthNextStep
            // 
            this.bthNextStep.Location = new System.Drawing.Point(454, 111);
            this.bthNextStep.Name = "bthNextStep";
            this.bthNextStep.Size = new System.Drawing.Size(75, 23);
            this.bthNextStep.TabIndex = 7;
            this.bthNextStep.Text = "Следующий шаг";
            this.bthNextStep.UseVisualStyleBackColor = true;
            this.bthNextStep.Click += new System.EventHandler(this.bthNextStep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 477);
            this.Controls.Add(this.bthNextStep);
            this.Controls.Add(this.bthSort);
            this.Controls.Add(this.btnGenerateNums);
            this.Controls.Add(this.tbNums);
            this.Controls.Add(this.tbCountNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCountNumbers;
        private System.Windows.Forms.TextBox tbNums;
        private System.Windows.Forms.Button btnGenerateNums;
        private System.Windows.Forms.Button bthSort;
        private System.Windows.Forms.Button bthNextStep;
    }
}

