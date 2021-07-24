namespace Domain
{
	/// <summary>
	/// POCO -> Plain Old CLR Object
	/// </summary>
	public class User : object
	{
		public User() : base()
		{
		}

		/// <summary>
		/// Id, ID, UserId, UserID
		/// </summary>
		public int Id { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public string FullName { get; set; }

		//public string GetInformation()
		//{
		//	string result =
		//		$"Id: { Id } - Username: { Username } - Password: { Password } - Full Name: { FullName }";

		//	return result;
		//}

		/// <summary>
		/// دستور ذیل خیلی شیک‌تر است
		/// </summary>
		public override string ToString()
		{
			string result =
				$"Id: { Id } - Username: { Username } - Password: { Password } - Full Name: { FullName }";

			return result;
		}
	}
}
