namespace POMODARO
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
            this.button1 = new System.Windows.Forms.Button();
            this.sec = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tick_wk = new System.Windows.Forms.Timer(this.components);
            this.High = new System.Windows.Forms.Label();
            this.tick_rest = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sec.Location = new System.Drawing.Point(182, 110);
            this.sec.Name = "sec";
            this.sec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sec.Size = new System.Drawing.Size(55, 37);
            this.sec.TabIndex = 1;
            this.sec.Text = "00";
            this.sec.Click += new System.EventHandler(this.Sec_Click);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.min.Location = new System.Drawing.Point(112, 110);
            this.min.Name = "min";
            this.min.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.min.Size = new System.Drawing.Size(55, 37);
            this.min.TabIndex = 2;
            this.min.Text = "00";
            this.min.Click += new System.EventHandler(this.Min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 109);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(25, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // tick_wk
            // 
            this.tick_wk.Interval = 1000;
            this.tick_wk.Tick += new System.EventHandler(this.TICK_WORK);
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.High.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.High.Location = new System.Drawing.Point(3, 256);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(121, 37);
            this.High.TabIndex = 4;
            this.High.Text = "READY ";
            this.High.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.High.Click += new System.EventHandler(this.High_Click);
            // 
            // tick_rest
            // 
            this.tick_rest.Interval = 1000;
            this.tick_rest.Tick += new System.EventHandler(this.tickrest);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(64, 26);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(216, 204);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 6;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(366, 502);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.High);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tick_wk;
        private System.Windows.Forms.Label High;
        private System.Windows.Forms.Timer tick_rest;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

