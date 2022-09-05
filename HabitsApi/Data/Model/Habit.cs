namespace Data.Model
{
    public class Habit : BaseModel
    {
        public string calendar { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string UserEmail { get; set; }
    }
}
