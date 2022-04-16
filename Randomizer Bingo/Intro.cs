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
        public DataRow randrow;
        public DataRow temprow;
        public static string seed;
        public int id;
        public int idtask;
        public int taskrandnum;
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
        public static StringBuilder sbseed = new StringBuilder();
        public StringBuilder sbmin = new StringBuilder();
        public StringBuilder sbmax = new StringBuilder();
        public StringBuilder objpicker = new StringBuilder();
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
                        //seed = seed + $"{id}-";
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

        private void finishintrobtn_Click(object sender, EventArgs e)
        {
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
                File.Delete(@"../../../Resources/fulltasks.txt");
                foreach (string entry in File.ReadAllLines(@"../../../Resources/enemylist.txt"))
                {
                    sbmin.AppendLine(entry);
                    
                    
                }
                foreach (string entry in File.ReadAllLines(@"../../../Resources/itemlist.txt"))
                {
                    sbmin.AppendLine(entry);


                }
                idtask = 0;
                File.AppendAllText(@"../../../Resources/fulltasks.txt", sbmin.ToString());
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
                            int startmin = newtask.IndexOf("[") +1;
                            
                            int endmin = newtask.IndexOf(":") -1;
                            
                            int startmax = newtask.IndexOf(":") +1;
                            int endmax = newtask.IndexOf("]") -1;
                            
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
                            
                            
                            for (int i = endmax; i != startmin -2; i--)
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



                        al.Add("B1string");
                        al.Add("B2string");
                        al.Add("B3string");
                        al.Add("B4string");
                        al.Add("B5string");
                        al.Add("I1string");
                        al.Add("I2string");
                        al.Add("I3string");
                        al.Add("I4string");
                        al.Add("I5string");
                        al.Add("N1string");
                        al.Add("N2string");
                        al.Add("N3string");
                        al.Add("N4string");
                        al.Add("N5string");
                        al.Add("G1string");
                        al.Add("G2string");
                        al.Add("G3string");
                        al.Add("G4string");
                        al.Add("G5string");
                        al.Add("O1string");
                        al.Add("O2string");
                        al.Add("O3string");
                        al.Add("O4string");
                        al.Add("O5string");




        //Generate card based on difficulty and options
        possibletasks = entrydata.Clone();
                possibletasks.Clear();
                sbmin.Clear();
                //Pre-hardmode only


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
                sbseed.Clear();
                sbseed.Append($"mult:[{difficultyslider.Value.ToString()}] ");
                generatecard();
                B1string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                B2string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                B3string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                B4string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                B5string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                I1string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                I2string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                I3string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                I4string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                I5string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                N1string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                N2string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                N3string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                N4string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                N5string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                G1string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                generatecard();
                G2string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                G3string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                G4string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                G5string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                O1string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                O2string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                O3string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                O4string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete(); 
                generatecard();
                O5string = sbmin.ToString();
                possibletasks.Rows[randrowint].Delete();
                if (freespacechk.Checked)
                {
                    freespace = true;
                    N3string = "Free Space";
                }
                sbseed.Insert(0, "-");
                sbseed.Remove(sbseed.Length - 1, 1);
                seedtxtbx.Text = sbseed.ToString();
                seed = sbseed.ToString();
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
        public void generatecard()
        {
            temptable = possibletasks.Clone();
            temptable.Rows.Clear();
            sbmin.Clear();
            int r = randomtemp.Next(1, 3);
            objpicker.Clear();
            
            if (r == 1)
            {
                //Select Enemy
                foreach (DataRow dr in possibletasks.Select("Enemy = 1"))
                {
                    temptable.ImportRow(dr);
                }


            }
            if (r == 2)
            {
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
                foreach (DataRow dr in possibletasks.Select(objpicker.ToString()))
                {
                    temptable.ImportRow(dr);
                }
            }
            else if (r == 3)
            {
                //Select Boss
                foreach (DataRow dr in possibletasks.Select("Boss = 1"))
                {
                    temptable.Rows.Add(dr);
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

            randrowint = random.Next(1, temptable.Rows.Count);
            if (temptable.Rows[randrowint]["Enemy"] == "1")
            {
                sbmin.Append("Defeat ");
                sbmin.Append(temptable.Rows[randrowint]["TaskName"]).ToString();
                killcount = int.Parse(temptable.Rows[randrowint]["Num"].ToString()) * difficultyslider.Value;
                sbmin.Append($" x {killcount}");
            }
            else if (temptable.Rows[randrowint]["Item"] == "1")
            {
                sbmin.Append("Obtain ");
                sbmin.Append(temptable.Rows[randrowint]["TaskName"]).ToString();
                killcount = int.Parse(temptable.Rows[randrowint]["Num"].ToString());
                if (killcount > 1)
                {
                    killcount = killcount * difficultyslider.Value;
                    sbmin.Append($" x {killcount}");
                }
                
            }
            
            sbseed.Append(temptable.Rows[randrowint]["TaskID"].ToString() + "[" + temptable.Rows[randrowint]["Num"].ToString() + "] -");
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
            ToolTip imagett = new ToolTip();
            imagett.AutomaticDelay = 500;
            imagett.ReshowDelay = 500;
            imagett.SetToolTip(this.pictureBox1, "Paste from clipboard");
            pictureBox1.Image = Image.FromFile(@"../../../Resources/Clipboard.png");
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