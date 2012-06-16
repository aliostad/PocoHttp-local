using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using PocoHttp.Grammars;

namespace PocoHttp
{
	public class PocoRuntime : IPocoRuntime
	{
		private static readonly PocoRuntime _current = new PocoRuntime();

		private PocoRuntime()
		{
			DefaultGrammar = new ODataGrammar();
			UsePluralUrls = true;
		}

		public static PocoRuntime Current
		{
			get { return _current; }
		}

		public IHttpDataGrammar DefaultGrammar {get; set; }

		public bool UsePluralUrls { get; set; }

		public Func<HttpRequestMessage> RequestBuilder { get; set; }
		
	}
}
