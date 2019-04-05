using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Locator;

namespace R4Mvc.Tools.Extensions
{
    public static class InstancesHelper
    {
        public static VisualStudioInstance[] GetVisualStudioInstances()
        {
            var instances = MSBuildLocator.QueryVisualStudioInstances().ToArray();
            return instances.OrderByDescending(i => i.Version).ToArray();
        }
    }
}
