using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObstacleMapMaker
{
    public partial class GenForm : Form
    {
        public GenForm(string map)
        {
            InitializeComponent();
            generatedMapTextBox.Text = map;
        }

        private void saveMapButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Map File";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder stringBuilder = new StringBuilder(generatedMapTextBox.Text);
                string temp = stringBuilder.ToString().TrimEnd('\r', '\n');
                File.WriteAllText(saveFileDialog1.FileName, temp);
            }
        }
    }
}
