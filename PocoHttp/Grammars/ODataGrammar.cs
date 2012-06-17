using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PocoHttp.Grammars
{
	public class ODataGrammar : QueryStringGrammar
	{
		protected override string GetQueryString(Expression expression)
		{
			throw new NotImplementedException();
		}
	}
}
