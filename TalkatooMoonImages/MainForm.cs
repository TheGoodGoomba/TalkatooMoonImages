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
        private static string KingdomDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "Cascade");
        private static List<KeyValuePair<string, string>> TalkatooMoons; // Key: Moon ID (as a string); Value: Moon name

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

        private bool MonitorStarting = true;
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (MonitorStarting)
            {
                MonitorStarting = false;
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
                MonitorStarting = true;
                ToggleEnabledWhenMonitoring(true);
                btnMonitor.Text = "Start Monitoring File";
                //btnMonitor.Enabled = true;

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
            TalkatooMoons = new List<KeyValuePair<string, string>>();
            var success = false;
            string[] pendingMoons = null;
            while (!success)
            {
                try
                {
                    pendingMoons = File.ReadAllLines(txtPath.Text);
                    success = true;
                }
                catch
                {
                    Thread.Sleep(100);
                }
            }
            foreach (var moon in pendingMoons)
            {
                var moonSplit = moon.Split(" - ");
                var idNamePair = new KeyValuePair<string, string>(moonSplit[0], moonSplit[1]);
                TalkatooMoons.Add(idNamePair);
            }

            Invoke(() =>
            {
                ClearMoons();
            }); // Invoke() avoids some weird threading error with changing label text in an event method

            if (TalkatooMoons.Count > 0)
            {
                var imagePath = Path.Combine(KingdomDirectory, $"{TalkatooMoons[0].Key}.png");
                picMoon1.ImageLocation = imagePath;
                Invoke(() =>
                {
                    lblMoon1.Text = TalkatooMoons[0].Value;
                });
            }
            if (TalkatooMoons.Count > 1)
            {
                var imagePath = Path.Combine(KingdomDirectory, $"{TalkatooMoons[1].Key}.png");
                picMoon2.ImageLocation = imagePath;
                Invoke(() =>
                {
                    lblMoon2.Text = TalkatooMoons[1].Value;
                });
            }
            if (TalkatooMoons.Count > 2)
            {
                var imagePath = Path.Combine(KingdomDirectory, $"{TalkatooMoons[2].Key}.png");
                picMoon3.ImageLocation = imagePath;
                Invoke(() =>
                {
                    lblMoon3.Text = TalkatooMoons[2].Value;
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
            KingdomDirectory = Kingdoms[CurrentKingdomIndex].GetImageDirectory();
            btnPrevKingdom.Text = $"{(CurrentKingdomIndex == 0 ? "" : Kingdoms[CurrentKingdomIndex - 1])} <<<";
            btnNextKingdom.Text = $">>> {(CurrentKingdomIndex == 9 ? "" : Kingdoms[CurrentKingdomIndex + 1])}";
            lblCurrentKingdom.Text = Kingdoms[CurrentKingdomIndex].Name;

            OnFileChange(null, null);
        }

        private void ClearMoons()
        {
            picMoon1.Image = null;
            picMoon2.Image = null;
            picMoon3.Image = null;
            lblMoon1.Text = "";
            lblMoon2.Text = "";
            lblMoon3.Text = "";
        }

        private void tsiMoonNotes_Click(object sender, EventArgs e)
        {
            var moonSelectForm = new MoonSelectForm();
            moonSelectForm.ShowDialog();
        }
    }
}