namespace MvcMovie.Entities
{
	public class MstGroup
	{
        public int GroupId { get; set; }

        public string GroupName { get; set; }

        public TblUser TblUser { get; set; }
    }
}
