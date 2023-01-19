using Domain.Entities.Songs;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class SongRepository : RepositoryBase<Song>, ISongRepository
    {
        public SongRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
