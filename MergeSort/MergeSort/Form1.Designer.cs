namespace MergeSort
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
            this.sort_btn = new System.Windows.Forms.Button();
            this.num_input = new System.Windows.Forms.NumericUpDown();
            this.unsorted_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sorted_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_input)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Many Random Numbers?";
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(340, 57);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(75, 23);
            this.sort_btn.TabIndex = 2;
            this.sort_btn.Text = "Merge Sort";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // num_input
            // 
            this.num_input.Location = new System.Drawing.Point(295, 32);
            this.num_input.Name = "num_input";
            this.num_input.Size = new System.Drawing.Size(120, 20);
            this.num_input.TabIndex = 3;
            this.num_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // unsorted_lbl
            // 
            this.unsorted_lbl.AutoSize = true;
            this.unsorted_lbl.Location = new System.Drawing.Point(55, 104);
            this.unsorted_lbl.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.unsorted_lbl.MaximumSize = new System.Drawing.Size(500, 0);
            this.unsorted_lbl.MinimumSize = new System.Drawing.Size(500, 0);
            this.unsorted_lbl.Name = "unsorted_lbl";
            this.unsorted_lbl.Size = new System.Drawing.Size(500, 13);
            this.unsorted_lbl.TabIndex = 4;
            this.unsorted_lbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unsorted Array:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sorted Array:";
            // 
            // sorted_lbl
            // 
            this.sorted_lbl.AutoSize = true;
            this.sorted_lbl.Location = new System.Drawing.Point(55, 168);
            this.sorted_lbl.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.sorted_lbl.MaximumSize = new System.Drawing.Size(500, 0);
            this.sorted_lbl.MinimumSize = new System.Drawing.Size(500, 0);
            this.sorted_lbl.Name = "sorted_lbl";
            this.sorted_lbl.Size = new System.Drawing.Size(500, 13);
            this.sorted_lbl.TabIndex = 6;
            this.sorted_lbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sorted_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unsorted_lbl);
            this.Controls.Add(this.num_input);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.NumericUpDown num_input;
        private System.Windows.Forms.Label unsorted_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sorted_lbl;
    }
}

