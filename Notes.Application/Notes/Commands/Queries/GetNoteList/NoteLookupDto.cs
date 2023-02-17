using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Commands.Queries.GetNoteList
{
    public class NoteLookupDto : IMapwith<Note>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLookupDto>()
                .ForMember(noteDto => noteDto.ID,
                opt => opt.MapFrom(note => note.ID))
                .ForMember(noteDto => noteDto.Title,
                opt => opt.MapFrom(note => note.Title));
        }
    }
}
