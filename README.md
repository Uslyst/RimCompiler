# RimWorld DLL Interceptor - RimCompiler

A small WinForms utility built in C# to eliminate the repetitive and manual process of copying DLL files when developing mods for **RimWorld**.

## 🚀 What It Does

This tool automatically detects when your Visual Studio project builds a new DLL in the Debug folder and:

- Creates a backup of the previous DLL from your mod's **Assemblies** folder
- Copies the newly built DLL into the Assemblies folder
- Closes RimWorld if it’s running
- Launches RimWorld again

All of this with a single click.

---

## ⚙️ How to Use

1. Open the app and configure the following paths:
   - Your mod’s **Debug DLL** path (from Visual Studio)
   - The **Assemblies** folder path (inside your RimWorld mod)
   - The **RimWorld executable** path

2. Click **Save Configuration** to persist your settings.

3. Click **Enable Interception** to begin monitoring.

Whenever you build your project, the app will detect the updated DLL and show a confirmation dialog. Upon confirmation, it will handle the entire update process automatically.

---

## 🧩 Common Issue: "Prompt window does not appear"

**Solution 1:**  
The prompt window may have opened minimized—check your taskbar or click the app icon to bring it forward.

**Solution 2:**  
Ensure that all configured paths are valid and pointing to the correct folders and files.

---

## 💡 Why This Exists

Modding RimWorld involves frequent DLL replacements during development. Doing it manually every time is tedious and error-prone. This tool speeds up your workflow and reduces human error by automating the process—so you can focus on building your mod, not on copy-pasting files.

---

## 📂 Example Use Case

- You're editing your RimWorld mod in Visual Studio.
- You hit **Build** (Ctrl+Shift+B).
- The app detects the new DLL.
- You confirm the replacement.
- Your mod DLL is updated, RimWorld restarts, and you're ready to test.

---

Feel free to fork, contribute, or suggest features!
