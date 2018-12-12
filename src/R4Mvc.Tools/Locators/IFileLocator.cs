namespace R4Mvc.Tools.Locators
{
    public interface IFileLocator
    {
        string[] GetFiles(string parentPath, string filter, bool recurse = false);
        string[] GetDirectories(string parentPath, bool recurse = false);
        bool DirectoryExists(string path);
    }
}
