namespace SortDiagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCountNumbers = new System.Windows.Forms.TextBox();
            this.tbNums = new System.Windows.Forms.TextBox();
            this.btnGenerateNums = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.chbInvers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chGraph
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.chGraph.ChartAreas.Add(chartArea2);
            this.chGraph.Location = new System.Drawing.Point(1, 65);
            this.chGraph.Name = "chGraph";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chGraph.Series.Add(series2);
            this.chGraph.Size = new System.Drawing.Size(300, 300);
            this.chGraph.TabIndex = 0;
            this.chGraph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Числа";
            // 
            // tbCountNumbers
            // 
            this.tbCountNumbers.Location = new System.Drawing.Point(119, 11);
            this.tbCountNumbers.Name = "tbCountNumbers";
            this.tbCountNumbers.Size = new System.Drawing.Size(100, 20);
            this.tbCountNumbers.TabIndex = 3;
            // 
            // tbNums
            // 
            this.tbNums.Location = new System.Drawing.Point(74, 33);
            this.tbNums.Name = "tbNums";
            this.tbNums.Size = new System.Drawing.Size(222, 20);
            this.tbNums.TabIndex = 4;
            // 
            // btnGenerateNums
            // 
            this.btnGenerateNums.Location = new System.Drawing.Point(302, 33);
            this.btnGenerateNums.Name = "btnGenerateNums";
            this.btnGenerateNums.Size = new System.Drawing.Size(96, 23);
            this.btnGenerateNums.TabIndex = 5;
            this.btnGenerateNums.Text = "Сгенерировать";
            this.btnGenerateNums.UseVisualStyleBackColor = true;
            this.btnGenerateNums.Click += new System.EventHandler(this.btnGenerateNums_Click_1);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(302, 62);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(96, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(302, 91);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(96, 23);
            this.btnNextStep.TabIndex = 7;
            this.btnNextStep.Text = "Следующий шаг";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click_1);
            // 
            // chbInvers
            // 
            this.chbInvers.AutoSize = true;
            this.chbInvers.Location = new System.Drawing.Point(250, 14);
            this.chbInvers.Name = "chbInvers";
            this.chbInvers.Size = new System.Drawing.Size(76, 17);
            this.chbInvers.TabIndex = 8;
            this.chbInvers.Text = "Инверсия";
            this.chbInvers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 364);
            this.Controls.Add(this.chbInvers);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnSort);
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
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.CheckBox chbInvers;
    }
}

