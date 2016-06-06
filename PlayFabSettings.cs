using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PlayFab
{
    public class PlayFabSettings
    {
        public static string SdkVersion = "0.26.160523";
        public static string BuildIdentifier = "jbuild_csharpsdk_1178";
        public static string SdkVersionString = "CSharpSDK-0.26.160523";

        public static bool UseDevelopmentEnvironment = false;
        public static string DevelopmentEnvironmentUrl = ".playfabsandbox.com";
        public static string ProductionEnvironmentUrl = ".playfabapi.com";
        public static string TitleId; // You must set this value for PlayFabSdk to work properly (Found in the Game Manager for your title, at the PlayFab Website)
        public static ErrorCallback GlobalErrorHandler;
        public static string DeveloperSecretKey = null; // You must set this value for PlayFabSdk to work properly (Found in the Game Manager for your title, at the PlayFab Website)
        internal static string LogicServerUrl = null; // Assigned by GetCloudScriptUrl, used by RunCloudScript
        public static string AdvertisingIdType = null; // Set this to the appropriate AD_TYPE_X constant below
        public static string AdvertisingIdValue = null; // Set this to corresponding device value

        // DisableAdvertising is provided for completeness, but changing it is not suggested
        // Disabling this may prevent your advertising-related PlayFab marketplace partners from working correctly
        public static bool DisableAdvertising = false;
        public static readonly string AD_TYPE_IDFA = "Idfa";
        public static readonly string AD_TYPE_ANDROID_ID = "Android_Id";

        public static string GetLogicUrl(string apiCall)
        {
            return LogicServerUrl + apiCall;
        }

        public static string GetFullUrl(string apiCall)
        {
            if (apiCall == "/Client/RunCloudScript")
            {
                return GetLogicUrl(apiCall);
            }
            else
            {
                string baseUrl = UseDevelopmentEnvironment ? DevelopmentEnvironmentUrl : ProductionEnvironmentUrl;
                if (baseUrl.StartsWith("http"))
                    return baseUrl;
                return "https://" + TitleId + baseUrl + apiCall;
            }
        }
    }
}
