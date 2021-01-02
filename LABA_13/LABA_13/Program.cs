using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LABA_13
{
    class Program
    {
        public class DSNLog
        {
            readonly DateTime DateNow = DateTime.Now;
            public void WriteFile(string action, string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug\netcoreapp3.1\DSNLog.txt", string fileName = "DSNLog.txt")
            {
                using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                {
                    sw.WriteLine("Имя файла: " + fileName);
                    sw.WriteLine("Путь к файлу " + path);
                    sw.WriteLine("Дата создания: " + DateNow);
                    sw.WriteLine(action);
                    sw.WriteLine();
                }
            }

            public void WriteFile(List<string> action, string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug\netcoreapp3.1\DSNLog.txt", string fileName = "DSNLog.txt")
            {
                using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
                {
                    sw.WriteLine("Имя файла: " + fileName);
                    sw.WriteLine("Путь к файлу " + path);
                    sw.WriteLine("Дата создания: " + DateNow);
                    foreach (string item in action)
                    {
                        sw.WriteLine(item);
                    }
                    sw.WriteLine();
                }
            }
        }

        public class DSNDiskInfo
        {
            private string actionOne;
            public string FreeSpace()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    actionOne = "Свободное место на диске в байтах: " + drive.AvailableFreeSpace.ToString();
                }
                return actionOne;
            }
            public string FileSystem()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    actionOne = "Файловая система: " + drive.DriveFormat.ToString();
                }
                return actionOne;
            }
            public string Disk()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    actionOne = "Имя диска: " + drive.Name + ". ";
                    actionOne += "Объём: " + drive.TotalFreeSpace + "байт. ";
                    actionOne += "Доступный объём: " + drive.AvailableFreeSpace + "байт. ";
                    actionOne += "Метка тома: " + drive.VolumeLabel + ". ";
                }
                return actionOne;
            }
        }


        class DSNFileInfo
        {
            private string action;
            public string FullPath(string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug\netcoreapp3.1\DSNLog.txt")
            {
                FileInfo f = new FileInfo(path);
                action = "Полный путь к файлу: " + f.DirectoryName;
                return action;
            }
            public string Info(string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug\netcoreapp3.1\DSNLog.txt")
            {
                FileInfo f = new FileInfo(path);
                action = "Размер: " + f.Length + "байт. ";
                action += "Расширение: " + f.Extension + ". ";
                action += "Имя: " + f.FullName + ". ";
                return action;
            }
            public string Dates(string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug\netcoreapp3.1\DSNLog.txt")
            {
                FileInfo f = new FileInfo(path);
                action = "Дата создания: " + f.CreationTime + ". ";
                action += "Дата изменения: " + f.LastWriteTime + ". ";
                return action;
            }
        }
        class DSNDirInfo
        {
            private string action;
            public string AmountOfFiles(string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug")
            {
                int amount = 0;
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    amount++;
                }
                action = "Количество файлов в " + path + ": " + amount;
                return action;
            }
            public string CreateDate(string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug")
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                action = "Дата создания: " + directory.CreationTime;
                return action;
            }
            public string AmountDirs(string path = @"D:\kurs\LABS\LABA_13\LABA_13\bin\Debug")
            {
                int amount = 0;
                DirectoryInfo directory = new DirectoryInfo(path);
                DirectoryInfo[] directories = directory.GetDirectories();
                foreach (DirectoryInfo info in directories)
                {
                    amount++;
                }
                action = "Количество каталогов: " + amount;
                return action;
            }
            public string Parent(string path = @"D:\kurs\LABS")
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                action = "Родительский каталог: " + directory.Parent;
                return action;
            }
        }

        public class DSNFileManager
        {
            private List<string> action = new List<string>();
            public List<string> FilesAndDirsList(string diskName = @"D:\")
            {
                string[] fileList = Directory.GetFiles(diskName);
                action.Add("Файлы: ");
                foreach (string file in fileList)
                {
                    action.Add(file);
                }
                string[] dirList = Directory.GetDirectories(diskName);
                action.Add("Папки: ");
                foreach (string dir in dirList)
                {
                    action.Add(dir);
                }
                return action;
            }
        }
        static void Main(string[] args)
        {
            DSNLog log = new DSNLog();

            DSNDiskInfo diskInfo = new DSNDiskInfo();

            log.WriteFile(diskInfo.FreeSpace());
            log.WriteFile(diskInfo.FileSystem());
            log.WriteFile(diskInfo.Disk());

            DSNFileInfo fileInfo = new DSNFileInfo();

            log.WriteFile(fileInfo.FullPath());
            log.WriteFile(fileInfo.Info());
            log.WriteFile(fileInfo.Dates());

            DSNDirInfo dirInfo = new DSNDirInfo();

            log.WriteFile(dirInfo.AmountOfFiles());
            log.WriteFile(dirInfo.CreateDate());
            log.WriteFile(dirInfo.AmountDirs());
            log.WriteFile(dirInfo.Parent());
        }
    }
}
