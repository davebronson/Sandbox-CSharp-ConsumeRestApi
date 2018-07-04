using System;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Represents a statused task belonging to a User.
	/// </summary>
	public class ToDo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SandboxCSharpConsumeRestApi.ToDo"/> class.
		/// </summary>
		public ToDo()
		{
		}

		/// <summary>
		/// Gets or sets the unique identifier for the ToDo.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the ID of the User that this ToDo belongs to.
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets the headline or short description for the ToDo.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the ToDo is in a completed state.
		/// </summary>
		public bool Completed { get; set; }
	}
}