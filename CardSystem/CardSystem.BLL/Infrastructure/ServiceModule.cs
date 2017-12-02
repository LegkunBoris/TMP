using System;
using CardSystem.DAL;
using Ninject.Modules;

namespace CardSystem.BLL
{
	public class ServiceModule : NinjectModule
	{
		private string _connectionString;
		public ServiceModule(string connection)
		{
			_connectionString = connection;
		}

		public override void Load()
		{
			Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(_connectionString);
		}
	}
}
