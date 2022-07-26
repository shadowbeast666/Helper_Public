namespace Project_Windows
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currenttextBox = new System.Windows.Forms.TextBox();
            this.newtextBox = new System.Windows.Forms.TextBox();
            this.confirmtextBox = new System.Windows.Forms.TextBox();
            this.errorlabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.confirnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(270, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change Password";
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(419, 429);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 46);
            this.button9.TabIndex = 15;
            this.button9.Text = "Submit";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current password :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "New password :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(13, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm new password :";
            // 
            // currenttextBox
            // 
            this.currenttextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.currenttextBox.Location = new System.Drawing.Point(299, 140);
            this.currenttextBox.Name = "currenttextBox";
            this.currenttextBox.Size = new System.Drawing.Size(295, 23);
            this.currenttextBox.TabIndex = 19;
            this.currenttextBox.TextChanged += new System.EventHandler(this.currenttextBox_TextChanged);
            // 
            // newtextBox
            // 
            this.newtextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.newtextBox.Location = new System.Drawing.Point(299, 230);
            this.newtextBox.Name = "newtextBox";
            this.newtextBox.Size = new System.Drawing.Size(295, 23);
            this.newtextBox.TabIndex = 20;
            // 
            // confirmtextBox
            // 
            this.confirmtextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.confirmtextBox.Location = new System.Drawing.Point(299, 324);
            this.confirmtextBox.Name = "confirmtextBox";
            this.confirmtextBox.Size = new System.Drawing.Size(295, 23);
            this.confirmtextBox.TabIndex = 21;
            // 
            // errorlabel
            // 
            this.errorlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(26, 446);
            this.errorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(19, 29);
            this.errorlabel.TabIndex = 22;
            this.errorlabel.Text = " ";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.ForeColor = System.Drawing.Color.Red;
            this.currentLabel.Location = new System.Drawing.Point(610, 148);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(0, 15);
            this.currentLabel.TabIndex = 23;
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.ForeColor = System.Drawing.Color.Red;
            this.newLabel.Location = new System.Drawing.Point(610, 238);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(0, 15);
            this.newLabel.TabIndex = 24;
            // 
            // confirnLabel
            // 
            this.confirnLabel.AutoSize = true;
            this.confirnLabel.ForeColor = System.Drawing.Color.Red;
            this.confirnLabel.Location = new System.Drawing.Point(610, 332);
            this.confirnLabel.Name = "confirnLabel";
            this.confirnLabel.Size = new System.Drawing.Size(0, 15);
            this.confirnLabel.TabIndex = 25;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(798, 497);
            this.Controls.Add(this.confirnLabel);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.confirmtextBox);
            this.Controls.Add(this.newtextBox);
            this.Controls.Add(this.currenttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChangePassword";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox currenttextBox;
        private TextBox newtextBox;
        private TextBox confirmtextBox;
        private Label errorlabel;
        private Label currentLabel;
        private Label newLabel;
        private Label confirnLabel;
    }
}