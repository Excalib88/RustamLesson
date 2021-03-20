using System;

namespace RustamLesson
{
	public class UserService : IUserService
	{
		public Func<string, string, string> func;
		public Action<string, string> action;
		public Predicate<string> predicate;
		
		
		public void Register(string name)
		{
			NewUniqueOrderInShop a = "asd";
			
			Console.WriteLine();
		}

		public void Register3(string name, string surname)
		{
		}

		public string Register2(string name, string surname)
		{
			return "";
		}
		
		public void EventMethod(object? sender, EventArgs e)
		{
			func = Register2;
			action = Register3;
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