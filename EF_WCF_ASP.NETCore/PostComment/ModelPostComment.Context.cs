namespace PostComment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    internal partial class ModelPostCommentContainer : DbContext
    {
        public ModelPostCommentContainer()
        : base("name=ModelPostCommentContainer")
        {
            // Inhibare: lazy loading si creare proxy dinamic.
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}