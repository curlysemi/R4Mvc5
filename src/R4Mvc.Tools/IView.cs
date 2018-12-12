using System;
using System.Collections.Generic;

namespace R4Mvc.Tools
{
    public interface IView
    {
        bool IsHackyDirectory { get; }

        Uri RelativePath { get; }
        string TemplateKind { get; }
        string Name { get; }

        //Dictionary<string, IEnumerable<IView>> SubFolders { get; }
    }
}
