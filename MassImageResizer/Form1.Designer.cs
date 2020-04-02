namespace MassImageResizer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button_chooseFolder = new System.Windows.Forms.Button();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.button_scale = new System.Windows.Forms.Button();
            this.label_chosenFolder = new System.Windows.Forms.Label();
            this.radioButton_height = new System.Windows.Forms.RadioButton();
            this.radioButton_width = new System.Windows.Forms.RadioButton();
            this.label_accF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_extraExtensions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_interpolation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_chooseFolder
            // 
            this.button_chooseFolder.Location = new System.Drawing.Point(11, 31);
            this.button_chooseFolder.Name = "button_chooseFolder";
            this.button_chooseFolder.Size = new System.Drawing.Size(91, 23);
            this.button_chooseFolder.TabIndex = 0;
            this.button_chooseFolder.Text = "Elegir carpeta";
            this.button_chooseFolder.UseVisualStyleBackColor = true;
            this.button_chooseFolder.Click += new System.EventHandler(this.button_chooseFolder_Click);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(144, 61);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(77, 20);
            this.textBox_height.TabIndex = 3;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(144, 84);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(77, 20);
            this.textBox_width.TabIndex = 4;
            // 
            // button_scale
            // 
            this.button_scale.Location = new System.Drawing.Point(70, 110);
            this.button_scale.Name = "button_scale";
            this.button_scale.Size = new System.Drawing.Size(75, 23);
            this.button_scale.TabIndex = 5;
            this.button_scale.Text = "Escalar";
            this.button_scale.UseVisualStyleBackColor = true;
            this.button_scale.Click += new System.EventHandler(this.button_scale_Click);
            // 
            // label_chosenFolder
            // 
            this.label_chosenFolder.AutoSize = true;
            this.label_chosenFolder.Location = new System.Drawing.Point(108, 36);
            this.label_chosenFolder.Name = "label_chosenFolder";
            this.label_chosenFolder.Size = new System.Drawing.Size(55, 13);
            this.label_chosenFolder.TabIndex = 6;
            this.label_chosenFolder.Text = "Dirección:";
            // 
            // radioButton_height
            // 
            this.radioButton_height.AutoSize = true;
            this.radioButton_height.Checked = true;
            this.radioButton_height.Location = new System.Drawing.Point(70, 62);
            this.radioButton_height.Name = "radioButton_height";
            this.radioButton_height.Size = new System.Drawing.Size(55, 17);
            this.radioButton_height.TabIndex = 7;
            this.radioButton_height.TabStop = true;
            this.radioButton_height.Text = "Altura:";
            this.radioButton_height.UseVisualStyleBackColor = true;
            // 
            // radioButton_width
            // 
            this.radioButton_width.AutoSize = true;
            this.radioButton_width.Location = new System.Drawing.Point(70, 85);
            this.radioButton_width.Name = "radioButton_width";
            this.radioButton_width.Size = new System.Drawing.Size(68, 17);
            this.radioButton_width.TabIndex = 7;
            this.radioButton_width.Text = "Anchura:";
            this.radioButton_width.UseVisualStyleBackColor = true;
            // 
            // label_accF
            // 
            this.label_accF.Location = new System.Drawing.Point(12, 166);
            this.label_accF.Name = "label_accF";
            this.label_accF.Size = new System.Drawing.Size(371, 53);
            this.label_accF.TabIndex = 8;
            this.label_accF.Text = "Formatos que se transformarán: png, jpg, jpeg, tiff, bmp, gif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Añadir otros formatos: separados por comas, por ejemplo (png, jpg)";
            // 
            // textBox_extraExtensions
            // 
            this.textBox_extraExtensions.Location = new System.Drawing.Point(11, 254);
            this.textBox_extraExtensions.Name = "textBox_extraExtensions";
            this.textBox_extraExtensions.Size = new System.Drawing.Size(372, 20);
            this.textBox_extraExtensions.TabIndex = 10;
            this.textBox_extraExtensions.Leave += new System.EventHandler(this.textBox_extraExtensions_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Si son formatos extraños, puede pasar cualquier cosa.";
            // 
            // comboBox_interpolation
            // 
            this.comboBox_interpolation.FormattingEnabled = true;
            this.comboBox_interpolation.Items.AddRange(new object[] {
            "Bicubic",
            "Bilinear",
            "Default",
            "High",
            "High Quality Bicubic",
            "High Quality Bilinear",
            "Low",
            "Nearest Neighbor"});
            this.comboBox_interpolation.Location = new System.Drawing.Point(247, 85);
            this.comboBox_interpolation.Name = "comboBox_interpolation";
            this.comboBox_interpolation.Size = new System.Drawing.Size(121, 21);
            this.comboBox_interpolation.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Interpolación:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_interpolation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_extraExtensions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_accF);
            this.Controls.Add(this.radioButton_width);
            this.Controls.Add(this.radioButton_height);
            this.Controls.Add(this.label_chosenFolder);
            this.Controls.Add(this.button_scale);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.button_chooseFolder);
            this.Name = "Form1";
            this.Text = "Reescalador de Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_chooseFolder;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.Button button_scale;
        private System.Windows.Forms.Label label_chosenFolder;
        private System.Windows.Forms.RadioButton radioButton_height;
        private System.Windows.Forms.RadioButton radioButton_width;
        private System.Windows.Forms.Label label_accF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_extraExtensions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_interpolation;
        private System.Windows.Forms.Label label1;
    }
}

