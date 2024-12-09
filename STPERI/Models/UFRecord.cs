namespace STPERI.Models
{
    public class UFRecord
    {
        public int Id { get; set; }
        public Guid FormId { get; set; }
        public string RecordData { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CurrentPage { get; set; }
        public int UmbracoPageId { get; set; }
        public string IP { get; set; }
        public Guid? MemberKey { get; set; }
        public Guid UniqueId { get; set; }
        public string State { get; set; }
        public string Culture { get; set; }
    }
}
