using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PocoHttp.Grammars
{
	public class ODataGrammar : QueryStringParameterGrammar
	{
		protected override string GetQueryString(Expression expression)
		{
			throw new NotImplementedException();
		}
	}
}
