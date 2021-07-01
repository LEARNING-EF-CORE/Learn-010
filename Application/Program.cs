using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Application
{
	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			// برای تست بقیه توابع، تابع ذیل را پنج بار اجرا می‌کنیم
			//Step_0100_Add();

			//for (int index = 1; index <= 5; index++)
			//{
			//	Step_0100_Add();
			//}

			//Step_0200_Find(1);
			//Step_0200_Find(1000);

			//Step_0300_FirstOrDefault(1);
			//Step_0300_FirstOrDefault(1000);

			//Step_0400_First(1);
			//Step_0400_First(1000);

			//Step_0500_LastOrDefault(1);
			//Step_0500_LastOrDefault(1000);

			//Step_0600_Last(1);
			//Step_0600_Last(1000);

			//Step_0700_Single(1);
			//Step_0700_Single(1000);

			Step_0800_SingleOrDefault(1);
			Step_0800_SingleOrDefault(1000);

			// خیلی مناسب‌تر است FirstOrDefault تا اینجا متوجه شدیم که

			//Step_0900_FirstOrDefaultAsync(1).Wait();
			//Step_0900_FirstOrDefaultAsync(1000).Wait();

			// نکته مهم! دستورات ذیل کار نمی‌کند! چون تابع ذیل خروجی ندارد
			//Step_0900_FirstOrDefaultAsync(1).Result;
			//Step_0900_FirstOrDefaultAsync(1000).Result;

			//Step_1000_ToListAsync().Wait();
		}

		private static void Step_0100_Add()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// **************************************************
				//Domain.User user = new Domain.User();

				//user.Username = "Dariush";
				//user.Password = "1234512345";
				//user.FullName = "Dariush Tasdighi";
				// **************************************************

				// **************************************************
				//Domain.User user =
				//	new Domain.User()
				//	{
				//		Username = "Dariush",
				//		Password = "1234512345",
				//		FullName = "Dariush Tasdighi"
				//	};
				// **************************************************

				// **************************************************
				//Domain.User user =
				//	new Domain.User
				//	{
				//		Username = "Dariush",
				//		Password = "1234512345",
				//		FullName = "Dariush Tasdighi"
				//	};
				// **************************************************

				// **************************************************
				//Domain.User user =
				//	new()
				//	{
				//		Username = "Dariush",
				//		Password = "1234512345",
				//		FullName = "Dariush Tasdighi"
				//	};
				// **************************************************

				// **************************************************
				//var user =
				//	new Domain.User
				//	{
				//		Username = "Dariush",
				//		Password = "1234512345",
				//		FullName = "Dariush Tasdighi"
				//	};
				// **************************************************

				// **************************************************
				var user =
					new Domain.User
					{
						Username = "Dariush",
						Password = "1234512345",
						FullName = "Dariush Tasdighi",
					};
				// **************************************************

				databaseContext.Users.Add(user);

				System.Console.WriteLine(user.GetInformation());

				databaseContext.SaveChanges();

				System.Console.WriteLine(user.GetInformation());
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Step_0200_Find(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					databaseContext.Users
					.Find(keyValues: id);

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Step_0300_FirstOrDefault(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				//var user =
				//	databaseContext.Users
				//	.FirstOrDefault();

				//var user =
				//	databaseContext.Users
				//	// using System.Linq;
				//	.Where(current => current.Id == id)
				//	.FirstOrDefault();

				var user =
					databaseContext.Users
					.FirstOrDefault(current => current.Id == id);

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Step_0400_First(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				//var user =
				//	databaseContext.Users
				//	.First();

				var user =
					databaseContext.Users
					.Where(current => current.Id == id)
					.First();

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Step_0500_LastOrDefault(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// Error!
				//var user =
				//	databaseContext.Users
				//	.LastOrDefault();

				//var user =
				//	databaseContext.Users
				//	.OrderBy(current => current.Id)
				//	.LastOrDefault();

				// Error!
				//var user =
				//	databaseContext.Users
				//	.Where(current => current.Id == id)
				//	.LastOrDefault();

				var user =
					databaseContext.Users
					.Where(current => current.Id == id)
					.OrderBy(current => current.Id)
					.LastOrDefault();

				// به دستور فوق دقت کنید
				// Where اول
				// OrderBy و بعد

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Step_0600_Last(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// Error!
				//var user =
				//	databaseContext.Users
				//	.Last();

				var user =
					databaseContext.Users
					.OrderBy(current => current.Id)
					.Last();

				// Error!
				//var user =
				//	databaseContext.Users
				//	.Where(current => current.Id == id)
				//	.Last();

				//var user =
				//	databaseContext.Users
				//	.Where(current => current.Id == id)
				//	.OrderBy(current => current.Id)
				//	.Last();

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Step_0700_Single(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				//var user =
				//	databaseContext.Users
				//	.Single();

				var user =
					databaseContext.Users
					.Where(current => current.Id == id)
					.Single();

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static void Step_0800_SingleOrDefault(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				//var user =
				//	databaseContext.Users
				//	.SingleOrDefault();

				var user =
					databaseContext.Users
					.Where(current => current.Id == id)
					.SingleOrDefault();

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_0900_FirstOrDefaultAsync(int id)
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					await
					databaseContext.Users
					.Where(current => current.Id == id)
					// using Microsoft.EntityFrameworkCore;
					.FirstOrDefaultAsync();

				if (user == null)
				{
					System.Console.WriteLine("User not found!");
				}
				else
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_1000_ToListAsync()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				//var users =
				//	databaseContext.Users
				//	.ToList()
				//	;

				//var users =
				//	await
				//	databaseContext.Users
				//	.ToListAsync()
				//	;

				//var users =
				//	await
				//	databaseContext.Users
				//	.OrderBy(current => current.Id)
				//	.ToListAsync()
				//	;

				//var users =
				//	await
				//	databaseContext.Users
				//	.OrderByDescending(current => current.Id)
				//	.ToListAsync()
				//	;

				// دستور ذیل خطا نمی‌دهد ولی کار هم نمی‌کند
				//var users =
				//	await
				//	databaseContext.Users
				//	.OrderBy(current => current.Id)
				//	.OrderBy(current => current.Username)
				//	.ToListAsync()
				//	;

				// دستور ذیل صحیح است، ولی بی‌معنا است
				//var users =
				//	await
				//	databaseContext.Users
				//	.OrderBy(current => current.Id)
				//	.ThenBy(current => current.Username)
				//	.ToListAsync()
				//	;

				// دستور ذیل صحیح است، ولی بی‌معنا است
				//var users =
				//	await
				//	databaseContext.Users
				//	.OrderBy(current => current.Id)
				//	.ThenByDescending(current => current.Username)
				//	.ToListAsync()
				//	;

				// دستور ذیل صحیح است، ولی بی‌معنا است
				var users =
					await
					databaseContext.Users
					.OrderBy(current => current.Username)
					.ToListAsync()
					;

				foreach (var user in users)
				{
					System.Console.WriteLine(user.GetInformation());
				}
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
