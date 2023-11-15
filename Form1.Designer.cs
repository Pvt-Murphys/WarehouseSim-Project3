namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadinganimationgif = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadinganimationgif)).BeginInit();
            this.SuspendLayout();
            // 
            // loadinganimationgif
            // 
            this.loadinganimationgif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadinganimationgif.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.loadinganimationgif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadinganimationgif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadinganimationgif.Image = ((System.Drawing.Image)(resources.GetObject("loadinganimationgif.Image")));
            this.loadinganimationgif.Location = new System.Drawing.Point(218, 58);
            this.loadinganimationgif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadinganimationgif.Name = "loadinganimationgif";
            this.loadinganimationgif.Size = new System.Drawing.Size(157, 170);
            this.loadinganimationgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadinganimationgif.TabIndex = 0;
            this.loadinganimationgif.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 246);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(510, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "THE ULTIMATE TRUCK UNLOADING SIMULATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadinganimationgif);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Shipping Sim.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadinganimationgif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox loadinganimationgif;
        private System.Windows.Forms.TextBox textBox1;
    }
}

