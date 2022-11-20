namespace MvcMovie.Entities
{
	public class MstJapan
	{
        public string CodeLevel { get; set; }


        public string NameLevel { get; set; }

        public virtual TblDetailUserJapan TblDetailUserJapan { get; set; }
    }
}
