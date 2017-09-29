using System;
namespace TestApp.Common.Exceptions
{
	public class TestAppExceptions : Exception
	{
		public TestAppExceptions(string errorCode, string errorMessage, Exception innerException = null) : base($"ErrorCode={errorCode}, ErrorMessage={errorMessage}", innerException)
		{
			ErrorCodeAsString = errorCode ?? string.Empty;
            ErrorMessage = errorMessage;
		}

		public string ErrorCodeAsString { get; set; }

		public string ErrorMessage { get; set; }
	}
}
