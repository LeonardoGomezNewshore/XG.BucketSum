using System.Collections.Generic;

namespace XG.BuketSum.Common.Helpers
{
    public interface IFileManager
    {
        void SaveFile(string finalPath, List<string> lines);

        List<string> ReadFile(string startPath);
    }
}