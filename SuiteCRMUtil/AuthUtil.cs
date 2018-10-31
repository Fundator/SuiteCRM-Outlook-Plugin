using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuiteCRMUtil
{
	public class AuthUtil
	{
		public static string GetEndpointAuthorizationString(DateTime when)
		{
			return GetMd5Hash("DeBank2017" + when.ToString("yyyyMMdd")).ToLowerInvariant();
		}

		static string GetMd5Hash(string input)
		{
			var md5Hash = MD5.Create();
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder sBuilder = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}
			return sBuilder.ToString();
		}
	}
}
