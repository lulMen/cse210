public class Menu
{
    private List<Video> _videos = new List<Video>();

    public Menu(){}

    public void Start()
    {
        bool isRunning = true;

        while (isRunning)
        {
            List<string> options = new List<string>
            {
                "  1. Display Videos",
                "  2. Add Video",
                "  3. Add Comment",
                "  4. Quit"
            };

            Console.WriteLine("Video Manager");

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            Console.Write("Please make a selection: ");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                for (int i = 0; i < _videos.Count(); i++)
                {
                    Console.WriteLine($"  {i + 1}. {_videos[i].GetVideoDetails()}");
                    _videos[i].ShowComments();
                }
            } else if (selection == "2")
            {
                Console.Write("What is the title of the video? ");
                string title = Console.ReadLine();
                Console.Write("What is the author of the video? ");
                string author = Console.ReadLine();
                Console.Write("How many minutes is the video? ");
                string length = Console.ReadLine();

                Video newVideo = new(title, author, int.Parse(length));
                _videos.Add(newVideo);

            } else if (selection == "3")
            {
                for (int i = 0; i < _videos.Count(); i++)
                {
                    Console.WriteLine($"  {i + 1}. {_videos[i].GetVideoInfo()}");
                }
                Console.WriteLine("Select a video: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                
                Console.WriteLine("What is the comment's text? ");
                string text = Console.ReadLine();
                Console.Write("Commentor's name: ");
                string name = Console.ReadLine();
                
                Comment newComment = new(name, text);
                _videos[index].addComment(newComment);

            } else if (selection == "4")
            {
                isRunning = false;
            } else {
                Console.WriteLine("Please try again.");
            }
        }  
    }
}