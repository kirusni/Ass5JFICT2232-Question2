namespace AreaCalculator
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.btnCalcukate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.Location = new System.Drawing.Point(147, 71);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 30);
            this.txtRadius.TabIndex = 13;
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radius.Location = new System.Drawing.Point(79, 74);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(71, 25);
            this.Radius.TabIndex = 11;
            this.Radius.Text = "Side A";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(158, 234);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 8;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(79, 234);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(72, 25);
            this.Area.TabIndex = 9;
            this.Area.Text = "Side C";
            // 
            // btnCalcukate
            // 
            this.btnCalcukate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcukate.Location = new System.Drawing.Point(147, 156);
            this.btnCalcukate.Name = "btnCalcukate";
            this.btnCalcukate.Size = new System.Drawing.Size(133, 44);
            this.btnCalcukate.TabIndex = 7;
            this.btnCalcukate.Text = "Calculate";
            this.btnCalcukate.UseVisualStyleBackColor = true;
            this.btnCalcukate.Click += new System.EventHandler(this.btnCalcukate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 429);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.btnCalcukate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button btnCalcukate;
    }
}

