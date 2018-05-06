using System.IO;

namespace XG.BuketSum.Common.Helpers
{
    public interface IFileDecorator
    {
        FileStream CreateFile(string path);

        void DeleteFile(string path);

        bool ExistPath(string path);
    }
}