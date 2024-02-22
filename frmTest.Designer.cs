namespace frmXO
{
    partial class frmTest
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
            this.PnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlyr = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblPlyrWin = new System.Windows.Forms.Label();
            this.lblCompWin = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlyAgn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PnlTable
            // 
            this.PnlTable.Location = new System.Drawing.Point(12, 70);
            this.PnlTable.Name = "PnlTable";
            this.PnlTable.Size = new System.Drawing.Size(248, 257);
            this.PnlTable.TabIndex = 0;
            // 
            // lblPlyr
            // 
            this.lblPlyr.AutoSize = true;
            this.lblPlyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlyr.Location = new System.Drawing.Point(12, 18);
            this.lblPlyr.Name = "lblPlyr";
            this.lblPlyr.Size = new System.Drawing.Size(41, 15);
            this.lblPlyr.TabIndex = 1;
            this.lblPlyr.Text = "Player";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComp.Location = new System.Drawing.Point(199, 18);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(61, 15);
            this.lblComp.TabIndex = 2;
            this.lblComp.Text = "Computer";
            // 
            // lblPlyrWin
            // 
            this.lblPlyrWin.AutoSize = true;
            this.lblPlyrWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyrWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlyrWin.Location = new System.Drawing.Point(59, 18);
            this.lblPlyrWin.Name = "lblPlyrWin";
            this.lblPlyrWin.Size = new System.Drawing.Size(14, 15);
            this.lblPlyrWin.TabIndex = 3;
            this.lblPlyrWin.Text = "0";
            // 
            // lblCompWin
            // 
            this.lblCompWin.AutoSize = true;
            this.lblCompWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompWin.Location = new System.Drawing.Point(179, 18);
            this.lblCompWin.Name = "lblCompWin";
            this.lblCompWin.Size = new System.Drawing.Size(14, 15);
            this.lblCompWin.TabIndex = 4;
            this.lblCompWin.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlyAgn
            // 
            this.btnPlyAgn.Location = new System.Drawing.Point(118, 333);
            this.btnPlyAgn.Name = "btnPlyAgn";
            this.btnPlyAgn.Size = new System.Drawing.Size(82, 23);
            this.btnPlyAgn.TabIndex = 5;
            this.btnPlyAgn.Text = "Play Again";
            this.btnPlyAgn.UseVisualStyleBackColor = true;
            this.btnPlyAgn.Click += new System.EventHandler(this.btnPlyAgn_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(260, 365);
            this.Controls.Add(this.btnPlyAgn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCompWin);
            this.Controls.Add(this.lblPlyrWin);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblPlyr);
            this.Controls.Add(this.PnlTable);
            this.Name = "frmTest";
            this.Text = "Test Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PnlTable;
        private System.Windows.Forms.Label lblPlyr;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblPlyrWin;
        private System.Windows.Forms.Label lblCompWin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlyAgn;
    }
}