using System;
using System.Collections.Generic;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Represents a collection of related Photos belonging to a User.
	/// </summary>
	public class Album
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SandboxCSharpConsumeRestApi.Album"/> class.
		/// </summary>
		public Album()
		{
		}

		/// <summary>
		/// Gets or sets the unique identifier for the Album.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the ID of the User that this Album belongs to.
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets the short description for the Album.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the list of Photo objects.
		/// </summary>
		public List<Photo> Photos { get; set; } = new List<Photo>();
	}
}