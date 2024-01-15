using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.CodeDom;
using System.Text;


namespace Randomizer_Bingo
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        public static Color filledcolor;
        public static Color unfilledcolor;
        public static Color filledtextcolor;
        public static Color unfilledtextcolor;
        public static DataTable taskdata = new DataTable();
        public static DataTable entrydata = new DataTable();
        public static DataTable possibletasks = new DataTable();
        public static DataTable temptable = new DataTable();
        public DataTable selectedtable = new DataTable();
        public DataRow randrow;
        public DataRow temprow;
        public static string seed;
        public int id;
        public int idtask;
        public int taskrandnum;
        public int r2;
        public static bool blackout;
        public static decimal bingosreq;
        public static bool prehardmode;
        public static bool hardmode;
        public static bool multiplayer;
        public static bool melee;
        public static bool ranger;
        public static bool mage;
        public static bool summoner;
        public static bool crimson;
        public static bool corruption;
        public static bool expert;
        public static bool freespace;
        public static string B1string;
        public static string B2string;
        public static string B3string;
        public static string B4string;
        public static string B5string;
        public static string I1string;
        public static string I2string;
        public static string I3string;
        public static string I4string;
        public static string I5string;
        public static string N1string;
        public static string N2string;
        public static string N3string;
        public static string N4string;
        public static string N5string;
        public static string G1string;
        public static string G2string;
        public static string G3string;
        public static string G4string;
        public static string G5string;
        public static string O1string;
        public static string O2string;
        public static string O3string;
        public static string O4string;
        public static string O5string;
        public int killcount;
        public string taskmin = new string("");
        public string taskmax = new string("");
        public string selectstring;
        public StringBuilder sbmin = new StringBuilder();
        public StringBuilder sbmax = new StringBuilder();
        public StringBuilder objpicker = new StringBuilder();
        public StringBuilder comp = new StringBuilder();
        public StringBuilder sbfile = new StringBuilder();
        public Random random = new Random();
        public Random randomtemp = new Random();
        public ArrayList al = new ArrayList();
        public string stringvar;
        public int randrowint;




        public void tasktable()
        {

            if (taskdata.Columns.Count == 0)
            {
                taskdata.Columns.Add("TaskID");
                taskdata.Columns.Add("TaskName");
                taskdata.Columns.Add("Item");
                taskdata.Columns.Add("Prehardmode");
                taskdata.Columns.Add("Hardmode");
                taskdata.Columns.Add("Armor");
                taskdata.Columns.Add("Enemy");
                taskdata.Columns.Add("Rare");
                taskdata.Columns.Add("Boss");
                taskdata.Columns.Add("NPC");
                taskdata.Columns.Add("Event");
                taskdata.Columns.Add("Easy");
                taskdata.Columns.Add("Medium");
                taskdata.Columns.Add("Hard");
                taskdata.Columns.Add("Insane");
                taskdata.Columns.Add("Crimson");
                taskdata.Columns.Add("Corruption");
                taskdata.Columns.Add("Melee");
                taskdata.Columns.Add("Ranged");
                taskdata.Columns.Add("Mage");
                taskdata.Columns.Add("Summoner");
                taskdata.Columns.Add("Passive");
                taskdata.Columns.Add("Fail");
                taskdata.Columns.Add("Team");

            }
            if (taskdata.Rows.Count == 0)
            {

                foreach (string objective in File.ReadLines(@"../../../Resources/objectivelist.txt"))
                {
                    id++;
                    string newobj = objective;
                    bool Item = false;
                    bool Prehardmode = false;
                    bool Hardmode = false;
                    bool Armor = false;
                    bool Enemy = false;
                    bool Rare = false;
                    bool Boss = false;
                    bool NPC = false;
                    bool Event = false;
                    bool Easy = false;
                    bool Medium = false;
                    bool Hard = false;
                    bool Insane = false;
                    bool Crimson = false;
                    bool Corruption = false;
                    bool Melee = false;
                    bool Ranged = false;
                    bool Mage = false;
                    bool Summoner = false;
                    bool Passive = false;
                    bool Fail = false;
                    bool Team = false;
                    if (newobj.Length > 0)

                    {

                        if (newobj.Contains("-item"))
                        {
                            Item = true;
                            newobj = newobj.Replace("-item", "");
                        }
                        if (newobj.Contains("-prehm"))
                        {
                            Prehardmode = true;
                            newobj = newobj.Replace("-prehm", "");
                        }
                        if (newobj.Contains("-hm"))
                        {
                            Hardmode = true;
                            newobj = newobj.Replace("-hm", "");
                        }
                        if (newobj.Contains("-armor"))
                        {
                            Armor = true;
                            newobj = newobj.Replace("-armor", "");
                        }
                        if (newobj.Contains("-enemy"))
                        {
                            Enemy = true;
                            newobj = newobj.Replace("-enemy", "");
                        }
                        if (newobj.Contains("-rare"))
                        {
                            Rare = true;
                            newobj = newobj.Replace("-rare", "");
                        }
                        if (newobj.Contains("-boss"))
                        {
                            Boss = true;
                            newobj = newobj.Replace("-boss", "");
                        }
                        if (newobj.Contains("-npc"))
                        {
                            NPC = true;
                            newobj = newobj.Replace("-npc", "");
                        }
                        if (newobj.Contains("-event"))
                        {
                            Event = true;
                            newobj = newobj.Replace("-event", "");
                        }
                        if (newobj.Contains("-easy"))
                        {
                            Easy = true;
                            newobj = newobj.Replace("-easy", "");
                        }
                        if (newobj.Contains("-medium"))
                        {
                            Medium = true;
                            newobj = newobj.Replace("-medium", "");
                        }
                        if (newobj.Contains("-hard"))
                        {
                            Hard = true;
                            newobj = newobj.Replace("-hard", "");
                        }
                        if (newobj.Contains("-insane"))
                        {
                            Insane = true;
                            newobj = newobj.Replace("-insane", "");
                        }
                        if (newobj.Contains("-crim"))
                        {
                            Crimson = true;
                            newobj = newobj.Replace("-crim", "");
                        }
                        if (newobj.Contains("-cor"))
                        {
                            Corruption = true;
                            newobj = newobj.Replace("-cor", "");
                        }
                        if (newobj.Contains("-melee"))
                        {
                            Melee = true;
                            newobj = newobj.Replace("-melee", "");
                        }
                        if (newobj.Contains("-ranged"))
                        {
                            Ranged = true;
                            newobj = newobj.Replace("-ranged", "");
                        }
                        if (newobj.Contains("-mage"))
                        {
                            Mage = true;
                            newobj = newobj.Replace("-mage", "");
                        }
                        if (newobj.Contains("-summoner"))
                        {
                            Summoner = true;
                            newobj = newobj.Replace("-summoner", "");
                        }
                        if (newobj.Contains("-passive"))
                        {
                            Passive = true;
                            newobj = newobj.Replace("-passive", "");
                        }
                        if (newobj.Contains("-fail"))
                        {
                            Fail = true;
                            newobj = newobj.Replace("-fail", "");
                        }
                        if (newobj.Contains("-team"))
                        {
                            Team = true;
                            newobj = newobj.Replace("-team", "");
                        }
                        newobj = newobj.TrimEnd();



                        taskdata.Rows.Add(id, newobj, Convert.ToInt32(Item), Convert.ToInt32(Prehardmode), Convert.ToInt32(Hardmode), Convert.ToInt32(Armor), Convert.ToInt32(Enemy), Convert.ToInt32(Rare), Convert.ToInt32(Boss), Convert.ToInt32(NPC), Convert.ToInt32(Event),
                            Convert.ToInt32(Easy), Convert.ToInt32(Medium), Convert.ToInt32(Hard), Convert.ToInt32(Insane), Convert.ToInt32(Crimson), Convert.ToInt32(Corruption), Convert.ToInt32(Melee), Convert.ToInt32(Ranged), Convert.ToInt32(Mage),
                            Convert.ToInt32(Summoner), Convert.ToInt32(Passive), Convert.ToInt32(Fail), Convert.ToInt32(Team));
                    }
                    else
                    {
                        id--;
                    }

                }
            }


        }
        private void filledcolorbtn_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                filledcolor = colorDialog1.Color;
                filledcolorbtn.BackColor = filledcolor;
                filledcolorbtn.Text = "";
                checkedtxtcolorbtn.BackColor = filledcolor;
            }
        }

        private void unfilledcolorbtn_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                unfilledcolor = colorDialog1.Color;
                unfilledcolorbtn.BackColor = unfilledcolor;
                unfilledcolorbtn.Text = "";
                uncheckedtxtcolorbtn.BackColor = unfilledcolor;
            }
        }

        private void checkedtxtcolorbtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                filledtextcolor = colorDialog1.Color;
                checkedtxtcolorbtn.Text = "Sample";
                checkedtxtcolorbtn.ForeColor = filledtextcolor;
            }
        }

        private void uncheckedtxtcolorbtn_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                unfilledtextcolor = colorDialog1.Color;
                uncheckedtxtcolorbtn.Text = "Sample";
                uncheckedtxtcolorbtn.ForeColor = unfilledtextcolor;
            }
        }




        private void blackoutchk_CheckedChanged(object sender, EventArgs e)
        {
            if (blackoutchk.Checked)
            {
                bingochk.Checked = false;
            }
            else
            {

            }
        }

        private void bingochk_CheckedChanged(object sender, EventArgs e)
        {
            if (bingochk.Checked)
            {
                blackoutchk.Checked = false;
                bingoamt.Show();
            }
            else
            {
                bingoamt.Hide();
            }
        }

        public void finishintrobtn_Click(object sender, EventArgs e)
        {
            if (seedtxtbx.Text != "")
            {
                seed = seedtxtbx.Text;
                 if (int.TryParse(seed, out int localseed)){
                    localseed.ToString();
                    random = new Random(localseed);
                    randomtemp = new Random(localseed);
                 }
            }
            else
            {
                 Random randomseed = new Random();
                 seed = randomseed.Next().ToString();   
                 random = new Random(int.Parse(seed));
                 randomtemp = new Random(int.Parse(seed));
            }

            if (!(bingochk.Checked | blackoutchk.Checked) | !(prehardmodechk.Checked | hardmodechk.Checked) | !(crimsonchk.Checked | corruptionchk.Checked))
            {
                MessageBox.Show("Invalid settings. Please select a Bingo Type (Bingo or Blackout) and/or make sure one world evil or one both Pre-Hardmode and Hardmode are selected.");
            }
            else
            {
                tasktable();


                //Sets values based on user defined settings
                if (prehardmodechk.Checked)
                {
                    prehardmode = true;
                }
                if (hardmodechk.Checked)
                {
                    hardmode = true;
                }
                if (multiplayerchk.Checked)
                {
                    multiplayer = true;
                }
                if (!(meleechk.Checked | rangerchk.Checked | magechk.Checked | summonerchk.Checked))
                {
                    melee = true;
                    ranger = true;
                    mage = true;
                    summoner = true;
                }
                else
                {
                    if (meleechk.Checked)
                    {
                        melee = true;
                    }
                    if (rangerchk.Checked)
                    {
                        ranger = true;
                    }
                    if (magechk.Checked)
                    {
                        mage = true;
                    }
                    if (summonerchk.Checked)
                    {
                        summoner = true;
                    }
                }
                if (crimsonchk.Checked)
                {
                    crimson = true;
                }
                if (corruptionchk.Checked)
                {
                    corruption = true;
                }

                if (filledcolor.IsEmpty)
                {
                    filledcolor = SystemColors.ControlDark;
                }
                if (unfilledcolor.IsEmpty)
                {
                    unfilledcolor = SystemColors.Control;
                }
                if (filledtextcolor.IsEmpty)
                {
                    filledtextcolor = SystemColors.ControlLightLight;
                }

                if (unfilledtextcolor.IsEmpty)
                {
                    unfilledtextcolor = SystemColors.ControlDarkDark;
                }




                //After checks, generate squares.

                //Build Table below
                if (!(entrydata.Rows.Count > 0))
                {
                    entrydata.Columns.Add("TaskID");
                    entrydata.Columns.Add("TaskName");
                    entrydata.Columns.Add("Item");
                    entrydata.Columns.Add("Prehardmode");
                    entrydata.Columns.Add("Hardmode");
                    entrydata.Columns.Add("Armor");
                    entrydata.Columns.Add("Enemy");
                    entrydata.Columns.Add("Rare");
                    entrydata.Columns.Add("Boss");
                    entrydata.Columns.Add("NPC");
                    entrydata.Columns.Add("Event");
                    entrydata.Columns.Add("Easy");
                    entrydata.Columns.Add("Medium");
                    entrydata.Columns.Add("Hard");
                    entrydata.Columns.Add("Insane");
                    entrydata.Columns.Add("Crimson");
                    entrydata.Columns.Add("Corruption");
                    entrydata.Columns.Add("Melee");
                    entrydata.Columns.Add("Ranged");
                    entrydata.Columns.Add("Mage");
                    entrydata.Columns.Add("Summoner");
                    entrydata.Columns.Add("Passive");
                    entrydata.Columns.Add("Fail");
                    entrydata.Columns.Add("Team");
                    entrydata.Columns.Add("Expert");
                    entrydata.Columns.Add("Num");
                }
                entrydata.Rows.Clear();
                //Rebuild fulltasks.txt file based on the contents of the other files for each category.
                sbfile.Clear();
                File.Delete(@"../../../Resources/fulltasks.txt");
                foreach (string entry in File.ReadAllLines(@"../../../Resources/enemylist.txt"))
                {
                    sbfile.AppendLine(entry);


                }
                sbfile.AppendLine();
                foreach (string entry in File.ReadAllLines(@"../../../Resources/itemlist.txt"))
                {
                    sbfile.AppendLine(entry);


                }
                idtask = 0;
                File.AppendAllText(@"../../../Resources/fulltasks.txt", sbfile.ToString());
                foreach (string task in File.ReadLines(@"../../../Resources/fulltasks.txt"))
                {
                    idtask++;
                    string newtask = task;
                    bool Item = false;
                    bool Prehardmode = false;
                    bool Hardmode = false;
                    bool Armor = false;
                    bool Enemy = false;
                    bool Rare = false;
                    bool Boss = false;
                    bool NPC = false;
                    bool Event = false;
                    bool Easy = false;
                    bool Medium = false;
                    bool Hard = false;
                    bool Insane = false;
                    bool Crimson = false;
                    bool Corruption = false;
                    bool Melee = false;
                    bool Ranged = false;
                    bool Mage = false;
                    bool Summoner = false;
                    bool Passive = false;
                    bool Fail = false;
                    bool Expert = false;
                    bool Team = false;
                    if (newtask.Length > 0)
                    {
                        if (newtask.Contains("-item"))
                        {
                            Item = true;
                            newtask = newtask.Replace("-item", "");
                        }
                        if (newtask.Contains("-prehm"))
                        {
                            Prehardmode = true;
                            newtask = newtask.Replace("-prehm", "");
                        }
                        if (newtask.Contains("-hm"))
                        {
                            Hardmode = true;
                            newtask = newtask.Replace("-hm", "");
                        }
                        if (newtask.Contains("-armor"))
                        {
                            Armor = true;
                            newtask = newtask.Replace("-armor", "");
                        }
                        if (newtask.Contains("-enemy"))
                        {
                            Enemy = true;
                            newtask = newtask.Replace("-enemy", "");
                        }
                        if (newtask.Contains("-rare"))
                        {
                            Rare = true;
                            newtask = newtask.Replace("-rare", "");
                        }
                        if (newtask.Contains("-boss"))
                        {
                            Boss = true;
                            newtask = newtask.Replace("-boss", "");
                        }
                        if (newtask.Contains("-npc"))
                        {
                            NPC = true;
                            newtask = newtask.Replace("-npc", "");
                        }
                        if (newtask.Contains("-event"))
                        {
                            Event = true;
                            newtask = newtask.Replace("-event", "");
                        }
                        if (newtask.Contains("-easy"))
                        {
                            Easy = true;
                            newtask = newtask.Replace("-easy", "");
                        }
                        if (newtask.Contains("-medium"))
                        {
                            Medium = true;
                            newtask = newtask.Replace("-medium", "");
                        }
                        if (newtask.Contains("-hard"))
                        {
                            Hard = true;
                            newtask = newtask.Replace("-hard", "");
                        }
                        if (newtask.Contains("-insane"))
                        {
                            Insane = true;
                            newtask = newtask.Replace("-insane", "");
                        }
                        if (newtask.Contains("-crim"))
                        {
                            Crimson = true;
                            newtask = newtask.Replace("-crim", "");
                        }
                        if (newtask.Contains("-cor"))
                        {
                            Corruption = true;
                            newtask = newtask.Replace("-cor", "");
                        }
                        if (newtask.Contains("-melee"))
                        {
                            Melee = true;
                            newtask = newtask.Replace("-melee", "");
                        }
                        if (newtask.Contains("-ranged"))
                        {
                            Ranged = true;
                            newtask = newtask.Replace("-ranged", "");
                        }
                        if (newtask.Contains("-mage"))
                        {
                            Mage = true;
                            newtask = newtask.Replace("-mage", "");
                        }
                        if (newtask.Contains("-summoner"))
                        {
                            Summoner = true;
                            newtask = newtask.Replace("-summoner", "");
                        }
                        if (newtask.Contains("-passive"))
                        {
                            Passive = true;
                            newtask = newtask.Replace("-passive", "");
                        }
                        if (newtask.Contains("-fail"))
                        {
                            Fail = true;
                            newtask = newtask.Replace("-fail", "");
                        }
                        if (newtask.Contains("-team"))
                        {
                            Team = true;
                            newtask = newtask.Replace("-team", "");
                        }
                        if (newtask.Contains("-expert"))
                        {
                            Expert = true;
                            newtask = newtask.Replace("-expert", "");
                        }
                        if (newtask.Contains("-n"))
                        {
                            int startmin = newtask.IndexOf("[") + 1;

                            int endmin = newtask.IndexOf(":") - 1;

                            int startmax = newtask.IndexOf(":") + 1;
                            int endmax = newtask.IndexOf("]") - 1;

                            char taskminchar;
                            char taskmaxchar;

                            //Create minimum and maximum numbers for RNG for -n[x:y]
                            sbmin.Clear();
                            for (int i = startmin; i <= endmin; i++)
                            {

                                taskminchar = newtask[i];
                                sbmin.Append(taskminchar);
                                taskmin.Insert(0, taskminchar.ToString());



                            }

                            sbmax.Clear();
                            for (int i = startmax; i <= endmax; i++)
                            {
                                taskmaxchar = newtask[i];
                                sbmax.Append(taskmaxchar);
                                taskmax.Insert(taskmin.Length, taskmaxchar.ToString());

                            }


                            taskrandnum = random.Next(int.Parse(sbmin.ToString()), int.Parse(sbmax.ToString()));
                            if (taskrandnum > 1)
                            {
                                taskrandnum = (taskrandnum * difficultyslider.Value) + random.Next(0, difficultyslider.Value);


                            }


                            for (int i = endmax; i != startmin - 2; i--)
                            {
                                newtask = newtask.Remove(i);
                            }
                            newtask = newtask.Replace("-n", "");
                        }
                        else
                        {
                            taskrandnum = 1;
                        }
                        newtask = newtask.TrimEnd();



                        entrydata.Rows.Add(idtask, newtask, Convert.ToInt32(Item), Convert.ToInt32(Prehardmode), Convert.ToInt32(Hardmode), Convert.ToInt32(Armor), Convert.ToInt32(Enemy), Convert.ToInt32(Rare), Convert.ToInt32(Boss), Convert.ToInt32(NPC), Convert.ToInt32(Event),
                            Convert.ToInt32(Easy), Convert.ToInt32(Medium), Convert.ToInt32(Hard), Convert.ToInt32(Insane), Convert.ToInt32(Crimson), Convert.ToInt32(Corruption), Convert.ToInt32(Melee), Convert.ToInt32(Ranged), Convert.ToInt32(Mage),
                            Convert.ToInt32(Summoner), Convert.ToInt32(Passive), Convert.ToInt32(Fail), Convert.ToInt32(Team), Convert.ToInt32(Expert), taskrandnum);

                    }
                }

                //Generate card based on difficulty and options
                possibletasks = entrydata.Clone();
                possibletasks.Clear();
                selectedtable = possibletasks.Clone();
                selectedtable.Rows.Clear();
                sbmin.Clear();



                if (prehardmodechk.Checked && !hardmodechk.Checked)
                {
                    sbmin.Append("Prehardmode = 1");

                }

                //Hardmode Only
                else if (hardmodechk.Checked && !prehardmodechk.Checked)
                {
                    sbmin.Append("Hardmode = 1");


                }

                //Pre-hardmode and Hardmode
                else if (prehardmodechk.Checked && hardmodechk.Checked)
                {
                    sbmin.Append("(Prehardmode = 1 or Hardmode = 1)");



                }


                if (crimson)
                {
                    sbmin.Append("and Corruption <> 1");
                }
                if (corruption)
                {
                    sbmin.Append("and Crimson <> 1");
                }
                if (!expert)
                {
                    sbmin.Append("and Expert = 0");
                }







                selectstring = sbmin.ToString();
                DataRow[] dttest = entrydata.Select(selectstring);
                foreach (DataRow prehmtask in dttest)
                {
                    possibletasks.ImportRow(prehmtask);
                }

                if (blackoutchk.Checked)
                {
                    blackout = true;
                    bingosreq = 12;

                }
                else
                {
                    bingosreq = bingoamt.Value;

                }
              

                comp.Clear();


                generatecard();
                B1string = sbmin.ToString();

                generatecard();
                B2string = sbmin.ToString();

                generatecard();
                B3string = sbmin.ToString();

                generatecard();
                B4string = sbmin.ToString();

                generatecard();
                B5string = sbmin.ToString();

                generatecard();
                I1string = sbmin.ToString();

                generatecard();
                I2string = sbmin.ToString();

                generatecard();
                I3string = sbmin.ToString();

                generatecard();
                I4string = sbmin.ToString();

                generatecard();
                I5string = sbmin.ToString();

                generatecard();
                N1string = sbmin.ToString();

                generatecard();
                N2string = sbmin.ToString();

                generatecard();
                N3string = sbmin.ToString();

                generatecard();
                N4string = sbmin.ToString();

                generatecard();
                N5string = sbmin.ToString();

                generatecard();
                G1string = sbmin.ToString();

                generatecard();
                G2string = sbmin.ToString();

                generatecard();
                G3string = sbmin.ToString();

                generatecard();
                G4string = sbmin.ToString();

                generatecard();
                G5string = sbmin.ToString();

                generatecard();
                O1string = sbmin.ToString();

                generatecard();
                O2string = sbmin.ToString();

                generatecard();
                O3string = sbmin.ToString();

                generatecard();
                O4string = sbmin.ToString();

                generatecard();
                O5string = sbmin.ToString();

                selectedtable.Rows.Clear();


                if (freespacechk.Checked)
                {
                    freespace = true;
                    N3string = "Free Space";
                }
                else
                {
                    freespace = false;
                }
                
                if (seedonlychk.Checked)
                {
                    Clipboard.SetText(seed);
                    seedtxtbx.Text = seed;
                    MessageBox.Show("Seed copied to clipboard.");
                }
                else
                {
                    if (blackoutchk.Checked)
                    {
                        blackout = true;
                        bingosreq = 12;

                    }
                    else
                    {
                        bingosreq = bingoamt.Value;

                    }

                    Sheet card = new Sheet();
                    card.Show();
                    card.Focus();



                }
            }
        }


        public void difficultygen()
        {
            r2 = randomtemp.Next(0, 21);
            if (hardmodechk.Checked)
            {
                //Increase difficulty slightly for all difficulties if hardmode is selected. Adds 1/20 for each chance. Example: Likely to shift easy to medium and medium to hard at higher difficulties.
                r2++;
            }

            //Easy
            if (difficultyslider.Value == 1)
            {
                if (r2 >= 1 && r2 <= 8)
                {
                    objpicker.Append(" and Easy = 1");
                }
                else if (r2 >= 9 && r2 <= 14)
                {
                    objpicker.Append(" and Medium = 1");
                }
                else if (r2 >= 15 && r2 <= 18)
                {
                    objpicker.Append(" and Hard = 1");
                }
                else if (r2 >= 19)
                {
                    objpicker.Append(" and Insane = 1");
                }
            }

            //Medium
            else if (difficultyslider.Value == 2)
            {
                if (r2 >= 1 && r2 <= 5)
                {
                    objpicker.Append(" and Easy = 1");
                }
                else if (r2 >= 6 && r2 <= 13)
                {
                    objpicker.Append(" and Medium = 1");
                }
                else if (r2 >= 14 && r2 <= 18)
                {
                    objpicker.Append(" and Hard = 1");
                }
                else if (r2 >= 19)
                {
                    objpicker.Append(" and Insane = 1");
                }
            }

            //Hard
            else if (difficultyslider.Value == 3)
            {
                if (r2 >= 1 && r2 <= 4)
                {
                    objpicker.Append(" and Easy = 1");
                }
                else if (r2 >= 5 && r2 <= 9)
                {
                    objpicker.Append(" and Medium = 1");
                }
                else if (r2 >= 10 && r2 <= 17)
                {
                    objpicker.Append(" and Hard = 1");
                }
                else if (r2 >= 18)
                {
                    objpicker.Append(" and Insane = 1");
                }
            }

            //Insane
            else if (difficultyslider.Value == 4)
            {
                if (r2 >= 1 && r2 <= 2)
                {
                    objpicker.Append(" and Easy = 1");
                }
                else if (r2 >= 3 && r2 <= 6)
                {
                    objpicker.Append(" and Medium = 1");
                }
                else if (r2 >= 7 && r2 <= 11)
                {
                    objpicker.Append(" and Hard = 1");
                }
                else if (r2 >= 12)
                {
                    objpicker.Append(" and Insane = 1");
                }
            }
        }


        public void generatecard()
        {
            temptable = possibletasks.Clone();
            temptable.Rows.Clear();
            sbmin.Clear();
            int r = randomtemp.Next(1, 4);
            objpicker.Clear();


            if (r == 1)
            {
                while (temptable.Rows.Count == 0)
                {
                    objpicker.Clear();
                    objpicker.Append("Enemy = 1");
                    difficultygen();
                    if (comp.ToString() != "")
                    {
                        objpicker.Append($" and (TaskID not in ({comp.ToString()}))");
                    }
                    foreach (DataRow dr in possibletasks.Select(objpicker.ToString()))
                    {
                        temptable.ImportRow(dr);
                    }
                }
            }
            if (r == 2)
            {
                while (temptable.Rows.Count == 0)
                {
                    objpicker.Clear();
                    //Select Item
                    objpicker.Append("Item = 1");
                    if (meleechk.Checked)
                    {
                        objpicker.Append(" and (Melee = 1");
                        if (rangerchk.Checked)
                        {
                            objpicker.Append(" or Ranged = 1");
                        }
                        if (magechk.Checked)
                        {
                            objpicker.Append(" or Mage = 1");
                        }
                        if (summonerchk.Checked)
                        {
                            objpicker.Append(" or Summoner = 1");
                        }
                    }
                    else if (rangerchk.Checked)
                    {

                        objpicker.Append(" and (Ranged = 1");
                        if (magechk.Checked)
                        {
                            objpicker.Append(" or Mage = 1");
                        }
                        if (summonerchk.Checked)
                        {
                            objpicker.Append(" or Summoner = 1");
                        }

                    }
                    else if (magechk.Checked)
                    {
                        objpicker.Append(" and (Mage = 1");
                        if (summonerchk.Checked)
                        {
                            objpicker.Append(" or Summoner = 1");
                        }


                    }
                    else if (summonerchk.Checked)
                    {
                        objpicker.Append(" and (Summoner = 1");

                    }
                    else if (!meleechk.Checked && !rangerchk.Checked && !magechk.Checked && !summonerchk.Checked)
                    {

                        objpicker.Append(" and (Melee = 1 or Ranged = 1 or Mage = 1 or Summoner = 1)");
                    }


                    if (objpicker[objpicker.Length - 1].ToString() != ")")
                    {
                        objpicker.Append(" )");
                    }
                    //Determine difficulty based on user input from slider
                    difficultygen();

                    if (comp.ToString() != "")
                    {
                        objpicker.Append($" and (TaskID not in ({comp.ToString()}))");
                    }


                    foreach (DataRow dr in possibletasks.Select(objpicker.ToString()))
                    {
                        temptable.ImportRow(dr);
                    }
                }
            }
            else if (r == 3)
            {
                int loop = 0;
                while (temptable.Rows.Count == 0)
                {
                    loop++;
                    objpicker.Clear();
                    objpicker.Append("Boss = 1");
                    difficultygen();
                    if (comp.ToString() != "")
                    {
                        objpicker.Append($" and (TaskID not in ({comp.ToString()}))");
                    }
                    foreach (DataRow dr in possibletasks.Select(objpicker.ToString()))
                    {
                        temptable.ImportRow(dr);
                    }
                    if (loop > 25)
                    {
                        sbmin.Clear();
                        generatecard();
                        sbmin.Clear();
                    }
                }
            }
            else if (r == 4)
            {
                //Select NPC
                foreach (DataRow dr in possibletasks.Select("NPC = 1"))
                {
                    temptable.Rows.Add(dr);
                }
            }
            else if (r == 5)
            {
                //Select Event
                foreach (DataRow dr in possibletasks.Select("Event = 1"))
                {
                    temptable.Rows.Add(dr);
                }
            }



            randrowint = random.Next(0, temptable.Rows.Count);


            comp.Append(temptable.Rows[randrowint]["TaskID"].ToString() + ",");

            if (temptable.Rows[randrowint]["Enemy"] == "1")
            {
                sbmin.Append("Defeat ");
                sbmin.Append(temptable.Rows[randrowint]["TaskName"]).ToString();
                killcount = int.Parse(temptable.Rows[randrowint]["Num"].ToString());
                sbmin.Append($" x {killcount}");
            }
            else if (temptable.Rows[randrowint]["Item"] == "1")
            {
                sbmin.Append("Obtain ");
                sbmin.Append(temptable.Rows[randrowint]["TaskName"]).ToString();
                killcount = int.Parse(temptable.Rows[randrowint]["Num"].ToString());
                if (killcount > 1)
                {

                    sbmin.Append($" x {killcount}");
                }

            }
            else if (temptable.Rows[randrowint]["Boss"] == "1")
            {
                sbmin.Append("Defeat ");
                sbmin.Append(temptable.Rows[randrowint]["TaskName"]).ToString();
                killcount = int.Parse(temptable.Rows[randrowint]["Num"].ToString());
                if (killcount > 1)
                {

                    sbmin.Append($" x {killcount}");
                }
            }

            
        }
        private void dgvbtn_Click(object sender, EventArgs e)
        {
            tasktable();
            tableform tableform = new tableform();
            tableform.Show();

        }

        private void crimsonchk_CheckedChanged(object sender, EventArgs e)
        {
            if (crimsonchk.Checked)
            {

                corruptionchk.Checked = false;


                if (hardmodechk.Checked)
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/HMCrimson.png");
                }
                else
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/Crimson.png");
                }
            }
            if (!crimsonchk.Checked && !corruptionchk.Checked)
            {
                crimsonchk.Checked = true;
            }
        }

        private void corruptionchk_CheckedChanged(object sender, EventArgs e)
        {
            if (corruptionchk.Checked)
            {
                crimsonchk.Checked = false;
            }
            if (hardmodechk.Checked)
            {
                worldpb.Image = Image.FromFile(@"../../../Resources/HMCorruption.png");
            }
            else
            {
                worldpb.Image = Image.FromFile(@"../../../Resources/Corruption.png");
            }
            if (!crimsonchk.Checked && !corruptionchk.Checked)
            {
                corruptionchk.Checked = true;
            }
        }

        private void expertchk_CheckedChanged(object sender, EventArgs e)
        {
            if (expertchk.Checked)
            {
                expert = true;
                expertpb.Show();
            }
            else
            {
                expert = false;
                expertpb.Hide();
            }
        }

        private void difficultyslider_Scroll(object sender, EventArgs e)
        {
            if (difficultyslider.Value == 1)
            {
                diffnum.Text = "Easy";
                difficultypb.Image = Image.FromFile(@"../../../Resources/Calm.png");
            }
            if (difficultyslider.Value == 2)
            {
                diffnum.Text = "Medium";
                difficultypb.Image = Image.FromFile(@"../../../Resources/Dangersense.png");

            }
            if (difficultyslider.Value == 3)
            {
                diffnum.Text = "Hard";
                difficultypb.Image = Image.FromFile(@"../../../Resources/Frostburn.png");
            }
            if (difficultyslider.Value == 4)
            {
                diffnum.Text = "Insane";
                difficultypb.Image = Image.FromFile(@"../../../Resources/Weak.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            seedtxtbx.Text = Clipboard.GetText();
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            Form help = new HelpForm();
            help.Show();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            seedlbl.Visible = true;
            seedtxtbx.Visible = true;
            clipbtn.Visible = true;
            seedonlychk.Visible = false;
            ToolTip tt = new ToolTip();
            tt.AutomaticDelay = 500;
            tt.ReshowDelay = 500;
            tt.SetToolTip(this.clipbtn, "Paste from clipboard");
            tt.SetToolTip(this.prehardmodechk, "Check to include tasks from Pre-Hardmode.");
            tt.SetToolTip(this.hardmodechk, "Check to include tasks from Hardmode.");
            tt.SetToolTip(this.crimsonchk, "Select this if you are playing on a Crimson world.");
            tt.SetToolTip(this.corruptionchk, "Select this if you are playing on a Corruption world.");
            tt.SetToolTip(this.multiplayerchk, "Select this if you want to include multiplayer items such as wormhole potions.");
            tt.SetToolTip(this.blackoutchk, "In Blackout, all squares must be completed. Fun fact: That would be 12 Bingos.");
            tt.SetToolTip(this.freespacechk, "Select this if you would like to have a free space in the middle of the card. (N3).");
            tt.SetToolTip(this.seedonlychk, "Select this if you would like to create a seed and have it copied to the clipboard instead \n" +
                "of creating a card when pressing Generate. Useful for not spoiling cards for races.");
            tt.SetToolTip(this.meleechk, "Check to include Melee items. If no classes are checked, all classes will be included." +
                "Only selected classes will be included.");
            tt.SetToolTip(this.rangerchk, "Check to include Ranger items. If no classes are checked, all classes will be included." +
                "Only selected classes will be included.");
            tt.SetToolTip(this.magechk, "Check to include Mage items. If no classes are checked, all classes will be included." +
                "Only selected classes will be included.");
            tt.SetToolTip(this.summonerchk, "Check to include Summoner items. If no classes are checked, all classes will be included." +
                "Only selected classes will be included.");





            clipbtn.Image = Image.FromFile(@"../../../Resources/Clipboard.png");
            difficultypb.SizeMode = PictureBoxSizeMode.StretchImage;
            worldpb.SizeMode = PictureBoxSizeMode.StretchImage;
            expertpb.SizeMode = PictureBoxSizeMode.StretchImage;
            difficultypb.Image = Image.FromFile(@"../../../Resources/Calm.png");
            expertpb.Hide();
            expertpb.Image = Image.FromFile(@"../../../Resources/Expert_mode_icon.png");


            updateworldimg();


        }

        public void updateworldimg()
        {
            if (prehardmodechk.Checked && !hardmodechk.Checked)
            {
                if (crimsonchk.Checked)
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/Crimson.png");
                }
                else
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/Corruption.png");
                }
            }
            else
            {
                if (crimsonchk.Checked)
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/HMCrimson.png");
                }
                else
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/HMCorruption.png");
                }
            }
            if (hardmodechk.Checked)
            {
                if (crimsonchk.Checked)
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/HMCrimson.png");
                }
                else
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/HMCorruption.png");
                }
            }
            else
            {
                if (crimsonchk.Checked)
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/Crimson.png");
                }
                else
                {
                    worldpb.Image = Image.FromFile(@"../../../Resources/Corruption.png");
                }

            }
        }


        private void prehardmodechk_CheckedChanged(object sender, EventArgs e)
        {

            if (!prehardmodechk.Checked && !hardmodechk.Checked)
            {
                prehardmodechk.Checked = true;
            }

            updateworldimg();


        }

        private void hardmodechk_CheckedChanged(object sender, EventArgs e)
        {
            if (!prehardmodechk.Checked && !hardmodechk.Checked)
            {
                hardmodechk.Checked = true;
            }
            updateworldimg();

        }
    }
}
