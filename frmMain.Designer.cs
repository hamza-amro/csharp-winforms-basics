namespace MyFirstWindowsFormsApplication
{
    partial class frmMain
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
            this.BtnShowPart1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowPart1
            // 
            this.BtnShowPart1.Location = new System.Drawing.Point(55, 73);
            this.BtnShowPart1.Name = "BtnShowPart1";
            this.BtnShowPart1.Size = new System.Drawing.Size(155, 66);
            this.BtnShowPart1.TabIndex = 0;
            this.BtnShowPart1.Text = "Show Form";
            this.BtnShowPart1.UseVisualStyleBackColor = true;
            this.BtnShowPart1.Click += new System.EventHandler(this.BtnShowPart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Form as DiaLog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMessageBox
            // 
            this.BtnMessageBox.Location = new System.Drawing.Point(228, 73);
            this.BtnMessageBox.Name = "BtnMessageBox";
            this.BtnMessageBox.Size = new System.Drawing.Size(155, 66);
            this.BtnMessageBox.TabIndex = 2;
            this.BtnMessageBox.Text = "Show Message box Form as DiaLog";
            this.BtnMessageBox.UseVisualStyleBackColor = true;
            this.BtnMessageBox.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMessageBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnShowPart1);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowPart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnMessageBox;
    }
}