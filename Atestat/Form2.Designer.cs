
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
            this.Istoric = new System.Windows.Forms.Button();
            this.Prezente = new System.Windows.Forms.Button();
            this.Goluri = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            this.Sevilla86 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Istoric
            // 
            this.Istoric.Location = new System.Drawing.Point(43, 40);
            this.Istoric.Name = "Istoric";
            this.Istoric.Size = new System.Drawing.Size(85, 39);
            this.Istoric.TabIndex = 0;
            this.Istoric.Text = "Istoric";
            this.Istoric.UseVisualStyleBackColor = true;
            this.Istoric.Click += new System.EventHandler(this.Istoric_Click);
            // 
            // Prezente
            // 
            this.Prezente.Location = new System.Drawing.Point(225, 40);
            this.Prezente.Name = "Prezente";
            this.Prezente.Size = new System.Drawing.Size(85, 39);
            this.Prezente.TabIndex = 1;
            this.Prezente.Text = "Prezente";
            this.Prezente.UseVisualStyleBackColor = true;
            // 
            // Goluri
            // 
            this.Goluri.Location = new System.Drawing.Point(134, 40);
            this.Goluri.Name = "Goluri";
            this.Goluri.Size = new System.Drawing.Size(85, 39);
            this.Goluri.TabIndex = 3;
            this.Goluri.Text = "Goluri";
            this.Goluri.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.Quiz.Location = new System.Drawing.Point(407, 40);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(75, 39);
            this.Quiz.TabIndex = 5;
            this.Quiz.Text = "Quiz";
            this.Quiz.UseVisualStyleBackColor = true;
            this.Quiz.Click += new System.EventHandler(this.Quiz_Click);
            // 
            // Sevilla86
            // 
            this.Sevilla86.Location = new System.Drawing.Point(316, 40);
            this.Sevilla86.Name = "Sevilla86";
            this.Sevilla86.Size = new System.Drawing.Size(85, 39);
            this.Sevilla86.TabIndex = 6;
            this.Sevilla86.Text = "Sevilla86";
            this.Sevilla86.UseVisualStyleBackColor = true;
            this.Sevilla86.Click += new System.EventHandler(this.Sevilla86_Click);
            // 
            // F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 490);
            this.Controls.Add(this.Sevilla86);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.Goluri);
            this.Controls.Add(this.Prezente);
            this.Controls.Add(this.Istoric);
            this.Name = "F2";
            this.Text = "Fereastra2";
            this.Load += new System.EventHandler(this.F2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Istoric;
        private System.Windows.Forms.Button Prezente;
        private System.Windows.Forms.Button Goluri;
        private System.Windows.Forms.Button Quiz;
        private System.Windows.Forms.Button Sevilla86;
    }
}