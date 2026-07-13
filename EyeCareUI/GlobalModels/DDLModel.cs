namespace EyeCareUI.GlobalModels
{
    public class DDLModel
    {
        public ICollection<PairModel> DDLNavigation { get; set; }
        public ICollection<PairGuidModel> DDLUser { get; set; }
        public ICollection<PairLongModel> DDLUserID { get; set; }
        public ICollection<PairModel> DDLGender { get; set; }
    }
}
