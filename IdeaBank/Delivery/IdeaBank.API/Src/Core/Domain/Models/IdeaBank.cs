namespace IdeaBank.Domain.Models
{
    public class IdeaBank : BaseEntity<Guid>
    {
       // public IdeaCategory IdeaCategory { get; set; }
        public int IdeaCategory { get; set; }
        public string Title { get; set; }
        public string Description { set; get; }
       // public RequestStage RequestStage { set; get; }
        public int RequestStage { set; get; }
        public string? Notes { set; get; }

        public  int? LK_InputTypeId { set; get; }
        public LK_InputType LK_InputType {  set; get; } 
        public bool IsPublished {  set; get; } 
        public virtual ICollection<IdeaAttachments> IdeaAttachments { get; set; }
        public virtual ICollection<IdeaLike> IdeaLikes { get; set; }
        public virtual ICollection<IdeaComment> IdeaComments { get; set; }
        public virtual ICollection<IdeaRate> IdeaRates { get; set; }
        public virtual ICollection<IdeaView> IdeaViews { get; set; }
    }
}
