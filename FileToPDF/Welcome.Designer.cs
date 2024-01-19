namespace FileToPDF
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.LoadingImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop a file into the window\r\n";
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(105, 137);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(74, 13);
            this.CounterLabel.TabIndex = 1;
            this.CounterLabel.Text = "Counter: 0000";
            // 
            // LoadingImage
            // 
            this.LoadingImage.Image = global::FileToPDF.Properties.Resources.loading;
            this.LoadingImage.Location = new System.Drawing.Point(117, 199);
            this.LoadingImage.Name = "LoadingImage";
            this.LoadingImage.Size = new System.Drawing.Size(50, 50);
            this.LoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingImage.TabIndex = 2;
            this.LoadingImage.TabStop = false;
            this.LoadingImage.Visible = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoadingImage);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Text = "File to PDF";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Welcome_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Welcome_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.PictureBox LoadingImage;
    }
}

