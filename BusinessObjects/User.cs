using System;
using System.Collections.Generic;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Represents a person.
	/// </summary>
	public class User
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SandboxCSharpConsumeRestApi.User"/> class.
		/// </summary>
		public User()
		{
		}

		/// <summary>
		/// Gets or sets the unique identifier for the User.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the full name of the User.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the login username of the User.
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// Gets or sets the User's email address.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the User's phone number.
		/// </summary>
		public string Phone { get; set; }

		/// <summary>
		/// Gets or sets the User's personal website URL.
		/// </summary>
		public string Website { get; set; }

		/// <summary>
		/// Gets or sets the Address object that provides information about the User's place of residence.
		/// </summary>
		public Address Address { get; set; } = new Address();

		/// <summary>
		/// Gets or sets the name of the company that the User is employed by.
		/// </summary>
		public string CompanyName { get; set; }

		/// <summary>
		/// Gets or sets the catch-phrase of the company that the User is employed by.
		/// </summary>
		public string CompanyCatchPhrase { get; set; }

		/// <summary>
		/// Gets or sets some random baloney about the company that the User is employed by.
		/// </summary>
		public string CompanyBs { get; set; }

		/// <summary>
		/// Gets or sets a list Album objects.
		/// </summary>
		public List<Album> Albums { get; set; } = new List<Album>();

		/// <summary>
		/// Gets or sets a list ToDo objects.
		/// </summary>
		public List<ToDo> Todos { get; set; } = new List<ToDo>();

		/// <summary>
		/// Gets or sets a list Post objects.
		/// </summary>
		public List<Post> Posts { get; set; } = new List<Post>();
	}
}