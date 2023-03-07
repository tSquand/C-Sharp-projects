namespace Module3Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.curtain5PictureBox = new System.Windows.Forms.PictureBox();
            this.curtain7PictureBox = new System.Windows.Forms.PictureBox();
            this.curtain9PictureBox = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.curtain5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain7PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain9PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // curtain5PictureBox
            // 
            this.curtain5PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("curtain5PictureBox.Image")));
            this.curtain5PictureBox.Location = new System.Drawing.Point(67, 109);
            this.curtain5PictureBox.Name = "curtain5PictureBox";
            this.curtain5PictureBox.Size = new System.Drawing.Size(193, 273);
            this.curtain5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curtain5PictureBox.TabIndex = 0;
            this.curtain5PictureBox.TabStop = false;
            this.curtain5PictureBox.Click += new System.EventHandler(this.curtain5PictureBox_Click);
            // 
            // curtain7PictureBox
            // 
            this.curtain7PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("curtain7PictureBox.Image")));
            this.curtain7PictureBox.Location = new System.Drawing.Point(314, 109);
            this.curtain7PictureBox.Name = "curtain7PictureBox";
            this.curtain7PictureBox.Size = new System.Drawing.Size(193, 273);
            this.curtain7PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curtain7PictureBox.TabIndex = 1;
            this.curtain7PictureBox.TabStop = false;
            this.curtain7PictureBox.Click += new System.EventHandler(this.curtain7PictureBox_Click);
            // 
            // curtain9PictureBox
            // 
            this.curtain9PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("curtain9PictureBox.Image")));
            this.curtain9PictureBox.Location = new System.Drawing.Point(557, 109);
            this.curtain9PictureBox.Name = "curtain9PictureBox";
            this.curtain9PictureBox.Size = new System.Drawing.Size(193, 273);
            this.curtain9PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curtain9PictureBox.TabIndex = 2;
            this.curtain9PictureBox.TabStop = false;
            this.curtain9PictureBox.Click += new System.EventHandler(this.curtain9PictureBox_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(67, 468);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(162, 30);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Pick a curtain...";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLabel.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 583);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.curtain9PictureBox);
            this.Controls.Add(this.curtain7PictureBox);
            this.Controls.Add(this.curtain5PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.curtain5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain7PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain9PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox curtain5PictureBox;
        private System.Windows.Forms.PictureBox curtain7PictureBox;
        private System.Windows.Forms.PictureBox curtain9PictureBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

