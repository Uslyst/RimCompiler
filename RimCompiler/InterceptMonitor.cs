using System.Diagnostics;

namespace RimCompiler
{
    public static class InterceptMonitor
    {
        public static bool IsIntercepting = false;
        public static string? ModDllName = Path.GetFileName(PathManager.DebugDll);
        public static DateTime DllSnapshot = DateTime.MinValue;
        public static bool IsFirstStart = true;
        public static async Task StartMonitoringDllChangeAsync()
        {
            if (PathManager.DebugDll == null)
            {
                MessageBox.Show("Unable to monitor the provided mod DLL - DebugDll was null.", "Unable to Monitor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsIntercepting = false;
                return;
            }

            IsIntercepting = true;
            await MonitorDLLChangeAsync();
        }
 
        public static async Task MonitorDLLChangeAsync()
        {
            while (IsIntercepting)
            {
                try
                {
                    if (File.Exists(PathManager.DebugDll))
                    {
                        DateTime currentTime = File.GetLastWriteTime(PathManager.DebugDll);
                        //MessageBox.Show(currentTime.ToString());
                        if (IsFirstStart)
                        {
                            DllSnapshot = currentTime;
                            IsFirstStart = false;
                        }

                        if (DllSnapshot != DateTime.MinValue && currentTime != DllSnapshot)
                        {
                            IsIntercepting = false;

                            var result = Prompt.ShowDialog(
      "RimCompiler detected a DLL change.",
      "Enter a backup name for the old DLL. Avoid: / \\ : * ? \" < > |",
      "DLL Change Detected",
      out string outputTex
  );

                            if (result == DialogResult.OK)
                                InterceptDll(outputTex);

                            DllSnapshot = currentTime;
                            IsIntercepting = true;
                        }
                        else
                        {
                            DllSnapshot = currentTime;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error monitoring DLL: " + ex.Message);
                    IsIntercepting = false;
                }

                await Task.Delay(1000);
            }
        }

        public static void InterceptDll(string backupName)
        {
            bool doBackupName = !string.IsNullOrEmpty(backupName);

            if (doBackupName)
            {
                backupName = SanitizeFileName(backupName);
            }

            string targetPath = Path.Combine(
                PathManager.BackupFolder,
                PathManager.ModDllName + (doBackupName ? $" ({backupName})" : "")
            );
 
            string assembliesFile = Path.Combine(PathManager.AssembliesFolder, PathManager.ModDllName);
           
            foreach (Process process in Process.GetProcessesByName("RimWorldWin64"))
            {
                try
                {
                    process.Kill();
                    process.WaitForExit(2000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to close RimWorld process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

          
            if(File.Exists(assembliesFile))
            {
                File.Copy(assembliesFile, targetPath, !doBackupName);
            }

            File.Copy(PathManager.DebugDll, assembliesFile, true);

            Process.Start(PathManager.RimWorldEXE);
        }

        private static string SanitizeFileName(string input)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                input = input.Replace(c, '_');
            }
            return input;
        }

    }

}
