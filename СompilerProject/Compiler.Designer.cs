namespace СompilerProject
{
    partial class Compiler
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
            this.textInputData = new System.Windows.Forms.TextBox();
            this.textCompiler = new System.Windows.Forms.TextBox();
            this.richTextAnalysisDown = new System.Windows.Forms.RichTextBox();
            this.richTextAnalysisUp = new System.Windows.Forms.RichTextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInputData
            // 
            this.textInputData.Location = new System.Drawing.Point(12, 34);
            this.textInputData.Multiline = true;
            this.textInputData.Name = "textInputData";
            this.textInputData.Size = new System.Drawing.Size(440, 92);
            this.textInputData.TabIndex = 0;
            // 
            // textCompiler
            // 
            this.textCompiler.Location = new System.Drawing.Point(12, 411);
            this.textCompiler.Multiline = true;
            this.textCompiler.Name = "textCompiler";
            this.textCompiler.Size = new System.Drawing.Size(440, 92);
            this.textCompiler.TabIndex = 1;
            // 
            // richTextAnalysisDown
            // 
            this.richTextAnalysisDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextAnalysisDown.Location = new System.Drawing.Point(12, 156);
            this.richTextAnalysisDown.Name = "richTextAnalysisDown";
            this.richTextAnalysisDown.Size = new System.Drawing.Size(440, 96);
            this.richTextAnalysisDown.TabIndex = 2;
            this.richTextAnalysisDown.Text = "";
            this.richTextAnalysisDown.TextChanged += new System.EventHandler(this.richTextAnalysisDown_TextChanged);
            // 
            // richTextAnalysisUp
            // 
            this.richTextAnalysisUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextAnalysisUp.Location = new System.Drawing.Point(12, 282);
            this.richTextAnalysisUp.Name = "richTextAnalysisUp";
            this.richTextAnalysisUp.Size = new System.Drawing.Size(440, 96);
            this.richTextAnalysisUp.TabIndex = 3;
            this.richTextAnalysisUp.Text = "";
            this.richTextAnalysisUp.TextChanged += new System.EventHandler(this.richTextAnalysisUp_TextChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(21, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(160, 22);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Исходные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Нисходящий разбор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Восходящий разбор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текст на С";
            // 
            // butResult
            // 
            this.butResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butResult.Location = new System.Drawing.Point(480, 29);
            this.butResult.Name = "butResult";
            this.butResult.Size = new System.Drawing.Size(122, 28);
            this.butResult.TabIndex = 8;
            this.butResult.Text = "Вычислить";
            this.butResult.UseVisualStyleBackColor = true;
            this.butResult.Click += new System.EventHandler(this.butResult_Click);
            // 
            // Compiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 526);
            this.Controls.Add(this.butResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.richTextAnalysisUp);
            this.Controls.Add(this.richTextAnalysisDown);
            this.Controls.Add(this.textCompiler);
            this.Controls.Add(this.textInputData);
            this.Name = "Compiler";
            this.Text = "Компилятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInputData;
        private System.Windows.Forms.TextBox textCompiler;
        private System.Windows.Forms.RichTextBox richTextAnalysisDown;
        private System.Windows.Forms.RichTextBox richTextAnalysisUp;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butResult;
    }
}

