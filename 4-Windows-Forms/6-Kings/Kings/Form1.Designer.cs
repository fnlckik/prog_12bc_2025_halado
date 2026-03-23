namespace Kings
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RangeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DynastyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KingsDataGrid = new System.Windows.Forms.DataGridView();
            this.DynastyComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KingsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.DataMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(74, 20);
            this.OpenMenuItem.Text = "Megnyitás";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // DataMenuItem
            // 
            this.DataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiagramMenuItem,
            this.EditMenuItem});
            this.DataMenuItem.Name = "DataMenuItem";
            this.DataMenuItem.Size = new System.Drawing.Size(57, 20);
            this.DataMenuItem.Text = "Adatok";
            // 
            // DiagramMenuItem
            // 
            this.DiagramMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RangeMenuItem,
            this.DynastyMenuItem});
            this.DiagramMenuItem.Name = "DiagramMenuItem";
            this.DiagramMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DiagramMenuItem.Text = "Diagram";
            // 
            // RangeMenuItem
            // 
            this.RangeMenuItem.Name = "RangeMenuItem";
            this.RangeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RangeMenuItem.Text = "Időtartam";
            this.RangeMenuItem.Click += new System.EventHandler(this.RangeMenuItem_Click);
            // 
            // DynastyMenuItem
            // 
            this.DynastyMenuItem.Name = "DynastyMenuItem";
            this.DynastyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DynastyMenuItem.Text = "Uralkodóházak";
            this.DynastyMenuItem.Click += new System.EventHandler(this.DynastyMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(132, 22);
            this.EditMenuItem.Text = "Szerkesztés";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // KingsDataGrid
            // 
            this.KingsDataGrid.AllowUserToAddRows = false;
            this.KingsDataGrid.AllowUserToDeleteRows = false;
            this.KingsDataGrid.AllowUserToResizeColumns = false;
            this.KingsDataGrid.AllowUserToResizeRows = false;
            this.KingsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KingsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KingsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.KingsDataGrid.Location = new System.Drawing.Point(424, 41);
            this.KingsDataGrid.Name = "KingsDataGrid";
            this.KingsDataGrid.RowHeadersVisible = false;
            this.KingsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KingsDataGrid.Size = new System.Drawing.Size(631, 493);
            this.KingsDataGrid.TabIndex = 1;
            // 
            // DynastyComboBox
            // 
            this.DynastyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DynastyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DynastyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DynastyComboBox.FormattingEnabled = true;
            this.DynastyComboBox.Location = new System.Drawing.Point(26, 94);
            this.DynastyComboBox.Name = "DynastyComboBox";
            this.DynastyComboBox.Size = new System.Drawing.Size(219, 28);
            this.DynastyComboBox.TabIndex = 2;
            this.DynastyComboBox.SelectedIndexChanged += new System.EventHandler(this.DynastyComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uralkodóház:";
            // 
            // Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart.Legends.Add(legend3);
            this.Chart.Location = new System.Drawing.Point(26, 151);
            this.Chart.Name = "Chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(373, 383);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "chart1";
            this.Chart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 546);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DynastyComboBox);
            this.Controls.Add(this.KingsDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KingsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.DataGridView KingsDataGrid;
        private System.Windows.Forms.ComboBox DynastyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem DataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiagramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RangeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DynastyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}

