using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkatooMoonImages
{
    public partial class MoonSelectForm : Form
    {
        private Kingdom Kingdom;

        public MoonSelectForm(Kingdom kingdom)
        {
            Kingdom = kingdom;

            InitializeComponent();

            nudMoonNumber.Maximum = Kingdom.Moons.Count;
            lblKingdom.Text = $"{Kingdom.Name} moon:";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            var moonForm = new MoonForm();
            moonForm.ShowDialog();
        }
    }
}
