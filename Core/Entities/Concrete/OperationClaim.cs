namespace Core.Entities.Concrete
{
    public class OperationClaim:BaseEntity
    {
        public string Name { get; set; }

        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
