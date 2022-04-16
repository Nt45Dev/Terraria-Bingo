using System.Drawing;
namespace Randomizer_Bingo
{
    public partial class Sheet : Form
    {
        public Sheet()
        {
            InitializeComponent();
        }
        public bool B1bool;
        public bool B2bool;
        public bool B3bool;
        public bool B4bool;
        public bool B5bool;
        public bool I1bool;
        public bool I2bool;
        public bool I3bool;
        public bool I4bool;
        public bool I5bool;
        public bool N1bool;
        public bool N2bool;
        public bool N3bool;
        public bool N4bool;
        public bool N5bool;
        public bool G1bool;
        public bool G2bool;
        public bool G3bool;
        public bool G4bool;
        public bool G5bool;
        public bool O1bool;
        public bool O2bool;
        public bool O3bool;
        public bool O4bool;
        public bool O5bool;
        public int bingosamtcheck;
        public int bingoscount;
        
        private void Sheet_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"../../../Resources/Clipboard.png");



            B1.Text = Intro.B1string;
            B2.Text = Intro.B2string;
            B3.Text = Intro.B3string;
            B4.Text = Intro.B4string;
            B5.Text = Intro.B5string;

            I1.Text = Intro.I1string;
            I2.Text = Intro.I2string;
            I3.Text = Intro.I3string;
            I4.Text = Intro.I4string;
            I5.Text = Intro.I5string;

            N1.Text = Intro.N1string;
            N2.Text = Intro.N2string;
            N3.Text = Intro.N3string;
            N4.Text = Intro.N4string;
            N5.Text = Intro.N5string;

            G1.Text = Intro.G1string;
            G2.Text = Intro.G2string;
            G3.Text = Intro.G3string;
            G4.Text = Intro.G4string;
            G5.Text = Intro.G5string;

            O1.Text = Intro.O1string;
            O2.Text = Intro.O2string;
            O3.Text = Intro.O3string;
            O4.Text = Intro.O4string;
            O5.Text = Intro.O5string;
            



            if (Intro.freespace)
            {
                N3bool = true;
                N3.Enabled = false;
                N3.Text = "Free Space";
            }
            updatesheet();
        }

        public void updatesheet()
        {
            if (B1bool)
            {
                B1.BackColor = Intro.filledcolor;
                B1.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                B1.BackColor = Intro.unfilledcolor;
                B1.ForeColor = Intro.unfilledtextcolor;
            }
            if (B2bool)
            {
                B2.BackColor = Intro.filledcolor;
                B2.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                B2.BackColor = Intro.unfilledcolor;
                B2.ForeColor = Intro.unfilledtextcolor;
            }
            if (B3bool)
            {
                B3.BackColor = Intro.filledcolor;
                B3.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                B3.BackColor = Intro.unfilledcolor;
                B3.ForeColor = Intro.unfilledtextcolor;
            }
            if (B4bool)
            {
                B4.BackColor = Intro.filledcolor;
                B4.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                B4.BackColor = Intro.unfilledcolor;
                B4.ForeColor = Intro.unfilledtextcolor;
            }
            if (B5bool)
            {
                B5.BackColor = Intro.filledcolor;
                B5.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                B5.BackColor = Intro.unfilledcolor;
                B5.ForeColor = Intro.unfilledtextcolor;
            }


            if (I1bool)
            {
                I1.BackColor = Intro.filledcolor;
                I1.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                I1.BackColor = Intro.unfilledcolor;
                I1.ForeColor = Intro.unfilledtextcolor;
            }
            if (I2bool)
            {
                I2.BackColor = Intro.filledcolor;
                I2.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                I2.BackColor = Intro.unfilledcolor;
                I2.ForeColor = Intro.unfilledtextcolor;
            }
            if (I3bool)
            {
                I3.BackColor = Intro.filledcolor;
                I3.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                I3.BackColor = Intro.unfilledcolor;
                I3.ForeColor = Intro.unfilledtextcolor;
            }
            if (I4bool)
            {
                I4.BackColor = Intro.filledcolor;
                I4.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                I4.BackColor = Intro.unfilledcolor;
                I4.ForeColor = Intro.unfilledtextcolor;
            }
            if (I5bool)
            {
                I5.BackColor = Intro.filledcolor;
                I5.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                I5.BackColor = Intro.unfilledcolor;
                I5.ForeColor = Intro.unfilledtextcolor;
            }


            if (N1bool)
            {
                N1.BackColor = Intro.filledcolor;
                N1.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                N1.BackColor = Intro.unfilledcolor;
                N1.ForeColor = Intro.unfilledtextcolor;
            }
            if (N2bool)
            {
                N2.BackColor = Intro.filledcolor;
                N2.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                N2.BackColor = Intro.unfilledcolor;
                N2.ForeColor = Intro.unfilledtextcolor;
            }
            if (N3bool)
            {
                N3.BackColor = Intro.filledcolor;
                N3.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                N3.BackColor = Intro.unfilledcolor;
                N3.ForeColor = Intro.unfilledtextcolor;
            }
            if (N4bool)
            {
                N4.BackColor = Intro.filledcolor;
                N4.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                N4.BackColor = Intro.unfilledcolor;
                N4.ForeColor = Intro.unfilledtextcolor;
            }
            if (N5bool)
            {
                N5.BackColor = Intro.filledcolor;
                N5.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                N5.BackColor = Intro.unfilledcolor;
                N5.ForeColor = Intro.unfilledtextcolor;
            }

            if (G1bool)
            {
                G1.BackColor = Intro.filledcolor;
                G1.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                G1.BackColor = Intro.unfilledcolor;
                G1.ForeColor = Intro.unfilledtextcolor;
            }
            if (G2bool)
            {
                G2.BackColor = Intro.filledcolor;
                G2.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                G2.BackColor = Intro.unfilledcolor;
                G2.ForeColor = Intro.unfilledtextcolor;
            }
            if (G3bool)
            {
                G3.BackColor = Intro.filledcolor;
                G3.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                G3.BackColor = Intro.unfilledcolor;
                G3.ForeColor = Intro.unfilledtextcolor;
            }
            if (G4bool)
            {
                G4.BackColor = Intro.filledcolor;
                G4.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                G4.BackColor = Intro.unfilledcolor;
                G4.ForeColor = Intro.unfilledtextcolor;
            }
            if (G5bool)
            {
                G5.BackColor = Intro.filledcolor;
                G5.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                G5.BackColor = Intro.unfilledcolor;
                G5.ForeColor = Intro.unfilledtextcolor;
            }

            if (O1bool)
            {
                O1.BackColor = Intro.filledcolor;
                O1.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                O1.BackColor = Intro.unfilledcolor;
                O1.ForeColor = Intro.unfilledtextcolor;
            }
            if (O2bool)
            {
                O2.BackColor = Intro.filledcolor;
                O2.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                O2.BackColor = Intro.unfilledcolor;
                O2.ForeColor = Intro.unfilledtextcolor;
            }
            if (O3bool)
            {
                O3.BackColor = Intro.filledcolor;
                O3.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                O3.BackColor = Intro.unfilledcolor;
                O3.ForeColor = Intro.unfilledtextcolor;
            }
            if (O4bool)
            {
                O4.BackColor = Intro.filledcolor;
                O4.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                O4.BackColor = Intro.unfilledcolor;
                O4.ForeColor = Intro.unfilledtextcolor;
            }
            if (O5bool)
            {
                O5.BackColor = Intro.filledcolor;
                O5.ForeColor = Intro.filledtextcolor;
            }
            else
            {
                O5.BackColor = Intro.unfilledcolor;
                O5.ForeColor = Intro.unfilledtextcolor;
            }

            //Possible Bingos, add amount to counter.
            bingosamtcheck = Convert.ToInt32(Intro.bingosreq);
            bingoscount = 0;
            if (B1bool && B2bool && B3bool && B4bool && B5bool)
            {
                bingoscount++;
            }
            if (I1bool && I2bool && I3bool && I4bool && I5bool)
            {
                bingoscount++;
            }
            if (N1bool && N2bool && N3bool && N4bool && N5bool)
            {
                bingoscount++;
            }
            if (G1bool && G2bool && G3bool && G4bool && G5bool)
            {
                bingoscount++;
            }
            if (O1bool && O2bool && O3bool && O4bool && O5bool)
            {
                bingoscount++;
            }

            if (B1bool && I1bool && N1bool && G1bool && O1bool)
            {
                bingoscount++;
            }
            if (B2bool && I2bool && N2bool && G2bool && O2bool)
            {
                bingoscount++;
            }
            if (B3bool && I3bool && N3bool && G3bool && O3bool)
            {
                bingoscount++;
            }
            if (B4bool && I4bool && N4bool && G4bool && O4bool)
            {
                bingoscount++;
            }
            if (B5bool && I5bool && N5bool && G5bool && O5bool)
            {
                bingoscount++;
            }
            if (B1bool && I2bool && N3bool && G4bool && O5bool)
            {
                bingoscount++;
            }
            if (B5bool && I4bool && N3bool && G2bool && O1bool)
            {
                bingoscount++;
            }

            currentbingoslbl.Text = bingoscount.ToString();


            if (bingoscount >= bingosamtcheck)
                if (bingosamtcheck == 1)
                {
                    MessageBox.Show($"BINGO!");
                }

                else {
                MessageBox.Show($"BINGO! All {bingosamtcheck} required bingos have been completed!");
                }
        }
        private void B1_Click(object sender, EventArgs e)
        {
            
            if (B1bool)
            {
                B1bool = false;
            }
            else
            {
                B1bool = true;
            }

            updatesheet();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2bool)
            {
                B2bool = false;
            }
            else
            {
                B2bool = true;
            }

            updatesheet();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (B3bool)
            {
                B3bool = false;
            }
            else
            {
                B3bool = true;
            }

            updatesheet();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (B4bool)
            {
                B4bool = false;
            }
            else
            {
                B4bool = true;
            }

            updatesheet();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (B5bool)
            {
                B5bool = false;
            }
            else
            {
                B5bool = true;
            }

            updatesheet();
        }

        private void I1_Click(object sender, EventArgs e)
        {

            if (I1bool)
            {
                I1bool = false;
            }
            else
            {
                I1bool = true;
            }

            updatesheet();
        }

        private void I2_Click(object sender, EventArgs e)
        {
            if (I2bool)
            {
                I2bool = false;
            }
            else
            {
                I2bool = true;
            }

            updatesheet();
        }

        private void I3_Click(object sender, EventArgs e)
        {
            if (I3bool)
            {
                I3bool = false;
            }
            else
            {
                I3bool = true;
            }

            updatesheet();
        }

        private void I4_Click(object sender, EventArgs e)
        {
            if (I4bool)
            {
                I4bool = false;
            }
            else
            {
                I4bool = true;
            }

            updatesheet();
        }

        private void I5_Click(object sender, EventArgs e)
        {
            if (I5bool)
            {
                I5bool = false;
            }
            else
            {
                I5bool = true;
            }

            updatesheet();
        }

        private void N1_Click(object sender, EventArgs e)
        {

            if (N1bool)
            {
                N1bool = false;
            }
            else
            {
                N1bool = true;
            }

            updatesheet();
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (N2bool)
            {
                N2bool = false;
            }
            else
            {
                N2bool = true;
            }

            updatesheet();
        }

        private void N3_Click(object sender, EventArgs e)
        {
            if (N3bool)
            {
                N3bool = false;
            }
            else
            {
                N3bool = true;
            }
            if (Intro.freespace)
            {
                N3bool = true;
            }
            updatesheet();
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if (N4bool)
            {
                N4bool = false;
            }
            else
            {
                N4bool = true;
            }

            updatesheet();
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if (N5bool)
            {
                N5bool = false;
            }
            else
            {
                N5bool = true;
            }

            updatesheet();
        }

        private void G1_Click(object sender, EventArgs e)
        {

            if (G1bool)
            {
                G1bool = false;
            }
            else
            {
                G1bool = true;
            }

            updatesheet();
        }

        private void G2_Click(object sender, EventArgs e)
        {
            if (G2bool)
            {
                G2bool = false;
            }
            else
            {
                G2bool = true;
            }

            updatesheet();
        }

        private void G3_Click(object sender, EventArgs e)
        {
            if (G3bool)
            {
                G3bool = false;
            }
            else
            {
                G3bool = true;
            }

            updatesheet();
        }

        private void G4_Click(object sender, EventArgs e)
        {
            if (G4bool)
            {
                G4bool = false;
            }
            else
            {
                G4bool = true;
            }

            updatesheet();
        }

        private void G5_Click(object sender, EventArgs e)
        {
            if (G5bool)
            {
                G5bool = false;
            }
            else
            {
                G5bool = true;
            }

            updatesheet();
        }
        private void O1_Click(object sender, EventArgs e)
        {

            if (O1bool)
            {
                O1bool = false;
            }
            else
            {
                O1bool = true;
            }

            updatesheet();
        }

        private void O2_Click(object sender, EventArgs e)
        {
            if (O2bool)
            {
                O2bool = false;
            }
            else
            {
                O2bool = true;
            }

            updatesheet();
        }

        private void O3_Click(object sender, EventArgs e)
        {
            if (O3bool)
            {
                O3bool = false;
            }
            else
            {
                O3bool = true;
            }

            updatesheet();
        }

        private void O4_Click(object sender, EventArgs e)
        {
            if (O4bool)
            {
                O4bool = false;
            }
            else
            {
                O4bool = true;
            }

            updatesheet();
        }

        private void O5_Click(object sender, EventArgs e)
        {
            if (O5bool)
            {
                O5bool = false;
            }
            else
            {
                O5bool = true;
            }

            updatesheet();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Intro.sbseed.ToString());
        }
    }
}
