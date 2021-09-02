//namespace Domain
//{
//	public class Country : object
//	{
//		public Country() : base()
//		{
//		}

//		/// <summary>
//		/// Primary Key -> OK
//		/// </summary>
//		public int Id { get; set; }
//		public int ID { get; set; }
//		public int CountryId { get; set; }
//		public int CountryID { get; set; }
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

//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		public int Id { get; set; }

//		//[System.ComponentModel.DataAnnotations.RegularExpression(pattern: "^\\d$")]
//		[System.ComponentModel.DataAnnotations.RegularExpression(pattern: "^\\d{10}$")]
//		//[System.ComponentModel.DataAnnotations.RegularExpression(pattern: "^\\d{3,8}$")]
//		public string PostalCode { get; set; }

//		public void Check()
//		{
//			bool isMatch =
//				System.Text.RegularExpressions.Regex.IsMatch(input: PostalCode, pattern: "^\\d{ 10}$");
//		}
//	}
//}

///// <summary>
///// EF: Automatically: Country -> Countries
///// </summary>
//[System.ComponentModel.DataAnnotations.Schema.Table(name: "CountriesTable")]
//public class Country : object
//{
//	public Country() : base()
//	{
//	}

//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "CountryId")]
//	public int Id { get; set; }

//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "CountryName")]
//	public string Name { get; set; }
//}

// **************************************************
// **************************************************
// **************************************************
//[System.ComponentModel.DataAnnotations.Schema.Table(name: "TABLE001")]
//public class Country : object
//{
//	public Country() : base()
//	{
//	}

//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "FIELD001")]
//	public int Id { get; set; }

//	[System.ComponentModel.DataAnnotations.Schema.Column(name: "FIELD002")]
//	public string Name { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Note: Schema does not work in SQL Server Compact Edition!
// **************************************************
//[System.ComponentModel.DataAnnotations.Schema.Table(name: "Countries", Schema = "Cms")]
//public class Country : object
//{
//	public Country() : base()
//	{
//	}

//	public int Id { get; set; }

//	public string Name { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Note: Does Not Work!
//[System.ComponentModel.DataAnnotations.Schema.Table(Schema = "Cms")]
//[System.ComponentModel.DataAnnotations.Schema.Table(name: "", Schema = "Cms")]
//[System.ComponentModel.DataAnnotations.Schema.Table(name: null, Schema = "Cms")]
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//	}

//	public int Id { get; set; }

//	public string Name { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Id:
//
//	C#		Database
//
//	int		int
//	long	long
//	Guid	uniqueidentifier
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//	}

//	//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//	//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//	public int Id { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//		// Note: Wrong Usage!
//		//Id = new System.Guid();

//		Id = System.Guid.NewGuid();
//	}

//	public System.Guid Id { get; set; }

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
//	public int Code { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//	}

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//	public int Id { get; set; }

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
//	public int Code { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Note: Wrong Usage!
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//	}

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
//	public int Id { get; set; }

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
//	public int Code { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//		Id = System.Guid.NewGuid();
//	}

//	public System.Guid Id { get; set; }

//	public int Code { get; set; }

//	public string Name { get; set; }

//	/// <summary>
//	/// EF.Core در
//	/// های محاسباتی Property
//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی گردند
//	/// </summary>
//	public string DisplayName
//	{
//		get
//		{
//			string result =
//				$"{ Code.ToString().PadLeft(3, '0') } - { Name }";

//			return result;
//		}
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//		Id = System.Guid.NewGuid();
//	}

//	public Country(string someProperty1, string someProperty2) : this()
//	{
//		SomeProperty1 = someProperty1;
//		SomeProperty2 = someProperty2;
//	}

//	public System.Guid Id { get; set; }

//	/// <summary>
//	/// در جدول بانک اطلاعاتی، تبديل به فيلد می‌گردد
//	/// </summary>
//	public string SomeProperty1 { get; private set; }

//	/// <summary>
//	/// در جدول بانک اطلاعاتی، تبديل به فيلد می‌گردد
//	/// </summary>
//	public string SomeProperty2 { get; protected set; }

//	/// <summary>
//	/// در جدول بانک اطلاعاتی، تبديل به فيلد نمی‌گردد
//	/// </summary>
//	[System.ComponentModel.DataAnnotations.Schema.NotMapped]
//	public string SomeProperty3 { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class Country : object
//{
//	public Country(string value) : base()
//	{
//		Id = System.Guid.NewGuid();
//		SomeReadOnlyProperty = value;
//	}

//	public System.Guid Id { get; set; }

//	/// <summary>
//	/// EF -> تبدیل به فیلد نمی‌شود
//	/// EF.Core: -> تبدیل به فیلد می‌شود
//	/// </summary>
//	public string SomeReadOnlyProperty { get; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//		Id = System.Guid.NewGuid();
//	}

//	public System.Guid Id { get; set; }

//	/// <summary>
//	/// Note:
//	/// 1. Order is Zero based!
//	/// 2. For changing field type or field order,
//	/// We should write the property name! (TypeName =)( Order =)
//	///
//	/// Note: Using TypeName is not recommended!
//	/// </summary>
//	[System.ComponentModel.DataAnnotations.Schema.Column
//		(name: "CountryName", Order = 0, TypeName = "Char")]

//	[System.ComponentModel.DataAnnotations.StringLength
//		(maximumLength: 100)]
//	public string Name { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//namespace Domain
//{
//	public class SomeClass : object
//	{
//		public SomeClass() : base()
//		{
//		}

//		[System.ComponentModel.DataAnnotations.Key]
//		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
//		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//		public int UserId { get; set; }

//		[System.ComponentModel.DataAnnotations.Key]
//		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 1)]
//		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//		public int GroupId { get; set; }
//	}
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Note: EF 6+
// **************************************************
//public class User : object
//{
//	public User() : base()
//	{
//		Id = System.Guid.NewGuid();
//	}

//	public System.Guid Id { get; set; }

//	// از نسخه ۲۰۱۹ یا ۲۰۱۶ دستور ذیل خطا نمی‌دهد
//	// ولی در نسخه‌های قدیمی خطا می‌دهد
//	//[System.ComponentModel.DataAnnotations.Schema.Index
//	//	(IsUnique = false)]
//	public string FullName { get; set; }

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]

//	//[Microsoft.EntityFrameworkCore.Index(IsUnique = true)]
//	public int Username { get; set; }
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class Country : object
//{
//	public Country() : base()
//	{
//		Id = System.Guid.NewGuid();
//	}

//	public System.Guid Id { get; set; }

//	// **************************************************
//	[System.ComponentModel.DataAnnotations.Schema.Index
//		(name: "Code1Code2", Order = 0, IsUnique = false)]
//	public int Code1 { get; set; }

//	[System.ComponentModel.DataAnnotations.Schema.Index
//		(name: "Code1Code2", Order = 1, IsUnique = false)]
//	public int Code2 { get; set; }
//	// **************************************************

//	// **************************************************
//	[System.ComponentModel.DataAnnotations.Schema.Index
//		(name: "Code3Code4", Order = 1, IsUnique = true)]
//	public int Code3 { get; set; }

//	[System.ComponentModel.DataAnnotations.Schema.Index
//		(name: "Code3Code4", Order = 0, IsUnique = true)]
//	public int Code4 { get; set; }
//	// **************************************************
//}
// **************************************************
// **************************************************
// **************************************************
