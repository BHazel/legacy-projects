namespace BWHazel.Scientific.GaussGraph
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tabGaussGraph = new System.Windows.Forms.TabControl();
            this.tbpData = new System.Windows.Forms.TabPage();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.tbpGraph = new System.Windows.Forms.TabPage();
            this.btnExportGraph = new System.Windows.Forms.Button();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.chtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpCsv = new System.Windows.Forms.TabPage();
            this.rtfCsv = new System.Windows.Forms.RichTextBox();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.tbpGVOutput = new System.Windows.Forms.TabPage();
            this.rtfGVOutput = new System.Windows.Forms.RichTextBox();
            this.dfoOpen = new System.Windows.Forms.OpenFileDialog();
            this.dfsExportGraph = new System.Windows.Forms.SaveFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.dfsExportCsv = new System.Windows.Forms.SaveFileDialog();
            this.tabGaussGraph.SuspendLayout();
            this.tbpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.tbpGraph.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).BeginInit();
            this.tbpCsv.SuspendLayout();
            this.tbpGVOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 13);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(82, 10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(454, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // tabGaussGraph
            // 
            this.tabGaussGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGaussGraph.Controls.Add(this.tbpData);
            this.tabGaussGraph.Controls.Add(this.tbpGraph);
            this.tabGaussGraph.Controls.Add(this.tbpCsv);
            this.tabGaussGraph.Controls.Add(this.tbpGVOutput);
            this.tabGaussGraph.Location = new System.Drawing.Point(16, 41);
            this.tabGaussGraph.Name = "tabGaussGraph";
            this.tabGaussGraph.SelectedIndex = 0;
            this.tabGaussGraph.Size = new System.Drawing.Size(601, 274);
            this.tabGaussGraph.TabIndex = 4;
            // 
            // tbpData
            // 
            this.tbpData.Controls.Add(this.grdData);
            this.tbpData.Location = new System.Drawing.Point(4, 22);
            this.tbpData.Name = "tbpData";
            this.tbpData.Size = new System.Drawing.Size(593, 248);
            this.tbpData.TabIndex = 2;
            this.tbpData.Text = "Data";
            this.tbpData.UseVisualStyleBackColor = true;
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(10, 10);
            this.grdData.Margin = new System.Windows.Forms.Padding(10);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.Size = new System.Drawing.Size(573, 228);
            this.grdData.TabIndex = 0;
            // 
            // tbpGraph
            // 
            this.tbpGraph.Controls.Add(this.btnExportGraph);
            this.tbpGraph.Controls.Add(this.pnlGraph);
            this.tbpGraph.Location = new System.Drawing.Point(4, 22);
            this.tbpGraph.Name = "tbpGraph";
            this.tbpGraph.Size = new System.Drawing.Size(593, 248);
            this.tbpGraph.TabIndex = 3;
            this.tbpGraph.Text = "Graph";
            this.tbpGraph.UseVisualStyleBackColor = true;
            // 
            // btnExportGraph
            // 
            this.btnExportGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportGraph.Enabled = false;
            this.btnExportGraph.Location = new System.Drawing.Point(10, 215);
            this.btnExportGraph.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.btnExportGraph.Name = "btnExportGraph";
            this.btnExportGraph.Size = new System.Drawing.Size(75, 23);
            this.btnExportGraph.TabIndex = 3;
            this.btnExportGraph.Text = "Export...";
            this.btnExportGraph.UseVisualStyleBackColor = true;
            this.btnExportGraph.Click += new System.EventHandler(this.btnExportGraph_Click);
            // 
            // pnlGraph
            // 
            this.pnlGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGraph.Controls.Add(this.chtGraph);
            this.pnlGraph.Location = new System.Drawing.Point(10, 10);
            this.pnlGraph.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(573, 199);
            this.pnlGraph.TabIndex = 2;
            // 
            // chtGraph
            // 
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.Name = "ChartArea";
            this.chtGraph.ChartAreas.Add(chartArea2);
            this.chtGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtGraph.Location = new System.Drawing.Point(0, 0);
            this.chtGraph.Name = "chtGraph";
            series2.ChartArea = "ChartArea";
            series2.Name = "DataSeries";
            this.chtGraph.Series.Add(series2);
            this.chtGraph.Size = new System.Drawing.Size(569, 195);
            this.chtGraph.TabIndex = 0;
            // 
            // tbpCsv
            // 
            this.tbpCsv.Controls.Add(this.rtfCsv);
            this.tbpCsv.Controls.Add(this.btnExportCsv);
            this.tbpCsv.Location = new System.Drawing.Point(4, 22);
            this.tbpCsv.Name = "tbpCsv";
            this.tbpCsv.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCsv.Size = new System.Drawing.Size(593, 248);
            this.tbpCsv.TabIndex = 1;
            this.tbpCsv.Text = "CSV";
            this.tbpCsv.UseVisualStyleBackColor = true;
            // 
            // rtfCsv
            // 
            this.rtfCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfCsv.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfCsv.Location = new System.Drawing.Point(10, 10);
            this.rtfCsv.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.rtfCsv.Name = "rtfCsv";
            this.rtfCsv.Size = new System.Drawing.Size(573, 199);
            this.rtfCsv.TabIndex = 2;
            this.rtfCsv.Text = "";
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportCsv.Enabled = false;
            this.btnExportCsv.Location = new System.Drawing.Point(10, 215);
            this.btnExportCsv.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(75, 23);
            this.btnExportCsv.TabIndex = 1;
            this.btnExportCsv.Text = "Export...";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // tbpGVOutput
            // 
            this.tbpGVOutput.Controls.Add(this.rtfGVOutput);
            this.tbpGVOutput.Location = new System.Drawing.Point(4, 22);
            this.tbpGVOutput.Name = "tbpGVOutput";
            this.tbpGVOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGVOutput.Size = new System.Drawing.Size(593, 248);
            this.tbpGVOutput.TabIndex = 0;
            this.tbpGVOutput.Text = "GaussView Output";
            this.tbpGVOutput.UseVisualStyleBackColor = true;
            // 
            // rtfGVOutput
            // 
            this.rtfGVOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfGVOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfGVOutput.Location = new System.Drawing.Point(10, 10);
            this.rtfGVOutput.Margin = new System.Windows.Forms.Padding(10);
            this.rtfGVOutput.Name = "rtfGVOutput";
            this.rtfGVOutput.Size = new System.Drawing.Size(573, 228);
            this.rtfGVOutput.TabIndex = 0;
            this.rtfGVOutput.Text = "";
            // 
            // dfsExportGraph
            // 
            this.dfsExportGraph.Filter = "Graphics Interchange Format (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|Portable Network Gra" +
    "phics (*.png)|*.png";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(542, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lnkAbout
            // 
            this.lnkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Location = new System.Drawing.Point(578, 318);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(35, 13);
            this.lnkAbout.TabIndex = 5;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "About";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // dfsExportCsv
            // 
            this.dfsExportCsv.Filter = "Comma Separated Values (*.csv)|*.csv";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.tabGaussGraph);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Name = "MainWindow";
            this.Text = "GaussGraph";
            this.tabGaussGraph.ResumeLayout(false);
            this.tbpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.tbpGraph.ResumeLayout(false);
            this.pnlGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).EndInit();
            this.tbpCsv.ResumeLayout(false);
            this.tbpGVOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TabControl tabGaussGraph;
        private System.Windows.Forms.TabPage tbpGVOutput;
        private System.Windows.Forms.TabPage tbpCsv;
        private System.Windows.Forms.TabPage tbpData;
        private System.Windows.Forms.TabPage tbpGraph;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.OpenFileDialog dfoOpen;
        private System.Windows.Forms.SaveFileDialog dfsExportGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart chtGraph;
        private System.Windows.Forms.Button btnExportGraph;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.RichTextBox rtfGVOutput;
        private System.Windows.Forms.RichTextBox rtfCsv;
        private System.Windows.Forms.SaveFileDialog dfsExportCsv;
    }
}

