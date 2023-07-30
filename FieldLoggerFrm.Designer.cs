namespace CricketFieldLogger
{
    partial class FieldLoggerFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Label> FielderLbl = new List<Label>();
        private PictureBox FieldLoggerPicBox;
        private Label label1, label2;
        private GroupBox groupBox1, groupBox2;
        private Button Seamer_Six_By_Four_btn, Seamer_Five_By_Four_btn, SaveField, ExitApplication;

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
                FielderLbl[i].Text = Convert.ToString(i+1);
                FielderLbl[i].Move += FielderLbl_Move;
            }

            FieldLoggerPicBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            Seamer_Five_By_Four_btn = new Button();
            Seamer_Six_By_Four_btn = new Button();
            groupBox2 = new GroupBox();
            SaveField = new Button();
            ExitApplication = new Button();
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
            FieldLoggerPicBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 537);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
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
            label2.Text = "Bowler must be player 11";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Seamer_Six_By_Four_btn);
            groupBox1.Controls.Add(Seamer_Five_By_Four_btn);
            groupBox1.Location = new Point(12, 570);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 61);
            groupBox1.TabStop = false;
            // 
            // FieldFormation_2
            // 
            Seamer_Five_By_Four_btn.Location = new Point(90, 12);
            Seamer_Five_By_Four_btn.Name = "FieldFormation_2";
            Seamer_Five_By_Four_btn.Size = new Size(70, 41);
            Seamer_Five_By_Four_btn.Text = "Seamer RHB 5-4";
            Seamer_Five_By_Four_btn.UseVisualStyleBackColor = true;
            Seamer_Five_By_Four_btn.Click += Seamer_Five_By_Four_btn_Click;
            // 
            // FieldFormation_1
            // 
            Seamer_Six_By_Four_btn.Location = new Point(6, 12);
            Seamer_Six_By_Four_btn.Name = "FieldFormation_1";
            Seamer_Six_By_Four_btn.Size = new Size(70, 41);
            Seamer_Six_By_Four_btn.Text = "Seamer RHB 6-3";
            Seamer_Six_By_Four_btn.UseVisualStyleBackColor = true;
            Seamer_Six_By_Four_btn.Click += Seamer_Six_By_Four_btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SaveField);
            groupBox2.Controls.Add(ExitApplication);
            groupBox2.Location = new Point(12, 637);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 60);
            groupBox2.TabStop = false;
            // 
            // SaveField
            // 
            SaveField.Location = new Point(14, 22);
            SaveField.Name = "SaveField";
            SaveField.Size = new Size(100, 30);
            SaveField.TabIndex = 0;
            SaveField.Text = "&Save Field";
            SaveField.UseVisualStyleBackColor = true;
            SaveField.Click += SaveField_Click;
            // 
            // ExitApplication
            // 
            ExitApplication.Location = new Point(124, 22);
            ExitApplication.Name = "ExitApplication";
            ExitApplication.Size = new Size(100, 30);
            ExitApplication.TabIndex = 1;
            ExitApplication.Text = "&Exit";
            ExitApplication.UseVisualStyleBackColor = true;
            ExitApplication.Click += ExitApplication_Click;
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
    }
}