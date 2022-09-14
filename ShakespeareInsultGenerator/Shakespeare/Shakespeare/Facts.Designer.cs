namespace Shakespeare
{
    partial class Facts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facts));
            this.Generaterandomfact = new System.Windows.Forms.Button();
            this.Randomfact = new System.Windows.Forms.Label();
            this.Gotomainmenu = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.Portrait = new System.Windows.Forms.PictureBox();
            this.Titlefacts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // Generaterandomfact
            // 
            this.Generaterandomfact.BackColor = System.Drawing.Color.Gainsboro;
            this.Generaterandomfact.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generaterandomfact.ForeColor = System.Drawing.Color.Black;
            this.Generaterandomfact.Location = new System.Drawing.Point(25, 105);
            this.Generaterandomfact.Name = "Generaterandomfact";
            this.Generaterandomfact.Size = new System.Drawing.Size(497, 57);
            this.Generaterandomfact.TabIndex = 0;
            this.Generaterandomfact.Text = "Showeth me thy by fate facts! ";
            this.Generaterandomfact.UseVisualStyleBackColor = false;
            this.Generaterandomfact.Click += new System.EventHandler(this.Generaterandomfact_Click);
            // 
            // Randomfact
            // 
            this.Randomfact.BackColor = System.Drawing.Color.White;
            this.Randomfact.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomfact.ForeColor = System.Drawing.Color.Black;
            this.Randomfact.Location = new System.Drawing.Point(25, 184);
            this.Randomfact.Name = "Randomfact";
            this.Randomfact.Size = new System.Drawing.Size(497, 357);
            this.Randomfact.TabIndex = 3;
            this.Randomfact.Text = "Hither will be by fate facts of of the most wondrous sir that is Shakespeare!";
            this.Randomfact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gotomainmenu
            // 
            this.Gotomainmenu.BackColor = System.Drawing.Color.Gainsboro;
            this.Gotomainmenu.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gotomainmenu.Location = new System.Drawing.Point(542, 431);
            this.Gotomainmenu.Name = "Gotomainmenu";
            this.Gotomainmenu.Size = new System.Drawing.Size(213, 110);
            this.Gotomainmenu.TabIndex = 4;
            this.Gotomainmenu.Text = "Taketh me to thy Menu";
            this.Gotomainmenu.UseVisualStyleBackColor = false;
            this.Gotomainmenu.Click += new System.EventHandler(this.Gotomainmenu_Click);
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.Gainsboro;
            this.Helpbutton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.Location = new System.Drawing.Point(542, 336);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(213, 79);
            this.Helpbutton.TabIndex = 6;
            this.Helpbutton.Text = "Doth thy Require Assistance?";
            this.Helpbutton.UseVisualStyleBackColor = false;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // Portrait
            // 
            this.Portrait.Image = global::Shakespeare.Properties.Resources.giphy__1_;
            this.Portrait.Location = new System.Drawing.Point(542, 29);
            this.Portrait.Name = "Portrait";
            this.Portrait.Size = new System.Drawing.Size(213, 289);
            this.Portrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Portrait.TabIndex = 2;
            this.Portrait.TabStop = false;
            // 
            // Titlefacts
            // 
            this.Titlefacts.BackColor = System.Drawing.Color.NavajoWhite;
            this.Titlefacts.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Bold);
            this.Titlefacts.ForeColor = System.Drawing.Color.Black;
            this.Titlefacts.Location = new System.Drawing.Point(28, 29);
            this.Titlefacts.Name = "Titlefacts";
            this.Titlefacts.Size = new System.Drawing.Size(494, 55);
            this.Titlefacts.TabIndex = 8;
            this.Titlefacts.Text = "SHAKESPEAREAN FACTS";
            this.Titlefacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Facts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(781, 566);
            this.ControlBox = false;
            this.Controls.Add(this.Titlefacts);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.Gotomainmenu);
            this.Controls.Add(this.Randomfact);
            this.Controls.Add(this.Portrait);
            this.Controls.Add(this.Generaterandomfact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facts";
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generaterandomfact;
        private System.Windows.Forms.PictureBox Portrait;
        private System.Windows.Forms.Label Randomfact;
        private System.Windows.Forms.Button Gotomainmenu;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Label Titlefacts;
    }
}