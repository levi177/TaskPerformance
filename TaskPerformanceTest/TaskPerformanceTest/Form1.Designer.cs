
namespace TaskPerformanceTest
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
            this.StartButton = new System.Windows.Forms.Button();
            this.TextBoxOneIndividual = new System.Windows.Forms.TextBox();
            this.TextBoxTwoIndividual = new System.Windows.Forms.TextBox();
            this.TextBoxOneOverall = new System.Windows.Forms.TextBox();
            this.TextBoxTwoOverall = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(143, 42);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TextBoxOneIndividual
            // 
            this.TextBoxOneIndividual.Location = new System.Drawing.Point(33, 103);
            this.TextBoxOneIndividual.Multiline = true;
            this.TextBoxOneIndividual.Name = "TextBoxOneIndividual";
            this.TextBoxOneIndividual.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxOneIndividual.Size = new System.Drawing.Size(128, 210);
            this.TextBoxOneIndividual.TabIndex = 1;
            // 
            // TextBoxTwoIndividual
            // 
            this.TextBoxTwoIndividual.Location = new System.Drawing.Point(203, 103);
            this.TextBoxTwoIndividual.Multiline = true;
            this.TextBoxTwoIndividual.Name = "TextBoxTwoIndividual";
            this.TextBoxTwoIndividual.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxTwoIndividual.Size = new System.Drawing.Size(128, 210);
            this.TextBoxTwoIndividual.TabIndex = 2;
            // 
            // TextBoxOneOverall
            // 
            this.TextBoxOneOverall.Location = new System.Drawing.Point(33, 350);
            this.TextBoxOneOverall.Name = "TextBoxOneOverall";
            this.TextBoxOneOverall.Size = new System.Drawing.Size(100, 20);
            this.TextBoxOneOverall.TabIndex = 3;
            // 
            // TextBoxTwoOverall
            // 
            this.TextBoxTwoOverall.Location = new System.Drawing.Point(203, 350);
            this.TextBoxTwoOverall.Name = "TextBoxTwoOverall";
            this.TextBoxTwoOverall.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTwoOverall.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxTwoOverall);
            this.Controls.Add(this.TextBoxOneOverall);
            this.Controls.Add(this.TextBoxTwoIndividual);
            this.Controls.Add(this.TextBoxOneIndividual);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox TextBoxOneIndividual;
        private System.Windows.Forms.TextBox TextBoxTwoIndividual;
        private System.Windows.Forms.TextBox TextBoxOneOverall;
        private System.Windows.Forms.TextBox TextBoxTwoOverall;
    }
}

