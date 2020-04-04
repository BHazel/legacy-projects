using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BWHazel.Scientific.GaussGraph
{
    public partial class MainWindow : Form
    {
        string gaussGraphCopyright;
        string gaussGraphTitle;
        string gaussGraphVersion;
        Graph graph;
        FileIOPermission filePerms;

        public MainWindow()
        {
            InitializeComponent();
            this.SetGaussGraphDetails();
            graph = new Graph();
        }

        public void SetGaussGraphDetails()
        {
            foreach (Attribute attr in Assembly.GetExecutingAssembly().GetCustomAttributes(false))
            {
                if (attr.GetType() == typeof(AssemblyCopyrightAttribute))
                    gaussGraphCopyright = ((AssemblyCopyrightAttribute)attr).Copyright;
                if (attr.GetType() == typeof(AssemblyTitleAttribute))
                    gaussGraphTitle = ((AssemblyTitleAttribute)attr).Title;
                if (attr.GetType() == typeof(AssemblyFileVersionAttribute))
                    gaussGraphVersion = ((AssemblyFileVersionAttribute)attr).Version;
            }
        }

        public void OpenFile()
        {
            if (dfoOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePerms = new FileIOPermission(FileIOPermissionAccess.Read, dfoOpen.FileName);
                    filePerms.Demand();
                    string gvOutput = null;
                    using (StreamReader reader = new StreamReader(dfoOpen.FileName))
                    {
                        this.ResetUi();
                        gvOutput = reader.ReadToEnd();
                        graph.SetGraph(gvOutput);
                        this.SetUi(gvOutput);
                    }

                }
                catch (Exception ex)
                {
                    this.ShowMessageBox(ex.Message, MessageBoxIcon.Warning);
                }
            }
        }

        public void ExportGraphFile()
        {
            if (dfsExportGraph.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePerms = new FileIOPermission(FileIOPermissionAccess.Write, dfsExportGraph.FileName);
                    filePerms.Demand();
                    ChartImageFormat format;
                    if (dfsExportGraph.FilterIndex == 1) format = ChartImageFormat.Gif;
                    else if (dfsExportGraph.FilterIndex == 2) format = ChartImageFormat.Jpeg;
                    else if (dfsExportGraph.FilterIndex == 3) format = ChartImageFormat.Png;
                    else throw new ApplicationException("Unknown file type selected");
                    chtGraph.SaveImage(dfsExportGraph.FileName, format);
                }
                catch (Exception ex)
                {
                    this.ShowMessageBox(ex.Message, MessageBoxIcon.Warning);
                }
            }
        }

        public void ExportCsvFile()
        {
            if (dfsExportCsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePerms = new FileIOPermission(FileIOPermissionAccess.Write, dfsExportCsv.FileName);
                    filePerms.Demand();
                    using (StreamWriter writer = new StreamWriter(dfsExportCsv.FileName))
                    {
                        writer.Write(graph.ToCsv());
                    }
                }
                catch (Exception ex)
                {
                    this.ShowMessageBox(ex.Message, MessageBoxIcon.Warning);
                }
            }
        }

        public void ResetUi()
        {
            rtfGVOutput.Text = "";
            txtDescription.Text = "";
            rtfCsv.Text = "";
            grdData.DataSource = null;
            chtGraph.Series.Clear();
            chtGraph.Titles.Clear();
            btnExportCsv.Enabled = false;
            btnExportGraph.Enabled = false;
        }

        public void SetUi(string gvOutput)
        {
            rtfGVOutput.Text = gvOutput;
            txtDescription.Text = graph.Description;
            rtfCsv.Text = graph.ToCsv();
            grdData.DataSource = graph.DataPoints;
            chtGraph.Series.Add("DataSeries");

            string labels = null;
            chtGraph.Titles.Add(graph.Description);
            chtGraph.ChartAreas["ChartArea"].AxisX.Title = graph.XAxis;
            chtGraph.ChartAreas["ChartArea"].AxisY.Title = graph.YAxis;
            if (graph.DataPoints.Columns.Count == 4)
            {
                chtGraph.Series["DataSeries"].ChartType = SeriesChartType.Point;
                labels = "Label=Label";
            }
            else chtGraph.Series["DataSeries"].ChartType = SeriesChartType.Spline;
            chtGraph.Series["DataSeries"].Points.DataBind(graph.DataPoints.DefaultView, graph.XAxis, graph.YAxis, labels);

            btnExportCsv.Enabled = true;
            btnExportGraph.Enabled = true;
        }

        public void ShowMessageBox(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, gaussGraphTitle, MessageBoxButtons.OK, icon);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.OpenFile();
        }

        private void btnExportGraph_Click(object sender, EventArgs e)
        {
            this.ExportGraphFile();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            this.ExportCsvFile();
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowMessageBox(String.Format("{0} {1}\n\n{2}", gaussGraphTitle, gaussGraphVersion, gaussGraphCopyright), MessageBoxIcon.Information);
        }
    }
}
