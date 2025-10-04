using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObstacleMapMaker
{
    public partial class MainForm : Form
    {

        private DrawHelper drawHelper;
        public Graphics g;
        public int mapSize = 50;
        public int scale = 13;
        public int[,] mapArr;
        public int startX;
        public int startY;
        public int goalX;
        public int goalY;

        public string startLoc;
        public string goalLoc;

        public bool isMouseDown = false;
        public bool isDrawRect = false;

        public int initX;
        public int initY;

        private bool isConvertThreadRunning = false;
        private bool isGeneratingThreadRunning = false;
        Bitmap img;
        StringBuilder genThreadSb = new StringBuilder("");

        bool isValidMap = false;

        int screenWidth = 0;
        int screenHeight = 0;

        public MainForm()
        {
            InitializeComponent();
            g = map.CreateGraphics();
            drawHelper = new DrawHelper(this);
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            screenWidth = area.Width;
            screenHeight = area.Height;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            drawTypeComboBox.Items.Clear();
            var values = Enum.GetValues(typeof(DrawTypes));
            foreach(var val in values)
            {
                drawTypeComboBox.Items.Add(val.ToString());
            }
            drawTypeComboBox.SelectedIndex = 0;
        }

        private void MainForm_ResizeEnd(object sender, System.EventArgs e)
        {
            bool hasStart = (startLocTextBox.Text.Length < 3) ? false : true;
            g = map.CreateGraphics();
            try
            {
                drawHelper.DrawGrid(true, hasStart);
                drawHelper.DrawUpdate();
            }
            catch { }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            bool hasStart = (startLocTextBox.Text.Length < 3) ? false : true;

            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                g = map.CreateGraphics();
                try
                {
                    drawHelper.DrawGrid(true, hasStart);
                    drawHelper.DrawUpdate();
                }
                catch { }
            }
        }

        private void canvasResizeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Creating new map clears current map", "Create new map?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string mapSizeStr = mapSizeTextBox.Text;
            int intSize = 0;


            string[] startLocArr = startLocTextBox.Text.Split(',');
            string[] goalLocArr = goalLocTextBox.Text.Split(',');

            if(startLocArr.Length != 2 || goalLocArr.Length != 2 ||
                !int.TryParse(startLocArr[0], out startX) || !int.TryParse(startLocArr[1], out startY) ||
                !int.TryParse(goalLocArr[0], out goalX) || !int.TryParse(goalLocArr[1], out goalY))
            {
                MessageBox.Show("Invalid start or goal location, must be in format 'x,y' e.g. 3,3", "Error");
                return;
            }

            startLoc = startLocTextBox.Text;
            goalLoc = goalLocTextBox.Text;

            if (!int.TryParse(mapSizeStr, out intSize))
            {
                mapSizeTextBox.Text = "";
                MessageBox.Show("Size must be positive integer", "Error");
                return;
            }

            scale = (int)(((double)screenHeight / intSize) * 0.97);

            if(scale < 1)
            {
                MessageBox.Show("Cannot load map, too large", "Error");
                return;
            }

            mapSize = intSize;
            map.Size = new Size((mapSize * scale + 2), (mapSize * scale + 2));
            mapArr = new int[mapSize, mapSize];
            g = map.CreateGraphics();
            drawHelper.DrawGrid(true, true);
        }

        private void map_DrawMouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / scale;
            int y = e.Y / scale;

            drawHelper.DrawMouseMove(e, x, y);
        }

        private void map_MouseDownEvent(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            initX = e.X / scale;
            initY = e.Y / scale;
        }

        private void map_MouseUpEvent(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void map_ClickEvent(object sender, MouseEventArgs e)
        {
            int x = e.X / scale;
            int y = e.Y / scale;

            int startX = (e.X / scale) * scale;
            int startY = (e.Y / scale) * scale;

            if (drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.NO_OBSTACLE.ToString()))
            {
                drawHelper.DrawNoObstacle(startX, startY, x, y);

            }
            else if (drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.OBSTACLE.ToString()))
            {
                drawHelper.DrawObstacle(startX, startY, x, y);

            }
            else if (drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.START.ToString()))
            {
                drawHelper.DrawStartLoc(startX, startY, x, y);

            }
            else if(drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.GOAL.ToString()))
            {
                drawHelper.DrawGoalLoc(startX, startY, x, y);
            }
            else if(drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.WAYPOINT.ToString()))
            {
                drawHelper.DrawWaypoint(startX, startY, x, y);
            }
        }

        private void generateMap_Click(object sender, EventArgs e)
        {
            if(isConvertThreadRunning | isGeneratingThreadRunning)
            {
                MessageBox.Show("Process already running, please wait!", "Error");
                return;
            }

            ThreadStart genThread = GeneratingThreadFunc;
            genThread += () => {
                if(isValidMap)
                {
                    GenForm genForm = new GenForm(genThreadSb.ToString());
                    genForm.ShowDialog();
                }
            };
            Thread thread = new Thread(genThread) { IsBackground = true };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void GeneratingThreadFunc()
        {

            isGeneratingThreadRunning = true;
            genThreadSb = new StringBuilder("");
            try
            {
                string wpString = ":";
                foreach (var item in waypointListBox.Items)
                {
                    wpString += item.ToString() + ":";
                }
                string mapStr = mapSize.ToString() + "\n" +
                    startLoc + wpString + goalLoc + "\n";

                genThreadSb.Append(mapStr);

                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        genThreadSb.Append(mapArr[j, i].ToString());
                    }
                    genThreadSb.Append("\n");

                    statusProgressBar.Invoke((MethodInvoker)delegate
                    {
                        statusProgressBar.Value = (int)(((double)i / mapSize) * 100);
                    });
                }

                statusProgressBar.Invoke((MethodInvoker)delegate
                {
                    statusProgressBar.Value = 100;
                });

                isValidMap = true;
            }
            catch
            {
                MessageBox.Show("Cannot generate a map until you create one and have completed all required attributes (start and goal location).", "Invalid Map");
                isValidMap = false;
            }
            isGeneratingThreadRunning = false;
        }

        private void drawRectButton_Click(object sender, EventArgs e)
        {
            isDrawRect = !isDrawRect;
            drawRectButton.BackColor = (isDrawRect) ? Color.Green : Color.Red;
        }

        private void openMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Users\\SuperJuanita\\Downloads\\street-map";
            openFileDialog1.Filter = "Map files (*.map) |*.map";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string[] fileArr = loadMap(openFileDialog1.FileName);
            int fileMapSize = 0;
            if(fileArr.Length > 4)
            {
                if(!int.TryParse(fileArr[1].Split(' ')[1], out fileMapSize))
                {
                    MessageBox.Show("Invalid map size!", "Error");
                    return;
                }
            }

            drawMapFile(fileArr, fileMapSize);
        }

        private void drawMapFile(string [] fileArr, int mapFileSize)
        {
            this.Invoke((MethodInvoker)delegate
            {
                map.Controls.Clear();   
                mapSize = mapFileSize;
                mapSizeTextBox.Text = mapSize.ToString();
                startLocTextBox.Text = "";
                goalLocTextBox.Text = ""; 

                scale = (int)(((double)screenHeight / mapSize) * 0.97);

                if (scale < 1)
                {
                    MessageBox.Show("Cannot load map, too large", "Error");
                    return;
                }

                map.Size = new Size((mapSize * scale + 2), (mapSize * scale + 2));
                mapArr = new int[mapSize, mapSize];
                g = map.CreateGraphics();
                drawHelper.DrawGrid(false, false);

                SolidBrush brush = new SolidBrush(Color.Black);
                for (int i = 4; i < fileArr.Length; i++)
                {
                    char[] line = fileArr[i].ToCharArray();
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == '@')
                        {
                            mapArr[j, i - 4] = 1;
                            g.FillRectangle(brush, new RectangleF(j * scale, (i - 4) * scale, scale, scale));
                        }
                    }
                }
            });
            
        }

        private string [] loadMap(string fileName)
        {

            const Int32 BufferSize = 128;
            string fileStr = "";
            string[] fileArr;
            using (var fileStream = File.OpenRead(fileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    fileStr += line + "\n";
                }
            }

            fileArr = fileStr.Split('\n');

            return fileArr;
        }

        private void convertBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Users\\SuperJuanita\\Downloads";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if(isConvertThreadRunning)
            {
                MessageBox.Show("Already trying to convert image, please wait.", "Error");
                return;
            }

            img = new Bitmap(openFileDialog1.FileName.ToString());

            Thread convertBinaryThread = new Thread(new ThreadStart(ConvertBinaryThreadFunc));
            convertBinaryThread.Start();

        }
        
        void ConvertBinaryThreadFunc()
        {
            startLoc = "";
            goalLoc = "";
            StringBuilder sb = new StringBuilder("");
            //The we make the cicles to read pixel by pixel and we make the comparation with the withe color.    
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if (img.GetPixel(j, i).A >= 0x7F && img.GetPixel(j, i).B >= 0x7F && img.GetPixel(j, i).G >= 0x7F && img.GetPixel(j, i).R >= 0x7F)
                    {
                        sb.Append(".");
                    }
                    else
                    {
                        sb.Append("@");
                    }
                }
                sb.Append("\n");

                statusProgressBar.Invoke((MethodInvoker)delegate
                {
                    statusProgressBar.Value = (int)(((double)i/img.Height) * 100);
                });
            }

            statusProgressBar.Invoke((MethodInvoker)delegate
            {
                statusProgressBar.Value = 100;
            });

            string [] fileArr = sb.ToString().Split('\n');

            drawMapFile(fileArr, fileArr.Length);
            isConvertThreadRunning = false;
            img.Dispose();
        }

        private void wpUpButton_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(waypointListBox, -1);
        }

        private void wpDownButton_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(waypointListBox, 1);
        }

        private void wpRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                drawHelper.DrawRemoveWaypoint(waypointListBox.SelectedItem.ToString());
                waypointListBox.Items.RemoveAt(waypointListBox.SelectedIndex);
            }
            catch { }
        }

        private void MoveSelectedItem(ListBox listBox, int direction)
        {
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return;

            int newIndex = listBox.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return; 

            object selected = listBox.SelectedItem;

            var checkedListBox = listBox as CheckedListBox;
            var checkState = CheckState.Unchecked;
            if (checkedListBox != null)
                checkState = checkedListBox.GetItemCheckState(checkedListBox.SelectedIndex);

            listBox.Items.Remove(selected);
            listBox.Items.Insert(newIndex, selected);
            listBox.SetSelected(newIndex, true);

            if (checkedListBox != null)
                checkedListBox.SetItemCheckState(newIndex, checkState);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
