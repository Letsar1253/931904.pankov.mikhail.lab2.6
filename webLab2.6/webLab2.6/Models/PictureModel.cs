


namespace webLab2._6.Models
{
    public class PictureModel
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public byte[] Image { get; set; }

        public int? TopicModelId { get; set; }
        public TopicModel Topic { get; set; }

        public int? ReplyModelId { get; set; }
        public ReplyModel Reply { get; set; }
    }
}
