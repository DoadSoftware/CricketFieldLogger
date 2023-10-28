using CricketFieldLogger.Helper;
using CricketFieldLogger.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace CricketFieldLogger
{
    public partial class Page3Frm : Form
    {
        string which_btn = "";

        public FieldersData fieldersData = new FieldersData(false, new List<FieldersFormation>());

        public Page3Frm()
        {
            InitializeComponent();
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
                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "No"));
            }
            if (checkBox2.Checked)
            {
                fieldersData.Checkbox = true;
                File.WriteAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Directory + FieldLoggerConstants.Field_Formation3_File,
              JsonConvert.SerializeObject(fieldersData));
            }
        }
        private void Seamer_Six_By_Four_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Six_By_Four";
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.Green;
            fieldersData.Fielders = new List<FieldersFormation>();
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
                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "No"));
            }
        }
        private void Seamer_Five_By_Four_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Five_By_Four";
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.Green;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }

            fieldersData.Fielders = new List<FieldersFormation>();
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
                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "No"));
                System.Diagnostics.Debug.WriteLine("size (5-4) = " + fieldersData.Fielders.Count);
            }

        }
        private void Seamer_Seven_By_Two_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Seamer_Seven_By_Two";
            Spinner_Six_By_Three_btn.BackColor = Color.LightGray;
            Seamer_Seven_By_Two_btn.BackColor = Color.Green;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }
            fieldersData.Fielders = new List<FieldersFormation>();
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
                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "No"));
                System.Diagnostics.Debug.WriteLine("size (7-2)= " + fieldersData.Fielders.Count);
            }
        }
        private void Spinner_Six_By_Three_btn_Click(object sender, EventArgs e)
        {
            which_btn = "Spinner_Six_By_Three";
            Spinner_Six_By_Three_btn.BackColor = Color.Green;
            Seamer_Seven_By_Two_btn.BackColor = Color.LightGray;
            Seamer_Five_By_Four_btn.BackColor = Color.LightGray;
            Seamer_Six_By_Four_btn.BackColor = Color.LightGray;
            if (fieldersData != null)
            {
                fieldersData.Fielders.Clear();
            }
            fieldersData.Fielders = new List<FieldersFormation>();
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

                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "No"));
            }
        }
        private void Swap_Click(object sender, EventArgs e)
        {
            if (File.Exists(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Directory +
                FieldLoggerConstants.Field_Formation3_File))
            {
                // Serialize and save the current fieldersData
                File.WriteAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Directory +
                    FieldLoggerConstants.Field_Formation3_File, JsonConvert.SerializeObject(fieldersData));

                // Initialize the fieldersData from the saved JSON
                using (StreamReader r = new StreamReader(FieldLoggerConstants.Cricket_Directory +
                    FieldLoggerConstants.Field_Directory + FieldLoggerConstants.Field_Formation3_File))
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
                        File.WriteAllText(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Directory +
                            FieldLoggerConstants.Field_Formation3_File, updatedJsonData);
                    }
                }
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

            if (checkBox2.Checked)
            {
                fieldersData.Checkbox = true;
            }
            else
            {
                fieldersData.Checkbox = false;
            }
            File.WriteAllText(FieldLoggerConstants.Cricket_Directory +
                   FieldLoggerConstants.Field_Directory + FieldLoggerConstants.Field_Formation3_File,
                       JsonConvert.SerializeObject(fieldersData));
        }
        private void checkbox_btn_Click(object sender, EventArgs e)
        {
            Boolean dataFound = false;
            if (checkBox1.Checked == true)
            {
                if (textBox1.Text.Contains(","))
                {
                    fieldersData.Fielders = new List<FieldersFormation>();

                    String[] substrings = textBox1.Text.Split(',');

                    if (which_btn == "Seamer_Seven_By_Two" || which_btn == "Seamer_Five_By_Four" || which_btn == "Seamer_Six_By_Four" || which_btn == "Spinner_Six_By_Three")
                    {
                        for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                        {
                            dataFound = false;
                            for (int j = 0; j < substrings.Length; j++)
                            {
                                if ((i + 1) == Int16.Parse(substrings[j]))
                                {
                                    dataFound = true;
                                    FielderLbl[Int16.Parse(substrings[j]) - 1].BackColor = Color.DarkRed;
                                    FielderLbl[Int16.Parse(substrings[j]) - 1].ForeColor = Color.White;

                                    fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "YES"));
                                    break;
                                }
                            }
                            if (dataFound == false)
                            {
                                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                        {
                            dataFound = false;
                            for (int j = 0; j < substrings.Length; j++)
                            {
                                if ((i + 1) == Int16.Parse(substrings[j]))
                                {
                                    dataFound = true;
                                    FielderLbl[Int16.Parse(substrings[j]) - 1].BackColor = Color.DarkRed;
                                    FielderLbl[Int16.Parse(substrings[j]) - 1].ForeColor = Color.White;

                                    fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "YES"));
                                    break;
                                }
                            }
                            if (dataFound == false)
                            {
                                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                            }
                        }
                    }
                }
                else
                {
                    if (textBox1.TextLength <= 0)
                    {
                        // MessageBox.Show("No Data to Highlight");
                    }
                    else
                    {
                        fieldersData.Fielders = new List<FieldersFormation>();
                        for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                        {
                            dataFound = false;
                            for (int j = 0; j < 1; j++)
                            {
                                if ((i + 1) == Int16.Parse(textBox1.Text))
                                {
                                    dataFound = true;
                                    FielderLbl[Int16.Parse(textBox1.Text) - 1].BackColor = Color.DarkRed;
                                    FielderLbl[Int16.Parse(textBox1.Text) - 1].ForeColor = Color.White;

                                    fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                                }
                            }
                            if (dataFound == false)
                            {
                                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                            }
                        }
                    }
                }
            }
            else
            {
                if (textBox1.Text.Contains(","))
                {
                    fieldersData.Fielders = new List<FieldersFormation>();

                    String[] substrings = textBox1.Text.Split(',');

                    for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                    {
                        dataFound = false;
                        for (int j = 0; j < substrings.Length; j++)
                        {
                            if ((i + 1) == Int16.Parse(substrings[j]))
                            {
                                dataFound = true;
                                FielderLbl[Int16.Parse(substrings[j]) - 1].BackColor = Color.White;
                                FielderLbl[Int16.Parse(substrings[j]) - 1].ForeColor = Color.Black;

                                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                            }
                        }
                        if (dataFound == false)
                        {
                            fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                        }
                    }
                }
                else
                {
                    if (textBox1.TextLength <= 0)
                    {
                    }
                    else
                    {
                        fieldersData.Fielders = new List<FieldersFormation>();
                        for (int i = 0; i < FieldLoggerConstants.Number_Of_Fielders; i++)
                        {
                            dataFound = false;
                            for (int j = 0; j < 1; j++)
                            {
                                if ((i + 1) == Int16.Parse(textBox1.Text))
                                {
                                    dataFound = true;
                                    FielderLbl[Int16.Parse(textBox1.Text) - 1].BackColor = Color.White;
                                    FielderLbl[Int16.Parse(textBox1.Text) - 1].ForeColor = Color.Black;

                                    fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                                }
                            }
                            if (dataFound == false)
                            {
                                fieldersData.Fielders.Add(new FieldersFormation(fielderId: i + 1, leftLocation: FielderLbl[i].Left, topLocation: FielderLbl[i].Top, fielderhighlight: "NO"));
                            }
                        }
                    }
                }
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
        private void SaveField_Click(object sender, EventArgs e)
        {
            // Set the checkbox value in the fieldersData object
            if (checkBox2.Checked == true)
            {
                fieldersData.Checkbox = true;
            }
            else
            {
                fieldersData.Checkbox = false;
            }

            // Serialize the fieldersData object and write it to the JSON file
            File.WriteAllText(FieldLoggerConstants.Cricket_Directory +
                FieldLoggerConstants.Field_Directory + FieldLoggerConstants.Field_Formation3_File,
                    JsonConvert.SerializeObject(fieldersData));

            MessageBox.Show("File Successfully Saved on \n" + DateTime.Now);
        }
        private void ExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(0);
        }
    }

}