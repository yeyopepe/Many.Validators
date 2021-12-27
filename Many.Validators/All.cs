using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators
{
	public sealed class All<TValidator1, TValidator2, TValue>
		where TValidator1 : IValidator<TValue>
		where TValidator2 : IValidator<TValue>
	{
		public All()
		{
			/*
			 * Ideas:
			 * - Access to each Validate method with no instantiation of validator
			 * 
			 *  private static bool Get(All<NotNull<int?>, Positive<int?>, int?> value)
				{
					return true;
				}
			 */
		}
	}
}
