using System;
using System.Drawing;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; //привязка панелі до вікна 
        }

        private string currentText = string.Empty;
        private int currentX = 0;
        private int currentY = 0;
        private void AddToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(panel1.Width, panel1.Height);
            form2.TextPreviewUpdated += (text, x, y) =>
            {
                currentText = text; //передаємо кординати(розміри поточної панелі) якзо ми вирішили розгширити її для того щоб задати ліміт для розташування тексту 
                currentX = x;
                currentY = y;
                UpdateTextPreview();
            };

            if (form2.ShowDialog() == DialogResult.OK)
            {
                AddFinalText(currentText, currentX, currentY);
            }
        }

        private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                panel1.BackgroundImage = img;
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(img, new Rectangle(0, 0, panel1.Width, panel1.Height));
                img.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void UpdateTextPreview() //при зміні кординат на 2 панелі цей метод забезпечує видимість зміни положення тексту на 1 формі
        {
            panel1.Invalidate(); // оновлення панелі
            using (Graphics g = panel1.CreateGraphics())
            {
                Font font = new Font("Arial", 14, FontStyle.Bold);
                Brush brush = Brushes.Black; 
                g.DrawString(currentText, font, brush, currentX, currentY);
            }
        }

        private void AddFinalText(string text, int x, int y) //це метод осточно додає текст на основну форму
        {
            if (panel1.BackgroundImage == null)
            {
                Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White); 
                }
                panel1.BackgroundImage = bitmap;
            }

            using (Graphics g = Graphics.FromImage(panel1.BackgroundImage))
            {
                Font font = new Font("Arial", 14, FontStyle.Bold);
                Brush brush = Brushes.Black;
                g.DrawString(text, font, brush, x, y);
            }
            panel1.Refresh();
        }

    }
}

