using System.Collections.Generic;

namespace PresseMots.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StoryTag> StoryTags { get; set; } = new List<StoryTag>();

    }
}
