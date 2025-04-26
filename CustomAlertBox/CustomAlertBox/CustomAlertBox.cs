using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomAlertBox
{
    /*
        1-) Formun Boyutu Değişirse Hizzalama Kısmı
        2-) Uyarı Resimleri
        3-) Font Tipi
        4-) Animasyon
        5-) AlertBox Kapatma Butonu
        6-) Font Büyüklüğü
     */

    public partial class CustomAlertForm : Form
    {
        public enum Action
        {
            wait,
            start,
            close
        }

        private Action action;
        private int x, y;

        public CustomAlertForm()
        {
            InitializeComponent();
        }

        public void ShowAlert(string message, AlertType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            // 1-)
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10;
            this.Location = new Point(x, y);
            // 

            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                var f = Application.OpenForms[fname] as CustomAlertForm;

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(x, y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            // 2-)
            switch (type)
            {
                case AlertType.Success:
                    this.BackColor = Color.SeaGreen;
                    pbAlertType.Image = Properties.Resources.success;
                    break;
                case AlertType.Error:
                    this.BackColor = Color.DarkRed;
                    pbAlertType.Image = Properties.Resources.error;
                    break;
                case AlertType.Info:
                    this.BackColor = Color.RoyalBlue;
                    pbAlertType.Image = Properties.Resources.info;
                    break;
                case AlertType.Warning:
                    this.BackColor = Color.DarkOrange;
                    pbAlertType.Image = Properties.Resources.warning;
                    break;
            }
            //

            // 3-)
            lblMessage.Text = message;
            lblMessage.Font = new Font("Century Gothic", GetFontSize(message.Length), FontStyle.Regular);
            //

            this.Show();
            this.action = Action.start;
            timerAnimation.Interval = 1;
            timerAnimation.Start();

        }

        // 4-)
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Action.start:
                    timerAnimation.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.Opacity == 1.0)
                        action = Action.wait;
                    break;

                case Action.wait:
                    timerAnimation.Interval = 5000;
                    action = Action.close;
                    break;

                case Action.close:
                    timerAnimation.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left += 10;
                    if (base.Opacity == 0.0)
                        this.Close();
                    break;
            }
        }
        //

        // 5-)
        private void btnClose_Click(object sender, EventArgs e)
        {
            timerAnimation.Interval = 1;
            action = Action.close;
        }
        //

        // 5-)
        private float GetFontSize(int messageLength)
        {
            if (messageLength <= 30)
                return 14f;
            else if (messageLength <= 60)
                return 12f;
            else if (messageLength <= 100)
                return 10f;
            else
                return 8f;
        }
    }
}
