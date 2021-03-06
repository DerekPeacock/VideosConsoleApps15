﻿using System;

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
        private readonly NewsFeed news = new NewsFeed();
        
        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Derek's News Feed");

            string[] choices = new string[]
            {
                "Post Message", 
                "Post Image",
                "Remove Post", 
                "Display All Posts", 
                "Display Posts by Author",
                "Display Posts by Date,",
                "Add Comments to Post,", 
                "Like/Unlike Post",
                "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost();break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor();break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment();break;
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }

            } while (!wantToQuit);

        }

        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ",
                                                    1, Post.GetNumberOfPosts());
            news.RemovePost(id);
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

            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();


            Console.Write(" Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
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

            string author = InputName();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();



            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle(" You have just posted this message:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
