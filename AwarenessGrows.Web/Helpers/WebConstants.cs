namespace AwarenessGrows.Web.Helpers
{
    public static class WebConstants
    {
        public static class Alerts
        {
            public const string SUCCESS = "success";
            public const string WARNING = "warning";
            public const string ERROR = "danger";
            public const string INFORMATION = "info";

            public static string[] ALL
            {
                get { return new[] { SUCCESS, WARNING, INFORMATION, ERROR }; }
            }
        }

        public static class ApplicationRegions
        {
            public const string DEVELOPMENT = "Development";
            public const string TEST = "Test";
            public const string PRODUCTION = "Production";

            public const string DEVELOPMENTMESSAGE = "DEVELOPMENT Region";
            public const string TESTMESSAGE = "TEST Region";
            public const string PRODUCTIONMESSAGE = "PRODUCTION Region";
            public const string UNKNOWNMESSAGE = "UNKNOWN Region, Application Region must be defined in configuration as Development, Test or Production.";
        }

        public static class ErrorMessages
        {
            public const string ERROR_MAIN = "An error has occured while processing your request!";
            public const string UNKNOWN = "Unknown Exception!";
            public const string UNKNOWN_MESSAGE = "An Unknown Exception has orrured, please review the server log file for details.";
            public const string NOTFOUND = "Resource Not Found!";
            public const string NOTFOUND_MESSAGE = "The resource you were looking for is not found.";
            public const string NOTAUTHORIZED = "Access Denied!";
            public const string NOTAUTHORIZED_MESSAGE = "You do not have authorization to view this page.";
        }
    }
}