//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		/// <summary>
//		/// Primary Key -> OK
//		/// </summary>
//		public int Id { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		/// <summary>
//		/// Primary Key -> Error!
//		/// </summary>
//		public int Code { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		/// <summary>
//		/// Primary Key -> OK
//		/// </summary>
//		[System.ComponentModel.DataAnnotations.Key]
//		public int Code { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		public string Description { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		[System.ComponentModel.DataAnnotations.MaxLength
//			(length: 100)]
//		public string FullName { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		[System.ComponentModel.DataAnnotations.MinLength
//			(length: 3)]

//		[System.ComponentModel.DataAnnotations.MaxLength
//			(length: 100)]
//		public string FullName { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		[System.ComponentModel.DataAnnotations.StringLength
//			(maximumLength: 100)]
//		public string FullName { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		[System.ComponentModel.DataAnnotations.StringLength
//			(maximumLength: 100, MinimumLength = 3)]
//		public string FullName { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		[System.ComponentModel.DataAnnotations.Required]

//		[System.ComponentModel.DataAnnotations.StringLength
//			(maximumLength: 100, MinimumLength = 3)]
//		public string FullName { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		[System.ComponentModel.DataAnnotations.Required
//			(AllowEmptyStrings = false)]

//		[System.ComponentModel.DataAnnotations.StringLength
//			(maximumLength: 100, MinimumLength = 3)]
//		public string FullName { get; set; }
//	}
//}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		[System.ComponentModel.DataAnnotations.Range
//			(minimum: 20, maximum: 30)]
//		public int Age { get; set; }
//	}
//}

namespace Domain
{
	public class SomeClass : object
	{
		public SomeClass() : base()
		{
		}

		public int Id { get; set; }

		//[System.ComponentModel.DataAnnotations.RegularExpression(pattern: "^\\d$")]
		[System.ComponentModel.DataAnnotations.RegularExpression(pattern: "^\\d{10}$")]
		//[System.ComponentModel.DataAnnotations.RegularExpression(pattern: "^\\d{3,8}$")]
		public int PostalCode { get; set; }

		public void Check()
		{
			bool isMatch =
				System.Text.RegularExpressions.Regex.IsMatch(input: "", pattern: "^\\d{ 10}$");
		}
	}
}

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		[System.ComponentModel.DataAnnotations.Key]
//		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
//		public int UserId { get; set; }

//		[System.ComponentModel.DataAnnotations.Key]
//		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 1)]
//		public int GroupId { get; set; }
//	}
//}
