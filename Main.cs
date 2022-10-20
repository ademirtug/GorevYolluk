namespace GorevYolluk
{
    public partial class Main : Form
    {
        public static PersonnelList? pl = new PersonnelList("KIRIKKALE");

        public Main()
        {
            InitializeComponent();

            Main.pl = PersonnelList.Load("KIRIKKALE");
            if (Main.pl.pl.Count < 1)
            {
                if (MessageBox.Show("Personel listesi sistemden temin edilsin mi?", "Liste Yok", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Main.pl.getUserTitles();
            }
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListesiForm pl = new PersonelListesiForm();
            pl.MdiParent = this;
            pl.Show();
        }

        private void seyyarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            SeyyarForm sf = new SeyyarForm(ofd.FileName);
            sf.MdiParent = this;
            sf.Show();
        }

        private void puantajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuantajForm pt = new PuantajForm();
            pt.MdiParent = this;
            pt.Show();
        }
    }
}