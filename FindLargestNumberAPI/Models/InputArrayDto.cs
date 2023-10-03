namespace FindLargestNumberAPI.Models
{
    public class InputArrayDto
    {
        public List<int> Items { get; set; }
        public InputArrayDto() {
            Items = new List<int>();
        }
    }
}
