using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Derek";

        private readonly List<Post> posts;

        // Using System.IO
        protected StreamWriter fileWriter;

        protected string filename;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            
            MessagePost post = new MessagePost(AUTHOR, "I love Visual Studio 2019");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "Visual Studio 2019");
            AddPhotoPost(photoPost);

            filename = "D:/Projects/PostData.txt";
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// 
        /// </summary>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);
            
            if (post == null)
            {
                Console.WriteLine($" \n Post with ID = {id} does not exist!!\n");
            }
            else
            {
                Console.WriteLine($" \n The following Post {id} has been removed!\n");

                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Post FindPost(int id)
        {
            foreach(Post post in posts)
            {
                if(post.PostId == id)
                {
                    return post;
                }
            }

            return null;
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            ConsoleHelper.OutputTitle("Displaying All Posts");

            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   
            }
        }

        public void SaveFile()
        {
            OpenFile();
        }


        /// <summary>
        /// Open a file for saving the posts
        /// </summary>
        private void OpenFile()
        {
            try
            {
                var output = new FileStream(
                    filename, FileMode.OpenOrCreate,
                    FileAccess.Write);

                fileWriter = new StreamWriter(output);
            }
            catch (IOException e)
            {
                Console.WriteLine("  File Open/Create Failed!!!");
            }
        }
    }

}
