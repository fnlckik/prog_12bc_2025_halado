namespace PizzaTime
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.FamilyCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NegysajtosRadio = new System.Windows.Forms.RadioButton();
            this.MagyarosRadio = new System.Windows.Forms.RadioButton();
            this.SongokuRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CostLabel = new System.Windows.Forms.Label();
            this.PizzaListBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddressTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(304, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felhasználó adatai";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(73, 79);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(199, 26);
            this.AddressTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(73, 41);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(199, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cím:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.AmountNumeric);
            this.groupBox2.Controls.Add(this.FamilyCheckBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(33, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(304, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza adatai";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(166, 272);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 36);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Törlés";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(31, 272);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Hozzáadás";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AmountNumeric
            // 
            this.AmountNumeric.Location = new System.Drawing.Point(136, 227);
            this.AmountNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AmountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountNumeric.Name = "AmountNumeric";
            this.AmountNumeric.Size = new System.Drawing.Size(120, 26);
            this.AmountNumeric.TabIndex = 4;
            this.AmountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FamilyCheckBox
            // 
            this.FamilyCheckBox.AutoSize = true;
            this.FamilyCheckBox.Location = new System.Drawing.Point(31, 186);
            this.FamilyCheckBox.Name = "FamilyCheckBox";
            this.FamilyCheckBox.Size = new System.Drawing.Size(181, 24);
            this.FamilyCheckBox.TabIndex = 3;
            this.FamilyCheckBox.Text = "Családi méret - 45 cm";
            this.FamilyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mennyiség:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NegysajtosRadio);
            this.groupBox3.Controls.Add(this.MagyarosRadio);
            this.groupBox3.Controls.Add(this.SongokuRadio);
            this.groupBox3.Location = new System.Drawing.Point(31, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 144);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Típus";
            // 
            // NegysajtosRadio
            // 
            this.NegysajtosRadio.AutoSize = true;
            this.NegysajtosRadio.Location = new System.Drawing.Point(29, 114);
            this.NegysajtosRadio.Name = "NegysajtosRadio";
            this.NegysajtosRadio.Size = new System.Drawing.Size(174, 24);
            this.NegysajtosRadio.TabIndex = 2;
            this.NegysajtosRadio.TabStop = true;
            this.NegysajtosRadio.Tag = "Négysajtos";
            this.NegysajtosRadio.Text = "Négysajtos (4500 Ft)";
            this.NegysajtosRadio.UseVisualStyleBackColor = true;
            this.NegysajtosRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // MagyarosRadio
            // 
            this.MagyarosRadio.AutoSize = true;
            this.MagyarosRadio.Location = new System.Drawing.Point(29, 76);
            this.MagyarosRadio.Name = "MagyarosRadio";
            this.MagyarosRadio.Size = new System.Drawing.Size(165, 24);
            this.MagyarosRadio.TabIndex = 1;
            this.MagyarosRadio.TabStop = true;
            this.MagyarosRadio.Tag = "Magyaros";
            this.MagyarosRadio.Text = "Magyaros (3800 Ft)";
            this.MagyarosRadio.UseVisualStyleBackColor = true;
            this.MagyarosRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // SongokuRadio
            // 
            this.SongokuRadio.AutoSize = true;
            this.SongokuRadio.Location = new System.Drawing.Point(29, 43);
            this.SongokuRadio.Name = "SongokuRadio";
            this.SongokuRadio.Size = new System.Drawing.Size(160, 24);
            this.SongokuRadio.TabIndex = 0;
            this.SongokuRadio.TabStop = true;
            this.SongokuRadio.Tag = "Songoku";
            this.SongokuRadio.Text = "Songoku (3500 Ft)";
            this.SongokuRadio.UseVisualStyleBackColor = true;
            this.SongokuRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::PizzaTime.Properties.Resources.pizza;
            this.panel1.Location = new System.Drawing.Point(407, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 64);
            this.panel1.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CostLabel.Location = new System.Drawing.Point(403, 377);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(139, 20);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Fizetendő összeg:";
            // 
            // PizzaListBox
            // 
            this.PizzaListBox.FormattingEnabled = true;
            this.PizzaListBox.ItemHeight = 15;
            this.PizzaListBox.Location = new System.Drawing.Point(422, 40);
            this.PizzaListBox.Name = "PizzaListBox";
            this.PizzaListBox.Size = new System.Drawing.Size(305, 244);
            this.PizzaListBox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(422, 315);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(106, 36);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Mentés";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(621, 315);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(106, 36);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Betöltés";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 535);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PizzaListBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 574);
            this.MinimumSize = new System.Drawing.Size(764, 574);
            this.Name = "Form1";
            this.Text = "Pizza Time!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown AmountNumeric;
        private System.Windows.Forms.CheckBox FamilyCheckBox;
        private System.Windows.Forms.RadioButton NegysajtosRadio;
        private System.Windows.Forms.RadioButton MagyarosRadio;
        private System.Windows.Forms.RadioButton SongokuRadio;
        private System.Windows.Forms.ListBox PizzaListBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

