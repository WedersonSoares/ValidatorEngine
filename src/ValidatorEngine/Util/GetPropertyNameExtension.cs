using System;
using System.Linq.Expressions;

namespace ValidatorEngine.Util
{
	public static class GetPropertyNameExtension
	{
		public static string NameOf<T, P>(this T objectTarget, Expression<Func<T, P>> action) where T : class
		{
			var expression = (MemberExpression)action.Body;
			string name = expression.Member.Name;

			return name;
		}
	}
}