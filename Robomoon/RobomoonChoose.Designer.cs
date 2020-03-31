namespace Robomoon
{
    partial class RobomoonChoose
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
            this.pbxCharacterAppearance = new System.Windows.Forms.PictureBox();
            this.lbxCharacterChoose = new System.Windows.Forms.ListBox();
            this.tbxCharacterTraits = new System.Windows.Forms.TextBox();
            this.lblYourCharacter = new System.Windows.Forms.Label();
            this.lblYourEnemy = new System.Windows.Forms.Label();
            this.tbxEnemyTraits = new System.Windows.Forms.TextBox();
            this.lbxEnemyChoose = new System.Windows.Forms.ListBox();
            this.pbxEnemyAppearance = new System.Windows.Forms.PictureBox();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnRandomEnemy = new System.Windows.Forms.Button();
            this.btnRandomCharacter = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacterAppearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemyAppearance)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCharacterAppearance
            // 
            this.pbxCharacterAppearance.Location = new System.Drawing.Point(228, 252);
            this.pbxCharacterAppearance.Name = "pbxCharacterAppearance";
            this.pbxCharacterAppearance.Size = new System.Drawing.Size(210, 280);
            this.pbxCharacterAppearance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCharacterAppearance.TabIndex = 0;
            this.pbxCharacterAppearance.TabStop = false;
            // 
            // lbxCharacterChoose
            // 
            this.lbxCharacterChoose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCharacterChoose.FormattingEnabled = true;
            this.lbxCharacterChoose.ItemHeight = 20;
            this.lbxCharacterChoose.Location = new System.Drawing.Point(117, 82);
            this.lbxCharacterChoose.Name = "lbxCharacterChoose";
            this.lbxCharacterChoose.Size = new System.Drawing.Size(210, 164);
            this.lbxCharacterChoose.TabIndex = 1;
            this.lbxCharacterChoose.SelectedIndexChanged += new System.EventHandler(this.lbxCharacterChoose_SelectedIndexChanged);
            // 
            // tbxCharacterTraits
            // 
            this.tbxCharacterTraits.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCharacterTraits.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCharacterTraits.Location = new System.Drawing.Point(12, 252);
            this.tbxCharacterTraits.Multiline = true;
            this.tbxCharacterTraits.Name = "tbxCharacterTraits";
            this.tbxCharacterTraits.ReadOnly = true;
            this.tbxCharacterTraits.Size = new System.Drawing.Size(210, 280);
            this.tbxCharacterTraits.TabIndex = 2;
            // 
            // lblYourCharacter
            // 
            this.lblYourCharacter.AutoSize = true;
            this.lblYourCharacter.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourCharacter.Location = new System.Drawing.Point(60, 9);
            this.lblYourCharacter.Name = "lblYourCharacter";
            this.lblYourCharacter.Size = new System.Drawing.Size(329, 51);
            this.lblYourCharacter.TabIndex = 3;
            this.lblYourCharacter.Text = "Your Character";
            // 
            // lblYourEnemy
            // 
            this.lblYourEnemy.AutoSize = true;
            this.lblYourEnemy.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourEnemy.Location = new System.Drawing.Point(1562, 9);
            this.lblYourEnemy.Name = "lblYourEnemy";
            this.lblYourEnemy.Size = new System.Drawing.Size(269, 51);
            this.lblYourEnemy.TabIndex = 4;
            this.lblYourEnemy.Text = "Your Enemy";
            // 
            // tbxEnemyTraits
            // 
            this.tbxEnemyTraits.BackColor = System.Drawing.SystemColors.Window;
            this.tbxEnemyTraits.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEnemyTraits.Location = new System.Drawing.Point(1466, 252);
            this.tbxEnemyTraits.Multiline = true;
            this.tbxEnemyTraits.Name = "tbxEnemyTraits";
            this.tbxEnemyTraits.ReadOnly = true;
            this.tbxEnemyTraits.Size = new System.Drawing.Size(210, 280);
            this.tbxEnemyTraits.TabIndex = 7;
            // 
            // lbxEnemyChoose
            // 
            this.lbxEnemyChoose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEnemyChoose.FormattingEnabled = true;
            this.lbxEnemyChoose.ItemHeight = 20;
            this.lbxEnemyChoose.Location = new System.Drawing.Point(1571, 82);
            this.lbxEnemyChoose.Name = "lbxEnemyChoose";
            this.lbxEnemyChoose.Size = new System.Drawing.Size(210, 164);
            this.lbxEnemyChoose.TabIndex = 6;
            this.lbxEnemyChoose.SelectedIndexChanged += new System.EventHandler(this.lbxEnemyChoose_SelectedIndexChanged);
            // 
            // pbxEnemyAppearance
            // 
            this.pbxEnemyAppearance.Location = new System.Drawing.Point(1682, 252);
            this.pbxEnemyAppearance.Name = "pbxEnemyAppearance";
            this.pbxEnemyAppearance.Size = new System.Drawing.Size(210, 280);
            this.pbxEnemyAppearance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemyAppearance.TabIndex = 5;
            this.pbxEnemyAppearance.TabStop = false;
            // 
            // lblVS
            // 
            this.lblVS.Font = new System.Drawing.Font("Arial", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(715, 155);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(490, 300);
            this.lblVS.TabIndex = 8;
            this.lblVS.Text = "VS";
            this.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRandomEnemy
            // 
            this.btnRandomEnemy.BackColor = System.Drawing.Color.Red;
            this.btnRandomEnemy.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomEnemy.Location = new System.Drawing.Point(1466, 662);
            this.btnRandomEnemy.Name = "btnRandomEnemy";
            this.btnRandomEnemy.Size = new System.Drawing.Size(426, 140);
            this.btnRandomEnemy.TabIndex = 9;
            this.btnRandomEnemy.Text = "Random Enemy";
            this.btnRandomEnemy.UseVisualStyleBackColor = false;
            this.btnRandomEnemy.Click += new System.EventHandler(this.btnRandomEnemy_Click);
            // 
            // btnRandomCharacter
            // 
            this.btnRandomCharacter.BackColor = System.Drawing.Color.Red;
            this.btnRandomCharacter.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomCharacter.Location = new System.Drawing.Point(12, 662);
            this.btnRandomCharacter.Name = "btnRandomCharacter";
            this.btnRandomCharacter.Size = new System.Drawing.Size(426, 140);
            this.btnRandomCharacter.TabIndex = 10;
            this.btnRandomCharacter.Text = "Random Character";
            this.btnRandomCharacter.UseVisualStyleBackColor = false;
            this.btnRandomCharacter.Click += new System.EventHandler(this.btnRandomCharacter_Click);
            // 
            // btnFight
            // 
            this.btnFight.BackColor = System.Drawing.SystemColors.Control;
            this.btnFight.Font = new System.Drawing.Font("Arial", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(640, 800);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(640, 210);
            this.btnFight.TabIndex = 11;
            this.btnFight.Text = "Fight!\r\n";
            this.btnFight.UseVisualStyleBackColor = false;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // RobomoonChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.btnRandomCharacter);
            this.Controls.Add(this.btnRandomEnemy);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.tbxEnemyTraits);
            this.Controls.Add(this.lbxEnemyChoose);
            this.Controls.Add(this.pbxEnemyAppearance);
            this.Controls.Add(this.lblYourEnemy);
            this.Controls.Add(this.lblYourCharacter);
            this.Controls.Add(this.tbxCharacterTraits);
            this.Controls.Add(this.lbxCharacterChoose);
            this.Controls.Add(this.pbxCharacterAppearance);
            this.Name = "RobomoonChoose";
            this.Text = "RobomoonChoose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobomoonChoose_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacterAppearance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemyAppearance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCharacterAppearance;
        private System.Windows.Forms.ListBox lbxCharacterChoose;
        private System.Windows.Forms.TextBox tbxCharacterTraits;
        private System.Windows.Forms.Label lblYourCharacter;
        private System.Windows.Forms.Label lblYourEnemy;
        private System.Windows.Forms.TextBox tbxEnemyTraits;
        private System.Windows.Forms.ListBox lbxEnemyChoose;
        private System.Windows.Forms.PictureBox pbxEnemyAppearance;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnRandomEnemy;
        private System.Windows.Forms.Button btnRandomCharacter;
        private System.Windows.Forms.Button btnFight;
    }
}