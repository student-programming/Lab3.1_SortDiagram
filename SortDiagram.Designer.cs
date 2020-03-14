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
            this.chGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCountNumbers = new System.Windows.Forms.TextBox();
            this.tbNums = new System.Windows.Forms.TextBox();
            this.btnGenerateNums = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chGraph)).BeginInit();
            this.SuspendLayout();
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
    }
}

