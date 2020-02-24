using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
//
using BasicStatLibrary;

namespace BasicStat2
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadTabbedForm
    {
        public RadForm1()
        {
            InitializeComponent();

            this.radPropertyGrid1.SelectedObject = person;
        }

        public Person person { get; set; } = new Person();
        public DataGen gen { get; set; } = new DataGen();
        public DataGen gen1 { get; set; } = new DataGen();

        public List<double> Height1 { get; set; } = new List<double>();
        public List<double> Weight { get; set; } = new List<double>();

        private void radTabbedFormControlTab2_Enter(object sender, EventArgs e)
        {
            if (this.TabbedFormControl.SelectedTab.Item.Text == "Задание")
            {
                // MessageBox.Show("Задание");
                // DataGen gen = new DataGen();
                gen.Setup(person.HashCode);
                gen.Generate();

                Height1 = gen.Items;

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("c1", "Рост");
                dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Rows.Clear();
                foreach (double item in Height1)
                {
                    dataGridView1.Rows.Add(Math.Floor(item));
                }

                gen1.Setup(person.HashCode,250,500,60,140);
                gen1.random.Next();
                gen1.Generate();
                Weight = gen1.Items;

                dataGridView2.Columns.Clear();
                dataGridView2.Columns.Add("c1", "Вес");
                dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView2.Rows.Clear();
                foreach (double item in Weight)
                {
                    dataGridView2.Rows.Add(Math.Floor(item));
                }

            }
            if (this.TabbedFormControl.SelectedTab.Item.Text == "Результаты")
            {
                var s1 = this.radChartView1.Series[0];
                var s2 = this.radChartView1.Series[1];

                s1.DataPoints.Clear();
                s2.DataPoints.Clear();

                int index = 0;
                foreach (double item in Height1)
                {
                    s1.DataPoints.Add(new Telerik.Charting.ScatterDataPoint(index,item));
                    index++;
                }
                index = 0;
                foreach (double item in Weight)
                {
                    s2.DataPoints.Add(new Telerik.Charting.ScatterDataPoint(index, item));
                    index++;
                }

            }

        }
    }
}
