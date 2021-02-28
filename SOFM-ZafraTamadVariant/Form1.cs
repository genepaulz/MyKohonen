using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOFM;

namespace SOFM_ZafraTamadVariant
{
    public partial class Form1 : Form
    {
        private SOFM.NeuralNetwork nn;

        private bool validNumberOfCards = false;
        private bool validIterations = false;
        private bool validAlpha = false;
        private bool ready = false;
        private Functions f;
        private int numCards = 0, iterations = 0;
        private double alpha = 0.0;
        private System.Drawing.Color[,] colorMatrix;
        

        public Form1()
        {
            InitializeComponent();
        }
        

        private void loadNRunBtn_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Size = new Size(850,500);
            openFileDialog1.ShowDialog();
        }

        private void alphaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                alpha = Convert.ToDouble(alphaBox.Text);
                if(alpha<0.01)
                validAlpha = true;
                else
                {
                    MessageBox.Show("Alpha Component is too big. Alpha must be less than 0.01.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                validAlpha = false;
            }
        }

        private void numberOfCardsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numCards = Convert.ToInt32(numberOfCardsBox.Text);
                validNumberOfCards = true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                validNumberOfCards = false;
            }
        }

        private void discreteRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (validNumberOfCards && validIterations && validAlpha)
            {
                ready = true;
                loadNRunBtn.Enabled = true;
                f = Functions.Discrete;
            }
        }

        private void gaussRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (validNumberOfCards && validIterations && validAlpha)
            {
                ready = true;
                loadNRunBtn.Enabled = true;
                f = Functions.Gaus;
            }
        }

        private void mexicanRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (validNumberOfCards && validIterations && validAlpha)
            {
                ready = true;
                loadNRunBtn.Enabled = true;
                f = Functions.MexicanHat;
            }
        }

        private void frenchRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (validNumberOfCards && validIterations && validAlpha)
            {
                ready = true;
                loadNRunBtn.Enabled = true;
                f = Functions.FrenchHat;
            }
        }

        private void AddDataToListBox()
        {
            inputVectorsListBox.Items.Clear();
            string patternString;
            for (int i = 0; i < nn.Patterns.Count; i++)
            {
                patternString = "";
                patternString += nn.Classes[i] + " ";
                for (int j = 0; j < nn.InputLayerDimension; j++)
                    patternString += nn.Patterns[i][j].ToString("g2") + " ";
                inputVectorsListBox.Items.Add(patternString);
            }
        }

        private void AddLabels()
        {
            labelsPanel.Controls.Clear();
            Label label = new Label();
            label.Name = "lblLegend";
            label.Top = 5;
            label.Left = 5;
            label.Text = "Legend";
            label.AutoSize = true;
            labelsPanel.Controls.Add(label);
            for (int i = 0; i < nn.ExistentClasses.Count; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl" + nn.ExistentClasses.Keys[i];
                lbl.Text = " - " + nn.ExistentClasses.Keys[i];
                lbl.Top = 20 * (i + 1);
                lbl.AutoSize = true;
                lbl.Left = 15 + (int)lbl.Font.Size;
                this.labelsPanel.Controls.Add(lbl);

                Panel panel = new Panel();
                panel.Name = "panel" + nn.ExistentClasses.Keys[i];
                panel.Top = 20 * (i + 1) + (int)lbl.Font.Size / 2;
                panel.Left = 15;
                panel.Width = (int)lbl.Font.Size;
                panel.Height = (int)lbl.Font.Size;
                panel.BackColor = nn.UsedColors[i];
                this.labelsPanel.Controls.Add(panel);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (ready)
            {
                nn = new NeuralNetwork(numCards, iterations, alpha, f);
                nn.Normalize = false;
                nn.ReadDataFromFile(openFileDialog1.FileName);
                AddDataToListBox();
                labelsPanel.Visible = false;
                nn.StartLearning();
                labelsPanel.Visible = true;
                colorMatrix = nn.ColorSOFM();
                /*MessageBox.Show(colorMatrix.Length.ToString());*/
                int size = ((int)Math.Sqrt(colorMatrix.Length))*10;
                int rectsize = 10;
                int grid = (int)Math.Sqrt(colorMatrix.Length);
                Bitmap res = new Bitmap(size, size);
            
                using (Graphics g = Graphics.FromImage(res))
                {
                    for(int i = 0; i < grid; i++)
                    {
                        for(int j = 0; j < grid; j++)
                        {
                            Brush b = new SolidBrush(colorMatrix[i,j]);
                            Brush c = new SolidBrush(Color.Black);
                            g.FillRectangle(b, new Rectangle(j * rectsize, i * rectsize, rectsize, rectsize));
                            g.DrawRectangle(new Pen(c), new Rectangle(j * rectsize, i * rectsize, rectsize, rectsize));
                        }
                    }
                }
                kohonenMap.Image = res;
                kohonenMap.Visible = true;
                AddLabels();
            }
            
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            List<Double> test = new List<double>();
           
                test.Add(Convert.ToDouble(areaBox.Text));
                test.Add(Convert.ToDouble(perimeterBox.Text));
                test.Add(Convert.ToDouble(compactnessBox.Text));
                test.Add(Convert.ToDouble(lengthBox.Text));
                test.Add(Convert.ToDouble(widthBox.Text));
                test.Add(Convert.ToDouble(coefficentBox.Text));
                test.Add(Convert.ToDouble(kernelGrooveBox.Text));

            
            Neuron winner = nn.FindWinner(test);
            MessageBox.Show("This test input is located at " + winner.Coordinate + "");
            test = null;
            int rectsize = 10;
            Bitmap x = new Bitmap(kohonenMap.Image);
            Brush b = new SolidBrush(Color.Aqua);
            Brush c = new SolidBrush(Color.Black);
            using (Graphics g = Graphics.FromImage(x))
            {
                g.FillRectangle(b, new Rectangle(winner.Coordinate.X * rectsize, winner.Coordinate.Y * rectsize, rectsize, rectsize));
                g.DrawRectangle(new Pen(c), new Rectangle(winner.Coordinate.X * rectsize, winner.Coordinate.Y * rectsize, rectsize, rectsize));
            }
            kohonenMap.Image = x;
        }

        private void iterationsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iterations = Convert.ToInt32(iterationsBox.Text);
                validIterations = true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                validIterations = false;
            }
        }

    }
}
