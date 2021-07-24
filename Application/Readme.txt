Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 5.0.7

	Microsoft.EntityFrameworkCore 

OR

<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.7" />

-----

DAL, Dal, DataAccessLayer, DataAccess, Data, Persistence

-----

Domain		-> Class Library
Persistence	-> Class Library

-----

Database				Table

DataSet					DataTable

DatabaseContext			Model / Entity

-----

(1)

void SomeFunctionSync(...)
{
	...
	someObject.DoSomethingSync(...);
	...
}

(2)

// Error!

void SomeFunctionSync(...)
{
	...
	someObject.DoSomethingAsync(...);
	...
}

(2.1)

void SomeFunctionSync(...)
{
	...
	var result = someObject.DoSomethingAsync(...).Result;
	...
}

(2.2)

void SomeFunctionSync(...)
{
	...
	someObject.DoSomethingAsync(...).Wait();
	...
}

(3.1)

- void SomeFunction(...):

async Task SomeFunctionAsync(...)
{
	...
	await someObject.DoSomethingAsync(...);
	...
}

(3.2)

- string SomeFunction(...):

async Task<string> SomeFunctionAsync(...)
{
	...
	await someObject.DoSomethingAsync(...);
	...
}

(4)

async Task SomeFunctionAsync(...)
{
	await Task.Run(() => {
		...
	});
}

-----

CRUD

	Create

	Retrieve

		Zero or (Max) One
		Zero or Many

	Update

	Delete
