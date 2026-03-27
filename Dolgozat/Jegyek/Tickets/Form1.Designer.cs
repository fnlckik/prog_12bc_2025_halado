namespace Tickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SeatsDataGrid = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.EmptySeatsButton = new System.Windows.Forms.Button();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.EmptySeatsLabel = new System.Windows.Forms.Label();
            this.ReserveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SeatsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SeatsDataGrid
            // 
            this.SeatsDataGrid.AllowUserToAddRows = false;
            this.SeatsDataGrid.AllowUserToDeleteRows = false;
            this.SeatsDataGrid.AllowUserToResizeColumns = false;
            this.SeatsDataGrid.AllowUserToResizeRows = false;
            this.SeatsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeatsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeatsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeatsDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SeatsDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.SeatsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SeatsDataGrid.Location = new System.Drawing.Point(310, 11);
            this.SeatsDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeatsDataGrid.MinimumSize = new System.Drawing.Size(514, 248);
            this.SeatsDataGrid.Name = "SeatsDataGrid";
            this.SeatsDataGrid.RowHeadersVisible = false;
            this.SeatsDataGrid.Size = new System.Drawing.Size(514, 248);
            this.SeatsDataGrid.TabIndex = 0;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(26, 19);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(90, 48);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Betöltés";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // EmptySeatsButton
            // 
            this.EmptySeatsButton.Location = new System.Drawing.Point(68, 139);
            this.EmptySeatsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmptySeatsButton.Name = "EmptySeatsButton";
            this.EmptySeatsButton.Size = new System.Drawing.Size(138, 48);
            this.EmptySeatsButton.TabIndex = 2;
            this.EmptySeatsButton.Text = "Szabad helyek";
            this.EmptySeatsButton.UseVisualStyleBackColor = true;
            this.EmptySeatsButton.Click += new System.EventHandler(this.EmptySeatsButton_Click);
            // 
            // ReserveButton
            // 
            this.ReserveButton.Enabled = false;
            this.ReserveButton.Location = new System.Drawing.Point(162, 19);
            this.ReserveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(101, 48);
            this.ReserveButton.TabIndex = 3;
            this.ReserveButton.Text = "Foglalás";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // EmptySeatsLabel
            // 
            this.EmptySeatsLabel.AutoSize = true;
            this.EmptySeatsLabel.Location = new System.Drawing.Point(36, 213);
            this.EmptySeatsLabel.Name = "EmptySeatsLabel";
            this.EmptySeatsLabel.Size = new System.Drawing.Size(168, 20);
            this.EmptySeatsLabel.TabIndex = 4;
            this.EmptySeatsLabel.Text = "Szabad helyek száma:";
            // 
            // ReserveLabel
            // 
            this.ReserveLabel.AutoSize = true;
            this.ReserveLabel.Location = new System.Drawing.Point(36, 91);
            this.ReserveLabel.Name = "ReserveLabel";
            this.ReserveLabel.Size = new System.Drawing.Size(122, 20);
            this.ReserveLabel.TabIndex = 5;
            this.ReserveLabel.Text = "Foglalás értéke:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 269);
            this.Controls.Add(this.ReserveLabel);
            this.Controls.Add(this.EmptySeatsLabel);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.EmptySeatsButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SeatsDataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(853, 316);
            this.Name = "Form1";
            this.Text = "Jegyfoglalás";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeatsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SeatsDataGrid;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button EmptySeatsButton;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Label EmptySeatsLabel;
        private System.Windows.Forms.Label ReserveLabel;
    }
}

