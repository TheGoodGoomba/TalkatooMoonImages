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
            ((System.ComponentModel.ISupportInitialize)picMoon1).BeginInit();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 27);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(286, 23);
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
            btnBrowse.Location = new Point(304, 27);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(87, 23);
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
            btnMonitor.Size = new Size(379, 23);
            btnMonitor.TabIndex = 3;
            btnMonitor.Text = "Start Monitoring File";
            btnMonitor.UseVisualStyleBackColor = true;
            btnMonitor.Click += btnMonitor_Click;
            // 
            // picMoon1
            // 
            picMoon1.Location = new Point(12, 121);
            picMoon1.Name = "picMoon1";
            picMoon1.Size = new Size(272, 113);
            picMoon1.TabIndex = 4;
            picMoon1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 440);
            Controls.Add(picMoon1);
            Controls.Add(btnMonitor);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Name = "Form1";
            Text = "Talkatoo Moon Images";
            ((System.ComponentModel.ISupportInitialize)picMoon1).EndInit();
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
    }
}