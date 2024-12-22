using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }


        public BaseEntity()
        {
            Id = Guid.NewGuid();

        }
    }
}
