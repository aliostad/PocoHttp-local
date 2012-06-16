using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using PocoHttp.Grammars;

namespace PocoHttp
{
	public class PocoClient : IPocoClient
	{
		private IPocoRuntime _pocoRuntime;
		private HttpClient _httpClient;
		private HttpMessageHandler _handler;
		private IHttpDataGrammar _grammar;

		public PocoClient() : this(PocoRuntime.Current)
		{
			
		}

		public PocoClient(IPocoRuntime pocoRuntime) : this(pocoRuntime, pocoRuntime.DefaultGrammar, null, false)
		{
			
		}

		public PocoClient(IPocoRuntime pocoRuntime, IHttpDataGrammar grammar)
			: this(pocoRuntime, grammar, null, false)
		{
			
		}

		public PocoClient(IPocoRuntime pocoRuntime, IHttpDataGrammar grammar, 
			HttpMessageHandler handler, bool disposeHandler)
		{
			_grammar = grammar;
			_handler = handler;
			if(handler == null)
				_httpClient = new HttpClient();
			else
				_httpClient = new HttpClient(handler, disposeHandler);
		}

		public Uri BaseAddress
		{
			get { return _httpClient.BaseAddress; }
			set { _httpClient.BaseAddress = value; }
		}

		public IQueryable<TEntity> Context<TEntity>()
		{
			throw new NotImplementedException();
		}

		public IQueryable Context(Type t)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			_httpClient.Dispose();
			
		}
	}
}
