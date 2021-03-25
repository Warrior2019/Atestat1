
namespace Atestat
{
    partial class Incepe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incepe));
            this.Inceput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inceput
            // 
            this.Inceput.BackColor = System.Drawing.Color.Transparent;
            this.Inceput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Inceput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Inceput.Location = new System.Drawing.Point(12, 254);
            this.Inceput.Name = "Inceput";
            this.Inceput.Size = new System.Drawing.Size(283, 28);
            this.Inceput.TabIndex = 0;
            this.Inceput.Text = "Apasa aici pentru a incepe";
            this.Inceput.UseVisualStyleBackColor = false;
            this.Inceput.Click += new System.EventHandler(this.Inceput_Click);
            // 
            // Incepe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(318, 308);
            this.Controls.Add(this.Inceput);
            this.DoubleBuffered = true;
            this.Name = "Incepe";
            this.Text = "Inceput";
            this.Load += new System.EventHandler(this.Incepe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inceput;
    }
}

