namespace EyeCareUI.GlobalModels
{
    public class PairStringModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class PairModel
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
    public class PairLongModel
    {
        public long Key { get; set; }
        public string Value { get; set; }
    }
    public class PairGuidModel
    {
        public Guid Key { get; set; }
        public string Value { get; set; }
    }

    public class PairResultModel
    {
        public Result Key { get; set; }
        public string Value { get; set; }
    }
}
