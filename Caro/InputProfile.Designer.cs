namespace Caro
{
    partial class InputProfile
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
            lblPlayerX = new Label();
            label2 = new Label();
            lblPlayerO = new Label();
            txbPlayerX = new TextBox();
            txbPlayerO = new TextBox();
            lblTime = new Label();
            rdbUnlimit = new RadioButton();
            rdbLimit = new RadioButton();
            txbTime = new TextBox();
            lblSecond = new Label();
            lblTittle = new Label();
            button1 = new Button();
            lblChan2dau = new Label();
            panel1 = new Panel();
            rdbNo2dau = new RadioButton();
            rdbYes2dau = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPlayerX
            // 
            lblPlayerX.AutoSize = true;
            lblPlayerX.BackColor = SystemColors.Control;
            lblPlayerX.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerX.ForeColor = Color.Red;
            lblPlayerX.Location = new Point(67, 81);
            lblPlayerX.Name = "lblPlayerX";
            lblPlayerX.Size = new Size(167, 31);
            lblPlayerX.TabIndex = 0;
            lblPlayerX.Text = "Người chơi X: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 196);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblPlayerO
            // 
            lblPlayerO.AutoSize = true;
            lblPlayerO.BackColor = SystemColors.Control;
            lblPlayerO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerO.ForeColor = Color.FromArgb(0, 192, 0);
            lblPlayerO.Location = new Point(67, 139);
            lblPlayerO.Name = "lblPlayerO";
            lblPlayerO.Size = new Size(169, 31);
            lblPlayerO.TabIndex = 2;
            lblPlayerO.Text = "Người chơi O: ";
            // 
            // txbPlayerX
            // 
            txbPlayerX.Location = new Point(241, 86);
            txbPlayerX.Name = "txbPlayerX";
            txbPlayerX.Size = new Size(307, 27);
            txbPlayerX.TabIndex = 3;
            // 
            // txbPlayerO
            // 
            txbPlayerO.Location = new Point(241, 143);
            txbPlayerO.Name = "txbPlayerO";
            txbPlayerO.Size = new Size(307, 27);
            txbPlayerO.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = SystemColors.Control;
            lblTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.DarkSlateGray;
            lblTime.Location = new Point(67, 242);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(99, 41);
            lblTime.TabIndex = 5;
            lblTime.Text = "TIME:";
            // 
            // rdbUnlimit
            // 
            rdbUnlimit.AutoSize = true;
            rdbUnlimit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbUnlimit.Location = new Point(198, 251);
            rdbUnlimit.Name = "rdbUnlimit";
            rdbUnlimit.Size = new Size(167, 32);
            rdbUnlimit.TabIndex = 6;
            rdbUnlimit.TabStop = true;
            rdbUnlimit.Text = "Không giới hạn";
            rdbUnlimit.UseVisualStyleBackColor = true;
            rdbUnlimit.CheckedChanged += rdbUnlimit_CheckedChanged;
            // 
            // rdbLimit
            // 
            rdbLimit.AutoSize = true;
            rdbLimit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbLimit.Location = new Point(198, 310);
            rdbLimit.Name = "rdbLimit";
            rdbLimit.Size = new Size(106, 32);
            rdbLimit.TabIndex = 7;
            rdbLimit.TabStop = true;
            rdbLimit.Text = "Giới hạn";
            rdbLimit.UseVisualStyleBackColor = true;
            rdbLimit.CheckedChanged += rdbLimit_CheckedChanged;
            // 
            // txbTime
            // 
            txbTime.Location = new Point(310, 312);
            txbTime.Name = "txbTime";
            txbTime.Size = new Size(83, 27);
            txbTime.TabIndex = 8;
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Location = new Point(399, 319);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(37, 20);
            lblSecond.TabIndex = 9;
            lblSecond.Text = "giây";
            // 
            // lblTittle
            // 
            lblTittle.Dock = DockStyle.Top;
            lblTittle.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblTittle.ForeColor = Color.OrangeRed;
            lblTittle.Location = new Point(0, 0);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(637, 67);
            lblTittle.TabIndex = 10;
            lblTittle.Text = "CARO GAME";
            lblTittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(182, 381);
            button1.Name = "button1";
            button1.Size = new Size(254, 54);
            button1.TabIndex = 11;
            button1.Text = "Chơi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblChan2dau
            // 
            lblChan2dau.AutoSize = true;
            lblChan2dau.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblChan2dau.Location = new Point(67, 196);
            lblChan2dau.Name = "lblChan2dau";
            lblChan2dau.Size = new Size(126, 28);
            lblChan2dau.TabIndex = 12;
            lblChan2dau.Text = "Chặn 2 đầu: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbNo2dau);
            panel1.Controls.Add(rdbYes2dau);
            panel1.Location = new Point(199, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 46);
            panel1.TabIndex = 13;
            // 
            // rdbNo2dau
            // 
            rdbNo2dau.AutoSize = true;
            rdbNo2dau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNo2dau.Location = new Point(164, 11);
            rdbNo2dau.Name = "rdbNo2dau";
            rdbNo2dau.Size = new Size(81, 27);
            rdbNo2dau.TabIndex = 1;
            rdbNo2dau.TabStop = true;
            rdbNo2dau.Text = "Không";
            rdbNo2dau.UseVisualStyleBackColor = true;
            // 
            // rdbYes2dau
            // 
            rdbYes2dau.AutoSize = true;
            rdbYes2dau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rdbYes2dau.Location = new Point(13, 11);
            rdbYes2dau.Name = "rdbYes2dau";
            rdbYes2dau.Size = new Size(52, 27);
            rdbYes2dau.TabIndex = 0;
            rdbYes2dau.TabStop = true;
            rdbYes2dau.Text = "Có";
            rdbYes2dau.UseVisualStyleBackColor = true;
            // 
            // InputProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 447);
            Controls.Add(panel1);
            Controls.Add(lblChan2dau);
            Controls.Add(button1);
            Controls.Add(lblTittle);
            Controls.Add(lblSecond);
            Controls.Add(txbTime);
            Controls.Add(rdbLimit);
            Controls.Add(rdbUnlimit);
            Controls.Add(lblTime);
            Controls.Add(txbPlayerO);
            Controls.Add(txbPlayerX);
            Controls.Add(lblPlayerO);
            Controls.Add(label2);
            Controls.Add(lblPlayerX);
            Name = "InputProfile";
            Text = "InputProfile";
            Load += InputProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerX;
        private Label label2;
        private Label lblPlayerO;
        private TextBox txbPlayerX;
        private TextBox txbPlayerO;
        private Label lblTime;
        private RadioButton rdbUnlimit;
        private RadioButton rdbLimit;
        private TextBox txbTime;
        private Label lblSecond;
        private Label lblTittle;
        private Button button1;
        private Label lblChan2dau;
        private Panel panel1;
        private RadioButton rdbNo2dau;
        private RadioButton rdbYes2dau;
    }
}