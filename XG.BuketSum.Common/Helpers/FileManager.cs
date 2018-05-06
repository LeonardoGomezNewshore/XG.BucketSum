
using System.Collections.Generic;
using System.IO;

namespace XG.BuketSum.Common.Helpers
{
    public class FileManager : IFileManager
    {
        private IFileDecorator fileDecorator;

        public FileManager(IFileDecorator fileDecorator)
        {
            this.fileDecorator = fileDecorator;
        }

        public List<string> ReadFile(string startPath)
        {
            List<string> lines = new List<string>();

            if (fileDecorator.ExistPath(startPath) && !string.IsNullOrEmpty(startPath))
            {
                using (StreamReader sr = new StreamReader(startPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

            }
            return lines;
        }

        public void SaveFile(string finalPath, List<string> lines)
        {
            if (!string.IsNullOrEmpty(finalPath) && lines != null && lines.Count > 0)
            {
                fileDecorator.DeleteFile(finalPath);

                using (TextWriter newLine = new StreamWriter(finalPath))
                {
                    foreach (string line in lines)
                    {
                        newLine.WriteLine(line);
                    }
                }
            }
        }
    }

}