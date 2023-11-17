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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnterNumber = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExportFile = new System.Windows.Forms.Button();
            this.ClearTable = new System.Windows.Forms.Button();
            this.loadinganimationgif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadinganimationgif)).BeginInit();
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
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.EnterNumber);
            this.MenuPanel.Controls.Add(this.textBox1);
            this.MenuPanel.Controls.Add(this.ExportFile);
            this.MenuPanel.Controls.Add(this.ClearTable);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(143, 422);
            this.MenuPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.loadinganimationgif);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EnterNumber
            // 
            this.EnterNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnterNumber.FlatAppearance.BorderSize = 0;
            this.EnterNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.EnterNumber.Location = new System.Drawing.Point(0, 67);
            this.EnterNumber.Margin = new System.Windows.Forms.Padding(0);
            this.EnterNumber.Name = "EnterNumber";
            this.EnterNumber.Size = new System.Drawing.Size(143, 40);
            this.EnterNumber.TabIndex = 2;
            this.EnterNumber.Text = "Run Simulation";
            this.EnterNumber.UseVisualStyleBackColor = true;
            this.EnterNumber.Click += new System.EventHandler(this.EnterNumber_Click);
            this.EnterNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterNumber_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(0, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = " ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // ExportFile
            // 
            this.ExportFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExportFile.FlatAppearance.BorderSize = 0;
            this.ExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExportFile.Location = new System.Drawing.Point(0, 127);
            this.ExportFile.Margin = new System.Windows.Forms.Padding(0);
            this.ExportFile.Name = "ExportFile";
            this.ExportFile.Size = new System.Drawing.Size(143, 40);
            this.ExportFile.TabIndex = 4;
            this.ExportFile.Text = "Export file\r\n";
            this.ExportFile.UseVisualStyleBackColor = true;
            this.ExportFile.Click += new System.EventHandler(this.ExportFile_Click);
            // 
            // ClearTable
            // 
            this.ClearTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearTable.FlatAppearance.BorderSize = 0;
            this.ClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTable.ForeColor = System.Drawing.Color.Gainsboro;
            this.ClearTable.Location = new System.Drawing.Point(0, 167);
            this.ClearTable.Margin = new System.Windows.Forms.Padding(0);
            this.ClearTable.Name = "ClearTable";
            this.ClearTable.Size = new System.Drawing.Size(143, 40);
            this.ClearTable.TabIndex = 5;
            this.ClearTable.Text = "Clear Table";
            this.ClearTable.UseVisualStyleBackColor = true;
            this.ClearTable.Click += new System.EventHandler(this.ClearTable_Click);
            // 
            // loadinganimationgif
            // 
            this.loadinganimationgif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadinganimationgif.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadinganimationgif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadinganimationgif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadinganimationgif.Image = ((System.Drawing.Image)(resources.GetObject("loadinganimationgif.Image")));
            this.loadinganimationgif.Location = new System.Drawing.Point(-52, 0);
            this.loadinganimationgif.Margin = new System.Windows.Forms.Padding(0);
            this.loadinganimationgif.Name = "loadinganimationgif";
            this.loadinganimationgif.Size = new System.Drawing.Size(216, 67);
            this.loadinganimationgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadinganimationgif.TabIndex = 1;
            this.loadinganimationgif.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 422);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Sim. Results";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadinganimationgif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EnterNumber;
        private System.Windows.Forms.Button ExportFile;
        private System.Windows.Forms.Button ClearTable;
        public System.Windows.Forms.PictureBox loadinganimationgif;
    }
}