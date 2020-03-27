using System.Runtime.Serialization;


namespace WCF_si_EF_PostAndComment
{
    [DataContract(IsReference = true)]
    public partial class Comment
    {
        [DataMember]
        public int CommentId { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public int PostPostId { get; set; }
        [DataMember]
        public virtual Post Post { get; set; }
    }
}