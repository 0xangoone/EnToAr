namespace EnToAr
{
    partial class EnToAr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.toar = new System.Windows.Forms.RadioButton();
            this.toen = new System.Windows.Forms.RadioButton();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(18, 18);
            this.input.Margin = new System.Windows.Forms.Padding(9);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(582, 46);
            this.input.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(18, 240);
            this.convert.Margin = new System.Windows.Forms.Padding(9);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(155, 53);
            this.convert.TabIndex = 1;
            this.convert.Text = "convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(185, 254);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(134, 39);
            this.result.TabIndex = 2;
            this.result.Text = "resault: ";
            // 
            // toar
            // 
            this.toar.AutoSize = true;
            this.toar.Location = new System.Drawing.Point(18, 147);
            this.toar.Name = "toar";
            this.toar.Size = new System.Drawing.Size(169, 43);
            this.toar.TabIndex = 3;
            this.toar.TabStop = true;
            this.toar.Text = "To Arabic";
            this.toar.UseVisualStyleBackColor = true;
            // 
            // toen
            // 
            this.toen.AutoSize = true;
            this.toen.Location = new System.Drawing.Point(18, 98);
            this.toen.Name = "toen";
            this.toen.Size = new System.Drawing.Size(181, 43);
            this.toen.TabIndex = 4;
            this.toen.TabStop = true;
            this.toen.Text = "To English";
            this.toen.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(18, 197);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(155, 47);
            this.clear.TabIndex = 5;
            this.clear.Text = "clear ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // EnToAr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 426);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.toen);
            this.Controls.Add(this.toar);
            this.Controls.Add(this.result);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.input);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "EnToAr";
            this.Text = "EnToAr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.RadioButton toar;
        private System.Windows.Forms.RadioButton toen;
        private System.Windows.Forms.Button clear;
    }
}

