namespace inClassAssignment3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarsWeight = new System.Windows.Forms.TextBox();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your weight on Earth.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your weight on Mars.";
            // 
            // txtMarsWeight
            // 
            this.txtMarsWeight.Location = new System.Drawing.Point(610, 263);
            this.txtMarsWeight.Name = "txtMarsWeight";
            this.txtMarsWeight.Size = new System.Drawing.Size(100, 31);
            this.txtMarsWeight.TabIndex = 2;
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(610, 149);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(100, 31);
            this.txtEarthWeight.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(543, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.txtMarsWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarsWeight;
        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.Button button1;
    }
}

