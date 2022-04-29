namespace SwissTransportApp
{
    partial class Abfahrtstafel
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
            this.Abfahrtstafel_Gridview = new System.Windows.Forms.DataGridView();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis_Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis_Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtstafek_Label = new System.Windows.Forms.Label();
            this.Suchen_Button = new System.Windows.Forms.Button();
            this.SucheCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel_Gridview)).BeginInit();
            this.SuspendLayout();
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
            this.Abfahrtstafel_Gridview.Location = new System.Drawing.Point(0, 267);
            this.Abfahrtstafel_Gridview.Name = "Abfahrtstafel_Gridview";
            this.Abfahrtstafel_Gridview.RowHeadersWidth = 102;
            this.Abfahrtstafel_Gridview.RowTemplate.Height = 49;
            this.Abfahrtstafel_Gridview.Size = new System.Drawing.Size(1908, 751);
            this.Abfahrtstafel_Gridview.TabIndex = 2;
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
            // Abfahrtstafek_Label
            // 
            this.Abfahrtstafek_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Abfahrtstafek_Label.AutoSize = true;
            this.Abfahrtstafek_Label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Abfahrtstafek_Label.Location = new System.Drawing.Point(127, 65);
            this.Abfahrtstafek_Label.Name = "Abfahrtstafek_Label";
            this.Abfahrtstafek_Label.Size = new System.Drawing.Size(623, 133);
            this.Abfahrtstafek_Label.TabIndex = 3;
            this.Abfahrtstafek_Label.Text = "Abfahrtstafel";
            // 
            // Suchen_Button
            // 
            this.Suchen_Button.Location = new System.Drawing.Point(1111, 109);
            this.Suchen_Button.Name = "Suchen_Button";
            this.Suchen_Button.Size = new System.Drawing.Size(537, 58);
            this.Suchen_Button.TabIndex = 4;
            this.Suchen_Button.Text = "Abfahrten suchen";
            this.Suchen_Button.UseVisualStyleBackColor = true;
            this.Suchen_Button.Click += new System.EventHandler(this.Suchen_Button_Click);
            // 
            // SucheCombobox
            // 
            this.SucheCombobox.FormattingEnabled = true;
            this.SucheCombobox.Location = new System.Drawing.Point(1111, 30);
            this.SucheCombobox.Name = "SucheCombobox";
            this.SucheCombobox.Size = new System.Drawing.Size(537, 49);
            this.SucheCombobox.TabIndex = 6;
            this.SucheCombobox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SucheCombobox_KeyUp);
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 1018);
            this.Controls.Add(this.SucheCombobox);
            this.Controls.Add(this.Suchen_Button);
            this.Controls.Add(this.Abfahrtstafek_Label);
            this.Controls.Add(this.Abfahrtstafel_Gridview);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel_Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView Abfahrtstafel_Gridview;
        private Label Abfahrtstafek_Label;
        private Button Suchen_Button;
        private DataGridViewTextBoxColumn Abfahrtsort;
        private DataGridViewTextBoxColumn Ankunftsort;
        private DataGridViewTextBoxColumn Abfahrt;
        private DataGridViewTextBoxColumn Ankunft;
        private DataGridViewTextBoxColumn Gleis_Abfahrt;
        private DataGridViewTextBoxColumn Gleis_Ankunft;
        private ComboBox SucheCombobox;
    }
}