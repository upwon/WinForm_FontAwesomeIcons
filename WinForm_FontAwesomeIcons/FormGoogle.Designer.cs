namespace WinForm_FontAwesomeIcons
{
    partial class FormGoogle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoogle));
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.iconButtonOpenMusic = new FontAwesome.Sharp.IconButton();
            this.iconButtonNextMusic = new FontAwesome.Sharp.IconButton();
            this.iconButtonPreMusic = new FontAwesome.Sharp.IconButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconPictureBox1.IconSize = 88;
            this.iconPictureBox1.Location = new System.Drawing.Point(876, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(115, 88);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.ItemHeight = 15;
            this.listBoxMusic.Location = new System.Drawing.Point(12, 78);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(398, 349);
            this.listBoxMusic.TabIndex = 2;
            this.listBoxMusic.DoubleClick += new System.EventHandler(this.listBoxMusic_DoubleClick);
            // 
            // iconButtonOpenMusic
            // 
            this.iconButtonOpenMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOpenMusic.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOpenMusic.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenMusic.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.iconButtonOpenMusic.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButtonOpenMusic.IconSize = 48;
            this.iconButtonOpenMusic.Location = new System.Drawing.Point(446, 12);
            this.iconButtonOpenMusic.Name = "iconButtonOpenMusic";
            this.iconButtonOpenMusic.Rotation = 0D;
            this.iconButtonOpenMusic.Size = new System.Drawing.Size(107, 54);
            this.iconButtonOpenMusic.TabIndex = 6;
            this.iconButtonOpenMusic.Text = "打开";
            this.iconButtonOpenMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOpenMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOpenMusic.UseVisualStyleBackColor = true;
            this.iconButtonOpenMusic.Click += new System.EventHandler(this.iconButtonOpenMusic_Click);
            // 
            // iconButtonNextMusic
            // 
            this.iconButtonNextMusic.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonNextMusic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonNextMusic.IconColor = System.Drawing.Color.Black;
            this.iconButtonNextMusic.IconSize = 16;
            this.iconButtonNextMusic.Location = new System.Drawing.Point(578, 28);
            this.iconButtonNextMusic.Name = "iconButtonNextMusic";
            this.iconButtonNextMusic.Rotation = 0D;
            this.iconButtonNextMusic.Size = new System.Drawing.Size(75, 23);
            this.iconButtonNextMusic.TabIndex = 7;
            this.iconButtonNextMusic.Text = "下一曲";
            this.iconButtonNextMusic.UseVisualStyleBackColor = true;
            this.iconButtonNextMusic.Click += new System.EventHandler(this.iconButtonNextMusic_Click);
            // 
            // iconButtonPreMusic
            // 
            this.iconButtonPreMusic.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPreMusic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonPreMusic.IconColor = System.Drawing.Color.Black;
            this.iconButtonPreMusic.IconSize = 16;
            this.iconButtonPreMusic.Location = new System.Drawing.Point(717, 28);
            this.iconButtonPreMusic.Name = "iconButtonPreMusic";
            this.iconButtonPreMusic.Rotation = 0D;
            this.iconButtonPreMusic.Size = new System.Drawing.Size(75, 23);
            this.iconButtonPreMusic.TabIndex = 8;
            this.iconButtonPreMusic.Text = "上一曲";
            this.iconButtonPreMusic.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(446, 115);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(527, 386);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // FormGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 569);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.iconButtonPreMusic);
            this.Controls.Add(this.iconButtonNextMusic);
            this.Controls.Add(this.iconButtonOpenMusic);
            this.Controls.Add(this.listBoxMusic);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "FormGoogle";
            this.Text = "FormGoogle";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ListBox listBoxMusic;
        private FontAwesome.Sharp.IconButton iconButtonOpenMusic;
        private FontAwesome.Sharp.IconButton iconButtonNextMusic;
        private FontAwesome.Sharp.IconButton iconButtonPreMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}