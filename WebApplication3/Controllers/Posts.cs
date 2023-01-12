using System.Collections;

namespace WebApplication3.Controllers;

public class Posts
{
    private const string Path = "bin/Debug/net7.0/idkPosts.csv";

    public void EditPost(int id, string newHeader, string newBody)
    {
        
    }
    
    public void RemovePost(int id)
    {
        var lines = File.ReadAllLines(Path).Where(arg => !string.IsNullOrWhiteSpace(arg));
        File.WriteAllLines(Path, lines);
        
        
        List<string> records =
            File.ReadAllLines(
                Path).ToList();
        records.RemoveAt(id);
        File.WriteAllLines(Path,
            records.ToArray());
    }

    public void AddPost(string postHeader, string postBody)
    {
        var lines = File.ReadAllLines(Path).Where(arg => !string.IsNullOrWhiteSpace(arg));
        File.WriteAllLines(Path, lines);
        
        int lineCount = File
            .ReadLines(Path)
            .Count();
        string content = "\n" + (lineCount + 1) + ";" + postHeader + ";" + postBody;
        File.AppendAllText(Path,
            content);
    }

    public List<OnePost> ReadPosts()
    {
        List<OnePost> posts = new List<OnePost>();
        var input = File.ReadLines(Path);

        foreach (var post in input)
        {
            if (post.Length <= 0) continue;
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