namespace Api.DTOs.Songs
{
    public class AddSongRequest
    {
        public string Title { get; internal set; }
        public string Artist { get; internal set; }
        public string Album { get; internal set; }
        public string Genre { get; internal set; }
    }
}
