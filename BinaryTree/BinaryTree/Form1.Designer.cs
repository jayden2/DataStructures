namespace BinaryTree
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
            this.addValue = new System.Windows.Forms.Button();
            this.numText = new System.Windows.Forms.TextBox();
            this.searchValue = new System.Windows.Forms.Button();
            this.deleteValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addValue
            // 
            this.addValue.Location = new System.Drawing.Point(460, 12);
            this.addValue.Name = "addValue";
            this.addValue.Size = new System.Drawing.Size(99, 23);
            this.addValue.TabIndex = 0;
            this.addValue.Text = "Add Value";
            this.addValue.UseVisualStyleBackColor = true;
            this.addValue.Click += new System.EventHandler(this.addValue_Click);
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(338, 15);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(116, 20);
            this.numText.TabIndex = 1;
            // 
            // searchValue
            // 
            this.searchValue.Location = new System.Drawing.Point(460, 41);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(99, 23);
            this.searchValue.TabIndex = 2;
            this.searchValue.Text = "Search Value";
            this.searchValue.UseVisualStyleBackColor = true;
            this.searchValue.Visible = false;
            this.searchValue.Click += new System.EventHandler(this.searchValue_Click);
            // 
            // deleteValue
            // 
            this.deleteValue.Location = new System.Drawing.Point(460, 70);
            this.deleteValue.Name = "deleteValue";
            this.deleteValue.Size = new System.Drawing.Size(99, 23);
            this.deleteValue.TabIndex = 3;
            this.deleteValue.Text = "Delete Value";
            this.deleteValue.UseVisualStyleBackColor = true;
            this.deleteValue.Visible = false;
            this.deleteValue.Click += new System.EventHandler(this.deleteValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 480);
            this.Controls.Add(this.deleteValue);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.addValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addValue;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.Button searchValue;
        private System.Windows.Forms.Button deleteValue;
    }
}

