
namespace Atestat
{
    partial class F2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F2));
            this.Istoric = new System.Windows.Forms.Label();
            this.Quiz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sevilla86 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Istoric
            // 
            this.Istoric.AutoSize = true;
            this.Istoric.BackColor = System.Drawing.Color.Transparent;
            this.Istoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Istoric.Location = new System.Drawing.Point(12, 9);
            this.Istoric.Name = "Istoric";
            this.Istoric.Size = new System.Drawing.Size(39, 15);
            this.Istoric.TabIndex = 8;
            this.Istoric.Text = "Istoric";
            this.Istoric.Click += new System.EventHandler(this.label1_Click);
            // 
            // Quiz
            // 
            this.Quiz.AutoSize = true;
            this.Quiz.BackColor = System.Drawing.Color.Transparent;
            this.Quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz.Location = new System.Drawing.Point(57, 9);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(32, 15);
            this.Quiz.TabIndex = 9;
            this.Quiz.Text = "Quiz";
            this.Quiz.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jucători importanți";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Sevilla86
            // 
            this.Sevilla86.AutoSize = true;
            this.Sevilla86.BackColor = System.Drawing.Color.Transparent;
            this.Sevilla86.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sevilla86.Location = new System.Drawing.Point(209, 9);
            this.Sevilla86.Name = "Sevilla86";
            this.Sevilla86.Size = new System.Drawing.Size(57, 15);
            this.Sevilla86.TabIndex = 11;
            this.Sevilla86.Text = "Sevilla86";
            this.Sevilla86.Click += new System.EventHandler(this.Sevilla86_Click_1);
            // 
            // F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 559);
            this.Controls.Add(this.Sevilla86);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.Istoric);
            this.DoubleBuffered = true;
            this.Name = "F2";
            this.Load += new System.EventHandler(this.F2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Istoric;
        private System.Windows.Forms.Label Quiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Sevilla86;
    }
}