
namespace ObstacleMapMaker
{
    partial class GenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.generatedMapTextBox = new System.Windows.Forms.RichTextBox();
            this.saveMapButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.generatedMapTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveMapButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1600, 865);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // generatedMapTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.generatedMapTextBox, 2);
            this.generatedMapTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatedMapTextBox.Location = new System.Drawing.Point(6, 56);
            this.generatedMapTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.generatedMapTextBox.Name = "generatedMapTextBox";
            this.generatedMapTextBox.Size = new System.Drawing.Size(1588, 803);
            this.generatedMapTextBox.TabIndex = 0;
            this.generatedMapTextBox.Text = "";
            this.generatedMapTextBox.WordWrap = false;
            // 
            // saveMapButton
            // 
            this.saveMapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMapButton.Location = new System.Drawing.Point(1, 1);
            this.saveMapButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveMapButton.Name = "saveMapButton";
            this.saveMapButton.Size = new System.Drawing.Size(318, 48);
            this.saveMapButton.TabIndex = 1;
            this.saveMapButton.Text = "Save Map";
            this.saveMapButton.UseVisualStyleBackColor = true;
            this.saveMapButton.Click += new System.EventHandler(this.saveMapButton_Click);
            // 
            // GenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GenForm";
            this.Text = "Generated Map";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox generatedMapTextBox;
        private System.Windows.Forms.Button saveMapButton;
    }
}