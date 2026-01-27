namespace _1_Hello
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
            this.HelloBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GreetLabel = new System.Windows.Forms.Label();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HelloBtn
            // 
            this.HelloBtn.Enabled = false;
            this.HelloBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelloBtn.Location = new System.Drawing.Point(431, 46);
            this.HelloBtn.Name = "HelloBtn";
            this.HelloBtn.Size = new System.Drawing.Size(218, 83);
            this.HelloBtn.TabIndex = 0;
            this.HelloBtn.Text = "Hello!";
            this.HelloBtn.UseVisualStyleBackColor = true;
            this.HelloBtn.Click += new System.EventHandler(this.HelloBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.Location = new System.Drawing.Point(181, 46);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(190, 29);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.Location = new System.Drawing.Point(97, 46);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 29);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Név:";
            // 
            // GreetLabel
            // 
            this.GreetLabel.AutoSize = true;
            this.GreetLabel.BackColor = System.Drawing.Color.Transparent;
            this.GreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreetLabel.Location = new System.Drawing.Point(426, 164);
            this.GreetLabel.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.GreetLabel.Name = "GreetLabel";
            this.GreetLabel.Size = new System.Drawing.Size(0, 29);
            this.GreetLabel.TabIndex = 3;
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoldCheckBox.Location = new System.Drawing.Point(102, 96);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(138, 33);
            this.BoldCheckBox.TabIndex = 4;
            this.BoldCheckBox.Text = "Félkövér?";
            this.BoldCheckBox.UseVisualStyleBackColor = true;
            this.BoldCheckBox.CheckedChanged += new System.EventHandler(this.BoldCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.BoldCheckBox);
            this.Controls.Add(this.GreetLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.HelloBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hello Grafikus Világ!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelloBtn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GreetLabel;
        private System.Windows.Forms.CheckBox BoldCheckBox;
    }
}

