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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightArena));
            this.gbxDecideAction = new System.Windows.Forms.GroupBox();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnBackpack = new System.Windows.Forms.Button();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.gbxFight = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbxRobomoon = new System.Windows.Forms.PictureBox();
            this.pbxCharacter = new System.Windows.Forms.PictureBox();
            this.gbxDecideAction.SuspendLayout();
            this.gbxFight.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRobomoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDecideAction
            // 
            this.gbxDecideAction.Controls.Add(this.btnFight);
            this.gbxDecideAction.Controls.Add(this.btnRun);
            this.gbxDecideAction.Controls.Add(this.btnBackpack);
            this.gbxDecideAction.Controls.Add(this.btnCharacter);
            this.gbxDecideAction.Location = new System.Drawing.Point(25, 38);
            this.gbxDecideAction.Name = "gbxDecideAction";
            this.gbxDecideAction.Size = new System.Drawing.Size(360, 130);
            this.gbxDecideAction.TabIndex = 0;
            this.gbxDecideAction.TabStop = false;
            this.gbxDecideAction.Text = "Decide Action";
            // 
            // btnFight
            // 
            this.btnFight.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(6, 19);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(130, 35);
            this.btnFight.TabIndex = 4;
            this.btnFight.Text = "FIGHT";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(224, 89);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 35);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnBackpack
            // 
            this.btnBackpack.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackpack.Location = new System.Drawing.Point(224, 19);
            this.btnBackpack.Name = "btnBackpack";
            this.btnBackpack.Size = new System.Drawing.Size(130, 35);
            this.btnBackpack.TabIndex = 3;
            this.btnBackpack.Text = "BACKPACK";
            this.btnBackpack.UseVisualStyleBackColor = true;
            // 
            // btnCharacter
            // 
            this.btnCharacter.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharacter.Location = new System.Drawing.Point(6, 89);
            this.btnCharacter.Name = "btnCharacter";
            this.btnCharacter.Size = new System.Drawing.Size(130, 35);
            this.btnCharacter.TabIndex = 2;
            this.btnCharacter.Text = "CHARACTER";
            this.btnCharacter.UseVisualStyleBackColor = true;
            // 
            // gbxFight
            // 
            this.gbxFight.Controls.Add(this.button6);
            this.gbxFight.Controls.Add(this.btnGoBack);
            this.gbxFight.Controls.Add(this.button4);
            this.gbxFight.Controls.Add(this.button3);
            this.gbxFight.Controls.Add(this.button2);
            this.gbxFight.Controls.Add(this.button1);
            this.gbxFight.Location = new System.Drawing.Point(393, 57);
            this.gbxFight.Name = "gbxFight";
            this.gbxFight.Size = new System.Drawing.Size(360, 130);
            this.gbxFight.TabIndex = 1;
            this.gbxFight.TabStop = false;
            this.gbxFight.Text = "Fight";
            this.gbxFight.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(279, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(279, 101);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1298, 691);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 338);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbxDecideAction);
            this.groupBox2.Controls.Add(this.gbxFight);
            this.groupBox2.Location = new System.Drawing.Point(12, 691);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1280, 338);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pbxRobomoon
            // 
            this.pbxRobomoon.Image = global::Robomoon.Properties.Resources.Jesper_No;
            this.pbxRobomoon.Location = new System.Drawing.Point(1305, 0);
            this.pbxRobomoon.Name = "pbxRobomoon";
            this.pbxRobomoon.Size = new System.Drawing.Size(210, 280);
            this.pbxRobomoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRobomoon.TabIndex = 8;
            this.pbxRobomoon.TabStop = false;
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.Image = ((System.Drawing.Image)(resources.GetObject("pbxCharacter.Image")));
            this.pbxCharacter.Location = new System.Drawing.Point(405, 266);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(210, 280);
            this.pbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCharacter.TabIndex = 7;
            this.pbxCharacter.TabStop = false;
            // 
            // FightArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pbxRobomoon);
            this.Controls.Add(this.pbxCharacter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FightArena";
            this.Text = "FightArena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FightArena_FormClosing);
            this.Load += new System.EventHandler(this.FightArena_Load);
            this.gbxDecideAction.ResumeLayout(false);
            this.gbxFight.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRobomoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDecideAction;
        private System.Windows.Forms.Button btnBackpack;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.GroupBox gbxFight;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbxCharacter;
        private System.Windows.Forms.PictureBox pbxRobomoon;
    }
}