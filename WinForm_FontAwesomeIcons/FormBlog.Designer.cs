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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButtonGo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(866, 5);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(55, 15);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            // 
            // forwardButton
            // 
            this.forwardButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.forwardButton.ForeColor = System.Drawing.Color.White;
            this.forwardButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.forwardButton.IconColor = System.Drawing.Color.White;
            this.forwardButton.IconSize = 32;
            this.forwardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forwardButton.Location = new System.Drawing.Point(119, -10);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Rotation = 0D;
            this.forwardButton.Size = new System.Drawing.Size(109, 50);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "Forward";
            this.forwardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.forwardButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.backButton.IconColor = System.Drawing.Color.White;
            this.backButton.IconSize = 32;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(4, -10);
            this.backButton.Name = "backButton";
            this.backButton.Rotation = 0D;
            this.backButton.Size = new System.Drawing.Size(109, 50);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 25);
            this.textBox1.TabIndex = 4;
            // 
            // iconButtonGo
            // 
            this.iconButtonGo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonGo.ForeColor = System.Drawing.Color.White;
            this.iconButtonGo.IconChar = FontAwesome.Sharp.IconChar.Google;
            this.iconButtonGo.IconColor = System.Drawing.Color.White;
            this.iconButtonGo.IconSize = 32;
            this.iconButtonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGo.Location = new System.Drawing.Point(718, 5);
            this.iconButtonGo.Name = "iconButtonGo";
            this.iconButtonGo.Rotation = 0D;
            this.iconButtonGo.Size = new System.Drawing.Size(89, 57);
            this.iconButtonGo.TabIndex = 5;
            this.iconButtonGo.Text = "Forward";
            this.iconButtonGo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGo.UseVisualStyleBackColor = true;
            // 
            // FormBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 548);
            this.Controls.Add(this.iconButtonGo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.outputLabel);
            this.Name = "FormBlog";
            this.Text = "FormBlog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private FontAwesome.Sharp.IconButton forwardButton;
        private FontAwesome.Sharp.IconButton backButton;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButtonGo;
    }
}