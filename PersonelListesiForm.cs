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
    public partial class PersonelListesiForm : Form
    {
        
        public PersonelListesiForm()
        {
            InitializeComponent();
            
            Main.pl = PersonnelList.Load("KIRIKKALE");
            if (Main.pl.pl.Count < 1 )
            { 
                if(MessageBox.Show("Personel listesi sistemden temin edilsin mi?", "Liste Yok", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Main.pl.getUserTitles();
            }

            int c = 0;
            foreach(Personnel p in Main.pl.pl)
            {
                ListViewItem lvi = new ListViewItem((c++).ToString());

                lvi.SubItems.Add(p.Name);
                lvi.SubItems.Add(p.Title);
                
                elvPl.Items.Add(lvi);
            }
        }
    }
}
