namespace Robomoon
{
    partial class StartMeny
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.Lblstartgame = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Kristen ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(379, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1162, 131);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome To Robomoon";
            // 
            // Lblstartgame
            // 
            this.Lblstartgame.AutoSize = true;
            this.Lblstartgame.BackColor = System.Drawing.Color.Transparent;
            this.Lblstartgame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblstartgame.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblstartgame.ForeColor = System.Drawing.Color.Silver;
            this.Lblstartgame.Location = new System.Drawing.Point(810, 506);
            this.Lblstartgame.Name = "Lblstartgame";
            this.Lblstartgame.Size = new System.Drawing.Size(299, 68);
            this.Lblstartgame.TabIndex = 2;
            this.Lblstartgame.Text = "Start Game";
            this.Lblstartgame.Click += new System.EventHandler(this.Lblstartgame_Click);
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.BackColor = System.Drawing.Color.Transparent;
            this.lblCreator.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.ForeColor = System.Drawing.Color.Silver;
            this.lblCreator.Location = new System.Drawing.Point(807, 584);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(304, 25);
            this.lblCreator.TabIndex = 3;
            this.lblCreator.Text = "Made by: André Edvardsson Te18Te";
            // 
            // StartMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.Lblstartgame);
            this.Controls.Add(this.lblTitle);
            this.Name = "StartMeny";
            this.Text = "StartMeny";
            this.Load += new System.EventHandler(this.StartMeny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label Lblstartgame;
        private System.Windows.Forms.Label lblCreator;
    }
}

