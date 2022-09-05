namespace Data.Model
{
    public class User : BaseModel
    {
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
    }
}
