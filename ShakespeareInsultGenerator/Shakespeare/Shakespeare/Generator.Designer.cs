namespace Shakespeare
{
    partial class Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.Generate = new System.Windows.Forms.Button();
            this.Randomsentence = new System.Windows.Forms.Label();
            this.Translation = new System.Windows.Forms.Label();
            this.Shakespeareheading = new System.Windows.Forms.Label();
            this.Translationheading = new System.Windows.Forms.Label();
            this.Gotodictionary = new System.Windows.Forms.Button();
            this.Gotomainmenu = new System.Windows.Forms.Button();
            this.Shakespeareportrait = new System.Windows.Forms.PictureBox();
            this.Help = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Aestheticline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Shakespeareportrait)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.Gainsboro;
            this.Generate.Font = new System.Drawing.Font("Felix Titling", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(26, 20);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(738, 106);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Maketh thy Random Fig";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Randomsentence
            // 
            this.Randomsentence.BackColor = System.Drawing.Color.White;
            this.Randomsentence.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomsentence.Location = new System.Drawing.Point(214, 211);
            this.Randomsentence.Name = "Randomsentence";
            this.Randomsentence.Size = new System.Drawing.Size(550, 176);
            this.Randomsentence.TabIndex = 2;
            this.Randomsentence.Text = "Hither will be thy insult!";
            this.Randomsentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Translation
            // 
            this.Translation.BackColor = System.Drawing.Color.White;
            this.Translation.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Translation.Location = new System.Drawing.Point(28, 465);
            this.Translation.Name = "Translation";
            this.Translation.Size = new System.Drawing.Size(736, 136);
            this.Translation.TabIndex = 3;
            this.Translation.Text = "Here will be your translation!";
            this.Translation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shakespeareheading
            // 
            this.Shakespeareheading.BackColor = System.Drawing.Color.NavajoWhite;
            this.Shakespeareheading.Font = new System.Drawing.Font("Felix Titling", 20F);
            this.Shakespeareheading.ForeColor = System.Drawing.Color.Black;
            this.Shakespeareheading.Location = new System.Drawing.Point(30, 139);
            this.Shakespeareheading.Name = "Shakespeareheading";
            this.Shakespeareheading.Size = new System.Drawing.Size(734, 55);
            this.Shakespeareheading.TabIndex = 4;
            this.Shakespeareheading.Text = "- Shakespearean -";
            this.Shakespeareheading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Translationheading
            // 
            this.Translationheading.BackColor = System.Drawing.Color.NavajoWhite;
            this.Translationheading.Font = new System.Drawing.Font("Felix Titling", 20F);
            this.Translationheading.ForeColor = System.Drawing.Color.Black;
            this.Translationheading.Location = new System.Drawing.Point(30, 404);
            this.Translationheading.Name = "Translationheading";
            this.Translationheading.Size = new System.Drawing.Size(734, 46);
            this.Translationheading.TabIndex = 5;
            this.Translationheading.Text = "- Mod\'rn Translation -";
            this.Translationheading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gotodictionary
            // 
            this.Gotodictionary.BackColor = System.Drawing.Color.Gainsboro;
            this.Gotodictionary.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gotodictionary.Location = new System.Drawing.Point(412, 621);
            this.Gotodictionary.Name = "Gotodictionary";
            this.Gotodictionary.Size = new System.Drawing.Size(145, 59);
            this.Gotodictionary.TabIndex = 7;
            this.Gotodictionary.Text = "Dictionary";
            this.Gotodictionary.UseVisualStyleBackColor = false;
            this.Gotodictionary.Click += new System.EventHandler(this.Gotodictionary_Click);
            // 
            // Gotomainmenu
            // 
            this.Gotomainmenu.BackColor = System.Drawing.Color.Gainsboro;
            this.Gotomainmenu.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gotomainmenu.Location = new System.Drawing.Point(194, 621);
            this.Gotomainmenu.Name = "Gotomainmenu";
            this.Gotomainmenu.Size = new System.Drawing.Size(197, 59);
            this.Gotomainmenu.TabIndex = 8;
            this.Gotomainmenu.Text = "Main Menu";
            this.Gotomainmenu.UseVisualStyleBackColor = false;
            this.Gotomainmenu.Click += new System.EventHandler(this.Gotomainmenu_Click);
            // 
            // Shakespeareportrait
            // 
            this.Shakespeareportrait.Image = global::Shakespeare.Properties.Resources.william_shakespeare_194895_1_402;
            this.Shakespeareportrait.Location = new System.Drawing.Point(28, 211);
            this.Shakespeareportrait.Name = "Shakespeareportrait";
            this.Shakespeareportrait.Size = new System.Drawing.Size(169, 176);
            this.Shakespeareportrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shakespeareportrait.TabIndex = 0;
            this.Shakespeareportrait.TabStop = false;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Gainsboro;
            this.Help.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(582, 621);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(182, 59);
            this.Help.TabIndex = 10;
            this.Help.Text = "Doth thy Require Assistance?";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.Gainsboro;
            this.Clearbutton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(26, 621);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(121, 59);
            this.Clearbutton.TabIndex = 11;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Aestheticline
            // 
            this.Aestheticline.BackColor = System.Drawing.Color.Gainsboro;
            this.Aestheticline.Location = new System.Drawing.Point(168, 621);
            this.Aestheticline.Name = "Aestheticline";
            this.Aestheticline.Size = new System.Drawing.Size(5, 59);
            this.Aestheticline.TabIndex = 12;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(794, 701);
            this.ControlBox = false;
            this.Controls.Add(this.Aestheticline);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Gotomainmenu);
            this.Controls.Add(this.Gotodictionary);
            this.Controls.Add(this.Translationheading);
            this.Controls.Add(this.Shakespeareheading);
            this.Controls.Add(this.Translation);
            this.Controls.Add(this.Randomsentence);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Shakespeareportrait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insult Generator";
            ((System.ComponentModel.ISupportInitialize)(this.Shakespeareportrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Shakespeareportrait;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label Randomsentence;
        private System.Windows.Forms.Label Translation;
        private System.Windows.Forms.Label Shakespeareheading;
        private System.Windows.Forms.Label Translationheading;
        private System.Windows.Forms.Button Gotodictionary;
        private System.Windows.Forms.Button Gotomainmenu;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Label Aestheticline;
    }
}