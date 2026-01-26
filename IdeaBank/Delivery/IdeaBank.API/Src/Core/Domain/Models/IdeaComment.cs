namespace IdeaBank.Domain.Models
{
    public class IdeaComment : BaseEntity<Guid>
    {
        public string CommentText { get; set; }

        [ForeignKey("IdeaBank")]
        public Guid IdeaBankId { get; set; }
        public IdeaBank IdeaBank { get; set; }

        [InverseProperty("Replies")]
        public Guid? ParentCommentId { set; get; }
        public virtual IdeaComment ParentComment { set; get; }
        public virtual ICollection<IdeaComment> Replies { get; set; }
        public virtual ICollection<CommentLike> CommentLikes { get; set; }
    }
}
