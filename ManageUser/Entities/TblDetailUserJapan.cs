namespace MvcMovie.Entities
{
	public class TblDetailUserJapan
	{
        public int TblUserJapanId { get; set; }

        public int UserId { get; set; }

        public string CodeLevel { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Total { get; set; }

        public MstJapan mst_japan { get; set; }

        public TblUser tbl_user { get; set; }
    }
}
