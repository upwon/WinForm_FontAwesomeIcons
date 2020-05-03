namespace WinForm_FontAwesomeIcons
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.iconbtnCloseMsbox = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconbtnCloseMsbox
            // 
            this.iconbtnCloseMsbox.BackColor = System.Drawing.Color.LightSalmon;
            this.iconbtnCloseMsbox.FlatAppearance.BorderSize = 0;
            this.iconbtnCloseMsbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnCloseMsbox.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnCloseMsbox.Font = new System.Drawing.Font("思源黑体 CN Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconbtnCloseMsbox.ForeColor = System.Drawing.Color.White;
            this.iconbtnCloseMsbox.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconbtnCloseMsbox.IconColor = System.Drawing.Color.White;
            this.iconbtnCloseMsbox.IconSize = 48;
            this.iconbtnCloseMsbox.Location = new System.Drawing.Point(345, 395);
            this.iconbtnCloseMsbox.Name = "iconbtnCloseMsbox";
            this.iconbtnCloseMsbox.Rotation = 0D;
            this.iconbtnCloseMsbox.Size = new System.Drawing.Size(130, 61);
            this.iconbtnCloseMsbox.TabIndex = 0;
            this.iconbtnCloseMsbox.Text = "关闭";
            this.iconbtnCloseMsbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnCloseMsbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnCloseMsbox.UseVisualStyleBackColor = false;
            this.iconbtnCloseMsbox.Click += new System.EventHandler(this.iconbtnCloseMsbox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForm_FontAwesomeIcons.Properties.Resources.rect4531;
            this.pictureBox1.Location = new System.Drawing.Point(83, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconbtnCloseMsbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnCloseMsbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}