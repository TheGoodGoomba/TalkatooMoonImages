namespace TalkatooMoonImages
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher Watcher;
        private static List<string> Kingdoms = new List<string>
        {
            "Cascade",
            "Sand",
            "Wooded",
            "Lake",
            "Lost",
            "Metro",
            "Snow",
            "Seaside",
            "Luncheon",
            "Bowser's"
        };
        private static int CurrentKingdomIndex = 0;
        private static string KingdomDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images", "Cascade");
        private static List<KeyValuePair<string, string>> TalkatooMoons; // Key: Moon ID (as a string); Value: Moon name

        public Form1()
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
                txtPath.Enabled = false;
                btnBrowse.Enabled = false;
                btnMonitor.Text = "Stop Monitoring File";

                Watcher = new FileSystemWatcher();
                Watcher.Path = Directory.GetParent(txtPath.Text).ToString();
                Watcher.Filter = Path.GetFileName(txtPath.Text);
                Watcher.Changed += OnFileChange;
                Watcher.EnableRaisingEvents = true;
            }
            else
            {
                MonitorStarting = true;
                txtPath.Enabled = true;
                btnBrowse.Enabled = true;
                btnMonitor.Text = "Start Monitoring File";
                btnMonitor.Enabled = true;

                Watcher.Dispose();
            }
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
            KingdomDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Images", Kingdoms[CurrentKingdomIndex]);
            btnPrevKingdom.Text = $"{(CurrentKingdomIndex == 0 ? "" : Kingdoms[CurrentKingdomIndex - 1])} <<<";
            btnNextKingdom.Text = $">>> {(CurrentKingdomIndex == 9 ? "" : Kingdoms[CurrentKingdomIndex + 1])}";
            lblCurrentKingdom.Text = Kingdoms[CurrentKingdomIndex];

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
    }
}