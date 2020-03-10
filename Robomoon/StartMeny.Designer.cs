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
            this.components = new System.ComponentModel.Container();
            this.MainMenyClosing = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenyClosing
            // 
            this.MainMenyClosing.Enabled = true;
            this.MainMenyClosing.Interval = 10;
            this.MainMenyClosing.Tick += new System.EventHandler(this.MainMenyClosing_Tick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(386, 346);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // StartMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 451);
            this.Controls.Add(this.btnStartGame);
            this.Name = "StartMeny";
            this.Text = "StartMeny";
            this.Load += new System.EventHandler(this.StartMeny_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MainMenyClosing;
        private System.Windows.Forms.Button btnStartGame;
    }
}

