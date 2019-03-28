using System;
using System.Collections.Generic;
using System.IO;
using AOIFileTransferToDiffFolder.Model;
using AOIFileTransferToDiffFolder.ComTool;

namespace AOIFileTransferToDiffFolder.BLL
{
    class FileBll
    {
        private void checkFolderExistsAndCreate(string folder)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }

        public bool initConfig(string configFile)
        {
            bool oResult = false;
            if (File.Exists(configFile))
            {
                var config = ConfigFile.LoadFile(configFile);
                BasicData.SouceFolder = config.GetConfigValue("SouceFolder");
                string target1 = config.GetConfigValue("TargetFolder1");
                string target2 = config.GetConfigValue("TargetFolder2");
                string target3 = config.GetConfigValue("TargetFolder3");
                List<string> folderList = new List<string>();
                if (!string.IsNullOrEmpty(target1))
                {
                    folderList.Add(target1);
                }
                if (!string.IsNullOrEmpty(target2))
                {
                    folderList.Add(target2);
                }
                if (!string.IsNullOrEmpty(target3))
                {
                    folderList.Add(target3);
                }
                BasicData.TargetFolderList = folderList;
                if (BasicData.TargetFolderList.Count > 0)
                {
                    oResult = true;
                }
            }

            return oResult;
        }


        public void transferFileToDiffFolder()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(BasicData.SouceFolder);
            FileInfo[] arrFiles = dirInfo.GetFiles();
            int fileCount = arrFiles.Length;
            string targetFlolder = string.Empty;
            string TargetFileName = string.Empty;
            int FolderListCount = BasicData.TargetFolderList.Count;
            for (int i = 0; i < fileCount; i++)
            {
                targetFlolder = BasicData.TargetFolderList[i % FolderListCount];
                FileInfo fileInfo = arrFiles[i];
                if (fileInfo.Exists)
                {
                    TargetFileName = targetFlolder + Path.GetFileName(fileInfo.Name);
                    FileInfo fi = new FileInfo(TargetFileName);
                    if (fi.Exists)  //如果目标文件已存在就直接删除源文件，否则就转移到新目录
                    {
                        fileInfo.Delete();
                    }
                    else
                    {
                        fileInfo.MoveTo(TargetFileName);
                    }
                }
            }
            refreshFilesQty();
        }

        private void refreshFilesQty()
        {
            DirectoryInfo dirInfoSource = new DirectoryInfo(BasicData.SouceFolder);
            BasicData.SouceFileQty = dirInfoSource.GetFiles().Length;
            List<int> TargetFileQtyList = new List<int>();
            BasicData.TargetFolderList.ForEach(obj => {
                DirectoryInfo dirInfoTarget = new DirectoryInfo(obj);
                TargetFileQtyList.Add(dirInfoTarget.GetFiles().Length);
            });
            BasicData.TargetFileQtyList = TargetFileQtyList;
        }

    }
}
