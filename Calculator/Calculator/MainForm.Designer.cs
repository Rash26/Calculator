using System.ComponentModel;
using System.Windows.Forms;

namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.FirstValue = new System.Windows.Forms.TextBox();
            this.SecondValue = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Added = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Cot = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Squaring = new System.Windows.Forms.Button();
            this.Bubble = new System.Windows.Forms.Button();
            this.SelectionSort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstValue
            // 
            this.FirstValue.Location = new System.Drawing.Point(12, 38);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(129, 20);
            this.FirstValue.TabIndex = 0;
            this.FirstValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstValueKeyPress);
            // 
            // SecondValue
            // 
            this.SecondValue.Location = new System.Drawing.Point(147, 38);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(131, 20);
            this.SecondValue.TabIndex = 1;
            this.SecondValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstValueKeyPress);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result.Cursor = System.Windows.Forms.Cursors.Default;
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(12, 12);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(266, 20);
            this.Result.TabIndex = 2;
            // 
            // Added
            // 
            this.Added.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Added.Location = new System.Drawing.Point(13, 65);
            this.Added.Name = "Added";
            this.Added.Size = new System.Drawing.Size(61, 47);
            this.Added.TabIndex = 3;
            this.Added.Text = "+";
            this.Added.UseVisualStyleBackColor = true;
            this.Added.Click += new System.EventHandler(this.PlusClick);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(80, 65);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(61, 47);
            this.Minus.TabIndex = 4;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.PlusClick);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Divide.Location = new System.Drawing.Point(217, 65);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(61, 47);
            this.Divide.TabIndex = 5;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.PlusClick);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(150, 64);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(61, 47);
            this.Multiply.TabIndex = 6;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.PlusClick);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(13, 219);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(265, 37);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ClearClick);
            // 
            // Sin
            // 
            this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sin.Location = new System.Drawing.Point(13, 113);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(61, 47);
            this.Sin.TabIndex = 10;
            this.Sin.Text = "SIN";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.SinClick);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cos.Location = new System.Drawing.Point(217, 113);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(61, 47);
            this.Cos.TabIndex = 10;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.SinClick);
            // 
            // Tan
            // 
            this.Tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tan.Location = new System.Drawing.Point(80, 113);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(61, 47);
            this.Tan.TabIndex = 10;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.SinClick);
            // 
            // Cot
            // 
            this.Cot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cot.Location = new System.Drawing.Point(150, 113);
            this.Cot.Name = "Cot";
            this.Cot.Size = new System.Drawing.Size(61, 47);
            this.Cot.TabIndex = 10;
            this.Cot.Text = "Cot";
            this.Cot.UseVisualStyleBackColor = true;
            this.Cot.Click += new System.EventHandler(this.SinClick);
            // 
            // Sqrt
            // 
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sqrt.Location = new System.Drawing.Point(13, 166);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(61, 47);
            this.Sqrt.TabIndex = 11;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.SinClick);
            // 
            // Power
            // 
            this.Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Power.Location = new System.Drawing.Point(80, 166);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(131, 47);
            this.Power.TabIndex = 12;
            this.Power.Text = "x^y";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.PlusClick);
            // 
            // Squaring
            // 
            this.Squaring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Squaring.Location = new System.Drawing.Point(216, 166);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(61, 47);
            this.Squaring.TabIndex = 13;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.SinClick);
            // 
            // Bubble
            // 
            this.Bubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bubble.Location = new System.Drawing.Point(13, 262);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(61, 47);
            this.Bubble.TabIndex = 13;
            this.Bubble.Text = "1";
            this.Bubble.UseVisualStyleBackColor = true;
            this.Bubble.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // SelectionSort
            // 
            this.SelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectionSort.Location = new System.Drawing.Point(80, 262);
            this.SelectionSort.Name = "SelectionSort";
            this.SelectionSort.Size = new System.Drawing.Size(61, 47);
            this.SelectionSort.TabIndex = 13;
            this.SelectionSort.Text = "2";
            this.SelectionSort.UseVisualStyleBackColor = true;
            this.SelectionSort.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(150, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 47);
            this.button3.TabIndex = 13;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(216, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 47);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 367);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SelectionSort);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.Squaring);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Cot);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Added);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondValue);
            this.Controls.Add(this.FirstValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstValue;
        private TextBox SecondValue;
        private TextBox Result;
        private Button Added;
        private Button Minus;
        private Button Divide;
        private Button Multiply;
        private Button Clear;
        private Button Sin;
        private Button Cos;
        private Button Tan;
        private Button Cot;
        private Button Sqrt;
        private Button Power;
        private Button Squaring;
        private Button Bubble;
        private Button SelectionSort;
        private Button button3;
        private Button button4;
    }
}

