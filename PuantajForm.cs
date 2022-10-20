using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace GorevYolluk
{
    public partial class PuantajForm : Form
    {
        bool pfile = false;
        bool gfile = false;
        DutyList dl = new DutyList();
        public PuantajForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            lbl_puantajFile.Text = ofd.FileName;
            pfile = true;
            checkReady();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            lbl_gorev.Text = ofd.FileName;
            gfile = true;
            checkReady();
        }

        public void checkReady()
        {
            btn_hazırla.Enabled = (gfile && pfile);
        }

        private void btn_hazırla_Click(object sender, EventArgs e)
        {
            try
            {
				dl = new DutyList(lbl_gorev.Text);
				IWorkbook? wb = null;
				using (FileStream file = new FileStream(lbl_puantajFile.Text, FileMode.Open, FileAccess.Read))
				{
					if (lbl_puantajFile.Text.ToLower().EndsWith("xls"))
					{
						wb = new HSSFWorkbook(file);
					}
					else
					{
						wb = new XSSFWorkbook(file);
					}
				}
				ISheet sheet = wb.GetSheet("ŞOFÖR");

				for (int i = 8; i < sheet.LastRowNum; i += 3)
				{
					if (sheet.GetRow(i) == null || sheet.GetRow(i).GetCell(0) == null)
						continue;
					if (sheet.GetRow(i).GetCell(0).ToString() == "" )
						continue;
					if (sheet.GetRow(i).GetCell(0).ToString() == "Puantörün")
						break;


					string personel = sheet.GetRow(i).GetCell(0).ToString() ?? "";
					List<Duty> d = dl.pd.ContainsKey(personel.ToUpper().RemoveDiacritics()) ? dl.pd[personel.ToUpper().RemoveDiacritics()] : new List<Duty>();
					if (d.Count < 1)
						continue;
					for (int x = 0; x < d.Count; x++)
					{
						if (!d[x].IsValid)
							continue;

						string v = sheet.GetRow(i + 1).GetCell(d[x].Start.Day + 2).ToString() ?? "";

						if (v != "" && v != "X")
						{
							rtb_out.AppendText(d[x].Who + " için: " + d[x].Start.ToString() + " gün değeri ->" + v + "\r\n");
							continue;
						}
						sheet.GetRow(i + 1).GetCell(d[x].Start.Day + 2).SetCellValue("X");
					}
				}
				using (var f = new FileStream(Path.GetDirectoryName(lbl_puantajFile.Text) + "\\"
					+ Path.GetFileNameWithoutExtension(lbl_puantajFile.Text) + "-HAZIR.xlsx", FileMode.Create, FileAccess.ReadWrite))
				{
					wb.Write(f);
					f.Close();
				}
				MessageBox.Show("tamamdır.");
			}
			catch (Exception xe)
            {
				int stop = 1;
                
            }

        }
    }
}
