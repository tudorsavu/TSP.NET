using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class PostDTO
    {
        public PostDTO()    {this.Comments = new HashSet<CommentDTO>();}
        public int PostId   { get; set; }
        public string Description   { get; set; }
        public string Domain    { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime Date     { get; set; }
        public virtual ICollection<CommentDTO> Comments    { get; set; }
    }
}
