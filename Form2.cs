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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (NameBox.Text.Equals(null) || updateBox.Text.Equals(null) || dateBox.Text.Equals(null) || approvedBox.Text.Equals(null) || addinfoBox.Text.Equals(null))
            {
                MessageBox.Show("Error: You have left one or more required fields empty, make sure to fill them up, if the information is not required, add a -", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string response;
                string name = NameBox.Text;
                string update = updateBox.Text;
                string date = dateBox.Text;
                string approved = approvedBox.Text;
                string addinfo = addinfoBox.Text;
                response = "[table=\"width: 500, class: grid, align: center\"]\n[tr]\n[td][SIZE=1][COLOR=#FFFFFF][FONT=Century Gothic][B][COLOR=#2B60DE]LSPD[/COLOR] |[/B] Personnel Profile Update[/FONT][/COLOR][/SIZE]\n[table=\"width: 500, align: center\"]\n[tr]\n[td][RIGHT][img]https://i.imgur.com/AVSucUE.png [/img][/RIGHT][/td] \n[td]\n \n [LEFT][SIZE=5][COLOR=#FFFFFF][FONT=Century Gothic]LOS SANTOS[/FONT][/COLOR]\n [COLOR=#2B60DE][B]POLICE DEPARTMENT[/B][/COLOR][/SIZE]\n[SIZE=1][FONT=Century Gothic][COLOR=#FFFFFF][I]Integrity, Courage, & Honor[/I][/COLOR][/FONT][/SIZE][/LEFT][/td]\n[/tr]\n[/table]\n [table=\"width: 490, align: center\"]\n[tr]\n[td][COLOR=#2B60DE][B]Name[/B]:[/COLOR] [COLOR=#D3D3D3]" + name + "[/COLOR]\n\n[COLOR=#2B60DE][B]Updated Information[/B]:[/COLOR] [COLOR=#D3D3D3]" + update + "[/COLOR]\n\n[COLOR=#2B60DE][B]Date Updated[/B]:[/COLOR] [COLOR=#D3D3D3]" + date + "[/COLOR]\n\n[COLOR=#2B60DE][B]Approved By[/B]:[/COLOR] [COLOR=#D3D3D3]" + approved + "[/COLOR]\n\n[COLOR=#2B60DE][B]Additional Details[/B]:[/COLOR] [COLOR=#D3D3D3]" + addinfo + "[/COLOR][/td]\n\n [/tr]\n [/table]\n[RIGHT][SIZE=2][/SIZE][COLOR=#D3D3D3][FONT=century gothic][SIZE=1][COLOR=#ffffff]Chief of Police Carlos S. Borrelli\n[FONT=century gothic][SIZE=1][COLOR=#ffffff]63rd Administration\n29/05/2021[/COLOR][/SIZE][/FONT][/COLOR][/SIZE][/FONT][/COLOR][/RIGHT]\n[/td]\n[/tr]\n[/table]";
                Clipboard.SetText(response);
                MessageBox.Show("The code has been successfully copied to the clipboard.");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1keuCx2liT3fDd-zhHkZc-d0eD7CMHUNB1EkwM4BZk1Q/edit#gid=0");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forums.hzgaming.net/showthread.php/473156-LSPD-Department-Roster-(Make-Edits)");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forums.hzgaming.net/showthread.php/474994-LSPD-LOA-Roster-amp-Information");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + name + "[/B][/COLOR] has been [COLOR=#00FF00][B]promoted[/B][/COLOR] to [B]" + rankBox.Text + "[/B].";
            Clipboard.SetText(response);
            MessageBox.Show("The code has been successfully copied to the clipboard.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string response = "[B]" + dateBox.Text + "[/B], [COLOR =#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has been [B]demoted[/B] to [B]" + rankBox.Text + "[/B]";
            Clipboard.SetText(response);
            MessageBox.Show("The code has been successfully copied to the clipboard.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string response = "[B]" + dateBox.Text + "[/B], [COLOR =#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has been [B]terminated[/B] from the department. ";
            Clipboard.SetText(response);
            MessageBox.Show("The code has been successfully copied to the clipboard.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string response = "[B]" + dateBox.Text + "[/B], [COLOR =#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has [B]stepped down[/B] to [B]" + rankBox.Text + "[/B]";
            Clipboard.SetText(response);
            MessageBox.Show("The code has been successfully copied to the clipboard.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string response;
            string rank = rankBox.Text.ToLower();
            if (rank == "officer")
            {
                response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has [b]reinstated[/b] as an [B]Officer[/B]";
            }
            else
            {
                response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has [b]reinstated[/b] as a [B]" + rankBox.Text + "[/B]";
            }
            Clipboard.SetText(response);
            MessageBox.Show("The code has been successfully copied to the clipboard.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has been appointed as the [B]" + divisionBox.Text + " Supervisor[/B]";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string nicemove = addinfoBox.Text.ToLower();
                string response = null;
                if (nicemove.Contains("assistant"))
                {
                    response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has been appointed as the[B] Assistant Commander [/B]of the [B]" + divisionBox.Text + "[/B]";
                }
                else if (nicemove.Contains("acting"))
                {
                    response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has been appointed as the[B] Acting Assistant Commander [/B]of the [B]" + divisionBox.Text + "[/B]";
                }
                else if (nicemove.Contains("commander") && !nicemove.Contains("assistant"))
                {
                    response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has been appointed as the[B] Commander [/B]of the [B]" + divisionBox.Text + "[/B]";
                }
                else
                {
                    response = "[B]" + dateBox.Text + "[/B], [COLOR=#2B60DE][B]" + NameBox.Text + "[/B][/COLOR] has been appointed as the[B] Acting / Assistant / Commander [/B]of the [B]" + divisionBox.Text + "[/B]";
                }
                Clipboard.SetText(response);
                MessageBox.Show("The code has been successfully copied to the clipboard.");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            string task = "**Task Done: **" + updateBox.Text + "\n **Message Link: **" + msgLink.Text + "\n" + "**Personnel Profile: **" + PP.Text + "\n**Badge Tracker:** https://docs.google.com/spreadsheets/d/1keuCx2liT3fDd-zhHkZc-d0eD7CMHUNB1EkwM4BZk1Q/edit#gid=0 \n**Department Roster: ** https://forums.hzgaming.net/showthread.php/473156-LSPD-Department-Roster-(Make-Edits) \n**LOA Roster: ** https://forums.hzgaming.net/showthread.php/474994-LSPD-LOA-Roster-amp-Information";
            Clipboard.SetText(task);
            MessageBox.Show("The code has been successfully copied to the clipboard.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Names = new string[]
    {
    "Afghanistan",
    "Albania",
    "Algeria",
    "American Samoa",
    "Andorra",
    "Angola",
    "Anguilla",
    "Antarctica",
    "Antigua and Barbuda",
    "Argentina",
    "Armenia",
    "Aruba",
    "Australia",
    "Austria",
    "Azerbaijan",
    "Bahamas",
    "Bahrain",
    "Bangladesh",
    "Barbados",
    "Belarus",
    "Belgium",
    "Belize",
    "Benin",
    "Bermuda",
    "Bhutan",
    "Bolivia",
    "Bosnia and Herzegovina",
    "Botswana",
    "Bouvet Island",
    "Brazil",
    "British Indian Ocean Territory",
    "Brunei Darussalam",
    "Bulgaria",
    "Burkina Faso",
    "Burundi",
    "Cambodia",
    "Cameroon",
    "Canada",
    "Cape Verde",
    "Cayman Islands",
    "Central African Republic",
    "Chad",
    "Chile",
    "China",
    "Christmas Island",
    "Cocos (Keeling) Islands",
    "Colombia",
    "Comoros",
    "Congo",
    "Congo, the Democratic Republic of the",
    "Cook Islands",
    "Costa Rica",
    "Cote D'Ivoire",
    "Croatia",
    "Cuba",
    "Cyprus",
    "Czech Republic",
    "Denmark",
    "Djibouti",
    "Dominica",
    "Dominican Republic",
    "Ecuador",
    "Egypt",
    "El Salvador",
    "Equatorial Guinea",
    "Eritrea",
    "Estonia",
    "Ethiopia",
    "Falkland Islands (Malvinas)",
    "Faroe Islands",
    "Fiji",
    "Finland",
    "France",
    "French Guiana",
    "French Polynesia",
    "French Southern Territories",
    "Gabon",
    "Gambia",
    "Georgia",
    "Germany",
    "Ghana",
    "Gibraltar",
    "Greece",
    "Greenland",
    "Grenada",
    "Guadeloupe",
    "Guam",
    "Guatemala",
    "Guinea",
    "Guinea-Bissau",
    "Guyana",
    "Haiti",
    "Heard Island and Mcdonald Islands",
    "Holy See (Vatican City State)",
    "Honduras",
    "Hong Kong",
    "Hungary",
    "Iceland",
    "India",
    "Indonesia",
    "Iran, Islamic Republic of",
    "Iraq",
    "Ireland",
    "Israel",
    "Italy",
    "Jamaica",
    "Japan",
    "Jordan",
    "Kazakhstan",
    "Kenya",
    "Kiribati",
    "Korea, Democratic People's Republic of",
    "Korea, Republic of",
    "Kuwait",
    "Kyrgyzstan",
    "Lao People's Democratic Republic",
    "Latvia",
    "Lebanon",
    "Lesotho",
    "Liberia",
    "Libyan Arab Jamahiriya",
    "Liechtenstein",
    "Lithuania",
    "Luxembourg",
    "Macao",
    "Macedonia, the Former Yugoslav Republic of",
    "Madagascar",
    "Malawi",
    "Malaysia",
    "Maldives",
    "Mali",
    "Malta",
    "Marshall Islands",
    "Martinique",
    "Mauritania",
    "Mauritius",
    "Mayotte",
    "Mexico",
    "Micronesia, Federated States of",
    "Moldova, Republic of",
    "Monaco",
    "Mongolia",
    "Montserrat",
    "Morocco",
    "Mozambique",
    "Myanmar",
    "Namibia",
    "Nauru",
    "Nepal",
    "Netherlands",
    "Netherlands Antilles",
    "New Caledonia",
    "New Zealand",
    "Nicaragua",
    "Niger",
    "Nigeria",
    "Niue",
    "Norfolk Island",
    "Northern Mariana Islands",
    "Norway",
    "Oman",
    "Pakistan",
    "Palau",
    "Palestinian Territory, Occupied",
    "Panama",
    "Papua New Guinea",
    "Paraguay",
    "Peru",
    "Philippines",
    "Pitcairn",
    "Poland",
    "Portugal",
    "Puerto Rico",
    "Qatar",
    "Reunion",
    "Romania",
    "Russian Federation",
    "Rwanda",
    "Saint Helena",
    "Saint Kitts and Nevis",
    "Saint Lucia",
    "Saint Pierre and Miquelon",
    "Saint Vincent and the Grenadines",
    "Samoa",
    "San Marino",
    "Sao Tome and Principe",
    "Saudi Arabia",
    "Senegal",
    "Serbia and Montenegro",
    "Seychelles",
    "Sierra Leone",
    "Singapore",
    "Slovakia",
    "Slovenia",
    "Solomon Islands",
    "Somalia",
    "South Africa",
    "South Georgia and the South Sandwich Islands",
    "Spain",
    "Sri Lanka",
    "Sudan",
    "Suriname",
    "Svalbard and Jan Mayen",
    "Swaziland",
    "Sweden",
    "Switzerland",
    "Syrian Arab Republic",
    "Taiwan, Province of China",
    "Tajikistan",
    "Tanzania, United Republic of",
    "Thailand",
    "Timor-Leste",
    "Togo",
    "Tokelau",
    "Tonga",
    "Trinidad and Tobago",
    "Tunisia",
    "Turkey",
    "Turkmenistan",
    "Turks and Caicos Islands",
    "Tuvalu",
    "Uganda",
    "Ukraine",
    "United Arab Emirates",
    "United Kingdom",
    "United States",
    "United States Minor Outlying Islands",
    "Uruguay",
    "Uzbekistan",
    "Vanuatu",
    "Venezuela",
    "Viet Nam",
    "Virgin Islands, British",
    "Virgin Islands, US",
    "Wallis and Futuna",
    "Western Sahara",
    "Yemen",
    "Zambia",
    "Zimbabwe",
    };
            string[] Codes = new string[]
    {
    "AF",
    "AL",
    "DZ",
    "AS",
    "AD",
    "AO",
    "AI",
    "AQ",
    "AG",
    "AR",
    "AM",
    "AW",
    "AU",
    "AT",
    "AZ",
    "BS",
    "BH",
    "BD",
    "BB",
    "BY",
    "BE",
    "BZ",
    "BJ",
    "BM",
    "BT",
    "BO",
    "BA",
    "BW",
    "BV",
    "BR",
    "IO",
    "BN",
    "BG",
    "BF",
    "BI",
    "KH",
    "CM",
    "CA",
    "CV",
    "KY",
    "CF",
    "TD",
    "CL",
    "CN",
    "CX",
    "CC",
    "CO",
    "KM",
    "CG",
    "CD",
    "CK",
    "CR",
    "CI",
    "HR",
    "CU",
    "CY",
    "CZ",
    "DK",
    "DJ",
    "DM",
    "DO",
    "EC",
    "EG",
    "SV",
    "GQ",
    "ER",
    "EE",
    "ET",
    "FK",
    "FO",
    "FJ",
    "FI",
    "FR",
    "GF",
    "PF",
    "TF",
    "GA",
    "GM",
    "GE",
    "DE",
    "GH",
    "GI",
    "GR",
    "GL",
    "GD",
    "GP",
    "GU",
    "GT",
    "GN",
    "GW",
    "GY",
    "HT",
    "HM",
    "VA",
    "HN",
    "HK",
    "HU",
    "IS",
    "IN",
    "ID",
    "IR",
    "IQ",
    "IE",
    "IL",
    "IT",
    "JM",
    "JP",
    "JO",
    "KZ",
    "KE",
    "KI",
    "KP",
    "KR",
    "KW",
    "KG",
    "LA",
    "LV",
    "LB",
    "LS",
    "LR",
    "LY",
    "LI",
    "LT",
    "LU",
    "MO",
    "MK",
    "MG",
    "MW",
    "MY",
    "MV",
    "ML",
    "MT",
    "MH",
    "MQ",
    "MR",
    "MU",
    "YT",
    "MX",
    "FM",
    "MD",
    "MC",
    "MN",
    "MS",
    "MA",
    "MZ",
    "MM",
    "NA",
    "NR",
    "NP",
    "NL",
    "AN",
    "NC",
    "NZ",
    "NI",
    "NE",
    "NG",
    "NU",
    "NF",
    "MP",
    "NO",
    "OM",
    "PK",
    "PW",
    "PS",
    "PA",
    "PG",
    "PY",
    "PE",
    "PH",
    "PN",
    "PL",
    "PT",
    "PR",
    "QA",
    "RE",
    "RO",
    "RU",
    "RW",
    "SH",
    "KN",
    "LC",
    "PM",
    "VC",
    "WS",
    "SM",
    "ST",
    "SA",
    "SN",
    "CS",
    "SC",
    "SL",
    "SG",
    "SK",
    "SI",
    "SB",
    "SO",
    "ZA",
    "GS",
    "ES",
    "LK",
    "SD",
    "SR",
    "SJ",
    "SZ",
    "SE",
    "CH",
    "SY",
    "TW",
    "TJ",
    "TZ",
    "TH",
    "TL",
    "TG",
    "TK",
    "TO",
    "TT",
    "TN",
    "TR",
    "TM",
    "TC",
    "TV",
    "UG",
    "UA",
    "AE",
    "GB",
    "US",
    "UM",
    "UY",
    "UZ",
    "VU",
    "VE",
    "VN",
    "VG",
    "VI",
    "WF",
    "EH",
    "YE",
    "ZM",
    "ZW"
    };      string country = cntryBox.Text.ToLower();
            string cc = null;

            for (int i = 0; i < Names.Length; i++)
            {

                Names[i] = Names[i].ToLower();

                if (Names[i] == country)
                {
                    cc = Codes[i];
                }
                else if (i == 239 && Names[i] != country)
                {
                    MessageBox.Show("Country not found");
                    cc = "xx";
                }
            }
            cc.ToLower();
            string response = "[IMG]https://forums.hzgaming.net/images/flags/" + cc + ".png[/IMG] [B][COLOR=#2B60DE]" + NameBox.Text + "[/COLOR][/B] - [FONT=century gothic][COLOR=#FFFFFF]" + divisionBox.Text + "[/COLOR][/FONT]";
            Clipboard.SetText(response);
            MessageBox.Show("Copied to clipboard!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("[B]" + dateBox.Text + "[/B], [B]" + NameBox.Text + "[/B] has[B]resigned[/B] from the department.");
            MessageBox.Show("Copied to clipboard!");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string response = "[TR]\n[TD]" + NameBox.Text + "[/TD]\n[TD]" + dateBox.Text + "[/TD]\n[TD]" + returnBox.Text + "[/TD]\n[TD][URL=" + loaBox.Text + "]**Attachment**[/URL][/TD]\n[TD]" + loareason.Text + "[/TD]\n[/TR]";
            Clipboard.SetText(response);
            MessageBox.Show("Copied to clipboard!");
        }
    }
}




