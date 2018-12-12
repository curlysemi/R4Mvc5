namespace R4Mvc.Tools
{
    internal static class Constants
    {
        internal const string ProjectName = "R4Mvc5";
        internal const string PrefixName = "T4MVC";
        internal const string Version = "1.0";
        internal const string GetR4ActionResult = "GetT4MVCResult";
        internal const string IR4MvcActionResult = "IT4MVCActionResult";

        internal const string R4MvcFileName = "T4MVC.cs";
        internal const string R4MvcGeneratedFileName = "T4MVC.generated.cs";
        internal const string R4MvcSettingsFileName = "r4mvc.json";

        internal const string DummyClass = "Dummy";
        internal const string DummyClassInstance = "Instance";

        internal const string R4MvcHelpersClass = "T4MVCHelpers";
        internal const string R4MvcHelpers_ProcessVirtualPath = "ProcessVirtualPath";

        internal const string IActionResultClass = "ActionResult"; // IActionResult
        private const string ActionResultNamespace = "_System_Web_Mvc_";
        internal const string ActionResultClass = PrefixName + ActionResultNamespace + "ActionResult";
        internal const string JsonResultClass = PrefixName + ActionResultNamespace + "JsonResult";
        internal const string ContentResultClass = PrefixName + ActionResultNamespace + "ContentResult";
        internal const string ViewResultClass = PrefixName + ActionResultNamespace + "ViewResult";
        internal const string PartialViewResultClass = PrefixName + ActionResultNamespace + "PartialViewResult";
        internal const string FileResultClass = PrefixName + ActionResultNamespace + "FileResult";
        internal const string RedirectResultClass = PrefixName + ActionResultNamespace + "RedirectResult";
        internal const string RedirectToActionResultClass = PrefixName + ActionResultNamespace + "RedirectToActionResult";
        internal const string RedirectToRouteResultClass = PrefixName + ActionResultNamespace + "RedirectToRouteResult";

        private const string PageActionResultNamespace = "_Microsoft_AspNetCore_Mvc_RazorPages_";
        internal const string PageActionResultClass = PrefixName + PageActionResultNamespace + "ActionResult";
        internal const string PageJsonResultClass = PrefixName + PageActionResultNamespace + "JsonResult";
        internal const string PageContentResultClass = PrefixName + PageActionResultNamespace + "ContentResult";
        internal const string PageFileResultClass = PrefixName + PageActionResultNamespace + "FileResult";
        internal const string PageRedirectResultClass = PrefixName + PageActionResultNamespace + "RedirectResult";
        internal const string PageRedirectToActionResultClass = PrefixName + PageActionResultNamespace + "RedirectToActionResult";
        internal const string PageRedirectToRouteResultClass = PrefixName + PageActionResultNamespace + "RedirectToRouteResult";

        internal static class ConfigKeys
        {
            internal const string HelpersPrefix = "helpersPrefix";
            internal const string R4MvcNamespace = "r4mvcNamespace";
            internal const string LinksNamespace = "linksNamespace";
        }
    }
}
