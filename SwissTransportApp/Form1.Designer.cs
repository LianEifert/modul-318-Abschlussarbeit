namespace SwissTransportApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Abfahrtstafel_Button = new System.Windows.Forms.Button();
            this.övVerbindungen_Button = new System.Windows.Forms.Button();
            this.Menu_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Abfahrtstafel_Button
            // 
            this.Abfahrtstafel_Button.Location = new System.Drawing.Point(69, 245);
            this.Abfahrtstafel_Button.Name = "Abfahrtstafel_Button";
            this.Abfahrtstafel_Button.Size = new System.Drawing.Size(328, 267);
            this.Abfahrtstafel_Button.TabIndex = 0;
            this.Abfahrtstafel_Button.Text = "Abfahrtstafel";
            this.Abfahrtstafel_Button.UseVisualStyleBackColor = true;
            this.Abfahrtstafel_Button.Click += new System.EventHandler(this.Abfahrtstafel_Button_Click);
            // 
            // övVerbindungen_Button
            // 
            this.övVerbindungen_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.övVerbindungen_Button.Location = new System.Drawing.Point(503, 245);
            this.övVerbindungen_Button.Name = "övVerbindungen_Button";
            this.övVerbindungen_Button.Size = new System.Drawing.Size(328, 267);
            this.övVerbindungen_Button.TabIndex = 3;
            this.övVerbindungen_Button.Text = "ÖV-Verbindungen";
            this.övVerbindungen_Button.UseVisualStyleBackColor = true;
            this.övVerbindungen_Button.Click += new System.EventHandler(this.övVerbindungen_Button_Click);
            // 
            // Menu_Label
            // 
            this.Menu_Label.AutoSize = true;
            this.Menu_Label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu_Label.Location = new System.Drawing.Point(69, 54);
            this.Menu_Label.Name = "Menu_Label";
            this.Menu_Label.Size = new System.Drawing.Size(313, 133);
            this.Menu_Label.TabIndex = 4;
            this.Menu_Label.Text = "Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.Menu_Label);
            this.Controls.Add(this.övVerbindungen_Button);
            this.Controls.Add(this.Abfahrtstafel_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Abfahrtstafel_Button;
        private Button övVerbindungen_Button;
        private Label Menu_Label;
    }
}