using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WEBPtoJPG
{
    internal class Converter
    {
        string dwebppath = Path.Combine(Application.StartupPath, "dwebp.exe");
        Action<string> log;
        List<string> webpfiles = new List<string>();

        public Converter(Action<string> log)
        {
            this.log = log;
            if (!File.Exists(dwebppath)) MessageBox.Show("Download libwebp and extract dwebp.exe to folder with this app\r\nhttps://developers.google.com/speed/webp/docs/precompiled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public int FilesCount() => webpfiles.Count;
        public string[] GetFiles() => webpfiles.ToArray();

        public void AddFile(string path)
        {
            webpfiles.Add(path);
            log($"file selected: {path}");
        }

        public void ScanFolder(bool recursive)
        {
            if (webpfiles.Count < 1) { MessageBox.Show("Add at least one file from folder to scan"); return; }

            string p = Path.GetDirectoryName(webpfiles[0]);
            var files = Directory.EnumerateFiles(p, "*.webp", recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            webpfiles.Clear(); log("--------"); log("File list Cleared");
            foreach (var file in files) AddFile(file);
        }

        public void Clear()
        {
            webpfiles.Clear();
            log("--------");
            log("File list Cleared");
        }

        void Convert(int jpegQuality, string filename)
        {
            var p = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = dwebppath,
                    Arguments = filename + " -o -",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            using (MemoryStream ms = new MemoryStream())
            {
                p.Start();
                p.StandardOutput.BaseStream.CopyTo(ms);

                Image img = Image.FromStream(ms);
                var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                var encoderParams = new EncoderParameters() { Param = new[] { new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)jpegQuality) } };
                img.Save(Path.ChangeExtension(filename, "jpg"), encoder, encoderParams);

                //Bitmap bmp = new Bitmap(ms);
                //var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                //var encoderParams = new EncoderParameters() { Param = new[] { new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)jpegQuality) } };
                //bmp.Save(Path.ChangeExtension(filename, "jpg"), encoder, encoderParams);
            }
        }

        public void ConvertFiles(int jpegQuality, bool deleteSources, bool alertErrors)
        {
            if (webpfiles.Count < 1) { MessageBox.Show("No files to convert"); return; }

            foreach (var file in webpfiles)
            {
                try
                {
                    Convert(jpegQuality, file);
                    log($"file converted: {file}");
                    if (deleteSources) { File.Delete(file); log($"file deleted: {file}"); }
                }
                catch (Exception exc)
                {
                    log(exc.Message);
                    if (alertErrors) MessageBox.Show(exc.Message);
                }
            }

            webpfiles.Clear();
            log("---finished---");
            log("File list Cleared");
        }
    }
}
