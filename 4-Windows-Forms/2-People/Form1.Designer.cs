namespace _2_People
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
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.selectedSalary = new System.Windows.Forms.Label();
            this.selectedAge = new System.Windows.Forms.Label();
            this.selectedName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUpDown)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleListBox
            // 
            this.peopleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 29;
            this.peopleListBox.Location = new System.Drawing.Point(479, 119);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(294, 381);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.SelectedIndexChanged += new System.EventHandler(this.peopleListBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(129, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Név:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageLabel.Location = new System.Drawing.Point(96, 121);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(95, 29);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Életkor:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(204, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 35);
            this.nameTextBox.TabIndex = 3;
            // 
            // ageNumUpDown
            // 
            this.ageNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageNumUpDown.Location = new System.Drawing.Point(204, 119);
            this.ageNumUpDown.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.ageNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNumUpDown.Name = "ageNumUpDown";
            this.ageNumUpDown.Size = new System.Drawing.Size(120, 35);
            this.ageNumUpDown.TabIndex = 4;
            this.ageNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(64, 186);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 51);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Rögzítés";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.selectedSalary);
            this.panel.Controls.Add(this.selectedAge);
            this.panel.Controls.Add(this.selectedName);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(64, 262);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(339, 238);
            this.panel.TabIndex = 6;
            this.panel.Visible = false;
            // 
            // selectedSalary
            // 
            this.selectedSalary.AutoSize = true;
            this.selectedSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedSalary.Location = new System.Drawing.Point(31, 175);
            this.selectedSalary.Name = "selectedSalary";
            this.selectedSalary.Size = new System.Drawing.Size(97, 29);
            this.selectedSalary.TabIndex = 3;
            this.selectedSalary.Text = "Fizetés:";
            // 
            // selectedAge
            // 
            this.selectedAge.AutoSize = true;
            this.selectedAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedAge.Location = new System.Drawing.Point(31, 121);
            this.selectedAge.Name = "selectedAge";
            this.selectedAge.Size = new System.Drawing.Size(95, 29);
            this.selectedAge.TabIndex = 2;
            this.selectedAge.Text = "Életkor:";
            // 
            // selectedName
            // 
            this.selectedName.AutoSize = true;
            this.selectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedName.Location = new System.Drawing.Point(64, 71);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(62, 29);
            this.selectedName.TabIndex = 1;
            this.selectedName.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiválasztott személy adatai";
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sortButton.Location = new System.Drawing.Point(264, 186);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(139, 51);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Rendezés";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.Location = new System.Drawing.Point(479, 59);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 51);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Mentés";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadButton.Location = new System.Drawing.Point(646, 59);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(127, 51);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Betöltés";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageNumUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.peopleListBox);
            this.MinimumSize = new System.Drawing.Size(816, 596);
            this.Name = "Form1";
            this.Text = "TESCO munkások (nem szénbánya)";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUpDown)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown ageNumUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedAge;
        private System.Windows.Forms.Label selectedName;
        private System.Windows.Forms.Label selectedSalary;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

