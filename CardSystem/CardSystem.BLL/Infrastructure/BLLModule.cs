using System;
using CardSystem.DAL;
using Ninject.Modules;

namespace CardSystem.BLL
{
	public class BLLModule : NinjectModule
	{
		private string _connectionString;
		public BLLModule(string connection)
		{
			_connectionString = connection;
		}

		public override void Load()
		{
			Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(_connectionString);
		}
	}
}
