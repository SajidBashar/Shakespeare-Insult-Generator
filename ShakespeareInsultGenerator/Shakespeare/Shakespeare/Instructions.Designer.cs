namespace Shakespeare
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.Title = new System.Windows.Forms.Label();
            this.Instructionstext = new System.Windows.Forms.Label();
            this.Backtomenu = new System.Windows.Forms.Button();
            this.Englishflag = new System.Windows.Forms.PictureBox();
            this.Thinking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Englishflag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thinking)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.NavajoWhite;
            this.Title.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(29, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(734, 55);
            this.Title.TabIndex = 5;
            this.Title.Text = "- GUIDANCE FOR THEE -";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Instructionstext
            // 
            this.Instructionstext.BackColor = System.Drawing.Color.White;
            this.Instructionstext.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructionstext.ForeColor = System.Drawing.Color.Black;
            this.Instructionstext.Location = new System.Drawing.Point(29, 101);
            this.Instructionstext.Name = "Instructionstext";
            this.Instructionstext.Size = new System.Drawing.Size(517, 338);
            this.Instructionstext.TabIndex = 6;
            this.Instructionstext.Text = resources.GetString("Instructionstext.Text");
            this.Instructionstext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Backtomenu
            // 
            this.Backtomenu.BackColor = System.Drawing.Color.Gainsboro;
            this.Backtomenu.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backtomenu.Location = new System.Drawing.Point(27, 462);
            this.Backtomenu.Name = "Backtomenu";
            this.Backtomenu.Size = new System.Drawing.Size(736, 59);
            this.Backtomenu.TabIndex = 7;
            this.Backtomenu.Text = "Wend Back";
            this.Backtomenu.UseVisualStyleBackColor = false;
            this.Backtomenu.Click += new System.EventHandler(this.Backtomenu_Click);
            // 
            // Englishflag
            // 
            this.Englishflag.Image = global::Shakespeare.Properties.Resources.RedCheeryAfricangroundhornbill_max_1mb;
            this.Englishflag.Location = new System.Drawing.Point(573, 101);
            this.Englishflag.Name = "Englishflag";
            this.Englishflag.Size = new System.Drawing.Size(190, 170);
            this.Englishflag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Englishflag.TabIndex = 10;
            this.Englishflag.TabStop = false;
            // 
            // Thinking
            // 
            this.Thinking.Image = global::Shakespeare.Properties.Resources.william_shakespeare___the_life_of_the_bard;
            this.Thinking.Location = new System.Drawing.Point(573, 329);
            this.Thinking.Name = "Thinking";
            this.Thinking.Size = new System.Drawing.Size(190, 110);
            this.Thinking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thinking.TabIndex = 9;
            this.Thinking.TabStop = false;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 543);
            this.ControlBox = false;
            this.Controls.Add(this.Englishflag);
            this.Controls.Add(this.Thinking);
            this.Controls.Add(this.Backtomenu);
            this.Controls.Add(this.Instructionstext);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.Englishflag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thinking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Instructionstext;
        private System.Windows.Forms.Button Backtomenu;
        private System.Windows.Forms.PictureBox Thinking;
        private System.Windows.Forms.PictureBox Englishflag;
    }
}