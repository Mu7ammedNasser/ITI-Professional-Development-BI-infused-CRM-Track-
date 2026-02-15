namespace DBTask
{
    partial class update
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
            comboInstructors = new ComboBox();
            label1 = new Label();
            clear_btnClick = new Button();
            label2 = new Label();
            Id_txtBox = new TextBox();
            label3 = new Label();
            InstructorName_txtBox = new TextBox();
            label5 = new Label();
            InstructorSalary_txtBox = new TextBox();
            btnUpdate_Click = new Button();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboInstructors
            // 
            comboInstructors.FormattingEnabled = true;
            comboInstructors.Location = new Point(619, 12);
            comboInstructors.Name = "comboInstructors";
            comboInstructors.Size = new Size(151, 28);
            comboInstructors.TabIndex = 17;
            comboInstructors.SelectedIndexChanged += comboInstructors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(541, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 18;
            label1.Text = "Instructors";
            // 
            // clear_btnClick
            // 
            clear_btnClick.Location = new Point(163, 163);
            clear_btnClick.Name = "clear_btnClick";
            clear_btnClick.Size = new Size(134, 29);
            clear_btnClick.TabIndex = 26;
            clear_btnClick.Text = "Clear";
            clear_btnClick.UseVisualStyleBackColor = true;
            clear_btnClick.Click += clear_btnClick_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 22);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 20;
            label2.Text = "Instructor ID";
            // 
            // Id_txtBox
            // 
            Id_txtBox.Enabled = false;
            Id_txtBox.Location = new Point(145, 22);
            Id_txtBox.Name = "Id_txtBox";
            Id_txtBox.Size = new Size(181, 27);
            Id_txtBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 120);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 22;
            label3.Text = "Instructor Salary";
            // 
            // InstructorName_txtBox
            // 
            InstructorName_txtBox.Location = new Point(145, 72);
            InstructorName_txtBox.Name = "InstructorName_txtBox";
            InstructorName_txtBox.Size = new Size(181, 27);
            InstructorName_txtBox.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 75);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 24;
            label5.Text = "Instructor Name";
            // 
            // InstructorSalary_txtBox
            // 
            InstructorSalary_txtBox.Location = new Point(145, 120);
            InstructorSalary_txtBox.Name = "InstructorSalary_txtBox";
            InstructorSalary_txtBox.Size = new Size(181, 27);
            InstructorSalary_txtBox.TabIndex = 25;
            // 
            // btnUpdate_Click
            // 
            btnUpdate_Click.Location = new Point(384, 262);
            btnUpdate_Click.Name = "btnUpdate_Click";
            btnUpdate_Click.Size = new Size(134, 29);
            btnUpdate_Click.TabIndex = 27;
            btnUpdate_Click.Text = "Update Instructor";
            btnUpdate_Click.UseVisualStyleBackColor = true;
            btnUpdate_Click.Click += btnUpdate_Click_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 216);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(244, 262);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 29;
            button1.Text = "Delete Instructor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnUpdate_Click);
            Controls.Add(clear_btnClick);
            Controls.Add(InstructorSalary_txtBox);
            Controls.Add(label5);
            Controls.Add(InstructorName_txtBox);
            Controls.Add(label3);
            Controls.Add(Id_txtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboInstructors);
            Name = "update";
            Text = "update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboInstructors;
        private Label label1;
        private Button clear_btnClick;
        private Label label2;
        private TextBox Id_txtBox;
        private Label label3;
        private TextBox InstructorName_txtBox;
        private Label label5;
        private TextBox InstructorSalary_txtBox;
        private Button btnUpdate_Click;
        private Label label4;
        private Button button1;
    }
}