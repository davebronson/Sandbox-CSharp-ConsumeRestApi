using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace SandboxCSharpConsumeRestApi
{
	class MainClass
	{
		// https://jsonplaceholder.typicode.com << Faked REST service
		// https://github.com/typicode/json-server << Details on querying the faked REST service

		private static List<User> UserList = new List<User>();

		public static void Main(string[] args)
		{
			MainAsync().Wait();
		}

		public static async Task MainAsync()
		{
			JArray users = await RestServiceHelper.GetResponseAsObject("https://jsonplaceholder.typicode.com/users?_sort=username&_order=asc");
			JArray todos = await RestServiceHelper.GetResponseAsObject("https://jsonplaceholder.typicode.com/todos?_sort=userId,title&_order=asc,asc");
			JArray posts = await RestServiceHelper.GetResponseAsObject("https://jsonplaceholder.typicode.com/posts?_sort=userId,title&_order=asc,asc");
			JArray comments = await RestServiceHelper.GetResponseAsObject("https://jsonplaceholder.typicode.com/comments?_sort=postId,name&_order=asc,asc");
			JArray albums = await RestServiceHelper.GetResponseAsObject("https://jsonplaceholder.typicode.com/albums?_sort=userId,title&_order=asc,asc");
			JArray photos = await RestServiceHelper.GetResponseAsObject("https://jsonplaceholder.typicode.com/photos?_sort=albumId,title&_order=asc,asc");


			// Process Users
			// *************
			User foundUser = null;

			foreach (JToken item in users)
			{
				User user = new User();

				user.Id = int.Parse(item["id"].ToString());
				user.Name = item["name"].ToString();
				user.UserName = item["username"].ToString();
				user.Email = item["email"].ToString();
				user.Phone = item["phone"].ToString();
				user.Website = item["website"].ToString();
				user.CompanyName = item["company"]["name"].ToString();
				user.CompanyCatchPhrase = item["company"]["catchPhrase"].ToString();
				user.CompanyBs = item["company"]["bs"].ToString();

				user.Address.Id = 0; // No ID provided
				user.Address.UserId = user.Id;
				user.Address.Street = item["address"]["street"].ToString();
				user.Address.Suite = item["address"]["suite"].ToString();
				user.Address.City = item["address"]["city"].ToString();
				user.Address.ZipCode = item["address"]["zipcode"].ToString();
				user.Address.GeoLatitude = decimal.Parse(item["address"]["geo"]["lat"].ToString());
				user.Address.GeoLongitude = decimal.Parse(item["address"]["geo"]["lng"].ToString());

				UserList.Add(user);
			}


			// Process ToDos
			// *************
			foundUser = null;

			foreach (JToken item in todos)
			{
				ToDo todo = new ToDo();

				todo.Id = int.Parse(item["id"].ToString());
				todo.UserId = int.Parse(item["userId"].ToString());
				todo.Title = item["title"].ToString();
				todo.Completed = bool.Parse(item["completed"].ToString());

				// Find the ToDo's user, and append
				if (foundUser == null || todo.UserId != foundUser.Id)
				{
					foundUser = UserList.FirstOrDefault(x => x.Id == todo.UserId);
				}
				if (foundUser != null)
				{
					foundUser.Todos.Add(todo);
				}
			}


			// Process Posts
			// *************
			foundUser = null;

			foreach (JToken item in posts)
			{
				Post post = new Post();

				post.Id = int.Parse(item["id"].ToString());
				post.UserId = int.Parse(item["userId"].ToString());
				post.Title = item["title"].ToString();
				post.Body = item["body"].ToString();

				// Append Comments for this Post
				IEnumerable<JToken> postsComments = comments.Where(x => int.Parse(x["postId"].ToString()) == post.Id);
				foreach (JToken c in postsComments)
				{
					Comment comment = new Comment();

					comment.Id = int.Parse(c["id"].ToString());
					comment.PostId = int.Parse(c["postId"].ToString());
					comment.Name = c["name"].ToString();
					comment.Email = c["email"].ToString();
					comment.Body = c["body"].ToString();

					post.Comments.Add(comment);
				}

				// Find the Post's user, and append
				if (foundUser == null || post.UserId != foundUser.Id)
				{
					foundUser = UserList.FirstOrDefault(x => x.Id == post.UserId);
				}
				if (foundUser != null)
				{
					foundUser.Posts.Add(post);
				}
			}


			// Process Albums
			// **************
			foundUser = null;

			foreach (JToken item in albums)
			{
				Album album = new Album();

				album.Id = int.Parse(item["id"].ToString());
				album.UserId = int.Parse(item["userId"].ToString());
				album.Title = item["title"].ToString();

				// Append Photos for this Album
				IEnumerable<JToken> albumsPhotos = photos.Where(x => int.Parse(x["albumId"].ToString()) == album.Id);
				foreach (JToken p in albumsPhotos)
				{
					Photo photo = new Photo();

					photo.Id = int.Parse(p["id"].ToString());
					photo.AlbumId = int.Parse(p["albumId"].ToString());
					photo.Title = p["title"].ToString();
					photo.Url = p["url"].ToString();
					photo.ThumbnailUrl = p["thumbnailUrl"].ToString();

					album.Photos.Add(photo);
				}

				// Find the Album's user, and append
				if (foundUser == null || album.UserId != foundUser.Id)
				{
					foundUser = UserList.FirstOrDefault(x => x.Id == album.UserId);
				}
				if (foundUser != null)
				{
					foundUser.Albums.Add(album);
				}
			}
		}
	}
}
