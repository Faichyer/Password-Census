namespace Password_Census
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.CreateTextFileButton = new ns1.BunifuFlatButton();
            this.OpenFileButton = new ns1.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CreateTextFileButton
            // 
            this.CreateTextFileButton.Activecolor = System.Drawing.Color.Indigo;
            this.CreateTextFileButton.BackColor = System.Drawing.Color.MediumPurple;
            this.CreateTextFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateTextFileButton.BorderRadius = 5;
            this.CreateTextFileButton.ButtonText = "Create a new text file";
            this.CreateTextFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTextFileButton.DisabledColor = System.Drawing.Color.Gray;
            this.CreateTextFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTextFileButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CreateTextFileButton.Iconimage = null;
            this.CreateTextFileButton.Iconimage_right = null;
            this.CreateTextFileButton.Iconimage_right_Selected = null;
            this.CreateTextFileButton.Iconimage_Selected = null;
            this.CreateTextFileButton.IconMarginLeft = 0;
            this.CreateTextFileButton.IconMarginRight = 0;
            this.CreateTextFileButton.IconRightVisible = true;
            this.CreateTextFileButton.IconRightZoom = 0D;
            this.CreateTextFileButton.IconVisible = true;
            this.CreateTextFileButton.IconZoom = 90D;
            this.CreateTextFileButton.IsTab = false;
            this.CreateTextFileButton.Location = new System.Drawing.Point(370, 284);
            this.CreateTextFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateTextFileButton.Name = "CreateTextFileButton";
            this.CreateTextFileButton.Normalcolor = System.Drawing.Color.MediumPurple;
            this.CreateTextFileButton.OnHovercolor = System.Drawing.Color.Purple;
            this.CreateTextFileButton.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateTextFileButton.selected = false;
            this.CreateTextFileButton.Size = new System.Drawing.Size(253, 90);
            this.CreateTextFileButton.TabIndex = 0;
            this.CreateTextFileButton.Text = "Create a new text file";
            this.CreateTextFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateTextFileButton.Textcolor = System.Drawing.Color.White;
            this.CreateTextFileButton.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTextFileButton.Click += new System.EventHandler(this.CreateTextFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.ActiveBorderThickness = 1;
            this.OpenFileButton.ActiveCornerRadius = 20;
            this.OpenFileButton.ActiveFillColor = System.Drawing.Color.Purple;
            this.OpenFileButton.ActiveForecolor = System.Drawing.Color.White;
            this.OpenFileButton.ActiveLineColor = System.Drawing.Color.DarkViolet;
            this.OpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.OpenFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.BackgroundImage")));
            this.OpenFileButton.ButtonText = "Open a text file";
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.OpenFileButton.IdleBorderThickness = 1;
            this.OpenFileButton.IdleCornerRadius = 20;
            this.OpenFileButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.OpenFileButton.IdleForecolor = System.Drawing.Color.MediumPurple;
            this.OpenFileButton.IdleLineColor = System.Drawing.Color.MediumPurple;
            this.OpenFileButton.Location = new System.Drawing.Point(53, 278);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(250, 102);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Amarillo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(173, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password Census";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(592, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(675, 585);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.CreateTextFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuThinButton2 OpenFileButton;
        private ns1.BunifuFlatButton CreateTextFileButton;
        private ns1.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
    }
}

