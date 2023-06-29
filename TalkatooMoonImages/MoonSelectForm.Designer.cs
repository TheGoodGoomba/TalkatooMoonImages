namespace TalkatooMoonImages
{
    partial class MoonSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoonSelectForm));
            lblKingdom = new Label();
            nudMoonNumber = new NumericUpDown();
            label1 = new Label();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMoonNumber).BeginInit();
            SuspendLayout();
            // 
            // lblKingdom
            // 
            lblKingdom.AutoSize = true;
            lblKingdom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblKingdom.Location = new Point(12, 9);
            lblKingdom.Name = "lblKingdom";
            lblKingdom.Size = new Size(107, 19);
            lblKingdom.TabIndex = 0;
            lblKingdom.Text = "Cascade moon: ";
            // 
            // nudMoonNumber
            // 
            nudMoonNumber.Location = new Point(174, 8);
            nudMoonNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMoonNumber.Name = "nudMoonNumber";
            nudMoonNumber.Size = new Size(42, 23);
            nudMoonNumber.TabIndex = 1;
            nudMoonNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 2;
            label1.Text = "(Select kingdom on the main window)";
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(12, 58);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(204, 23);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // MoonSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 91);
            Controls.Add(btnContinue);
            Controls.Add(label1);
            Controls.Add(nudMoonNumber);
            Controls.Add(lblKingdom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MoonSelectForm";
            Text = "Moon Select";
            ((System.ComponentModel.ISupportInitialize)nudMoonNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKingdom;
        private NumericUpDown nudMoonNumber;
        private Label label1;
        private Button btnContinue;
    }
}