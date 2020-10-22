namespace cowsNbulls_client
{
    partial class menu
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
            this.createButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.compCheck = new System.Windows.Forms.CheckBox();
            this.playersNumeric = new System.Windows.Forms.NumericUpDown();
            this.labelPlayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playersNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(291, 101);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(181, 72);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Server";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(291, 206);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(181, 72);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join server";
            this.joinButton.UseVisualStyleBackColor = true;
            // 
            // compCheck
            // 
            this.compCheck.AutoSize = true;
            this.compCheck.Location = new System.Drawing.Point(478, 139);
            this.compCheck.Name = "compCheck";
            this.compCheck.Size = new System.Drawing.Size(261, 21);
            this.compCheck.TabIndex = 2;
            this.compCheck.Text = "The server comes up with an answer";
            this.compCheck.UseVisualStyleBackColor = true;
            // 
            // playersNumeric
            // 
            this.playersNumeric.Location = new System.Drawing.Point(477, 111);
            this.playersNumeric.Name = "playersNumeric";
            this.playersNumeric.Size = new System.Drawing.Size(38, 22);
            this.playersNumeric.TabIndex = 3;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(522, 115);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(124, 17);
            this.labelPlayers.TabIndex = 4;
            this.labelPlayers.Text = "Number of players";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.playersNumeric);
            this.Controls.Add(this.compCheck);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.createButton);
            this.Name = "menu";
            this.Text = "CowsNBulls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.CheckBox compCheck;
        private System.Windows.Forms.NumericUpDown playersNumeric;
        private System.Windows.Forms.Label labelPlayers;
    }
}

