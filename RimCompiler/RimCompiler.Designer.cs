namespace RimCompiler
{
    partial class RimCompiler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_DebugPath = new Label();
            LabelAssembliesPath = new Label();
            LabelDllPath = new Label();
            ButtonSelectDLL = new Button();
            ButtonSelectAssemblies = new Button();
            LabelAssembliesFolderPath = new Label();
            LabelBackupFolderPath = new Label();
            ButtonSelectBackup = new Button();
            LabelBackupFolder = new Label();
            ButtonSelectRimWorld = new Button();
            LabelRimWorldPath = new Label();
            LabelRimWorldEXE = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            ButtonEnableInterception = new Button();
            LabelInterceptionStatus = new Label();
            LabelStatus = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label_DebugPath
            // 
            Label_DebugPath.AutoSize = true;
            Label_DebugPath.Font = new Font("Segoe UI", 15F);
            Label_DebugPath.ForeColor = Color.White;
            Label_DebugPath.Location = new Point(50, 40);
            Label_DebugPath.Margin = new Padding(0, 10, 3, 5);
            Label_DebugPath.Name = "Label_DebugPath";
            Label_DebugPath.Size = new Size(182, 28);
            Label_DebugPath.TabIndex = 0;
            Label_DebugPath.Text = "Project DLL to copy";
            // 
            // LabelAssembliesPath
            // 
            LabelAssembliesPath.AutoSize = true;
            LabelAssembliesPath.Font = new Font("Segoe UI", 15F);
            LabelAssembliesPath.ForeColor = Color.White;
            LabelAssembliesPath.Location = new Point(50, 133);
            LabelAssembliesPath.Margin = new Padding(0, 10, 3, 5);
            LabelAssembliesPath.Name = "LabelAssembliesPath";
            LabelAssembliesPath.Size = new Size(212, 28);
            LabelAssembliesPath.TabIndex = 2;
            LabelAssembliesPath.Text = "Mod Assemblies folder";
            // 
            // LabelDllPath
            // 
            LabelDllPath.AutoSize = true;
            LabelDllPath.Font = new Font("Segoe UI", 10F);
            LabelDllPath.ForeColor = Color.FromArgb(97, 108, 122);
            LabelDllPath.Location = new Point(53, 73);
            LabelDllPath.Name = "LabelDllPath";
            LabelDllPath.Size = new Size(26, 19);
            LabelDllPath.TabIndex = 1;
            LabelDllPath.Text = "file";
            LabelDllPath.Visible = false;
            // 
            // ButtonSelectDLL
            // 
            ButtonSelectDLL.BackColor = Color.FromArgb(106, 81, 46);
            ButtonSelectDLL.FlatAppearance.BorderColor = Color.FromArgb(125, 97, 51);
            ButtonSelectDLL.FlatStyle = FlatStyle.Flat;
            ButtonSelectDLL.Font = new Font("Segoe UI", 11F);
            ButtonSelectDLL.ForeColor = Color.White;
            ButtonSelectDLL.Location = new Point(50, 92);
            ButtonSelectDLL.Margin = new Padding(0);
            ButtonSelectDLL.Name = "ButtonSelectDLL";
            ButtonSelectDLL.Size = new Size(131, 31);
            ButtonSelectDLL.TabIndex = 12;
            ButtonSelectDLL.Text = "Select file";
            ButtonSelectDLL.UseVisualStyleBackColor = false;
            ButtonSelectDLL.Click += ButtonSelectDLL_Click;
            // 
            // ButtonSelectAssemblies
            // 
            ButtonSelectAssemblies.BackColor = Color.FromArgb(106, 81, 46);
            ButtonSelectAssemblies.FlatAppearance.BorderColor = Color.FromArgb(125, 97, 51);
            ButtonSelectAssemblies.FlatStyle = FlatStyle.Flat;
            ButtonSelectAssemblies.Font = new Font("Segoe UI", 11F);
            ButtonSelectAssemblies.ForeColor = Color.White;
            ButtonSelectAssemblies.Location = new Point(50, 185);
            ButtonSelectAssemblies.Margin = new Padding(0);
            ButtonSelectAssemblies.Name = "ButtonSelectAssemblies";
            ButtonSelectAssemblies.Size = new Size(131, 31);
            ButtonSelectAssemblies.TabIndex = 13;
            ButtonSelectAssemblies.Text = "Select folder";
            ButtonSelectAssemblies.UseVisualStyleBackColor = false;
            ButtonSelectAssemblies.Click += ButtonSelectAssemblies_Click;
            // 
            // LabelAssembliesFolderPath
            // 
            LabelAssembliesFolderPath.AutoSize = true;
            LabelAssembliesFolderPath.Font = new Font("Segoe UI", 10F);
            LabelAssembliesFolderPath.ForeColor = Color.FromArgb(97, 108, 122);
            LabelAssembliesFolderPath.Location = new Point(53, 166);
            LabelAssembliesFolderPath.Name = "LabelAssembliesFolderPath";
            LabelAssembliesFolderPath.Size = new Size(44, 19);
            LabelAssembliesFolderPath.TabIndex = 14;
            LabelAssembliesFolderPath.Text = "folder";
            LabelAssembliesFolderPath.Visible = false;
            // 
            // LabelBackupFolderPath
            // 
            LabelBackupFolderPath.AutoSize = true;
            LabelBackupFolderPath.Font = new Font("Segoe UI", 10F);
            LabelBackupFolderPath.ForeColor = Color.FromArgb(97, 108, 122);
            LabelBackupFolderPath.Location = new Point(53, 259);
            LabelBackupFolderPath.Name = "LabelBackupFolderPath";
            LabelBackupFolderPath.Size = new Size(44, 19);
            LabelBackupFolderPath.TabIndex = 17;
            LabelBackupFolderPath.Text = "folder";
            LabelBackupFolderPath.Visible = false;
            // 
            // ButtonSelectBackup
            // 
            ButtonSelectBackup.BackColor = Color.FromArgb(106, 81, 46);
            ButtonSelectBackup.FlatAppearance.BorderColor = Color.FromArgb(125, 97, 51);
            ButtonSelectBackup.FlatStyle = FlatStyle.Flat;
            ButtonSelectBackup.Font = new Font("Segoe UI", 11F);
            ButtonSelectBackup.ForeColor = Color.White;
            ButtonSelectBackup.Location = new Point(50, 278);
            ButtonSelectBackup.Margin = new Padding(0);
            ButtonSelectBackup.Name = "ButtonSelectBackup";
            ButtonSelectBackup.Size = new Size(131, 31);
            ButtonSelectBackup.TabIndex = 16;
            ButtonSelectBackup.Text = "Select folder";
            ButtonSelectBackup.UseVisualStyleBackColor = false;
            ButtonSelectBackup.Click += ButtonSelectBackup_Click;
            // 
            // LabelBackupFolder
            // 
            LabelBackupFolder.AutoSize = true;
            LabelBackupFolder.Font = new Font("Segoe UI", 15F);
            LabelBackupFolder.ForeColor = Color.White;
            LabelBackupFolder.Location = new Point(50, 226);
            LabelBackupFolder.Margin = new Padding(0, 10, 3, 5);
            LabelBackupFolder.Name = "LabelBackupFolder";
            LabelBackupFolder.Size = new Size(132, 28);
            LabelBackupFolder.TabIndex = 15;
            LabelBackupFolder.Text = "Backup folder";
            // 
            // ButtonSelectRimWorld
            // 
            ButtonSelectRimWorld.BackColor = Color.FromArgb(106, 81, 46);
            ButtonSelectRimWorld.FlatAppearance.BorderColor = Color.FromArgb(125, 97, 51);
            ButtonSelectRimWorld.FlatStyle = FlatStyle.Flat;
            ButtonSelectRimWorld.Font = new Font("Segoe UI", 11F);
            ButtonSelectRimWorld.ForeColor = Color.White;
            ButtonSelectRimWorld.Location = new Point(50, 371);
            ButtonSelectRimWorld.Margin = new Padding(0);
            ButtonSelectRimWorld.Name = "ButtonSelectRimWorld";
            ButtonSelectRimWorld.Size = new Size(131, 31);
            ButtonSelectRimWorld.TabIndex = 20;
            ButtonSelectRimWorld.Text = "Select file";
            ButtonSelectRimWorld.UseVisualStyleBackColor = false;
            ButtonSelectRimWorld.Click += ButtonSelectRimWorld_Click;
            // 
            // LabelRimWorldPath
            // 
            LabelRimWorldPath.AutoSize = true;
            LabelRimWorldPath.Font = new Font("Segoe UI", 10F);
            LabelRimWorldPath.ForeColor = Color.FromArgb(97, 108, 122);
            LabelRimWorldPath.Location = new Point(53, 352);
            LabelRimWorldPath.Name = "LabelRimWorldPath";
            LabelRimWorldPath.Size = new Size(26, 19);
            LabelRimWorldPath.TabIndex = 19;
            LabelRimWorldPath.Text = "file";
            LabelRimWorldPath.Visible = false;
            // 
            // LabelRimWorldEXE
            // 
            LabelRimWorldEXE.AutoSize = true;
            LabelRimWorldEXE.Font = new Font("Segoe UI", 15F);
            LabelRimWorldEXE.ForeColor = Color.White;
            LabelRimWorldEXE.Location = new Point(50, 319);
            LabelRimWorldEXE.Margin = new Padding(0, 10, 3, 5);
            LabelRimWorldEXE.Name = "LabelRimWorldEXE";
            LabelRimWorldEXE.Size = new Size(198, 28);
            LabelRimWorldEXE.TabIndex = 18;
            LabelRimWorldEXE.Text = "RimWorld executable";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(21, 25, 29);
            flowLayoutPanel1.Controls.Add(Label_DebugPath);
            flowLayoutPanel1.Controls.Add(LabelDllPath);
            flowLayoutPanel1.Controls.Add(ButtonSelectDLL);
            flowLayoutPanel1.Controls.Add(LabelAssembliesPath);
            flowLayoutPanel1.Controls.Add(LabelAssembliesFolderPath);
            flowLayoutPanel1.Controls.Add(ButtonSelectAssemblies);
            flowLayoutPanel1.Controls.Add(LabelBackupFolder);
            flowLayoutPanel1.Controls.Add(LabelBackupFolderPath);
            flowLayoutPanel1.Controls.Add(ButtonSelectBackup);
            flowLayoutPanel1.Controls.Add(LabelRimWorldEXE);
            flowLayoutPanel1.Controls.Add(LabelRimWorldPath);
            flowLayoutPanel1.Controls.Add(ButtonSelectRimWorld);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50, 30, 30, 20);
            flowLayoutPanel1.Size = new Size(684, 576);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(106, 81, 46);
            button1.FlatAppearance.BorderColor = Color.FromArgb(125, 97, 51);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(195, 634);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(131, 31);
            button1.TabIndex = 21;
            button1.Text = "Save Config";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ButtonEnableInterception
            // 
            ButtonEnableInterception.BackColor = Color.FromArgb(106, 81, 46);
            ButtonEnableInterception.FlatAppearance.BorderColor = Color.FromArgb(125, 97, 51);
            ButtonEnableInterception.FlatStyle = FlatStyle.Flat;
            ButtonEnableInterception.Font = new Font("Segoe UI", 11F);
            ButtonEnableInterception.ForeColor = Color.White;
            ButtonEnableInterception.Location = new Point(27, 634);
            ButtonEnableInterception.Margin = new Padding(0);
            ButtonEnableInterception.Name = "ButtonEnableInterception";
            ButtonEnableInterception.Size = new Size(154, 31);
            ButtonEnableInterception.TabIndex = 22;
            ButtonEnableInterception.Text = "\tEnable Interception";
            ButtonEnableInterception.UseVisualStyleBackColor = false;
            ButtonEnableInterception.Click += ButtonEnableInterception_Click;
            // 
            // LabelInterceptionStatus
            // 
            LabelInterceptionStatus.AutoSize = true;
            LabelInterceptionStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInterceptionStatus.ForeColor = Color.White;
            LabelInterceptionStatus.Location = new Point(351, 634);
            LabelInterceptionStatus.Name = "LabelInterceptionStatus";
            LabelInterceptionStatus.Size = new Size(185, 28);
            LabelInterceptionStatus.TabIndex = 23;
            LabelInterceptionStatus.Text = "Interception Status: ";
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelStatus.Location = new Point(532, 634);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(88, 28);
            LabelStatus.TabIndex = 24;
            LabelStatus.Text = "Disabled";
            // 
            // RimCompiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 17, 19);
            ClientSize = new Size(684, 680);
            Controls.Add(LabelStatus);
            Controls.Add(LabelInterceptionStatus);
            Controls.Add(ButtonEnableInterception);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            ForeColor = Color.FromArgb(97, 108, 122);
            Name = "RimCompiler";
            Padding = new Padding(0, 40, 0, 30);
            Text = "RimCompiler";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label Label_DebugPath;
        private Label LabelAssembliesPath;
        private Label LabelDllPath;
        private Button ButtonSelectDLL;
        private Button ButtonSelectAssemblies;
        private Label LabelAssembliesFolderPath;
        private Label LabelBackupFolderPath;
        private Button ButtonSelectBackup;
        private Label LabelBackupFolder;
        private Button ButtonSelectRimWorld;
        private Label LabelRimWorldPath;
        private Label LabelRimWorldEXE;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button ButtonEnableInterception;
        private Label LabelInterceptionStatus;
        private Label LabelStatus;
    }
}
