namespace WinForm_FontAwesomeIcons
{
    partial class FormBlog
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.forwardButton = new FontAwesome.Sharp.IconButton();
            this.backButton = new FontAwesome.Sharp.IconButton();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.iconButtonGo = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(866, 17);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(55, 15);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.forwardButton.ForeColor = System.Drawing.Color.White;
            this.forwardButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.forwardButton.IconColor = System.Drawing.Color.White;
            this.forwardButton.IconSize = 32;
            this.forwardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forwardButton.Location = new System.Drawing.Point(80, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Rotation = 0D;
            this.forwardButton.Size = new System.Drawing.Size(106, 42);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "Forward";
            this.forwardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.backButton.IconColor = System.Drawing.Color.White;
            this.backButton.IconSize = 32;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(0, 3);
            this.backButton.Name = "backButton";
            this.backButton.Rotation = 0D;
            this.backButton.Size = new System.Drawing.Size(84, 42);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxURL.Font = new System.Drawing.Font("思源黑体 Normal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxURL.ForeColor = System.Drawing.Color.Black;
            this.textBoxURL.Location = new System.Drawing.Point(182, 9);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(533, 32);
            this.textBoxURL.TabIndex = 4;
            // 
            // iconButtonGo
            // 
            this.iconButtonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.iconButtonGo.FlatAppearance.BorderSize = 0;
            this.iconButtonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonGo.ForeColor = System.Drawing.Color.White;
            this.iconButtonGo.IconChar = FontAwesome.Sharp.IconChar.Google;
            this.iconButtonGo.IconColor = System.Drawing.Color.White;
            this.iconButtonGo.IconSize = 32;
            this.iconButtonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGo.Location = new System.Drawing.Point(721, 7);
            this.iconButtonGo.Name = "iconButtonGo";
            this.iconButtonGo.Rotation = 0D;
            this.iconButtonGo.Size = new System.Drawing.Size(114, 34);
            this.iconButtonGo.TabIndex = 5;
            this.iconButtonGo.Text = "Go";
            this.iconButtonGo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGo.UseVisualStyleBackColor = false;
            this.iconButtonGo.Click += new System.EventHandler(this.iconButtonGo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.outputLabel);
            this.panel1.Controls.Add(this.iconButtonGo);
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Controls.Add(this.textBoxURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 45);
            this.panel1.TabIndex = 6;
            // 
            // FormBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 548);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBlog";
            this.Text = "FormBlog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private FontAwesome.Sharp.IconButton forwardButton;
        private FontAwesome.Sharp.IconButton backButton;
        private System.Windows.Forms.TextBox textBoxURL;
        private FontAwesome.Sharp.IconButton iconButtonGo;
        private System.Windows.Forms.Panel panel1;
    }
}