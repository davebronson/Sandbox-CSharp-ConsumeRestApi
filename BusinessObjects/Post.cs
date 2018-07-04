using System;
using System.Collections.Generic;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Represents a blog Post belonging to a User.
	/// </summary>
	public class Post
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SandboxCSharpConsumeRestApi.Post"/> class.
		/// </summary>
		public Post()
		{
		}

		/// <summary>
		/// Gets or sets the unique identifier for the Post.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the ID of the User that this Post belongs to.
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets the headline or short description for the Post.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the full text of the Post.
		/// </summary>
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the list Comment objects that belong to the Post.
		/// </summary>
		/// <value>The comments.</value>
		public List<Comment> Comments { get; set; } = new List<Comment>(); 
	}
}