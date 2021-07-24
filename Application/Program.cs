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

			//Step_0800_SingleOrDefault(1);
			//Step_0800_SingleOrDefault(1000);

			// خیلی مناسب‌تر است FirstOrDefault تا اینجا متوجه شدیم که

			//Step_0900_FirstOrDefaultAsync(1).Wait();
			//Step_0900_FirstOrDefaultAsync(1000).Wait();

			// نکته مهم! دستورات ذیل کار نمی‌کند! چون تابع ذیل خروجی ندارد
			//Step_0900_FirstOrDefaultAsync(1).Result;
			//Step_0900_FirstOrDefaultAsync(1000).Result;

			//Step_1000_ToListAsync().Wait();

			//Step_1100_Edit().Wait();

			//Step_1200_Delete().Wait();

			Step_1300_State().Wait();
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

				System.Console.WriteLine(user.ToString());

				databaseContext.SaveChanges();

				System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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
					System.Console.WriteLine(user.ToString());
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

				// دستور ذیل خطا نمی‌دهد - منطقی هم نیست و در ضمن کار هم نمی‌کند
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

				//var users =
				//	await
				//	databaseContext.Users
				//	.OrderBy(current => current.Username)
				//	.ToListAsync()
				//	;

				// خیلی توصیه نمی‌شود
				//var users =
				//	await
				//	databaseContext.Users
				//	.OrderBy(current => current.Username)
				//	.Where(current => current.Id > 10)
				//	.ToListAsync()
				//	;

				var users =
					await
					databaseContext.Users
					.Where(current => current.Id > 10)
					.OrderBy(current => current.Username)
					.ToListAsync()
					;

				foreach (var user in users)
				{
					System.Console.WriteLine(user.ToString());
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
			Step_1100_Edit()
		{
			int newId = 0;

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var newUser =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				await databaseContext.Users.AddAsync(newUser);

				await databaseContext.SaveChangesAsync();

				newId = newUser.Id;
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
				}
			}

			System.Console.WriteLine($"New Id: { newId }");

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				foundedUser.Username = "Dariush";
				foundedUser.Password = "123456789";
				foundedUser.FullName = "Dariush Tasdighi";

				await databaseContext.SaveChangesAsync();
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
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(foundedUser.ToString());
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_1200_Delete()
		{
			int newId = 0;

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var newUser =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				await databaseContext.Users.AddAsync(newUser);

				await databaseContext.SaveChangesAsync();

				newId = newUser.Id;
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
				}
			}

			System.Console.WriteLine($"New Id: { newId }");

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				databaseContext.Users.Remove(foundedUser);

				await databaseContext.SaveChangesAsync();
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
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(foundedUser.ToString());
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_1300_State()
		{
			int newId = 0;

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var newUser =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				System.Console.WriteLine(databaseContext.Entry(newUser).State);

				await databaseContext.Users.AddAsync(newUser);

				System.Console.WriteLine(databaseContext.Entry(newUser).State);

				await databaseContext.SaveChangesAsync();

				System.Console.WriteLine(databaseContext.Entry(newUser).State);

				newId = newUser.Id;
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
				}
			}

			System.Console.WriteLine($"New Id: { newId }");

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);

				string username =
					foundedUser.Username;

				foundedUser.Username = username;

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);

				foundedUser.Username = "Googooli";

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);

				foundedUser.Username = username;

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);

				await databaseContext.SaveChangesAsync();

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);
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
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);

				databaseContext.Users.Remove(foundedUser);

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);

				await databaseContext.SaveChangesAsync();

				System.Console.WriteLine(databaseContext.Entry(foundedUser).State);
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task Step_0140_Add_1_Async()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// **************************************************
				var user =
					new Domain.User
					{
						Username = "Dariush",
						Password = "1234512345",
						FullName = "Dariush Tasdighi",
					};
				// **************************************************

				await databaseContext.Users.AddAsync(user);

				System.Console.WriteLine(user.ToString());

				await databaseContext.SaveChangesAsync();

				System.Console.WriteLine(user.ToString());
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task Step_0150_Add_2_Async()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				// **************************************************
				var user =
					new Domain.User
					{
						Username = "Dariush",
						Password = "1234512345",
						FullName = "Dariush Tasdighi",
					};
				// **************************************************

				databaseContext.Entry(user).State = EntityState.Added;

				System.Console.WriteLine(user.ToString());

				await databaseContext.SaveChangesAsync();

				System.Console.WriteLine(user.ToString());
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_0160_Edit_1_Async()
		{
			int newId = 0;

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var newUser =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				await databaseContext.Users.AddAsync(newUser);

				await databaseContext.SaveChangesAsync();

				newId = newUser.Id;
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
				}
			}

			System.Console.WriteLine($"New Id: { newId }");

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				foundedUser.Username = "Dariush";
				foundedUser.Password = "123456789";
				foundedUser.FullName = "Dariush Tasdighi";

				await databaseContext.SaveChangesAsync();
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
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(foundedUser.ToString());
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_0170_Edit_2_Async()
		{
			int newId = 0;

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var newUser =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				await databaseContext.Users.AddAsync(newUser);

				await databaseContext.SaveChangesAsync();

				newId = newUser.Id;
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
				}
			}

			System.Console.WriteLine($"New Id: { newId }");

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var theUser =
					new Domain.User
					{
						Id = newId,
						Username = "Dariush",
						Password = "123456789",
						FullName = "Dariush Tasdighi",
					};

				databaseContext.Entry(theUser).State = EntityState.Modified;

				await databaseContext.SaveChangesAsync();
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
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(foundedUser.ToString());
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_0180_Delete_1_Async()
		{
			int newId = 0;

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var newUser =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				await databaseContext.Users.AddAsync(newUser);

				await databaseContext.SaveChangesAsync();

				newId = newUser.Id;
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
				}
			}

			System.Console.WriteLine($"New Id: { newId }");

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				databaseContext.Users.Remove(foundedUser);

				await databaseContext.SaveChangesAsync();
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
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(foundedUser.ToString());
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
				}
			}
		}

		private static
			async
			System.Threading.Tasks.Task
			Step_0190_Delete_2_Async()
		{
			int newId = 0;

			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var newUser =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				await databaseContext.Users.AddAsync(newUser);

				await databaseContext.SaveChangesAsync();

				newId = newUser.Id;
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
				}
			}

			System.Console.WriteLine($"New Id: { newId }");

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var theUser =
					new Domain.User
					{
						Id = newId,
					};

				databaseContext.Entry(theUser).State = EntityState.Deleted;

				await databaseContext.SaveChangesAsync();
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
				}
			}

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Id == newId)
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Console.WriteLine("User not found!");

					return;
				}

				System.Console.WriteLine(foundedUser.ToString());
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
				}
			}
		}

		private static void Question_01_Async()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				System.Console.WriteLine(databaseContext.Entry(user).State);

				user.FullName = "Dariush Tasdighi";

				System.Console.WriteLine(databaseContext.Entry(user).State); // Question
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
				}
			}
		}

		private static void Question_02_Async()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				System.Console.WriteLine(databaseContext.Entry(user).State);

				databaseContext.Users.Add(user);

				System.Console.WriteLine(databaseContext.Entry(user).State);

				databaseContext.Users.Remove(user);

				System.Console.WriteLine(databaseContext.Entry(user).State); // Question
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
				}
			}
		}

		private static void Question_03_Async()
		{
			Persistence.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var user =
					new Domain.User()
					{
						Username = "AliReza",
						Password = "1234512345",
						FullName = "Ali Reza Alavi",
					};

				System.Console.WriteLine(databaseContext.Entry(user).State);

				databaseContext.Users.Add(user);

				System.Console.WriteLine(databaseContext.Entry(user).State);

				databaseContext.SaveChanges();

				System.Console.WriteLine(databaseContext.Entry(user).State);

				user.FullName = "Dariush Tasdighi";

				databaseContext.Users.Remove(user);

				System.Console.WriteLine(databaseContext.Entry(user).State); // Question
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
				}
			}
		}
	}
}
