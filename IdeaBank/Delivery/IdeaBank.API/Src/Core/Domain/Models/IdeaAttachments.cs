namespace IdeaBank.Domain.Models
{
    public class IdeaAttachments : BaseEntity<Guid>
    {
        public Guid IdeaBankId { get; set; }
        public IdeaBank IdeaBank { get; set; }
        public string AttachmentPath { get; set; }
    }
}
