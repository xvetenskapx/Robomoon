namespace Robomoon
{
    partial class FightArena
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
            this.GbxDecideAction = new System.Windows.Forms.GroupBox();
            this.BtnFight = new System.Windows.Forms.Button();
            this.BtnCharacter = new System.Windows.Forms.Button();
            this.GbxFight = new System.Windows.Forms.GroupBox();
            this.BtnAttack5 = new System.Windows.Forms.Button();
            this.BtnGoBack = new System.Windows.Forms.Button();
            this.BtnAttack4 = new System.Windows.Forms.Button();
            this.BtnAttack3 = new System.Windows.Forms.Button();
            this.BtnAttack2 = new System.Windows.Forms.Button();
            this.BtnAttack1 = new System.Windows.Forms.Button();
            this.GbxActions = new System.Windows.Forms.GroupBox();
            this.GbxSpec = new System.Windows.Forms.GroupBox();
            this.BtnGoBackSpecs = new System.Windows.Forms.Button();
            this.LblRobomoonSpec = new System.Windows.Forms.Label();
            this.LblCharacterSpec = new System.Windows.Forms.Label();
            this.GbxActionText = new System.Windows.Forms.GroupBox();
            this.LblText = new System.Windows.Forms.Label();
            this.PbrRobomoonHP = new System.Windows.Forms.ProgressBar();
            this.GbxRobomoonSpec = new System.Windows.Forms.GroupBox();
            this.LblRobomoonNamn = new System.Windows.Forms.Label();
            this.GbxCharacterSpec = new System.Windows.Forms.GroupBox();
            this.LblCharacterHP = new System.Windows.Forms.Label();
            this.LblCharacterName = new System.Windows.Forms.Label();
            this.PbrCharacterHP = new System.Windows.Forms.ProgressBar();
            this.PbxRobomoon = new System.Windows.Forms.PictureBox();
            this.PbxCharacter = new System.Windows.Forms.PictureBox();
            this.TmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.TmrDeath = new System.Windows.Forms.Timer(this.components);
            this.GbxDecideAction.SuspendLayout();
            this.GbxFight.SuspendLayout();
            this.GbxActions.SuspendLayout();
            this.GbxSpec.SuspendLayout();
            this.GbxActionText.SuspendLayout();
            this.GbxRobomoonSpec.SuspendLayout();
            this.GbxCharacterSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRobomoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxDecideAction
            // 
            this.GbxDecideAction.Controls.Add(this.BtnFight);
            this.GbxDecideAction.Controls.Add(this.BtnCharacter);
            this.GbxDecideAction.Location = new System.Drawing.Point(95, 60);
            this.GbxDecideAction.Name = "GbxDecideAction";
            this.GbxDecideAction.Size = new System.Drawing.Size(360, 130);
            this.GbxDecideAction.TabIndex = 0;
            this.GbxDecideAction.TabStop = false;
            this.GbxDecideAction.Text = "Decide Action";
            // 
            // BtnFight
            // 
            this.BtnFight.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFight.Location = new System.Drawing.Point(6, 19);
            this.BtnFight.Name = "BtnFight";
            this.BtnFight.Size = new System.Drawing.Size(348, 35);
            this.BtnFight.TabIndex = 4;
            this.BtnFight.Text = "FIGHT";
            this.BtnFight.UseVisualStyleBackColor = true;
            this.BtnFight.Click += new System.EventHandler(this.BtnFight_Click);
            // 
            // BtnCharacter
            // 
            this.BtnCharacter.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCharacter.Location = new System.Drawing.Point(6, 89);
            this.BtnCharacter.Name = "BtnCharacter";
            this.BtnCharacter.Size = new System.Drawing.Size(348, 35);
            this.BtnCharacter.TabIndex = 2;
            this.BtnCharacter.Text = "CHARACTER";
            this.BtnCharacter.UseVisualStyleBackColor = true;
            this.BtnCharacter.Click += new System.EventHandler(this.BtnCharacter_Click);
            // 
            // GbxFight
            // 
            this.GbxFight.Controls.Add(this.BtnAttack5);
            this.GbxFight.Controls.Add(this.BtnGoBack);
            this.GbxFight.Controls.Add(this.BtnAttack4);
            this.GbxFight.Controls.Add(this.BtnAttack3);
            this.GbxFight.Controls.Add(this.BtnAttack2);
            this.GbxFight.Controls.Add(this.BtnAttack1);
            this.GbxFight.Location = new System.Drawing.Point(31, 190);
            this.GbxFight.Name = "GbxFight";
            this.GbxFight.Size = new System.Drawing.Size(360, 130);
            this.GbxFight.TabIndex = 1;
            this.GbxFight.TabStop = false;
            this.GbxFight.Text = "Fight";
            this.GbxFight.Visible = false;
            // 
            // BtnAttack5
            // 
            this.BtnAttack5.Location = new System.Drawing.Point(254, 19);
            this.BtnAttack5.Name = "BtnAttack5";
            this.BtnAttack5.Size = new System.Drawing.Size(100, 23);
            this.BtnAttack5.TabIndex = 5;
            this.BtnAttack5.Text = "Attack 5";
            this.BtnAttack5.UseVisualStyleBackColor = true;
            this.BtnAttack5.Click += new System.EventHandler(this.BtnAttack5_Click);
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.Location = new System.Drawing.Point(254, 101);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(100, 23);
            this.BtnGoBack.TabIndex = 4;
            this.BtnGoBack.Text = "Go Back";
            this.BtnGoBack.UseVisualStyleBackColor = true;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // BtnAttack4
            // 
            this.BtnAttack4.Location = new System.Drawing.Point(130, 101);
            this.BtnAttack4.Name = "BtnAttack4";
            this.BtnAttack4.Size = new System.Drawing.Size(100, 23);
            this.BtnAttack4.TabIndex = 3;
            this.BtnAttack4.Text = "Attack 4";
            this.BtnAttack4.UseVisualStyleBackColor = true;
            this.BtnAttack4.Click += new System.EventHandler(this.BtnAttack4_Click);
            // 
            // BtnAttack3
            // 
            this.BtnAttack3.Location = new System.Drawing.Point(130, 19);
            this.BtnAttack3.Name = "BtnAttack3";
            this.BtnAttack3.Size = new System.Drawing.Size(100, 23);
            this.BtnAttack3.TabIndex = 2;
            this.BtnAttack3.Text = "Attack 2";
            this.BtnAttack3.UseVisualStyleBackColor = true;
            this.BtnAttack3.Click += new System.EventHandler(this.btnAttack3_Click);
            // 
            // BtnAttack2
            // 
            this.BtnAttack2.Location = new System.Drawing.Point(6, 101);
            this.BtnAttack2.Name = "BtnAttack2";
            this.BtnAttack2.Size = new System.Drawing.Size(100, 23);
            this.BtnAttack2.TabIndex = 1;
            this.BtnAttack2.Text = "Attack 2";
            this.BtnAttack2.UseVisualStyleBackColor = true;
            this.BtnAttack2.Click += new System.EventHandler(this.BtnAttack2_Click);
            // 
            // BtnAttack1
            // 
            this.BtnAttack1.Location = new System.Drawing.Point(6, 19);
            this.BtnAttack1.Name = "BtnAttack1";
            this.BtnAttack1.Size = new System.Drawing.Size(100, 23);
            this.BtnAttack1.TabIndex = 0;
            this.BtnAttack1.Text = "Attack 1";
            this.BtnAttack1.UseVisualStyleBackColor = true;
            this.BtnAttack1.Click += new System.EventHandler(this.BtnAttack1_Click);
            // 
            // GbxActions
            // 
            this.GbxActions.BackColor = System.Drawing.Color.Transparent;
            this.GbxActions.Controls.Add(this.GbxDecideAction);
            this.GbxActions.Controls.Add(this.GbxSpec);
            this.GbxActions.Controls.Add(this.GbxFight);
            this.GbxActions.Location = new System.Drawing.Point(1298, 691);
            this.GbxActions.Name = "GbxActions";
            this.GbxActions.Size = new System.Drawing.Size(594, 338);
            this.GbxActions.TabIndex = 6;
            this.GbxActions.TabStop = false;
            // 
            // GbxSpec
            // 
            this.GbxSpec.Controls.Add(this.BtnGoBackSpecs);
            this.GbxSpec.Controls.Add(this.LblRobomoonSpec);
            this.GbxSpec.Controls.Add(this.LblCharacterSpec);
            this.GbxSpec.Location = new System.Drawing.Point(461, 47);
            this.GbxSpec.Name = "GbxSpec";
            this.GbxSpec.Size = new System.Drawing.Size(416, 219);
            this.GbxSpec.TabIndex = 6;
            this.GbxSpec.TabStop = false;
            this.GbxSpec.Text = "Specs";
            this.GbxSpec.Visible = false;
            // 
            // BtnGoBackSpecs
            // 
            this.BtnGoBackSpecs.Location = new System.Drawing.Point(172, 180);
            this.BtnGoBackSpecs.Name = "BtnGoBackSpecs";
            this.BtnGoBackSpecs.Size = new System.Drawing.Size(72, 23);
            this.BtnGoBackSpecs.TabIndex = 2;
            this.BtnGoBackSpecs.Text = "Go Back";
            this.BtnGoBackSpecs.UseVisualStyleBackColor = true;
            this.BtnGoBackSpecs.Click += new System.EventHandler(this.BtnGoBackSpecs_Click);
            // 
            // LblRobomoonSpec
            // 
            this.LblRobomoonSpec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRobomoonSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRobomoonSpec.Location = new System.Drawing.Point(210, 16);
            this.LblRobomoonSpec.Name = "LblRobomoonSpec";
            this.LblRobomoonSpec.Size = new System.Drawing.Size(200, 148);
            this.LblRobomoonSpec.TabIndex = 1;
            this.LblRobomoonSpec.Text = "label2";
            // 
            // LblCharacterSpec
            // 
            this.LblCharacterSpec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCharacterSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCharacterSpec.Location = new System.Drawing.Point(6, 16);
            this.LblCharacterSpec.Name = "LblCharacterSpec";
            this.LblCharacterSpec.Size = new System.Drawing.Size(200, 148);
            this.LblCharacterSpec.TabIndex = 0;
            this.LblCharacterSpec.Text = "Attack Dammage: 999";
            // 
            // GbxActionText
            // 
            this.GbxActionText.BackColor = System.Drawing.Color.Transparent;
            this.GbxActionText.Controls.Add(this.LblText);
            this.GbxActionText.Location = new System.Drawing.Point(12, 691);
            this.GbxActionText.Name = "GbxActionText";
            this.GbxActionText.Size = new System.Drawing.Size(1280, 338);
            this.GbxActionText.TabIndex = 0;
            this.GbxActionText.TabStop = false;
            // 
            // LblText
            // 
            this.LblText.Location = new System.Drawing.Point(85, 16);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(1189, 311);
            this.LblText.TabIndex = 1;
            this.LblText.Text = "label1";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbrRobomoonHP
            // 
            this.PbrRobomoonHP.Location = new System.Drawing.Point(6, 39);
            this.PbrRobomoonHP.Name = "PbrRobomoonHP";
            this.PbrRobomoonHP.Size = new System.Drawing.Size(500, 20);
            this.PbrRobomoonHP.Step = 1;
            this.PbrRobomoonHP.TabIndex = 9;
            // 
            // GbxRobomoonSpec
            // 
            this.GbxRobomoonSpec.BackColor = System.Drawing.Color.Transparent;
            this.GbxRobomoonSpec.Controls.Add(this.LblRobomoonNamn);
            this.GbxRobomoonSpec.Controls.Add(this.PbrRobomoonHP);
            this.GbxRobomoonSpec.Location = new System.Drawing.Point(315, 64);
            this.GbxRobomoonSpec.Name = "GbxRobomoonSpec";
            this.GbxRobomoonSpec.Size = new System.Drawing.Size(515, 69);
            this.GbxRobomoonSpec.TabIndex = 10;
            this.GbxRobomoonSpec.TabStop = false;
            // 
            // LblRobomoonNamn
            // 
            this.LblRobomoonNamn.AutoSize = true;
            this.LblRobomoonNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRobomoonNamn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRobomoonNamn.Location = new System.Drawing.Point(6, 16);
            this.LblRobomoonNamn.Name = "LblRobomoonNamn";
            this.LblRobomoonNamn.Size = new System.Drawing.Size(134, 20);
            this.LblRobomoonNamn.TabIndex = 11;
            this.LblRobomoonNamn.Text = "Robomoon Name";
            // 
            // GbxCharacterSpec
            // 
            this.GbxCharacterSpec.BackColor = System.Drawing.Color.Transparent;
            this.GbxCharacterSpec.Controls.Add(this.LblCharacterHP);
            this.GbxCharacterSpec.Controls.Add(this.LblCharacterName);
            this.GbxCharacterSpec.Controls.Add(this.PbrCharacterHP);
            this.GbxCharacterSpec.Location = new System.Drawing.Point(1174, 479);
            this.GbxCharacterSpec.Name = "GbxCharacterSpec";
            this.GbxCharacterSpec.Size = new System.Drawing.Size(515, 88);
            this.GbxCharacterSpec.TabIndex = 11;
            this.GbxCharacterSpec.TabStop = false;
            // 
            // LblCharacterHP
            // 
            this.LblCharacterHP.AutoSize = true;
            this.LblCharacterHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCharacterHP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCharacterHP.Location = new System.Drawing.Point(439, 62);
            this.LblCharacterHP.Name = "LblCharacterHP";
            this.LblCharacterHP.Size = new System.Drawing.Size(67, 20);
            this.LblCharacterHP.TabIndex = 12;
            this.LblCharacterHP.Text = "999/999";
            // 
            // LblCharacterName
            // 
            this.LblCharacterName.AutoSize = true;
            this.LblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCharacterName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCharacterName.Location = new System.Drawing.Point(6, 16);
            this.LblCharacterName.Name = "LblCharacterName";
            this.LblCharacterName.Size = new System.Drawing.Size(125, 20);
            this.LblCharacterName.TabIndex = 11;
            this.LblCharacterName.Text = "Character Name";
            // 
            // PbrCharacterHP
            // 
            this.PbrCharacterHP.Location = new System.Drawing.Point(6, 39);
            this.PbrCharacterHP.Name = "PbrCharacterHP";
            this.PbrCharacterHP.Size = new System.Drawing.Size(500, 20);
            this.PbrCharacterHP.TabIndex = 9;
            // 
            // PbxRobomoon
            // 
            this.PbxRobomoon.Location = new System.Drawing.Point(1305, 0);
            this.PbxRobomoon.Name = "PbxRobomoon";
            this.PbxRobomoon.Size = new System.Drawing.Size(210, 280);
            this.PbxRobomoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxRobomoon.TabIndex = 8;
            this.PbxRobomoon.TabStop = false;
            // 
            // PbxCharacter
            // 
            this.PbxCharacter.Location = new System.Drawing.Point(405, 266);
            this.PbxCharacter.Name = "PbxCharacter";
            this.PbxCharacter.Size = new System.Drawing.Size(210, 280);
            this.PbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCharacter.TabIndex = 7;
            this.PbxCharacter.TabStop = false;
            // 
            // TmrEnemy
            // 
            this.TmrEnemy.Interval = 300;
            this.TmrEnemy.Tick += new System.EventHandler(this.TmrEnemy_Tick);
            // 
            // TmrDeath
            // 
            this.TmrDeath.Interval = 500;
            this.TmrDeath.Tick += new System.EventHandler(this.TmrDeath_Tick);
            // 
            // FightArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Robomoon.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.GbxCharacterSpec);
            this.Controls.Add(this.GbxRobomoonSpec);
            this.Controls.Add(this.PbxRobomoon);
            this.Controls.Add(this.PbxCharacter);
            this.Controls.Add(this.GbxActions);
            this.Controls.Add(this.GbxActionText);
            this.Name = "FightArena";
            this.Text = "FightArena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FightArena_FormClosing);
            this.Load += new System.EventHandler(this.FightArena_Load);
            this.GbxDecideAction.ResumeLayout(false);
            this.GbxFight.ResumeLayout(false);
            this.GbxActions.ResumeLayout(false);
            this.GbxSpec.ResumeLayout(false);
            this.GbxActionText.ResumeLayout(false);
            this.GbxRobomoonSpec.ResumeLayout(false);
            this.GbxRobomoonSpec.PerformLayout();
            this.GbxCharacterSpec.ResumeLayout(false);
            this.GbxCharacterSpec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRobomoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxDecideAction;
        private System.Windows.Forms.Button BtnCharacter;
        private System.Windows.Forms.Button BtnFight;
        private System.Windows.Forms.GroupBox GbxFight;
        private System.Windows.Forms.Button BtnAttack5;
        private System.Windows.Forms.Button BtnGoBack;
        private System.Windows.Forms.Button BtnAttack4;
        private System.Windows.Forms.Button BtnAttack3;
        private System.Windows.Forms.Button BtnAttack2;
        private System.Windows.Forms.Button BtnAttack1;
        private System.Windows.Forms.GroupBox GbxActions;
        private System.Windows.Forms.GroupBox GbxActionText;
        private System.Windows.Forms.PictureBox PbxCharacter;
        private System.Windows.Forms.PictureBox PbxRobomoon;
        private System.Windows.Forms.ProgressBar PbrRobomoonHP;
        private System.Windows.Forms.GroupBox GbxRobomoonSpec;
        private System.Windows.Forms.Label LblRobomoonNamn;
        private System.Windows.Forms.GroupBox GbxCharacterSpec;
        private System.Windows.Forms.Label LblCharacterName;
        private System.Windows.Forms.ProgressBar PbrCharacterHP;
        private System.Windows.Forms.Label LblCharacterHP;
        private System.Windows.Forms.GroupBox GbxSpec;
        private System.Windows.Forms.Label LblRobomoonSpec;
        private System.Windows.Forms.Label LblCharacterSpec;
        private System.Windows.Forms.Button BtnGoBackSpecs;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Timer TmrEnemy;
        private System.Windows.Forms.Timer TmrDeath;
    }
}