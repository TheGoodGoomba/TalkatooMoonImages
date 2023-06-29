namespace TalkatooMoonImages
{
    public partial class MainForm : Form
    {
        private FileSystemWatcher Watcher;
        public static List<Kingdom> Kingdoms = new List<Kingdom>
        {
            new Kingdom("Cascade", 40),
            new Kingdom("Sand", 89),
            new Kingdom("Wooded", 76),
            new Kingdom("Lake", 42),
            new Kingdom("Lost", 35),
            new Kingdom("Metro", 81),
            new Kingdom("Snow", 55),
            new Kingdom("Seaside", 71),
            new Kingdom("Luncheon", 68),
            new Kingdom("Bowser's", 62)
        };
        private static int CurrentKingdomIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdMoonsFile.ShowDialog();
            txtPath.Text = ofdMoonsFile.FileName;
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtPath.Text))
            {
                btnMonitor.Enabled = true;
            }
            else
            {
                btnMonitor.Enabled = false;
            }
        }

        private bool Monitoring = false;
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (!Monitoring)
            {
                Monitoring = true;
                ToggleEnabledWhenMonitoring(false);
                btnMonitor.Text = "Stop Monitoring File";

                Watcher = new FileSystemWatcher();
                Watcher.Path = Directory.GetParent(txtPath.Text).ToString();
                Watcher.Filter = Path.GetFileName(txtPath.Text);
                Watcher.Changed += OnFileChange;
                Watcher.EnableRaisingEvents = true;
                OnFileChange(null, null);
            }
            else
            {
                Monitoring = false;
                ToggleEnabledWhenMonitoring(true);
                btnMonitor.Text = "Start Monitoring File";

                Watcher.Dispose();
            }
        }

        private void ToggleEnabledWhenMonitoring(bool enabled)
        {
            txtPath.Enabled = enabled;
            btnBrowse.Enabled = enabled;
            tsiMoonNotes.Enabled = enabled;
        }

        private void OnFileChange(object sender, FileSystemEventArgs e)
        {
            var pendingMoons = new List<KeyValuePair<Moon, string>>(); // Key: Moon (kingdom and Id); Value: Moon name
            var success = false;
            string[] pendingMoonsText = null;
            while (!success)
            {
                try
                {
                    pendingMoonsText = File.ReadAllLines(txtPath.Text);
                    success = true;
                }
                catch
                {
                    Thread.Sleep(100);
                }
            }
            foreach (var moonLine in pendingMoonsText)
            {
                var moonSplit = moonLine.Split(" - ");
                var moon = Kingdoms[CurrentKingdomIndex].Moons.FirstOrDefault(x => x.MoonId == int.Parse(moonSplit[0]));
                var moonNamePair = new KeyValuePair<Moon, string>(moon, moonSplit[1]);
                pendingMoons.Add(moonNamePair);
            }

            // Invoke() avoids some weird threading error with changing label text in an event method
            Invoke(() =>
            {
                ClearMoons();
            });

            if (pendingMoons.Count > 0)
            {
                var imageLocation = pendingMoons[0].Key.GetImageLocation();
                picMoon1.ImageLocation = imageLocation;
                Invoke(() =>
                {
                    lblMoon1Name.Text = pendingMoons[0].Value;
                });
            }
            if (pendingMoons.Count > 1)
            {
                var imageLocation = pendingMoons[1].Key.GetImageLocation();
                picMoon2.ImageLocation = imageLocation;
                Invoke(() =>
                {
                    lblMoon2Name.Text = pendingMoons[1].Value;
                });
            }
            if (pendingMoons.Count > 2)
            {
                var imageLocation = pendingMoons[2].Key.GetImageLocation();
                picMoon3.ImageLocation = imageLocation;
                Invoke(() =>
                {
                    lblMoon3Name.Text = pendingMoons[2].Value;
                });
            }
        }

        private void btnNextKingdom_Click(object sender, EventArgs e)
        {
            if (CurrentKingdomIndex != 9)
            {
                CurrentKingdomIndex++;
                UpdateKingdom();
            }
        }

        private void btnPrevKingdom_Click(object sender, EventArgs e)
        {
            if (CurrentKingdomIndex != 0)
            {
                CurrentKingdomIndex--;
                UpdateKingdom();
            }
        }

        private void UpdateKingdom()
        {
            btnPrevKingdom.Text = $"{(CurrentKingdomIndex == 0 ? "" : Kingdoms[CurrentKingdomIndex - 1].Name)} <<<";
            btnNextKingdom.Text = $">>> {(CurrentKingdomIndex == 9 ? "" : Kingdoms[CurrentKingdomIndex + 1].Name)}";
            lblCurrentKingdom.Text = Kingdoms[CurrentKingdomIndex].Name;

            if (btnMonitor.Enabled) // From txtPath_Changed(), the button is only enabled when there is a valid path in the textbox.
            {
                OnFileChange(null, null);
            }
        }

        private void ClearMoons()
        {
            picMoon1.Image = null;
            picMoon2.Image = null;
            picMoon3.Image = null;
            lblMoon1Name.Text = "";
            lblMoon1Notes.Text = "";
            lblMoon2Name.Text = "";
            lblMoon2Notes.Text = "";
            lblMoon3Name.Text = "";
            lblMoon3Notes.Text = "";
        }

        private void tsiMoonNotes_Click(object sender, EventArgs e)
        {
            var moonSelectForm = new MoonSelectForm(Kingdoms[CurrentKingdomIndex]);
            moonSelectForm.ShowDialog();
        }
    }
}