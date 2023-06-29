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
            btnSave = new Button();
            picImage = new PictureBox();
            lblHeading = new Label();
            txtNotes = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(318, 184);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(233, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.White;
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(12, 38);
            picImage.Name = "picImage";
            picImage.Size = new Size(300, 169);
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(12, 10);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(131, 21);
            lblHeading.TabIndex = 3;
            lblHeading.Text = "Cascade Moon 3";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(318, 38);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(233, 140);
            txtNotes.TabIndex = 13;
            // 
            // MoonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 221);
            Controls.Add(txtNotes);
            Controls.Add(lblHeading);
            Controls.Add(picImage);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MoonForm";
            Text = "Edit Moon Details";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private PictureBox picImage;
        private Label lblHeading;
        private TextBox txtNotes;
    }
}