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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Pending Interview
        {
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Carlos S. Borrelli
63rd Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://media.discordapp.net/attachments/630483639725064220/893150943330328576/PI.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

Your application has been received by the Field Training and Operations branch of the Los Santos Police Department. After reviewing your experience and qualifications, we are pleased to inform you that your application has been [/FONT][/COLOR][B][COLOR=#00ff00][FONT=Century Gothic]progressed[/FONT][/COLOR][/B][COLOR=#00bfff][FONT=Century Gothic] to the next stage and you are pending to be interviewed. 

You are about to embark on a career of public service in which professionalism, perfection, and dedication are required on a daily basis. You have been registered on the interview list and can now contact a recruitment officer to conduct your interview. Your interview will consist of general life questions, State Penal Codes, rationality, and other basic knowledge questions found in the handbook, be prepared. [/FONT][/COLOR][FONT=Century Gothic]
[TABLE=""width: 670, align: center""]
[TR]
[TD][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/320687-Faction-Rules""]Enclosed within - Rules[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/119591-Felonies-misdemeanors-and-infractions-Laws-Thread""]Enclosed within - State Penal Code[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Enclosed within - Official Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#AFEEEE][I]Please read through it so that you know how to proceed through and enter the Los Santos Police Department.[/I][/COLOR][/INDENT]

[COLOR=#D3D3D3]
[LIST][*](( Kindly join the [URL=""https://hzgaming.net/factiondiscord/""]Faction Discord[/URL] server and edit your name into ""[P. INT] Full Name"". ))[*](( Wait inside the ""Lobby"" under '1.) LSPD' category for your Interview which you will be dragged by a representative from FTO. ))[*]You have a week (7 days) to schedule an interview, otherwise, your application will get denied.[/LIST]
[/COLOR]




[COLOR=#00bfff]After completing a successful interview, you will be eligible to attend the recruitment drive, about which you'll receive an e-mail soon enough. Failure to attend the interview before the recruitment drive will result in you being put on hold and shifted for the next recruitment drive.[/COLOR][COLOR=#D3D3D3]


[/COLOR][COLOR=#00bfff]Sincerely,
[/COLOR][COLOR=#D3D3D3]
[/COLOR][COLOR=#00bfff][B][I]"+textBox2.Text+ @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text);
            MessageBox.Show("Copied to clipboard!");
        }
        private void button2_Click(object sender, EventArgs e) // ON-HOLD
        {
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Carlos S. Borrelli
63rd Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[FONT=century gothic]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/D0fB4n1.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1]
[/SIZE][/COLOR][/RIGHT]
[/FONT][CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

Your application has been reviewed by the Field Training and Operations branch of the Los Santos Police Department. After reviewing your application, we found some minor errors that will need to be fixed so we can proceed with your application. 

The following section(s) need to be [/FONT][/COLOR][B][COLOR=#ffffff][FONT=Century Gothic]FIXED [/FONT][/COLOR][/B][COLOR=#00bfff][FONT=Century Gothic]within the next 48 hours:[/FONT][/COLOR][COLOR=#FFFFFF][FONT=Century Gothic]

[/FONT][/COLOR][COLOR=#ffffff][FONT=Century Gothic][B]
[LIST][*]" + textBox1.Text + @"[/LIST]
[/B][/FONT][/COLOR][FONT=Century Gothic][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/403491-LSPD-Career-Information""]Police Academy Process[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/335311-LSPD-Requirements""]Enrollment Requirements[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Official Police Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#AFEEEE][I]It is important that you actively review the manual as you begin resuming your career within our department for further knowledge sustenance.[/I][/COLOR][/INDENT]


[COLOR=#00bfff]Please keep in mind that you only have a maximum of 48 hours to fix your application or it shall be automatically [/COLOR][COLOR=#ff0000]denied[/COLOR][COLOR=#00bfff]. 
[/COLOR][COLOR=#D3D3D3]
[/COLOR][COLOR=#00bfff]Sincerely,[/COLOR][COLOR=#D3D3D3]

[/COLOR][COLOR=#00bfff][B][I]"+textBox2.Text+ @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");

        }
        private void button3_Click(object sender, EventArgs e) // Denied
        {
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Carlos S. Borrelli
63rd Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[FONT=century gothic]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/tXgwI10.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

Your application has been reviewed by the Field Training and Operations division of the Los Santos Police Department. 

[/FONT][/COLOR][COLOR=#00bfff]After reviewing all information received throughout the selection process, we regret to inform you that your applicant has been [/COLOR][COLOR=#ff0000]DENIED[/COLOR][COLOR=#00bfff].[/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]
 
[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]You were [/FONT][/COLOR][COLOR=#ff0000][FONT=Century Gothic]denied[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic] for employment due to the following reason(s):

[/FONT][/COLOR][COLOR=#ffffff][FONT=Century Gothic][B]
[LIST][*]" + textBox1.Text + @"[/LIST]
[/B][/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]
[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]Please feel free to correct any issues above and re-apply when we start the next recruitment drive for the department. Be advised of the following exigencies:[/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]


[LIST][*]Unable to try again at employment until the next batch (( [B][U]2[/U][/B] weeks )).[*]Unable to continue in the recruitment process or claim you are currently enrolled.[*]Applying in less than 14 days will lead you to be [SIZE=2][COLOR=#B22222]Blacklisted.[/COLOR][/SIZE][/LIST]

[/FONT][/COLOR][COLOR=#ffd700]It is important that you actively review our handbook to understand and acknowledge our standards and learn more about us.[/COLOR] [COLOR=#D3D3D3][FONT=Century Gothic]

[/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]Sincerely,[/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]

[/FONT][/COLOR][I][COLOR=#00bfff][FONT=Century Gothic][B]" + textBox2.Text + @"
[/B][/FONT][/COLOR][/I][COLOR=#00bfff][FONT=Century Gothic][I]Field Training Operations
[/I][/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic][I]Los Santos Police Department[/I][/FONT][/COLOR]


[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/TD]
[/TR]
[/TABLE]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");
        }
        private void button4_Click(object sender, EventArgs e) // Blacklisted
        {
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Carlos S. Borrelli
63rd Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[FONT=century gothic]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/GZBzb2x.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1]
[/SIZE][/COLOR][/RIGHT]
[/FONT][CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][FONT=century gothic][COLOR=#00bfff]Dear Applicant,

After having a review of your application in the officer of Field Training Operations, we regret to inform you that your application has been [/COLOR][B][COLOR=#ff0000]DENIED [/COLOR][/B][COLOR=#00bfff]along with a Recruitment Ban. [/COLOR][COLOR=#FFFFFF]

[/COLOR][COLOR=#00bfff]With the [/COLOR][B][COLOR=#b22222]blacklisted [/COLOR][/B][COLOR=#00bfff]status, you are of the following:[/COLOR][/FONT][COLOR=#FFFFFF][FONT=Century Gothic]

[/FONT][/COLOR][COLOR=#ffffff][FONT=Century Gothic][B]
[LIST][*]" + textBox1.Text + @"[/LIST]
[/B][/FONT][/COLOR]
[FONT=Century Gothic][quote][FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/448872-LSPD-Recruitment-Blacklist""][CENTER]Enclosed within - Recruitment Blacklist[/CENTER]
[/URL][/FONT][/quote]
[COLOR=#FFFFFF]
[/COLOR][COLOR=#00bfff]You can check your recruitment ban by clicking the attachment foreseen above.
[/COLOR][COLOR=#FFFFFF]
[/COLOR][COLOR=#00bfff]Sincerely,[/COLOR][COLOR=#FFFFFF]

[/COLOR][COLOR=#00bfff][B][I]" + textBox2.Text + @"[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");
        }
        private void button5_Click(object sender, EventArgs e) // Hired
        {
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Carlos S. Borrelli
63rd Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/8Anz9JF.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00BFFF][FONT=&amp][FONT=century gothic]Dear Applicant,


After reviewing your performance during the recruitment drive,[/FONT] [FONT=century gothic]we are pleased to inform you that you have been [/FONT][/FONT][/COLOR][FONT=century gothic][COLOR=#00FF00]ACCEPTED [/COLOR][/FONT][FONT=Century Gothic][COLOR=#00bfff]to join the Los Santos Police Department as a Cadet of the Academy.[/COLOR][/FONT]

[FONT=Century Gothic][COLOR=#00bfff]You have successfully completed the first two steps of the Recruitment Procedure and are now ready to receive a series of trainings to shape you into an Officer of the future.[/COLOR][/FONT]

[FONT=Century Gothic][COLOR=#00bfff]You will now be referred to the training instructors, to learn the essentials of being a Law Enforcement Officer. In these sessions, we expect nothing but your best.[/COLOR][/FONT]
[TABLE=""width: 670, align: center""]
[TR]
[TD][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/320687-Faction-Rules""]Enclosed within - Rules[/URL] |  [URL=""https://forums.hzgaming.net/showthread.php/119591-Felonies-misdemeanors-and-infractions-Laws-Thread""]Enclosed within - State Penal Code[/URL] | [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Enclosed within - Official Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#ffffff][I]Please read through it so that you know how to proceed through and enter the Los Santos Police Department.[/I][/COLOR][/INDENT]


[COLOR=#00bfff][FONT=century gothic]After completing a successful interview, you will be eligible to attend the recruitment drive, about which you'll receive an e-mail soon enough. Failure to attend the interview before the recruitment drive will result in you being put on hold and shifted for the next recruitment drive.[/FONT]
[/COLOR]
[COLOR=#00bfff][FONT=century gothic]Sincerely,

[B][I]" + textBox2.Text+@"[/I]
[/B]Field Training Operations,
Los Santos Police Departmen[/FONT]t[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]



[CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");
        }
        private void button6_Click(object sender, EventArgs e)// Accepted
        {
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Carlos S. Borrelli
63rd Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/alHXmN8.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

We'd like to congratulate you as you have successfully [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]passed [/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]the Officer Introductory Exam (OIE), hence your [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]promotion [/FONT][/COLOR][FONT=Century Gothic][COLOR=#00bfff]to the officer rank has been decided by the leadership staff. Follow these next steps to complete the required document work to register yourself as an official member and to receive the new badge.[/COLOR][/FONT]
[COLOR=#D3D3D3][FONT=Century Gothic]

[LIST][*]Head to the personnel management office and create your personnel profile.[*]Request for a new unused badge number in the personnel management office.[*]A representative from the Leadership Staff will give you the new officer badge.[/LIST]

[COLOR=#00ff00]Welcome to [/COLOR][COLOR=#00bfff]Los Santos Police Department[/COLOR][COLOR=#00ff00] and we wish you the best of luck in your new journey.[/COLOR]
[/FONT][/COLOR][FONT=Century Gothic]
[TABLE=""width: 670, align: center""]
[TR]
[TD][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/320687-Faction-Rules""]Enclosed within - Rules[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/119591-Felonies-misdemeanors-and-infractions-Laws-Thread""]Enclosed within - State Penal Code[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Enclosed within - Official Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#AFEEEE][I]Please read through it so that you know how to proceed through and enter the Los Santos Police Department.[/I][/COLOR][/INDENT]

[COLOR=#00bfff]Sincerely,
[B][I]" + textBox2.Text + @"E[/I]
[/B]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");
        }
        private void button12_Click(object sender, EventArgs e) // Pending Badge
        {
            var text = @"
[TABLE=""class: grid, width: 750, align: center""]
[TR]
[TD][LEFT][COLOR=#FFFFFF][SIZE=1][I][FONT=century gothic]Chief of Police Carlos S. Borrelli
63rd Administration
29/05/2021[/FONT][/I][/SIZE][/COLOR][FONT=century gothic]
[SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Application Response[/FONT][/COLOR][/SIZE][/FONT][/LEFT]
[TABLE=""width: 650, align: center""]
[TR]
[TD][CENTER][FONT=Book Antiqua][IMG]https://i.imgur.com/IBVmDfV.png[/IMG][/FONT][/CENTER]
[/TD]
[TD][/TD]
[/TR]
[/TABLE]
[RIGHT][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][B][COLOR=#2b60de]Los Santos Police Department[/COLOR][/B]
[COLOR=#ffffff][RIGHT]Police Headquarters
Pershing Square
Los Santos, San Andreas[/RIGHT]
[/COLOR][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic]
[/FONT][/SIZE][/COLOR][/RIGHT]
[CENTER][FONT=Century Gothic]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG]
[B][I][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE]
[COLOR=#FFFFFF][SIZE=3][I]Integrity, Courage, & Honor[/I][/SIZE][/COLOR][/I][/B]
[IMG]https://i.imgur.com/3NydTbM.png[/IMG][/FONT][/CENTER]


[TABLE=""width: 650, align: center""]
[TR]
[TD][COLOR=#00bfff][FONT=Century Gothic]Dear Applicant,

We, field training division of the Los Santos Police Department [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]congratulate [/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]you on your [/FONT][/COLOR][COLOR=#00ff00][FONT=Century Gothic]success [/FONT][/COLOR][COLOR=#00bfff][FONT=Century Gothic]in the Interview. Now you must wait for a representative from the top hierarchy team that will be a member of the leadership team, however, to get your badge there must be a field training instructor available to conduct your very first phase, which is the theory training. Follow the following steps to continue in your employment path:
[/FONT][/COLOR][COLOR=#D3D3D3][FONT=Century Gothic]

[LIST][*](( Head to HZRP factions discord - hzgaming.net/factionsdiscord - Stay in the 'lobby' under LSPD category with your nickname set to [P. Badge] First and Lastname.))[*]A representative from the Leadership Staff will give you the cadet badge.[/LIST]
[/FONT][/COLOR][FONT=Century Gothic]

[TABLE=""width: 670, align: center""]
[TR]
[TD][quote]
[FONT=Century Gothic][URL=""https://forums.hzgaming.net/showthread.php/320687-Faction-Rules""]Enclosed within - Rules[/URL][COLOR=#FFFFFF] | [/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/119591-Felonies-misdemeanors-and-infractions-Laws-Thread""]Enclosed within - State Penal Code[/URL] [COLOR=#FFFFFF]|[/COLOR] [URL=""https://forums.hzgaming.net/showthread.php/132851-LSPD-Police-Handbook""]Enclosed within - Official Manual[/URL]
[/FONT][/quote][INDENT][COLOR=#ffffff][I]Please read through it so that you know how to proceed through and enter the Los Santos Police Department.[/I][/COLOR][/INDENT]


[COLOR=#00bfff]Sincerely,[/COLOR]
[B][COLOR=#00bfff][I]" + textBox2.Text + @"[/I][/COLOR][COLOR=#FFFFFF]
[/COLOR][/B][COLOR=#00bfff]Field Training Operations,
Los Santos Police Department[/COLOR]

[SIZE=1][I]ATTN: APPLICANT & CITIZEN OF SAN ANDREAS
SUBJECT: EMPLOYMENT[/I][/SIZE][/TD]
[/TR]
[/TABLE]


[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/FONT][/TD]
[/TR]
[/TABLE]
[FONT=Century Gothic]
[/FONT][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");
        }
        private void button7_Click(object sender, EventArgs e) // Ridealongs - P.Ridealongs 
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic][COLOR=#0066ff][B]LSPD[/B][/COLOR] | Field Training Operations[/FONT][/SIZE][/COLOR]
[TABLE=""width: 500, align: center""]
[TR]
[TD][RIGHT][IMG]https://i.imgur.com/Z7zBNwQ.png[/IMG]
[/RIGHT]
[/TD]
[TD][RIGHT]
[SIZE=2][FONT=Century Gothic][COLOR=#FFFFFF][COLOR=#2B60DE][B]Los Santos Police Department[/B][/COLOR]
Police Headquarters
Pershing Square
Los Santos, San Andreas[/COLOR][/FONT][/SIZE][/RIGHT]
[/TD]
[/TR]
[/TABLE]
[CENTER][IMG]https://i.imgur.com/ysNwX1n.png[/IMG]
[B][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE][/B]
[FONT=Century Gothic][SIZE=5][COLOR=#D3D3D3]POLICE REINSTATEMENT[/COLOR][/SIZE][/FONT]
[IMG]https://i.imgur.com/ysNwX1n.png[/IMG][/CENTER]
[TABLE=""width: 680, align: center""]
[TR]
[TD][RIGHT][FONT=courier new][COLOR=#d3d3d3]Chief of Police Carlos Sage Borrelli[/COLOR][/FONT]
[FONT=courier new][COLOR=#d3d3d3]63rd Administration
30/05/2021[/COLOR][/FONT][/RIGHT]

[COLOR=#e6e6fa]To Whom It May Concern,

[SIZE=3][FONT=Trebuchet MS][B][COLOR=#FFFFFF]LSPD REINSTATEMENT[/COLOR][/B] - [/FONT][/SIZE][/COLOR][SIZE=3][FONT=Trebuchet MS][B][COLOR=#A9A9A9][COLOR=#FFA500]PENDING RIDEALONGS[/COLOR][/COLOR][/B][/FONT][/SIZE][COLOR=#e6e6fa]

You have successfully passed the background stage as we gathered sufficient amount of information. Your reinstatement is now set to pending ridealongs. You are required to finish 3 ridealongs. You are required to contact a [/COLOR][COLOR=#ff8c00][B]Corporal+[/B][/COLOR][COLOR=#e6e6fa] to take your ridealong. You will be tested on your LEO knowledge during this process, by answering important questions. If the ridealongs feedback from our members deem you fit for a reinstatement, you will be directly set to pending leadership review, otherwise your reinstatement will be denied for lacking LEO knowledge. We suggest you to get a load of our handbook to refresh your memory.[/COLOR]
[quote][COLOR=#E6E6FA][FONT=&amp][CENTER][URL=""https://forums.hzgaming.net/showthread.php/423511-LSPD-Reinstatement-Information""]Enclosed within - Reinstatement Information[/URL][/CENTER]
[/FONT][/COLOR][/quote]

[COLOR=#e6e6fa]Sincerely,[/COLOR]
[COLOR=#e6e6fa]Field Training Operations,[/COLOR]
[COLOR=#e6e6fa]Los Santos Police Department[/COLOR][/TD]
[/TR]
[/TABLE]
[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var text = @"
[table=""width: 700, class: grid, align: center""]
[tr]
	[td][COLOR=""#FFFFFF""][SIZE=1][FONT=Century Gothic][color=#0066ff][B]LSPD[/B][/color] | Field Training Operations[/FONT][/SIZE][/COLOR]
[TABLE=""width: 500, align: center""]
[TR]
[TD][RIGHT][IMG]https://i.imgur.com/Z7zBNwQ.png[/IMG]
[/RIGHT]
[/TD]
[TD][RIGHT]
[SIZE=2][FONT=Century Gothic][COLOR=#FFFFFF][COLOR=#2B60DE][B]Los Santos Police Department[/B][/COLOR]
Police Headquarters
Pershing Square
Los Santos, San Andreas[/COLOR][/FONT][/SIZE][/RIGHT]
[/TD]
[/TR]
[/TABLE]
[CENTER][IMG]https://i.imgur.com/ysNwX1n.png[/IMG]
[B][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE][/B]
[FONT=Century Gothic][SIZE=5][COLOR=#D3D3D3]POLICE REINSTATEMENT[/COLOR][/SIZE][/FONT]
[IMG]https://i.imgur.com/ysNwX1n.png[/IMG][/CENTER]
[table=""width: 680, align: center""]
[tr]
	[td][RIGHT][FONT=courier new][COLOR=#d3d3d3]Chief of Police Carlos Sage Borrelli[/COLOR][/FONT]
[FONT=courier new][COLOR=#d3d3d3]63rd Administration
30/05/2021[/COLOR][/FONT][/RIGHT]

[COLOR=#e6e6fa]To Whom It May Concern,

[SIZE=3][FONT=Trebuchet MS][B][COLOR=""#FFFFFF""]LSPD REINSTATEMENT[/COLOR][/B] - [B][COLOR=#00ff00]APPROVED[/COLOR][/B][/FONT][/SIZE]

We are writing a letter to let you know about your application, following a discussion among the leadership team and based on the feedback we got from the command team, we're pleased to offer you employment with the rank of [B][COLOR=#0066ff][" + textBox3.Text + @"][/COLOR][/B] in the Los Santos Police Department. We wish you the best of luck in your new career.

You must now read the following details and complete the tasks mentioned to ensure a successful reinstatement into the LSPD

[LIST][*]Contact any LSPD Leader in order to receive your badge.[*]You have exactly 4 days to get your badge[*](( Apply for the user group after you've been invited. ))[*](( Request for LSPD roles after you've been invited. ))[/LIST]
[quote][FONT=Century Gothic][CENTER][URL=https://forums.hzgaming.net/showthread.php/423511-LSPD-Reinstatement-Information]Enclosed within - Reinstatement Information[/URL][/CENTER][/FONT][/quote]

Sincerely,
Field Training Operations,
Los Santos Police Department
[/COLOR]
[/td]
[/tr]
[/table]
[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR]
[/td]
[/tr]
[/table]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var text = @"
[TABLE=""class: grid, width: 700, align: center""]
[TR]
[TD][COLOR=#FFFFFF][SIZE=1][FONT=Century Gothic][COLOR=#0066ff][B]LSPD[/B][/COLOR] | Field Training Operations[/FONT][/SIZE][/COLOR]
[TABLE=""width: 500, align: center""]
[TR]
[TD][RIGHT][IMG]https://i.imgur.com/Z7zBNwQ.png[/IMG]
[/RIGHT]
[/TD]
[TD][RIGHT]
[SIZE=2][FONT=Century Gothic][COLOR=#FFFFFF][COLOR=#2B60DE][B]Los Santos Police Department[/B][/COLOR]
Police Headquarters
Pershing Square
Los Santos, San Andreas[/COLOR][/FONT][/SIZE][/RIGHT]
[/TD]
[/TR]
[/TABLE]
[CENTER][IMG]https://i.imgur.com/ysNwX1n.png[/IMG]
[B][SIZE=5][COLOR=#2B60DE]LOS SANTOS POLICE DEPARTMENT[/COLOR][/SIZE][/B]
[FONT=Century Gothic][SIZE=5][COLOR=#D3D3D3]POLICE REINSTATEMENT[/COLOR][/SIZE][/FONT]
[IMG]https://i.imgur.com/ysNwX1n.png[/IMG][/CENTER]
[TABLE=""width: 680, align: center""]
[TR]
[td][RIGHT][FONT=courier new][COLOR=#d3d3d3]Chief of Police Carlos Sage Borrelli[/COLOR][/FONT]
[FONT=courier new][COLOR=#d3d3d3]63rd Administration
30/05/2021[/COLOR][/FONT][/RIGHT]

[COLOR=#e6e6fa]To Whom It May Concern,

[SIZE=3][FONT=Trebuchet MS][B][COLOR=#FFFFFF]LSPD REINSTATEMENT[/COLOR][/B] - [/FONT][/SIZE][/COLOR][SIZE=3][FONT=Trebuchet MS][B][COLOR=""#A9A9A9""]PENDING LEADERSHIP REVIEW[/COLOR][/B][/FONT][/SIZE][COLOR=#e6e6fa][SIZE=3][FONT=Trebuchet MS][/FONT][/SIZE]

Your reinstatement is now under review from the [B]LSPD Leadership Team[/B], this is the end of the process and your reinstatement will either be accepted or denied. We'll be evaluating your overall performance while also considering your criminal record and career history. You will hear back shortly on your reinstatement, thank you for your application.

[quote][FONT=Century Gothic][CENTER][URL=""https://forums.hzgaming.net/showthread.php/423511-LSPD-Reinstatement-Information""]Enclosed within - Reinstatement Information[/URL][/CENTER]
[/FONT][/quote]

Sincerely,
Field Training Operations,
Los Santos Police Department
[/COLOR][/TD]
[/TR]
[/TABLE]
[COLOR=#d3d3d3][CENTER][B]AN EQUAL OPPORTUNITY EMPLOYER[/B]
[URL=""https://forums.hzgaming.net/forumdisplay.php/790-Los-Santos-Police-Department-(LSPD)""]www.lspd.gov[/URL]
[URL=""https://forums.hzgaming.net/forumdisplay.php/796-Recruitment-Office""]www.lspd.gov/careers/recruitment-office[/URL][/CENTER]
[/COLOR][/TD]
[/TR]
[/TABLE]
";
            Clipboard.SetText(text.ToString());
            MessageBox.Show("Copied to clipboard!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}