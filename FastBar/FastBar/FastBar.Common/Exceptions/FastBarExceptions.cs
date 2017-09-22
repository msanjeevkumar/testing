using System;
namespace FastBar.Common.Exceptions
{
	public class FastBarExceptions : Exception
	{
		public FastBarExceptions(string errorCode, string errorMessage, Exception innerException = null) : base($"ErrorCode={errorCode}, ErrorMessage={errorMessage}", innerException)
		{
			ErrorCodeAsString = errorCode ?? string.Empty;
            ErrorMessage = errorMessage;
		}

		public string ErrorCodeAsString { get; set; }

		public string ErrorMessage { get; set; }
	}
}
