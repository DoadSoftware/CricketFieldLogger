using System;
using System.Drawing;
using System.Windows.Forms;
using CricketFieldLogger.Model;
using System.Drawing.Drawing2D;

namespace CricketFieldLogger
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ShowServerIpDialog();

            if (FieldLoggerConstants.connected)
            {
                Application.Run(new FieldLoggerFrm());
            }
            else
            {
                Application.Exit();
            }
        }

        private static void ShowServerIpDialog()
        {
            using (Form popup = new Form())
            {
                popup.Text = "Enter Server IP";
                popup.FormBorderStyle = FormBorderStyle.None;
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ClientSize = new Size(350, 150);
                popup.BackColor = Color.Cyan;

                popup.Paint += (sender, e) =>
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(popup.ClientRectangle, Color.Cyan, Color.Magenta, 45F))
                    {
                        e.Graphics.FillRectangle(brush, popup.ClientRectangle);
                    }

                    using (Pen shadowPen = new Pen(Color.Gray, 5))
                    {
                        e.Graphics.DrawRectangle(shadowPen, new Rectangle(3, 3, popup.ClientSize.Width - 6, popup.ClientSize.Height - 6));
                    }

                    using (Pen borderPen = new Pen(Color.Blue, 2))
                    {
                        e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, popup.ClientSize.Width - 1, popup.ClientSize.Height - 1));
                    }
                };

                Label label = new Label
                {
                    Text = "Server IP:",
                    Location = new Point(20, 20),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black
                };
                popup.Controls.Add(label);

                TextBox textBox = new TextBox
                {
                    Location = new Point(130, 18),
                    Size = new Size(200, 30),
                    Font = new Font("Arial", 12)
                };
                popup.Controls.Add(textBox);

                Button okButton = new Button
                {
                    Text = "OK",
                    Location = new Point(100, 90),
                    Size = new Size(80, 32),
                    BackColor = Color.LimeGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                okButton.FlatAppearance.BorderSize = 0;
                okButton.Click += (sender, e) =>
                {
                    string ipAddress = textBox.Text.Trim();
                    if (!string.IsNullOrEmpty(ipAddress) && !ipAddress.Equals("localhost", StringComparison.OrdinalIgnoreCase))
                    {
                        FieldLoggerConstants.Cricket_Directory = "\\\\" + ipAddress + "\\c\\Sports\\Cricket\\Fielder\\";
                        FieldLoggerConstants.connected = true;
                        popup.DialogResult = DialogResult.OK;
                        popup.Close();
                    }
                    else
                    {
                        FieldLoggerConstants.connected = true;
                        popup.DialogResult = DialogResult.OK;
                        popup.Close();
                    }
                };
                popup.Controls.Add(okButton);

                Button cancelButton = new Button
                {
                    Text = "Cancel",
                    Location = new Point(200, 90),
                    Size = new Size(80, 32),
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cancelButton.FlatAppearance.BorderSize = 0;
                cancelButton.Click += (sender, e) =>
                {
                    FieldLoggerConstants.connected = false;
                    popup.DialogResult = DialogResult.Cancel;
                    popup.Close();
                };
                popup.Controls.Add(cancelButton);

                popup.ShowDialog();
            }
        }
    }
}