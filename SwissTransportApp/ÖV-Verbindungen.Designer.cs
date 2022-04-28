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
            this.Verbindungstafel_Text = new System.Windows.Forms.Label();
            this.Abfahrtstafel_Gridview = new System.Windows.Forms.DataGridView();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis_Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis_Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuchenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AbfahrtCombo = new System.Windows.Forms.ComboBox();
            this.ViaCombo = new System.Windows.Forms.ComboBox();
            this.AnkunftCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel_Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // zurück_Button
            // 
            this.zurück_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zurück_Button.Location = new System.Drawing.Point(0, 936);
            this.zurück_Button.Name = "zurück_Button";
            this.zurück_Button.Size = new System.Drawing.Size(2063, 124);
            this.zurück_Button.TabIndex = 0;
            this.zurück_Button.Text = "Zurück zum Menü";
            this.zurück_Button.UseVisualStyleBackColor = true;
            this.zurück_Button.Click += new System.EventHandler(this.zurück_Button_Click);
            // 
            // Verbindungstafel_Text
            // 
            this.Verbindungstafel_Text.AutoSize = true;
            this.Verbindungstafel_Text.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Verbindungstafel_Text.Location = new System.Drawing.Point(36, 49);
            this.Verbindungstafel_Text.Name = "Verbindungstafel_Text";
            this.Verbindungstafel_Text.Size = new System.Drawing.Size(806, 133);
            this.Verbindungstafel_Text.TabIndex = 1;
            this.Verbindungstafel_Text.Text = "Verbindungstafel";
            // 
            // Abfahrtstafel_Gridview
            // 
            this.Abfahrtstafel_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Abfahrtstafel_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Abfahrtstafel_Gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtsort,
            this.Ankunftsort,
            this.Abfahrt,
            this.Ankunft,
            this.Gleis_Abfahrt,
            this.Gleis_Ankunft});
            this.Abfahrtstafel_Gridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Abfahrtstafel_Gridview.Location = new System.Drawing.Point(0, 363);
            this.Abfahrtstafel_Gridview.Name = "Abfahrtstafel_Gridview";
            this.Abfahrtstafel_Gridview.RowHeadersWidth = 102;
            this.Abfahrtstafel_Gridview.RowTemplate.Height = 49;
            this.Abfahrtstafel_Gridview.Size = new System.Drawing.Size(2063, 573);
            this.Abfahrtstafel_Gridview.TabIndex = 3;
            // 
            // Abfahrtsort
            // 
            this.Abfahrtsort.HeaderText = "Abfahrtsort";
            this.Abfahrtsort.MinimumWidth = 12;
            this.Abfahrtsort.Name = "Abfahrtsort";
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.MinimumWidth = 12;
            this.Ankunftsort.Name = "Ankunftsort";
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 12;
            this.Abfahrt.Name = "Abfahrt";
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 12;
            this.Ankunft.Name = "Ankunft";
            // 
            // Gleis_Abfahrt
            // 
            this.Gleis_Abfahrt.HeaderText = "Gleis oder Kante Abfahrt";
            this.Gleis_Abfahrt.MinimumWidth = 12;
            this.Gleis_Abfahrt.Name = "Gleis_Abfahrt";
            // 
            // Gleis_Ankunft
            // 
            this.Gleis_Ankunft.HeaderText = "Gleis oder Kante Ankunft";
            this.Gleis_Ankunft.MinimumWidth = 12;
            this.Gleis_Ankunft.Name = "Gleis_Ankunft";
            // 
            // SuchenButton
            // 
            this.SuchenButton.Location = new System.Drawing.Point(1386, 273);
            this.SuchenButton.Name = "SuchenButton";
            this.SuchenButton.Size = new System.Drawing.Size(421, 58);
            this.SuchenButton.TabIndex = 4;
            this.SuchenButton.Text = "Verbindung suchen";
            this.SuchenButton.UseVisualStyleBackColor = true;
            this.SuchenButton.Click += new System.EventHandler(this.SuchenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1203, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Abfahrtsort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1197, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ankunftsort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1254, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Via";
            // 
            // AbfahrtCombo
            // 
            this.AbfahrtCombo.FormattingEnabled = true;
            this.AbfahrtCombo.Location = new System.Drawing.Point(1428, 52);
            this.AbfahrtCombo.Name = "AbfahrtCombo";
            this.AbfahrtCombo.Size = new System.Drawing.Size(302, 49);
            this.AbfahrtCombo.TabIndex = 11;
            this.AbfahrtCombo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AbfahrtCombo_KeyUp);
            // 
            // ViaCombo
            // 
            this.ViaCombo.FormattingEnabled = true;
            this.ViaCombo.Location = new System.Drawing.Point(1428, 207);
            this.ViaCombo.Name = "ViaCombo";
            this.ViaCombo.Size = new System.Drawing.Size(302, 49);
            this.ViaCombo.TabIndex = 12;
            this.ViaCombo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ViaCombo_KeyUp);
            // 
            // AnkunftCombo
            // 
            this.AnkunftCombo.FormattingEnabled = true;
            this.AnkunftCombo.Location = new System.Drawing.Point(1428, 133);
            this.AnkunftCombo.Name = "AnkunftCombo";
            this.AnkunftCombo.Size = new System.Drawing.Size(302, 49);
            this.AnkunftCombo.TabIndex = 13;
            this.AnkunftCombo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AnkunftCombo_KeyUp);
            // 
            // ÖV_Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2063, 1060);
            this.Controls.Add(this.AnkunftCombo);
            this.Controls.Add(this.ViaCombo);
            this.Controls.Add(this.AbfahrtCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuchenButton);
            this.Controls.Add(this.Abfahrtstafel_Gridview);
            this.Controls.Add(this.Verbindungstafel_Text);
            this.Controls.Add(this.zurück_Button);
            this.Name = "ÖV_Verbindungen";
            this.Text = "ÖV_Verbindungen";
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button zurück_Button;
        private Label Verbindungstafel_Text;
        private DataGridView Abfahrtstafel_Gridview;
        private DataGridViewTextBoxColumn Abfahrtsort;
        private DataGridViewTextBoxColumn Ankunftsort;
        private DataGridViewTextBoxColumn Abfahrt;
        private DataGridViewTextBoxColumn Ankunft;
        private DataGridViewTextBoxColumn Gleis_Abfahrt;
        private DataGridViewTextBoxColumn Gleis_Ankunft;
        private Button SuchenButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox AbfahrtCombo;
        private ComboBox ViaCombo;
        private ComboBox AnkunftCombo;
    }
}