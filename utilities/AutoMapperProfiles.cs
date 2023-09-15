using AutoMapper;
using entity_framework.Models;
using entity_framework.ViewModels;

namespace entity_framework.Utilities;

/// <summary>
/// 
/// </summary>
public class AutoMapperProfiles: Profile
{
    /// <summary>
    /// 
    /// </summary>
    public AutoMapperProfiles()
    {
        CreateMap<GenreModel, Genre>();
        
/*             CreateMap<ActorCreacionDTO, Actor>();
        CreateMap<Actor, ActorDTO>();
        CreateMap<ComentarioCreacionDTO, Comentario>();

        CreateMap<PeliculaCreacionDTO, Pelicula>()
            .ForMember(ent => ent.Generos, dto => 
            dto.MapFrom(campo => campo.Generos.Select(id => new Genero { Id = id })));

        CreateMap<PeliculaActorCreacionDTO, PeliculaActor>(); */
    }
}
