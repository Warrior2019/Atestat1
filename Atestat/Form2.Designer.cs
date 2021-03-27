
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
            this.Istoric = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            this.Sevilla86 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Istoric
            // 
            this.Istoric.Location = new System.Drawing.Point(1, 1);
            this.Istoric.Name = "Istoric";
            this.Istoric.Size = new System.Drawing.Size(46, 24);
            this.Istoric.TabIndex = 0;
            this.Istoric.Text = "Istoric";
            this.Istoric.UseVisualStyleBackColor = true;
            this.Istoric.Click += new System.EventHandler(this.Istoric_Click);
            // 
            // Quiz
            // 
            this.Quiz.Location = new System.Drawing.Point(92, 359);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(75, 39);
            this.Quiz.TabIndex = 5;
            this.Quiz.Text = "Quiz";
            this.Quiz.UseVisualStyleBackColor = true;
            this.Quiz.Click += new System.EventHandler(this.Quiz_Click);
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
            // F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sevilla86);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.Istoric);
            this.DoubleBuffered = true;
            this.Name = "F2";
            this.Text = "Fereastra2";
            this.Load += new System.EventHandler(this.F2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Istoric;
        private System.Windows.Forms.Button Quiz;
        private System.Windows.Forms.Button Sevilla86;
        private System.Windows.Forms.Button button1;
    }
}