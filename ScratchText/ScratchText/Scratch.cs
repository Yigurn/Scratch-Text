using System;
using System.Drawing;

namespace ScratchText
{
    class Scratch
    {
        private Bitmap maskImage;
        Random random = new Random();

        private int imageWidth;
        private int imageHeight;

        private int textX;
        private int textY;

        private int minScratch;
        private int maxScratch;

        private int letterWidth;
        private int letterHeight;
        private int letterSpacing;

        const int BORDER = 200;

        public Scratch(Bitmap baseImage)
        {
            maskImage = baseImage;
            imageWidth = maskImage.Width;
            imageHeight = maskImage.Height;
        }

        public void ScratchText(string imageText, int textPosition, int letterWidth,
            int letterHeight, int letterSpacing, int minScratch, int maxScratch)
        {
            textX = (imageWidth + letterSpacing - imageText.Length * (letterWidth + letterSpacing)) / 2;
            if (textX < 0)
                Console.WriteLine("Impossible values!");
            textY = 0;
            if (textPosition == 1)
                textY = BORDER;
            else if (textPosition == 2)
                textY = (imageHeight - letterHeight) / 2;
            else
                textY = imageHeight - letterHeight - BORDER;

            this.minScratch = minScratch;
            this.maxScratch = maxScratch;

            this.letterWidth = letterWidth;
            this.letterHeight = letterHeight;
            this.letterSpacing = letterSpacing;

            for (int i = 0; i < imageText.Length; i++)
            {
                for (int j = 0; j <= letterWidth; j++)
                {
                    if (imageText[i] == 'A')
                    {
                        if (j < letterWidth * 3 / 10 || j > letterWidth * 7 / 10)
                            AddScratch(i, 0, letterHeight, j);
                        else
                        {
                            AddScratch(i, 0, letterHeight * 0.8f, j);
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.6f, j);
                        }
                    }
                    if (imageText[i] == 'B')
                    {
                        AddScratch(i, 0, letterHeight, j);
                        if (j > letterWidth * 3 / 10 && j < letterWidth * 7 / 10)
                        {
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.4f, j);
                            AddScratchBlock(i, letterHeight * 0.6f, letterHeight * 0.8f, j);
                        }
                    }
                    if (imageText[i] == 'C')
                    {
                        AddScratch(i, 0, letterHeight, j);
                        if (j > letterWidth * 3 / 10)
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.8f, j);
                    }
                    if (imageText[i] == 'D')
                    {
                        if (j < letterWidth * 7 / 10)
                            AddScratch(i, 0, letterHeight, j);
                        else
                            AddScratch(i, j - (letterWidth * 7 / 10), letterHeight + (letterWidth * 7 / 10) - j, j);
                        if (j > letterWidth * 3 / 10 && j < letterWidth * 7 / 10)
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.8f, j);
                    }
                    if (imageText[i] == 'E')
                    {
                        AddScratch(i, 0, letterHeight, j);
                        if (j > letterWidth * 3 / 10)
                        {
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.4f, j);
                            AddScratchBlock(i, letterHeight * 0.6f, letterHeight * 0.8f, j);
                        }
                    }
                    if (imageText[i] == 'F')
                    {
                        if (j > letterWidth * 3 / 10)
                        {
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.4f, j);
                            AddScratch(i, 0, letterHeight * 0.6f, j);
                        }
                        else
                            AddScratch(i, 0, letterHeight, j);
                    }
                    if (imageText[i] == 'G')
                    { }
                    if (imageText[i] == 'H')
                    {
                        if (j < letterWidth * 3 / 10 || j > letterWidth * 7 / 10)
                            AddScratch(i, 0, letterHeight, j);
                        else
                            AddScratch(i, letterHeight * 0.4f, letterHeight * 0.6f, j);
                    }
                    if (imageText[i] == 'I')
                    {
                        AddScratch(i, 0, letterHeight, j);
                        if (j < letterWidth * 3 / 10 || j > letterWidth * 7 / 10)
                        {
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.8f, j);
                        }
                    }
                    if (imageText[i] == 'J')
                    {
                        if (j > letterWidth * 7 / 10)
                            AddScratch(i, 0, letterHeight * 0.2f, j);
                        else
                        {
                            AddScratch(i, 0, letterHeight, j);
                            if (j < letterWidth * 4 / 10)
                                AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.8f, j);
                        }
                    }
                    if (imageText[i] == 'K')
                    { }
                    if (imageText[i] == 'L')
                    {
                        if (j < letterWidth * 3 / 10)
                            AddScratch(i, 0, letterHeight, j);
                        else
                            AddScratch(i, letterHeight * 0.8f, letterHeight, j);
                    }
                    if (imageText[i] == 'M')
                    { }
                    if (imageText[i] == 'N')
                    {
                        if (j < letterWidth * 3 / 10 || j > letterWidth * 7 / 10)
                            AddScratch(i, 0, letterHeight, j);
                        else
                            AddScratch(i, (j - letterWidth * 0.3f) * (0.6f * letterHeight / (0.4f * letterWidth)),
                                letterHeight * 0.4f + (j - letterWidth * 0.3f) * (0.6f * letterHeight / (0.4f * letterWidth)), j);
                    }
                    if (imageText[i] == 'O')
                    {
                        AddScratch(i, 0, letterHeight, j);
                        if (j > letterWidth * 3 / 10 && j < letterHeight * 7 / 10)
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.8f, j);
                    }
                    if (imageText[i] == 'P')
                    {
                        if (j < letterWidth * 3 / 10)
                            AddScratch(i, 0, letterHeight, j);
                        else
                        {
                            AddScratch(i, 0, letterHeight * 0.6f, j);
                            if (j > letterWidth * 7 / 10)
                                AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.4f, j);
                        }
                    }
                    if (imageText[i] == 'Q')
                    { }
                    if (imageText[i] == 'R')
                    {
                        if (j < letterWidth * 0.3 || j > letterWidth * 0.7)
                        {
                            AddScratch(i, 0, letterHeight, j);
                            if (j > letterWidth * 7 / 10)
                                AddScratchBlock(i, letterHeight * 0.6f, letterHeight * 0.6f - (letterWidth * 7 / 10) + j, j);
                        }
                        else
                        {
                            AddScratch(i, 0, letterHeight * 0.8f, j);
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.4f, j);
                        }
                    }
                    if (imageText[i] == 'S')
                    {
                        AddScratch(i, 0, letterHeight, j);
                        if (j > letterWidth * 3 / 10)
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.4f, j);
                        if (j < letterWidth * 7 / 10)
                            AddScratchBlock(i, letterHeight * 0.6f, letterHeight * 0.8f, j);
                    }
                    if (imageText[i] == 'T')
                    {
                        if (j < letterWidth * 3 / 10 || j > letterWidth * 7 / 10)
                            AddScratch(i, 0, letterHeight * 0.2f, j);
                        else
                            AddScratch(i, 0, letterHeight, j);

                    }
                    if (imageText[i] == 'U')
                    {
                        if (j > letterWidth * 3 / 10 && j < letterWidth * 7 / 10)
                            AddScratch(i, letterHeight * 0.8f, letterHeight, j);
                        else
                            AddScratch(i, 0, letterHeight, j);
                    }
                    if (imageText[i] == 'V')
                    {
                        if (j < letterWidth * 3 / 10)
                            AddScratch(i, 0, letterHeight * 0.2f + (j * (0.8f * letterHeight / (letterWidth * 3 / 10))), j);
                        else if (j < letterWidth / 2)
                            AddScratch(i, ((j - (letterWidth * 3 / 10)) * (0.8f * letterHeight / (letterWidth * 3 / 10))), letterHeight, j);
                        else if (j < letterWidth * 7 / 10)
                            AddScratch(i, ((letterWidth * 7 / 10) - j) * (0.8f * letterHeight / (letterWidth * 3 / 10)), letterHeight, j);
                        else
                            AddScratch(i, 0, letterHeight - (j - letterWidth * 7 / 10) * (0.8f * letterHeight / (letterWidth * 3 / 10)), j);
                    }
                    if (imageText[i] == 'W')
                    { }
                    if (imageText[i] == 'X')
                    { }
                    if (imageText[i] == 'Y')
                    { }
                    if (imageText[i] == 'Z')
                    {
                        AddScratch(i, 0, letterHeight, j);
                        if (j < letterWidth * 0.5)
                            AddScratchBlock(i, letterHeight * 0.2f, letterHeight * 0.8f - (j * (0.6f * letterHeight) / (0.5f * letterWidth)), j);
                        else
                            AddScratchBlock(i, letterHeight * 0.8f - ((j - 0.5f * letterWidth) * (0.6f * letterHeight) / (0.5f * letterWidth)), letterHeight * 0.8f, j);
                    }
                }
            }
            maskImage.Save("C:/Users/Yigabar/Desktop/Proper.png");
            Console.WriteLine("Finished");
        }

        private void AddScratch(int letterPosition, float letterTop, float letterBottom, int i)
        {
            int scratchBottom = random.Next(
                Math.Min(textY + letterHeight + minScratch, imageHeight - 1),
                Math.Min(textY + letterHeight + maxScratch, imageHeight - 1)
                );
            int scratchTop = random.Next(Math.Max(0, textY - maxScratch), Math.Max(0, textY - minScratch));

            for (int j = textY + (int)letterBottom; j < scratchBottom; j++)
            {
                Color pixel = maskImage.GetPixel(textX + letterPosition * (letterWidth + letterSpacing) + i, textY + (int)letterBottom);
                maskImage.SetPixel(textX + letterPosition * (letterWidth + letterSpacing) + i, j, pixel);
            }

            for (int j = textY + (int)letterTop; j > scratchTop; j--)
            {
                Color pixel = maskImage.GetPixel(textX + letterPosition * (letterWidth + letterSpacing) + i, textY + (int)letterTop);
                maskImage.SetPixel(textX + letterPosition * (letterWidth + letterSpacing) + i, j, pixel);
            }
        }

        private void AddScratchBlock(int letterPosition, float letterTop, float letterBottom, int i)
        {
            for (int j = textY + (int)letterBottom; j > textY + (int)letterTop; j--)
            {
                Color pixel = maskImage.GetPixel(textX + letterPosition * (letterWidth + letterSpacing) + i, textY + (int)letterBottom);
                maskImage.SetPixel(textX + letterPosition * (letterWidth + letterSpacing) + i, j, pixel);
            }
        }
    }
}
