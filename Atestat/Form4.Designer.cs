
namespace Atestat
{
    partial class F4
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
            this.Istoric_text = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Istoric_text
            // 
            this.Istoric_text.Location = new System.Drawing.Point(12, 12);
            this.Istoric_text.Name = "Istoric_text";
            this.Istoric_text.ReadOnly = true;
            this.Istoric_text.Size = new System.Drawing.Size(776, 426);
            this.Istoric_text.TabIndex = 0;
            this.Istoric_text.Text = "";
            this.Istoric_text.TextChanged += new System.EventHandler(this.Istoric_text_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Despre Steaua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // F4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Istoric_text);
            this.Name = "F4";
            this.Text = "Istoric";
            this.Load += new System.EventHandler(this.F4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Istoric_text;
        private System.Windows.Forms.Button button1;
    }
}