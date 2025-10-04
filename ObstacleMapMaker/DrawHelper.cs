using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ObstacleMapMaker
{
    public class DrawHelper
    {

        MainForm mainForm;

        public DrawHelper(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void DrawGrid(bool withBorder, bool hasStart)
        {
            mainForm.g.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 1.0f);
            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush startBrush = new SolidBrush(Color.Red);
            SolidBrush goalBrush = new SolidBrush(Color.Green);

            if (mainForm.mapSize < 600)
            {
                for (int i = 0; i <= mainForm.mapSize; i++)
                {
                    mainForm.g.DrawLine(pen, new Point(0, i * mainForm.scale), new Point(mainForm.mapSize * mainForm.scale, i * mainForm.scale));
                    mainForm.g.DrawLine(pen, new Point(i * mainForm.scale, 0), new Point(i * mainForm.scale, mainForm.mapSize * mainForm.scale));
                }
            }
            if(hasStart)
            {
                mainForm.g.FillRectangle(startBrush, new RectangleF((mainForm.startX - 1) * mainForm.scale, (mainForm.mapSize - mainForm.startY) * mainForm.scale, mainForm.scale, mainForm.scale));
                mainForm.g.FillRectangle(goalBrush, new RectangleF((mainForm.goalX - 1) * mainForm.scale, (mainForm.mapSize - mainForm.goalY) * mainForm.scale, mainForm.scale, mainForm.scale));

            }

            if (withBorder)
            {
                for (int i = 0; i < mainForm.mapSize; i++)
                {
                    mainForm.mapArr[i, 0] = 1;
                    mainForm.mapArr[0, i] = 1;
                    mainForm.mapArr[(mainForm.mapSize - 1), i] = 1;
                    mainForm.mapArr[i, (mainForm.mapSize - 1)] = 1;
                    mainForm.g.FillRectangle(brush, new RectangleF(i * mainForm.scale, 0, mainForm.scale, mainForm.scale));
                    mainForm.g.FillRectangle(brush, new RectangleF(0, i * mainForm.scale, mainForm.scale, mainForm.scale));
                    mainForm.g.FillRectangle(brush, new RectangleF(i * mainForm.scale, (mainForm.mapSize - 1) * mainForm.scale, mainForm.scale, mainForm.scale));
                    mainForm.g.FillRectangle(brush, new RectangleF((mainForm.mapSize - 1) * mainForm.scale, i * mainForm.scale, mainForm.scale, mainForm.scale));
                }
            }
        }
        public void DrawStartLoc(int startX, int startY, int x, int y)
        {
            int scale = mainForm.scale;
            int mapSize = mainForm.mapSize;
            Graphics g = mainForm.g;

            int sx, sy;
            Pen bpen;
            SolidBrush brush;
            //First clear old start loc
            if (mainForm.startLocTextBox.Text.Length > 0)
            {
                string[] startLocArr = mainForm.startLocTextBox.Text.Split(',');

                if (!int.TryParse(startLocArr[0], out sx) || !int.TryParse(startLocArr[1], out sy))
                {
                    MessageBox.Show("Start loc invalid, must be x,y", "Error");
                    return;
                }

                bpen = new Pen(Color.Black, 1.0f);
                brush = new SolidBrush(Color.White);
                g.FillRectangle(brush, new RectangleF((sx - 1) * scale, (mapSize - sy) * scale, scale, scale));
                g.DrawRectangle(bpen, new Rectangle((sx - 1) * scale, (mapSize - sy) * scale, scale, scale));

            }

            mainForm.mapArr[x, y] = 0;

            //Second draw new start loc
            bpen = new Pen(Color.Black, 1.0f);
            brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, new RectangleF(startX, startY, scale, scale));
            g.DrawRectangle(bpen, new Rectangle(startX, startY, scale, scale));
            mainForm.startLoc = mainForm.startLocTextBox.Text = (x + 1).ToString() + "," + (mapSize - y).ToString();
        }
        public void DrawGoalLoc(int startX, int startY, int x, int y)
        {
            int scale = mainForm.scale;
            int mapSize = mainForm.mapSize;
            Graphics g = mainForm.g;

            int sx, sy;
            Pen bpen;
            SolidBrush brush;
            //First clear old goal loc
            if (mainForm.goalLocTextBox.Text.Length > 0)
            {
                string[] goalLocArr = mainForm.goalLocTextBox.Text.Split(',');

                if (!int.TryParse(goalLocArr[0], out sx) || !int.TryParse(goalLocArr[1], out sy))
                {
                    MessageBox.Show("Goal loc invalid, must be x,y", "Error");
                    return;
                }

                bpen = new Pen(Color.Black, 1.0f);
                brush = new SolidBrush(Color.White);
                g.FillRectangle(brush, new RectangleF((sx - 1) * scale, (mapSize - sy) * scale, scale, scale));
                g.DrawRectangle(bpen, new Rectangle((sx - 1) * scale, (mapSize - sy) * scale, scale, scale));

            }

            mainForm.mapArr[x, y] = 0;

            //Second draw new start loc
            bpen = new Pen(Color.Black, 1.0f);
            brush = new SolidBrush(Color.Green);
            g.FillRectangle(brush, new RectangleF(startX, startY, scale, scale));
            g.DrawRectangle(bpen, new Rectangle(startX, startY, scale, scale));
            mainForm.goalLoc = mainForm.goalLocTextBox.Text = (x + 1).ToString() + "," + (mapSize - y).ToString();
        }
        public void DrawObstacle(int startX, int startY, int x, int y)
        {
            mainForm.mapArr[x, y] = 1;
            SolidBrush brush = new SolidBrush(Color.Black);
            mainForm.g.FillRectangle(brush, new RectangleF(startX, startY, mainForm.scale, mainForm.scale));
        }

        public void DrawNoObstacle(int startX, int startY, int x, int y)
        {
            mainForm.mapArr[x, y] = 0;
            Pen bpen = new Pen(Color.Black, 1.0f);
            SolidBrush brush = new SolidBrush(Color.White);
            mainForm.g.FillRectangle(brush, new RectangleF(startX, startY, mainForm.scale, mainForm.scale));
            if(mainForm.scale != 1)
                mainForm.g.DrawRectangle(bpen, new Rectangle(startX, startY, mainForm.scale, mainForm.scale));

        }

        internal void DrawMouseMove(MouseEventArgs e, int x, int y)
        {
            int scale = mainForm.scale;
            Graphics g = mainForm.g;

            if (mainForm.isMouseDown && !mainForm.isDrawRect)
            {

                int startX = x * scale;
                int startY = y * scale;

                if (mainForm.drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.OBSTACLE.ToString()))
                {
                    DrawObstacle(startX, startY, x, y);
                }
                else if (mainForm.drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.NO_OBSTACLE.ToString()))
                {
                    DrawNoObstacle(startX, startY, x, y);
                }
            }
            else if (mainForm.isMouseDown && mainForm.isDrawRect)
            {
                for (int i = mainForm.initX; i <= x; i++)
                {
                    for (int j = mainForm.initY; j <= y; j++)
                    {
                        try
                        {
                            if (mainForm.drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.OBSTACLE.ToString()))
                            {
                                DrawObstacle(i * scale, j * scale, i, j);
                            }
                            else if (mainForm.drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.NO_OBSTACLE.ToString()))
                            {
                                DrawNoObstacle(i * scale, j * scale, i, j);
                            }
                        }
                        catch { }
                    }
                }

                int startX = (e.X / scale) * scale;
                int startY = (e.Y / scale) * scale;

                try
                {

                    if (mainForm.drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.OBSTACLE.ToString()))
                    {
                        DrawObstacle(startX, startY, x, y);
                    }
                    else if (mainForm.drawTypeComboBox.SelectedItem.ToString().Equals(DrawTypes.NO_OBSTACLE.ToString()))
                    {
                        DrawNoObstacle(startX, startY, x, y);
                    }
                }
                catch { }
            }
        }

        internal void DrawWaypoint(int startX, int startY, int x, int y)
        {
            int scale = mainForm.scale;
            int mapSize = mainForm.mapSize;
            Graphics g = mainForm.g;

            Pen bpen;
            SolidBrush brush;

            mainForm.mapArr[x, y] = 0;

            bpen = new Pen(Color.Black, 1.0f);
            brush = new SolidBrush(Color.Orange);
            g.FillRectangle(brush, new RectangleF(startX, startY, scale, scale));
            g.DrawRectangle(bpen, new Rectangle(startX, startY, scale, scale));
            string temp = (x + 1).ToString() + "," + (mapSize - y).ToString();
            mainForm.waypointListBox.Items.Add(temp);
        }

        internal void RedrawWaypoint(int startX, int startY, int x, int y)
        {
            int scale = mainForm.scale;
            int mapSize = mainForm.mapSize;
            Graphics g = mainForm.g;

            Pen bpen;
            SolidBrush brush;

            mainForm.mapArr[x, y] = 0;

            bpen = new Pen(Color.Black, 1.0f);
            brush = new SolidBrush(Color.Orange);
            g.FillRectangle(brush, new RectangleF(startX, startY, scale, scale));
            g.DrawRectangle(bpen, new Rectangle(startX, startY, scale, scale));
        }

        internal void DrawRemoveWaypoint(string v)
        {
            int scale = mainForm.scale;
            int mapSize = mainForm.mapSize;
            Graphics g = mainForm.g;

            string[] valueStr = v.Split(',');
            int sx = Int32.Parse(valueStr[0]);
            int sy = Int32.Parse(valueStr[1]);

            Pen bpen;
            SolidBrush brush;

            bpen = new Pen(Color.Black, 1.0f);
            brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, new RectangleF((sx - 1) * scale, (mapSize - sy) * scale, scale, scale));
            g.DrawRectangle(bpen, new Rectangle((sx - 1) * scale, (mapSize - sy) * scale, scale, scale));

        }

        internal void DrawUpdate()
        {
            //Draw Obstacles
            for(int i = 0; i < mainForm.mapArr.GetLength(0); i++)
            {
                for(int j = 0; j < mainForm.mapArr.GetLength(1); j++)
                {
                    if (mainForm.mapArr[i,j] == 1)
                    {
                        DrawObstacle(i * mainForm.scale, j * mainForm.scale, i, j);
                    }
                }
            }
            //Draw Waypoints
            foreach(var item in mainForm.waypointListBox.Items)
            {
                int mapSize = mainForm.mapSize;
                int scale = mainForm.scale;
                string v = item.ToString();
                string[] valueStr = v.Split(',');
                int sx = Int32.Parse(valueStr[0]);
                int sy = Int32.Parse(valueStr[1]);
                RedrawWaypoint(scale * (sx - 1), scale * (mapSize-sy), sx, sy);
            }
        }
    }
}
