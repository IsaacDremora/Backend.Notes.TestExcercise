using Notes.Domain;
using Microsoft.EntityFrameworkCore;
using Notes.Application.interfaces;
using Notes.Persistance.EntityTypeConfigurations;


namespace Notes.Persistance
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }
        protected void OneModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfigurations());
            base.OnModelCreating(builder);
        }
    }
}
