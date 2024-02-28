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
        private MainForm MainForm;

        public MoonSelectForm(Kingdom kingdom, MainForm mainForm)
        {
            Kingdom = kingdom;
            MainForm = mainForm;

            InitializeComponent();

            nudMoonNumber.Maximum = Kingdom.Moons.Count;
            lblKingdom.Text = $"{Kingdom.Name} moon:";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            var moon = Kingdom.Moons.FirstOrDefault(x => x.MoonId == nudMoonNumber.Value);
            var moonForm = new MoonForm(moon, MainForm);
            moonForm.ShowDialog();
        }
    }
}
