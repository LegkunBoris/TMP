using System;
using CardSystem.BLL;
using Ninject.Modules;

namespace CardSystem.WEB
{
	public class WEBModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ICardService>().To<CardService>();
		}
	}
}
