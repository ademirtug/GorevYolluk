using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorevYolluk
{
    public partial class SeyyarForm : Form
    {
        DutyList? dl;
        public SeyyarForm(string fn)
        {
            InitializeComponent();


            lv_gorevler.Items.Clear();
            tv_personel.Nodes.Clear();

            try
            {
                dl = new DutyList(fn);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            var tvp = tv_personel.Nodes.Add("Personel");
            foreach (var xe in dl.pd.Keys)
            {
                tvp.Nodes.Add(dl.pd[xe][0].UniWho, dl.pd[xe][0].Who + $"({dl.pd[xe][0].Title})");
            }

            tvp.Expand();

        }

        private void tv_personel_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Personel")
                return;

            string p = e.Node.Name;
            lv_gorevler.Items.Clear();

            var xe = dl.pd[p];

            int c = 1;
            HashSet<DateTime> gn = new HashSet<DateTime>();
            foreach (Duty d in xe)
            {
                if (d.IsValid)
                    gn.Add(d.Start.Date);

                ListViewItem lvi = new ListViewItem((c++).ToString());

                lvi.SubItems.Add(d.Order);
                lvi.SubItems.Add(d.Where);
                lvi.SubItems.Add(d.Start.ToString());
                lvi.SubItems.Add(d.End.ToString());
                lvi.Checked = d.IsValid;

                lv_gorevler.Items.Add(lvi);
            }
            this.Text = "Seyyar - " + e.Node.Text + $"({gn.Count})";
            lv_gorevler.Show();
        }
    }
}
