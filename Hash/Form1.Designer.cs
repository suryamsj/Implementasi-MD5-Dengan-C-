
namespace Hash
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TulisanNormal = new System.Windows.Forms.TextBox();
            this.TulisanMD5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tulisan normal";
            // 
            // TulisanNormal
            // 
            this.TulisanNormal.Location = new System.Drawing.Point(15, 46);
            this.TulisanNormal.Name = "TulisanNormal";
            this.TulisanNormal.Size = new System.Drawing.Size(407, 22);
            this.TulisanNormal.TabIndex = 1;
            // 
            // TulisanMD5
            // 
            this.TulisanMD5.Location = new System.Drawing.Point(15, 110);
            this.TulisanMD5.Name = "TulisanMD5";
            this.TulisanMD5.Size = new System.Drawing.Size(407, 22);
            this.TulisanMD5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MD5";
            // 
            // Hash
            // 
            this.Hash.Location = new System.Drawing.Point(315, 147);
            this.Hash.Name = "Hash";
            this.Hash.Size = new System.Drawing.Size(107, 40);
            this.Hash.TabIndex = 4;
            this.Hash.Text = "button1";
            this.Hash.UseVisualStyleBackColor = true;
            this.Hash.Click += new System.EventHandler(this.Hash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 210);
            this.Controls.Add(this.Hash);
            this.Controls.Add(this.TulisanMD5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TulisanNormal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TulisanNormal;
        private System.Windows.Forms.TextBox TulisanMD5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Hash;
    }
}

