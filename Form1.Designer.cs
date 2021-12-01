
namespace CalculatorWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNumberOne = new System.Windows.Forms.Button();
            this.btnNumberTwo = new System.Windows.Forms.Button();
            this.btnNumberThree = new System.Windows.Forms.Button();
            this.btnNumberFour = new System.Windows.Forms.Button();
            this.btnNumberFive = new System.Windows.Forms.Button();
            this.btnNumberSix = new System.Windows.Forms.Button();
            this.btnNumberSeven = new System.Windows.Forms.Button();
            this.btnNumberNine = new System.Windows.Forms.Button();
            this.btnNumberEight = new System.Windows.Forms.Button();
            this.txtInputField = new System.Windows.Forms.TextBox();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnNumberZero = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumberOne
            // 
            this.btnNumberOne.Location = new System.Drawing.Point(322, 239);
            this.btnNumberOne.Name = "btnNumberOne";
            this.btnNumberOne.Size = new System.Drawing.Size(25, 25);
            this.btnNumberOne.TabIndex = 0;
            this.btnNumberOne.Text = "1";
            this.btnNumberOne.UseVisualStyleBackColor = true;
            this.btnNumberOne.Click += new System.EventHandler(this.btnNumberOne_Click);
            // 
            // btnNumberTwo
            // 
            this.btnNumberTwo.Location = new System.Drawing.Point(353, 239);
            this.btnNumberTwo.Name = "btnNumberTwo";
            this.btnNumberTwo.Size = new System.Drawing.Size(25, 25);
            this.btnNumberTwo.TabIndex = 1;
            this.btnNumberTwo.Text = "2";
            this.btnNumberTwo.UseVisualStyleBackColor = true;
            this.btnNumberTwo.Click += new System.EventHandler(this.btnNumberTwo_Click);
            // 
            // btnNumberThree
            // 
            this.btnNumberThree.Location = new System.Drawing.Point(384, 239);
            this.btnNumberThree.Name = "btnNumberThree";
            this.btnNumberThree.Size = new System.Drawing.Size(25, 25);
            this.btnNumberThree.TabIndex = 2;
            this.btnNumberThree.Text = "3";
            this.btnNumberThree.UseVisualStyleBackColor = true;
            this.btnNumberThree.Click += new System.EventHandler(this.btnNumberThree_Click);
            // 
            // btnNumberFour
            // 
            this.btnNumberFour.Location = new System.Drawing.Point(322, 208);
            this.btnNumberFour.Name = "btnNumberFour";
            this.btnNumberFour.Size = new System.Drawing.Size(25, 25);
            this.btnNumberFour.TabIndex = 3;
            this.btnNumberFour.Text = "4";
            this.btnNumberFour.UseVisualStyleBackColor = true;
            this.btnNumberFour.Click += new System.EventHandler(this.btnNumberFour_Click);
            // 
            // btnNumberFive
            // 
            this.btnNumberFive.Location = new System.Drawing.Point(353, 208);
            this.btnNumberFive.Name = "btnNumberFive";
            this.btnNumberFive.Size = new System.Drawing.Size(25, 25);
            this.btnNumberFive.TabIndex = 4;
            this.btnNumberFive.Text = "5";
            this.btnNumberFive.UseVisualStyleBackColor = true;
            this.btnNumberFive.Click += new System.EventHandler(this.btnNumberFive_Click);
            // 
            // btnNumberSix
            // 
            this.btnNumberSix.Location = new System.Drawing.Point(384, 208);
            this.btnNumberSix.Name = "btnNumberSix";
            this.btnNumberSix.Size = new System.Drawing.Size(25, 25);
            this.btnNumberSix.TabIndex = 5;
            this.btnNumberSix.Text = "6";
            this.btnNumberSix.UseVisualStyleBackColor = true;
            this.btnNumberSix.Click += new System.EventHandler(this.btnNumberSix_Click);
            // 
            // btnNumberSeven
            // 
            this.btnNumberSeven.Location = new System.Drawing.Point(322, 177);
            this.btnNumberSeven.Name = "btnNumberSeven";
            this.btnNumberSeven.Size = new System.Drawing.Size(25, 25);
            this.btnNumberSeven.TabIndex = 6;
            this.btnNumberSeven.Text = "7";
            this.btnNumberSeven.UseVisualStyleBackColor = true;
            this.btnNumberSeven.Click += new System.EventHandler(this.btnNumberSeven_Click);
            // 
            // btnNumberNine
            // 
            this.btnNumberNine.Location = new System.Drawing.Point(384, 177);
            this.btnNumberNine.Name = "btnNumberNine";
            this.btnNumberNine.Size = new System.Drawing.Size(25, 25);
            this.btnNumberNine.TabIndex = 7;
            this.btnNumberNine.Text = "9";
            this.btnNumberNine.UseVisualStyleBackColor = true;
            this.btnNumberNine.Click += new System.EventHandler(this.btnNumberNine_Click);
            // 
            // btnNumberEight
            // 
            this.btnNumberEight.Location = new System.Drawing.Point(353, 177);
            this.btnNumberEight.Name = "btnNumberEight";
            this.btnNumberEight.Size = new System.Drawing.Size(25, 25);
            this.btnNumberEight.TabIndex = 8;
            this.btnNumberEight.Text = "8";
            this.btnNumberEight.UseVisualStyleBackColor = true;
            this.btnNumberEight.Click += new System.EventHandler(this.btnNumberEight_Click);
            // 
            // txtInputField
            // 
            this.txtInputField.Enabled = false;
            this.txtInputField.Location = new System.Drawing.Point(322, 144);
            this.txtInputField.Name = "txtInputField";
            this.txtInputField.PlaceholderText = "0";
            this.txtInputField.ReadOnly = true;
            this.txtInputField.Size = new System.Drawing.Size(149, 23);
            this.txtInputField.TabIndex = 9;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(446, 208);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(25, 25);
            this.btnDivision.TabIndex = 10;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(415, 177);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(25, 25);
            this.btnAddition.TabIndex = 11;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(415, 208);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(25, 25);
            this.btnMultiplication.TabIndex = 12;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(446, 177);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(25, 25);
            this.btnSubtraction.TabIndex = 13;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnNumberZero
            // 
            this.btnNumberZero.Location = new System.Drawing.Point(353, 270);
            this.btnNumberZero.Name = "btnNumberZero";
            this.btnNumberZero.Size = new System.Drawing.Size(25, 25);
            this.btnNumberZero.TabIndex = 14;
            this.btnNumberZero.Text = "0";
            this.btnNumberZero.UseVisualStyleBackColor = true;
            this.btnNumberZero.Click += new System.EventHandler(this.btnNumberZero_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(446, 270);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(25, 25);
            this.btnSum.TabIndex = 15;
            this.btnSum.Text = "=";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(415, 270);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(25, 25);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnNumberZero);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.txtInputField);
            this.Controls.Add(this.btnNumberNine);
            this.Controls.Add(this.btnNumberOne);
            this.Controls.Add(this.btnNumberEight);
            this.Controls.Add(this.btnNumberSeven);
            this.Controls.Add(this.btnNumberFour);
            this.Controls.Add(this.btnNumberThree);
            this.Controls.Add(this.btnNumberTwo);
            this.Controls.Add(this.btnNumberFive);
            this.Controls.Add(this.btnNumberSix);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumberOne;
        private System.Windows.Forms.Button btnNumberTwo;
        private System.Windows.Forms.Button btnNumberThree;
        private System.Windows.Forms.Button btnNumberFour;
        private System.Windows.Forms.Button btnNumberFive;
        private System.Windows.Forms.Button btnNumberSix;
        private System.Windows.Forms.Button btnNumberSeven;
        private System.Windows.Forms.Button btnNumberNine;
        private System.Windows.Forms.Button btnNumberEight;
        private System.Windows.Forms.TextBox txtInputField;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnNumberZero;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnReset;
    }
}

