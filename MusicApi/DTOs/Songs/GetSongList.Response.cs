using System;
namespace Api.DTOs.Songs
{
    public class SongInfoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int? PlayListId { get; set; }

    }
}
