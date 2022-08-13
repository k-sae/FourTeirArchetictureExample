#Meet structure
### General guidelines
The project is using dependency injection across multiple instances in order to
- Eliminate tight coupling by making dependency relying on interfaces instead of concrete implementation (separation of concern)
- Allow the modification/extension of domain logic without affecting the step logic
### Project directory structure
1. Controllers:
   1. The logic stater of business logic
   2. Contains the step invocation logic
   3. Services are injected into the controller constructor according to the use case of each controller ex:
      ```c#
      public PostController(IPostService ps,IUserService ius, IImageService ims)
      ```
2. Models:
   1. These are the data Holders which are translated from/into JSON on each request/response
   2. Have the validation rules for each attribute ex:
    ```c#
    public class Post
   {
      [Required]
      [StringLength(100)]
      public int Title { get; set; }
    ```
3. Services:
   1. These contain the detailed logic for each of the step methods
   2. Each service relies on its repository only to be injected ex:
   ```c#
   public PostService(IPostRepository postRepository)
   ```
4. Repositories:
   1. This Abstracts the data layer which based on Couchbase DB
   2. The methods names should reflect its behaviour strictly ex:
   ```c#
   // fetch the most liked posts with in date interval
   public Task<IEnumerable<Post>> GetMostLikedPostBetweenInterval(DateTime start, DateTime end)
   ```
