using System.Text.Json;

namespace RimCompiler
{
    public static class PathManager
    {
        public static string? DebugDll { get; set; } = null; // mod dll
        public static string? RimWorldEXE { get; set; } = null;
        public static string? AssembliesFolder { get; set; } = null;
        public static string? BackupFolder { get; set; } = null;

        public static string BaseDirectory = AppContext.BaseDirectory;
        public static string ModDllName => Path.GetFileName(DebugDll);
        public static string SaveFilePath => Path.Combine(BaseDirectory, "paths.json");


        public static bool IsPathsFilled()
        {
            return (DebugDll != null && RimWorldEXE != null && AssembliesFolder != null && BackupFolder != null);
        }
        public static void SavePaths()
        {
            if (!IsPathsFilled())
                return;

            PathData pathData = new PathData
            {
                DebugDll = DebugDll,
                RimWorldEXE = RimWorldEXE,
                AssembliesFolder = AssembliesFolder,
                BackupFolder = BackupFolder
            };

            var json = JsonSerializer.Serialize(pathData, new JsonSerializerOptions { WriteIndented = true });
            MessageBox.Show("The configuration was saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.WriteAllText(SaveFilePath, json);
        }

        public static void LoadPaths(out bool loaded)
        {
            loaded = false;
            if (!File.Exists(SaveFilePath))
                return;

            var json = File.ReadAllText(SaveFilePath);

            var data = JsonSerializer.Deserialize<PathData>(json);

            if (data != null)
            {
                DebugDll = data.DebugDll;
                RimWorldEXE = data.RimWorldEXE;
                AssembliesFolder = data.AssembliesFolder;
                BackupFolder = data.BackupFolder;
                loaded = true;
            }
        }

    }

}
