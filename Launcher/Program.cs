using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using IWshRuntimeLibrary;
using File = System.IO.File;
using System.Reflection;

namespace Launcher {
    internal static class Program {
        static string horizonInstallPath;
        static ProcessStartInfo start = new ProcessStartInfo();
        static Form1 form;

        public static void Start() {
            horizonInstallPath = Environment.GetEnvironmentVariable("Horizon", EnvironmentVariableTarget.Machine);
            Console.WriteLine(horizonInstallPath);

            string installDir = Environment.ExpandEnvironmentVariables("%AppData%") + "/Horizon/";

            start.FileName = installDir + "/Horizon.exe";
            Console.WriteLine(start.FileName);

            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            int exitCode;

            int run() {
                using (Process proc = Process.Start(start)) {
                    proc.WaitForExit();
                    Console.WriteLine("App Exit");

                    // Retrieve the app's exit code
                    exitCode = proc.ExitCode;
                    form.Close();
                    Console.WriteLine(exitCode);
                    return exitCode;
                }
            }

            if (File.Exists(start.FileName)) {
                Console.WriteLine("starting");
                form.Invis();
                run();
            } else {
                form.Vis();
                Console.WriteLine("Downloading Horizon...");
                Console.WriteLine(installDir);
                string temp = Path.GetTempPath();
                using (var client = new WebClient()) { client.DownloadFile("https://github.com/AW1534/Horizon/releases/latest/download/Horizon.zip", temp + "/Horizon.zip"); }
                Console.WriteLine("Download Complete");
                Console.WriteLine("Installing Horizon...");
                File.Delete(temp + "/Horizon/");
                ZipFile.ExtractToDirectory(temp + "/Horizon.zip", temp + "/Horizon/");
                File.Delete(temp + "/Horizon.zip");
                if (File.Exists(installDir)) { File.Delete(installDir); }
                new DirectoryInfo(Directory.GetDirectories(temp + "/Horizon/")[0]).MoveTo(installDir);   

                List<string> paths = new List<string>();
                paths.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
                paths.Add(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "/Programs/");

                foreach (string path in paths) {
                    string shortcutLocation = path + "/Horizon.lnk";
                    WshShellClass shell = new WshShellClass();
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
                    Console.WriteLine(shortcutLocation + " >> " + installDir);
                    shortcut.TargetPath = installDir + "/Horizon.exe";
                    shortcut.WorkingDirectory = installDir;
                    shortcut.Description = "Launch Horizon";
                    shortcut.IconLocation = installDir + "/IncludeFiles/Logo.ico";
                    shortcut.Save();
                }

                Console.WriteLine("Install Complete");
                Console.WriteLine("Running Horizon...");

                run();
            }
        }


        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Console.WriteLine(form.ShowDialog() == DialogResult.OK);
        }
    }
}
