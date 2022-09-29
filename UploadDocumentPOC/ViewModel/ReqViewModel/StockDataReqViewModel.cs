namespace UploadDocumentPOCWebAPI.ViewModel.ReqViewModel
{
    public class StockDataReqViewModel
    {
        public string Symbol { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
