namespace ProjectTask.UI
{
    partial class AnasayfaForm
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
            btnYemekler = new Button();
            btnRapor = new Button();
            btnOgunler = new Button();
            btnYemekPlani = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYemekler
            // 
            btnYemekler.BackColor = Color.SkyBlue;
            btnYemekler.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYemekler.ForeColor = Color.Transparent;
            btnYemekler.Location = new Point(407, 104);
            btnYemekler.Name = "btnYemekler";
            btnYemekler.Size = new Size(232, 79);
            btnYemekler.TabIndex = 1;
            btnYemekler.Text = "Yemekler";
            btnYemekler.UseVisualStyleBackColor = false;
            btnYemekler.Click += btnYemekler_Click;
            // 
            // btnRapor
            // 
            btnRapor.BackColor = Color.SkyBlue;
            btnRapor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRapor.ForeColor = Color.Transparent;
            btnRapor.Location = new Point(407, 209);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(232, 79);
            btnRapor.TabIndex = 2;
            btnRapor.Text = "Rapor / Özet";
            btnRapor.UseVisualStyleBackColor = false;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnOgunler
            // 
            btnOgunler.BackColor = Color.SkyBlue;
            btnOgunler.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunler.ForeColor = Color.Transparent;
            btnOgunler.Location = new Point(112, 104);
            btnOgunler.Name = "btnOgunler";
            btnOgunler.Size = new Size(226, 79);
            btnOgunler.TabIndex = 0;
            btnOgunler.Text = "Öğünler";
            btnOgunler.UseVisualStyleBackColor = false;
            btnOgunler.Click += btnOgunler_Click;
            // 
            // btnYemekPlani
            // 
            btnYemekPlani.BackColor = Color.SkyBlue;
            btnYemekPlani.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYemekPlani.ForeColor = Color.Transparent;
            btnYemekPlani.Location = new Point(112, 209);
            btnYemekPlani.Name = "btnYemekPlani";
            btnYemekPlani.Size = new Size(226, 79);
            btnYemekPlani.TabIndex = 3;
            btnYemekPlani.Text = "Yemek Planı";
            btnYemekPlani.UseVisualStyleBackColor = false;
            btnYemekPlani.Click += btnYemekPlani_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 4;
            label1.Text = "Fit-Kal";
            // 
            // AnasayfaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnYemekPlani);
            Controls.Add(btnRapor);
            Controls.Add(btnYemekler);
            Controls.Add(btnOgunler);
            Name = "AnasayfaForm";
            Text = "AnasayfaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYemekler;
        private Button btnRapor;
        private Button btnOgunler;
        private Button btnYemekPlani;
        private Label label1;
    }
}