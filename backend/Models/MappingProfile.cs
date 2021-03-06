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

            CreateMap<Mission, MissionDTO>();
            CreateMap<MissionDTO, Mission>();

            CreateMap<Mission, MissionWithUserDTO>();
            CreateMap<MissionWithUserDTO, Mission>();

            CreateMap<Mission, MissionWithEnterprisesDTO>();
            CreateMap<MissionWithEnterprisesDTO, Mission>();

            CreateMap<Mission, MissionWithUsingsDTO>();
            CreateMap<MissionWithUsingsDTO, Mission>();

            CreateMap<Experience, ExperienceDTO>();
            CreateMap<ExperienceDTO, Experience>();

            CreateMap<Enterprise, EnterpriseDTO>();
            CreateMap<EnterpriseDTO, Enterprise>();

            CreateMap<Consultant, UserDTO>();
            CreateMap<UserDTO, Consultant>();

            CreateMap<Consultant, UserWithPasswordDTO>();
            CreateMap<UserWithPasswordDTO, Consultant>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

            CreateMap<User, UserWithPasswordDTO>();
            CreateMap<UserWithPasswordDTO, User>();

            CreateMap<User, UserWithExperiencesDTO>();
            CreateMap<UserWithExperiencesDTO, User>();

            CreateMap<User, UserWithMasteringsDTO>();
            CreateMap<UserWithMasteringsDTO, User>();

            CreateMap<User, UserWithExperiencesWithMasteringsDTO>();
            CreateMap<UserWithExperiencesWithMasteringsDTO, User>();

            CreateMap<Consultant, ConsultantDTO>();
            CreateMap<ConsultantDTO, Consultant>();

            CreateMap<Manager, ManagerDTO>();
            CreateMap<ManagerDTO, Manager>();

            CreateMap<Manager, ManagerWithConsultantsDTO>();
            CreateMap<ManagerWithConsultantsDTO, Manager>();

            CreateMap<Manager, ManagerWithExperiencesWithMasteringsWithConsultantsDTO>();
            CreateMap<ManagerWithExperiencesWithMasteringsWithConsultantsDTO, Manager>();


            CreateMap<Mastering, MasteringDTO>();
            CreateMap<MasteringDTO, Mastering>();

            CreateMap<Mastering, MasteringWithSkillDTO>();
            CreateMap<MasteringWithSkillDTO, Mastering>();

            CreateMap<Mastering, MasteringWithUserDTO>();
            CreateMap<MasteringWithUserDTO, Mastering>();

            CreateMap<Mastering, MasteringWithSkillAndUserDTO>();
            CreateMap<MasteringWithSkillAndUserDTO, Mastering>();

            CreateMap<Using, UsingDTO>();
            CreateMap<UsingDTO, Using>();

            CreateMap<Using, UsingWithSkillDTO>();
            CreateMap<UsingWithSkillDTO, Using>();

            CreateMap<Using, UsingWithExperienceDTO>();
            CreateMap<UsingWithExperienceDTO, Using>();

            CreateMap<Skill, SkillDTO>();
            CreateMap<SkillDTO, Skill>();

            CreateMap<Skill, SkillWithMasteringsDTO>();
            CreateMap<SkillWithMasteringsDTO, Skill>();

            CreateMap<Skill, SkillWithUsingsDTO>();
            CreateMap<SkillWithUsingsDTO, Skill>();

            CreateMap<Skill, SkillWithCategoryDTO>();
            CreateMap<SkillWithCategoryDTO, Skill>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<Category, CategoryWithSkillsDTO>();
            CreateMap<CategoryWithSkillsDTO, Category>();

            CreateMap<Category, CategoryWithSkillsAndMasteringsDTO>();
            CreateMap<CategoryWithSkillsAndMasteringsDTO, Category>();

            CreateMap<Category, CategoryWithSkillsAndUsingsDTO>();
            CreateMap<CategoryWithSkillsAndUsingsDTO, Category>();

            CreateMap<Training, TrainingDTO>();
            CreateMap<TrainingDTO, Training>();

            CreateMap<Training, TrainingWithEnterprisesAndUsingsDTO>();
            CreateMap<TrainingWithEnterprisesAndUsingsDTO, Training>();

            // CreateMap<Training, TrainingWithUserDTO>();
            // CreateMap<TrainingWithUserDTO, Training>();

            CreateMap<Training, TrainingWithUsingsDTO>();
            CreateMap<TrainingWithUsingsDTO, Training>();

        }
    }
}
