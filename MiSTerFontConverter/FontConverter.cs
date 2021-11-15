using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSTerFontConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        public FontFamily GetFontFamilyByName(string name)
        {
            return privateFontCollection.Families.FirstOrDefault(x => x.Name == name);
        }

        public bool AddFont(string fullFileName)
        {
            return AddFont(File.ReadAllBytes(fullFileName));
        }

        public bool AddFont(byte[] fontBytes)
        {
            var handle = GCHandle.Alloc(fontBytes, GCHandleType.Pinned);
            IntPtr pointer = handle.AddrOfPinnedObject();
            Boolean result = false;
            try
            {
                privateFontCollection.AddMemoryFont(pointer, fontBytes.Length);
                result = true;
            }
            finally
            {
                handle.Free();               
            }
            return result;
        }

        PointF pointF = new PointF(0, 0);
        SolidBrush foregroundBrush = new SolidBrush(Color.White);
        SolidBrush backgroundBrush = new SolidBrush(Color.Black);

        char[,] charSet = new char[,]
                            {
                                      { ' ', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/' },
                                      { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':', ';', '<', '=', '>', '?' },
                                      { '@', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O' },
                                      { 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '[', '\\', ']', '^', '_' },
                                      { '`', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' },
                                      { 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '{', '|', '}', '`', (char)219}
                            };
        private void RenderBitmap()
        {
            try
            {
                if (privateFontCollection.Families.Length > 0)
                {
                    Bitmap charBitmap                 = new Bitmap(8 * 16, 8 * 6);
                    Graphics graphCharBitmap          = Graphics.FromImage(charBitmap);
                    graphCharBitmap.InterpolationMode = InterpolationMode.NearestNeighbor;
                    graphCharBitmap.SmoothingMode     = SmoothingMode.None;
                    Font regFont = new Font(privateFontCollection.Families[(int)numericUpDownFont.Value].Name,
                                            (float)numericUpDown1.Value,
                                            FontStyle.Regular,
                                            GraphicsUnit.Pixel);
                    graphCharBitmap.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                    graphCharBitmap.FillRectangle(backgroundBrush, 0, 0, charBitmap.Width, charBitmap.Height);
                    pointF.X = 0;
                    pointF.Y = 0;

                    for (int y = 0; y < charSet.GetLongLength(0); y++)
                    {
                        for (int x = 0; x < charSet.GetLongLength(1); x++)
                        {
                            graphCharBitmap.DrawString(
                                    "" + charSet[y, x],
                                    regFont,
                                    foregroundBrush,
                                    pointF);

                            pointF.X += 8;
                        }
                        pointF.Y += 8;
                        pointF.X = 0;
                    }

                    if ((int)numericUpDownCursorChar.Value == 0)
                        graphCharBitmap.FillRectangle(foregroundBrush, 15 * 8, 8 * 5, 7, 7);

                    Graphics graphicsZoom = Graphics.FromImage(charBitmap);

                    
                    pictureBoxPrv.Image               = (Image)charBitmap;
                    pictureBoxPrv.Width               = charBitmap.Width;
                    pictureBoxPrv.Height              = charBitmap.Height;
                    pictureBoxPrvZoom.Width           = charBitmap.Width  + charBitmap.Width;
                    pictureBoxPrvZoom.Height          = charBitmap.Height + charBitmap.Height;
                    Bitmap resized                    = new Bitmap(charBitmap, new Size(charBitmap.Width * 2, charBitmap.Height * 2));
                    Graphics graphZoomed              = Graphics.FromImage(resized);
                    graphZoomed.InterpolationMode     = InterpolationMode.NearestNeighbor;
                    graphZoomed.SmoothingMode         = SmoothingMode.None;
                    pictureBoxPrvZoom.Top             = pictureBoxPrv.Bottom + 4;
                    pictureBoxPrvZoom.Image           = (Image)resized;
                }
            }
            catch (Exception OOPS)
            {
                MessageBox.Show(System.Reflection.MethodBase.GetCurrentMethod() + " --> " + OOPS.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RenderBitmap();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogTTF.ShowDialog() == DialogResult.OK)
                {
                    if (AddFont(openFileDialogTTF.FileName)) 
                        numericUpDownFont.Maximum = privateFontCollection.Families.Length - 1;
                    textBox1.Text = privateFontCollection.Families[(int)numericUpDownFont.Value].Name;
                    RenderBitmap();
                }
            }
            catch (Exception OOPS)
            {
                MessageBox.Show(System.Reflection.MethodBase.GetCurrentMethod() + " --> " + OOPS.Message);
            }
        }

        private void numericUpDownFont_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = privateFontCollection.Families[(int)numericUpDownFont.Value].Name;
            }
            catch (Exception OOPS)
            {
                MessageBox.Show(System.Reflection.MethodBase.GetCurrentMethod() + " --> " + OOPS.Message);
            }
        }

        private void savePNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialogPNG.ShowDialog() == DialogResult.OK)
                    pictureBoxPrv.Image.Save(saveFileDialogPNG.FileName, ImageFormat.Png);
            }
            catch (Exception OOPS)
            {
                MessageBox.Show(System.Reflection.MethodBase.GetCurrentMethod() + " --> " + OOPS.Message);
            }
        }

        private void numericUpDownCursorChar_ValueChanged(object sender, EventArgs e)
        {
            charSet[5, 15] = (char)numericUpDownCursorChar.Value;
            RenderBitmap();
        }

        private void labelTitle_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(labelTitle.Width,
                                       labelFontNo.Height);
            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint,
                                        endPoint,
                                        Color.FromArgb(255, 255, 0, 0),
                                        Color.FromArgb(255, 255, 255, 0));

            e.Graphics.FillRectangle(lgb, 0, 0, labelTitle.Width, labelFontNo.Height);
            e.Graphics.DrawString(labelTitle.Text, DefaultFont, foregroundBrush, new Point(30, 0));
        } 
    }
}
