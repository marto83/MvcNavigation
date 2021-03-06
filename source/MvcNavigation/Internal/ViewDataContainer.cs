﻿using System.Web.Mvc;

namespace MvcNavigation.Internal
{
	internal class ViewDataContainer<TModel> : IViewDataContainer
	{
		internal ViewDataContainer(TModel model)
		{
			ViewData = new ViewDataDictionary<TModel>(model);
		}

		#region IViewDataContainer Members

		public ViewDataDictionary ViewData { get; set; }

		#endregion
	}
}