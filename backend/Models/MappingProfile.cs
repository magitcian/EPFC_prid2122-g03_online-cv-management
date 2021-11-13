using AutoMapper;

namespace prid2122_g03.Models
{
    /*
    Cette classe sert à configurer AutoMapper pour lui indiquer quels sont les mappings possibles
    et, le cas échéant, paramétrer ces mappings de manière déclarative (nous verrons des exemples plus tard).
    */
    public class MappingProfile : Profile
    {
        private CvContext _context;

        /*
        Le gestionnaire de dépendance injecte une instance du contexte EF dont le mapper peut
        se servir en cas de besoin (ce n'est pas encore le cas).
        */
        public MappingProfile(CvContext context) {
            _context = context;

            CreateMap<Member, MemberDTO>();
            CreateMap<MemberDTO, Member>();

            CreateMap<Member, MemberWithPasswordDTO>();
            CreateMap<MemberWithPasswordDTO, Member>();

            CreateMap<Phone, PhoneDTO>();
            CreateMap<PhoneDTO, Phone>();
        }
    }
}
