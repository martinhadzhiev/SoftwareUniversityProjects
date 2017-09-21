namespace _01.Stream_Progress
{
    public class Program
    {
        public static void Main()
        {
            IStreamable file = new File("file", 2, 100);
            IStreamable music = new File("music", 2, 100);

            StreamProgressInfo fileInfo = new StreamProgressInfo(file);
            StreamProgressInfo musicInfo = new StreamProgressInfo(music);
            
        }
    }
}
