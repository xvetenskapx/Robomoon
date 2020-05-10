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
            this.PbxCharacterAppearance = new System.Windows.Forms.PictureBox();
            this.LbxCharacterChoose = new System.Windows.Forms.ListBox();
            this.TbxCharacterTraits = new System.Windows.Forms.TextBox();
            this.LblYourCharacter = new System.Windows.Forms.Label();
            this.LblYourEnemy = new System.Windows.Forms.Label();
            this.TbxEnemyTraits = new System.Windows.Forms.TextBox();
            this.LbxEnemyChoose = new System.Windows.Forms.ListBox();
            this.PbxEnemyAppearance = new System.Windows.Forms.PictureBox();
            this.LblVS = new System.Windows.Forms.Label();
            this.BtnRandomEnemy = new System.Windows.Forms.Button();
            this.BtnRandomCharacter = new System.Windows.Forms.Button();
            this.BtnFight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCharacterAppearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnemyAppearance)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxCharacterAppearance
            // 
            this.PbxCharacterAppearance.Location = new System.Drawing.Point(228, 252);
            this.PbxCharacterAppearance.Name = "PbxCharacterAppearance";
            this.PbxCharacterAppearance.Size = new System.Drawing.Size(210, 280);
            this.PbxCharacterAppearance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCharacterAppearance.TabIndex = 0;
            this.PbxCharacterAppearance.TabStop = false;
            // 
            // LbxCharacterChoose
            // 
            this.LbxCharacterChoose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxCharacterChoose.FormattingEnabled = true;
            this.LbxCharacterChoose.ItemHeight = 20;
            this.LbxCharacterChoose.Location = new System.Drawing.Point(117, 82);
            this.LbxCharacterChoose.Name = "LbxCharacterChoose";
            this.LbxCharacterChoose.Size = new System.Drawing.Size(210, 164);
            this.LbxCharacterChoose.TabIndex = 1;
            this.LbxCharacterChoose.SelectedIndexChanged += new System.EventHandler(this.LbxCharacterChoose_SelectedIndexChanged);
            // 
            // TbxCharacterTraits
            // 
            this.TbxCharacterTraits.BackColor = System.Drawing.SystemColors.Window;
            this.TbxCharacterTraits.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCharacterTraits.Location = new System.Drawing.Point(12, 252);
            this.TbxCharacterTraits.Multiline = true;
            this.TbxCharacterTraits.Name = "TbxCharacterTraits";
            this.TbxCharacterTraits.ReadOnly = true;
            this.TbxCharacterTraits.Size = new System.Drawing.Size(210, 280);
            this.TbxCharacterTraits.TabIndex = 2;
            // 
            // LblYourCharacter
            // 
            this.LblYourCharacter.AutoSize = true;
            this.LblYourCharacter.BackColor = System.Drawing.Color.Transparent;
            this.LblYourCharacter.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYourCharacter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblYourCharacter.Location = new System.Drawing.Point(60, 9);
            this.LblYourCharacter.Name = "LblYourCharacter";
            this.LblYourCharacter.Size = new System.Drawing.Size(329, 51);
            this.LblYourCharacter.TabIndex = 3;
            this.LblYourCharacter.Text = "Your Character";
            // 
            // LblYourEnemy
            // 
            this.LblYourEnemy.AutoSize = true;
            this.LblYourEnemy.BackColor = System.Drawing.Color.Transparent;
            this.LblYourEnemy.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYourEnemy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblYourEnemy.Location = new System.Drawing.Point(1562, 9);
            this.LblYourEnemy.Name = "LblYourEnemy";
            this.LblYourEnemy.Size = new System.Drawing.Size(269, 51);
            this.LblYourEnemy.TabIndex = 4;
            this.LblYourEnemy.Text = "Your Enemy";
            // 
            // TbxEnemyTraits
            // 
            this.TbxEnemyTraits.BackColor = System.Drawing.SystemColors.Window;
            this.TbxEnemyTraits.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEnemyTraits.Location = new System.Drawing.Point(1466, 252);
            this.TbxEnemyTraits.Multiline = true;
            this.TbxEnemyTraits.Name = "TbxEnemyTraits";
            this.TbxEnemyTraits.ReadOnly = true;
            this.TbxEnemyTraits.Size = new System.Drawing.Size(210, 280);
            this.TbxEnemyTraits.TabIndex = 7;
            // 
            // LbxEnemyChoose
            // 
            this.LbxEnemyChoose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxEnemyChoose.FormattingEnabled = true;
            this.LbxEnemyChoose.ItemHeight = 20;
            this.LbxEnemyChoose.Location = new System.Drawing.Point(1571, 82);
            this.LbxEnemyChoose.Name = "LbxEnemyChoose";
            this.LbxEnemyChoose.Size = new System.Drawing.Size(210, 164);
            this.LbxEnemyChoose.TabIndex = 6;
            this.LbxEnemyChoose.SelectedIndexChanged += new System.EventHandler(this.LbxEnemyChoose_SelectedIndexChanged);
            // 
            // PbxEnemyAppearance
            // 
            this.PbxEnemyAppearance.Location = new System.Drawing.Point(1682, 252);
            this.PbxEnemyAppearance.Name = "PbxEnemyAppearance";
            this.PbxEnemyAppearance.Size = new System.Drawing.Size(210, 280);
            this.PbxEnemyAppearance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxEnemyAppearance.TabIndex = 5;
            this.PbxEnemyAppearance.TabStop = false;
            // 
            // LblVS
            // 
            this.LblVS.BackColor = System.Drawing.Color.Transparent;
            this.LblVS.Font = new System.Drawing.Font("Arial", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVS.Location = new System.Drawing.Point(715, 155);
            this.LblVS.Name = "LblVS";
            this.LblVS.Size = new System.Drawing.Size(490, 300);
            this.LblVS.TabIndex = 8;
            this.LblVS.Text = "VS";
            this.LblVS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnRandomEnemy
            // 
            this.BtnRandomEnemy.BackColor = System.Drawing.Color.Red;
            this.BtnRandomEnemy.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandomEnemy.Location = new System.Drawing.Point(1466, 662);
            this.BtnRandomEnemy.Name = "BtnRandomEnemy";
            this.BtnRandomEnemy.Size = new System.Drawing.Size(426, 140);
            this.BtnRandomEnemy.TabIndex = 9;
            this.BtnRandomEnemy.Text = "Random Enemy";
            this.BtnRandomEnemy.UseVisualStyleBackColor = false;
            this.BtnRandomEnemy.Click += new System.EventHandler(this.BtnRandomEnemy_Click);
            // 
            // BtnRandomCharacter
            // 
            this.BtnRandomCharacter.BackColor = System.Drawing.Color.Red;
            this.BtnRandomCharacter.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandomCharacter.Location = new System.Drawing.Point(12, 662);
            this.BtnRandomCharacter.Name = "BtnRandomCharacter";
            this.BtnRandomCharacter.Size = new System.Drawing.Size(426, 140);
            this.BtnRandomCharacter.TabIndex = 10;
            this.BtnRandomCharacter.Text = "Random Character";
            this.BtnRandomCharacter.UseVisualStyleBackColor = false;
            this.BtnRandomCharacter.Click += new System.EventHandler(this.BtnRandomCharacter_Click);
            // 
            // BtnFight
            // 
            this.BtnFight.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFight.Font = new System.Drawing.Font("Arial", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFight.Location = new System.Drawing.Point(640, 800);
            this.BtnFight.Name = "BtnFight";
            this.BtnFight.Size = new System.Drawing.Size(640, 210);
            this.BtnFight.TabIndex = 11;
            this.BtnFight.Text = "Fight!\r\n";
            this.BtnFight.UseVisualStyleBackColor = false;
            this.BtnFight.Click += new System.EventHandler(this.BtnFight_Click);
            // 
            // RobomoonChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.BtnFight);
            this.Controls.Add(this.BtnRandomCharacter);
            this.Controls.Add(this.BtnRandomEnemy);
            this.Controls.Add(this.LblVS);
            this.Controls.Add(this.TbxEnemyTraits);
            this.Controls.Add(this.LbxEnemyChoose);
            this.Controls.Add(this.PbxEnemyAppearance);
            this.Controls.Add(this.LblYourEnemy);
            this.Controls.Add(this.LblYourCharacter);
            this.Controls.Add(this.TbxCharacterTraits);
            this.Controls.Add(this.LbxCharacterChoose);
            this.Controls.Add(this.PbxCharacterAppearance);
            this.Name = "RobomoonChoose";
            this.Text = "RobomoonChoose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobomoonChoose_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCharacterAppearance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnemyAppearance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxCharacterAppearance;
        private System.Windows.Forms.ListBox LbxCharacterChoose;
        private System.Windows.Forms.TextBox TbxCharacterTraits;
        private System.Windows.Forms.Label LblYourCharacter;
        private System.Windows.Forms.Label LblYourEnemy;
        private System.Windows.Forms.TextBox TbxEnemyTraits;
        private System.Windows.Forms.ListBox LbxEnemyChoose;
        private System.Windows.Forms.PictureBox PbxEnemyAppearance;
        private System.Windows.Forms.Label LblVS;
        private System.Windows.Forms.Button BtnRandomEnemy;
        private System.Windows.Forms.Button BtnRandomCharacter;
        private System.Windows.Forms.Button BtnFight;
    }
}