using System;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Notes.Application.Notes.Commands.DeleteCommand.Delete
{
    public class DeleteNoteCommand : IRequest
    {
        public Guid UserID { get; set; }
        public Guid ID { get; set; }

    }
}
