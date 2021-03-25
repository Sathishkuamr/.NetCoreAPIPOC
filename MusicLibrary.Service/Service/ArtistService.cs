using AutoMapper;
using MusicLibrary.Core.Entities;
using MusicLibrary.Core.Models;
using MusicLibrary.DatatAccess.Interface;
using MusicLibrary.Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.Service.Service
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;

        public ArtistService(IArtistRepository artistRepository, IMapper mapper)
        {
            _artistRepository = artistRepository;
            _mapper = mapper;
        }

        /// <summary>
        ///  To get artist details
        /// </summary>
        /// <returns></returns>
        public async Task<List<ArtistDTO>> GetArtistDetails()
        {
            try
            {
                return _mapper.Map<List<ArtistDTO>>(await _artistRepository.GetArtistDetails());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="artistId"></param>
        /// <returns></returns>
        public async Task<ArtistDTO> GetArtistById(int artistId)
        {
            try
            {
                return _mapper.Map<ArtistDTO>(await _artistRepository.GetArtistById(artistId));
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}