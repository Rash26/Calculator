﻿namespace Calculator
{
    partial class MainForm
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
            this.tbFirstValue = new System.Windows.Forms.TextBox();
            this.tbSecondValue = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bthPlus = new System.Windows.Forms.Button();
            this.bthMinus = new System.Windows.Forms.Button();
            this.bthDivide = new System.Windows.Forms.Button();
            this.bthMultiply = new System.Windows.Forms.Button();
            this.bthClear = new System.Windows.Forms.Button();
            this.bthExit = new System.Windows.Forms.Button();
            this.bthSin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstValue
            // 
            this.tbFirstValue.Location = new System.Drawing.Point(12, 38);
            this.tbFirstValue.Name = "tbFirstValue";
            this.tbFirstValue.Size = new System.Drawing.Size(129, 20);
            this.tbFirstValue.TabIndex = 0;
            this.tbFirstValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstValue_KeyPress);
            // 
            // tbSecondValue
            // 
            this.tbSecondValue.Location = new System.Drawing.Point(147, 38);
            this.tbSecondValue.Name = "tbSecondValue";
            this.tbSecondValue.Size = new System.Drawing.Size(131, 20);
            this.tbSecondValue.TabIndex = 1;
            this.tbSecondValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstValue_KeyPress);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(12, 12);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(266, 20);
            this.tbResult.TabIndex = 2;
            // 
            // bthPlus
            // 
            this.bthPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthPlus.Location = new System.Drawing.Point(13, 65);
            this.bthPlus.Name = "bthPlus";
            this.bthPlus.Size = new System.Drawing.Size(61, 47);
            this.bthPlus.TabIndex = 3;
            this.bthPlus.Text = "+";
            this.bthPlus.UseVisualStyleBackColor = true;
            this.bthPlus.Click += new System.EventHandler(this.bthPlus_Click);
            // 
            // bthMinus
            // 
            this.bthMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthMinus.Location = new System.Drawing.Point(80, 65);
            this.bthMinus.Name = "bthMinus";
            this.bthMinus.Size = new System.Drawing.Size(61, 47);
            this.bthMinus.TabIndex = 4;
            this.bthMinus.Text = "-";
            this.bthMinus.UseVisualStyleBackColor = true;
            this.bthMinus.Click += new System.EventHandler(this.bthPlus_Click);
            // 
            // bthDivide
            // 
            this.bthDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthDivide.Location = new System.Drawing.Point(217, 65);
            this.bthDivide.Name = "bthDivide";
            this.bthDivide.Size = new System.Drawing.Size(61, 47);
            this.bthDivide.TabIndex = 5;
            this.bthDivide.Text = "/";
            this.bthDivide.UseVisualStyleBackColor = true;
            this.bthDivide.Click += new System.EventHandler(this.bthPlus_Click);
            // 
            // bthMultiply
            // 
            this.bthMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthMultiply.Location = new System.Drawing.Point(147, 65);
            this.bthMultiply.Name = "bthMultiply";
            this.bthMultiply.Size = new System.Drawing.Size(61, 47);
            this.bthMultiply.TabIndex = 6;
            this.bthMultiply.Text = "*";
            this.bthMultiply.UseVisualStyleBackColor = true;
            this.bthMultiply.Click += new System.EventHandler(this.bthPlus_Click);
            // 
            // bthClear
            // 
            this.bthClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthClear.Location = new System.Drawing.Point(13, 166);
            this.bthClear.Name = "bthClear";
            this.bthClear.Size = new System.Drawing.Size(128, 37);
            this.bthClear.TabIndex = 7;
            this.bthClear.Text = "Clear";
            this.bthClear.UseVisualStyleBackColor = true;
            this.bthClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // bthExit
            // 
            this.bthExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthExit.Location = new System.Drawing.Point(150, 166);
            this.bthExit.Name = "bthExit";
            this.bthExit.Size = new System.Drawing.Size(128, 37);
            this.bthExit.TabIndex = 8;
            this.bthExit.Text = "Exit";
            this.bthExit.UseVisualStyleBackColor = true;
            this.bthExit.Click += new System.EventHandler(this.bthExit_Click);
            // 
            // bthSin
            // 
            this.bthSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthSin.Location = new System.Drawing.Point(13, 118);
            this.bthSin.Name = "bthSin";
            this.bthSin.Size = new System.Drawing.Size(128, 47);
            this.bthSin.TabIndex = 10;
            this.bthSin.Text = "SIN";
            this.bthSin.UseVisualStyleBackColor = true;
            this.bthSin.Click += new System.EventHandler(this.bthSin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 215);
            this.Controls.Add(this.bthSin);
            this.Controls.Add(this.bthExit);
            this.Controls.Add(this.bthClear);
            this.Controls.Add(this.bthMultiply);
            this.Controls.Add(this.bthDivide);
            this.Controls.Add(this.bthMinus);
            this.Controls.Add(this.bthPlus);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbSecondValue);
            this.Controls.Add(this.tbFirstValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstValue;
        private System.Windows.Forms.TextBox tbSecondValue;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button bthPlus;
        private System.Windows.Forms.Button bthMinus;
        private System.Windows.Forms.Button bthDivide;
        private System.Windows.Forms.Button bthMultiply;
        private System.Windows.Forms.Button bthClear;
        private System.Windows.Forms.Button bthExit;
        private System.Windows.Forms.Button bthSin;
    }
}

