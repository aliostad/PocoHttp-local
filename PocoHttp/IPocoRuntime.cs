using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using PocoHttp.Grammars;

namespace PocoHttp
{
	public interface IPocoRuntime
	{

		IHttpDataGrammar DefaultGrammar { get; set; }

		/// <summary>
		/// Whether use for example http://myserver/api/car or http://myserver/api/cars
		/// to retrieve Car objects
		/// </summary>
		bool UsePluralUrls { get; set; }

		Func<HttpRequestMessage> RequestBuilder { get; set; }


	}
}
