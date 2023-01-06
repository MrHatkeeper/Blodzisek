using System.Collections;

namespace WebApplication3.Controllers;

public class Posts
{
    public List<OnePost> ManagePosts()
    {
        List<OnePost> posts = new List<OnePost>();
        var input = File.ReadLines(
            "/home/warel/RiderProjects/WebApplication3/WebApplication3/bin/Debug/net7.0/posts.csv");

        foreach (var post in input)
        {
            
        }
        return posts;
    }
}

public class OnePost
{
    public OnePost(int postId, string postHeader, string postText)
    {
    
        this.PostId = postId;
        this.PostHeader = postHeader;
        this.PostText = postText;
    }

    public int PostId { get; private set; }
    public String PostHeader { get; private set; }
    public String PostText { get; private set; }

}