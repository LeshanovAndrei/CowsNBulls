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
            this.answersTable = new System.Windows.Forms.DataGridView();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bullsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.answersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // answersTable
            // 
            this.answersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.replyColumn,
            this.bullsColumn,
            this.cowsColumn});
            this.answersTable.Location = new System.Drawing.Point(12, 12);
            this.answersTable.Name = "answersTable";
            this.answersTable.RowHeadersWidth = 51;
            this.answersTable.RowTemplate.Height = 24;
            this.answersTable.Size = new System.Drawing.Size(1017, 400);
            this.answersTable.TabIndex = 3;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(322, 420);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(100, 22);
            this.answerBox.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(428, 419);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send!";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.answersTable);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.answersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView answersTable;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn replyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bullsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsColumn;
    }
}