using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.Queries.GetNoteDetails
{
    public class NoteDetailsVm : IMapwith<Note>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsVm>()
                .ForMember(noteVm => noteVm.Title,
                opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.Details,
                opt => opt.MapFrom(note => note.Details))
                .ForMember(noteVm => noteVm.ID,
                opt => opt.MapFrom(noteVm => noteVm.ID))
                .ForMember(noteVm => noteVm.CreationDate,
                opt => opt.MapFrom(noteVm => noteVm.CrationDate))
                .ForMember(noteVm => noteVm.EditDate,
                opt => opt.MapFrom(noteVm => noteVm.EditDate));
        }
    }
}
