using System.Collections;

namespace WebApplication3.Controllers;

public class Posts
{
    private readonly string path = "bin/Debug/net7.0/idkPosts.csv";

    public void EditPost(int id, string newHeader, string newBody)
    {
        
    }
    
    public void RemovePost(int id)
    {
        List<string> records =
            File.ReadAllLines(
                path).ToList();
        records.RemoveAt(id - 1);
        File.WriteAllLines(path,
            records.ToArray());
    }

    public void AddPost(string postHeader, string postBody)
    {
        int lineCount = File
            .ReadLines(path)
            .Count();
        string content = "\n" + lineCount + ";" + postHeader + ";" + postBody;
        File.AppendAllText(path,
            content);
    }

    public List<OnePost> ReadPosts()
    {
        List<OnePost> posts = new List<OnePost>();
        var input = File.ReadLines(path);

        foreach (var post in input)
        {
            var tempPost = post.Split(";");
            posts.Add(new OnePost(int.Parse(tempPost[0]), tempPost[1], tempPost[2]));
        }

        return posts;
    }
}

public class OnePost
{
    public OnePost(int postId, string postHeader, string postText)
    {
        PostId = postId;
        PostHeader = postHeader;
        PostText = postText;
    }

    public int PostId { get; private set; }
    public String PostHeader { get; private set; }
    public String PostText { get; private set; }
}