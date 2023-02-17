using MediatR;
using Notes.Application.interfaces;
using Notes.Application.Common.Exceptions;
using Notes.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Commands.DeleteCommand.Delete
{
    public class DeleteNoteCommandHandler 
        : IRequestHandler<DeleteNoteCommand>
    {
        private readonly INotesDbContext _dbContext;
        public DeleteNoteCommandHandler(INotesDbContext dbContext) =>
             _dbContext = dbContext;
        

        public async Task<Unit> Handle(DeleteNoteCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes
                .FindAsync(new object[] { request.ID }, cancellationToken);

            if (entity == null || entity.UserID != request.UserID)
            {
                throw new NotFoundException(nameof(Note), request.ID);
            }

            _dbContext.Notes.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

        Task IRequestHandler<DeleteNoteCommand>.Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
