using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassImageResizer {
    public partial class Form1 : Form {

        string[] files;
        string resizeFolder;

        public Form1() {
            InitializeComponent();
        }

        private void button_chooseFolder_Click(object sender, EventArgs e) {
            using (var f = new FolderBrowserDialog()) {
                DialogResult result = f.ShowDialog();
                if(result == DialogResult.OK && f.SelectedPath != "") {
                    files = Directory.GetFiles(f.SelectedPath);
                }
                MessageBox.Show("Archivos encontrados: " + files.Length, "Archivos");
                resizeFolder = f.SelectedPath + "\\resize";
                label_chosenFolder.Text = "Carpeta: " + f.SelectedPath;
            }
        }

        private bool TryGetDimensions(Size dimensions, out Size newDimensions) {
            if(radioButton_width.Checked) {
                if (!int.TryParse(textBox_width.Text, out int width)) {
                    newDimensions = dimensions;
                    return false;
                }
                else {
                    double scale = width / (double)dimensions.Width;
                    int height = (int)Math.Round(dimensions.Height * scale);
                    newDimensions = new Size(width, height);
                    return true;
                }
            }
            else {
                if (!int.TryParse(textBox_height.Text, out int height)) {
                    newDimensions = dimensions;
                    return false;
                }
                else {
                    double scale = height / (double)dimensions.Height;
                    int width = (int)Math.Round(dimensions.Width * scale);
                    newDimensions = new Size(width, height);
                    return true;
                }
            }
        }

        private void button_scale_Click(object sender, EventArgs e) {
            ResizeAllFiles();
        }

        private void ResizeAllFiles() {
            if(!TryGetDimensions(new Size(100, 100), out Size test)) {
                MessageBox.Show("Hay un problema con el valor introducido.");
                return;
            }
            if (GetInterpolation() == System.Drawing.Drawing2D.InterpolationMode.Invalid) {
                MessageBox.Show("Elige un tipo de interpolación.");
                return;
            }
            
            Directory.CreateDirectory(resizeFolder);

            foreach (string s in files) {
                if (Path.GetExtension(s) == ".png" || Path.GetExtension(s) == ".jpg" || Path.GetExtension(s) == ".jpeg" ||
                    Path.GetExtension(s) == ".tiff" || Path.GetExtension(s) == ".bmp" || Path.GetExtension(s) == ".gif") {
                    ResizeFile(s);
                }
                else {
                    foreach(string validFormat in ExtraExtensions) {
                        Console.WriteLine(Path.GetExtension(s) + " is not equal to " + validFormat);
                        if (Path.GetExtension(s) == validFormat) ResizeFile(s);
                    }
                }
            }

            MessageBox.Show("Todos los archivos han sido reescalados");
            System.Diagnostics.Process.Start("explorer.exe", resizeFolder);
        }

        private void ResizeFile(string path) {
            Console.WriteLine(path);
            using (var originalImage = Image.FromFile(path)) {
                TryGetDimensions(originalImage.Size, out Size newSize);
                ImageFormat format = GetImageFormat(Path.GetExtension(Path.GetFileName(path)));
                using (var newImage = new Bitmap(newSize.Width, newSize.Height)) {
                    using (Graphics g = Graphics.FromImage(newImage)) {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.InterpolationMode = GetInterpolation();
                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        g.DrawImage(originalImage, new Rectangle(0, 0, newSize.Width, newSize.Height));

                        string savePath = resizeFolder + "\\" + Path.GetFileName(path);
                        newImage.Save(savePath, format);
                        //newImage.Save(@"E:\owo.png", format);
                    }
                }
            }
        }

        private void textBox_extraExtensions_Leave(object sender, EventArgs e) {
            if(ExtraExtensions[0] == "") {
                label_accF.Text = "Formatos que se transformarán: png, jpg, jpeg, tiff, bmp, gif";
            }
            else {
                label_accF.Text = "Formatos que se transformarán: png, jpg, jpeg, tiff, bmp, gif";
                foreach(string s in ExtraExtensions) {
                    label_accF.Text += ", " + s;
                }
            }
        }

        private string[] ExtraExtensions {
            get {
                string[] ext = textBox_extraExtensions.Text.Split(',');

                for (int i = 1; i < ext.Length; i++) {
                    ext[i] = ext[i].Trim();
                }
                return ext;
            }
        }

        private System.Drawing.Drawing2D.InterpolationMode GetInterpolation() {
            switch(comboBox_interpolation.SelectedIndex) {
                case 0: return System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                case 1: return System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                case 2: return System.Drawing.Drawing2D.InterpolationMode.Default;
                case 3: return System.Drawing.Drawing2D.InterpolationMode.High;
                case 4: return System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                case 5: return System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                case 6: return System.Drawing.Drawing2D.InterpolationMode.Low;
                case 7: return System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                default: return System.Drawing.Drawing2D.InterpolationMode.Invalid;
            }
        }

        private ImageFormat GetImageFormat(string fileName) {
            switch (Path.GetExtension(fileName)) {
                case ".png":
                    return ImageFormat.Png;
                case ".bmp":
                    return ImageFormat.Bmp;
                case ".jpg":
                    return ImageFormat.Jpeg;
                case ".jpeg":
                    return ImageFormat.Jpeg;
                case ".gif":
                    return ImageFormat.Gif;
                case ".tiff":
                    return ImageFormat.Tiff;
                default:
                    return ImageFormat.Png;
            }
        }
    }
}
