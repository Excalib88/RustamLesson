using System;

namespace RustamLesson
{
	public class UserService : IUserService
	{
		public void Register(string name)
		{
			NewUniqueOrderInShop a = "asd";
			
			Console.WriteLine();
		}

		public NewUniqueOrderInShop Get()
		{
			return new NewUniqueOrderInShop();
		}
	}

	public class NewUniqueOrderInShop
	{
		public string Name { get; set; }

		public static implicit operator NewUniqueOrderInShop(string value)
		{
			return new NewUniqueOrderInShop
			{
				Name = value
			};
		}
	}
}