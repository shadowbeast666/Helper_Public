namespace Project_Windows
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.databaseGeneratedAttributeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersFoundListBox = new System.Windows.Forms.ListBox();
            this.modifybutton = new System.Windows.Forms.Button();
            this.getuserbutton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.roletextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGeneratedAttributeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            this.databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            // 
            // usersFoundListBox
            // 
            this.usersFoundListBox.BackColor = System.Drawing.Color.LightGray;
            this.usersFoundListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersFoundListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usersFoundListBox.FormattingEnabled = true;
            this.usersFoundListBox.ItemHeight = 25;
            this.usersFoundListBox.Location = new System.Drawing.Point(12, 23);
            this.usersFoundListBox.Name = "usersFoundListBox";
            this.usersFoundListBox.Size = new System.Drawing.Size(732, 154);
            this.usersFoundListBox.TabIndex = 0;
            // 
            // modifybutton
            // 
            this.modifybutton.BackColor = System.Drawing.Color.Crimson;
            this.modifybutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifybutton.Location = new System.Drawing.Point(629, 531);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(108, 60);
            this.modifybutton.TabIndex = 1;
            this.modifybutton.Text = "Modify";
            this.modifybutton.UseVisualStyleBackColor = false;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // getuserbutton
            // 
            this.getuserbutton.Location = new System.Drawing.Point(662, 230);
            this.getuserbutton.Name = "getuserbutton";
            this.getuserbutton.Size = new System.Drawing.Size(75, 23);
            this.getuserbutton.TabIndex = 2;
            this.getuserbutton.Text = "Select User";
            this.getuserbutton.UseVisualStyleBackColor = true;
            this.getuserbutton.Click += new System.EventHandler(this.getuserbutton_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.ForeColor = System.Drawing.Color.Crimson;
            this.id.Location = new System.Drawing.Point(12, 284);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(40, 37);
            this.id.TabIndex = 3;
            this.id.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(12, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(12, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(194, 298);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.ReadOnly = true;
            this.idtextBox.Size = new System.Drawing.Size(28, 23);
            this.idtextBox.TabIndex = 8;
            // 
            // logintextBox
            // 
            this.logintextBox.Location = new System.Drawing.Point(194, 368);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(230, 23);
            this.logintextBox.TabIndex = 9;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(194, 436);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(230, 23);
            this.passwordtextBox.TabIndex = 10;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(194, 502);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(230, 23);
            this.emailtextBox.TabIndex = 11;
            // 
            // roletextBox
            // 
            this.roletextBox.Location = new System.Drawing.Point(194, 569);
            this.roletextBox.Name = "roletextBox";
            this.roletextBox.Size = new System.Drawing.Size(230, 23);
            this.roletextBox.TabIndex = 12;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(756, 625);
            this.ControlBox = false;
            this.Controls.Add(this.roletextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.logintextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.getuserbutton);
            this.Controls.Add(this.modifybutton);
            this.Controls.Add(this.usersFoundListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseGeneratedAttributeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource databaseGeneratedAttributeBindingSource;
        private ListBox usersFoundListBox;
        private Button modifybutton;
        private Button getuserbutton;
        private Label id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idtextBox;
        private TextBox logintextBox;
        private TextBox passwordtextBox;
        private TextBox emailtextBox;
        private TextBox roletextBox;
    }
}