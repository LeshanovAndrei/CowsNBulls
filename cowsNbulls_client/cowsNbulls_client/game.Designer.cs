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
            this.myReplyTextBox = new System.Windows.Forms.TextBox();
            this.myReplyLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.replyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bullsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // myReplyTextBox
            // 
            this.myReplyTextBox.Location = new System.Drawing.Point(126, 400);
            this.myReplyTextBox.Name = "myReplyTextBox";
            this.myReplyTextBox.Size = new System.Drawing.Size(100, 22);
            this.myReplyTextBox.TabIndex = 0;
            // 
            // myReplyLabel
            // 
            this.myReplyLabel.AutoSize = true;
            this.myReplyLabel.Location = new System.Drawing.Point(41, 403);
            this.myReplyLabel.Name = "myReplyLabel";
            this.myReplyLabel.Size = new System.Drawing.Size(65, 17);
            this.myReplyLabel.TabIndex = 1;
            this.myReplyLabel.Text = "My reply:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(250, 398);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send!";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.replyColumn,
            this.bullsColumn,
            this.cowsColumn});
            this.dataGridView1.Location = new System.Drawing.Point(126, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.myReplyLabel);
            this.Controls.Add(this.myReplyTextBox);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myReplyTextBox;
        private System.Windows.Forms.Label myReplyLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn replyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bullsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsColumn;
    }
}