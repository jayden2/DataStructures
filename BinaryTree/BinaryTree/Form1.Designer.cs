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
            this.dataText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchEdit = new System.Windows.Forms.Button();
            this.inorder_btn = new System.Windows.Forms.Button();
            this.preorder_btn = new System.Windows.Forms.Button();
            this.postorder_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addValue
            // 
            this.addValue.Location = new System.Drawing.Point(460, 12);
            this.addValue.Name = "addValue";
            this.addValue.Size = new System.Drawing.Size(99, 23);
            this.addValue.TabIndex = 0;
            this.addValue.Text = "Start Tree";
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
            // dataText
            // 
            this.dataText.Location = new System.Drawing.Point(338, 44);
            this.dataText.Name = "dataText";
            this.dataText.Size = new System.Drawing.Size(116, 20);
            this.dataText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "node value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "node data";
            // 
            // searchEdit
            // 
            this.searchEdit.Location = new System.Drawing.Point(460, 99);
            this.searchEdit.Name = "searchEdit";
            this.searchEdit.Size = new System.Drawing.Size(99, 23);
            this.searchEdit.TabIndex = 7;
            this.searchEdit.Text = "Search and Edit";
            this.searchEdit.UseVisualStyleBackColor = true;
            this.searchEdit.Visible = false;
            this.searchEdit.Click += new System.EventHandler(this.searchEdit_Click);
            // 
            // inorder_btn
            // 
            this.inorder_btn.Location = new System.Drawing.Point(12, 9);
            this.inorder_btn.Name = "inorder_btn";
            this.inorder_btn.Size = new System.Drawing.Size(109, 23);
            this.inorder_btn.TabIndex = 8;
            this.inorder_btn.Text = "Traverse Inorder";
            this.inorder_btn.UseVisualStyleBackColor = true;
            this.inorder_btn.Visible = false;
            this.inorder_btn.Click += new System.EventHandler(this.inorder_btn_Click);
            // 
            // preorder_btn
            // 
            this.preorder_btn.Location = new System.Drawing.Point(12, 37);
            this.preorder_btn.Name = "preorder_btn";
            this.preorder_btn.Size = new System.Drawing.Size(109, 23);
            this.preorder_btn.TabIndex = 9;
            this.preorder_btn.Text = "Traverse Preorder";
            this.preorder_btn.UseVisualStyleBackColor = true;
            this.preorder_btn.Visible = false;
            this.preorder_btn.Click += new System.EventHandler(this.preorder_btn_Click);
            // 
            // postorder_btn
            // 
            this.postorder_btn.Location = new System.Drawing.Point(12, 66);
            this.postorder_btn.Name = "postorder_btn";
            this.postorder_btn.Size = new System.Drawing.Size(109, 23);
            this.postorder_btn.TabIndex = 10;
            this.postorder_btn.Text = "Traverse Postorder";
            this.postorder_btn.UseVisualStyleBackColor = true;
            this.postorder_btn.Visible = false;
            this.postorder_btn.Click += new System.EventHandler(this.postorder_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 134);
            this.Controls.Add(this.postorder_btn);
            this.Controls.Add(this.preorder_btn);
            this.Controls.Add(this.inorder_btn);
            this.Controls.Add(this.searchEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataText);
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
        private System.Windows.Forms.TextBox dataText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchEdit;
        private System.Windows.Forms.Button inorder_btn;
        private System.Windows.Forms.Button preorder_btn;
        private System.Windows.Forms.Button postorder_btn;
    }
}

