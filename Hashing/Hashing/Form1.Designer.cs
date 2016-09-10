namespace Hashing
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
            this.arrayHash_btn = new System.Windows.Forms.Button();
            this.listHash_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayHash_btn
            // 
            this.arrayHash_btn.Location = new System.Drawing.Point(249, 12);
            this.arrayHash_btn.Name = "arrayHash_btn";
            this.arrayHash_btn.Size = new System.Drawing.Size(127, 23);
            this.arrayHash_btn.TabIndex = 0;
            this.arrayHash_btn.Text = "Array to HashTable";
            this.arrayHash_btn.UseVisualStyleBackColor = true;
            this.arrayHash_btn.Click += new System.EventHandler(this.arrayHash_btn_Click);
            // 
            // listHash_btn
            // 
            this.listHash_btn.Location = new System.Drawing.Point(249, 41);
            this.listHash_btn.Name = "listHash_btn";
            this.listHash_btn.Size = new System.Drawing.Size(127, 23);
            this.listHash_btn.TabIndex = 1;
            this.listHash_btn.Text = "List HashTable";
            this.listHash_btn.UseVisualStyleBackColor = true;
            this.listHash_btn.Click += new System.EventHandler(this.listHash_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 272);
            this.Controls.Add(this.listHash_btn);
            this.Controls.Add(this.arrayHash_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button arrayHash_btn;
        private System.Windows.Forms.Button listHash_btn;
    }
}

