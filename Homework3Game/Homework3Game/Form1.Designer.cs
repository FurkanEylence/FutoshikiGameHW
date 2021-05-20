
namespace Homework3Game
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
            this.components = new System.ComponentModel.Container();
            this.gbxGameArea = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxControlArea = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblCountsOfHints = new System.Windows.Forms.Label();
            this.lblCountHintsText = new System.Windows.Forms.Label();
            this.btnHints = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnCheckInputs = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbxControlArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGameArea
            // 
            this.gbxGameArea.Location = new System.Drawing.Point(18, 17);
            this.gbxGameArea.Name = "gbxGameArea";
            this.gbxGameArea.Size = new System.Drawing.Size(343, 320);
            this.gbxGameArea.TabIndex = 0;
            this.gbxGameArea.TabStop = false;
            this.gbxGameArea.Text = "GAME AREA";
            // 
            // gbxControlArea
            // 
            this.gbxControlArea.Controls.Add(this.lblTime);
            this.gbxControlArea.Controls.Add(this.lblTimer);
            this.gbxControlArea.Controls.Add(this.btnAbout);
            this.gbxControlArea.Controls.Add(this.lblCountsOfHints);
            this.gbxControlArea.Controls.Add(this.lblCountHintsText);
            this.gbxControlArea.Controls.Add(this.btnHints);
            this.gbxControlArea.Controls.Add(this.btnEndGame);
            this.gbxControlArea.Controls.Add(this.btnCheckInputs);
            this.gbxControlArea.Controls.Add(this.btnNewGame);
            this.gbxControlArea.Location = new System.Drawing.Point(376, 17);
            this.gbxControlArea.Name = "gbxControlArea";
            this.gbxControlArea.Size = new System.Drawing.Size(146, 320);
            this.gbxControlArea.TabIndex = 1;
            this.gbxControlArea.TabStop = false;
            this.gbxControlArea.Text = " ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(18, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 20);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Last Sec.:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.Location = new System.Drawing.Point(104, 32);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(30, 24);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "90";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(17, 192);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(112, 25);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About Game";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblCountsOfHints
            // 
            this.lblCountsOfHints.AutoSize = true;
            this.lblCountsOfHints.Location = new System.Drawing.Point(111, 246);
            this.lblCountsOfHints.Name = "lblCountsOfHints";
            this.lblCountsOfHints.Size = new System.Drawing.Size(13, 13);
            this.lblCountsOfHints.TabIndex = 5;
            this.lblCountsOfHints.Text = "0";
            // 
            // lblCountHintsText
            // 
            this.lblCountHintsText.AutoSize = true;
            this.lblCountHintsText.Location = new System.Drawing.Point(14, 246);
            this.lblCountHintsText.Name = "lblCountHintsText";
            this.lblCountHintsText.Size = new System.Drawing.Size(91, 13);
            this.lblCountHintsText.TabIndex = 4;
            this.lblCountHintsText.Text = "Left Hints Counts:";
            // 
            // btnHints
            // 
            this.btnHints.Location = new System.Drawing.Point(17, 262);
            this.btnHints.Name = "btnHints";
            this.btnHints.Size = new System.Drawing.Size(113, 35);
            this.btnHints.TabIndex = 3;
            this.btnHints.Text = "Show More Hints";
            this.btnHints.UseVisualStyleBackColor = true;
            this.btnHints.Click += new System.EventHandler(this.btnHints_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(17, 151);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(113, 35);
            this.btnEndGame.TabIndex = 2;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnCheckInputs
            // 
            this.btnCheckInputs.Location = new System.Drawing.Point(17, 110);
            this.btnCheckInputs.Name = "btnCheckInputs";
            this.btnCheckInputs.Size = new System.Drawing.Size(113, 35);
            this.btnCheckInputs.TabIndex = 1;
            this.btnCheckInputs.Text = "Check Inputs";
            this.btnCheckInputs.UseVisualStyleBackColor = true;
            this.btnCheckInputs.Click += new System.EventHandler(this.btnCheckInputs_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(17, 69);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(113, 35);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 358);
            this.Controls.Add(this.gbxControlArea);
            this.Controls.Add(this.gbxGameArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxControlArea.ResumeLayout(false);
            this.gbxControlArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGameArea;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxControlArea;
        private System.Windows.Forms.Label lblCountHintsText;
        private System.Windows.Forms.Button btnHints;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnCheckInputs;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblCountsOfHints;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

