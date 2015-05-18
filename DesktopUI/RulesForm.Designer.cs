namespace DesktopUI
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.rtbRules = new System.Windows.Forms.RichTextBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbRules
            // 
            this.rtbRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRules.Location = new System.Drawing.Point(12, 32);
            this.rtbRules.Name = "rtbRules";
            this.rtbRules.ReadOnly = true;
            this.rtbRules.Size = new System.Drawing.Size(408, 190);
            this.rtbRules.TabIndex = 0;
            this.rtbRules.Text = resources.GetString("rtbRules.Text");
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(12, 5);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(58, 24);
            this.lblRules.TabIndex = 1;
            this.lblRules.Text = "Rules";
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.Location = new System.Drawing.Point(13, 235);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(79, 24);
            this.lblControls.TabIndex = 2;
            this.lblControls.Text = "Controls";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 262);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(408, 77);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Use your arrows to move Player.Press U for undo the last move,press R to restart " +
    "the game.\nPress M/N to turn ON/OFF the  sound.";
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 351);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.rtbRules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RulesForm";
            this.Text = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}