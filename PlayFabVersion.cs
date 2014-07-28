
namespace PlayFab.Internal
{
	public class PlayFabVersion
	{
		public static string ApiRevision = "1.0.0.b3";
		public static string SdkRevision = "1.0.1";

		public static string getVersionString()
		{
			return "CSharpSDK-" + SdkRevision + "-" + ApiRevision;
		}
	}
}

