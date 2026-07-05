namespace MyFirstWindowsFormsApplication
{
    partial class frmMessageBox
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
            this.BtnShowMessageBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowMessageBox
            // 
            this.BtnShowMessageBox.Location = new System.Drawing.Point(57, 68);
            this.BtnShowMessageBox.Name = "BtnShowMessageBox";
            this.BtnShowMessageBox.Size = new System.Drawing.Size(184, 61);
            this.BtnShowMessageBox.TabIndex = 0;
            this.BtnShowMessageBox.Text = "Show Message Box";
            this.BtnShowMessageBox.UseVisualStyleBackColor = true;
            this.BtnShowMessageBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Message Box with Title";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Message Box with Title and Buttons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Message Box with Title and Buttons And Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnShowMessageBox);
            this.Name = "frmMessageBox";
            this.Text = "frmMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowMessageBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}