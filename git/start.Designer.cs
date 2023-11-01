
namespace git
{
    partial class start
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
            this.title = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(312, 183);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(170, 51);
            this.title.TabIndex = 0;
            this.title.Text = "色当てゲーム";
            this.title.UseVisualStyleBackColor = true;
            this.title.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Name = "start";
            this.Text = "start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button title;
    }
}