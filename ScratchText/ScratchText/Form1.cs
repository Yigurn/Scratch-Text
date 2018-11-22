using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Scratch scratch;
        private int textPosition = 0;

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PNG File (*.png) | *.png;";
            if (open.ShowDialog() != DialogResult.OK)
                return;

            textFile.Text = open.FileName.Substring(open.FileName.LastIndexOf('\\') + 1);

            Bitmap baseImage = new Bitmap(open.FileName);
            labelImageWidth.Text = baseImage.Width.ToString();
            labelImageHeight.Text = baseImage.Height.ToString();

            scratch = new Scratch(baseImage);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG File (*.png) | *.png;";
            if (save.ShowDialog() != DialogResult.OK)
                return;
            
            scratch.ScratchText(textImage.Text.ToUpper(), textPosition, Convert.ToInt32(textWidth.Text),
                Convert.ToInt32(textHeight.Text), Convert.ToInt32(textSpacing.Text),
                Convert.ToInt32(textMinScratch.Text), Convert.ToInt32(textMaxScratch.Text));            
        }

        private void radioTop_CheckedChanged(object sender, EventArgs e)
        {
            textPosition = 1;

        }
        private void radioCentre_CheckedChanged(object sender, EventArgs e)
        {
            textPosition = 2;
        }
        private void radioBottom_CheckedChanged(object sender, EventArgs e)
        {
            textPosition = 3;
        }
    }
}
