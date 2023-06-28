namespace TalkatooMoonImages
{
    partial class Form1
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
            txtPath = new TextBox();
            label1 = new Label();
            btnBrowse = new Button();
            ofdMoonsFile = new OpenFileDialog();
            btnMonitor = new Button();
            picMoon1 = new PictureBox();
            lblCurrentKingdom = new Label();
            label2 = new Label();
            btnPrevKingdom = new Button();
            btnNextKingdom = new Button();
            picMoon2 = new PictureBox();
            picMoon3 = new PictureBox();
            lblMoon1 = new Label();
            lblMoon2 = new Label();
            lblMoon3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picMoon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMoon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMoon3).BeginInit();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 27);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(413, 23);
            txtPath.TabIndex = 0;
            txtPath.TextChanged += txtPath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "pending-moons.txt Path:";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(431, 26);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(120, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // ofdMoonsFile
            // 
            ofdMoonsFile.InitialDirectory = "C:\\";
            // 
            // btnMonitor
            // 
            btnMonitor.Enabled = false;
            btnMonitor.Location = new Point(12, 56);
            btnMonitor.Name = "btnMonitor";
            btnMonitor.Size = new Size(539, 23);
            btnMonitor.TabIndex = 3;
            btnMonitor.Text = "Start Monitoring File";
            btnMonitor.UseVisualStyleBackColor = true;
            btnMonitor.Click += btnMonitor_Click;
            // 
            // picMoon1
            // 
            picMoon1.BorderStyle = BorderStyle.FixedSingle;
            picMoon1.Location = new Point(12, 154);
            picMoon1.Name = "picMoon1";
            picMoon1.Size = new Size(300, 169);
            picMoon1.TabIndex = 4;
            picMoon1.TabStop = false;
            // 
            // lblCurrentKingdom
            // 
            lblCurrentKingdom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentKingdom.Location = new Point(12, 104);
            lblCurrentKingdom.Name = "lblCurrentKingdom";
            lblCurrentKingdom.Size = new Size(539, 24);
            lblCurrentKingdom.TabIndex = 5;
            lblCurrentKingdom.Text = "Cascade";
            lblCurrentKingdom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(538, 23);
            label2.TabIndex = 6;
            label2.Text = "Current Kingdom:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrevKingdom
            // 
            btnPrevKingdom.Location = new Point(12, 105);
            btnPrevKingdom.Name = "btnPrevKingdom";
            btnPrevKingdom.Size = new Size(200, 26);
            btnPrevKingdom.TabIndex = 7;
            btnPrevKingdom.Text = "<<<";
            btnPrevKingdom.TextAlign = ContentAlignment.MiddleRight;
            btnPrevKingdom.UseVisualStyleBackColor = true;
            btnPrevKingdom.Click += btnPrevKingdom_Click;
            // 
            // btnNextKingdom
            // 
            btnNextKingdom.Location = new Point(351, 105);
            btnNextKingdom.Name = "btnNextKingdom";
            btnNextKingdom.Size = new Size(200, 26);
            btnNextKingdom.TabIndex = 8;
            btnNextKingdom.Text = ">>> Sand";
            btnNextKingdom.TextAlign = ContentAlignment.MiddleLeft;
            btnNextKingdom.UseVisualStyleBackColor = true;
            btnNextKingdom.Click += btnNextKingdom_Click;
            // 
            // picMoon2
            // 
            picMoon2.BorderStyle = BorderStyle.FixedSingle;
            picMoon2.Location = new Point(12, 329);
            picMoon2.Name = "picMoon2";
            picMoon2.Size = new Size(300, 169);
            picMoon2.SizeMode = PictureBoxSizeMode.Zoom;
            picMoon2.TabIndex = 9;
            picMoon2.TabStop = false;
            // 
            // picMoon3
            // 
            picMoon3.BorderStyle = BorderStyle.FixedSingle;
            picMoon3.Location = new Point(12, 504);
            picMoon3.Name = "picMoon3";
            picMoon3.Size = new Size(300, 169);
            picMoon3.SizeMode = PictureBoxSizeMode.Zoom;
            picMoon3.TabIndex = 10;
            picMoon3.TabStop = false;
            // 
            // lblMoon1
            // 
            lblMoon1.BackColor = Color.White;
            lblMoon1.BorderStyle = BorderStyle.FixedSingle;
            lblMoon1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon1.Location = new Point(318, 154);
            lblMoon1.Name = "lblMoon1";
            lblMoon1.Size = new Size(233, 169);
            lblMoon1.TabIndex = 11;
            // 
            // lblMoon2
            // 
            lblMoon2.BackColor = Color.White;
            lblMoon2.BorderStyle = BorderStyle.FixedSingle;
            lblMoon2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon2.Location = new Point(318, 329);
            lblMoon2.Name = "lblMoon2";
            lblMoon2.Size = new Size(233, 169);
            lblMoon2.TabIndex = 12;
            // 
            // lblMoon3
            // 
            lblMoon3.BackColor = Color.White;
            lblMoon3.BorderStyle = BorderStyle.FixedSingle;
            lblMoon3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon3.Location = new Point(318, 504);
            lblMoon3.Name = "lblMoon3";
            lblMoon3.Size = new Size(233, 169);
            lblMoon3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 684);
            Controls.Add(lblMoon3);
            Controls.Add(lblMoon2);
            Controls.Add(lblMoon1);
            Controls.Add(picMoon3);
            Controls.Add(picMoon2);
            Controls.Add(btnNextKingdom);
            Controls.Add(btnPrevKingdom);
            Controls.Add(label2);
            Controls.Add(lblCurrentKingdom);
            Controls.Add(picMoon1);
            Controls.Add(btnMonitor);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Name = "Form1";
            Text = "Talkatoo Moon Images";
            ((System.ComponentModel.ISupportInitialize)picMoon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMoon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMoon3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPath;
        private Label label1;
        private Button btnBrowse;
        private OpenFileDialog ofdMoonsFile;
        private Button btnMonitor;
        private PictureBox picMoon1;
        private Label lblCurrentKingdom;
        private Label label2;
        private Button btnPrevKingdom;
        private Button btnNextKingdom;
        private PictureBox picMoon2;
        private PictureBox picMoon3;
        private Label lblMoon1;
        private Label lblMoon2;
        private Label lblMoon3;
    }
}