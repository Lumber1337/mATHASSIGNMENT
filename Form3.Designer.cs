namespace mATHASSIGNMENT
{
    partial class Form3
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
            this.usersName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOption5 = new System.Windows.Forms.RadioButton();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersName
            // 
            this.usersName.AutoSize = true;
            this.usersName.BackColor = System.Drawing.Color.Transparent;
            this.usersName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersName.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersName.ForeColor = System.Drawing.Color.Yellow;
            this.usersName.Location = new System.Drawing.Point(310, 9);
            this.usersName.Name = "usersName";
            this.usersName.Size = new System.Drawing.Size(195, 35);
            this.usersName.TabIndex = 1;
            this.usersName.Text = "Users Name";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(274, 136);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(164, 36);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(147, 23);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Question One";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(168, 117);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 48);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(22, 36);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(110, 21);
            this.rbOption1.TabIndex = 5;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "radioButton1";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(22, 63);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(110, 21);
            this.rbOption2.TabIndex = 6;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "radioButton2";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(665, 63);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(110, 21);
            this.rbOption3.TabIndex = 6;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "radioButton2";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(22, 117);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(110, 21);
            this.rbOption4.TabIndex = 7;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "radioButton4";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(527, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAnswer);
            this.groupBox1.Controls.Add(this.rbOption5);
            this.groupBox1.Controls.Add(this.rbOption1);
            this.groupBox1.Controls.Add(this.rbOption2);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.rbOption4);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Controls.Add(this.rbOption3);
            this.groupBox1.Location = new System.Drawing.Point(392, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 182);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbOption5
            // 
            this.rbOption5.AutoSize = true;
            this.rbOption5.Location = new System.Drawing.Point(22, 90);
            this.rbOption5.Name = "rbOption5";
            this.rbOption5.Size = new System.Drawing.Size(110, 21);
            this.rbOption5.TabIndex = 8;
            this.rbOption5.TabStop = true;
            this.rbOption5.Text = "radioButton2";
            this.rbOption5.UseVisualStyleBackColor = true;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(168, 94);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(68, 17);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.Text = "lblAnswer";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mATHASSIGNMENT.Properties.Resources.realistic_math_chalkboard_background_23_2148154055;
            this.ClientSize = new System.Drawing.Size(1172, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usersName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOption5;
        private System.Windows.Forms.Label lblAnswer;
    }
}