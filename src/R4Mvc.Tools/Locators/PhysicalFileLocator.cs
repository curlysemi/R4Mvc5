using System.IO;

namespace R4Mvc.Tools.Locators
{
    public class PhysicalFileLocator : IFileLocator
    {
        public bool DirectoryExists(string path)
            => Directory.Exists(path);

        public string[] GetDirectories(string parentPath, bool recurse = false)
            => Directory.GetDirectories(parentPath, "*", recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

        public string[] GetFiles(string parentPath, string filter, bool recurse = false)
        {
            if (!DirectoryExists(parentPath))
                return new string[0];
            return Directory.GetFiles(parentPath, filter, recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        }
    }
}
