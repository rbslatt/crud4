namespace ACT1E_CRUD
{
    partial class Admin
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
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txtName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            txtPassword = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            cbRole = new ComboBox();
            txtSearch = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(415, 373);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(25, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(222, 23);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 2;
            label1.Text = "#";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(25, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 46;
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 23);
            txtName.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(25, 78);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 48;
            label2.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(25, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 49;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Maroon;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(548, 29);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(226, 54);
            btnLogout.TabIndex = 51;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(319, 33);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 52;
            label3.Text = "Welcome,";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(25, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(222, 23);
            txtUsername.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(25, 131);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 54;
            label4.Text = "Username";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(25, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 55;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(222, 23);
            txtPassword.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(25, 191);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 57;
            label5.Text = "Password";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(25, 230);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 2);
            panel4.TabIndex = 58;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 2);
            panel5.TabIndex = 56;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Location = new Point(25, 283);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 2);
            panel6.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(25, 244);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 61;
            label6.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(12, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(226, 59);
            btnAdd.TabIndex = 62;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(12, 424);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 59);
            btnUpdate.TabIndex = 63;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Maroon;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(12, 503);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(226, 54);
            btnRemove.TabIndex = 64;
            btnRemove.Text = "Remove Account";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(25, 259);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(225, 23);
            cbRole.TabIndex = 65;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(309, 115);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(305, 23);
            txtSearch.TabIndex = 66;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.HotTrack;
            panel7.Location = new Point(389, 136);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 2);
            panel7.TabIndex = 67;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.HotTrack;
            panel8.Location = new Point(309, 136);
            panel8.Name = "panel8";
            panel8.Size = new Size(225, 2);
            panel8.TabIndex = 56;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(620, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 23);
            btnSearch.TabIndex = 68;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(btnSearch);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(txtSearch);
            Controls.Add(cbRole);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(btnLogout);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtID;
        private Label label1;
        private Panel panel1;
        private TextBox txtName;
        private Label label2;
        private Panel panel2;
        private Button btnLogout;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label5;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private ComboBox cbRole;
        private TextBox txtSearch;
        private Panel panel7;
        private Panel panel8;
        private Button btnSearch;
    }
}