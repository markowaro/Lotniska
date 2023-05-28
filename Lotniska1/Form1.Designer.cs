namespace Lotniska1
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
            buttonPokaz = new Button();
            comboBox1 = new ComboBox();
            checkBoxMiasto = new CheckBox();
            checkBoxWojewodztwo = new CheckBox();
            checkBoxICAO = new CheckBox();
            checkBoxIATA = new CheckBox();
            checkBoxLiczbaPasazerow = new CheckBox();
            checkBoxZmiana = new CheckBox();
            SuspendLayout();
            // 
            // buttonPokaz
            // 
            buttonPokaz.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPokaz.Location = new Point(323, 323);
            buttonPokaz.Name = "buttonPokaz";
            buttonPokaz.Size = new Size(120, 67);
            buttonPokaz.TabIndex = 0;
            buttonPokaz.Text = "Pokaż";
            buttonPokaz.UseVisualStyleBackColor = true;
            buttonPokaz.Click += buttonPokaz_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(776, 23);
            comboBox1.TabIndex = 1;
            // 
            // checkBoxMiasto
            // 
            checkBoxMiasto.AutoSize = true;
            checkBoxMiasto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMiasto.Location = new Point(323, 98);
            checkBoxMiasto.Name = "checkBoxMiasto";
            checkBoxMiasto.Size = new Size(156, 29);
            checkBoxMiasto.TabIndex = 2;
            checkBoxMiasto.Text = "Główne miasto";
            checkBoxMiasto.UseVisualStyleBackColor = true;
            // 
            // checkBoxWojewodztwo
            // 
            checkBoxWojewodztwo.AutoSize = true;
            checkBoxWojewodztwo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxWojewodztwo.Location = new Point(323, 133);
            checkBoxWojewodztwo.Name = "checkBoxWojewodztwo";
            checkBoxWojewodztwo.Size = new Size(150, 29);
            checkBoxWojewodztwo.TabIndex = 3;
            checkBoxWojewodztwo.Text = "Województwo";
            checkBoxWojewodztwo.UseVisualStyleBackColor = true;
            // 
            // checkBoxICAO
            // 
            checkBoxICAO.AutoSize = true;
            checkBoxICAO.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxICAO.Location = new Point(323, 168);
            checkBoxICAO.Name = "checkBoxICAO";
            checkBoxICAO.Size = new Size(74, 29);
            checkBoxICAO.TabIndex = 4;
            checkBoxICAO.Text = "ICAO";
            checkBoxICAO.UseVisualStyleBackColor = true;
            // 
            // checkBoxIATA
            // 
            checkBoxIATA.AutoSize = true;
            checkBoxIATA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIATA.Location = new Point(323, 202);
            checkBoxIATA.Name = "checkBoxIATA";
            checkBoxIATA.Size = new Size(68, 29);
            checkBoxIATA.TabIndex = 5;
            checkBoxIATA.Text = "IATA";
            checkBoxIATA.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiczbaPasazerow
            // 
            checkBoxLiczbaPasazerow.AutoSize = true;
            checkBoxLiczbaPasazerow.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxLiczbaPasazerow.Location = new Point(323, 237);
            checkBoxLiczbaPasazerow.Name = "checkBoxLiczbaPasazerow";
            checkBoxLiczbaPasazerow.Size = new Size(179, 29);
            checkBoxLiczbaPasazerow.TabIndex = 6;
            checkBoxLiczbaPasazerow.Text = "Liczba pasażerów";
            checkBoxLiczbaPasazerow.UseVisualStyleBackColor = true;
            // 
            // checkBoxZmiana
            // 
            checkBoxZmiana.AutoSize = true;
            checkBoxZmiana.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxZmiana.Location = new Point(323, 272);
            checkBoxZmiana.Name = "checkBoxZmiana";
            checkBoxZmiana.Size = new Size(94, 29);
            checkBoxZmiana.TabIndex = 7;
            checkBoxZmiana.Text = "Zmiana";
            checkBoxZmiana.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxZmiana);
            Controls.Add(checkBoxLiczbaPasazerow);
            Controls.Add(checkBoxIATA);
            Controls.Add(checkBoxICAO);
            Controls.Add(checkBoxWojewodztwo);
            Controls.Add(checkBoxMiasto);
            Controls.Add(comboBox1);
            Controls.Add(buttonPokaz);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPokaz;
        private ComboBox comboBox1;
        private CheckBox checkBoxMiasto;
        private CheckBox checkBoxWojewodztwo;
        private CheckBox checkBoxICAO;
        private CheckBox checkBoxIATA;
        private CheckBox checkBoxLiczbaPasazerow;
        private CheckBox checkBoxZmiana;
    }
}