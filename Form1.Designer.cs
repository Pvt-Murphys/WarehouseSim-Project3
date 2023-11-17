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
            this.GoToSimulation = new WindowsFormsApp1.CustomButton();
            this.loadinganimationgif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadinganimationgif)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToSimulation
            // 
            this.GoToSimulation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoToSimulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.GoToSimulation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.GoToSimulation.BorderColor = System.Drawing.Color.Yellow;
            this.GoToSimulation.BorderRadius = 15;
            this.GoToSimulation.BorderSize = 0;
            this.GoToSimulation.FlatAppearance.BorderSize = 0;
            this.GoToSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToSimulation.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSimulation.ForeColor = System.Drawing.Color.Gainsboro;
            this.GoToSimulation.Location = new System.Drawing.Point(199, 207);
            this.GoToSimulation.Name = "GoToSimulation";
            this.GoToSimulation.Size = new System.Drawing.Size(179, 48);
            this.GoToSimulation.TabIndex = 3;
            this.GoToSimulation.Text = "Simulation";
            this.GoToSimulation.TextColor = System.Drawing.Color.Gainsboro;
            this.GoToSimulation.UseVisualStyleBackColor = false;
            this.GoToSimulation.Click += new System.EventHandler(this.GoToSimulation_Click);
            // 
            // loadinganimationgif
            // 
            this.loadinganimationgif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadinganimationgif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.loadinganimationgif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadinganimationgif.Image = ((System.Drawing.Image)(resources.GetObject("loadinganimationgif.Image")));
            this.loadinganimationgif.Location = new System.Drawing.Point(191, 44);
            this.loadinganimationgif.Margin = new System.Windows.Forms.Padding(0);
            this.loadinganimationgif.Name = "loadinganimationgif";
            this.loadinganimationgif.Size = new System.Drawing.Size(187, 160);
            this.loadinganimationgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadinganimationgif.TabIndex = 4;
            this.loadinganimationgif.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.loadinganimationgif);
            this.Controls.Add(this.GoToSimulation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Shipping Sim.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadinganimationgif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton GoToSimulation;
        public System.Windows.Forms.PictureBox loadinganimationgif;
    }
}

