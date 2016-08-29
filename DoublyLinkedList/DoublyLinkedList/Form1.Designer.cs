namespace DoublyLinkedList
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
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.inputEdit = new System.Windows.Forms.TextBox();
            this.travseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(307, 13);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Start List";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(307, 42);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(95, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(307, 71);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(95, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit Value";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(307, 100);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(95, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(197, 15);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Node Value:";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.Location = new System.Drawing.Point(88, 47);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(103, 13);
            this.editLabel.TabIndex = 8;
            this.editLabel.Text = "Node Edit Value:";
            this.editLabel.Visible = false;
            // 
            // inputEdit
            // 
            this.inputEdit.Location = new System.Drawing.Point(197, 44);
            this.inputEdit.Name = "inputEdit";
            this.inputEdit.Size = new System.Drawing.Size(100, 20);
            this.inputEdit.TabIndex = 7;
            this.inputEdit.Visible = false;
            // 
            // travseBtn
            // 
            this.travseBtn.Location = new System.Drawing.Point(307, 127);
            this.travseBtn.Name = "travseBtn";
            this.travseBtn.Size = new System.Drawing.Size(95, 23);
            this.travseBtn.TabIndex = 9;
            this.travseBtn.Text = "Traverse";
            this.travseBtn.UseVisualStyleBackColor = true;
            this.travseBtn.Visible = false;
            this.travseBtn.Click += new System.EventHandler(this.travseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 162);
            this.Controls.Add(this.travseBtn);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.inputEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.TextBox inputEdit;
        private System.Windows.Forms.Button travseBtn;
    }
}

