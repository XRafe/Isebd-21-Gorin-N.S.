namespace Lab1Var5
{
    partial class FormParking
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBoxGeneral = new System.Windows.Forms.PictureBox();
            this.pictureBoxDop = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelPickUp = new System.Windows.Forms.Label();
            this.buttonToPut = new System.Windows.Forms.Button();
            this.buttonToPutTun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDop)).BeginInit();
            this.SuspendLayout();

            this.pictureBoxGeneral.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxGeneral.Name = "pictureBoxGeneral";
            this.pictureBoxGeneral.Size = new System.Drawing.Size(529, 464);
            this.pictureBoxGeneral.TabIndex = 0;
            this.pictureBoxGeneral.TabStop = false;

            this.pictureBoxDop.Location = new System.Drawing.Point(533, 255);
            this.pictureBoxDop.Name = "pictureBoxDop";
            this.pictureBoxDop.Size = new System.Drawing.Size(176, 131);
            this.pictureBoxDop.TabIndex = 1;
            this.pictureBoxDop.TabStop = false;

            this.maskedTextBoxPlace.Location = new System.Drawing.Point(624, 200);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxPlace.TabIndex = 2;

            this.buttonPickUp.Location = new System.Drawing.Point(567, 226);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(79, 23);
            this.buttonPickUp.TabIndex = 3;
            this.buttonPickUp.Text = "Забрать";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);

            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(564, 203);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место:";

            this.labelPickUp.AutoSize = true;
            this.labelPickUp.Location = new System.Drawing.Point(564, 173);
            this.labelPickUp.Name = "labelPickUp";
            this.labelPickUp.Size = new System.Drawing.Size(94, 13);
            this.labelPickUp.TabIndex = 5;
            this.labelPickUp.Text = "Забрать корабль";

            this.buttonToPut.Location = new System.Drawing.Point(567, 11);
            this.buttonToPut.Name = "buttonToPut";
            this.buttonToPut.Size = new System.Drawing.Size(100, 39);
            this.buttonToPut.TabIndex = 6;
            this.buttonToPut.Text = "Припарковать корабль";
            this.buttonToPut.UseVisualStyleBackColor = true;
            this.buttonToPut.Click += new System.EventHandler(this.buttonToPut_Click);

            this.buttonToPutTun.Location = new System.Drawing.Point(567, 56);
            this.buttonToPutTun.Name = "buttonToPutTun";
            this.buttonToPutTun.Size = new System.Drawing.Size(100, 40);
            this.buttonToPutTun.TabIndex = 7;
            this.buttonToPutTun.Text = "Припарковать тюнинг корабль";
            this.buttonToPutTun.UseVisualStyleBackColor = true;
            this.buttonToPutTun.Click += new System.EventHandler(this.buttonToPutTun_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 468);
            this.Controls.Add(this.buttonToPutTun);
            this.Controls.Add(this.buttonToPut);
            this.Controls.Add(this.labelPickUp);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.buttonPickUp);
            this.Controls.Add(this.maskedTextBoxPlace);
            this.Controls.Add(this.pictureBoxDop);
            this.Controls.Add(this.pictureBoxGeneral);
            this.Name = "FormParking";
            this.Text = "Пристань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGeneral;

        private System.Windows.Forms.PictureBox pictureBoxDop;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;

        private System.Windows.Forms.Button buttonPickUp;

        private System.Windows.Forms.Label labelPlace;

        private System.Windows.Forms.Label labelPickUp;

        private System.Windows.Forms.Button buttonToPut;

        private System.Windows.Forms.Button buttonToPutTun;
    }
}