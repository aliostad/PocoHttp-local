using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocoHttp
{
	public interface IPocoClient : IDisposable
	{
		IQueryable<TEntity> Context<TEntity>();
		IQueryable Context(Type t);
		Uri BaseAddress { get; set; }
	}
}
