
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
            this.Sevilla86 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Istoric = new System.Windows.Forms.Label();
            this.Quiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sevilla86
            // 
            this.Sevilla86.Location = new System.Drawing.Point(676, 331);
            this.Sevilla86.Name = "Sevilla86";
            this.Sevilla86.Size = new System.Drawing.Size(85, 39);
            this.Sevilla86.TabIndex = 6;
            this.Sevilla86.Text = "Sevilla86";
            this.Sevilla86.UseVisualStyleBackColor = true;
            this.Sevilla86.Click += new System.EventHandler(this.Sevilla86_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Jucători importanți";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Istoric
            // 
            this.Istoric.AutoSize = true;
            this.Istoric.Location = new System.Drawing.Point(89, 159);
            this.Istoric.Name = "Istoric";
            this.Istoric.Size = new System.Drawing.Size(35, 13);
            this.Istoric.TabIndex = 8;
            this.Istoric.Text = "Istoric";
            this.Istoric.Click += new System.EventHandler(this.label1_Click);
            // 
            // Quiz
            // 
            this.Quiz.AutoSize = true;
            this.Quiz.Location = new System.Drawing.Point(28, 245);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(28, 13);
            this.Quiz.TabIndex = 9;
            this.Quiz.Text = "Quiz";
            this.Quiz.Click += new System.EventHandler(this.label2_Click);
            // 
            // F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 559);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.Istoric);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sevilla86);
            this.DoubleBuffered = true;
            this.Name = "F2";
            this.Text = "Fereastra2";
            this.Load += new System.EventHandler(this.F2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sevilla86;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Istoric;
        private System.Windows.Forms.Label Quiz;
    }
}