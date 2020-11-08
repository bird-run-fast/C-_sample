namespace WindowsFormSample
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
            this.gooButton = new System.Windows.Forms.Button();
            this.chokiButton = new System.Windows.Forms.Button();
            this.parButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gooButton
            // 
            this.gooButton.Location = new System.Drawing.Point(193, 280);
            this.gooButton.Name = "gooButton";
            this.gooButton.Size = new System.Drawing.Size(75, 23);
            this.gooButton.TabIndex = 0;
            this.gooButton.Text = "グー";
            this.gooButton.UseVisualStyleBackColor = true;
            this.gooButton.Click += new System.EventHandler(this.gooButton_Click);
            // 
            // chokiButton
            // 
            this.chokiButton.Location = new System.Drawing.Point(70, 325);
            this.chokiButton.Name = "chokiButton";
            this.chokiButton.Size = new System.Drawing.Size(75, 23);
            this.chokiButton.TabIndex = 1;
            this.chokiButton.Text = "チョキ";
            this.chokiButton.UseVisualStyleBackColor = true;
            this.chokiButton.Click += new System.EventHandler(this.chokiButton_Click);
            // 
            // parButton
            // 
            this.parButton.Location = new System.Drawing.Point(325, 325);
            this.parButton.Name = "parButton";
            this.parButton.Size = new System.Drawing.Size(75, 23);
            this.parButton.TabIndex = 2;
            this.parButton.Text = "パー";
            this.parButton.UseVisualStyleBackColor = true;
            this.parButton.Click += new System.EventHandler(this.parButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ボタンをクリックして下さい";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parButton);
            this.Controls.Add(this.chokiButton);
            this.Controls.Add(this.gooButton);
            this.Name = "GameForm";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gooButton;
        private System.Windows.Forms.Button chokiButton;
        private System.Windows.Forms.Button parButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}