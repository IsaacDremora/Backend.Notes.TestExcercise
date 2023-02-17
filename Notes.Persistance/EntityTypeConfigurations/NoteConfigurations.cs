using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Domain;


namespace Notes.Persistance.EntityTypeConfigurations
{
    public class NoteConfigurations : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(note => note.ID);
            builder.HasIndex(note => note.UserID).IsUnique();
            builder.Property(note => note.Details).HasMaxLength(250);

        }
    }
}
