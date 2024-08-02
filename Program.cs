using SavarankiskaUzduotisPenktadienis.Models;
using SavarankiskaUzduotisPenktadienis.Repositories;
using SavarankiskaUzduotisPenktadienis.Services;
using System;

public class Program
{
    private static UserService _userService;
    private static PostService _postService;

    public static void Main(string[] args)
    {
        string connectionString = "Server=localhost;Database=UsersAndPosts;Trusted_Connection=True;";

        _userService = new UserService(new UserRepository(connectionString));
        _postService = new PostService(new PostRepository(connectionString));

        while (true)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Add User to database");
            Console.WriteLine("2. Add Post to database");
            Console.WriteLine("3. Get User from database");
            Console.WriteLine("4. Get Post from database");
            Console.WriteLine("5. Delete User from database");
            Console.WriteLine("6. Delete Post from database");
            Console.WriteLine("----------------------------");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    var user = new User { Name = name, Email = email };
                    _userService.AddUser(user);

                    break;

                case "2":

                    Console.Write("Enter User Id: ");
                    int userId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Content: ");
                    string content = Console.ReadLine();

                    var post = new Post { UserId = userId, Title = title, Content = content };
                    _postService.AddPost(post);

                    break;

                case "3":
                    Console.Write("Enter User Id: ");
                    int getUserId = int.Parse(Console.ReadLine());
                    var getUser = _userService.GetUser(getUserId);
                    if (getUser != null)
                    {
                        Console.WriteLine($"Id: {getUser.Id}, Name: {getUser.Name}, Email: {getUser.Email}");
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }

                    break;

                case "4":

                    Console.Write("Enter Post Id: ");
                    int getPostId = int.Parse(Console.ReadLine());
                    var getPost = _postService.GetPost(getPostId);
                    if (getPost != null)
                    {
                        Console.WriteLine($"Id: {getPost.Id}, UserId: {getPost.UserId}, Title: {getPost.Title}, Content: {getPost.Content}");
                    }
                    else
                    {
                        Console.WriteLine("Post not found.");
                    }

                    break;

                case "5":
                    Console.Write("Enter User Id: ");
                    var deleteUserId = int.Parse(Console.ReadLine());
                    _userService.DeleteUser(deleteUserId);

                    break;

                case "6": 
                    
                    Console.Write("Enter Post Id: ");
                    var deletePostId = int.Parse(Console.ReadLine());
                    _postService.DeletePost(deletePostId);

                    break;


                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }

}