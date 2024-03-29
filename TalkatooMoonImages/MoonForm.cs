﻿using System;
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
    public partial class MoonForm : Form
    {
        private Moon Moon;
        private MainForm MainForm;

        public MoonForm(Moon moon, MainForm mainForm)
        {
            Moon = moon;
            MainForm = mainForm;
            InitializeComponent();

            lblHeading.Text = $"{Moon.Kingdom.Name} Moon {Moon.MoonId}";
            picImage.ImageLocation = Moon.GetImageLocation();
            txtNotes.Text = Moon.Notes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Moon.Notes = txtNotes.Text;
            MainForm.SaveSaveFile();
            Close();
        }
    }
}
