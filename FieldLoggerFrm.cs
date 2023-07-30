using CricketFieldLogger.Helper;
using CricketFieldLogger.Model;
using System.Text.Json;

namespace CricketFieldLogger
{
    public partial class FieldLoggerFrm : Form
    {
        public List<FieldersFormation> fieldersFormation;

        public FieldLoggerFrm()
        {
            InitializeComponent();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                ControlMover.Init(this.FielderLbl[i]);
            }
        }
        private void FielderLbl_Move(object sender, EventArgs e)
        {
            fieldersFormation = new List<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                fieldersFormation.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top));
            }
        }
        private void Seamer_Six_By_Four_btn_Click(object sender, EventArgs e)
        {
            fieldersFormation = new List<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 172;
                        FielderLbl[i].Top = 195;
                        break;
                    case 2:
                        FielderLbl[i].Left = 172;
                        FielderLbl[i].Top = 304;
                        break;
                    case 3:
                        FielderLbl[i].Left = 155;
                        FielderLbl[i].Top = 78;
                        break;
                    case 4:
                        FielderLbl[i].Left = 58;
                        FielderLbl[i].Top = 232;
                        break;
                    case 5:
                        FielderLbl[i].Left = 154;
                        FielderLbl[i].Top = 440;
                        break;
                    case 6:
                        FielderLbl[i].Left = 364;
                        FielderLbl[i].Top = 440;
                        break;
                    case 7:
                        FielderLbl[i].Left = 458;
                        FielderLbl[i].Top = 232;
                        break;
                    case 8:
                        FielderLbl[i].Left = 355;
                        FielderLbl[i].Top = 78;
                        break;
                    case 9:
                        FielderLbl[i].Left = 354;
                        FielderLbl[i].Top = 304;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                fieldersFormation.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top));
            }
        }

        private void Seamer_Five_By_Four_btn_Click(object sender, EventArgs e)
        {
            fieldersFormation = new List<FieldersFormation>();
            for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
            {
                switch (i)
                {
                    case 0:
                        FielderLbl[i].Left = 263;
                        FielderLbl[i].Top = 210;
                        break;
                    case 1:
                        FielderLbl[i].Left = 172;
                        FielderLbl[i].Top = 195;
                        break;
                    case 2:
                        FielderLbl[i].Left = 172;
                        FielderLbl[i].Top = 304;
                        break;
                    case 3:
                        FielderLbl[i].Left = 155;
                        FielderLbl[i].Top = 78;
                        break;
                    case 4:
                        FielderLbl[i].Left = 58;
                        FielderLbl[i].Top = 232;
                        break;
                    case 5:
                        FielderLbl[i].Left = 154;
                        FielderLbl[i].Top = 440;
                        break;
                    case 6:
                        FielderLbl[i].Left = 364;
                        FielderLbl[i].Top = 440;
                        break;
                    case 7:
                        FielderLbl[i].Left = 458;
                        FielderLbl[i].Top = 232;
                        break;
                    case 8:
                        FielderLbl[i].Left = 315;
                        FielderLbl[i].Top = 148;
                        break;
                    case 9:
                        FielderLbl[i].Left = 354;
                        FielderLbl[i].Top = 304;
                        break;
                    case 10:
                        FielderLbl[i].Left = 260;
                        FielderLbl[i].Top = 350;
                        break;
                }
                fieldersFormation.Add(new FieldersFormation(fielderId: i+1,leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top));
            }
        }
        private void SaveField_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Directory 
                + FieldLoggerConstants.Field_Formation_File, JsonSerializer.Serialize(fieldersFormation));
        }
        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}