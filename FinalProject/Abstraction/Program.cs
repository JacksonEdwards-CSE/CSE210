
class Program
{
    public static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Bob867", "Programming in CSE210", 630);
        videoList.Add(video1);

        Comment comment1 = new Comment("Commenter1", "210 is fun!");
        video1.AppendComment(comment1);
        Comment comment2 = new Comment("Commenter2", "C# is good");
        video1.AppendComment(comment2);
        Comment comment3 = new Comment("Commenter3", "STC is a nice place");
        video1.AppendComment(comment3);
        Comment comment4 = new Comment("Commenter4", "Great Job!");
        video1.AppendComment(comment4);
        
        Video video2 = new Video("Betty53", "Learning at BYUI", 957);
        videoList.Add(video2);

        Comment comment5 = new Comment("Commenter5", "BYUI is cool");
        video2.AppendComment(comment5);
        Comment comment6 = new Comment("Commenter6", "Learning is fun");
        video2.AppendComment(comment6);
        Comment comment7 = new Comment("Commenter7", "Nice Campus!");
        video2.AppendComment(comment7);
        Comment comment8 = new Comment("Commenter8", "Lots of opportunities there");
        video2.AppendComment(comment8);

        Video video3 = new Video("Bubba09", "Going home over break", 415);
        videoList.Add(video3);

        Comment comment9 = new Comment("Commenter9", "Seeing family is nice!");
        video3.AppendComment(comment9);
        Comment comment10 = new Comment("Commenter10", "Only for a week");
        video3.AppendComment(comment10);
        Comment comment11 = new Comment("Commenter11", "Missouri is a bit far away");
        video3.AppendComment(comment11);
        Comment comment12 = new Comment("Commenter12", "Flying is tiring");
        video3.AppendComment(comment12);

        Video video4 = new Video("Jackson01", "Working at Domino's", 743);
        videoList.Add(video4);

        Comment comment13 = new Comment("Commenter13", "Making some money");
        video4.AppendComment(comment9);
        Comment comment14 = new Comment("Commenter14", "Tips are nice");
        video4.AppendComment(comment10);
        Comment comment15 = new Comment("Commenter15", "That's a lot of gas");
        video4.AppendComment(comment11);
        Comment comment16 = new Comment("Commenter16", "That's a nice gig!");
        video4.AppendComment(comment12);

        foreach (Video video in videoList)
        {
            video.GetVideoData();
            
            video.DisplayComments();
            
            video.GetCommentData();

            Console.WriteLine();
        }




    }
}