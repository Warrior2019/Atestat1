
namespace Atestat
{
    partial class F5
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Sevilla86 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Istoric";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "Echipa de start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sevilla86
            // 
            this.Sevilla86.Location = new System.Drawing.Point(12, 12);
            this.Sevilla86.Name = "Sevilla86";
            this.Sevilla86.ReadOnly = true;
            this.Sevilla86.Size = new System.Drawing.Size(776, 400);
            this.Sevilla86.TabIndex = 3;
            this.Sevilla86.Text = "";
            this.Sevilla86.TextChanged += new System.EventHandler(this.Sevilla86_TextChanged);
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sevilla86);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "F5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox Sevilla86;
    }
}