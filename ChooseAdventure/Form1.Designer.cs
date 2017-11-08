namespace ChooseAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.sceneLabel = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSpace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.Lime;
            this.redLabel.Location = new System.Drawing.Point(161, 161);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(325, 58);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "Mountians";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.Lime;
            this.blueLabel.Location = new System.Drawing.Point(161, 246);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(325, 52);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "River";
            // 
            // sceneLabel
            // 
            this.sceneLabel.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneLabel.ForeColor = System.Drawing.Color.Lime;
            this.sceneLabel.Location = new System.Drawing.Point(50, 27);
            this.sceneLabel.Name = "sceneLabel";
            this.sceneLabel.Size = new System.Drawing.Size(442, 108);
            this.sceneLabel.TabIndex = 4;
            this.sceneLabel.Text = "You are lost in a forest. Where do you go?";
            // 
            // spaceLabel
            // 
            this.spaceLabel.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceLabel.ForeColor = System.Drawing.Color.Lime;
            this.spaceLabel.Location = new System.Drawing.Point(161, 319);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(325, 48);
            this.spaceLabel.TabIndex = 5;
            this.spaceLabel.Text = "Forest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelB.Location = new System.Drawing.Point(52, 246);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 20);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(50, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "M";
            // 
            // labelSpace
            // 
            this.labelSpace.AutoSize = true;
            this.labelSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpace.ForeColor = System.Drawing.Color.Lime;
            this.labelSpace.Location = new System.Drawing.Point(52, 319);
            this.labelSpace.Name = "labelSpace";
            this.labelSpace.Size = new System.Drawing.Size(55, 20);
            this.labelSpace.TabIndex = 9;
            this.labelSpace.Text = "Space";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 462);
            this.Controls.Add(this.labelSpace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.sceneLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Adventure";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label sceneLabel;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSpace;
    }
}

