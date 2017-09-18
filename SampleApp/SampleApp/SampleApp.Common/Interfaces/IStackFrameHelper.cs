using System;
namespace SampleApp.Common.Interfaces
{
	public interface IStackFrameHelper
	{
		string GetCallerFullTypeName(int? skipFrames = null);

		Type GetCallerFullType(int? skipFrames = null);
	}
}
