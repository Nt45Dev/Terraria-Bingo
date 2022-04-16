using System.Data;

namespace Randomizer_Bingo
{
    public partial class tableform : Form
    {
        public tableform()
        {
            InitializeComponent();
        }

        private void tableform_Load(object sender, EventArgs e)
        {
            DataTable taskdata = Intro.possibletasks;
            dgv.DataSource = taskdata;
            dgv.Show();
        }
    }
}
