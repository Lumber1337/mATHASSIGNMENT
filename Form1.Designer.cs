namespace mATHASSIGNMENT
{
    partial class Form1
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
            this.usernameTxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.AutoCompleteCustomSource.AddRange(new string[] {
            "What\'s your name?"});
            this.usernameTxtbox.BackColor = System.Drawing.Color.DimGray;
            this.usernameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.usernameTxtbox.ForeColor = System.Drawing.Color.FloralWhite;
            this.usernameTxtbox.Location = new System.Drawing.Point(183, 304);
            this.usernameTxtbox.MaxLength = 20;
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(412, 41);
            this.usernameTxtbox.TabIndex = 2;
            this.usernameTxtbox.Text = "Enter your name here..";
            this.usernameTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImage = global::mATHASSIGNMENT.Properties.Resources.kisspng_feather_snowflake_5a6bb4802529c0_0877122715170080001522;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(183, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(412, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mATHASSIGNMENT.Properties.Resources.skylinegif;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameTxtbox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTxtbox;
        private System.Windows.Forms.Button button1;
    }
}

