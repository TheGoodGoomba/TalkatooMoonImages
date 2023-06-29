namespace TalkatooMoonImages
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            lblMoon1Name = new Label();
            menuStrip = new MenuStrip();
            tsiMoonNotes = new ToolStripMenuItem();
            lblMoon1Notes = new Label();
            lblMoon2Notes = new Label();
            lblMoon2Name = new Label();
            lblMoon3Notes = new Label();
            lblMoon3Name = new Label();
            ((System.ComponentModel.ISupportInitialize)picMoon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMoon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMoon3).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 51);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(413, 23);
            txtPath.TabIndex = 0;
            txtPath.TextChanged += txtPath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "pending-moons.txt Path:";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(430, 51);
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
            btnMonitor.Location = new Point(12, 80);
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
            picMoon1.Location = new Point(12, 178);
            picMoon1.Name = "picMoon1";
            picMoon1.Size = new Size(300, 170);
            picMoon1.TabIndex = 4;
            picMoon1.TabStop = false;
            // 
            // lblCurrentKingdom
            // 
            lblCurrentKingdom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentKingdom.Location = new Point(12, 128);
            lblCurrentKingdom.Name = "lblCurrentKingdom";
            lblCurrentKingdom.Size = new Size(539, 24);
            lblCurrentKingdom.TabIndex = 5;
            lblCurrentKingdom.Text = "Cascade";
            lblCurrentKingdom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(538, 23);
            label2.TabIndex = 6;
            label2.Text = "Current Kingdom:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrevKingdom
            // 
            btnPrevKingdom.Location = new Point(12, 129);
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
            btnNextKingdom.Location = new Point(350, 129);
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
            picMoon2.Location = new Point(12, 354);
            picMoon2.Name = "picMoon2";
            picMoon2.Size = new Size(300, 170);
            picMoon2.SizeMode = PictureBoxSizeMode.Zoom;
            picMoon2.TabIndex = 9;
            picMoon2.TabStop = false;
            // 
            // picMoon3
            // 
            picMoon3.BorderStyle = BorderStyle.FixedSingle;
            picMoon3.Location = new Point(12, 530);
            picMoon3.Name = "picMoon3";
            picMoon3.Size = new Size(300, 170);
            picMoon3.SizeMode = PictureBoxSizeMode.Zoom;
            picMoon3.TabIndex = 10;
            picMoon3.TabStop = false;
            // 
            // lblMoon1Name
            // 
            lblMoon1Name.BackColor = Color.White;
            lblMoon1Name.BorderStyle = BorderStyle.FixedSingle;
            lblMoon1Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon1Name.Location = new Point(319, 178);
            lblMoon1Name.Name = "lblMoon1Name";
            lblMoon1Name.Size = new Size(233, 70);
            lblMoon1Name.TabIndex = 11;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { tsiMoonNotes });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(564, 24);
            menuStrip.TabIndex = 14;
            menuStrip.Text = "menuStrip1";
            // 
            // tsiMoonNotes
            // 
            tsiMoonNotes.Name = "tsiMoonNotes";
            tsiMoonNotes.Size = new Size(85, 20);
            tsiMoonNotes.Text = "Moon Notes";
            tsiMoonNotes.Click += tsiMoonNotes_Click;
            // 
            // lblMoon1Notes
            // 
            lblMoon1Notes.BackColor = Color.White;
            lblMoon1Notes.BorderStyle = BorderStyle.FixedSingle;
            lblMoon1Notes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon1Notes.Location = new Point(319, 250);
            lblMoon1Notes.Name = "lblMoon1Notes";
            lblMoon1Notes.Size = new Size(233, 98);
            lblMoon1Notes.TabIndex = 15;
            // 
            // lblMoon2Notes
            // 
            lblMoon2Notes.BackColor = Color.White;
            lblMoon2Notes.BorderStyle = BorderStyle.FixedSingle;
            lblMoon2Notes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon2Notes.Location = new Point(319, 426);
            lblMoon2Notes.Name = "lblMoon2Notes";
            lblMoon2Notes.Size = new Size(233, 98);
            lblMoon2Notes.TabIndex = 17;
            // 
            // lblMoon2Name
            // 
            lblMoon2Name.BackColor = Color.White;
            lblMoon2Name.BorderStyle = BorderStyle.FixedSingle;
            lblMoon2Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon2Name.Location = new Point(319, 354);
            lblMoon2Name.Name = "lblMoon2Name";
            lblMoon2Name.Size = new Size(233, 70);
            lblMoon2Name.TabIndex = 16;
            // 
            // lblMoon3Notes
            // 
            lblMoon3Notes.BackColor = Color.White;
            lblMoon3Notes.BorderStyle = BorderStyle.FixedSingle;
            lblMoon3Notes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon3Notes.Location = new Point(319, 602);
            lblMoon3Notes.Name = "lblMoon3Notes";
            lblMoon3Notes.Size = new Size(233, 98);
            lblMoon3Notes.TabIndex = 19;
            // 
            // lblMoon3Name
            // 
            lblMoon3Name.BackColor = Color.White;
            lblMoon3Name.BorderStyle = BorderStyle.FixedSingle;
            lblMoon3Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoon3Name.Location = new Point(319, 530);
            lblMoon3Name.Name = "lblMoon3Name";
            lblMoon3Name.Size = new Size(233, 70);
            lblMoon3Name.TabIndex = 18;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 711);
            Controls.Add(lblMoon3Notes);
            Controls.Add(lblMoon3Name);
            Controls.Add(lblMoon2Notes);
            Controls.Add(lblMoon2Name);
            Controls.Add(lblMoon1Notes);
            Controls.Add(lblMoon1Name);
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
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Talkatoo Moon Images";
            ((System.ComponentModel.ISupportInitialize)picMoon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMoon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMoon3).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private Label lblMoon1Name;
        private MenuStrip menuStrip;
        private ToolStripMenuItem tsiMoonNotes;
        private Label lblMoon1Notes;
        private Label lblMoon2Notes;
        private Label lblMoon2Name;
        private Label lblMoon3Notes;
        private Label lblMoon3Name;
    }
}