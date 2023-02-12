// See https://aka.ms/new-console-template for more information
using System.Text;

string ddActive = "-1";
string txtWorkcell = "HP";
string txtStationName = "Station1";

var active = ddActive == "-1" ? "Active" : ddActive;
string workcell = string.Empty;
string station = string.Empty;

StringBuilder query = new StringBuilder("Select * FROM vw_Station WHERE ");

query.Append("Active = @Active");
if (txtWorkcell != string.Empty)
{
    query.Append(" AND Workcell Like @Workcell");
    workcell = string.Format("'%{0}%'", txtWorkcell);
}

if (txtStationName != string.Empty)
{
    query.Append(" AND StationName Like @StationName");
    station = string.Format("'%{0}%'", txtStationName);
}

//SqlDataSource1.SelectCommand = query.ToString();

//SqlDataSource1.SelectParameters.Add("Active", active);
Console.WriteLine(query);

if (txtWorkcell != string.Empty)
    Console.WriteLine(workcell);
if (txtStationName != string.Empty)
    Console.WriteLine(station);

Console.WriteLine("Hello, World!");
