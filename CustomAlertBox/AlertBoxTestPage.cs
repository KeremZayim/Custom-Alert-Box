using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAlertBox
{
    public partial class AlertBoxTestPage : Form
    {
        public AlertBoxTestPage()
        {
            InitializeComponent();
        }

        private void btnSuccessAlert_Click(object sender, EventArgs e)
        {
            CustomAlertForm alert = new CustomAlertForm();
            alert.ShowAlert("İşlem Başarılı!", AlertType.Success);
        }

        private void btnErrorAlert_Click(object sender, EventArgs e)
        {
            CustomAlertForm alert = new CustomAlertForm();
            alert.ShowAlert("İşlem Başarısız!!", AlertType.Error);
        }

        private void btnWarningAlert_Click(object sender, EventArgs e)
        {
            CustomAlertForm alert = new CustomAlertForm();
            alert.ShowAlert("Uyarı!", AlertType.Warning);
        }

        private void btnInfoAlert_Click(object sender, EventArgs e)
        {
            CustomAlertForm alert = new CustomAlertForm();
            alert.ShowAlert("Bilgi!", AlertType.Info);
        }
    }
}
