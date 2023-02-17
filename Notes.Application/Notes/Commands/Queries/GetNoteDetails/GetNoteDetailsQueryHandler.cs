using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutoMapper;
using MediatR;
using Notes.Application.interfaces;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Common.Exceptions;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryHandler
        : IRequestHandler<GetNoteDetailsQuery, NoteDetailsVm>
    {
        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetNoteDetailsQueryHandler(INotesDbContext dbContext, IMapper mapper)
            => (_dbContext, _mapper) = (dbContext, mapper);
      
    
        public async Task<NoteDetailsVm> Handle(GetNoteDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes
                .FirstOrDefaultAsync(note => note.ID == request.ID, cancellationToken);

            if (entity == null || entity.UserID != request.UserID)
            {
                throw new NotFoundException(nameof(Note), request.ID);
            }
            return _mapper.Map<NoteDetailsVm>(entity); 
        }
    }
}
