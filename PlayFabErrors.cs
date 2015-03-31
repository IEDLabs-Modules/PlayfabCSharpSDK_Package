using System.Collections.Generic;

namespace PlayFab
{
	/// <summary>
	/// Error codes returned by PlayFabAPIs
	/// </summary>
	public enum PlayFabErrorCode
	{
		Success = 0,
		Unknown = 1,
		ConnectionError = 2,
        JsonParseError = 3,
		InvalidParams = 1000,
		AccountNotFound = 1001,
		AccountBanned = 1002,
		InvalidUsernameOrPassword = 1003,
		InvalidTitleId = 1004,
		InvalidEmailAddress = 1005,
		EmailAddressNotAvailable = 1006,
		InvalidUsername = 1007,
		InvalidPassword = 1008,
		UsernameNotAvailable = 1009,
		InvalidSteamTicket = 1010,
		AccountAlreadyLinked = 1011,
		LinkedAccountAlreadyClaimed = 1012,
		InvalidFacebookToken = 1013,
		AccountNotLinked = 1014,
		FailedByPaymentProvider = 1015,
		CouponCodeNotFound = 1016,
		InvalidContainerItem = 1017,
		ContainerNotOwned = 1018,
		KeyNotOwned = 1019,
		InvalidItemIdInTable = 1020,
		InvalidReceipt = 1021,
		ReceiptAlreadyUsed = 1022,
		ReceiptCancelled = 1023,
		GameNotFound = 1024,
		GameModeNotFound = 1025,
		InvalidGoogleToken = 1026,
		UserIsNotPartOfDeveloper = 1027,
		InvalidTitleForDeveloper = 1028,
		TitleNameConflicts = 1029,
		UserisNotValid = 1030,
		ValueAlreadyExists = 1031,
		BuildNotFound = 1032,
		PlayerNotInGame = 1033,
		InvalidTicket = 1034,
		InvalidDeveloper = 1035,
		InvalidOrderInfo = 1036,
		RegistrationIncomplete = 1037,
		InvalidPlatform = 1038,
		UnknownError = 1039,
		SteamApplicationNotOwned = 1040,
		WrongSteamAccount = 1041,
		TitleNotActivated = 1042,
		RegistrationSessionNotFound = 1043,
		NoSuchMod = 1044,
		FileNotFound = 1045,
		DuplicateEmail = 1046,
		ItemNotFound = 1047,
		ItemNotOwned = 1048,
		ItemNotRecycleable = 1049,
		ItemNotAffordable = 1050,
		InvalidVirtualCurrency = 1051,
		WrongVirtualCurrency = 1052,
		WrongPrice = 1053,
		NonPositiveValue = 1054,
		InvalidRegion = 1055,
		RegionAtCapacity = 1056,
		ServerFailedToStart = 1057,
		NameNotAvailable = 1058,
		InsufficientFunds = 1059,
		InvalidDeviceID = 1060,
		InvalidPushNotificationToken = 1061,
		NoRemainingUses = 1062,
		InvalidPaymentProvider = 1063,
		PurchaseInitializationFailure = 1064,
		DuplicateUsername = 1065,
		InvalidBuyerInfo = 1066,
		NoGameModeParamsSet = 1067,
		BodyTooLarge = 1068,
		ReservedWordInBody = 1069,
		InvalidTypeInBody = 1070,
		InvalidRequest = 1071,
		ReservedEventName = 1072,
		InvalidUserStatistics = 1073,
		NotAuthenticated = 1074,
		StreamAlreadyExists = 1075,
		ErrorCreatingStream = 1076,
		StreamNotFound = 1077,
		InvalidAccount = 1078,
		PurchaseDoesNotExist = 1080,
		InvalidPurchaseTransactionStatus = 1081,
		APINotEnabledForGameClientAccess = 1082,
		NoPushNotificationARNForTitle = 1083,
		BuildAlreadyExists = 1084,
		BuildPackageDoesNotExist = 1085,
		CustomAnalyticsEventsNotEnabledForTitle = 1087,
		InvalidSharedGroupId = 1088,
		NotAuthorized = 1089,
		MissingTitleGoogleProperties = 1090,
		InvalidItemProperties = 1091,
		InvalidPSNAuthCode = 1092,
		InvalidItemId = 1093,
		PushNotEnabledForAccount = 1094,
		PushServiceError = 1095,
		ReceiptDoesNotContainInAppItems = 1096,
		ReceiptContainsMultipleInAppItems = 1097,
		InvalidBundleID = 1098,
		JavascriptException = 1099,
		InvalidSessionTicket = 1100,
		UnableToConnectToDatabase = 1101,
		InternalServerError = 1110,
		InvalidReportDate = 1111,
		ReportNotAvailable = 1112,
		DatabaseThroughputExceeded = 1113,
		InvalidLobbyId = 1114,
		InvalidGameTicket = 1115,
		ExpiredGameTicket = 1116,
		GameTicketDoesNotMatchLobby = 1117,
		LinkedDeviceAlreadyClaimed = 1118,
		DeviceAlreadyLinked = 1119,
		DeviceNotLinked = 1120,
		PartialFailure = 1121,
		PublisherNotSet = 1122,
		ServiceUnavailable = 1123,
		VersionNotFound = 1124,
		RevisionNotFound = 1125,
		InvalidPublisherId = 1126,
		DownstreamServiceUnavailable = 1127,
		APINotIncludedInTitleUsageTier = 1128,
		DAULimitExceeded = 1129,
		APIRequestLimitExceeded = 1130,
		InvalidAPIEndpoint = 1131,
		BuildNotAvailable = 1132,
		ConcurrentEditError = 1133,
		ContentNotFound = 1134,
		CharacterNotFound = 1135,
		CloudScriptNotFound = 1136,
		ContentQuotaExceeded = 1137,
		InvalidCharacterStatistics = 1138,
		PhotonNotEnabledForTitle = 1139,
		PhotonApplicationNotFound = 1140,
		PhotonApplicationNotAssociatedWithTitle = 1141
	}
	
	public class PlayFabError
    {
        public int HttpCode;
		public string HttpStatus;
		public PlayFabErrorCode Error;
		public string ErrorMessage;
		public Dictionary<string, string[] > ErrorDetails;
    };

    public class PlayFabResult<ResultT>
    {
        public PlayFabError Error;
        public ResultT Result;
    }
	
	public delegate void ErrorCallback(PlayFabError error);
}