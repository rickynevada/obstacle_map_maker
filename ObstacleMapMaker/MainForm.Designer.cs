
namespace ObstacleMapMaker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.map = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.mapSizeTextBox = new System.Windows.Forms.TextBox();
            this.canvasResizeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startLocTextBox = new System.Windows.Forms.TextBox();
            this.goalLocTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.generateMap = new System.Windows.Forms.Button();
            this.drawTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drawRectButton = new System.Windows.Forms.Button();
            this.waypointListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.wpUpButton = new System.Windows.Forms.Button();
            this.wpDownButton = new System.Windows.Forms.Button();
            this.wpRemoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.map, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1038F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1718, 1038);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // map
            // 
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.Location = new System.Drawing.Point(429, 0);
            this.map.Margin = new System.Windows.Forms.Padding(0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(0, 0);
            this.map.TabIndex = 0;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_ClickEvent);
            this.map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map_MouseDownEvent);
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_DrawMouseMove);
            this.map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.map_MouseUpEvent);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 1038);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(429, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mapSizeTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.canvasResizeButton, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.startLocTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.goalLocTextBox, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 23);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(427, 346);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size (n):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mapSizeTextBox
            // 
            this.mapSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mapSizeTextBox.Location = new System.Drawing.Point(214, 20);
            this.mapSizeTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.mapSizeTextBox.Name = "mapSizeTextBox";
            this.mapSizeTextBox.Size = new System.Drawing.Size(212, 29);
            this.mapSizeTextBox.TabIndex = 1;
            this.mapSizeTextBox.Text = "50";
            // 
            // canvasResizeButton
            // 
            this.canvasResizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasResizeButton.Location = new System.Drawing.Point(214, 208);
            this.canvasResizeButton.Margin = new System.Windows.Forms.Padding(1);
            this.canvasResizeButton.Name = "canvasResizeButton";
            this.canvasResizeButton.Size = new System.Drawing.Size(212, 67);
            this.canvasResizeButton.TabIndex = 2;
            this.canvasResizeButton.Text = "Create";
            this.canvasResizeButton.UseVisualStyleBackColor = true;
            this.canvasResizeButton.Click += new System.EventHandler(this.canvasResizeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(1, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 67);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Location (x,y):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(1, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 67);
            this.label4.TabIndex = 6;
            this.label4.Text = "Goal Location (x,y):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startLocTextBox
            // 
            this.startLocTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startLocTextBox.Location = new System.Drawing.Point(214, 89);
            this.startLocTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.startLocTextBox.Name = "startLocTextBox";
            this.startLocTextBox.Size = new System.Drawing.Size(212, 29);
            this.startLocTextBox.TabIndex = 7;
            this.startLocTextBox.Text = "4,4";
            // 
            // goalLocTextBox
            // 
            this.goalLocTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goalLocTextBox.Location = new System.Drawing.Point(214, 158);
            this.goalLocTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.goalLocTextBox.Name = "goalLocTextBox";
            this.goalLocTextBox.Size = new System.Drawing.Size(212, 29);
            this.goalLocTextBox.TabIndex = 8;
            this.goalLocTextBox.Text = "47,47";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 370);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(429, 630);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toolbox";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.generateMap, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.drawTypeComboBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.drawRectButton, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.waypointListBox, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 23);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(427, 606);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // generateMap
            // 
            this.generateMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateMap.Location = new System.Drawing.Point(214, 129);
            this.generateMap.Margin = new System.Windows.Forms.Padding(1);
            this.generateMap.Name = "generateMap";
            this.generateMap.Size = new System.Drawing.Size(212, 117);
            this.generateMap.TabIndex = 9;
            this.generateMap.Text = "Generate";
            this.generateMap.UseVisualStyleBackColor = true;
            this.generateMap.Click += new System.EventHandler(this.generateMap_Click);
            // 
            // drawTypeComboBox
            // 
            this.drawTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.drawTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawTypeComboBox.FormattingEnabled = true;
            this.drawTypeComboBox.Location = new System.Drawing.Point(214, 16);
            this.drawTypeComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.drawTypeComboBox.Name = "drawTypeComboBox";
            this.drawTypeComboBox.Size = new System.Drawing.Size(212, 32);
            this.drawTypeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "Draw:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawRectButton
            // 
            this.drawRectButton.BackColor = System.Drawing.Color.Red;
            this.drawRectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawRectButton.Location = new System.Drawing.Point(214, 65);
            this.drawRectButton.Margin = new System.Windows.Forms.Padding(1);
            this.drawRectButton.Name = "drawRectButton";
            this.drawRectButton.Size = new System.Drawing.Size(212, 62);
            this.drawRectButton.TabIndex = 0;
            this.drawRectButton.Text = "Draw Rectangle";
            this.drawRectButton.UseVisualStyleBackColor = false;
            this.drawRectButton.Click += new System.EventHandler(this.drawRectButton_Click);
            // 
            // waypointListBox
            // 
            this.waypointListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waypointListBox.FormattingEnabled = true;
            this.waypointListBox.ItemHeight = 24;
            this.waypointListBox.Location = new System.Drawing.Point(1, 367);
            this.waypointListBox.Margin = new System.Windows.Forms.Padding(1);
            this.waypointListBox.Name = "waypointListBox";
            this.tableLayoutPanel4.SetRowSpan(this.waypointListBox, 2);
            this.waypointListBox.Size = new System.Drawing.Size(211, 238);
            this.waypointListBox.TabIndex = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.wpUpButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.wpDownButton, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.wpRemoveButton, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(213, 366);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(214, 240);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // wpUpButton
            // 
            this.wpUpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpUpButton.Location = new System.Drawing.Point(1, 1);
            this.wpUpButton.Margin = new System.Windows.Forms.Padding(1);
            this.wpUpButton.Name = "wpUpButton";
            this.wpUpButton.Size = new System.Drawing.Size(212, 78);
            this.wpUpButton.TabIndex = 0;
            this.wpUpButton.Text = "Up";
            this.wpUpButton.UseVisualStyleBackColor = true;
            this.wpUpButton.Click += new System.EventHandler(this.wpUpButton_Click);
            // 
            // wpDownButton
            // 
            this.wpDownButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpDownButton.Location = new System.Drawing.Point(1, 81);
            this.wpDownButton.Margin = new System.Windows.Forms.Padding(1);
            this.wpDownButton.Name = "wpDownButton";
            this.wpDownButton.Size = new System.Drawing.Size(212, 78);
            this.wpDownButton.TabIndex = 1;
            this.wpDownButton.Text = "Down";
            this.wpDownButton.UseVisualStyleBackColor = true;
            this.wpDownButton.Click += new System.EventHandler(this.wpDownButton_Click);
            // 
            // wpRemoveButton
            // 
            this.wpRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpRemoveButton.Location = new System.Drawing.Point(1, 161);
            this.wpRemoveButton.Margin = new System.Windows.Forms.Padding(1);
            this.wpRemoveButton.Name = "wpRemoveButton";
            this.wpRemoveButton.Size = new System.Drawing.Size(212, 78);
            this.wpRemoveButton.TabIndex = 2;
            this.wpRemoveButton.Text = "Remove";
            this.wpRemoveButton.UseVisualStyleBackColor = true;
            this.wpRemoveButton.Click += new System.EventHandler(this.wpRemoveButton_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.statusProgressBar, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 1000);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(429, 38);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusProgressBar.Location = new System.Drawing.Point(129, 1);
            this.statusProgressBar.Margin = new System.Windows.Forms.Padding(1);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(299, 36);
            this.statusProgressBar.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1718, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMapToolStripMenuItem,
            this.convertBinaryToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMapToolStripMenuItem
            // 
            this.openMapToolStripMenuItem.Name = "openMapToolStripMenuItem";
            this.openMapToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.openMapToolStripMenuItem.Text = "Open .map";
            this.openMapToolStripMenuItem.Click += new System.EventHandler(this.openMapToolStripMenuItem_Click);
            // 
            // convertBinaryToolStripMenuItem
            // 
            this.convertBinaryToolStripMenuItem.Name = "convertBinaryToolStripMenuItem";
            this.convertBinaryToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.convertBinaryToolStripMenuItem.Text = "Convert Image";
            this.convertBinaryToolStripMenuItem.Click += new System.EventHandler(this.convertBinaryToolStripMenuItem_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1718, 1084);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 1084);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Obstacle Map Maker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button canvasResizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateMap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button drawRectButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMapToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ToolStripMenuItem convertBinaryToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button wpUpButton;
        private System.Windows.Forms.Button wpDownButton;
        private System.Windows.Forms.Button wpRemoveButton;
        public System.Windows.Forms.TextBox mapSizeTextBox;
        public System.Windows.Forms.TextBox startLocTextBox;
        public System.Windows.Forms.TextBox goalLocTextBox;
        public System.Windows.Forms.ComboBox drawTypeComboBox;
        public System.Windows.Forms.ListBox waypointListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

