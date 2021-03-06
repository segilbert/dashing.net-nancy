﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashing
{
    public class FileSystem : IFileSystem
    {
        public IEnumerable<string> EnumerateFiles(string dir, string searchPattern)
        {
            return Directory.EnumerateFiles(dir, searchPattern, SearchOption.AllDirectories);
        }

        public void Copy(string source, string dest, bool overwrite)
        {
            File.Copy(source, dest, overwrite);
        }

        public bool DirectoryExists(string path)
        {
            return Directory.Exists(path);
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }

        public string CurrentDirectory
        {
            get { return Environment.CurrentDirectory; }
        }

        public DateTime GetLastWriteTime(string file)
        {
            return File.GetLastWriteTime(file);
        }
    }
}