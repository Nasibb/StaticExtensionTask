using System;
namespace StaticExtensionTask.Domain.Interfaces
{
	public interface IAccount
	{
		bool PasswordChecker(string password);

		void ShowInfo();
	};
}

