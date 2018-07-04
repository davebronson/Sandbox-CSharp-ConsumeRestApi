using System;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Represents a user comment on a blog Post.
	/// </summary>
	public class Comment
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SandboxCSharpConsumeRestApi.Comment"/> class.
		/// </summary>
		public Comment()
		{
		}

		/// <summary>
		/// Gets or sets the unique identifier for the Comment.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the ID of the Post that this Comment belongs to.
		/// </summary>
		public int PostId { get; set; }

		/// <summary>
		/// Gets or sets the name of the person commenting.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the email address of the person commenting.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the full text of the Comment.
		/// </summary>
		/// <value>The comment.</value>
		public string Body { get; set; }
	}
}