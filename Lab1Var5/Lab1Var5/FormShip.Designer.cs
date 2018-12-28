namespace Lab1Var5
{
    partial class FormShip
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.CrSt = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxShips = new System.Windows.Forms.PictureBox();
            this.CrTun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).BeginInit();
            this.SuspendLayout();

            this.CrSt.Location = new System.Drawing.Point(8, 8);
            this.CrSt.Name = "CrSt";
            this.CrSt.Size = new System.Drawing.Size(91, 23);
            this.CrSt.TabIndex = 1;
            this.CrSt.Text = "Create Standart";
            this.CrSt.UseVisualStyleBackColor = true;
            this.CrSt.Click += new System.EventHandler(this.buttonCreate_Click);

            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Lab1Var5.Properties.Resources.left1;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLeft.Location = new System.Drawing.Point(511, 279);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);

            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::Lab1Var5.Properties.Resources.down1;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDown.Location = new System.Drawing.Point(544, 279);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);

            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Lab1Var5.Properties.Resources.right1;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRight.Location = new System.Drawing.Point(578, 279);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);

            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Lab1Var5.Properties.Resources.up1;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUp.Location = new System.Drawing.Point(544, 245);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);

            this.pictureBoxShips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShips.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShips.Name = "pictureBoxShips";
            this.pictureBoxShips.Size = new System.Drawing.Size(736, 333);
            this.pictureBoxShips.TabIndex = 0;
            this.pictureBoxShips.TabStop = false;

            this.CrTun.Location = new System.Drawing.Point(511, 8);
            this.CrTun.Name = "CrTun";
            this.CrTun.Size = new System.Drawing.Size(97, 23);
            this.CrTun.TabIndex = 6;
            this.CrTun.Text = "Create Tuning";
            this.CrTun.UseVisualStyleBackColor = true;
            this.CrTun.Click += new System.EventHandler(this.button1_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 333);
            this.Controls.Add(this.CrTun);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.CrSt);
            this.Controls.Add(this.pictureBoxShips);
            this.Name = "FormShip";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShips;

        private System.Windows.Forms.Button CrSt;

        private System.Windows.Forms.Button buttonUp;

        private System.Windows.Forms.Button buttonLeft;

        private System.Windows.Forms.Button buttonDown;

        private System.Windows.Forms.Button buttonRight;

        private System.Windows.Forms.Button CrTun;
    }
}

