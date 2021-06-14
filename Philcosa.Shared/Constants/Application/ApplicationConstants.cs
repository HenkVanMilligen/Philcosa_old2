﻿namespace Philcosa.Shared.Constants.Application
{
    public static class ApplicationConstants
    {
        public static class SignalR
        {
            public const string HubUrl = "/signalRHub";
            public const string SendUpdateDashboard = "UpdateDashboardAsync";
            public const string ReceiveUpdateDashboard = "UpdateDashboard";
            public const string SendRegenerateTokens = "RegenerateTokensAsync";
            public const string ReceiveRegenerateTokens = "RegenerateTokens";
            public const string ReceiveChatNotification = "ReceiveChatNotification";
            public const string SendChatNotification = "ChatNotificationAsync";
            public const string ReceiveMessage = "ReceiveMessage";
            public const string SendMessage = "SendMessageAsync";
        }
        public static class Cache
        {
            public const string GetAllBrandsCacheKey = "all-brands";
            public const string GetAllCountriesCacheKey = "all-countries";
            public const string GetAllCoverTypesCacheKey = "all-covertypes";
            public const string GetAllCoverValuesCacheKey = "all-covervalues";
            public const string GetAllThemesCacheKey = "all-themes";
            public const string GetAllCoverIssuersCacheKey = "all-coverissuers";
        }
    }
}