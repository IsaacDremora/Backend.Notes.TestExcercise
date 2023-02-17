using System.Collections.Generic;


namespace Notes.Application.Notes.Commands.Queries.GetNoteList
{
    public class NoteListVm
    {
        public IList<NoteLookupDto> Notes { get; set; }
    }
}
