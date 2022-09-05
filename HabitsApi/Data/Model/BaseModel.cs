using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    public abstract class BaseModel
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
