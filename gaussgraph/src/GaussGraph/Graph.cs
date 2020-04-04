using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Graph
{
    string labelMatcher = @"\# (?<label>[\w\W\s]*):\s*(?<value>[\w\W\s]*)";
    string columnThreeMatcher = @"\#\s*X\s*Y\s*(?<label>[\w\W\s]*)";
    // If problems occur, original expressions ended with \r

    protected StringBuilder _description;
    protected string _xaxis;
    protected string _yaxis;
    protected string _columnThree;
    protected DataTable _dataPoints;

    public string Description
    {
        get { return _description.ToString(); }
    }

    public string XAxis
    {
        get { return _xaxis; }
        set { _xaxis = value; }
    }

    public string YAxis
    {
        get { return _yaxis; }
        set { _yaxis = value; }
    }

    public string ColumnThree
    {
        get { return _columnThree; }
        set { _columnThree = value; }
    }

    public DataTable DataPoints
    {
        get { return _dataPoints; }
        set { _dataPoints = value; }
    }

    public void SetGraph(string gvoutput)
    {
        _description = new StringBuilder();
        this.DataPoints = new DataTable();
        
        bool columnsFound = false;
        int  columns = 0;

        string[] lines = gvoutput.Split('\n');
        string line = null;

        for (int i = 0; i < lines.Length; i++)
        {
            // Extract Graph Information
            if (lines[i].Contains('\r')) line = lines[i].Replace('\r', ' ').Trim();
            else line = lines[i];

            if (line.StartsWith("#"))
            {
                if (Regex.IsMatch(line, labelMatcher))
                {
                    MatchCollection m = Regex.Matches(line, labelMatcher, RegexOptions.Singleline);
                    foreach (Match match in m)
                    {
                        switch (match.Groups[1].ToString())
                        {
                            case "X-Axis":
                                this.XAxis = match.Groups[2].ToString();
                                break;
                            case "Y-Axis":
                                this.YAxis = match.Groups[2].ToString();
                                break;
                            case "Reference":
                                if (_description.Length != 0) _description.Append("; ");
                                _description.Append("Reference: " + match.Groups[2].ToString());
                                break;
                            case "Reference shielding":
                                if (_description.Length != 0) _description.Append("; ");
                                _description.Append("Reference Shielding: " + match.Groups[2].ToString());
                                break;
                            case "NMR Degeneracy Tolerance":
                                if (_description.Length != 0) _description.Append("; ");
                                _description.Append("Degeneracy Tolerance: " + match.Groups[2].ToString());
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (Regex.IsMatch(line, columnThreeMatcher))
                {
                    Match match = Regex.Match(line, columnThreeMatcher);
                    // NMR Specific
                    if (match.Groups[1].ToString() == "Degeneracy") this.ColumnThree = "Total Degeneracy";
                    else this.ColumnThree = match.Groups[1].ToString();

                }
                else
                {
                    _description.Append(line.Replace('#', ' ').Trim());
                }
            }
            else if (line != "")
            {
                string[] row = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (!columnsFound)
                {
                    columns = row.GetLength(0);
                    columnsFound = true;
                    if (columns == 4) this.DataPoints.Columns.Add("Label");
                    this.DataPoints.Columns.Add(this.XAxis);
                    this.DataPoints.Columns.Add(this.YAxis);
                    if (columns >= 3) this.DataPoints.Columns.Add(this.ColumnThree);
                }
                if (columns == 4) this.DataPoints.Rows.Add(row[0], double.Parse(row[1]), double.Parse(row[2]), double.Parse(row[3]));
                else if (columns == 3) this.DataPoints.Rows.Add(double.Parse(row[0]), double.Parse(row[1]), double.Parse(row[2]));
                else this.DataPoints.Rows.Add(double.Parse(row[0]), double.Parse(row[1]));
            }
        }
    }
        
    public string ToCsv()
    {
        StringBuilder csv = new StringBuilder();
        csv.Append(this.Description + "\n");
        if (this.DataPoints.Columns.Count == 4) csv.Append("Label,");
        csv.Append(this.XAxis + "," + this.YAxis);
        if (this.DataPoints.Columns.Count >= 3) csv.Append("," + this.ColumnThree);
        csv.Append("\n");
        foreach (DataRow row in this.DataPoints.Rows)
        {
            if (this.DataPoints.Columns.Count == 4)
                csv.Append(row[0].ToString() + "," + row[1].ToString() + "," + row[2].ToString() + "," + row[3].ToString() + "\n");
            else if (this.DataPoints.Columns.Count == 3)
                csv.Append(row[0].ToString() + "," + row[1].ToString() + "," + row[2].ToString() + "\n");
            else
                csv.Append(row[0].ToString() + "," + row[1].ToString() + "\n");
        }
        return csv.ToString();
    }
}
