namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EnterNumber = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClearTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(143, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(778, 422);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.MenuPanel.Controls.Add(this.EnterNumber);
            this.MenuPanel.Controls.Add(this.textBox1);
            this.MenuPanel.Controls.Add(this.ClearTable);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(143, 422);
            this.MenuPanel.TabIndex = 6;
            // 
            // EnterNumber
            // 
            this.EnterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.EnterNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnterNumber.FlatAppearance.BorderSize = 0;
            this.EnterNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.EnterNumber.Location = new System.Drawing.Point(0, 0);
            this.EnterNumber.Margin = new System.Windows.Forms.Padding(0);
            this.EnterNumber.Name = "EnterNumber";
            this.EnterNumber.Size = new System.Drawing.Size(143, 40);
            this.EnterNumber.TabIndex = 2;
            this.EnterNumber.Text = "Run Simulation";
            this.EnterNumber.UseVisualStyleBackColor = false;
            this.EnterNumber.Click += new System.EventHandler(this.EnterNumber_Click);
            this.EnterNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterNumber_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(0, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = " ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // ClearTable
            // 
            this.ClearTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.ClearTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearTable.FlatAppearance.BorderSize = 0;
            this.ClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTable.ForeColor = System.Drawing.Color.Gainsboro;
            this.ClearTable.Location = new System.Drawing.Point(0, 60);
            this.ClearTable.Margin = new System.Windows.Forms.Padding(0);
            this.ClearTable.Name = "ClearTable";
            this.ClearTable.Size = new System.Drawing.Size(143, 40);
            this.ClearTable.TabIndex = 5;
            this.ClearTable.Text = "Clear Table";
            this.ClearTable.UseVisualStyleBackColor = false;
            this.ClearTable.Click += new System.EventHandler(this.ClearTable_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 422);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Sim. Results";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EnterNumber;
        private System.Windows.Forms.Button ClearTable;
    }
}