using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WEBPtoJPG
{
    public class Settings
    {
        [PropertyInfo(Category = "All")]
        public bool DeleteSources { get; set; } = true;

        [PropertyInfo(Category = "All")]
        public int JPEGQuality { get; set; } = 85;


        string defPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "settings.txt");

        class PropInfo { public string Category; public string Name; public string Value; };

        List<PropInfo> getPropInfoList(bool sort)
        {
            Type t = this.GetType();
            var props = t.GetProperties();

            List<PropInfo> pi = new List<PropInfo>();
            foreach (var p in props) pi.Add(new PropInfo() { Name = p.Name, Value = p.GetValue(this, null).ToString(), Category = p.GetCustomAttributes(true).OfType<PropertyInfoAttribute>().FirstOrDefault()?.Category });
            if (sort) pi.Sort((a, b) => string.Compare(a.Category + a.Name, b.Category + b.Name));

            return pi;
        }


        public void Save() => Save(defPath);
        public void Save(string filename)
        {
            var pi = getPropInfoList(true);
            List<string> lines = new List<string>();

            string currentCatName = null;
            foreach (var p in pi)
            {
                if (p.Category != currentCatName)
                {
                    if (lines.Count > 0) lines.Add("");
                    lines.Add($"[{p.Category}]");
                    currentCatName = p.Category;
                }
                lines.Add($"{p.Name}={p.Value}");
            }

            File.WriteAllLines(filename, lines);
        }


        List<string> parseErrors = new List<string>();
        public List<string> GetParseErrors() => parseErrors;
        public int GetParseErrorsCount() => parseErrors.Count;

        public void Load() => Load(defPath);
        public void Load(string filename)
        {
            if (!File.Exists(filename))
            {
                parseErrors.Add($"No settings file {filename}, default one is created");
                Save();
                return;
            }
            var lines = File.ReadAllLines(filename);
            Load(lines);
        }
        public void Load(string[] lines)
        {
            parseErrors.Clear();
            Type t = this.GetType();
            var props = t.GetProperties();
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("["))
                {
                    string tname = Settings.GetBefore(line, '=');
                    string tvalue = Settings.GetAfter(line, '=');
                    var p = props.FirstOrDefault(pi => pi.Name == tname);
                    if (p != null)
                    {
                        Type pt = p.PropertyType;
                        object v = null;
                        try
                        {
                            if (pt == typeof(bool)) v = bool.Parse(tvalue);
                            else if (pt == typeof(int)) v = int.Parse(tvalue);
                            else if (pt == typeof(double)) v = double.Parse(tvalue);
                            else if (pt == typeof(string)) v = tvalue;
                            else parseErrors.Add($"No parser for {pt.Name}");

                            if (v != null) p.SetValue(this, v, null);
                        }
                        catch { parseErrors.Add($"Parsing failed for {tname}={tvalue}"); }
                    }
                    else parseErrors.Add($"No property in object with name {tname}");
                }
            }
        }

        public static string GetBefore(string s, char ch)
        {
            int pos = s.IndexOf(ch);
            if (pos >= 0) return s.Substring(0, pos);
            return s;
        }

        public static string GetAfter(string s, char ch)
        {
            int pos = s.IndexOf(ch);
            if (pos >= 0) return s.Substring(pos + 1);
            return "";
        }

        public void StartProcess()
        {
            System.Diagnostics.Process.Start(defPath);
        }
    }

    public class PropertyInfoAttribute : Attribute
    {
        public string Category { get; set; }
    }
}
