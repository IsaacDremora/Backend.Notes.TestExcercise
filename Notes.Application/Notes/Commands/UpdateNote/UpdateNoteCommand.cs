using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Notes.Application.interfaces;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommand : IRequest
    {
        public Guid UserID { get; set; }
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
