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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chGraph2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbCountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chblnvers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chGraph2)).BeginInit();
            this.SuspendLayout();
            // 
            // chGraph2
            // 
            chartArea1.Name = "ChartArea1";
            this.chGraph2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGraph2.Legends.Add(legend1);
            this.chGraph2.Location = new System.Drawing.Point(1, 92);
            this.chGraph2.Name = "chGraph2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chGraph2.Series.Add(series1);
            this.chGraph2.Size = new System.Drawing.Size(336, 422);
            this.chGraph2.TabIndex = 0;
            this.chGraph2.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerateNums_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сортировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Следующий шаг";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(79, 56);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(258, 20);
            this.tbNum.TabIndex = 4;
            // 
            // tbCountNumber
            // 
            this.tbCountNumber.Location = new System.Drawing.Point(117, 15);
            this.tbCountNumber.Name = "tbCountNumber";
            this.tbCountNumber.Size = new System.Drawing.Size(119, 20);
            this.tbCountNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество чисел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "числа";
            // 
            // chblnvers
            // 
            this.chblnvers.AutoSize = true;
            this.chblnvers.Location = new System.Drawing.Point(303, 17);
            this.chblnvers.Name = "chblnvers";
            this.chblnvers.Size = new System.Drawing.Size(76, 17);
            this.chblnvers.TabIndex = 8;
            this.chblnvers.Text = "Инверсия";
            this.chblnvers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(526, 513);
            this.Controls.Add(this.chblnvers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCountNumber);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chGraph2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chGraph2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chGraph2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbCountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chblnvers;
    }
}

