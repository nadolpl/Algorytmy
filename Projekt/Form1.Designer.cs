namespace Projekt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DescendingOrderBtn = new System.Windows.Forms.RadioButton();
            this.RandomOrderBtn = new System.Windows.Forms.RadioButton();
            this.AscendingOrderBtn = new System.Windows.Forms.RadioButton();
            this.BubbleBtn = new System.Windows.Forms.RadioButton();
            this.MergeBtn = new System.Windows.Forms.RadioButton();
            this.QuickBtn = new System.Windows.Forms.RadioButton();
            this.SelectionBtn = new System.Windows.Forms.RadioButton();
            this.InsertionBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearChartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToChartBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PointsBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ElementsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescendingOrderBtn
            // 
            this.DescendingOrderBtn.AutoSize = true;
            this.DescendingOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescendingOrderBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.DescendingOrderBtn.Location = new System.Drawing.Point(0, 76);
            this.DescendingOrderBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DescendingOrderBtn.Name = "DescendingOrderBtn";
            this.DescendingOrderBtn.Size = new System.Drawing.Size(138, 26);
            this.DescendingOrderBtn.TabIndex = 2;
            this.DescendingOrderBtn.Text = "Descending";
            this.DescendingOrderBtn.UseVisualStyleBackColor = true;
            // 
            // RandomOrderBtn
            // 
            this.RandomOrderBtn.AutoSize = true;
            this.RandomOrderBtn.Checked = true;
            this.RandomOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomOrderBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.RandomOrderBtn.Location = new System.Drawing.Point(0, 0);
            this.RandomOrderBtn.Margin = new System.Windows.Forms.Padding(6);
            this.RandomOrderBtn.Name = "RandomOrderBtn";
            this.RandomOrderBtn.Size = new System.Drawing.Size(106, 26);
            this.RandomOrderBtn.TabIndex = 3;
            this.RandomOrderBtn.TabStop = true;
            this.RandomOrderBtn.Text = "Random";
            this.RandomOrderBtn.UseVisualStyleBackColor = true;
            // 
            // AscendingOrderBtn
            // 
            this.AscendingOrderBtn.AutoSize = true;
            this.AscendingOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AscendingOrderBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.AscendingOrderBtn.Location = new System.Drawing.Point(0, 38);
            this.AscendingOrderBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AscendingOrderBtn.Name = "AscendingOrderBtn";
            this.AscendingOrderBtn.Size = new System.Drawing.Size(126, 26);
            this.AscendingOrderBtn.TabIndex = 4;
            this.AscendingOrderBtn.Text = "Ascending";
            this.AscendingOrderBtn.UseVisualStyleBackColor = true;
            // 
            // BubbleBtn
            // 
            this.BubbleBtn.AutoSize = true;
            this.BubbleBtn.Checked = true;
            this.BubbleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BubbleBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.BubbleBtn.Location = new System.Drawing.Point(15, 54);
            this.BubbleBtn.Margin = new System.Windows.Forms.Padding(6);
            this.BubbleBtn.Name = "BubbleBtn";
            this.BubbleBtn.Size = new System.Drawing.Size(137, 26);
            this.BubbleBtn.TabIndex = 5;
            this.BubbleBtn.TabStop = true;
            this.BubbleBtn.Text = "Bubble Sort";
            this.BubbleBtn.UseVisualStyleBackColor = true;
            // 
            // MergeBtn
            // 
            this.MergeBtn.AutoSize = true;
            this.MergeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MergeBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.MergeBtn.Location = new System.Drawing.Point(15, 95);
            this.MergeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(131, 26);
            this.MergeBtn.TabIndex = 6;
            this.MergeBtn.Text = "Merge Sort";
            this.MergeBtn.UseVisualStyleBackColor = true;
            // 
            // QuickBtn
            // 
            this.QuickBtn.AutoSize = true;
            this.QuickBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuickBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.QuickBtn.Location = new System.Drawing.Point(15, 135);
            this.QuickBtn.Margin = new System.Windows.Forms.Padding(6);
            this.QuickBtn.Name = "QuickBtn";
            this.QuickBtn.Size = new System.Drawing.Size(127, 26);
            this.QuickBtn.TabIndex = 7;
            this.QuickBtn.Text = "Quick Sort";
            this.QuickBtn.UseVisualStyleBackColor = true;
            // 
            // SelectionBtn
            // 
            this.SelectionBtn.AutoSize = true;
            this.SelectionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectionBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.SelectionBtn.Location = new System.Drawing.Point(15, 178);
            this.SelectionBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SelectionBtn.Name = "SelectionBtn";
            this.SelectionBtn.Size = new System.Drawing.Size(158, 26);
            this.SelectionBtn.TabIndex = 8;
            this.SelectionBtn.Text = "Selection Sort";
            this.SelectionBtn.UseVisualStyleBackColor = true;
            // 
            // InsertionBtn
            // 
            this.InsertionBtn.AutoSize = true;
            this.InsertionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertionBtn.Font = new System.Drawing.Font("Sansation", 15F);
            this.InsertionBtn.Location = new System.Drawing.Point(15, 218);
            this.InsertionBtn.Margin = new System.Windows.Forms.Padding(6);
            this.InsertionBtn.Name = "InsertionBtn";
            this.InsertionBtn.Size = new System.Drawing.Size(154, 26);
            this.InsertionBtn.TabIndex = 9;
            this.InsertionBtn.Text = "Insertion Sort";
            this.InsertionBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sansation", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sort type";
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Chart.BackImageTransparentColor = System.Drawing.Color.White;
            this.Chart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(296, 0);
            this.Chart.Margin = new System.Windows.Forms.Padding(0);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(688, 492);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // ClearChartBtn
            // 
            this.ClearChartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClearChartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearChartBtn.Font = new System.Drawing.Font("Sansation", 25F);
            this.ClearChartBtn.Location = new System.Drawing.Point(399, 498);
            this.ClearChartBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ClearChartBtn.Name = "ClearChartBtn";
            this.ClearChartBtn.Size = new System.Drawing.Size(365, 57);
            this.ClearChartBtn.TabIndex = 1;
            this.ClearChartBtn.Text = "CLEAR";
            this.ClearChartBtn.UseVisualStyleBackColor = false;
            this.ClearChartBtn.Click += new System.EventHandler(this.ClearChartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sansation", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numbers order";
            // 
            // AddToChartBtn
            // 
            this.AddToChartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddToChartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToChartBtn.Font = new System.Drawing.Font("Sansation", 20F);
            this.AddToChartBtn.Location = new System.Drawing.Point(15, 505);
            this.AddToChartBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddToChartBtn.Name = "AddToChartBtn";
            this.AddToChartBtn.Size = new System.Drawing.Size(192, 48);
            this.AddToChartBtn.TabIndex = 14;
            this.AddToChartBtn.Text = "ADD";
            this.AddToChartBtn.UseVisualStyleBackColor = false;
            this.AddToChartBtn.Click += new System.EventHandler(this.AddToChartBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sansation", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Points:";
            // 
            // PointsBox
            // 
            this.PointsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PointsBox.Font = new System.Drawing.Font("Sansation", 15F);
            this.PointsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.PointsBox.Location = new System.Drawing.Point(111, 422);
            this.PointsBox.Name = "PointsBox";
            this.PointsBox.Size = new System.Drawing.Size(97, 30);
            this.PointsBox.TabIndex = 16;
            this.PointsBox.Text = "10";
            this.PointsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.RandomOrderBtn);
            this.panel1.Controls.Add(this.DescendingOrderBtn);
            this.panel1.Controls.Add(this.AscendingOrderBtn);
            this.panel1.Location = new System.Drawing.Point(15, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 102);
            this.panel1.TabIndex = 17;
            // 
            // ElementsBox
            // 
            this.ElementsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ElementsBox.Font = new System.Drawing.Font("Sansation", 15F);
            this.ElementsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.ElementsBox.Location = new System.Drawing.Point(196, 462);
            this.ElementsBox.Name = "ElementsBox";
            this.ElementsBox.Size = new System.Drawing.Size(97, 30);
            this.ElementsBox.TabIndex = 21;
            this.ElementsBox.Text = "10000";
            this.ElementsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sansation", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Max Elements:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(313, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Time (ms)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(572, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Elements";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(828, 518);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 24;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ElementsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PointsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddToChartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertionBtn);
            this.Controls.Add(this.SelectionBtn);
            this.Controls.Add(this.QuickBtn);
            this.Controls.Add(this.MergeBtn);
            this.Controls.Add(this.BubbleBtn);
            this.Controls.Add(this.ClearChartBtn);
            this.Controls.Add(this.Chart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Sort types";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton DescendingOrderBtn;
        private System.Windows.Forms.RadioButton RandomOrderBtn;
        private System.Windows.Forms.RadioButton AscendingOrderBtn;
        private System.Windows.Forms.RadioButton BubbleBtn;
        private System.Windows.Forms.RadioButton MergeBtn;
        private System.Windows.Forms.RadioButton QuickBtn;
        private System.Windows.Forms.RadioButton SelectionBtn;
        private System.Windows.Forms.RadioButton InsertionBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Button ClearChartBtn;
        private System.Windows.Forms.Button AddToChartBtn;
        private System.Windows.Forms.TextBox PointsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ElementsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

