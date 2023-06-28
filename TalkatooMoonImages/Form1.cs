namespace TalkatooMoonImages
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher _watcher;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtPath.Text = openFileDialog.FileName;
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

        private bool _starting = true;
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (_starting)
            {
                _starting = false;
                txtPath.Enabled = false;
                btnMonitor.Text = "Stop Monitoring File";

                _watcher = new FileSystemWatcher();
                _watcher.Path = Directory.GetParent(txtPath.Text).ToString();
                _watcher.Filter = Path.GetFileName(txtPath.Text);
                _watcher.Changed += OnFileChange;
            }
            else
            {
                _starting = true;
                txtPath.Enabled = true;
                btnMonitor.Text = "Start Monitoring File";
                btnMonitor.Enabled = true;

                _watcher.Dispose();
            }
        }

        private void OnFileChange(object sender, FileSystemEventArgs e)
        {
            
        }
    }
}