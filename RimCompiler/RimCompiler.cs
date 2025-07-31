using Button = System.Windows.Forms.Button;

namespace RimCompiler
{
    public partial class RimCompiler : Form
    {
        public RimCompiler()
        {
            InitializeComponent();
            PathManager.LoadPaths(out bool loaded);

            if (loaded)
            {
                LabelDllPath.Text = PathManager.DebugDll;
                LabelAssembliesFolderPath.Text = PathManager.AssembliesFolder;
                LabelBackupFolderPath.Text = PathManager.BackupFolder;
                LabelRimWorldPath.Text = PathManager.RimWorldEXE;

                LabelDllPath.Visible = true;
                LabelAssembliesFolderPath.Visible = true;
                LabelBackupFolderPath.Visible = true;
                LabelRimWorldPath.Visible = true;

                ButtonSelectDLL.Margin = new Padding(0, 10, 10, 10);
                ButtonSelectBackup.Margin = new Padding(0, 10, 10, 10);
                ButtonSelectAssemblies.Margin = new Padding(0, 10, 10, 10);
                ButtonSelectRimWorld.Margin = new Padding(0, 10, 10, 10);
            }

        }

        private void OpenItemDialog(string title, Label pathLabel, Button button, out string? path, string? filter = null)
        {
            path = null;
            if (filter != null)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = title;

                    openFileDialog.Filter = filter;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = openFileDialog.FileName;
                        pathLabel.Text = path;
                        button.Margin = new Padding(0, 10, 10, 10);
                        pathLabel.Visible = true;
                    }
                }
                return;
            }


            using (FolderBrowserDialog browserDialog = new FolderBrowserDialog())
            {
                browserDialog.Description = title;

                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = browserDialog.SelectedPath;
                    pathLabel.Text = path;
                    button.Margin = new Padding(0, 10, 10, 10);
                    pathLabel.Visible = true;
                }
            }
        }

        private void ButtonSelectDLL_Click(object sender, EventArgs e)
        {
            OpenItemDialog("Select the DLL file to copy", LabelDllPath, ButtonSelectDLL, out string? path, "(*.dll)|*.dll");
            if (path != null)
                PathManager.DebugDll = path;
        }

        private void ButtonSelectAssemblies_Click(object sender, EventArgs e)
        {
            OpenItemDialog("Select your mod Assemblies folder", LabelAssembliesFolderPath, ButtonSelectAssemblies, out string? path);
            if (path != null)
                PathManager.AssembliesFolder = path;
        }

        private void ButtonSelectBackup_Click(object sender, EventArgs e)
        {
            OpenItemDialog("Select your backup folder", LabelBackupFolderPath, ButtonSelectBackup, out string? path);
            if (path != null)
                PathManager.BackupFolder = path;
        }

        private void ButtonSelectRimWorld_Click(object sender, EventArgs e)
        {
            OpenItemDialog("Select the RimWorld executable file", LabelRimWorldPath, ButtonSelectRimWorld, out string? path, "(*.exe)|*.exe");
            if (path != null)
                PathManager.RimWorldEXE = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PathManager.SavePaths();
        }

        private async void ButtonEnableInterception_Click(object sender, EventArgs e)
        {
            bool isIntercepting = InterceptMonitor.IsIntercepting;
            if (!PathManager.IsPathsFilled())
            {
                MessageBox.Show("Fill in the paths first before starting the interception.", "Unable to Start", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isIntercepting = !isIntercepting;

            string buttonText = isIntercepting ? "Disable Interception" : "Enable Interception";

            string status = isIntercepting ? "Enabled" : "Disabled";

            Color statusColor = isIntercepting ? Color.LightGreen : Color.FromArgb(97, 108, 122);

            ButtonEnableInterception.Text = buttonText;
            LabelStatus.Text = status;
            LabelStatus.ForeColor = statusColor;

            if (isIntercepting)
                await InterceptMonitor.StartMonitoringDllChangeAsync();

        }
    }
}
