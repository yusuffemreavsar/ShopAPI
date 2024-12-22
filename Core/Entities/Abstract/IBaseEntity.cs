namespace Core.Entities.Abstract
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? DeletedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}
