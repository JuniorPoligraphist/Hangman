namespace Hangman
{
    partial class HangmanForm
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
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthCount = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOne.Location = new System.Drawing.Point(330, 149);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(0, 39);
            this.labelOne.TabIndex = 0;
            this.labelOne.MouseLeave += new System.EventHandler(this.LabelOne_MouseLeave);
            this.labelOne.MouseHover += new System.EventHandler(this.LabelOne_MouseHover);
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwo.Location = new System.Drawing.Point(330, 210);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(0, 39);
            this.labelTwo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // healthCount
            // 
            this.healthCount.AutoSize = true;
            this.healthCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthCount.Location = new System.Drawing.Point(658, 10);
            this.healthCount.Name = "healthCount";
            this.healthCount.Size = new System.Drawing.Size(0, 17);
            this.healthCount.TabIndex = 3;
            this.healthCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(227, 125);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(0, 17);
            this.labelHint.TabIndex = 4;
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(687, 300);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.healthCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HangmanForm";
            this.Text = "Hangman App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label healthCount;
        private System.Windows.Forms.Label labelHint;
    }
}

