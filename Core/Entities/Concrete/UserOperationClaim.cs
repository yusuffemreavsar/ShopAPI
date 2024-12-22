namespace Core.Entities.Concrete
{
    public class UserOperationClaim
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public User User { get; set; }
        public OperationClaim OperationClaim { get; set; }
    }
}
