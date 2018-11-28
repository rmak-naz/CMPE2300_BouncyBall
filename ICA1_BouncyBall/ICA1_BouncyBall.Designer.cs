namespace ICA1_BouncyBall
{
    partial class ICA1_BouncyBall
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
            this.components = new System.ComponentModel.Container();
            this.B_RandBall = new System.Windows.Forms.Button();
            this.B_HyperBall = new System.Windows.Forms.Button();
            this.Bounce_Intrvl = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // B_RandBall
            // 
            this.B_RandBall.Location = new System.Drawing.Point(13, 13);
            this.B_RandBall.Name = "B_RandBall";
            this.B_RandBall.Size = new System.Drawing.Size(259, 23);
            this.B_RandBall.TabIndex = 0;
            this.B_RandBall.Text = "Add Random Ball";
            this.B_RandBall.UseVisualStyleBackColor = true;
            this.B_RandBall.Click += new System.EventHandler(this.B_RandBall_Click);
            // 
            // B_HyperBall
            // 
            this.B_HyperBall.Location = new System.Drawing.Point(13, 43);
            this.B_HyperBall.Name = "B_HyperBall";
            this.B_HyperBall.Size = new System.Drawing.Size(259, 23);
            this.B_HyperBall.TabIndex = 1;
            this.B_HyperBall.Text = "Add HyperBall";
            this.B_HyperBall.UseVisualStyleBackColor = true;
            this.B_HyperBall.Click += new System.EventHandler(this.B_HyperBall_Click);
            // 
            // Bounce_Intrvl
            // 
            this.Bounce_Intrvl.Enabled = true;
            this.Bounce_Intrvl.Interval = 20;
            this.Bounce_Intrvl.Tick += new System.EventHandler(this.Bounce_Intrvl_Tick);
            // 
            // ICA1_BouncyBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 70);
            this.Controls.Add(this.B_HyperBall);
            this.Controls.Add(this.B_RandBall);
            this.Name = "ICA1_BouncyBall";
            this.Text = "BouncyBall";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_RandBall;
        private System.Windows.Forms.Button B_HyperBall;
        private System.Windows.Forms.Timer Bounce_Intrvl;
    }
}

