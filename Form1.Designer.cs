
namespace DWS
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
            this.coordinates_btn = new System.Windows.Forms.Button();
            this.windowed_btn = new System.Windows.Forms.Button();
            this.none_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coordinates_btn
            // 
            this.coordinates_btn.Location = new System.Drawing.Point(12, 12);
            this.coordinates_btn.Name = "coordinates_btn";
            this.coordinates_btn.Size = new System.Drawing.Size(90, 46);
            this.coordinates_btn.TabIndex = 0;
            this.coordinates_btn.Text = "Coordinates";
            this.coordinates_btn.UseVisualStyleBackColor = true;
            this.coordinates_btn.Click += new System.EventHandler(this.coordinates_btn_Click);
            // 
            // windowed_btn
            // 
            this.windowed_btn.Location = new System.Drawing.Point(133, 12);
            this.windowed_btn.Name = "windowed_btn";
            this.windowed_btn.Size = new System.Drawing.Size(90, 46);
            this.windowed_btn.TabIndex = 1;
            this.windowed_btn.Text = "Windowed";
            this.windowed_btn.UseVisualStyleBackColor = true;
            this.windowed_btn.Click += new System.EventHandler(this.windowed_btn_Click);
            // 
            // none_btn
            // 
            this.none_btn.Location = new System.Drawing.Point(12, 92);
            this.none_btn.Name = "none_btn";
            this.none_btn.Size = new System.Drawing.Size(90, 46);
            this.none_btn.TabIndex = 2;
            this.none_btn.Text = "None";
            this.none_btn.UseVisualStyleBackColor = true;
            this.none_btn.Click += new System.EventHandler(this.none_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 163);
            this.Controls.Add(this.none_btn);
            this.Controls.Add(this.windowed_btn);
            this.Controls.Add(this.coordinates_btn);
            this.Name = "Form1";
            this.Text = "DWS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button coordinates_btn;
        private System.Windows.Forms.Button windowed_btn;
        private System.Windows.Forms.Button none_btn;
    }
}

