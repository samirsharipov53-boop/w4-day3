public class Post
{
    int id;
    public string? Title{get; set;}
    public string? Discription{get; set;}
    public int CategoryId{get; set;}
    static int next=1;
    static List<Post> posts=[];
    public static void CreatePost(string t, string d, int c)
    {
        Post post = new Post()
        {
            id=next,
            Title=t,
            Discription=d,
            CategoryId=c
        };
        posts.Add(post);
        next++;
    }
    public static List<Post> GetPostsBy(string a)
    {
        return posts;
    }
    public static List<Post> GetPosts()
    {
        return posts;
    }
    List<int> CategoryIdeis = new List<int>();
   public static List<int> CategoryIdeas =new List<int>();
   
   
    public static List<Post> GetPostByCategoryId(int id)
    {
        foreach (var item in posts)
        {
            CategoryIdeas.Add(item.CategoryId);
        }
        foreach (var item in CategoryIdeas)
        {
         if (item == id)
            {
               return posts; 
            }   
        }

        return null;
    }

  public static  void DeleteById(int i)
    {
        foreach (var item in posts)
        {
            if (item.id == i)
            {
                posts.Remove(item);
            }
        }
    }
}