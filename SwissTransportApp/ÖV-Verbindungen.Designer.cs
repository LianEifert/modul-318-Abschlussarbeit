namespace SwissTransportApp
{
    partial class ÖV_Verbindungen
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
            this.zurück_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zurück_Button
            // 
            this.zurück_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zurück_Button.Location = new System.Drawing.Point(0, 811);
            this.zurück_Button.Name = "zurück_Button";
            this.zurück_Button.Size = new System.Drawing.Size(1121, 124);
            this.zurück_Button.TabIndex = 0;
            this.zurück_Button.Text = "Zurück zum Menü";
            this.zurück_Button.UseVisualStyleBackColor = true;
            this.zurück_Button.Click += new System.EventHandler(this.zurück_Button_Click);
            // 
            // ÖV_Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 935);
            this.Controls.Add(this.zurück_Button);
            this.Name = "ÖV_Verbindungen";
            this.Text = "ÖV_Verbindungen";
            this.ResumeLayout(false);

        }

        #endregion

        private Button zurück_Button;
    }
}