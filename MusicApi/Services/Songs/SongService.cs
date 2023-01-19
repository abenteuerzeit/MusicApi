using Domain.Interfaces;
using Api.DTOs.Songs;
using Domain.Entities.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.Songs
{
    public class SongService : BaseService
    {

        public SongService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<List<SongInfoDTO>> SearchAsync(GetSongRequest request)
        {
            var repository = UnitOfWork.AsyncRepository<Song>();
            var songs = await repository.ListAsync(_ => _.Title.Contains(request.Search));

            var songDTOs = songs.Select(_ => new SongInfoDTO()
            {
                Id = _.Id,
                Title = _.Title,
                Artist = _.Artist,
                Album = _.Album,
                Genre = _.Genre
            }).ToList();
            return songDTOs;
        }

        public async Task<AddSongResponse> AddNewAsync(AddSongRequest model)
        {
            var song = new Song
                (
                    model.Title,
                    model.Artist,
                    model.Album,
                    model.Genre
                );

            var repository = UnitOfWork.AsyncRepository<Song>();
            await repository.AddAsync(song);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddSongResponse()
            {
                Id = song.Id,
                Title = song.Title,
            };
            return response;
        }
    }

}

