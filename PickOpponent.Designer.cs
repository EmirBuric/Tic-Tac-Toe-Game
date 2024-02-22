namespace frmXO
{
    partial class frmPickOpponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPickOpponent));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVsPlyr = new System.Windows.Forms.Button();
            this.btVsComp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVsPlyr
            // 
            this.btnVsPlyr.Location = new System.Drawing.Point(69, 80);
            this.btnVsPlyr.Name = "btnVsPlyr";
            this.btnVsPlyr.Size = new System.Drawing.Size(75, 23);
            this.btnVsPlyr.TabIndex = 1;
            this.btnVsPlyr.Text = "VS Player";
            this.btnVsPlyr.UseVisualStyleBackColor = true;
            this.btnVsPlyr.Click += new System.EventHandler(this.btnVsPlyr_Click);
            // 
            // btVsComp
            // 
            this.btVsComp.Location = new System.Drawing.Point(164, 80);
            this.btVsComp.Name = "btVsComp";
            this.btVsComp.Size = new System.Drawing.Size(78, 23);
            this.btVsComp.TabIndex = 2;
            this.btVsComp.Text = "VS Computer";
            this.btVsComp.UseVisualStyleBackColor = true;
            this.btVsComp.Click += new System.EventHandler(this.btVsComp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(107, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPickOpponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(304, 163);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btVsComp);
            this.Controls.Add(this.btnVsPlyr);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPickOpponent";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVsPlyr;
        private System.Windows.Forms.Button btVsComp;
        private System.Windows.Forms.Button btnExit;
    }
}