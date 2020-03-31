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
            this.tbxCharacterTraits.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCharacterTraits.Location = new System.Drawing.Point(12, 252);
            this.tbxCharacterTraits.Multiline = true;
            this.tbxCharacterTraits.Name = "tbxCharacterTraits";
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
            this.lblYourEnemy.Location = new System.Drawing.Point(622, 9);
            this.lblYourEnemy.Name = "lblYourEnemy";
            this.lblYourEnemy.Size = new System.Drawing.Size(269, 51);
            this.lblYourEnemy.TabIndex = 4;
            this.lblYourEnemy.Text = "Your Enemy";
            // 
            // tbxEnemyTraits
            // 
            this.tbxEnemyTraits.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEnemyTraits.Location = new System.Drawing.Point(526, 252);
            this.tbxEnemyTraits.Multiline = true;
            this.tbxEnemyTraits.Name = "tbxEnemyTraits";
            this.tbxEnemyTraits.Size = new System.Drawing.Size(210, 280);
            this.tbxEnemyTraits.TabIndex = 7;
            // 
            // lbxEnemyChoose
            // 
            this.lbxEnemyChoose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEnemyChoose.FormattingEnabled = true;
            this.lbxEnemyChoose.ItemHeight = 20;
            this.lbxEnemyChoose.Location = new System.Drawing.Point(631, 82);
            this.lbxEnemyChoose.Name = "lbxEnemyChoose";
            this.lbxEnemyChoose.Size = new System.Drawing.Size(210, 164);
            this.lbxEnemyChoose.TabIndex = 6;
            // 
            // pbxEnemyAppearance
            // 
            this.pbxEnemyAppearance.Location = new System.Drawing.Point(742, 252);
            this.pbxEnemyAppearance.Name = "pbxEnemyAppearance";
            this.pbxEnemyAppearance.Size = new System.Drawing.Size(210, 280);
            this.pbxEnemyAppearance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemyAppearance.TabIndex = 5;
            this.pbxEnemyAppearance.TabStop = false;
            // 
            // RobomoonChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 544);
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
    }
}