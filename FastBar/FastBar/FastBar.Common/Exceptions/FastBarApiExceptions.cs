﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using FastBar.Common.Interfaces;
using FastBar.Common.Logging;

namespace FastBar.Common.Exceptions
{
	public class FastBarApiExceptions : FastBarExceptions
	{
		public FastBarApiExceptions(string errorCode, string errorMessage, Exception innerException = null) : base(errorCode, errorMessage, innerException)
		{
			ApiErrorCodes code;
			ApiErrorCode = Enum.TryParse(errorCode, out code) ? code : ApiErrorCodes.Unknown;
		}

		public FastBarApiExceptions(HttpStatusCode httpStatusCode, string errorCode, string errorMessage, Exception innerException = null) : base(errorCode, errorMessage, innerException)
		{
			HttpStatusCode = httpStatusCode;
			ApiErrorCodes code;
			ApiErrorCode = Enum.TryParse(errorCode, out code) ? code : ApiErrorCodes.Unknown;
		}

		public FastBarApiExceptions(ApiErrorCodes apiErrorCode, string errorMessage, Exception innerException = null) : base(apiErrorCode.ToString(), errorMessage, innerException)
		{
			ApiErrorCode = apiErrorCode;
		}

		public FastBarApiExceptions(ApiErrorCodes apiErrorCode, string errorCode, string errorMessage, Exception innerException = null) : base(errorCode, errorMessage, innerException)
		{
			ApiErrorCode = apiErrorCode;
		}

		public FastBarApiExceptions(ApiErrorCodes apiErrorCode, HttpStatusCode httpStatusCode, string errorCode, string errorMessage, Exception innerException = null) : base(errorCode, errorMessage, innerException)
		{
			ApiErrorCode = apiErrorCode;
			HttpStatusCode = httpStatusCode;
		}

		public FastBarApiExceptions(ApiErrorCodes apiErrorCode, HttpStatusCode httpStatusCode, string errorCode, string errorMessage, string responseContent, Exception innerException = null) : base(errorCode, errorMessage, innerException)
		{
			ApiErrorCode = apiErrorCode;
			HttpStatusCode = httpStatusCode;
			ResponseContent = responseContent;
		}

		public FastBarApiExceptions(HttpStatusCode httpStatusCode, string errorCode, string errorMessage, string responseContent, Exception innerException = null) : base(errorCode, errorMessage, innerException)
		{
			ApiErrorCodes code;
			ApiErrorCode = Enum.TryParse(errorCode, out code) ? code : ApiErrorCodes.Unknown;
			HttpStatusCode = httpStatusCode;
			ResponseContent = responseContent;
		}

		public HttpStatusCode HttpStatusCode { get; set; }

		public ApiErrorCodes ApiErrorCode { get; set; }

		public string ResponseContent { get; set; }


		public static FastBarApiExceptions ProcessApiException(Exception ex, int? id = null, string api = null, string verb = null, string url = null, object data = null)
		{
			WebException webEx = ex as WebException;

			bool isTimeout = ex is TaskCanceledException || (webEx != null && webEx.Status != WebExceptionStatus.UnknownError);
			bool isOnline = ((IConnectivityHelper)ContainerManager.Container.Resolve(typeof(IConnectivityHelper), typeof(IConnectivityHelper).GetType().ToString())).IsConnected;

			if (id != null)
				((ILogger)ContainerManager.Container.Resolve(typeof(ILogger),
															 typeof(ILogger).GetType().ToString()))
					.Error($"InvocationId<{id}> Request to {api} failed",
						   new { ex.Message, isOnline, isTimeout, verb, url, data },
						   new[] { LoggerConstants.ApiOperation });

			Dictionary<string, object> metadata = new Dictionary<string, object>
				{
					{"verb", verb},
					{"url", url},
					{"data", data},
					{"isOnline", isOnline},
					{"isTimedOut", isTimeout}
				};

			if (webEx != null)
				metadata.Add("WebExceptionStatus", webEx.Status.ToString());

			if (!isOnline)
				return new FastBarApiExceptions(ApiErrorCodes.ConnectivityLost, ex.Message);

			if (isTimeout)
				return new FastBarApiExceptions(ApiErrorCodes.ServerUnreachable, ex.Message);

			return new FastBarApiExceptions(ApiErrorCodes.Unknown, ex.Message);
		}
	}
}
