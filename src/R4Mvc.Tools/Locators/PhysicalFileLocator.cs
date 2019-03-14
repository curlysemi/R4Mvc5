using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace R4Mvc.Tools.Locators
{
    public class PhysicalFileLocator : IFileLocator
    {
        public bool DirectoryExists(string path)
            => Directory.Exists(path);

        public string[] GetDirectories(string parentPath, bool recurse = false)
            => Directory.GetDirectories(parentPath, "*", recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

        public string[] GetFiles(string parentPath, string filter, bool recurse = false, string[] blacklistedDirectories = null)
        {
            if (!DirectoryExists(parentPath))
                return new string[0];

            if (blacklistedDirectories?.Any() != true || !recurse)
            {
                return Directory.GetFiles(parentPath, filter, recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            }
            else
            {
                var files = new List<string>();

                // get all files in the current directory
                //// don't worry about excluded files by extension yet . . . that filtering happens after this call
                var topFiles = Directory.GetFiles(parentPath, filter, SearchOption.TopDirectoryOnly);
                if (topFiles?.Any() == true)
                {
                    files.AddRange(topFiles);
                }

                // get all directories in the current directory
                var otherDirectories = Directory.GetDirectories(parentPath, filter, SearchOption.TopDirectoryOnly);
                if (otherDirectories?.Any() == true)
                {
                    // check that each directory isn't 'blacklisted'
                    foreach (var directory in otherDirectories)
                    {
                        var thisDirectoryName = Path.GetFileName(directory);
                        if (!blacklistedDirectories.Contains(thisDirectoryName))
                        {
                            // recursively get the files in each non-blacklisted directory
                            var theseFiles = Directory.GetFiles(directory, filter, SearchOption.AllDirectories);
                            if (theseFiles?.Any() == true)
                            {
                                files.AddRange(theseFiles);
                            }
                        }
                    }
                }

                return files.ToArray();
            }
        }
    }
}
