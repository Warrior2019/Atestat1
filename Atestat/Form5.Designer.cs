
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F5));
            this.button2 = new System.Windows.Forms.Button();
            this.Sevilla86 = new System.Windows.Forms.RichTextBox();
            this.pb_Sevilla86 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Video = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sevilla86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(162, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Istoric";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sevilla86
            // 
            this.Sevilla86.BackColor = System.Drawing.SystemColors.Highlight;
            this.Sevilla86.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sevilla86.Location = new System.Drawing.Point(12, 12);
            this.Sevilla86.Name = "Sevilla86";
            this.Sevilla86.ReadOnly = true;
            this.Sevilla86.Size = new System.Drawing.Size(776, 401);
            this.Sevilla86.TabIndex = 3;
            this.Sevilla86.Text = "";
            this.Sevilla86.Visible = false;
            this.Sevilla86.TextChanged += new System.EventHandler(this.Sevilla86_TextChanged);
            // 
            // pb_Sevilla86
            // 
            this.pb_Sevilla86.Location = new System.Drawing.Point(12, 12);
            this.pb_Sevilla86.Name = "pb_Sevilla86";
            this.pb_Sevilla86.Size = new System.Drawing.Size(776, 370);
            this.pb_Sevilla86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Sevilla86.TabIndex = 4;
            this.pb_Sevilla86.TabStop = false;
            this.pb_Sevilla86.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(324, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Echipa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(634, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 19);
            this.button5.TabIndex = 6;
            this.button5.Text = "Iesire";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sus: Boloni, Belodedici, Iovan, Pițurcă, Bumbescu, Duckadam\r\nJos:  Majearu, Lăcăt" +
    "uș, Bălan, Blaint, Bărbulescu\r\n";
            this.label1.Visible = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(489, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 19);
            this.button3.TabIndex = 8;
            this.button3.Text = "Penalty-urile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Video
            // 
            this.Video.Enabled = true;
            this.Video.Location = new System.Drawing.Point(12, 12);
            this.Video.Name = "Video";
            this.Video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Video.OcxState")));
            this.Video.Size = new System.Drawing.Size(776, 399);
            this.Video.TabIndex = 9;
            this.Video.Visible = false;
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_Sevilla86);
            this.Controls.Add(this.Sevilla86);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sevilla86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Sevilla86;
        private System.Windows.Forms.PictureBox pb_Sevilla86;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private AxWMPLib.AxWindowsMediaPlayer Video;
    }
}