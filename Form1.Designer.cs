
namespace TimerLessonDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.counterLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(69, 51);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(69, 13);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "counterLabel";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(114, 192);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(122, 47);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // countTimer
            // 
            this.countTimer.Enabled = true;
            this.countTimer.Interval = 1000;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // colorLabel
            // 
            this.colorLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.colorLabel.Location = new System.Drawing.Point(69, 89);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(167, 52);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "ColorLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.counterLabel);
            this.Name = "Form1";
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Label colorLabel;
    }
}

