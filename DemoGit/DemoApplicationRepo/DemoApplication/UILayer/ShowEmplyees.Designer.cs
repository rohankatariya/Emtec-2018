namespace UILayer
{
    partial class ShowEmplyees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Navbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Navbtn
            // 
            this.Navbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Navbtn.Location = new System.Drawing.Point(288, 233);
            this.Navbtn.Name = "Navbtn";
            this.Navbtn.Size = new System.Drawing.Size(179, 35);
            this.Navbtn.TabIndex = 31;
            this.Navbtn.Text = "Go to navigation page";
            this.Navbtn.UseVisualStyleBackColor = true;
            this.Navbtn.Click += new System.EventHandler(this.Navbtn_Click);
            // 
            // ShowEmplyees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 555);
            this.Controls.Add(this.Navbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowEmplyees";
            this.Text = "ShowEmplyees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Navbtn;
    }
}