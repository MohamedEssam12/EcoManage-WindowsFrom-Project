﻿namespace EcoManage.Gui.UsersGui
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            groupBox1 = new GroupBox();
            comboBoxRole = new ComboBox();
            textBoxPassword = new TextBox();
            label6 = new Label();
            textBoxUserName = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            textBoxFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            checkBoxSecondayUser = new CheckBox();
            comboBoxUserId = new ComboBox();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            textBoxAddress = new TextBox();
            textBoxEmail = new TextBox();
            label9 = new Label();
            textBoxPhone = new TextBox();
            label10 = new Label();
            label12 = new Label();
            groupBox3 = new GroupBox();
            flowLayoutPanelRoles = new FlowLayoutPanel();
            checkBoxAdd = new CheckBox();
            checkBoxDelete = new CheckBox();
            checkBoxEdit = new CheckBox();
            checkBoxExport = new CheckBox();
            checkBoxPrint = new CheckBox();
            checkBoxSearch = new CheckBox();
            checkBoxHomeSearch = new CheckBox();
            checkBoxHome = new CheckBox();
            checkBoxSalary = new CheckBox();
            checkBoxEmployees = new CheckBox();
            checkBoxUsers = new CheckBox();
            checkBoxReport = new CheckBox();
            checkBoxSettings = new CheckBox();
            checkBoxAbout = new CheckBox();
            checkBoxHelp = new CheckBox();
            checkBoxRetirmnet = new CheckBox();
            checkBoxSystemRecords = new CheckBox();
            label11 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanelRoles.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 498);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Info";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(27, 432);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(320, 33);
            comboBoxRole.TabIndex = 4;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(23, 320);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(324, 30);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(129, 270);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(23, 205);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(324, 30);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(129, 154);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 0;
            label4.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(28, 386);
            label7.Name = "label7";
            label7.Size = new Size(203, 25);
            label7.TabIndex = 0;
            label7.Text = "General Permissions :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 282);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 0;
            label5.Text = "Password :";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(23, 94);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(324, 30);
            textBoxFullName.TabIndex = 1;
            textBoxFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 165);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 0;
            label3.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(129, 45);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 0;
            label2.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(181, 54);
            label8.Name = "label8";
            label8.Size = new Size(153, 18);
            label8.TabIndex = 0;
            label8.Text = "At least 3 Charachters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 54);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // checkBoxSecondayUser
            // 
            checkBoxSecondayUser.AutoSize = true;
            checkBoxSecondayUser.ForeColor = Color.Black;
            checkBoxSecondayUser.Location = new Point(36, 45);
            checkBoxSecondayUser.Name = "checkBoxSecondayUser";
            checkBoxSecondayUser.Size = new Size(195, 29);
            checkBoxSecondayUser.TabIndex = 5;
            checkBoxSecondayUser.Text = "Is Secondary User";
            checkBoxSecondayUser.UseVisualStyleBackColor = true;
            checkBoxSecondayUser.CheckedChanged += checkBoxSecondayUser_CheckedChanged;
            // 
            // comboBoxUserId
            // 
            comboBoxUserId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserId.FormattingEnabled = true;
            comboBoxUserId.Location = new Point(27, 91);
            comboBoxUserId.Name = "comboBoxUserId";
            comboBoxUserId.Size = new Size(320, 33);
            comboBoxUserId.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxUserId);
            groupBox2.Controls.Add(checkBoxSecondayUser);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(textBoxAddress);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(396, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 498);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Info";
            // 
            // buttonSave
            // 
            buttonSave.ForeColor = Color.Black;
            buttonSave.Image = Properties.Resources.icons8_save_32px;
            buttonSave.ImageAlign = ContentAlignment.MiddleRight;
            buttonSave.Location = new Point(23, 432);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(319, 50);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(23, 372);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(324, 30);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(23, 282);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(324, 30);
            textBoxEmail.TabIndex = 8;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(27, 325);
            label9.Name = "label9";
            label9.Size = new Size(96, 25);
            label9.TabIndex = 0;
            label9.Text = "Address :";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(23, 187);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(324, 30);
            textBoxPhone.TabIndex = 7;
            textBoxPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(23, 240);
            label10.Name = "label10";
            label10.Size = new Size(71, 25);
            label10.TabIndex = 0;
            label10.Text = "Email :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(23, 142);
            label12.Name = "label12";
            label12.Size = new Size(75, 25);
            label12.TabIndex = 0;
            label12.Text = "Phone:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanelRoles);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 542);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(747, 156);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Permissions";
            // 
            // flowLayoutPanelRoles
            // 
            flowLayoutPanelRoles.AutoScroll = true;
            flowLayoutPanelRoles.Controls.Add(checkBoxAdd);
            flowLayoutPanelRoles.Controls.Add(checkBoxDelete);
            flowLayoutPanelRoles.Controls.Add(checkBoxEdit);
            flowLayoutPanelRoles.Controls.Add(checkBoxExport);
            flowLayoutPanelRoles.Controls.Add(checkBoxPrint);
            flowLayoutPanelRoles.Controls.Add(checkBoxSearch);
            flowLayoutPanelRoles.Controls.Add(checkBoxHomeSearch);
            flowLayoutPanelRoles.Controls.Add(checkBoxHome);
            flowLayoutPanelRoles.Controls.Add(checkBoxSalary);
            flowLayoutPanelRoles.Controls.Add(checkBoxEmployees);
            flowLayoutPanelRoles.Controls.Add(checkBoxUsers);
            flowLayoutPanelRoles.Controls.Add(checkBoxReport);
            flowLayoutPanelRoles.Controls.Add(checkBoxSettings);
            flowLayoutPanelRoles.Controls.Add(checkBoxAbout);
            flowLayoutPanelRoles.Controls.Add(checkBoxHelp);
            flowLayoutPanelRoles.Controls.Add(checkBoxRetirmnet);
            flowLayoutPanelRoles.Controls.Add(checkBoxSystemRecords);
            flowLayoutPanelRoles.Dock = DockStyle.Fill;
            flowLayoutPanelRoles.ForeColor = Color.Black;
            flowLayoutPanelRoles.Location = new Point(3, 26);
            flowLayoutPanelRoles.Name = "flowLayoutPanelRoles";
            flowLayoutPanelRoles.Padding = new Padding(3);
            flowLayoutPanelRoles.Size = new Size(741, 127);
            flowLayoutPanelRoles.TabIndex = 0;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Checked = true;
            checkBoxAdd.CheckState = CheckState.Checked;
            checkBoxAdd.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAdd.Location = new Point(6, 6);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new Size(63, 24);
            checkBoxAdd.TabIndex = 3;
            checkBoxAdd.Text = "Add";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            checkBoxDelete.AutoSize = true;
            checkBoxDelete.Checked = true;
            checkBoxDelete.CheckState = CheckState.Checked;
            checkBoxDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxDelete.Location = new Point(75, 6);
            checkBoxDelete.Name = "checkBoxDelete";
            checkBoxDelete.Size = new Size(86, 24);
            checkBoxDelete.TabIndex = 4;
            checkBoxDelete.Text = "Delete";
            checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Checked = true;
            checkBoxEdit.CheckState = CheckState.Checked;
            checkBoxEdit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEdit.Location = new Point(167, 6);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Size = new Size(64, 24);
            checkBoxEdit.TabIndex = 5;
            checkBoxEdit.Text = "Edit";
            checkBoxEdit.UseVisualStyleBackColor = true;
            // 
            // checkBoxExport
            // 
            checkBoxExport.AutoSize = true;
            checkBoxExport.Checked = true;
            checkBoxExport.CheckState = CheckState.Checked;
            checkBoxExport.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxExport.Location = new Point(237, 6);
            checkBoxExport.Name = "checkBoxExport";
            checkBoxExport.Size = new Size(85, 24);
            checkBoxExport.TabIndex = 6;
            checkBoxExport.Text = "Export";
            checkBoxExport.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrint
            // 
            checkBoxPrint.AutoSize = true;
            checkBoxPrint.Checked = true;
            checkBoxPrint.CheckState = CheckState.Checked;
            checkBoxPrint.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxPrint.Location = new Point(328, 6);
            checkBoxPrint.Name = "checkBoxPrint";
            checkBoxPrint.Size = new Size(71, 24);
            checkBoxPrint.TabIndex = 7;
            checkBoxPrint.Text = "Print";
            checkBoxPrint.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearch
            // 
            checkBoxSearch.AutoSize = true;
            checkBoxSearch.Checked = true;
            checkBoxSearch.CheckState = CheckState.Checked;
            checkBoxSearch.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSearch.Location = new Point(405, 6);
            checkBoxSearch.Name = "checkBoxSearch";
            checkBoxSearch.Size = new Size(90, 24);
            checkBoxSearch.TabIndex = 8;
            checkBoxSearch.Text = "Search";
            checkBoxSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxHomeSearch
            // 
            checkBoxHomeSearch.AutoSize = true;
            checkBoxHomeSearch.Checked = true;
            checkBoxHomeSearch.CheckState = CheckState.Checked;
            checkBoxHomeSearch.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxHomeSearch.Location = new Point(501, 6);
            checkBoxHomeSearch.Name = "checkBoxHomeSearch";
            checkBoxHomeSearch.Size = new Size(205, 24);
            checkBoxHomeSearch.TabIndex = 9;
            checkBoxHomeSearch.Text = "Search in Main Page";
            checkBoxHomeSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxHome
            // 
            checkBoxHome.AutoSize = true;
            checkBoxHome.Checked = true;
            checkBoxHome.CheckState = CheckState.Checked;
            checkBoxHome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxHome.Location = new Point(6, 36);
            checkBoxHome.Name = "checkBoxHome";
            checkBoxHome.Size = new Size(122, 24);
            checkBoxHome.TabIndex = 10;
            checkBoxHome.Text = "HomePage";
            checkBoxHome.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalary
            // 
            checkBoxSalary.AutoSize = true;
            checkBoxSalary.Checked = true;
            checkBoxSalary.CheckState = CheckState.Checked;
            checkBoxSalary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSalary.Location = new Point(134, 36);
            checkBoxSalary.Name = "checkBoxSalary";
            checkBoxSalary.Size = new Size(165, 24);
            checkBoxSalary.TabIndex = 11;
            checkBoxSalary.Text = "Salary Category";
            checkBoxSalary.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployees
            // 
            checkBoxEmployees.AutoSize = true;
            checkBoxEmployees.Checked = true;
            checkBoxEmployees.CheckState = CheckState.Checked;
            checkBoxEmployees.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEmployees.Location = new Point(305, 36);
            checkBoxEmployees.Name = "checkBoxEmployees";
            checkBoxEmployees.Size = new Size(122, 24);
            checkBoxEmployees.TabIndex = 12;
            checkBoxEmployees.Text = "Employees";
            checkBoxEmployees.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsers
            // 
            checkBoxUsers.AutoSize = true;
            checkBoxUsers.Checked = true;
            checkBoxUsers.CheckState = CheckState.Checked;
            checkBoxUsers.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxUsers.Location = new Point(433, 36);
            checkBoxUsers.Name = "checkBoxUsers";
            checkBoxUsers.Size = new Size(81, 24);
            checkBoxUsers.TabIndex = 13;
            checkBoxUsers.Text = "Users";
            checkBoxUsers.UseVisualStyleBackColor = true;
            // 
            // checkBoxReport
            // 
            checkBoxReport.AutoSize = true;
            checkBoxReport.Checked = true;
            checkBoxReport.CheckState = CheckState.Checked;
            checkBoxReport.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxReport.Location = new Point(520, 36);
            checkBoxReport.Name = "checkBoxReport";
            checkBoxReport.Size = new Size(97, 24);
            checkBoxReport.TabIndex = 14;
            checkBoxReport.Text = "Reports";
            checkBoxReport.UseVisualStyleBackColor = true;
            // 
            // checkBoxSettings
            // 
            checkBoxSettings.AutoSize = true;
            checkBoxSettings.Checked = true;
            checkBoxSettings.CheckState = CheckState.Checked;
            checkBoxSettings.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSettings.Location = new Point(623, 36);
            checkBoxSettings.Name = "checkBoxSettings";
            checkBoxSettings.Size = new Size(100, 24);
            checkBoxSettings.TabIndex = 15;
            checkBoxSettings.Text = "Settings";
            checkBoxSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbout
            // 
            checkBoxAbout.AutoSize = true;
            checkBoxAbout.Checked = true;
            checkBoxAbout.CheckState = CheckState.Checked;
            checkBoxAbout.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAbout.Location = new Point(6, 66);
            checkBoxAbout.Name = "checkBoxAbout";
            checkBoxAbout.Size = new Size(79, 24);
            checkBoxAbout.TabIndex = 16;
            checkBoxAbout.Text = "About";
            checkBoxAbout.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxAbout.UseVisualStyleBackColor = true;
            // 
            // checkBoxHelp
            // 
            checkBoxHelp.AutoSize = true;
            checkBoxHelp.Checked = true;
            checkBoxHelp.CheckState = CheckState.Checked;
            checkBoxHelp.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxHelp.Location = new Point(91, 66);
            checkBoxHelp.Name = "checkBoxHelp";
            checkBoxHelp.Size = new Size(70, 24);
            checkBoxHelp.TabIndex = 17;
            checkBoxHelp.Text = "Help";
            checkBoxHelp.UseVisualStyleBackColor = true;
            // 
            // checkBoxRetirmnet
            // 
            checkBoxRetirmnet.AutoSize = true;
            checkBoxRetirmnet.Checked = true;
            checkBoxRetirmnet.CheckState = CheckState.Checked;
            checkBoxRetirmnet.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxRetirmnet.Location = new Point(167, 66);
            checkBoxRetirmnet.Name = "checkBoxRetirmnet";
            checkBoxRetirmnet.Size = new Size(189, 24);
            checkBoxRetirmnet.TabIndex = 18;
            checkBoxRetirmnet.Text = "Retired Employees";
            checkBoxRetirmnet.UseVisualStyleBackColor = true;
            // 
            // checkBoxSystemRecords
            // 
            checkBoxSystemRecords.AutoSize = true;
            checkBoxSystemRecords.Checked = true;
            checkBoxSystemRecords.CheckState = CheckState.Checked;
            checkBoxSystemRecords.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxSystemRecords.Location = new Point(362, 66);
            checkBoxSystemRecords.Name = "checkBoxSystemRecords";
            checkBoxSystemRecords.Size = new Size(163, 24);
            checkBoxSystemRecords.TabIndex = 19;
            checkBoxSystemRecords.Text = "SystemRecords";
            checkBoxSystemRecords.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(181, 170);
            label11.Name = "label11";
            label11.Size = new Size(153, 18);
            label11.TabIndex = 5;
            label11.Text = "At least 3 Charachters";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F);
            label13.ForeColor = Color.Silver;
            label13.Location = new Point(181, 287);
            label13.Name = "label13";
            label13.Size = new Size(153, 18);
            label13.TabIndex = 6;
            label13.Text = "At least 3 Charachters";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 710);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit User";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanelRoles.ResumeLayout(false);
            flowLayoutPanelRoles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private Label label6;
        private TextBox textBoxUserName;
        private Label label4;
        private Label label5;
        private TextBox textBoxFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxUserId;
        private CheckBox checkBoxSecondayUser;
        private GroupBox groupBox2;
        private TextBox textBoxAddress;
        private TextBox textBoxEmail;
        private Label label9;
        private TextBox textBoxPhone;
        private Label label10;
        private Label label12;
        private GroupBox groupBox3;
        private Button buttonSave;
        private FlowLayoutPanel flowLayoutPanelRoles;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxDelete;
        private CheckBox checkBoxEdit;
        private CheckBox checkBoxExport;
        private CheckBox checkBoxPrint;
        private CheckBox checkBoxSearch;
        private CheckBox checkBoxHomeSearch;
        private CheckBox checkBoxHome;
        private CheckBox checkBoxSalary;
        private CheckBox checkBoxEmployees;
        private ComboBox comboBoxRole;
        private Label label7;
        private CheckBox checkBoxUsers;
        private CheckBox checkBoxReport;
        private CheckBox checkBoxSettings;
        private CheckBox checkBoxAbout;
        private CheckBox checkBoxHelp;
        private CheckBox checkBoxRetirmnet;
        private CheckBox checkBoxSystemRecords;
        private Label label8;
        private Label label13;
        private Label label11;
    }
}