
namespace EmployeesRecord
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
            panel1 = new Panel();
            UpdateData_Btn = new Button();
            DateOfBirthPicker = new DateTimePicker();
            label7 = new Label();
            RegisterBtn = new Button();
            PhoneNumberBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            OccupationBox = new TextBox();
            label4 = new Label();
            EmailBox = new TextBox();
            label3 = new Label();
            LastNameBox = new TextBox();
            label2 = new Label();
            FirstNameBox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            DeleteBtn = new Button();
            EditBtn = new Button();
            employeeTable = new DataGridView();
            button2 = new Button();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(UpdateData_Btn);
            panel1.Controls.Add(DateOfBirthPicker);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(RegisterBtn);
            panel1.Controls.Add(PhoneNumberBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(OccupationBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EmailBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LastNameBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(FirstNameBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 611);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // UpdateData_Btn
            // 
            UpdateData_Btn.BackColor = Color.Fuchsia;
            UpdateData_Btn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateData_Btn.ForeColor = SystemColors.ActiveCaptionText;
            UpdateData_Btn.Location = new Point(67, 543);
            UpdateData_Btn.Name = "UpdateData_Btn";
            UpdateData_Btn.Size = new Size(400, 50);
            UpdateData_Btn.TabIndex = 15;
            UpdateData_Btn.Text = "Update Data";
            UpdateData_Btn.UseVisualStyleBackColor = false;
            UpdateData_Btn.Click += button1_Click;
            // 
            // DateOfBirthPicker
            // 
            DateOfBirthPicker.CustomFormat = "MM-dd-yyyy";
            DateOfBirthPicker.Format = DateTimePickerFormat.Custom;
            DateOfBirthPicker.Location = new Point(138, 421);
            DateOfBirthPicker.Name = "DateOfBirthPicker";
            DateOfBirthPicker.Size = new Size(286, 27);
            DateOfBirthPicker.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(11, 32);
            label7.Name = "label7";
            label7.Size = new Size(533, 79);
            label7.TabIndex = 13;
            label7.Text = "Employee Registration";
            label7.Click += label7_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(0, 192, 0);
            RegisterBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.ForeColor = SystemColors.ActiveCaptionText;
            RegisterBtn.Location = new Point(67, 487);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(400, 50);
            RegisterBtn.TabIndex = 12;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(138, 370);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(286, 27);
            PhoneNumberBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 373);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 10;
            label6.Text = "Phone Number";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 421);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 8;
            label5.Text = "Date Of Birth";
            label5.Click += label5_Click;
            // 
            // OccupationBox
            // 
            OccupationBox.Location = new Point(138, 322);
            OccupationBox.Name = "OccupationBox";
            OccupationBox.Size = new Size(286, 27);
            OccupationBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 325);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 6;
            label4.Text = "Occupation";
            label4.Click += label4_Click;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(138, 277);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(286, 27);
            EmailBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(77, 280);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(138, 228);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(286, 27);
            LastNameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 231);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(138, 182);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(286, 27);
            FirstNameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 182);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(employeeTable);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox5);
            panel2.Location = new Point(557, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 611);
            panel2.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(417, 522);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(395, 59);
            DeleteBtn.TabIndex = 16;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.HotTrack;
            EditBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.Location = new Point(13, 522);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(398, 59);
            EditBtn.TabIndex = 15;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // employeeTable
            // 
            employeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeTable.Location = new Point(13, 90);
            employeeTable.Name = "employeeTable";
            employeeTable.RowHeadersWidth = 51;
            employeeTable.RowTemplate.Height = 29;
            employeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeTable.Size = new Size(801, 426);
            employeeTable.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(638, 32);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 13;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(13, 40);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(619, 27);
            textBox5.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1383, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Employees Record";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeTable).EndInit();
            ResumeLayout(false);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox FirstNameBox;
        private Label label5;
        private TextBox OccupationBox;
        private Label label4;
        private TextBox EmailBox;
        private Label label3;
        private TextBox LastNameBox;
        private Label label2;
        private TextBox PhoneNumberBox;
        private Label label6;
        private Button RegisterBtn;
        private Label label7;
        private DateTimePicker DateOfBirthPicker;
        private Button button2;
        private TextBox textBox5;
        private DataGridView employeeTable;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button UpdateData_Btn;
    }
}
