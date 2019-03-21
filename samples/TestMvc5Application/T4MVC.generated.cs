// <auto-generated />
// This file was generated by R4Mvc5.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using T4MVC;

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
public static partial class MVC
{
    public static readonly TestMvc5Application.Controllers.HomeController Home = new TestMvc5Application.Controllers.T4MVC_HomeController();
    public static readonly TestMvc5Application.Controllers.UserController User = new TestMvc5Application.Controllers.T4MVC_UserController();
    public static readonly T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy()
        {
        }

        public static Dummy Instance = new Dummy();
    }

    [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
    public partial class SharedController
    {
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string Error = "Error";
                public readonly string _Layout = "_Layout";
            }

            public readonly string Error = "~/Views/Shared/Error.cshtml";
            public readonly string _Layout = "~/Views/Shared/_Layout.cshtml";
        }

        static readonly ViewsClass s_Views = new ViewsClass();
        public ViewsClass Views => s_Views;
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
public static partial class Links
{
    public const string UrlPath = "~";
    public static string Url() => T4MVCHelpers.ProcessVirtualPath(UrlPath);
    public static string Url(string fileName) => T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
    public static partial class Content
    {
        public const string UrlPath = "~/Content";
        public static string Url() => T4MVCHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string bootstrap_theme_css = Url("bootstrap-theme.css");
        public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
        public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
        public static readonly string bootstrap_theme_min_css_map = Url("bootstrap-theme.min.css.map");
        public static readonly string bootstrap_css = Url("bootstrap.css");
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string bootstrap_min_css_map = Url("bootstrap.min.css.map");
        public static readonly string Site_css = Url("Site.css");
    }

    public static partial class Scripts
    {
        public const string UrlPath = "~/Scripts";
        public static string Url() => T4MVCHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string bootstrap_js = Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_3_3_1_intellisense_js = Url("jquery-3.3.1.intellisense.js");
        public static readonly string jquery_3_3_1_js = Url("jquery-3.3.1.js");
        public static readonly string jquery_3_3_1_min_js = Url("jquery-3.3.1.min.js");
        public static readonly string jquery_3_3_1_min_map = Url("jquery-3.3.1.min.map");
        public static readonly string jquery_3_3_1_slim_js = Url("jquery-3.3.1.slim.js");
        public static readonly string jquery_3_3_1_slim_min_js = Url("jquery-3.3.1.slim.min.js");
        public static readonly string jquery_3_3_1_slim_min_map = Url("jquery-3.3.1.slim.min.map");
        public static readonly string jquery_validate_vsdoc_js = Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string modernizr_2_8_3_js = Url("modernizr-2.8.3.js");
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal static class T4MVCHelpers
{
    private static string ProcessVirtualPathDefault(string virtualPath) => virtualPath;
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }

    public override void ExecuteResult(ControllerContext context)
    {
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ViewResult : ViewResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ViewResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_PartialViewResult : PartialViewResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_PartialViewResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_JsonResult : JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ContentResult : ContentResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ContentResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_FileResult : FileResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_FileResult(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }

    protected override void WriteFile(HttpResponseBase response)
    {
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_RedirectResult : RedirectResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_RedirectResult(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

[GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_RedirectToRouteResult : RedirectToRouteResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_RedirectToRouteResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }
}

namespace TestMvc5Application.Controllers
{
    public partial class HomeController
    {
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public HomeController()
        {
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected HomeController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public HomeController Actions => MVC.Home;
        [GeneratedCode("R4Mvc5", "1.0.3")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc5", "1.0.3")]
        public readonly string Name = "Home";
        [GeneratedCode("R4Mvc5", "1.0.3")]
        public const string NameConst = "Home";
        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string About = "About";
            public readonly string Contact = "Contact";
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string About = "About";
            public const string Contact = "Contact";
        }

        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ActionParamsClass_Index s_IndexParams = new ActionParamsClass_Index();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams => s_IndexParams;
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
        }

        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ActionParamsClass_About s_AboutParams = new ActionParamsClass_About();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ActionParamsClass_About AboutParams => s_AboutParams;
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionParamsClass_About
        {
        }

        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ActionParamsClass_Contact s_ContactParams = new ActionParamsClass_Contact();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ActionParamsClass_Contact ContactParams => s_ContactParams;
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionParamsClass_Contact
        {
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string About = "About";
                public readonly string Contact = "Contact";
                public readonly string Index = "Index";
            }

            public readonly string About = "~/Views/Home/About.cshtml";
            public readonly string Contact = "~/Views/Home/Contact.cshtml";
            public readonly string Index = "~/Views/Home/Index.cshtml";
            static readonly _StuffClass s_Stuff = new _StuffClass();
            public _StuffClass Stuff => s_Stuff;
            public partial class _StuffClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames => s_ViewNames;
                public class _ViewNamesClass
                {
                    public readonly string CoolPage = "CoolPage";
                    public readonly string SmartPage = "SmartPage";
                }

                public readonly string CoolPage = "~/Views/Home/Stuff/CoolPage.cshtml";
                public readonly string SmartPage = "~/Views/Home/Stuff/SmartPage.cshtml";
                static readonly _MoreClass s_More = new _MoreClass();
                public _MoreClass More => s_More;
                public partial class _MoreClass
                {
                    static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                    public _ViewNamesClass ViewNames => s_ViewNames;
                    public class _ViewNamesClass
                    {
                        public readonly string DumbPage = "DumbPage";
                        public readonly string LamePage = "LamePage";
                    }

                    public readonly string DumbPage = "~/Views/Home/Stuff/More/DumbPage.cshtml";
                    public readonly string LamePage = "~/Views/Home/Stuff/More/LamePage.cshtml";
                }
            }
        }

        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : TestMvc5Application.Controllers.HomeController
    {
        public T4MVC_HomeController(): base(Dummy.Instance)
        {
        }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AboutOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Web.Mvc.ActionResult About()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.About);
            AboutOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ContactOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Web.Mvc.ActionResult Contact()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Contact);
            ContactOverride(callInfo);
            return callInfo;
        }
    }

    public partial class UserController
    {
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public UserController()
        {
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected UserController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public virtual ActionResult Details()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
        }

        [NonAction]
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public virtual ActionResult Stropping()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Stropping);
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public UserController Actions => MVC.User;
        [GeneratedCode("R4Mvc5", "1.0.3")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc5", "1.0.3")]
        public readonly string Name = "User";
        [GeneratedCode("R4Mvc5", "1.0.3")]
        public const string NameConst = "User";
        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Details = "Details";
            public readonly string Stropping = "Stropping";
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Details = "Details";
            public const string Stropping = "Stropping";
        }

        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ActionParamsClass_Details s_DetailsParams = new ActionParamsClass_Details();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ActionParamsClass_Details DetailsParams => s_DetailsParams;
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionParamsClass_Details
        {
            public readonly string id = "id";
            public readonly string name = "name";
            public readonly string model = "model";
        }

        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ActionParamsClass_Stropping s_StroppingParams = new ActionParamsClass_Stropping();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ActionParamsClass_Stropping StroppingParams => s_StroppingParams;
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ActionParamsClass_Stropping
        {
            public readonly string @default = "default";
        }

        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string Details = "Details";
            }

            public readonly string Details = "~/Views/User/Details.cshtml";
        }

        [GeneratedCode("R4Mvc5", "1.0.3")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc5", "1.0.3"), DebuggerNonUserCode]
    public partial class T4MVC_UserController : TestMvc5Application.Controllers.UserController
    {
        public T4MVC_UserController(): base(Dummy.Instance)
        {
        }

        [NonAction]
        partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string name);
        [NonAction]
        public override System.Web.Mvc.ActionResult Details(int id, string name)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "name", name);
            DetailsOverride(callInfo, id, name);
            return callInfo;
        }

        [NonAction]
        partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, TestMvc5Application.Models.User.UserDetails model);
        [NonAction]
        public override System.Web.Mvc.ActionResult Details(TestMvc5Application.Models.User.UserDetails model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            DetailsOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void StroppingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string @default);
        [NonAction]
        public override System.Web.Mvc.ActionResult Stropping(string @default)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Stropping);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "default", @default);
            StroppingOverride(callInfo, @default);
            return callInfo;
        }
    }
}
#pragma warning restore 1591, 3008, 3009, 0108
