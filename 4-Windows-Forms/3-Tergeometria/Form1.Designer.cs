namespace _3_Tergeometria
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
            this.ConeRadioBtn = new System.Windows.Forms.RadioButton();
            this.CylinderRadioBtn = new System.Windows.Forms.RadioButton();
            this.SphereRadioBtn = new System.Windows.Forms.RadioButton();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.LargestLabel = new System.Windows.Forms.Label();
            this.VolumeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.AreaNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgPanel = new System.Windows.Forms.Panel();
            this.ShapeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadiusNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConeRadioBtn);
            this.groupBox1.Controls.Add(this.CylinderRadioBtn);
            this.groupBox1.Controls.Add(this.SphereRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(37, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 1000;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test típusa";
            // 
            // ConeRadioBtn
            // 
            this.ConeRadioBtn.AutoSize = true;
            this.ConeRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConeRadioBtn.Location = new System.Drawing.Point(18, 124);
            this.ConeRadioBtn.Name = "ConeRadioBtn";
            this.ConeRadioBtn.Size = new System.Drawing.Size(62, 28);
            this.ConeRadioBtn.TabIndex = 69;
            this.ConeRadioBtn.TabStop = true;
            this.ConeRadioBtn.Tag = "cone";
            this.ConeRadioBtn.Text = "Kúp";
            this.ConeRadioBtn.UseVisualStyleBackColor = true;
            this.ConeRadioBtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // CylinderRadioBtn
            // 
            this.CylinderRadioBtn.AutoSize = true;
            this.CylinderRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CylinderRadioBtn.Location = new System.Drawing.Point(18, 85);
            this.CylinderRadioBtn.Name = "CylinderRadioBtn";
            this.CylinderRadioBtn.Size = new System.Drawing.Size(92, 28);
            this.CylinderRadioBtn.TabIndex = 68;
            this.CylinderRadioBtn.TabStop = true;
            this.CylinderRadioBtn.Tag = "cylinder";
            this.CylinderRadioBtn.Text = "Henger";
            this.CylinderRadioBtn.UseVisualStyleBackColor = true;
            this.CylinderRadioBtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // SphereRadioBtn
            // 
            this.SphereRadioBtn.AutoSize = true;
            this.SphereRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SphereRadioBtn.Location = new System.Drawing.Point(18, 46);
            this.SphereRadioBtn.Name = "SphereRadioBtn";
            this.SphereRadioBtn.Size = new System.Drawing.Size(80, 28);
            this.SphereRadioBtn.TabIndex = 67;
            this.SphereRadioBtn.TabStop = true;
            this.SphereRadioBtn.Tag = "sphere";
            this.SphereRadioBtn.Text = "Gömb";
            this.SphereRadioBtn.UseVisualStyleBackColor = true;
            this.SphereRadioBtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateButton.Location = new System.Drawing.Point(20, 34);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(90, 43);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generál";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.AddButton);
            this.ButtonPanel.Controls.Add(this.CheckButton);
            this.ButtonPanel.Controls.Add(this.CalculateButton);
            this.ButtonPanel.Controls.Add(this.LargestLabel);
            this.ButtonPanel.Controls.Add(this.VolumeNumUpDown);
            this.ButtonPanel.Controls.Add(this.AreaNumUpDown);
            this.ButtonPanel.Controls.Add(this.label4);
            this.ButtonPanel.Controls.Add(this.label3);
            this.ButtonPanel.Controls.Add(this.GenerateButton);
            this.ButtonPanel.Enabled = false;
            this.ButtonPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPanel.Location = new System.Drawing.Point(37, 241);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(540, 240);
            this.ButtonPanel.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.Location = new System.Drawing.Point(418, 34);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 43);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Tárol";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckButton.Location = new System.Drawing.Point(282, 34);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(103, 43);
            this.CheckButton.TabIndex = 11;
            this.CheckButton.Text = "Ellenőriz";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculateButton.Location = new System.Drawing.Point(151, 34);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(90, 43);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Számol";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // LargestLabel
            // 
            this.LargestLabel.AutoSize = true;
            this.LargestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LargestLabel.Location = new System.Drawing.Point(29, 185);
            this.LargestLabel.Name = "LargestLabel";
            this.LargestLabel.Size = new System.Drawing.Size(193, 24);
            this.LargestLabel.TabIndex = 9;
            this.LargestLabel.Text = "Legnagyobb térfogatú";
            // 
            // VolumeNumUpDown
            // 
            this.VolumeNumUpDown.DecimalPlaces = 1;
            this.VolumeNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.VolumeNumUpDown.Location = new System.Drawing.Point(335, 126);
            this.VolumeNumUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.VolumeNumUpDown.Name = "VolumeNumUpDown";
            this.VolumeNumUpDown.Size = new System.Drawing.Size(120, 29);
            this.VolumeNumUpDown.TabIndex = 8;
            // 
            // AreaNumUpDown
            // 
            this.AreaNumUpDown.DecimalPlaces = 1;
            this.AreaNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AreaNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AreaNumUpDown.Location = new System.Drawing.Point(111, 125);
            this.AreaNumUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AreaNumUpDown.Name = "AreaNumUpDown";
            this.AreaNumUpDown.Size = new System.Drawing.Size(120, 29);
            this.AreaNumUpDown.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(245, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Térfogat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Felszín:";
            // 
            // ImgPanel
            // 
            this.ImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImgPanel.Location = new System.Drawing.Point(636, 231);
            this.ImgPanel.Name = "ImgPanel";
            this.ImgPanel.Size = new System.Drawing.Size(250, 250);
            this.ImgPanel.TabIndex = 8;
            // 
            // ShapeListBox
            // 
            this.ShapeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShapeListBox.FormattingEnabled = true;
            this.ShapeListBox.ItemHeight = 24;
            this.ShapeListBox.Location = new System.Drawing.Point(636, 27);
            this.ShapeListBox.Name = "ShapeListBox";
            this.ShapeListBox.Size = new System.Drawing.Size(254, 172);
            this.ShapeListBox.TabIndex = 9;
            this.ShapeListBox.SelectedIndexChanged += new System.EventHandler(this.ShapeListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(321, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sugár (R):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(282, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Magasság (M):";
            // 
            // RadiusNumUpDown
            // 
            this.RadiusNumUpDown.DecimalPlaces = 1;
            this.RadiusNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadiusNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RadiusNumUpDown.Location = new System.Drawing.Point(422, 121);
            this.RadiusNumUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RadiusNumUpDown.Name = "RadiusNumUpDown";
            this.RadiusNumUpDown.Size = new System.Drawing.Size(120, 29);
            this.RadiusNumUpDown.TabIndex = 0;
            this.RadiusNumUpDown.ValueChanged += new System.EventHandler(this.NumUpDown_ValueChanged);
            // 
            // HeightNumUpDown
            // 
            this.HeightNumUpDown.DecimalPlaces = 1;
            this.HeightNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HeightNumUpDown.Location = new System.Drawing.Point(422, 163);
            this.HeightNumUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HeightNumUpDown.Name = "HeightNumUpDown";
            this.HeightNumUpDown.Size = new System.Drawing.Size(120, 29);
            this.HeightNumUpDown.TabIndex = 13;
            this.HeightNumUpDown.ValueChanged += new System.EventHandler(this.NumUpDown_ValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.ForeColor = System.Drawing.Color.Blue;
            this.SaveButton.Location = new System.Drawing.Point(360, 41);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 56);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "💾";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.OpenButton.Location = new System.Drawing.Point(483, 41);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(59, 56);
            this.OpenButton.TabIndex = 14;
            this.OpenButton.Text = "📂";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 527);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HeightNumUpDown);
            this.Controls.Add(this.RadiusNumUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShapeListBox);
            this.Controls.Add(this.ImgPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ConeRadioBtn;
        private System.Windows.Forms.RadioButton CylinderRadioBtn;
        private System.Windows.Forms.RadioButton SphereRadioBtn;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel ImgPanel;
        private System.Windows.Forms.ListBox ShapeListBox;
        private System.Windows.Forms.Label LargestLabel;
        private System.Windows.Forms.NumericUpDown VolumeNumUpDown;
        private System.Windows.Forms.NumericUpDown AreaNumUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RadiusNumUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumUpDown;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
    }
}

