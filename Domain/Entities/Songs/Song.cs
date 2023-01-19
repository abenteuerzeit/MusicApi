using Domain.Base;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Songs
{
    public class Song : BaseEntity<int>, IAggregateRoot
    {
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public string Album { get; private set; }
        public string Genre { get; private set; }

        public Song(string title, string artist, string album, string genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Genre = genre;
        }
    }
}
