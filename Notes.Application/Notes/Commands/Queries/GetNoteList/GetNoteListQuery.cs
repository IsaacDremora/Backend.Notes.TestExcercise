using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Commands.Queries.GetNoteList
{
    public class GetNoteListQuery 
        : IRequest<NoteListVm>
    {
        public Guid UserID { get; set; }
        

    }
}
