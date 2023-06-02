using System;
namespace SocialNetwork
{
	public class Post
	{
		public Post()
		{
			Console.WriteLine("New Post");
		}
		private string text;

        public string Text
		{
			get { return text; }
			set { text = value; }
		}

		public void ShowPost()
		{
			Console.WriteLine(text);
		}
    }
}

