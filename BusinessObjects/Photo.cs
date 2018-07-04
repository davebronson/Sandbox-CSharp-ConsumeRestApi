using System;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Represents digital photographic image.
	/// </summary>
	public class Photo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SandboxCSharpConsumeRestApi.Photo"/> class.
		/// </summary>
		public Photo()
		{
		}

		/// <summary>
		/// Gets or sets the unique identifier for the Photo.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the ID of the Album that this Photo belongs to.
		/// </summary>
		public int AlbumId { get; set; }

		/// <summary>
		/// Gets or sets the short description for the Photo.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the internet address that points at the Photo image.
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// Gets or sets the internet address that points at the small thumbnail of the Photo image.
		/// </summary>
		public string ThumbnailUrl { get; set; }
	}
}