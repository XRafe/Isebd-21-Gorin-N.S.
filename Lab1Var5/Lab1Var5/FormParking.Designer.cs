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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.buttonSetTuningShip = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.SuspendLayout();

            this.pictureBoxParking.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(529, 464);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;

            this.pictureBoxTakeShip.Location = new System.Drawing.Point(533, 325);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(186, 131);
            this.pictureBoxTakeShip.TabIndex = 1;
            this.pictureBoxTakeShip.TabStop = false;

            this.maskedTextBox.Location = new System.Drawing.Point(536, 297);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox.TabIndex = 2;

            this.buttonTakeShip.Location = new System.Drawing.Point(584, 296);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(79, 23);
            this.buttonTakeShip.TabIndex = 3;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Место:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Забрать корабль";

            this.buttonSetShip.Location = new System.Drawing.Point(533, 199);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(89, 55);
            this.buttonSetShip.TabIndex = 6;
            this.buttonSetShip.Text = "Припарковать корабль";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);

            this.buttonSetTuningShip.Location = new System.Drawing.Point(629, 199);
            this.buttonSetTuningShip.Name = "buttonSetTuningShip";
            this.buttonSetTuningShip.Size = new System.Drawing.Size(90, 55);
            this.buttonSetTuningShip.TabIndex = 7;
            this.buttonSetTuningShip.Text = "Припарковать тюнинг корабль";
            this.buttonSetTuningShip.UseVisualStyleBackColor = true;
            this.buttonSetTuningShip.Click += new System.EventHandler(this.buttonSetTuningShip_Click);

            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(533, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged_1);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 468);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.buttonSetTuningShip);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeShip);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.pictureBoxTakeShip);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Пристань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;

        private System.Windows.Forms.PictureBox pictureBoxTakeShip;

        private System.Windows.Forms.MaskedTextBox maskedTextBox;

        private System.Windows.Forms.Button buttonTakeShip;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonSetShip;

        private System.Windows.Forms.Button buttonSetTuningShip;

        private System.Windows.Forms.ListBox listBoxLevels;
    }
}