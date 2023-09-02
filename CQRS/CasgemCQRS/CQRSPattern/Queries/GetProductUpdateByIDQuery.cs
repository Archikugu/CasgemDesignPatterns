namespace CasgemCQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIDQuery
    {
        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
    }
}
