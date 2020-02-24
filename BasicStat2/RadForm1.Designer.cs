namespace BasicStat2
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.LinearAxis linearAxis3 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis4 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.ScatterLineSeries scatterLineSeries3 = new Telerik.WinControls.UI.ScatterLineSeries();
            Telerik.WinControls.UI.ScatterLineSeries scatterLineSeries4 = new Telerik.WinControls.UI.ScatterLineSeries();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radTabbedFormControl1 = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.radTabbedFormControlTab1 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            this.radTabbedFormControlTab2 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radTabbedFormControlTab3 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).BeginInit();
            this.radTabbedFormControl1.SuspendLayout();
            this.radTabbedFormControlTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            this.radTabbedFormControlTab2.SuspendLayout();
            this.radTabbedFormControlTab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabbedFormControl1
            // 
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab1);
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab2);
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab3);
            this.radTabbedFormControl1.Location = new System.Drawing.Point(0, 0);
            this.radTabbedFormControl1.Name = "radTabbedFormControl1";
            this.radTabbedFormControl1.SelectedTab = this.radTabbedFormControlTab1;
            this.radTabbedFormControl1.ShowNewTabButton = false;
            this.radTabbedFormControl1.ShowTabCloseButton = false;
            this.radTabbedFormControl1.Size = new System.Drawing.Size(792, 595);
            this.radTabbedFormControl1.TabHeight = 29;
            this.radTabbedFormControl1.TabIndex = 1;
            this.radTabbedFormControl1.TabSpacing = -1;
            this.radTabbedFormControl1.Text = "Описательная статистика";
            this.radTabbedFormControl1.ThemeName = "Crystal";
            this.radTabbedFormControl1.SelectedTabChanged += new System.EventHandler(this.radTabbedFormControlTab2_Enter);
            // 
            // radTabbedFormControlTab1
            // 
            this.radTabbedFormControlTab1.Controls.Add(this.radTextBox1);
            this.radTabbedFormControlTab1.Controls.Add(this.radPropertyGrid1);
            this.radTabbedFormControlTab1.Location = new System.Drawing.Point(1, 31);
            this.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1";
            this.radTabbedFormControlTab1.Size = new System.Drawing.Size(790, 563);
            this.radTabbedFormControlTab1.Text = "Личные данные";
            // 
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPropertyGrid1.ItemHeight = 30;
            this.radPropertyGrid1.ItemIndent = 30;
            this.radPropertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.radPropertyGrid1.Size = new System.Drawing.Size(425, 563);
            this.radPropertyGrid1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.radPropertyGrid1.TabIndex = 0;
            this.radPropertyGrid1.ThemeName = "Crystal";
            // 
            // radTabbedFormControlTab2
            // 
            this.radTabbedFormControlTab2.Controls.Add(this.radTextBox2);
            this.radTabbedFormControlTab2.Controls.Add(this.dataGridView2);
            this.radTabbedFormControlTab2.Controls.Add(this.dataGridView1);
            this.radTabbedFormControlTab2.Location = new System.Drawing.Point(1, 31);
            this.radTabbedFormControlTab2.Name = "radTabbedFormControlTab2";
            this.radTabbedFormControlTab2.Size = new System.Drawing.Size(790, 563);
            this.radTabbedFormControlTab2.Text = "Задание";
            this.radTabbedFormControlTab2.Enter += new System.EventHandler(this.radTabbedFormControlTab2_Enter);
            // 
            // radTabbedFormControlTab3
            // 
            this.radTabbedFormControlTab3.Controls.Add(this.radChartView1);
            this.radTabbedFormControlTab3.Location = new System.Drawing.Point(1, 31);
            this.radTabbedFormControlTab3.Name = "radTabbedFormControlTab3";
            this.radTabbedFormControlTab3.Size = new System.Drawing.Size(790, 563);
            this.radTabbedFormControlTab3.Text = "Результаты";
            // 
            // radTextBox1
            // 
            this.radTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.radTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTextBox1.Location = new System.Drawing.Point(425, 0);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.ReadOnly = true;
            // 
            // 
            // 
            this.radTextBox1.RootElement.StretchVertically = true;
            this.radTextBox1.Size = new System.Drawing.Size(365, 563);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.Text = resources.GetString("radTextBox1.Text");
            this.radTextBox1.ThemeName = "Crystal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 563);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(240, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(240, 563);
            this.dataGridView2.TabIndex = 1;
            // 
            // radTextBox2
            // 
            this.radTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.radTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTextBox2.Location = new System.Drawing.Point(480, 0);
            this.radTextBox2.Multiline = true;
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.ReadOnly = true;
            // 
            // 
            // 
            this.radTextBox2.RootElement.StretchVertically = true;
            this.radTextBox2.Size = new System.Drawing.Size(310, 563);
            this.radTextBox2.TabIndex = 2;
            this.radTextBox2.Text = resources.GetString("radTextBox2.Text");
            this.radTextBox2.ThemeName = "Crystal";
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea2;
            linearAxis3.IsPrimary = true;
            linearAxis3.TickOrigin = null;
            linearAxis4.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis4.IsPrimary = true;
            linearAxis4.TickOrigin = null;
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            linearAxis3,
            linearAxis4});
            this.radChartView1.Location = new System.Drawing.Point(11, 17);
            this.radChartView1.Name = "radChartView1";
            scatterLineSeries3.HorizontalAxis = linearAxis3;
            scatterLineSeries3.VerticalAxis = linearAxis4;
            scatterLineSeries4.HorizontalAxis = linearAxis3;
            scatterLineSeries4.VerticalAxis = linearAxis4;
            this.radChartView1.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            scatterLineSeries3,
            scatterLineSeries4});
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(759, 535);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.ThemeName = "Crystal";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 595);
            this.Controls.Add(this.radTabbedFormControl1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Описательная статистика";
            this.ThemeName = "Crystal";
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).EndInit();
            this.radTabbedFormControl1.ResumeLayout(false);
            this.radTabbedFormControlTab1.ResumeLayout(false);
            this.radTabbedFormControlTab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            this.radTabbedFormControlTab2.ResumeLayout(false);
            this.radTabbedFormControlTab2.PerformLayout();
            this.radTabbedFormControlTab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadTabbedFormControl radTabbedFormControl1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab1;
        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab2;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab3;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}
