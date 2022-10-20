using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GorevYolluk
{
    public class Personnel
    {
        public string Name { get; set; } = "";

        public string UniName 
        {
            get 
            {
                return Name;
            }
        }

        public string Title { get; set; } = "";

    }

    public class Duty
    {
        public string Order { get; set; } = "";
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime End { get; set; } = DateTime.Now;
        public string Plaka { get; set; } = "";
        public string Driver { get; set; } = "";
        public string Where { get; set; } = "";
        public string Who { get; set; } = "";
        public string UniWho { get { return Who.ToUpper().RemoveDiacritics(); } }
        public int Km { get; set; } = 0;

        public string Title { get; set; } = "";
        public bool IsValid
        {
            get
            {
                if (Where.ToUpper().Contains("MERKEZ"))
                    return false;

                bool vt = false;

                string[] titles = { "PROGRAMCI", "TEKNİKER", "TEKNİSYEN", "MÜHENDİS", "MİMAR" };

                for (int i = 0; i < titles.Length; i++)
                {
                    if (Title.ToUpper().RemoveDiacritics().Contains(titles[i].ToUpper().RemoveDiacritics()))
                    {
                        vt = true;
                        break;
                    }
                }

                if (!vt)
                    return false;

                if (Driver == Who && Km > 0)
                {
                    return true;
                }

                if (((Start.Hour < 12 || (Start.Hour == 12 && Start.Minute == 0)) && End.Hour >= 13)
                    || (Start.Hour < 17 && (End.Hour > 17 || (End.Hour == 17 && End.Minute > 0))))
                {
                    if (!Plaka.Contains("X") && Km > 0)
                        return true;
                    if (Plaka.Contains("X"))
                        return true;
                }
                return false;
            }
        }


    }

    public class DutyList
    {
        public SortedList<string, List<Duty>> pd = new SortedList<string, List<Duty>>();
        public string fn = "";
        ISheet? sheet = null;
        IWorkbook? wb = null;


        public DutyList()
        {
        }
        public DutyList(string filename)
        {
            fn = filename;
            try
            {
                using (FileStream file = new FileStream(fn, FileMode.Open, FileAccess.Read))
                {
                    if (fn.ToLower().EndsWith("xls"))
                    {
                        wb = new HSSFWorkbook(file);
                    }
                    else
                    {
                        wb = new XSSFWorkbook(file);
                    }
                }

                sheet = wb.GetSheetAt(0);

                for (int i = 0; i < sheet.LastRowNum; i++)
                {
                    if (sheet.GetRow(i) == null) //null is when the row only contains empty cells 
                        continue;
                    if (sheet.GetRow(i).GetCell(1).ToString() == "" || sheet.GetRow(i).GetCell(1).ToString().Contains("Görevlendirme"))
                        continue;


                    AddDuties(i);
                    AddDriverDuty(i);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
        public void AddDriverDuty(int row)
        {
            Duty d = new Duty();

            try
            {

                d = new Duty();
                d.Driver = sheet.GetRow(row).GetCell(4).ToString().Trim().Replace("  ", " ") ?? "";   //sheet.Cells[row, 5].Value?.ToString().Trim().Replace("  ", " ") ?? "";
                d.Start = Convert.ToDateTime(sheet.GetRow(row).GetCell(9).ToString()
                    + " " + sheet.GetRow(row).GetCell(11).ToString(), new CultureInfo("tr-TR"));
                string bb = d.Start.Month.ToString();
                d.End = Convert.ToDateTime(sheet.GetRow(row).GetCell(12).ToString()
                    + " " + sheet.GetRow(row).GetCell(13).ToString(), new CultureInfo("tr-TR"));
                d.Km = Convert.ToInt32(sheet.GetRow(row).GetCell(17).ToString() ?? "0");
                d.Order = sheet.GetRow(row).GetCell(1).ToString() ?? "";
                d.Plaka = sheet.GetRow(row).GetCell(3).ToString() ?? "";
                d.Where = sheet.GetRow(row).GetCell(6).ToString() ?? "";
                d.Who = d.Driver;
                d.Title = getUserTitle(d.UniWho);

                if (!pd.ContainsKey(d.UniWho))
                    pd[d.UniWho] = new List<Duty>();

                Duty? dc = pd[d.UniWho].FirstOrDefault(dx => dx.Order == d.Order);
                if (dc != null)
                    return;

                pd[d.UniWho].Add(d);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                int stop = 1;
            }
        }


        public void AddDuties(int row)
        {
            Duty d = new Duty();
            try
            {
                string[] rw = (sheet.GetRow(row).GetCell(8)?.ToString() ?? "").Split(",");


                for (int x = 0; x < rw.Length; x++)
                {
                    if (rw[x].Length == 0)
                        continue;
                    d = new Duty();
                    d.Driver = sheet.GetRow(row).GetCell(4).ToString().Trim().Replace("  ", " ") ?? "";


                    d.Start = Convert.ToDateTime(sheet.GetRow(row).GetCell(9).ToString()
                        + " "
                        + sheet.GetRow(row).GetCell(11).ToString(), new CultureInfo("tr-TR"));
                    string bb = d.Start.Month.ToString();
                    d.End = Convert.ToDateTime(sheet.GetRow(row).GetCell(12).ToString()
                        + " "
                        + sheet.GetRow(row).GetCell(13).ToString(), new CultureInfo("tr-TR"));

                    d.Km = Convert.ToInt32(sheet.GetRow(row).GetCell(17).ToString() ?? "0");

                    d.Order = sheet.GetRow(row).GetCell(1).ToString() ?? "";
                    d.Plaka = sheet.GetRow(row).GetCell(3).ToString() ?? "";
                    d.Where = sheet.GetRow(row).GetCell(6).ToString() ?? "";
                    d.Who = rw[x].Split("-")[0].Trim().Replace("  ", " ");
                    d.Title = getUserTitle(d.UniWho);

                    if (!pd.ContainsKey(d.UniWho))
                        pd[d.UniWho] = new List<Duty>();

                    pd[d.UniWho].Add(d);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                int stop = 1;
            }
            Debug.WriteLine("Duty:" + d.Order);
        }
        public string getUserTitle(string uniwho)
        {
            return Main.pl[uniwho] ?? "";
        }
    }

    public static class LevenshteinDistance
    {
        /// <summary>
        ///     Calculate the difference between 2 strings using the Levenshtein distance algorithm
        /// </summary>
        /// <param name="source1">First string</param>
        /// <param name="source2">Second string</param>
        /// <returns></returns>
        public static int Calculate(string source1, string source2) //O(n*m)
        {
            var source1Length = source1.Length;
            var source2Length = source2.Length;

            var matrix = new int[source1Length + 1, source2Length + 1];

            // First calculation, if one entry is empty return full length
            if (source1Length == 0)
                return source2Length;

            if (source2Length == 0)
                return source1Length;

            // Initialization of matrix with row size source1Length and columns size source2Length
            for (var i = 0; i <= source1Length; matrix[i, 0] = i++) { }
            for (var j = 0; j <= source2Length; matrix[0, j] = j++) { }

            // Calculate rows and collumns distances
            for (var i = 1; i <= source1Length; i++)
            {
                for (var j = 1; j <= source2Length; j++)
                {
                    var cost = (source2[j - 1] == source1[i - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                        matrix[i - 1, j - 1] + cost);
                }
            }
            // return result
            return matrix[source1Length, source2Length];
        }
    }
    public static class MyExtensions
    {
        public static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString.EnumerateRunes())
            {
                var unicodeCategory = Rune.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

    }
    public class PersonnelList
    {
        public string City { get; set; }

        //public SortedDictionary<string, string> personnel { get; set; } = new SortedDictionary<string, string>();
        public List<Personnel> pl { get; set; } = new List<Personnel>();
        
        public PersonnelList(string city)
        {
            City = city;
        }

        public void getUserTitles()
        {
            try
            {
                DirectoryContext dc = new DirectoryContext(DirectoryContextType.Domain, "csb.local", "akin.demirtug", "Sandalye11");
                DirectorySearcher adSearcher = new DirectorySearcher(Domain.GetDomain(dc).GetDirectoryEntry());

                adSearcher.Filter = "(&(objectClass=user)(objectCategory=person)(company=" + City + "*))";
                adSearcher.PropertiesToLoad.AddRange(new string[] { "countrycode", "title", "company", "department", "displayname" });

                SearchResultCollection iResult = adSearcher.FindAll();

                foreach (SearchResult result in iResult)
                {
                    Personnel p = new Personnel();

                    p.Name = result.Properties["displayname"][0].ToString() ?? "";
                    var ttl = result.Properties["title"];
                    p.Title = ttl.Count > 0 ? ttl[0].ToString() : "";
                    pl.Add(p);
                }
                adSearcher.Dispose();
                FlushAsJson();
            }
            catch (Exception)
            {
            }

            //PrincipalContext pc = new PrincipalContext(ContextType.Domain, "csb.local", "akin.demirtug", "Sandalye11");

        }

        /// <summary>
        /// Get Title for a specific name
        /// </summary>
        /// <param name="Name">Personnel's name</param>
        /// <returns></returns>
        public string? this[string Name]
        {
            get
            {
                Personnel? p = pl.FirstOrDefault(i => i.Name.ToUpper().RemoveDiacritics() == Name);
                if (p != null)
                    return p.Title;

                p = pl.FirstOrDefault(i => LevenshteinDistance.Calculate(i.Name.ToUpper().RemoveDiacritics(), Name) < 2);

                if (p != null)
                    return p.Title;

                return "";
            }
        }

        public void AddPersonnel(string Name, string Title)
        {
            Personnel p = new Personnel();
            p.Name = Name;
            p.Title = Title;
            pl.Add(p);
        }

        public void FlushAsJson()
        {
            string path = "./data/";


            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize<PersonnelList>(this, options);

            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path) ?? "");
            File.WriteAllText(path + "personnel_data.json", json);
        }
        public static PersonnelList Load(string city)
        {
            string dp = "./data/personnel_data.json";
            if (File.Exists(dp))
                return JsonSerializer.Deserialize<PersonnelList>(File.ReadAllText(dp))!;
                
            return new PersonnelList(city);
        }
    }
}
