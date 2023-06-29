namespace TalkatooMoonImages
{
    partial class MoonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoonForm));
            btnCancel = new Button();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            lblMoonHeading = new Label();
            lblMoonName = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(396, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(477, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 169);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblMoonHeading
            // 
            lblMoonHeading.AutoSize = true;
            lblMoonHeading.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoonHeading.Location = new Point(12, 10);
            lblMoonHeading.Name = "lblMoonHeading";
            lblMoonHeading.Size = new Size(131, 21);
            lblMoonHeading.TabIndex = 3;
            lblMoonHeading.Text = "Cascade Moon 3";
            // 
            // lblMoonName
            // 
            lblMoonName.BackColor = Color.White;
            lblMoonName.BorderStyle = BorderStyle.FixedSingle;
            lblMoonName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoonName.Location = new Point(319, 38);
            lblMoonName.Name = "lblMoonName";
            lblMoonName.Size = new Size(233, 70);
            lblMoonName.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 96);
            textBox1.TabIndex = 13;
            // 
            // MoonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 221);
            Controls.Add(textBox1);
            Controls.Add(lblMoonName);
            Controls.Add(lblMoonHeading);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MoonForm";
            Text = "Edit Moon Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private PictureBox pictureBox1;
        private Label lblMoonHeading;
        private Label lblMoonName;
        private TextBox textBox1;
    }
}