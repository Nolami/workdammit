namespace workdammit
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
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.WorkLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.Location = new System.Drawing.Point(92, 116);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(75, 23);
            this.VaihdaBT.TabIndex = 0;
            this.VaihdaBT.Text = "Work!";
            this.VaihdaBT.UseVisualStyleBackColor = true;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // WorkLB
            // 
            this.WorkLB.AutoSize = true;
            this.WorkLB.Location = new System.Drawing.Point(92, 54);
            this.WorkLB.Name = "WorkLB";
            this.WorkLB.Size = new System.Drawing.Size(56, 15);
            this.WorkLB.TabIndex = 1;
            this.WorkLB.Text = "No world";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkLB);
            this.Controls.Add(this.VaihdaBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button VaihdaBT;
        private Label WorkLB;
    }
}