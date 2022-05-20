using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPD_Templates
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string english = null;
            string rp = null;
            string mic = null;
            string serverrules = null;
            // English Check
            if (goodEnglish.Checked)
            {
                english = @"[COLOR=#00FF00][B]GOOD[/B][/COLOR]";
            }
            else if (avgEnglish.Checked)
            {
                english = @"[B][COLOR=#D3D3D3]AVERAGE[/COLOR][/B]";
            }
            else if (badEnglish.Checked)
            {
                english = @"[B][COLOR=#FF0000]BAD[/COLOR][/B]";
            }
            else
            {
                MessageBox.Show("Please make sure you have selected the correct boxes, exiting the process.");
                return;
            }
            if (goodRP.Checked)
            {
                rp = @"[COLOR=#00FF00][B]GOOD[/B][/COLOR]";
            }
            else if (avgRP.Checked)
            {
                rp = @"[B][COLOR=#D3D3D3]AVERAGE[/COLOR][/B]";
            }
            else if (badRP.Checked)
            {
                rp = @"[B][COLOR=#FF0000]BAD[/COLOR][/B]";
            }
            else
            {
                MessageBox.Show("Please make sure you have selected the correct boxes, exiting the process.");
                return;
            }
            if (goodmic.Checked)
            {
                mic = @"[COLOR=#00FF00][B]GOOD[/B][/COLOR]";
            }
            else if (avgmic.Checked)
            {
                mic = @"[B][COLOR=#D3D3D3]AVERAGE[/COLOR][/B]";
            }
            else if (badmic.Checked)
            {
                mic = @"[B][COLOR=#FF0000]BAD[/COLOR][/B]";
            }
            else
            {
                MessageBox.Show("Please make sure you have selected the correct boxes, exiting the process.");
                return;
            }
            if (rulesGood.Checked)
            {
                serverrules = @"[COLOR=#00FF00][B]GOOD[/B][/COLOR]";
            }
            else if (rulesAVG.Checked)
            {
                serverrules = @"[B][COLOR=#D3D3D3]AVERAGE[/COLOR][/B]";
            }
            else if (rulesBAD.Checked)
            {
                serverrules = @"[B][COLOR=#FF0000]BAD[/COLOR][/B]";
            }
            else
            {
                MessageBox.Show("Please make sure you have selected the correct boxes, exiting the process.");
                return;
            }
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Verdana][SIZE=1][B][COLOR=ROYALBLUE]San Andreas Police Department
Field Training and Operations[/COLOR][/b][/size][/font][/left]
[CENTER][FONT=Trebuchet MS][IMG]https://i.imgur.com/xcc59oQ.png[/IMG]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[b][size=5][COLOR=#D3D3D3]TRAINING FILE[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/center]


[SIZE=4][FONT=Verdana][COLOR=ROYALBLUE][u][b][center]CADET'S INFORMATION[/center][/b][/u][/COLOR][u][b][center][/center][/b][/u][/FONT][/SIZE][FONT=Verdana][u][b][center][/center][/b][/U][b][center][/center][/B][center][/center][/FONT][center][/CENTER]


[list][COLOR=#2B60DE][B]Full Name[/B]:[/COLOR] [COLOR=#D3D3D3]ANSWER[/COLOR]

[COLOR=#2B60DE][B][*]Police Application:[/B][/COLOR] [URL="""+policeapp.Text+ @"""]** ATTACHMENT **[/URL]

[COLOR=#2b60de][B][*]Discord ID: [/B][/COLOR] [COLOR=#D3D3D3]" + cdtdisc.Text + @"[/COLOR]



[SIZE=4][FONT=Verdana][COLOR=ROYALBLUE][u][b][center](( EVALUATION OF PERFORMANCE ))[/center][/b][/u][/COLOR][u][b][center][/center][/b][/u][/FONT][/SIZE][FONT=Verdana][u][b][center][/center][/b][/U][b][center][/center][/B][center][/center][/FONT][center][/CENTER]


[COLOR=#2B60DE][B][*]Microphone Quality:[/B][/COLOR]" + mic + @"

[COLOR=#2B60DE][B][*]English Skills:[/B][/COLOR]" + english + @"
[COLOR=#2B60DE][B][*]Roleplay Skills:[/B][/COLOR]" + rp + @"

[COLOR=#2B60DE][B][*]Server Rules Knowledge:[/B][/COLOR]" + serverrules + @"[/list][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Text copied to clipboard!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = @"
>>> Request: Add to Roster
Full Name: " + cdtname.Text + @"
Department Rank: Officer
Assignment (Division): PTL
Personnel Profile: He will link it
Requested role changes: Remove Cadet role, add Officer and PTL
(@" + cdtdisc.Text + @")
>>> Request: Badge number addition
Full Name:" + cdtname.Text + @"
Rank: Officer
Badge Number:" + ridealongoieno.Text + @"
Personnel Profile: He will link it
(@" + cdtdisc.Text + @")";

            Clipboard.SetText(text.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string training = null;
            if (theorybox.Checked)
            {
                training = "Theory";
            }
            else if (practicalbox.Checked)
            {
                training = "Practical";
            }
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][/FONT][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][B][COLOR=WHITE][/COLOR][/B]

[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/035KHhy.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[b][size=5][COLOR=#D3D3D3]TRAINING COMPLETED[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/center]


[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#1E90FF][B]TRAINER: [/B][/COLOR][COLOR=WHITE]"+trainername.Text+@"[/COLOR][COLOR=#e6e6fa]

[/COLOR][B][COLOR=#1E90FF]TRAINING COMPLETED:[/COLOR][/B][COLOR=WHITE]"+training+ @"[/COLOR]
[COLOR=#1E90FF]
[B]SUPERVISORY TRAINER:[/B][/COLOR] [COLOR=WHITE]" + sprvsr.Text + @"[/COLOR]

[COLOR=#1E90FF][B]EVALUATION:[/B][/COLOR] [color=WHITE]" + evaluation.Text + @" 

[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to Clipboard");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
[SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/035KHhy.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[COLOR=#add8e6][B][SIZE=5]RIDEALONG COMPLETED[/SIZE][/B][/COLOR]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#1E90FF][B]RIDEALONG SUPERVISOR: [/B][/COLOR][COLOR=WHITE]" + trainername.Text + @"[/COLOR][COLOR=#e6e6fa]

[/COLOR][B][COLOR=#1e90ff]RIDEALONG COMPLETED:[/COLOR][/B][COLOR=WHITE]" + ridealongoieno.Text + @"[/COLOR]

[COLOR=#1E90FF][B]EVALUATION:[/B][/COLOR] [COLOR=WHITE] " + evaluation.Text + @"

[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to Clipboard");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][/FONT][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][B][COLOR=WHITE][/COLOR][/B]

[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/035KHhy.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[b][size=5][COLOR=YELLOW]RE-TRAINING IN PROGRESS[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/center]

[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#1E90FF][B]TRAINER: [/B][/COLOR][COLOR=#e6e6fa]" + trainername.Text + @"[/COLOR]

[COLOR=#1E90FF][B]PROGRESSION:[/B][/COLOR] [COLOR=WHITE]" + progression.Text + @"[/COLOR]

[COLOR=#1E90FF][B]NOTES: [/B][/COLOR][COLOR=#e6e6fa]" + evaluation.Text + @"[/COLOR][COLOR=#D3D3D3]

[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to Clipboard");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][/FONT][SIZE=1][B][COLOR=WHITE][/COLOR][/B][/SIZE][B][COLOR=WHITE][/COLOR][/B]

[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/035KHhy.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[b][size=5][COLOR=#D3D3D3]PENDING OIE[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/center]
[/TD]
[/TR]
[/TABLE]

[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=WHITE][FONT=TIMES NEW ROMAN]The applicant has successfully finished their 3 Ride Alongs, 24 hours has also passed and they're now eligible for their OIE.[/FONT][/COLOR][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to Clipboard");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
[SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


[CENTER][FONT=Trebuchet MS][img]https://i.imgur.com/035KHhy.png[/img]

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][SIZE=5][COLOR=#D3D3D3]PENDING RIDEALONGS[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]
[/TD]
[/TR]
[/TABLE]

[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=WHITE][FONT=TIMES NEW ROMAN]The applicant is to have 3 ridealongs conducted by a FTO General Instructor+ or any Sergeant+ of any division. These ridealongs must be filed through our #ridealong channel on discord in order to be counted and documented by FTO Supervisor+ on the Cadets Training File.[/FONT][/COLOR][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to Clipboard");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string x = null;
            if (oiePassed.Checked)
            {
                x = "[COLOR =#00FF00]PASSED[/COLOR]";
            }
            else if (oieFailed.Checked)
            {
                x = "[COLOR=#FF0000]FAILED[/COLOR]";
            }
            else if (oiePassed.Checked && oieFailed.Checked)
            {
                MessageBox.Show("Stop trolling around with the program please!");
                x = null;
            }
            else
            {
                MessageBox.Show("Please select if the applicant has passed his OIE or they failed it.");
            }

             var text = @"
 [TABLE=""class: grid, width: 700, align: center""]
 [TR]
 [TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
 [SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


 [CENTER][FONT=Trebuchet MS][IMG]https://i.imgur.com/035KHhy.png[/IMG]

 [IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
 [B][SIZE=5][COLOR=GREEN]FINISHED OIE[/COLOR][/SIZE][/B]
 [IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]

 [TABLE=""width: 500, align: center""]
 [TR]
 [TD][COLOR=#ffffff][B]OIE RESULTS:[/B][/COLOR]"+x+@"

 [COLOR=WHITE][B]OIE NUMBER:[/B]"+ridealongoieno.Text+ @"

 [B]OIE GIVEN BY:[/B] " + trainername.Text + @"

 [B]SUPERVISED BY:[/B] " + sprvsr.Text + @"

 [B]NOTES:[/B] " + evaluation.Text + @"

 [/COLOR][/TD]
 [/TR]
 [/TABLE]
 [/TD]
 [/TR]
 [/TABLE]
 ";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to Clipboard");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][LEFT][FONT=Century Gothic][SIZE=1][B][COLOR=WHITE]
[SIZE=2]Commander of Field Training Operations Lizzie Kingsman[/SIZE][/COLOR][/B][/SIZE][/FONT][/LEFT]


[CENTER][FONT=Trebuchet MS][IMG]https://i.imgur.com/035KHhy.png[/IMG]        

[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG]
[B][SIZE=5][COLOR=RED]DISQUALIFIED[/COLOR][/SIZE][/B]
[IMG]https://www.asianbiketour.com/wp-content/uploads/2012/07/fade-line-div.png[/IMG][/FONT][/CENTER]
[TABLE=""width: 500, align: center""]
[TR]
[TD][COLOR=#D3D3D3][B]Reason: [/B][/COLOR][COLOR=#e6e6fa]" + reasons.Text + @"[/COLOR][COLOR=#D3D3D3]


[/COLOR][/TD]
[/TR]
[/TABLE]
[/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to Clipboard");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
