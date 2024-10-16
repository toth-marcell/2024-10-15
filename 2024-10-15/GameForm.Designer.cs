
namespace _2024_10_15
{
    partial class GameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crossingGate = new System.Windows.Forms.PictureBox();
            this.toggleGatesButton = new System.Windows.Forms.Button();
            this.track1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crossingGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // crossingGate
            // 
            this.crossingGate.BackColor = System.Drawing.Color.Gray;
            this.crossingGate.Location = new System.Drawing.Point(244, 103);
            this.crossingGate.Name = "crossingGate";
            this.crossingGate.Size = new System.Drawing.Size(10, 259);
            this.crossingGate.TabIndex = 2;
            this.crossingGate.TabStop = false;
            // 
            // toggleGatesButton
            // 
            this.toggleGatesButton.Location = new System.Drawing.Point(600, 9);
            this.toggleGatesButton.Name = "toggleGatesButton";
            this.toggleGatesButton.Size = new System.Drawing.Size(188, 38);
            this.toggleGatesButton.TabIndex = 3;
            this.toggleGatesButton.Text = "toggle gates";
            this.toggleGatesButton.UseVisualStyleBackColor = true;
            this.toggleGatesButton.Click += new System.EventHandler(this.toggleGatesButton_Click);
            // 
            // track1
            // 
            this.track1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track1.Location = new System.Drawing.Point(291, -3);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(10, 454);
            this.track1.TabIndex = 4;
            this.track1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(338, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 454);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.track1);
            this.Controls.Add(this.toggleGatesButton);
            this.Controls.Add(this.crossingGate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Train game";
            ((System.ComponentModel.ISupportInitialize)(this.crossingGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox crossingGate;
        private System.Windows.Forms.Button toggleGatesButton;
        private System.Windows.Forms.PictureBox track1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

