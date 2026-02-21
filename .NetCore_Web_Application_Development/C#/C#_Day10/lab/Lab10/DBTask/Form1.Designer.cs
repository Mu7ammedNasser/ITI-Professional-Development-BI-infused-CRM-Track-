namespace DBTask
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
            dataGridInstructors = new DataGridView();
            comboInstructors = new ComboBox();
            label1 = new Label();
            allIns_click = new Button();
            ins_click = new Button();
            label2 = new Label();
            Id_txtBox = new TextBox();
            InstructorName_txtBox = new TextBox();
            label3 = new Label();
            btnIns_Click = new Button();
            InstructorSalary_txtBox = new TextBox();
            label5 = new Label();
            clear_btnClick = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).BeginInit();
            SuspendLayout();
            // 
            // dataGridInstructors
            // 
            dataGridInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInstructors.Dock = DockStyle.Bottom;
            dataGridInstructors.Location = new Point(0, 316);
            dataGridInstructors.Name = "dataGridInstructors";
            dataGridInstructors.RowHeadersWidth = 51;
            dataGridInstructors.Size = new Size(861, 196);
            dataGridInstructors.TabIndex = 0;
            // 
            // comboInstructors
            // 
            comboInstructors.FormattingEnabled = true;
            comboInstructors.Location = new Point(90, 25);
            comboInstructors.Name = "comboInstructors";
            comboInstructors.Size = new Size(151, 28);
            comboInstructors.TabIndex = 1;
            comboInstructors.SelectedIndexChanged += comboInstructors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Instructors";
            // 
            // allIns_click
            // 
            allIns_click.Location = new Point(302, 25);
            allIns_click.Name = "allIns_click";
            allIns_click.Size = new Size(163, 29);
            allIns_click.TabIndex = 3;
            allIns_click.Text = "All Instructors Topics";
            allIns_click.UseVisualStyleBackColor = true;
            allIns_click.Click += allIns_click_Click;
            // 
            // ins_click
            // 
            ins_click.Location = new Point(582, 24);
            ins_click.Name = "ins_click";
            ins_click.Size = new Size(146, 29);
            ins_click.TabIndex = 4;
            ins_click.Text = "Display Instructors";
            ins_click.UseVisualStyleBackColor = true;
            ins_click.Click += ins_click_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 100);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Instructor ID";
            // 
            // Id_txtBox
            // 
            Id_txtBox.Location = new Point(169, 100);
            Id_txtBox.Name = "Id_txtBox";
            Id_txtBox.Size = new Size(181, 27);
            Id_txtBox.TabIndex = 6;
            // 
            // InstructorName_txtBox
            // 
            InstructorName_txtBox.Location = new Point(169, 150);
            InstructorName_txtBox.Name = "InstructorName_txtBox";
            InstructorName_txtBox.Size = new Size(181, 27);
            InstructorName_txtBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 198);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 7;
            label3.Text = "Instructor Salary";
            // 
            // btnIns_Click
            // 
            btnIns_Click.Location = new Point(371, 100);
            btnIns_Click.Name = "btnIns_Click";
            btnIns_Click.Size = new Size(127, 29);
            btnIns_Click.TabIndex = 9;
            btnIns_Click.Text = "Insert Instructor";
            btnIns_Click.UseVisualStyleBackColor = true;
            btnIns_Click.Click += btnIns_Click_Click;
            // 
            // InstructorSalary_txtBox
            // 
            InstructorSalary_txtBox.Location = new Point(169, 198);
            InstructorSalary_txtBox.Name = "InstructorSalary_txtBox";
            InstructorSalary_txtBox.Size = new Size(181, 27);
            InstructorSalary_txtBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 153);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 14;
            label5.Text = "Instructor Name";
            // 
            // clear_btnClick
            // 
            clear_btnClick.Location = new Point(187, 243);
            clear_btnClick.Name = "clear_btnClick";
            clear_btnClick.Size = new Size(134, 29);
            clear_btnClick.TabIndex = 16;
            clear_btnClick.Text = "Clear";
            clear_btnClick.UseVisualStyleBackColor = true;
            clear_btnClick.Click += clear_btnClick_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(712, 264);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 512);
            Controls.Add(label4);
            Controls.Add(clear_btnClick);
            Controls.Add(InstructorSalary_txtBox);
            Controls.Add(label5);
            Controls.Add(btnIns_Click);
            Controls.Add(InstructorName_txtBox);
            Controls.Add(label3);
            Controls.Add(Id_txtBox);
            Controls.Add(label2);
            Controls.Add(ins_click);
            Controls.Add(allIns_click);
            Controls.Add(label1);
            Controls.Add(comboInstructors);
            Controls.Add(dataGridInstructors);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridInstructors;
        private ComboBox comboInstructors;
        private Label label1;
        private Button allIns_click;
        private Button ins_click;
        private Label label2;
        private TextBox Id_txtBox;
        private TextBox InstructorName_txtBox;
        private Label label3;
        private Button btnIns_Click;
        private TextBox InstructorSalary_txtBox;
        private Label label5;
        private Button clear_btnClick;
        private Label label4;
    }
}
