namespace GodsUnchainedDeckTracker
{
    partial class GUDECKTRACKER
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            YourIdLabel = new Label();
            OpponentIdLabel = new Label();
            OpponentNickLabel = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            YourNicknameLabel = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // YourIdLabel
            // 
            YourIdLabel.AutoSize = true;
            YourIdLabel.Location = new Point(232, 47);
            YourIdLabel.Margin = new Padding(2, 0, 2, 0);
            YourIdLabel.Name = "YourIdLabel";
            YourIdLabel.Size = new Size(50, 19);
            YourIdLabel.TabIndex = 0;
            YourIdLabel.Text = "label1";
            YourIdLabel.Click += YourIdLabel_Click;
            // 
            // OpponentIdLabel
            // 
            OpponentIdLabel.AutoSize = true;
            OpponentIdLabel.Location = new Point(230, 51);
            OpponentIdLabel.Margin = new Padding(2, 0, 2, 0);
            OpponentIdLabel.Name = "OpponentIdLabel";
            OpponentIdLabel.Size = new Size(50, 19);
            OpponentIdLabel.TabIndex = 1;
            OpponentIdLabel.Text = "label2";
            // 
            // OpponentNickLabel
            // 
            OpponentNickLabel.AutoSize = true;
            OpponentNickLabel.Location = new Point(230, 18);
            OpponentNickLabel.Margin = new Padding(2, 0, 2, 0);
            OpponentNickLabel.Name = "OpponentNickLabel";
            OpponentNickLabel.Size = new Size(50, 19);
            OpponentNickLabel.TabIndex = 2;
            OpponentNickLabel.Text = "label3";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-12, -20);
            panel1.Margin = new Padding(2, 6, 2, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 81);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 5;
            label2.Text = "GU DECK TRACKER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 452);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 85);
            label1.TabIndex = 4;
            label1.Text = "When opening this deck link, a brief ad will be displayed.\r\n Your support helps us keep the software free and running. \r\nThank you for your understanding!\r\n\r\n\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(167, 370);
            checkBox1.Margin = new Padding(2, 6, 2, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(167, 37);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "AUTO OPEN";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // YourNicknameLabel
            // 
            YourNicknameLabel.AutoSize = true;
            YourNicknameLabel.ForeColor = SystemColors.ActiveCaptionText;
            YourNicknameLabel.Location = new Point(232, 16);
            YourNicknameLabel.Margin = new Padding(2, 0, 2, 0);
            YourNicknameLabel.Name = "YourNicknameLabel";
            YourNicknameLabel.Size = new Size(50, 19);
            YourNicknameLabel.TabIndex = 6;
            YourNicknameLabel.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(YourNicknameLabel);
            panel3.Controls.Add(YourIdLabel);
            panel3.Location = new Point(77, 138);
            panel3.Margin = new Padding(2, 6, 2, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(369, 86);
            panel3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(17, 47);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(198, 19);
            label4.TabIndex = 8;
            label4.Text = "YOUR ID(yep its ugly)";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(17, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 7;
            label3.Text = "YOU";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(OpponentNickLabel);
            panel2.Controls.Add(OpponentIdLabel);
            panel2.Location = new Point(77, 236);
            panel2.Margin = new Padding(2, 6, 2, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 88);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(15, 51);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(198, 19);
            label5.TabIndex = 8;
            label5.Text = "His ID(very bad deck)";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(15, 18);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 7;
            label6.Text = "Oppoment";
            // 
            // GUDECKTRACKER
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(480, 544);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 6, 2, 6);
            Name = "GUDECKTRACKER";
            RightToLeft = RightToLeft.No;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label YourIdLabel;
        private Label OpponentIdLabel;
        private Label OpponentNickLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Label YourNicknameLabel;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Label label6;
    }
}
