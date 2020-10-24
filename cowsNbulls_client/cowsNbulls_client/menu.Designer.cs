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
            this.ipBox = new System.Windows.Forms.TextBox();
            this.IPlabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
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
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(291, 206);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(181, 72);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join server";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
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
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(477, 206);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(142, 22);
            this.ipBox.TabIndex = 5;
            // 
            // IPlabel
            // 
            this.IPlabel.AutoSize = true;
            this.IPlabel.Location = new System.Drawing.Point(626, 210);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(20, 17);
            this.IPlabel.TabIndex = 6;
            this.IPlabel.Text = "IP";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(291, 320);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(181, 22);
            this.nameBox.TabIndex = 7;
            this.nameBox.Text = "Player";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(288, 345);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 17);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Your name";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.IPlabel);
            this.Controls.Add(this.ipBox);
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
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
    }
}

