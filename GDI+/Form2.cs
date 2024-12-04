using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form2 : Form
    {
        private int panelWidth;
        private int panelHeight;

        public Form2(int panelWidth, int panelHeight)
        {
            InitializeComponent();
            this.panelWidth = panelWidth;
            this.panelHeight = panelHeight;
            UpdateMaxCoordinates();
        }

        //приймаємо кординати(розміри панелі) і за допомогою події відслідковуємо зміни (переміщення) тексту по панелі
        public event Action<string, int, int> TextPreviewUpdated;

        public string InputText => TextBoxText.Text;
        public Font SelectedFont { get; private set; } = new Font("Arial", 14, FontStyle.Regular);
        public int TextX => (int)numericUpDownX.Value;
        public int TextY => (int)numericUpDownY.Value;

        private void UpdatePreview()
        {
            TextPreviewUpdated?.Invoke(TextBoxText.Text, TextX, TextY);
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void TextBoxText_TextChanged_1(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void buttonAddText_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateMaxCoordinates()
        {
            numericUpDownX.Maximum = panelWidth - 1; 
            numericUpDownY.Maximum = panelHeight - 1; 
        }
    }
}
