namespace IdeaBank.Infrastructure.ModelsConfigurations
{
	public class IdeaBankConfig : IEntityTypeConfiguration<Domain.Models.IdeaBank>
	{
		public void Configure(EntityTypeBuilder<Domain.Models.IdeaBank> builder)
		{

			builder.HasMany(a => a.IdeaAttachments)
					.WithOne(a => a.IdeaBank)
					.HasForeignKey(a => a.IdeaBankId);

            builder.HasMany(a => a.IdeaLikes)
                    .WithOne(a => a.IdeaBank)
                    .HasForeignKey(a => a.IdeaBankId);

            builder.HasMany(a => a.IdeaComments)
                    .WithOne(a => a.IdeaBank)
                    .HasForeignKey(a => a.IdeaBankId)
					.OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(a => a.IdeaRates)
                    .WithOne(a => a.IdeaBank)
                    .HasForeignKey(a => a.IdeaBankId);

            /*builder.HasOne(ic => ic.IdeaBank)
                .WithMany(ib => ib.IdeaComments)
                .HasForeignKey(ic => ic.IdeaBankId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            // Configure the foreign key relationship with ParentComment
            builder.HasOne(ic => ic.ParentComment)
                .WithMany(p => p.Replies)
                .HasForeignKey(ic => ic.ParentCommentId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configure the inverse navigation property for Replies
            builder.HasMany(ic => ic.Replies)
                .WithOne()
                .HasForeignKey(ic => ic.ParentCommentId)
                .OnDelete(DeleteBehavior.NoAction);*/
        }
    }
}
