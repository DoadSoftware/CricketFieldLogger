using CricketFieldLogger.Helper;
using CricketFieldLogger.Model;
using Newtonsoft.Json;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;
using Newtonsoft.Json.Linq;
using System.Media;

namespace CricketFieldLogger
{
    public partial class FieldLoggerFrm : Form
    {     
        string which_btn = "",style = "";
        public int player_id=-1;
        public FieldersData fieldersData = new FieldersData(true, "RHB", new List<FieldersFormation>());

        public FieldLoggerFrm()
        {
            InitializeComponent();
            fieldersData.Style = "RHB";
            fieldersData.BowlingEnd = "Near";
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                ControlMover.Init(this.FielderLbl[i]);
            }
        }
        private void FielderLbl_Move(object sender, EventArgs e)
        {
            fieldersData.Fielders = new List<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                FielderLbl[i].BackColor = Color.White;
                FielderLbl[i].ForeColor = Color.Black;
                if (fieldersData.BowlingEnd == "Far")
                {
                    fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: 522 - FielderLbl[i].Left, topLocation: 522 - FielderLbl[i].Top, fielderhighlight: "NO"));

                }
                else
                {
                    fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));

                }

            }
            if (checkBox2.Checked)
            {
                fieldersData.Checkbox = true;
                SaveFile();
            }
        }

        private void Seamer_Six_By_Four_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Six_By_Four";
            fieldersData.Style = "RHB";
            label3.Text = "RHB";
            style = "RHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.Green;
            Six_By_Three_lbh_btn.BackColor = Color.LightGray;
            Seven_By_Two_lbh_btn.BackColor = Color.LightGray;
            Five_By_Four_lbh_btn.BackColor = Color.LightGray;
            Six_By_Four_lbh_btn.BackColor = Color.LightGray;
            HashSet<FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 237;
                        FielderLbl[i].Top = 204;
                        break;
                    case 2:
                        FielderLbl[i].Left = 219;
                        FielderLbl[i].Top = 214;
                        break;
                    case 3:
                        FielderLbl[i].Left = 166;
                        FielderLbl[i].Top = 85;
                        break;
                    case 4:
                        FielderLbl[i].Left = 185;
                        FielderLbl[i].Top = 190;
                        break;
                    case 5:
                        FielderLbl[i].Left = 175;
                        FielderLbl[i].Top = 230;
                        break;
                    case 6:
                        FielderLbl[i].Left = 186;
                        FielderLbl[i].Top = 278;
                        break;
                    case 7:
                        FielderLbl[i].Left = 351;
                        FielderLbl[i].Top = 220;
                        break;
                    case 8:
                        FielderLbl[i].Left = 355;
                        FielderLbl[i].Top = 78;
                        break;
                    case 9:
                        FielderLbl[i].Left = 336;
                        FielderLbl[i].Top = 350;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
            }
            fieldersData.Fielders = new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }
        private void Seamer_Five_By_Four_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Five_By_Four";
            fieldersData.Style = "RHB";
            label3.Text = "RHB";
            style = "RHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.Green;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            Six_By_Three_lbh_btn.BackColor = Color.LightGray;
            Seven_By_Two_lbh_btn.BackColor = Color.LightGray;
            Five_By_Four_lbh_btn.BackColor = Color.LightGray;
            Six_By_Four_lbh_btn.BackColor = Color.LightGray;
            /*if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }
*/
            HashSet<FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            //fieldersFormation.Clear();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                System.Diagnostics.Debug.WriteLine("i = " + i);
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 241;
                        FielderLbl[i].Top = 186;
                        break;
                    case 2:
                        FielderLbl[i].Left = 190;
                        FielderLbl[i].Top = 226;
                        break;
                    case 3:
                        FielderLbl[i].Left = 191;
                        FielderLbl[i].Top = 271;
                        break;
                    case 4:
                        FielderLbl[i].Left = 200;
                        FielderLbl[i].Top = 291;
                        break;
                    case 5:
                        FielderLbl[i].Left = 207;
                        FielderLbl[i].Top = 459;
                        break;
                    case 6:
                        FielderLbl[i].Left = 299;
                        FielderLbl[i].Top = 368;
                        break;
                    case 7:
                        FielderLbl[i].Left = 331;
                        FielderLbl[i].Top = 239;
                        break;
                    case 8:
                        FielderLbl[i].Left = 454;
                        FielderLbl[i].Top = 227;
                        break;
                    case 9:
                        FielderLbl[i].Left = 323;
                        FielderLbl[i].Top = 167;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                //fieldersFormation.Clear();
                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                System.Diagnostics.Debug.WriteLine("size (5-4) = " + fieldersData.Fielders.Count);

            }
            fieldersData.Fielders = new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }
        private void Seamer_Seven_By_Two_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Seven_By_Two";
            fieldersData.Style = "RHB";
            label3.Text = "RHB";
            style = "RHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.Green;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            Six_By_Three_lbh_btn.BackColor = Color.LightGray;
            Seven_By_Two_lbh_btn.BackColor = Color.LightGray;
            Five_By_Four_lbh_btn.BackColor = Color.LightGray;
            Six_By_Four_lbh_btn.BackColor = Color.LightGray;
            HashSet<FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                System.Diagnostics.Debug.WriteLine("i = " + i);
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 337;
                        FielderLbl[i].Top = 232;
                        break;
                    case 2:
                        FielderLbl[i].Left = 318;
                        FielderLbl[i].Top = 374;
                        break;
                    case 3:
                        FielderLbl[i].Left = 206;
                        FielderLbl[i].Top = 365;
                        break;
                    case 4:
                        FielderLbl[i].Left = 174;
                        FielderLbl[i].Top = 297;
                        break;
                    case 5:
                        FielderLbl[i].Left = 173;
                        FielderLbl[i].Top = 226;
                        break;
                    case 6:
                        FielderLbl[i].Left = 198;
                        FielderLbl[i].Top = 172;
                        break;
                    case 7:
                        FielderLbl[i].Left = 83;
                        FielderLbl[i].Top = 178;
                        break;
                    case 8:
                        FielderLbl[i].Left = 66;
                        FielderLbl[i].Top = 297;
                        break;
                    case 9:
                        FielderLbl[i].Left = 108;
                        FielderLbl[i].Top = 395;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                System.Diagnostics.Debug.WriteLine("size (7-2)= " + fieldersData.Fielders.Count);
            }
            fieldersData.Fielders = new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }
        private void Spinner_Six_By_Three_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Spinner_Six_By_Three";
            fieldersData.Style = "RHB";
            label3.Text = "RHB";
            style = "RHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
            Spinner_Six_By_Three_btn.BackColor = Color.Green;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            Six_By_Three_lbh_btn.BackColor = Color.LightGray;
            Seven_By_Two_lbh_btn.BackColor = Color.LightGray;
            Five_By_Four_lbh_btn.BackColor = Color.LightGray;
            Six_By_Four_lbh_btn.BackColor = Color.LightGray;
            if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }
            HashSet<FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 237;
                        FielderLbl[i].Top = 204;
                        break;
                    case 2:
                        FielderLbl[i].Left = 219;
                        FielderLbl[i].Top = 214;
                        break;
                    case 3:
                        FielderLbl[i].Left = 184;
                        FielderLbl[i].Top = 91;
                        break;
                    case 4:
                        FielderLbl[i].Left = 185;
                        FielderLbl[i].Top = 190;
                        break;
                    case 5:
                        FielderLbl[i].Left = 190;
                        FielderLbl[i].Top = 230;
                        break;
                    case 6:
                        FielderLbl[i].Left = 217;
                        FielderLbl[i].Top = 270;
                        break;
                    case 7:
                        FielderLbl[i].Left = 325;
                        FielderLbl[i].Top = 220;
                        break;
                    case 8:
                        FielderLbl[i].Left = 350;
                        FielderLbl[i].Top = 86;
                        break;
                    case 9:
                        FielderLbl[i].Left = 318;
                        FielderLbl[i].Top = 323;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }

                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
            }
            fieldersData.Fielders = new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }

        private void Six_By_Four_lbh_btn_click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Six_By_Four";
            fieldersData.Style = "LBH";
            label3.Text = "LHB";
            style = "LHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
            Six_By_Three_lbh_btn.BackColor = Color.LightGray;
            Seven_By_Two_lbh_btn.BackColor = Color.LightGray;
            Five_By_Four_lbh_btn.BackColor = Color.LightGray;
            Six_By_Four_lbh_btn.BackColor = Color.Green;
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
           HashSet< FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 285;
                        FielderLbl[i].Top = 204;
                        break;
                    case 2:
                        FielderLbl[i].Left = 303;
                        FielderLbl[i].Top = 214;
                        break;
                    case 3:
                        FielderLbl[i].Left = 356;
                        FielderLbl[i].Top = 85;
                        break;
                    case 4:
                        FielderLbl[i].Left = 337;
                        FielderLbl[i].Top = 190;
                        break;
                    case 5:
                        FielderLbl[i].Left = 347;
                        FielderLbl[i].Top = 230;
                        break;
                    case 6:
                        FielderLbl[i].Left = 336;
                        FielderLbl[i].Top = 278;
                        break;
                    case 7:
                        FielderLbl[i].Left = 171;
                        FielderLbl[i].Top = 220;
                        break;
                    case 8:
                        FielderLbl[i].Left = 167;
                        FielderLbl[i].Top = 78;
                        break;
                    case 9:
                        FielderLbl[i].Left = 186;
                        FielderLbl[i].Top = 350;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
            }
            fieldersData.Fielders = new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }
        private void Six_By_Three_lbh_btn_click(object sender, EventArgs e)
        {
            which_btn = "Spinner_Six_By_Three";
            fieldersData.Style = "LHB";
            label3.Text = "LHB";
            style = "LHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
            Six_By_Three_lbh_btn.BackColor = Color.Green;
            Seven_By_Two_lbh_btn.BackColor = Color.LightGray;
            Five_By_Four_lbh_btn.BackColor = Color.LightGray;
            Six_By_Four_lbh_btn.BackColor = Color.LightGray;
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }
           HashSet<FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 285;
                        FielderLbl[i].Top = 204;
                        break;
                    case 2:
                        FielderLbl[i].Left = 303;
                        FielderLbl[i].Top = 214;
                        break;
                    case 3:
                        FielderLbl[i].Left = 338;
                        FielderLbl[i].Top = 91;
                        break;
                    case 4:
                        FielderLbl[i].Left = 337;
                        FielderLbl[i].Top = 190;
                        break;
                    case 5:
                        FielderLbl[i].Left = 332;
                        FielderLbl[i].Top = 230;
                        break;
                    case 6:
                        FielderLbl[i].Left = 305;
                        FielderLbl[i].Top = 270;
                        break;
                    case 7:
                        FielderLbl[i].Left = 197;
                        FielderLbl[i].Top = 220;
                        break;
                    case 8:
                        FielderLbl[i].Left = 172;
                        FielderLbl[i].Top = 86;
                        break;
                    case 9:
                        FielderLbl[i].Left = 204;
                        FielderLbl[i].Top = 323;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }

                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
            }
            fieldersData.Fielders= new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }
        private void Five_By_Four_lbh_btn_click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Five_By_Four";
            fieldersData.Style = "LHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
            Six_By_Three_lbh_btn.BackColor = Color.LightGray;
            Seven_By_Two_lbh_btn.BackColor = Color.LightGray;
            Five_By_Four_lbh_btn.BackColor = Color.Green;
            Six_By_Four_lbh_btn.BackColor = Color.LightGray;
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }

            HashSet<FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            //fieldersFormation.Clear();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                System.Diagnostics.Debug.WriteLine("i = " + i);
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 281;
                        FielderLbl[i].Top = 186;
                        break;
                    case 2:
                        FielderLbl[i].Left = 332;
                        FielderLbl[i].Top = 226;
                        break;
                    case 3:
                        FielderLbl[i].Left = 331;
                        FielderLbl[i].Top = 271;
                        break;
                    case 4:
                        FielderLbl[i].Left = 322;
                        FielderLbl[i].Top = 291;
                        break;
                    case 5:
                        FielderLbl[i].Left = 315;
                        FielderLbl[i].Top = 459;
                        break;
                    case 6:
                        FielderLbl[i].Left = 223;
                        FielderLbl[i].Top = 368;
                        break;
                    case 7:
                        FielderLbl[i].Left = 191;
                        FielderLbl[i].Top = 239;
                        break;
                    case 8:
                        FielderLbl[i].Left = 68;
                        FielderLbl[i].Top = 227;
                        break;
                    case 9:
                        FielderLbl[i].Left = 199;
                        FielderLbl[i].Top = 167;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                //fieldersFormation.Clear();
                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                System.Diagnostics.Debug.WriteLine("size (5-4) = " + fieldersData.Fielders.Count);
            }
            fieldersData.Fielders = new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }
        private void Seven_By_Two_lbh_btn_click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Seven_By_Two";
            fieldersData.Style = "LHB";
            label3.Text = "LHB";
            style = "LHB";
            comboBox.SelectedItem = "Near";
            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
            Six_By_Three_lbh_btn.BackColor = Color.LightGray;
            Seven_By_Two_lbh_btn.BackColor = Color.Green;
            Five_By_Four_lbh_btn.BackColor = Color.LightGray;
            Six_By_Four_lbh_btn.BackColor = Color.LightGray;
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }
           HashSet<FieldersFormation> uniqueFielders = new HashSet<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                System.Diagnostics.Debug.WriteLine("i = " + i);
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 185;
                        FielderLbl[i].Top = 232;
                        break;
                    case 2:
                        FielderLbl[i].Left = 204;
                        FielderLbl[i].Top = 374;
                        break;
                    case 3:
                        FielderLbl[i].Left = 316;
                        FielderLbl[i].Top = 365;
                        break;
                    case 4:
                        FielderLbl[i].Left = 348;
                        FielderLbl[i].Top = 297;
                        break;
                    case 5:
                        FielderLbl[i].Left = 349;
                        FielderLbl[i].Top = 226;
                        break;
                    case 6:
                        FielderLbl[i].Left = 324;
                        FielderLbl[i].Top = 172;
                        break;
                    case 7:
                        FielderLbl[i].Left = 439;
                        FielderLbl[i].Top = 178;
                        break;
                    case 8:
                        FielderLbl[i].Left = 456;
                        FielderLbl[i].Top = 297;
                        break;
                    case 9:
                        FielderLbl[i].Left = 414;
                        FielderLbl[i].Top = 395;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                uniqueFielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                System.Diagnostics.Debug.WriteLine("size (7-2)= " + fieldersData.Fielders.Count);
            }
            fieldersData.Fielders = new List<FieldersFormation>(uniqueFielders);
            SaveFile();
        }

        private void Swap_Click(object sender, EventArgs e)
        {
            if (File.Exists(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File))

            {
                if (fieldersData.Style == "LHB")
                {

                    fieldersData.Style = "RHB";
                    label3.Text= "RHB";
                    FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
                }
                else                 {
                    fieldersData.Style = "LHB";
                    label3.Text= "LHB";
                    FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
                }
                // Serialize and save the current fieldersData
                File.WriteAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File, JsonConvert.SerializeObject(fieldersData));

                // Initialize the fieldersData from the saved JSON
                using (StreamReader r = new StreamReader(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File))
                {
                    string jsonstring = r.ReadToEnd();
                    fieldersData = JsonConvert.DeserializeObject<FieldersData>(jsonstring);
                }

                if (fieldersData != null)
                {
                    for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                FielderLbl[i].Left = fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 1:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 2:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 3:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 4:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 5:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 6:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 7:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 8:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 9:
                                FielderLbl[i].Left = 522 - fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                            case 10:
                                FielderLbl[i].Left = fieldersData.Fielders[i].leftLocation;
                                FielderLbl[i].Top = fieldersData.Fielders[i].topLocation;
                                break;
                        }
                        // Serialize the updated data back to JSON
                        string updatedJsonData = JsonConvert.SerializeObject(fieldersData, Formatting.Indented);

                        // Write the updated JSON data back to the file
                        File.WriteAllText(FieldLoggerConstants.Cricket_Directory+
                            FieldLoggerConstants.Field_Formation_File, updatedJsonData);
                }   }
            }
        }
        private void Page_1_btn_Click(object sender, EventArgs e)
        {
            new Page1Frm().Show();
        }
        private void Page_2_btn_Click(object sender, EventArgs e)
        {
            new Page2Frm().Show();
        }
        private void Page_3_btn_Click(object sender, EventArgs e)
        {
            new Page3Frm().Show();
        }
        private void Page_4_btn_Click(object sender, EventArgs e)
        {
            new Page4Frm().Show();
        }

        //textbox_Click
        private void textbox_Click(object sender, EventArgs e)
        {
            string ipAddress = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(ipAddress) && !ipAddress.Equals("localhost", StringComparison.OrdinalIgnoreCase))
            {
                FieldLoggerConstants.Cricket_Directory = "\\\\" + ipAddress + "\\c\\Sports\\Cricket\\Fielder\\";
                textBox2.BackColor = Color.LightGreen; 
                textBox2.ForeColor = Color.Black;
                textBox2.Text = ipAddress;
                textBox2.Font = new Font(textBox2.Font.FontFamily, textBox2.Font.Size + 2, FontStyle.Regular);

                MessageBox.Show("Successfully connected to "+ FieldLoggerConstants.Cricket_Directory);
            }
            SaveFile();
        }
        void SetValue(string value)
        {
            if (fieldersData.BowlingEnd != value)
            {
                fieldersData.BowlingEnd = value;
            }

            string filePath = FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File;

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    JObject obj = JObject.Parse(jsonString);

                    FieldLoggerConstants.BowlingEnd = value;

                    if (fieldersData.BowlingEnd == "Far")
                    {
                        string battingStyle = (string)obj["style"];
                        if (battingStyle == "LHB")
                        {
                            label3.Text = "RHB";
                            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
                        }
                        else if (battingStyle == "RHB")
                        {
                            label3.Text = "LHB";
                            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
                        }
                    }
                    else
                    {
                        if ((string)obj["style"] == "LHB")
                        {
                            // Load the first image
                            label3.Text = "LHB";
                            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
                        }
                        else if ((string)obj["style"] == "RHB")
                        {
                            label3.Text = "RHB";
                            // Load the second image
                            FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
                        }

                    }

                    for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                    {
                        try
                        {
                            int leftLocation = int.Parse((string)obj["fielders"][i]["leftLocation"]);
                            int topLocation = int.Parse((string)obj["fielders"][i]["topLocation"]);

                            if (fieldersData.BowlingEnd == "Far")
                            {
                                FielderLbl[i].Location = new Point(522 - leftLocation, 522 - topLocation);
                            }
                            else
                            {
                                FielderLbl[i].Location = new Point(leftLocation, topLocation);
                            }
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show($"Format error for fielder {i + 1}: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error for fielder {i + 1}: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while processing the file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }
        private void textbox_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))
            {
                String[] substrings = textBox1.Text.Split(',');

                var stringNumber = substrings[substrings.Length - 1];
                int numericValue;
                bool isNumber = int.TryParse(stringNumber, out numericValue);
                if (isNumber == true)
                {
                }
                else
                {
                    if (substrings[substrings.Length - 1] == "," || substrings[substrings.Length - 1] == "")
                    {
                    }
                    else
                    {
                        MessageBox.Show("Input Value is String");
                        textBox1.Text = "";
                    }
                }
            }
            else
            {
                var stringNumber = textBox1.Text;
                int numericValue;
                bool isNumber = int.TryParse(stringNumber, out numericValue);
                if (isNumber == true)
                {
                }
                else
                {
                    if (stringNumber == "," || stringNumber == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("Input Value is String");
                        textBox1.Text = "";
                    }
                }
            }

        }
        private void checkbox2_btn_Click(object sender, EventArgs e)
        {

            FieldersData existingData = JsonConvert.DeserializeObject<FieldersData>(
                File.ReadAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File));

            if (checkBox2.Checked)
            {

                existingData.Checkbox = true;
            }
            else
            {
                existingData.Checkbox = false;
            }
            File.WriteAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File, JsonConvert.SerializeObject(existingData));

            string filePath = @"" + FieldLoggerConstants.Cricket_Directory + "Fielder_Text\\FieldPlotter.txt";  // Replace this with the desired file path
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
               
                if (lines.Length >=2)
                {
                    // If the lines at specified indexes are empty or if the file is empty, write the lines
                    if (string.IsNullOrWhiteSpace(lines[0]) && string.IsNullOrWhiteSpace(lines[1]))
                    {
                        if (checkBox2.Checked)
                        {
                            lines[0] = "FielderFormation.JSON";
                            lines[1] = "true";
                        }
                        else
                        {
                            lines[0] = "FielderFormation.JSON";
                            lines[1] = "false";
                        }

                    }
                    else
                    {
                        if (checkBox2.Checked)
                        {
                            lines[0] = "FielderFormation.JSON";
                            lines[1] = "true";
                        }
                        else
                        {
                            lines[0] = "FielderFormation.JSON";
                            lines[1] = "false";
                        }

                    }
                    File.WriteAllLines(filePath, lines);

                }
                else
                {
                    // Create the file with the specified lines
                   
                    List<string> newLines = lines.ToList();
                    newLines.Add("FielderFormation.JSON");
                    if (checkBox2.Checked)
                    {
                        newLines.Add("true");
                    }
                    else
                    {
                        newLines.Add("false");
                    }
                    File.WriteAllLines(filePath, newLines);
                }
            }
            else
            {            // Writing content to the text file
                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    if (checkBox2.Checked)
                    {
                        outputFile.WriteLine("FielderFormation.JSON");
                        outputFile.WriteLine("true");
                    }
                    else
                    {
                        outputFile.WriteLine("FielderFormation.JSON");
                        outputFile.WriteLine("false");
                    }
                }
            }
        }
        private void SaveField_Click(object sender, EventArgs e)
        {
            fieldersData.Checkbox = checkBox2.Checked;
            fieldersData.BowlingEnd = comboBox.SelectedItem?.ToString(); 

            try
            {
                if (fieldersData.BowlingEnd == "Far")
                {
                    fieldersData.Fielders.Clear();
                    for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                    {
                        int leftLocation = 522 - FielderLbl[i].Left;
                        int topLocation = 522 - FielderLbl[i].Top;

                        fieldersData.Fielders.Add(new FieldersFormation(
                            fielderId: i + 1,
                            leftLocation: leftLocation,
                            topLocation: topLocation,
                            fielderhighlight: "NO"
                        ));
                    }
                }

                string filePath = FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File;
                File.WriteAllText(filePath, JsonConvert.SerializeObject(fieldersData));

                MessageBox.Show("File Successfully Saved on \n" + DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
            }
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            

            this.Close();
            //Environment.Exit(0);
        }
        private void SaveFile()
        {
            File.WriteAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File,
                JsonConvert.SerializeObject(fieldersData));
        }

        private void FielderLbl_Click(object sender, EventArgs e, int id)
        {
            player_id = id;
            if (File.Exists(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File))
            {
                FieldersData existingData = JsonConvert.DeserializeObject<FieldersData>(File.ReadAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File));
                if (existingData.Fielders[player_id].fielderhighlight == "NO")
                {
                    if (player_id > -1)
                    {
                        FielderLbl[player_id].BackColor = Color.Transparent;
                    }
                    FielderLbl[player_id].BackColor = Color.OrangeRed;
                }
            }
            else
            {
                if (player_id > -1)
                {
                    FielderLbl[player_id].BackColor = Color.Transparent;
                }
                FielderLbl[player_id].BackColor = Color.OrangeRed;
            }
            System.Diagnostics.Debug.WriteLine("fielder id  " + id);
        }
        private void Move_Player_On_Click(object sender, MouseEventArgs e)
        {
            if (player_id > -1)
            {
                string filePath = Path.Combine(FieldLoggerConstants.Cricket_Directory, "Fielder_Text\\FieldPlotter.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    string l3 = "Player ID\t" + player_id;
                    string l4 = "Before_player_Top\t" + FielderLbl[player_id].Top;
                    string l5 = "Before_Player_Left\t" + FielderLbl[player_id].Left;
                    string l6 = "After_player_Top\t" + e.Y;
                    string l7 = "After_Player_Left\t" + e.X;
                    if (lines.Length >= 7)
                    {
                        lines[2] = l3;
                        lines[3] = l4;
                        lines[4] = l5;
                        lines[5] = l6;
                        lines[6] = l7;
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    {
                        var newLines = lines.ToList();
                        newLines.Add(l3);
                        newLines.Add(l4);
                        newLines.Add(l5);
                        newLines.Add(l6);
                        newLines.Add(l7);
                        File.WriteAllLines(filePath, newLines);
                    }
                }
                else
                {
                    Console.WriteLine("File not found: " + filePath);
                }

                FielderLbl[player_id].Left = e.X;
                FielderLbl[player_id].Top = e.Y;

                string formationFilePath = Path.Combine(FieldLoggerConstants.Cricket_Directory, FieldLoggerConstants.Field_Formation_File);

                if (File.Exists(formationFilePath))
                {
                    FieldersData existingData = JsonConvert.DeserializeObject<FieldersData>(File.ReadAllText(formationFilePath));

                    if (existingData.Fielders.Count > player_id)
                    {
                        if (fieldersData.BowlingEnd == "Far")
                        {
                            existingData.Fielders[player_id].leftLocation = 522 - e.X;
                            existingData.Fielders[player_id].topLocation = 522 - e.Y;
                        }
                        else
                        {
                            existingData.Fielders[player_id].leftLocation = e.X;
                            existingData.Fielders[player_id].topLocation = e.Y;
                        }

                        File.WriteAllText(formationFilePath, JsonConvert.SerializeObject(existingData));

                        if (existingData.Fielders[player_id].fielderhighlight == "NO")
                        {
                            FielderLbl[player_id].BackColor = Color.Transparent;
                        }

                        player_id = -1;
                    }
                    else
                    {
                        SaveFile();
                    }
                }
            }
        }
        private void checkbox_btn_Click(object sender, EventArgs e)
        {
            if (File.Exists(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File))
            {
                string existingData = File.ReadAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File);
                fieldersData = JsonConvert.DeserializeObject<FieldersData>(existingData);

                if (!checkBox1.Checked)
                {
                    for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                    {
                        FielderLbl[i].BackColor = Color.White;
                        FielderLbl[i].ForeColor = Color.Black;

                        var existingPlayer = fieldersData.Fielders.FirstOrDefault(p => p.fielderId == (i + 1));
                        if (existingPlayer != null)
                        {
                            existingPlayer.fielderhighlight = "NO";
                        }
                    }

                    textBox1.Clear();
                }
                else
                {
                    string[] substrings = textBox1.Text.Split(',');
                    if (substrings.Length == 1 && substrings[0] == "")
                    {
                        MessageBox.Show("Please enter a number or numbers separated by commas.");
                        checkBox1.Checked = false;
                        textBox1.Clear();
                    }
                    else
                    {
                        for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                        {
                            for (int j = 0; j < substrings.Length; j++)
                            {
                                if (int.TryParse(substrings[j], out int parsedValue) && parsedValue >= 1 && parsedValue <= FieldLoggerConstants.Number_Of_Fielders)
                                {
                                    FielderLbl[parsedValue - 1].BackColor = Color.DarkRed;
                                    FielderLbl[parsedValue - 1].ForeColor = Color.White;

                                    var existingPlayer = fieldersData.Fielders.FirstOrDefault(p => p.fielderId == parsedValue);
                                    if (existingPlayer != null)
                                    {
                                        existingPlayer.fielderhighlight = "YES";
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid data format. Please enter valid numbers separated by commas.");
                                    checkBox1.Checked = false;
                                    textBox1.Clear();
                                    return;
                                }
                            }
                        }
                    }
                }

                using (StreamWriter file = new StreamWriter(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File, false))
                {
                    string json = JsonConvert.SerializeObject(fieldersData);
                    file.Write(json);
                }
            }
            else
            {
                using (StreamWriter file = new StreamWriter(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation_File, false))
                {
                    string json = JsonConvert.SerializeObject(fieldersData);
                    file.Write(json);
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
                textBox1.Clear();
            }
            string filePath = FieldLoggerConstants.Cricket_Directory + "\\Fielder_Text\\FieldPlotter.txt";
            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                if (lines.Count >= 7)
                {
                    lines.RemoveRange(2, 5);
                    File.WriteAllLines(filePath, lines.ToArray());
                }
            }

        }
    }
}