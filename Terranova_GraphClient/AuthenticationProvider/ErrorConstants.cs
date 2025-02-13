﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Terranova_GraphClient.AuthenticationProvider
{
	internal static class ErrorConstants
    {
		internal static class Codes
		{
			internal const string TemporarilyUnavailable = "temporarily_unavailable";
			internal const string InvalidRequest = "invalidRequest";
			internal const string GeneralException = "generalException";
			internal const string AuthenticationException = "authenticationException";
		}

		internal static class Message
		{
			internal const string MissingRetryAfterHeader = "Missing retry after header.";
			internal const string NullValue = "{0} cannot be null.";
			internal static string UnexpectedMsalException = "Unexpected exception returned from MSAL.";
			internal static string UnexpectedException = "Unexpected exception occured while authenticating the request.";
			internal const string EmptyScopes = "Scopes cannot be empty.";
			internal const string ConsentRequired = "Consent is required for the tenant";
		}
	}
}
