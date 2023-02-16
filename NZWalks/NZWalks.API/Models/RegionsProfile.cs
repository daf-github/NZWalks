using AutoMapper;

namespace NZWalks.API.Models
{
    public class RegionsProfile: Profile
    {

        public RegionsProfile() {


            CreateMap <Models.Domain.Region, Models.DTO.Region>();
        
        
        }



    }
}
