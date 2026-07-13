namespace EyeCareUI.GlobalModels
{
    public class ModalFooterModel : SystemStructureModel
    {
        public ModalFooterModel(IHttpContextAccessor httpContextAccessor):base(httpContextAccessor)
        {
            
        }
        public string SubmitButtonText { get; set; }
        public SubmitState SubmitType { get; set; }
        public string CancelButtonText { get; set; } = "Cancel";
        public SubmitButtonID SubmitButtonID { get; set; }
        public CancelButtonID CancelButtonID { get; set; }
        public bool OnlyCancelButton { get; set; }
        public bool EnableCancelButton { get; set; } = true;
    }
}
