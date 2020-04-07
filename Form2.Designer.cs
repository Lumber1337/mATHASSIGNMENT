namespace mATHASSIGNMENT
{
    partial class Form2
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
            this.lvl1button = new System.Windows.Forms.Button();
            this.lvl2button = new System.Windows.Forms.Button();
            this.lvl3button = new System.Windows.Forms.Button();
            this.usersName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(220, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a level:";
            // 
            // lvl1button
            // 
            this.lvl1button.Location = new System.Drawing.Point(122, 337);
            this.lvl1button.Name = "lvl1button";
            this.lvl1button.Size = new System.Drawing.Size(117, 71);
            this.lvl1button.TabIndex = 3;
            this.lvl1button.Text = "Level 1";
            this.lvl1button.UseVisualStyleBackColor = true;
            this.lvl1button.Click += new System.EventHandler(this.lvl1button_Click);
            // 
            // lvl2button
            // 
            this.lvl2button.Location = new System.Drawing.Point(300, 337);
            this.lvl2button.Name = "lvl2button";
            this.lvl2button.Size = new System.Drawing.Size(117, 71);
            this.lvl2button.TabIndex = 4;
            this.lvl2button.Text = "Level 2";
            this.lvl2button.UseVisualStyleBackColor = true;
            // 
            // lvl3button
            // 
            this.lvl3button.Location = new System.Drawing.Point(483, 337);
            this.lvl3button.Name = "lvl3button";
            this.lvl3button.Size = new System.Drawing.Size(117, 71);
            this.lvl3button.TabIndex = 5;
            this.lvl3button.Text = "Level 3";
            this.lvl3button.UseVisualStyleBackColor = true;
            // 
            // usersName
            // 
            this.usersName.AutoSize = true;
            this.usersName.BackColor = System.Drawing.Color.Transparent;
            this.usersName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersName.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.usersName.ForeColor = System.Drawing.Color.Yellow;
            this.usersName.Location = new System.Drawing.Point(12, 32);
            this.usersName.Name = "usersName";
            this.usersName.Size = new System.Drawing.Size(131, 23);
            this.usersName.TabIndex = 6;
            this.usersName.Text = "Users Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mATHASSIGNMENT.Properties.Resources.realistic_math_chalkboard_background_23_2148154055;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersName);
            this.Controls.Add(this.lvl3button);
            this.Controls.Add(this.lvl2button);
            this.Controls.Add(this.lvl1button);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lvl1button;
        private System.Windows.Forms.Button lvl2button;
        private System.Windows.Forms.Button lvl3button;
        private System.Windows.Forms.Label usersName;
    }
}