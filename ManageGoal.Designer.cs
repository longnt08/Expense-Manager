namespace ExpenseManager {
    partial class ManageGoal {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewGoals = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createGoalBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimePickerDeadline = new System.Windows.Forms.TextBox();
            this.txtTargetAmout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxFilterGoals = new System.Windows.Forms.ComboBox();
            this.filterGoalsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.filterGoalsBtn);
            this.panel1.Controls.Add(this.comboBoxFilterGoals);
            this.panel1.Controls.Add(this.dataGridViewGoals);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.BurlyWood;
            this.panel1.Location = new System.Drawing.Point(30, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 268);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewGoals
            // 
            this.dataGridViewGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoals.Location = new System.Drawing.Point(21, 56);
            this.dataGridViewGoals.Name = "dataGridViewGoals";
            this.dataGridViewGoals.Size = new System.Drawing.Size(787, 192);
            this.dataGridViewGoals.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your\'s goals";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.createGoalBtn);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.datetimePickerDeadline);
            this.panel2.Controls.Add(this.txtTargetAmout);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.BurlyWood;
            this.panel2.Location = new System.Drawing.Point(30, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 247);
            this.panel2.TabIndex = 1;
            // 
            // createGoalBtn
            // 
            this.createGoalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.createGoalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createGoalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.createGoalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.createGoalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGoalBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGoalBtn.ForeColor = System.Drawing.Color.White;
            this.createGoalBtn.Location = new System.Drawing.Point(401, 195);
            this.createGoalBtn.Name = "createGoalBtn";
            this.createGoalBtn.Size = new System.Drawing.Size(89, 36);
            this.createGoalBtn.TabIndex = 10;
            this.createGoalBtn.Text = "Create";
            this.createGoalBtn.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Deadline";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 71);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Add new goal";
            // 
            // datetimePickerDeadline
            // 
            this.datetimePickerDeadline.Location = new System.Drawing.Point(131, 163);
            this.datetimePickerDeadline.Multiline = true;
            this.datetimePickerDeadline.Name = "datetimePickerDeadline";
            this.datetimePickerDeadline.Size = new System.Drawing.Size(199, 20);
            this.datetimePickerDeadline.TabIndex = 5;
            // 
            // txtTargetAmout
            // 
            this.txtTargetAmout.Location = new System.Drawing.Point(131, 115);
            this.txtTargetAmout.Multiline = true;
            this.txtTargetAmout.Name = "txtTargetAmout";
            this.txtTargetAmout.Size = new System.Drawing.Size(199, 20);
            this.txtTargetAmout.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saved amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Target amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxFilterGoals
            // 
            this.comboBoxFilterGoals.FormattingEnabled = true;
            this.comboBoxFilterGoals.Items.AddRange(new object[] {
            "In progress",
            "Completed"});
            this.comboBoxFilterGoals.Location = new System.Drawing.Point(597, 17);
            this.comboBoxFilterGoals.Name = "comboBoxFilterGoals";
            this.comboBoxFilterGoals.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterGoals.TabIndex = 2;
            // 
            // filterGoalsBtn
            // 
            this.filterGoalsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterGoalsBtn.ForeColor = System.Drawing.Color.Black;
            this.filterGoalsBtn.Location = new System.Drawing.Point(733, 17);
            this.filterGoalsBtn.Name = "filterGoalsBtn";
            this.filterGoalsBtn.Size = new System.Drawing.Size(75, 23);
            this.filterGoalsBtn.TabIndex = 3;
            this.filterGoalsBtn.Text = "Filter";
            this.filterGoalsBtn.UseVisualStyleBackColor = true;
            // 
            // ManageGoal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageGoal";
            this.Size = new System.Drawing.Size(875, 557);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewGoals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox datetimePickerDeadline;
        private System.Windows.Forms.TextBox txtTargetAmout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createGoalBtn;
        private System.Windows.Forms.Button filterGoalsBtn;
        private System.Windows.Forms.ComboBox comboBoxFilterGoals;
    }
}
