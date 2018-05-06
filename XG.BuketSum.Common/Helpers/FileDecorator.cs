using System.IO;

namespace XG.BuketSum.Common.Helpers
{
    public class FileDecorator : IFileDecorator
    {
        public bool ExistPath(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                return File.Exists(path);
            }
            return false;
        }

        public FileStream CreateFile(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                return File.Create(path);
            }
            return null;
        }

        public void DeleteFile(string path)
        {
            if (!string.IsNullOrEmpty(path) && this.ExistPath(path))
            {
                File.Delete(path);
            }
        }
    }
}
