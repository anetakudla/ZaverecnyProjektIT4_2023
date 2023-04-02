namespace ZaverecnyProjektIT4_2023
{
    partial class UserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearchWorks = new System.Windows.Forms.TextBox();
            this.listViewWorks = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAddContract = new System.Windows.Forms.Button();
            this.buttonDeleteContract = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearchContacts = new System.Windows.Forms.TextBox();
            this.listViewContracts = new System.Windows.Forms.ListView();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxSearchEmployee);
            this.panel2.Controls.Add(this.listViewEmployees);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 426);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vyhledávání:";
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(511, 43);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(105, 23);
            this.textBoxSearchEmployee.TabIndex = 3;
            this.textBoxSearchEmployee.TextChanged += new System.EventHandler(this.textBoxSearchEmployee_TextChanged_1);
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.Location = new System.Drawing.Point(0, 24);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(505, 402);
            this.listViewEmployees.TabIndex = 2;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EmployeeId";
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 3;
            this.columnHeader7.Text = "Job";
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 1;
            this.columnHeader5.Text = "Firstname";
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 2;
            this.columnHeader6.Text = "Lastname";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Birthdate";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Email";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Zaměstnanci";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxSearchWorks);
            this.panel3.Controls.Add(this.listViewWorks);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(649, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 426);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vyhledávání:";
            // 
            // textBoxSearchWorks
            // 
            this.textBoxSearchWorks.Location = new System.Drawing.Point(188, 43);
            this.textBoxSearchWorks.Name = "textBoxSearchWorks";
            this.textBoxSearchWorks.Size = new System.Drawing.Size(105, 23);
            this.textBoxSearchWorks.TabIndex = 3;
            this.textBoxSearchWorks.TextChanged += new System.EventHandler(this.textBoxSearchWorks_TextChanged_1);
            // 
            // listViewWorks
            // 
            this.listViewWorks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewWorks.FullRowSelect = true;
            this.listViewWorks.GridLines = true;
            this.listViewWorks.Location = new System.Drawing.Point(0, 24);
            this.listViewWorks.Name = "listViewWorks";
            this.listViewWorks.Size = new System.Drawing.Size(182, 399);
            this.listViewWorks.TabIndex = 2;
            this.listViewWorks.UseCompatibleStateImageBehavior = false;
            this.listViewWorks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "WorkId";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Name";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Práce";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.buttonAddContract);
            this.panel4.Controls.Add(this.buttonDeleteContract);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxSearchContacts);
            this.panel4.Controls.Add(this.listViewContracts);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(12, 444);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 297);
            this.panel4.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(706, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "(podle Customer)";
            // 
            // buttonAddContract
            // 
            this.buttonAddContract.Location = new System.Drawing.Point(739, 243);
            this.buttonAddContract.Name = "buttonAddContract";
            this.buttonAddContract.Size = new System.Drawing.Size(75, 23);
            this.buttonAddContract.TabIndex = 7;
            this.buttonAddContract.Text = "Přidat";
            this.buttonAddContract.UseVisualStyleBackColor = true;
            this.buttonAddContract.Click += new System.EventHandler(this.buttonAddContract_Click_1);
            // 
            // buttonDeleteContract
            // 
            this.buttonDeleteContract.Location = new System.Drawing.Point(739, 272);
            this.buttonDeleteContract.Name = "buttonDeleteContract";
            this.buttonDeleteContract.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteContract.TabIndex = 5;
            this.buttonDeleteContract.Text = "Smazat";
            this.buttonDeleteContract.UseVisualStyleBackColor = true;
            this.buttonDeleteContract.Click += new System.EventHandler(this.buttonDeleteContract_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Vyhledávání:";
            // 
            // textBoxSearchContacts
            // 
            this.textBoxSearchContacts.Location = new System.Drawing.Point(706, 40);
            this.textBoxSearchContacts.Name = "textBoxSearchContacts";
            this.textBoxSearchContacts.Size = new System.Drawing.Size(105, 23);
            this.textBoxSearchContacts.TabIndex = 3;
            this.textBoxSearchContacts.TextChanged += new System.EventHandler(this.textBoxSearchContacts_TextChanged_1);
            // 
            // listViewContracts
            // 
            this.listViewContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listViewContracts.FullRowSelect = true;
            this.listViewContracts.GridLines = true;
            this.listViewContracts.Location = new System.Drawing.Point(0, 27);
            this.listViewContracts.Name = "listViewContracts";
            this.listViewContracts.Size = new System.Drawing.Size(700, 270);
            this.listViewContracts.TabIndex = 2;
            this.listViewContracts.UseCompatibleStateImageBehavior = false;
            this.listViewContracts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "ContractId";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Work";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Employee";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "CustomerName";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Date";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Zakázky";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.buttonLogout);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(832, 444);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 297);
            this.panel5.TabIndex = 12;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(43, 271);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Odhlásit se";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Uživatel";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 753);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label3;
        private TextBox textBoxSearchEmployee;
        private ListView listViewEmployees;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private TextBox textBoxSearchWorks;
        private ListView listViewWorks;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Label label6;
        private Panel panel4;
        private Label label11;
        private Label label7;
        private TextBox textBoxSearchContacts;
        private ListView listViewContracts;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private Label label8;
        private Button buttonAddContract;
        private Button buttonDeleteContract;
        private Panel panel5;
        private Button buttonLogout;
        private Label label10;
        private Label label9;
    }
}