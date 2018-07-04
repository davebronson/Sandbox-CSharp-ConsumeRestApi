using System;

namespace SandboxCSharpConsumeRestApi
{
	/// <summary>
	/// Represents a place of residence for a person or business.
	/// </summary>
	public class Address
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SandboxCSharpConsumeRestApi.Address"/> class.
		/// </summary>
		public Address()
		{
		}

		/// <summary>
		/// Gets or sets the unique identifier for the Address.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the ID of the User that this Address belongs to.
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets the number and street name.
		/// </summary>
		public string Street { get; set; }

		/// <summary>
		/// Gets or sets the suite or apartment number, if any.
		/// </summary>
		public string Suite { get; set; }

		/// <summary>
		/// Gets or sets the name of the city or town.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Gets or sets the postal code that the Address exists within.
		/// </summary>
		public string ZipCode { get; set; }

		/// <summary>
		/// Gets or sets the precise north-south geographic location on the surface of the Earth.
		/// </summary>
		public decimal GeoLatitude { get; set; }

		/// <summary>
		/// Gets or sets the precise east-west geographic location on the surface of the Earth.
		/// </summary>
		public decimal GeoLongitude { get; set; }
	}
}