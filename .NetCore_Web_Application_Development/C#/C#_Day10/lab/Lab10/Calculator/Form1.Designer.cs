namespace Calculator
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnFour = new Button();
            btnOne = new Button();
            btnDot = new Button();
            btnZero = new Button();
            btnFive = new Button();
            btnTwo = new Button();
            btnSeven = new Button();
            btnSix = new Button();
            btnthree = new Button();
            btnEquals = new Button();
            btnMinus = new Button();
            btnMulti = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btnNine = new Button();
            btnEight = new Button();
            screen = new TextBox();
            openBracket = new Button();
            closeBracket = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnFour
            // 
            btnFour.Location = new Point(49, 280);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(109, 37);
            btnFour.TabIndex = 0;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnNumber_Clicked;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(49, 323);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(109, 37);
            btnOne.TabIndex = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnNumber_Clicked;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(279, 323);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(109, 37);
            btnDot.TabIndex = 2;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnNumber_Clicked;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(164, 323);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(109, 37);
            btnZero.TabIndex = 3;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnNumber_Clicked;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(279, 237);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(109, 37);
            btnFive.TabIndex = 4;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnNumber_Clicked;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(279, 280);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(109, 37);
            btnTwo.TabIndex = 5;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnNumber_Clicked;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(49, 237);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(109, 37);
            btnSeven.TabIndex = 6;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnNumber_Clicked;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(164, 237);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(109, 37);
            btnSix.TabIndex = 7;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnNumber_Clicked;
            // 
            // btnthree
            // 
            btnthree.Location = new Point(164, 280);
            btnthree.Name = "btnthree";
            btnthree.Size = new Size(109, 37);
            btnthree.TabIndex = 8;
            btnthree.Text = "3";
            btnthree.UseVisualStyleBackColor = true;
            btnthree.Click += btnNumber_Clicked;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(394, 323);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(109, 37);
            btnEquals.TabIndex = 9;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(394, 280);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(109, 37);
            btnMinus.TabIndex = 10;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnNumber_Clicked;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(394, 237);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(109, 37);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnNumber_Clicked;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(394, 194);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(109, 37);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnNumber_Clicked;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(279, 194);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 37);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(49, 194);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(109, 37);
            btnNine.TabIndex = 16;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNumber_Clicked;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(164, 194);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(109, 37);
            btnEight.TabIndex = 14;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnNumber_Clicked;
            // 
            // screen
            // 
            screen.Dock = DockStyle.Top;
            screen.Enabled = false;
            screen.Location = new Point(0, 0);
            screen.Multiline = true;
            screen.Name = "screen";
            screen.Size = new Size(550, 56);
            screen.TabIndex = 17;
            // 
            // openBracket
            // 
            openBracket.Location = new Point(49, 151);
            openBracket.Name = "openBracket";
            openBracket.Size = new Size(109, 37);
            openBracket.TabIndex = 18;
            openBracket.Text = "(";
            openBracket.UseVisualStyleBackColor = true;
            openBracket.Click += btnNumber_Clicked;
            // 
            // closeBracket
            // 
            closeBracket.Location = new Point(164, 151);
            closeBracket.Name = "closeBracket";
            closeBracket.Size = new Size(109, 37);
            closeBracket.TabIndex = 19;
            closeBracket.Text = ")";
            closeBracket.UseVisualStyleBackColor = true;
            closeBracket.Click += btnNumber_Clicked;
            // 
            // button1
            // 
            button1.Location = new Point(394, 151);
            button1.Name = "button1";
            button1.Size = new Size(109, 37);
            button1.TabIndex = 20;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNumber_Clicked;
            // 
            // button2
            // 
            button2.Location = new Point(279, 151);
            button2.Name = "button2";
            button2.Size = new Size(109, 37);
            button2.TabIndex = 21;
            button2.Text = "del";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 398);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(closeBracket);
            Controls.Add(openBracket);
            Controls.Add(screen);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnMulti);
            Controls.Add(btnMinus);
            Controls.Add(btnEquals);
            Controls.Add(btnthree);
            Controls.Add(btnSix);
            Controls.Add(btnSeven);
            Controls.Add(btnTwo);
            Controls.Add(btnFive);
            Controls.Add(btnZero);
            Controls.Add(btnDot);
            Controls.Add(btnOne);
            Controls.Add(btnFour);
            Name = "Form1";
            Text = "Form1";
            Click += btnNumber_Clicked;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnFour;
        private Button btnOne;
        private Button btnDot;
        private Button btnZero;
        private Button btnFive;
        private Button btnTwo;
        private Button btnSeven;
        private Button btnSix;
        private Button btnthree;
        private Button btnEquals;
        private Button btnMinus;
        private Button btnMulti;
        private Button btnDivide;
        private Button btnClear;
        private Button btnNine;
        private Button btnEight;
        private TextBox screen;
        private Button openBracket;
        private Button closeBracket;
        private Button button1;
        private Button button2;
    }
}
