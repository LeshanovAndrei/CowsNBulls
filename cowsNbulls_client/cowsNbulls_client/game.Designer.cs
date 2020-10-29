namespace cowsNbulls_client
{
    partial class game
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.answersTable = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bullsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.answersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // answersTable
            // 
            this.answersTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.answersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.answersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.replyColumn,
            this.bullsColumn,
            this.cowsColumn});
            this.answersTable.Location = new System.Drawing.Point(11, 11);
            this.answersTable.Margin = new System.Windows.Forms.Padding(2);
            this.answersTable.Name = "answersTable";
            this.answersTable.RowHeadersWidth = 51;
            this.answersTable.RowTemplate.Height = 24;
            this.answersTable.Size = new System.Drawing.Size(763, 346);
            this.answersTable.TabIndex = 3;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 280;
            // 
            // replyColumn
            // 
            this.replyColumn.HeaderText = "Reply";
            this.replyColumn.MinimumWidth = 6;
            this.replyColumn.Name = "replyColumn";
            this.replyColumn.Width = 125;
            // 
            // bullsColumn
            // 
            this.bullsColumn.HeaderText = "Bulls";
            this.bullsColumn.MinimumWidth = 6;
            this.bullsColumn.Name = "bullsColumn";
            this.bullsColumn.Width = 125;
            // 
            // cowsColumn
            // 
            this.cowsColumn.HeaderText = "Cows";
            this.cowsColumn.MinimumWidth = 6;
            this.cowsColumn.Name = "cowsColumn";
            this.cowsColumn.Width = 125;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 366);
            this.Controls.Add(this.answersTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.answersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView answersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn replyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bullsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsColumn;
    }
}