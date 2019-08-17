namespace Picture_Move_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.puzzleBox = new System.Windows.Forms.GroupBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.originalBox = new System.Windows.Forms.GroupBox();
            this.stopwatchText = new System.Windows.Forms.Label();
            this.stopwatch = new System.Windows.Forms.Timer(this.components);
            this.puzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.SuspendLayout();
            // 
            // puzzleBox
            // 
            this.puzzleBox.Controls.Add(this.pb1);
            this.puzzleBox.Controls.Add(this.pb2);
            this.puzzleBox.Controls.Add(this.pb3);
            this.puzzleBox.Controls.Add(this.pb4);
            this.puzzleBox.Controls.Add(this.pb5);
            this.puzzleBox.Controls.Add(this.pb6);
            this.puzzleBox.Controls.Add(this.pb7);
            this.puzzleBox.Controls.Add(this.pb8);
            this.puzzleBox.Controls.Add(this.pb9);
            this.puzzleBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puzzleBox.ForeColor = System.Drawing.Color.Blue;
            this.puzzleBox.Location = new System.Drawing.Point(17, 47);
            this.puzzleBox.Name = "puzzleBox";
            this.puzzleBox.Size = new System.Drawing.Size(357, 374);
            this.puzzleBox.TabIndex = 0;
            this.puzzleBox.TabStop = false;
            this.puzzleBox.Text = "puzzleBox";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(17, 28);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 100);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(123, 28);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 100);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(229, 28);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 100);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(17, 134);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(100, 100);
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(123, 134);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(100, 100);
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(229, 134);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(100, 100);
            this.pb6.TabIndex = 5;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(17, 240);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(100, 100);
            this.pb7.TabIndex = 6;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(123, 240);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(100, 100);
            this.pb8.TabIndex = 7;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.MovePicture);
            // 
            // pb9
            // 
            this.pb9.Location = new System.Drawing.Point(229, 240);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(100, 100);
            this.pb9.TabIndex = 8;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.MovePicture);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Blue;
            this.lblText.Location = new System.Drawing.Point(12, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(153, 26);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Moves made :";
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.ForeColor = System.Drawing.Color.Blue;
            this.lblMovesMade.Location = new System.Drawing.Point(171, 9);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(24, 26);
            this.lblMovesMade.TabIndex = 2;
            this.lblMovesMade.Text = "0";
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(140, 427);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 32);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(34, 427);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(99, 32);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(246, 427);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 32);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // originalBox
            // 
            this.originalBox.BackgroundImage = global::Picture_Move_Game.Properties.Resources.original;
            this.originalBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalBox.ForeColor = System.Drawing.Color.Blue;
            this.originalBox.Location = new System.Drawing.Point(419, 47);
            this.originalBox.Name = "originalBox";
            this.originalBox.Size = new System.Drawing.Size(400, 247);
            this.originalBox.TabIndex = 7;
            this.originalBox.TabStop = false;
            this.originalBox.Text = "original";
            // 
            // stopwatchText
            // 
            this.stopwatchText.AutoSize = true;
            this.stopwatchText.Font = new System.Drawing.Font("DS-Digital", 68.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchText.Location = new System.Drawing.Point(440, 310);
            this.stopwatchText.Name = "stopwatchText";
            this.stopwatchText.Size = new System.Drawing.Size(354, 89);
            this.stopwatchText.TabIndex = 8;
            this.stopwatchText.Text = "00:00:00";
            // 
            // stopwatch
            // 
            this.stopwatch.Enabled = true;
            this.stopwatch.Interval = 1000;
            this.stopwatch.Tick += new System.EventHandler(this.stopwatch_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 480);
            this.Controls.Add(this.stopwatchText);
            this.Controls.Add(this.originalBox);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.puzzleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Move Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.puzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox puzzleBox;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox originalBox;
        private System.Windows.Forms.Label stopwatchText;
        private System.Windows.Forms.Timer stopwatch;
    }
}


