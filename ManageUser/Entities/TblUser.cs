namespace MvcMovie.Entities
{
	public class TblUser
	{
        public int UserId { get; set; }

        public int GroupId { get; set; }

        public string LoginName { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string FullNameKana { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public DateTime Birthday { get; set; }

        public int Rules { get; set; }

        public string Salt { get; set; }

        public MstGroup mst_group { get; set; }

        public TblDetailUserJapan tbl_detail_user_japan { get; set; }
    }
}
