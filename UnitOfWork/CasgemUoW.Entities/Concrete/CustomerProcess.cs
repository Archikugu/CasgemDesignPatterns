namespace CasgemUoW.Entities.Concrete
{
    public class CustomerProcess
    {
        public int CustomerProcessID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public decimal Amount { get; set; }
    }
}
