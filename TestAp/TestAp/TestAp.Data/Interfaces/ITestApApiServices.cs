﻿using System;
using System.Threading.Tasks;

namespace TestAp.Data.Interfaces
{
	public interface ITestApApiServices
	{
		Task<string> PostRequest(string api, object data);

		Task<T> PostRequest<T>(string api, object data);

		Task<T> PostImageFileRequest<T>(byte[] fileBytes, string filename, string api);

		Task<T> GetRequest<T>(string api);

		Task<string> GetRequest(string api);

		Task<string> DeleteRequest(string api);
	}
}
