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

        public Form1()
        {
            InitializeComponent();

            picMoon1.ImageLocation = @"C:\src\TalkatooMoonImages\SMO\Cascade\300px-SMO_Cascade_Moon_1.png";
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
                btnMonitor.Text = "Stop Monitoring File";

                Watcher = new FileSystemWatcher();
                Watcher.Path = Directory.GetParent(txtPath.Text).ToString();
                Watcher.Filter = Path.GetFileName(txtPath.Text);
                Watcher.Changed += OnFileChange;
            }
            else
            {
                MonitorStarting = true;
                txtPath.Enabled = true;
                btnMonitor.Text = "Start Monitoring File";
                btnMonitor.Enabled = true;

                Watcher.Dispose();
            }
        }

        private void OnFileChange(object sender, FileSystemEventArgs e)
        {

        }

        private void btnNextKingdom_Click(object sender, EventArgs e)
        {
            if (CurrentKingdomIndex != 9)
            {
                CurrentKingdomIndex++;
                UpdateKingdomButtons();
            }
        }

        private void btnPrevKingdom_Click(object sender, EventArgs e)
        {
            if (CurrentKingdomIndex != 0)
            {
                CurrentKingdomIndex--;
                UpdateKingdomButtons();
            }
        }

        private void UpdateKingdomButtons()
        {
            btnPrevKingdom.Text = $"{(CurrentKingdomIndex == 0 ? "" : Kingdoms[CurrentKingdomIndex - 1])} <<<";
            btnNextKingdom.Text = $">>> {(CurrentKingdomIndex == 9 ? "" : Kingdoms[CurrentKingdomIndex + 1])}";
            lblCurrentKingdom.Text = Kingdoms[CurrentKingdomIndex];
        }
    }
}