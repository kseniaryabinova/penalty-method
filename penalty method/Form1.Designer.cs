namespace penalty_method
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
            this.equation = new System.Windows.Forms.ComboBox();
            this.penalty = new System.Windows.Forms.ComboBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equation
            // 
            this.equation.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation.FormattingEnabled = true;
            this.equation.Location = new System.Drawing.Point(12, 13);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(555, 34);
            this.equation.TabIndex = 0;
            this.equation.Text = "введите функцию";
            this.equation.Leave += new System.EventHandler(this.equation_Leave);
            // 
            // penalty
            // 
            this.penalty.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.penalty.FormattingEnabled = true;
            this.penalty.Location = new System.Drawing.Point(12, 53);
            this.penalty.Name = "penalty";
            this.penalty.Size = new System.Drawing.Size(555, 34);
            this.penalty.TabIndex = 1;
            this.penalty.Text = "введите функцию штрафов";
            this.penalty.Leave += new System.EventHandler(this.penalty_Leave);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(12, 93);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(554, 680);
            this.output.TabIndex = 4;
            this.output.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(554, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 888);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.penalty);
            this.Controls.Add(this.equation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "метод штрафных функций";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox equation;
        private System.Windows.Forms.ComboBox penalty;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button button1;
    }
}

