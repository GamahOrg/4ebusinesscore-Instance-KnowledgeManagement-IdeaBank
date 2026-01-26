namespace IdeaBank.Infrastructure.Context
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<Domain.Models.IdeaBank> IdeaBanks { get; set; }
        public DbSet<IdeaAttachments> IdeaAttachments { get; set; }
        public DbSet<IdeaLike> IdeaLikes { get; set; }
        public DbSet<IdeaComment> IdeaComments { get; set; }
        public DbSet<IdeaRate> IdeaRates { get; set; }
        public DbSet<IdeaView> IdeaViews { get; set; }
        public DbSet<CommentLike> CommentLikes { get; set; }
        public DbSet<LK_InputType> LK_InputTypes { get; set; }
        public DbSet<LK_IdeaCategory> LK_IdeaCategories { get; set; }
        public DbSet<Lk_RequestStage> Lk_RequestStages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Models.IdeaBank>().Property(n => n.LK_InputTypeId).IsRequired(false);
            //modelBuilder.Entity<Domain.Models.LK_IdeaCategory>()
            //.Property(x => x.Id)
            //.UseIdentityColumn(seed: 0, increment: 1);

            modelBuilder.Entity<LK_IdeaCategory>()
                    .Property(u => u.Id)
                    .ValueGeneratedNever();
            base.OnModelCreating(modelBuilder);

        }
        public bool AllMigrationsApplied()
        {
            var applied = this.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = this.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
        public void Migrate()
        {
            this.Database.Migrate();
        }
    }
}