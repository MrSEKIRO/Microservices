namespace Podcasts.Models
{
	public class Podacast
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public string? Description { get; set; }
    }
}
