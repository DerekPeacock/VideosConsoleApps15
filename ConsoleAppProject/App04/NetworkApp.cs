using System;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This class offers a console based user interface for the
    /// NewsFeed class and allows users to make multiple posts
    /// 
    /// Author: Derek Peacock
    /// </summary>
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        
        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Derek's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "Display All Posts", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;
                }

            } while (!wantToQuit);

        }

        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();


            Console.Write(" Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(NewsFeed.AUTHOR, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting an Message");


            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();



            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle(" You have just posted this message:");
            post.Display();
        }
    }
}
