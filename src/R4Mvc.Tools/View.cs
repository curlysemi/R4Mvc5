using System;
using System.Collections.Generic;
using System.Linq;

namespace R4Mvc.Tools
{
    public class View : IView
    {
        public View(string areaName, string controllerName, string viewName, Uri relativePath, string templateKind, Dictionary<string, IEnumerable<View>> subFolders = null)
        {
            AreaName = areaName;
            ControllerName = controllerName;
            Name = viewName;
            RelativePath = relativePath;
            TemplateKind = templateKind;

            SubFolders = subFolders ?? new Dictionary<string, IEnumerable<View>>();
        }

        public string AreaName { get; }
        public string ControllerName { get; }
        public string Name { get; }
        public Uri RelativePath { get; }
        public string TemplateKind { get; set; }

        public Dictionary<string, IEnumerable<View>> SubFolders { get; set; }

        public bool IsHackyDirectory => SubFolders?.Any() == true;
    }
}
