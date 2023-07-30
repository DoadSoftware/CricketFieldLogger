namespace CricketFieldLogger
{
    partial class FieldLoggerFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public List<Label> FielderLbl = new List<Label>();
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldLoggerFrm));
            for(int i = 0; i < 11; i++)
            {
                FielderLbl.Add(new Label());
                FielderLbl[i].AutoSize = true;
                switch(i) {
                    case 0:
                        FielderLbl[i].Location = new Point(263, 230);
                        break;
                    case 1:
                        FielderLbl[i].Location = new Point(263, 245);
                        break;
                    case 2:
                        FielderLbl[i].Location = new Point(263, 260);
                        break;
                    case 3:
                        FielderLbl[i].Location = new Point(263, 275);
                        break;
                    case 4:
                        FielderLbl[i].Location = new Point(263, 290);
                        break;
                    case 5:
                        FielderLbl[i].Location = new Point(263, 305);
                        break;
                    case 6:
                        FielderLbl[i].Location = new Point(263, 320);
                        break;
                    case 7:
                        FielderLbl[i].Location = new Point(263, 335);
                        break;
                    case 8:
                        FielderLbl[i].Location = new Point(263, 350);
                        break;
                    case 9:
                        FielderLbl[i].Location = new Point(263, 365);
                        break;
                    case 10:
                        FielderLbl[i].Location = new Point(263, 380);
                        break;
                }
                FielderLbl[i].Size = new Size(13, 15);
                FielderLbl[i].TabIndex = 3;
                FielderLbl[i].Text = Convert.ToString(i+1);
            }

            FieldLoggerPicBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            FieldFormation_2 = new Button();
            FieldFormation_1 = new Button();
            groupBox2 = new GroupBox();
            SaveField = new Button();
            ((System.ComponentModel.ISupportInitialize)FieldLoggerPicBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            // 
            // FieldLoggerPicBox
            // 
            FieldLoggerPicBox.BackgroundImage = (Image)resources.GetObject("FieldLoggerPicBox.BackgroundImage");
            FieldLoggerPicBox.Location = new Point(12, 12);
            FieldLoggerPicBox.Name = "FieldLoggerPicBox";
            FieldLoggerPicBox.Size = new Size(515, 522);
            FieldLoggerPicBox.TabIndex = 1;
            FieldLoggerPicBox.TabStop = false;

            /*FielderLbl_1 = new Label();
            FielderLbl_2 = new Label();
            FielderLbl_3 = new Label();
            FielderLbl_4 = new Label();
            FielderLbl_5 = new Label();
            FielderLbl_6 = new Label();
            FielderLbl_7 = new Label();
            FielderLbl_8 = new Label();
            FielderLbl_9 = new Label();
            FielderLbl_10 = new Label();
            FielderLbl_11 = new Label();
            // 
            // FielderLbl_1
            // 
            FielderLbl_1.AutoSize = true;
            FielderLbl_1.Location = new Point(263, 229);
            FielderLbl_1.Name = "FielderLbl_1";
            FielderLbl_1.Size = new Size(13, 15);
            FielderLbl_1.TabIndex = 3;
            FielderLbl_1.Text = "1";
            // 
            // FielderLbl_2
            // 
            FielderLbl_2.AutoSize = true;
            FielderLbl_2.Location = new Point(263, 244);
            FielderLbl_2.Name = "FielderLbl_2";
            FielderLbl_2.Size = new Size(13, 15);
            FielderLbl_2.TabIndex = 4;
            FielderLbl_2.Text = "2";
            // 
            // FielderLbl_3
            // 
            FielderLbl_3.AutoSize = true;
            FielderLbl_3.Location = new Point(263, 259);
            FielderLbl_3.Name = "FielderLbl_3";
            FielderLbl_3.Size = new Size(13, 15);
            FielderLbl_3.TabIndex = 5;
            FielderLbl_3.Text = "3";
            // 
            // FielderLbl_4
            // 
            FielderLbl_4.AutoSize = true;
            FielderLbl_4.Location = new Point(263, 274);
            FielderLbl_4.Name = "FielderLbl_4";
            FielderLbl_4.Size = new Size(13, 15);
            FielderLbl_4.TabIndex = 6;
            FielderLbl_4.Text = "4";
            // 
            // FielderLbl_5
            // 
            FielderLbl_5.AutoSize = true;
            FielderLbl_5.Location = new Point(263, 289);
            FielderLbl_5.Name = "FielderLbl_5";
            FielderLbl_5.Size = new Size(13, 15);
            FielderLbl_5.TabIndex = 7;
            FielderLbl_5.Text = "5";
            // 
            // FielderLbl_6
            // 
            FielderLbl_6.AutoSize = true;
            FielderLbl_6.Location = new Point(263, 304);
            FielderLbl_6.Name = "FielderLbl_6";
            FielderLbl_6.Size = new Size(13, 15);
            FielderLbl_6.TabIndex = 8;
            FielderLbl_6.Text = "6";
            // 
            // FielderLbl_7
            // 
            FielderLbl_7.AutoSize = true;
            FielderLbl_7.Location = new Point(263, 319);
            FielderLbl_7.Name = "FielderLbl_7";
            FielderLbl_7.Size = new Size(13, 15);
            FielderLbl_7.TabIndex = 9;
            FielderLbl_7.Text = "7";
            // 
            // FielderLbl_8
            // 
            FielderLbl_8.AutoSize = true;
            FielderLbl_8.Location = new Point(263, 334);
            FielderLbl_8.Name = "FielderLbl_8";
            FielderLbl_8.Size = new Size(13, 15);
            FielderLbl_8.TabIndex = 10;
            FielderLbl_8.Text = "8";
            // 
            // FielderLbl_9
            // 
            FielderLbl_9.AutoSize = true;
            FielderLbl_9.Location = new Point(263, 349);
            FielderLbl_9.Name = "FielderLbl_9";
            FielderLbl_9.Size = new Size(13, 15);
            FielderLbl_9.TabIndex = 11;
            FielderLbl_9.Text = "9";
            // 
            // FielderLbl_10
            // 
            FielderLbl_10.AutoSize = true;
            FielderLbl_10.Location = new Point(263, 364);
            FielderLbl_10.Name = "FielderLbl_10";
            FielderLbl_10.Size = new Size(19, 15);
            FielderLbl_10.TabIndex = 12;
            FielderLbl_10.Text = "10";
            // 
            // FielderLbl_11
            // 
            FielderLbl_11.AutoSize = true;
            FielderLbl_11.Location = new Point(263, 379);
            FielderLbl_11.Name = "FielderLbl_11";
            FielderLbl_11.Size = new Size(19, 15);
            FielderLbl_11.TabIndex = 13;
            FielderLbl_11.Text = "11";*/
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 537);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 14;
            label1.Text = "Wicket-keeper must be player 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Green;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 552);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 15;
            label2.Text = "Bowler must be player 11";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FieldFormation_2);
            groupBox1.Controls.Add(FieldFormation_1);
            groupBox1.Location = new Point(12, 570);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 61);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // FieldFormation_2
            // 
            FieldFormation_2.Location = new Point(90, 12);
            FieldFormation_2.Name = "FieldFormation_2";
            FieldFormation_2.Size = new Size(78, 41);
            FieldFormation_2.TabIndex = 18;
            FieldFormation_2.Text = "Seamer RHB 5-4";
            FieldFormation_2.UseVisualStyleBackColor = true;
            FieldFormation_2.Click += FieldFormation_2_Click;
            // 
            // FieldFormation_1
            // 
            FieldFormation_1.Location = new Point(6, 12);
            FieldFormation_1.Name = "FieldFormation_1";
            FieldFormation_1.Size = new Size(78, 41);
            FieldFormation_1.TabIndex = 17;
            FieldFormation_1.Text = "Seamer RHB 6-3";
            FieldFormation_1.UseVisualStyleBackColor = true;
            FieldFormation_1.Click += FieldFormation_1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SaveField);
            groupBox2.Location = new Point(18, 637);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 80);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // SaveField
            // 
            SaveField.Location = new Point(14, 22);
            SaveField.Name = "SaveField";
            SaveField.Size = new Size(119, 40);
            SaveField.TabIndex = 0;
            SaveField.Text = "&Save Field";
            SaveField.UseVisualStyleBackColor = true;
            SaveField.Click += SaveField_Click;
            // 
            // FieldLoggerFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 764);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            for (int i = 0; i < 11; i++)
            {
                Controls.Add(FielderLbl[i]);
            }
            /*Controls.Add(FielderLbl_11);
            Controls.Add(FielderLbl_10);
            Controls.Add(FielderLbl_9);
            Controls.Add(FielderLbl_8);
            Controls.Add(FielderLbl_7);
            Controls.Add(FielderLbl_6);
            Controls.Add(FielderLbl_5);
            Controls.Add(FielderLbl_4);
            Controls.Add(FielderLbl_3);
            Controls.Add(FielderLbl_2);
            Controls.Add(FielderLbl_1);*/

            Controls.Add(FieldLoggerPicBox);
            MaximizeBox = false;
            Name = "FieldLoggerFrm";
            Text = "Cricket Field Logger";
            ((System.ComponentModel.ISupportInitialize)FieldLoggerPicBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox FieldLoggerPicBox;
        /*private Label FielderLbl_1;
        private Label FielderLbl_2;
        private Label FielderLbl_3;
        private Label FielderLbl_4;
        private Label FielderLbl_5;
        private Label FielderLbl_6;
        private Label FielderLbl_7;
        private Label FielderLbl_8;
        private Label FielderLbl_9;
        private Label FielderLbl_10;
        private Label FielderLbl_11;*/
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button FieldFormation_2;
        private Button FieldFormation_1;
        private GroupBox groupBox2;
        private Button SaveField;
    }
}