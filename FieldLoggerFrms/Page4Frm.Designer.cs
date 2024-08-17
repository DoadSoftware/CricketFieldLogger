using CricketFieldLogger.Model;
using Newtonsoft.Json.Linq;

namespace CricketFieldLogger
{
    partial class Page4Frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Label> FielderLbl = new List<Label>();
        private PictureBox FieldLoggerPicBox;
        private Label label1, label2, label3, bowlingEnd;
        private TextBox textBox1;
        private ComboBox comboBox;
        private CheckBox checkBox1, checkBox2;
        private GroupBox groupBox1, groupBox2, groupBox3, groupBox4;
        private Button Seamer_Six_By_Four_btn, Seamer_Five_By_Four_btn, Seamer_Seven_By_Two_btn, Spinner_Six_By_Three_btn,
             Six_By_Four_lbh_btn, Five_By_Four_lbh_btn, Seven_By_Two_lbh_btn, Six_By_Three_lbh_btn,
            Swap, SaveField, ExitApplication, Page_1, Page_2, Page_3, Page_4;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldLoggerFrm));
            //  this.MouseUp += new MouseEventArgs(this.FielderLbl_Up);

            FieldLoggerPicBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            Seamer_Seven_By_Two_btn = new Button();
            Seamer_Five_By_Four_btn = new Button();
            Seamer_Six_By_Four_btn = new Button();
            Spinner_Six_By_Three_btn = new Button();
            Six_By_Four_lbh_btn = new Button();
            Seven_By_Two_lbh_btn = new Button();
            Six_By_Three_lbh_btn = new Button();
            Five_By_Four_lbh_btn = new Button();
            groupBox2 = new GroupBox();
            Swap = new Button();
            SaveField = new Button();
            ExitApplication = new Button();
            groupBox3 = new GroupBox();
            Page_1 = new Button();
            Page_2 = new Button();
            Page_3 = new Button();
            Page_4 = new Button();
            comboBox = new ComboBox();
            bowlingEnd = new Label();
            ((System.ComponentModel.ISupportInitialize)FieldLoggerPicBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // FieldLoggerPicBox
            // 
            FieldLoggerPicBox.BackgroundImage = (Image)resources.GetObject("FieldLoggerPicBox.BackgroundImage");
            FieldLoggerPicBox.Location = new Point(12, 12);
            FieldLoggerPicBox.Name = "FieldLoggerPicBox";
            FieldLoggerPicBox.Size = new Size(515, 522);
            FieldLoggerPicBox.TabStop = false;
            // 
            // label1 setup
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 537);
            label1.Name = "label1";
            label1.Size = new Size(173, 30); // Adjust the height for the line break
            label1.Text = "Wicket-keeper\nmust be player 1";

            // textBox1 setup
            textBox1.AutoSize = true;
            textBox1.BorderStyle = BorderStyle.Fixed3D;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(180, 537); // Adjusted to be in line with label1
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 30); // Adjusted to fit the line
            textBox1.Text = "";
            textBox1.TextChanged += textbox_btn_Click;

            // bowlingEnd setup
            bowlingEnd.AutoSize = true;
            bowlingEnd.BackColor = Color.DeepSkyBlue;
            bowlingEnd.ForeColor = Color.White;
            bowlingEnd.Location = new Point(330, 537); // Adjusted to be in line with textBox1
            bowlingEnd.Name = "bowlingEnd";
            bowlingEnd.Size = new Size(90, 30); // Adjusted size
            bowlingEnd.Text = "Bowling End";

            // comboBox setup
            comboBox.AutoSize = false;
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.Black;
            comboBox.Location = new Point(430, 537); // Adjusted to be in line with bowlingEnd
            comboBox.Size = new Size(63, 30); // Adjusted size
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox.Items.AddRange(new object[] { "Near", "Far" });
            comboBox.SelectedItem = "Near";

            // Handle ComboBox drawing and selection
            comboBox.DrawItem += (sender, e) =>
            {
                if (e.Index >= 0)
                {
                    e.DrawBackground();
                    e.Graphics.DrawString(
                        ((ComboBox)sender).Items[e.Index].ToString(),
                        e.Font,
                        Brushes.Black,
                        e.Bounds.Left,
                        e.Bounds.Top + 5 // Adjust spacing here
                    );
                    e.DrawFocusRectangle();
                }
            };

            // Handle selection change
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                var selectedItem = ((ComboBox)sender).SelectedItem?.ToString();
                if (selectedItem != null)
                {
                    SetValue(selectedItem);
                }
            };

            // Adjust dropdown width
            comboBox.DropDown += (sender, e) =>
            {
                ComboBox cb = (ComboBox)sender;
                cb.DropDownWidth = cb.Width + 20; // Adjust dropdown width as needed
            };
            // 
            // checkbox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(240, 565);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 7);
            checkBox1.Text = "HIGHLIGHT";
            checkBox1.CheckedChanged += checkbox_btn_Click;
            // 
            // label1
            // 

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Green;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 580);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.Text = "Bowler must be player 11";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Green;
            label3.ForeColor = Color.White;
            label3.Location = new Point(425, 565);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.Text = "RHB";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Seamer_Six_By_Four_btn);
            groupBox1.Controls.Add(Seamer_Five_By_Four_btn);
            groupBox1.Controls.Add(Seamer_Seven_By_Two_btn);
            groupBox1.Controls.Add(Spinner_Six_By_Three_btn);
            groupBox1.Location = new Point(12, 600);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 71);
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Six_By_Four_lbh_btn);
            groupBox4.Controls.Add(Five_By_Four_lbh_btn);
            groupBox4.Controls.Add(Seven_By_Two_lbh_btn);
            groupBox4.Controls.Add(Six_By_Three_lbh_btn);
            groupBox4.Location = new Point(12, 660);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(450, 60);
            groupBox4.TabStop = false;
            // 
            // FieldFormation_4
            // 
            Spinner_Six_By_Three_btn.Location = new Point(335, 12);
            Spinner_Six_By_Three_btn.Name = "FieldFormation_4";
            Spinner_Six_By_Three_btn.Size = new Size(110, 48);
            Spinner_Six_By_Three_btn.Text = "Spinner RHB \n6-3";
            Spinner_Six_By_Three_btn.UseVisualStyleBackColor = true;
            Spinner_Six_By_Three_btn.Click += Spinner_Six_By_Three_btn_Click;
            //
            // FieldFormation_3
            //
            Seamer_Seven_By_Two_btn.Location = new Point(225, 12);
            Seamer_Seven_By_Two_btn.Name = "FieldFormation_3";
            Seamer_Seven_By_Two_btn.Size = new Size(110, 48);
            Seamer_Seven_By_Two_btn.Text = "Seamer RHB \n7-2";
            Seamer_Seven_By_Two_btn.UseVisualStyleBackColor = true;
            Seamer_Seven_By_Two_btn.Click += Seamer_Seven_By_Two_btn_Click;
            // 
            // FieldFormation_2
            // 
            Seamer_Five_By_Four_btn.Location = new Point(115, 12);
            Seamer_Five_By_Four_btn.Name = "FieldFormation_2";
            Seamer_Five_By_Four_btn.Size = new Size(110, 48);
            Seamer_Five_By_Four_btn.Text = "Seamer RHB \n5-4";
            Seamer_Five_By_Four_btn.UseVisualStyleBackColor = true;
            Seamer_Five_By_Four_btn.Click += Seamer_Five_By_Four_btn_Click;

            // 
            // FieldFormation_1
            // 
            Seamer_Six_By_Four_btn.Location = new Point(4, 12);
            Seamer_Six_By_Four_btn.Name = "FieldFormation_1";
            Seamer_Six_By_Four_btn.Size = new Size(110, 48);
            Seamer_Six_By_Four_btn.Text = "Seamer RHB \n6-3";
            Seamer_Six_By_Four_btn.UseVisualStyleBackColor = true;
            Seamer_Six_By_Four_btn.Click += Seamer_Six_By_Four_btn_Click;


            // 
            // FieldFormation_1_lbh
            // 
            Six_By_Four_lbh_btn.Location = new Point(4, 12);
            Six_By_Four_lbh_btn.Name = "FieldFormation_lbh_1";
            Six_By_Four_lbh_btn.Size = new Size(110, 48);
            Six_By_Four_lbh_btn.Text = "Seamer LHB \n6-3";
            Six_By_Four_lbh_btn.UseVisualStyleBackColor = true;
            Six_By_Four_lbh_btn.Click += Six_By_Four_lbh_btn_click;


            // 
            // FieldFormation_2_lbh
            // 
            Five_By_Four_lbh_btn.Location = new Point(115, 12);
            Five_By_Four_lbh_btn.Name = "FieldFormation_lbh_2";
            Five_By_Four_lbh_btn.Size = new Size(110, 48);
            Five_By_Four_lbh_btn.Text = "Seamer LHB \n5-4";
            Five_By_Four_lbh_btn.UseVisualStyleBackColor = true;
            Five_By_Four_lbh_btn.Click += Five_By_Four_lbh_btn_click;


            // 
            // FieldFormation_3_lbh
            // 
            Seven_By_Two_lbh_btn.Location = new Point(225, 12);
            Seven_By_Two_lbh_btn.Name = "FieldFormation_lbh_3";
            Seven_By_Two_lbh_btn.Size = new Size(110, 48);
            Seven_By_Two_lbh_btn.Text = "Seamer LHB \n7-2";
            Seven_By_Two_lbh_btn.UseVisualStyleBackColor = true;
            Seven_By_Two_lbh_btn.Click += Seven_By_Two_lbh_btn_click;


            // 
            // FieldFormation_4_lbh
            // 
            Six_By_Three_lbh_btn.Location = new Point(335, 12);
            Six_By_Three_lbh_btn.Name = "FieldFormation_lbh_4";
            Six_By_Three_lbh_btn.Size = new Size(110, 48);
            Six_By_Three_lbh_btn.Text = "Spinner LHB \n6-3";
            Six_By_Three_lbh_btn.UseVisualStyleBackColor = true;
            Six_By_Three_lbh_btn.Click += Six_By_Three_lbh_btn_click;
            // 
            // groupBox2
            //
            //groupBox2.Controls.Add(Swap);
            groupBox2.Controls.Add(SaveField);
            groupBox2.Controls.Add(ExitApplication);
            groupBox2.Location = new Point(12, 770);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 60);
            groupBox2.TabStop = false;
            // 
            // Swap
            // 
            Swap.Location = new Point(14, 22);
            Swap.Name = "Swap";
            Swap.Size = new Size(100, 30);
            Swap.TabIndex = 0;
            Swap.Text = "&Swap";
            Swap.UseVisualStyleBackColor = true;
            Swap.Click += Swap_Click;
            // 
            // SaveField
            // 
            SaveField.Location = new Point(124, 22);
            SaveField.Name = "SaveField";
            SaveField.Size = new Size(100, 30);
            SaveField.TabIndex = 0;
            SaveField.Text = "&Save Field";
            SaveField.UseVisualStyleBackColor = true;
            SaveField.Click += SaveField_Click;
            // 
            // checkbox2            
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Red;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(351, 565);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(80, 30);
            checkBox2.Text = "LIVE";
            checkBox2.CheckedChanged += checkbox2_btn_Click;
            // 
            // ExitApplication
            // 
            ExitApplication.Location = new Point(234, 22);
            ExitApplication.Name = "ExitApplication";
            ExitApplication.Size = new Size(100, 30);
            ExitApplication.TabIndex = 1;
            ExitApplication.Text = "&Exit";
            ExitApplication.UseVisualStyleBackColor = true;
            ExitApplication.Click += ExitApplication_Click;
            // 
            // groupBox3
            //
            groupBox3.Controls.Add(Page_1);
            groupBox3.Controls.Add(Page_2);
            groupBox3.Controls.Add(Page_3);
            groupBox3.Controls.Add(Page_4);
            groupBox3.Location = new Point(12, 730);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(450, 60);
            groupBox3.TabStop = false;
            // 
            // Page1
            // 
            Page_1.Location = new Point(14, 22);
            Page_1.Name = "Page_1";
            Page_1.Size = new Size(100, 30);
            Page_1.TabIndex = 0;
            Page_1.Text = "&Page_1";
            Page_1.UseVisualStyleBackColor = true;
            Page_1.Click += Page_1_btn_Click;
            // 
            // Page2
            // 
            Page_2.Location = new Point(115, 22);
            Page_2.Name = "Page_2";
            Page_2.Size = new Size(100, 30);
            Page_2.TabIndex = 0;
            Page_2.Text = "&Page_2";
            Page_2.UseVisualStyleBackColor = true;
            Page_2.Click += Page_2_btn_Click;
            // 
            // Page3
            // 
            Page_3.Location = new Point(216, 22);
            Page_3.Name = "Page_3";
            Page_3.Size = new Size(100, 30);
            Page_3.TabIndex = 0;
            Page_3.Text = "&Page_3";
            Page_3.UseVisualStyleBackColor = true;
            Page_3.Click += Page_3_btn_Click;
            // 
            // Page4
            // 
            Page_4.Location = new Point(317, 22);
            Page_4.Name = "Page_4";
            Page_4.Size = new Size(100, 30);
            Page_4.TabIndex = 0;
            Page_4.Text = "&Page_4";
            Page_4.UseVisualStyleBackColor = true;
            Page_4.Click += Page_4_btn_Click;

            List<String> data = new List<String>();
            int value = 0;


            FieldLoggerPicBox.MouseClick += (sender, e) =>
            {
                // Get the coordinates of the clicked location
                int x = e.X;
                int y = e.Y;

                // Pass the coordinates to the MainForm_Click function
                Move_Player_On_Click(sender, new MouseEventArgs(e.Button, e.Clicks, x, y, e.Delta));
            };


            if (File.Exists(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation2_File))
            {
                using (StreamReader r = new StreamReader(FieldLoggerConstants.Cricket_Directory + FieldLoggerConstants.Field_Formation2_File))
                {
                    string jsonstring = r.ReadToEnd();
                    JObject obj = JObject.Parse(jsonstring);

                    if ((string)obj["style"] == "LHB")
                    {
                        label3.Text = "LHB";
                        FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.lhb_img);
                    }
                    else if ((string)obj["style"] == "RHB")
                    {
                        label3.Text = "RHB";
                        FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
                    }

                    for (int i = 0; i < 11; i++)
                    {
                        FielderLbl.Add(new Label());
                        FielderLbl[i].AutoSize = true;
                        FielderLbl[i].Location = new Point(Int16.Parse((string)obj["fielders"][i]["leftLocation"]), Int16.Parse((string)obj["fielders"][i]["topLocation"]));
                        if ((string)obj["fielders"][i]["fielderhighlight"] == "YES")
                        {
                            value = i + 1;
                            data.Add(value.ToString());
                            checkBox1.Checked = true;
                            FielderLbl[i].BackColor = Color.DarkRed;
                            FielderLbl[i].ForeColor = Color.White;
                        }
                        if (i == 10 || i == 9)
                        {
                            FielderLbl[i].Size = new Size(22, 20);
                            FielderLbl[i].TextAlign = ContentAlignment.MiddleCenter;

                        }
                        else
                        {
                            FielderLbl[i].Size = new Size(17, 20);
                            FielderLbl[i].TextAlign = ContentAlignment.MiddleCenter;

                        }
                        var path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddEllipse(0, 0, FielderLbl[i].Width, FielderLbl[i].Height);
                        this.FielderLbl[i].Region = new Region(path);
                        FielderLbl[i].Text = Convert.ToString(i + 1);
                        FielderLbl[i].Move += FielderLbl_Move;
                        int id = i;
                        FielderLbl[i].Click += (sender, e) => FielderLbl_Click(sender, e, id);
                    }
                    System.Diagnostics.Debug.WriteLine("Count = " + data.Count);
                    String text = "";

                    if (data.Count > 0)
                    {
                        for (int i = 0; i < data.Count; i++)
                        {
                            System.Diagnostics.Debug.WriteLine("data = " + data[i]);
                            text = text + "," + String.Join(",", data[i]);
                            System.Diagnostics.Debug.WriteLine("text = " + text);
                        }

                        if (data.Count == 1)
                        {
                            textBox1.Text = text;
                        }
                        else
                        {
                            textBox1.Text = text.Remove(0, 1);

                        }
                    }

                }
            }
            else
            {
                FieldLoggerPicBox.BackgroundImage = Image.FromFile(FieldLoggerConstants.rhb_img);
                for (int i = 0; i < 11; i++)
                {
                    FielderLbl.Add(new Label());
                    FielderLbl[i].AutoSize = true;
                    FielderLbl[i].Location = new Point(263, 230 + i * 15);
                    if (i == 10 || i == 9)
                    {
                        FielderLbl[i].Size = new Size(22, 20);
                        FielderLbl[i].TextAlign = ContentAlignment.MiddleCenter;

                    }
                    else
                    {
                        FielderLbl[i].Size = new Size(17, 20);
                        FielderLbl[i].TextAlign = ContentAlignment.MiddleCenter;

                    }
                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, FielderLbl[i].Width, FielderLbl[i].Height);
                    this.FielderLbl[i].Region = new Region(path);
                    FielderLbl[i].Text = Convert.ToString(i + 1);
                    FielderLbl[i].Move += FielderLbl_Move;
                    int id = i;
                    FielderLbl[i].Click += (sender, e) => FielderLbl_Click(sender, e, id);
                }
            }


            // 
            // Page1Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 900);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            this.Controls.Add(comboBox);
            Controls.Add(bowlingEnd);
            for (int i = 0; i < 11; i++)
            {
                Controls.Add(FielderLbl[i]);
            }
            Controls.Add(FieldLoggerPicBox);
            MaximizeBox = false;
            Name = "Page4Frm";
            Text = "Page 4";
            ((System.ComponentModel.ISupportInitialize)FieldLoggerPicBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}