namespace ABLAB.Sogo.PoC.Shared.Dtos
{
    public class SearchParameters
    {
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? MinRooms { get; set; }
        public int? MaxRooms { get; set; }
        public decimal? MinArea { get; set; }
        public decimal? MaxArea { get; set; }
        public bool? Garden { get; set; }
        public bool? Storage { get; set; }
        public IList<InvestmentDto> Investments { get; set; } = default!;
    }
}
