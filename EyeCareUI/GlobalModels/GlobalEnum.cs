namespace EyeCareUI.GlobalModels
{
    public enum SubmitButtonText
    {
        Submit,
        Print,
        Download,
        Upload,
        Export,
        Create,
        View,
        Update,
        Delete,
        Search,
        Cancel,
        Import
    }
    public enum CancelButtonText
    {
        Cancel,
        Remove,
        Reset
    }
    public enum SubmitButtonID
    {
        btnSubmit,
        btnPrint,
        btnDownload,
        btnUpload,
        btnExport,
        btnView
    }
    public enum CancelButtonID
    {
        btnCancel,
        btnRemove,
        btnReset
    }
    public enum SubmitState
    {
        Submit,
        Button,
        Reset
    }
    public enum CRUDState
    {
        CREATE = 0,
        READ = 1,
        UPDATE = 2,
        DELETE = 3,
        PRINT = 4,
        EXPORT = 5,
        IMPORT = 6,
        DELETED = 7,
        CONFIRM = 8
    }
    public enum ApplicationRole
    {
        Select = 0,
        SuperAdmin = 1,
        Normal = 2
    }
    public enum PairModelTitle
    {
        Navigation,
        Gender,
        Religion,
        WeekDay,
        OfficeWorkingDay,
        DocumentType,
        Role,
        User,
        UserID,
        EmailTemplate
    }
    
    public enum SortDirection
    {
        Asc,
        Desc
    }
    public enum SortOrder
    {
        Id,
        CreatedOn,
        IdWorkingDay,
        IdOfficeWorkingDay,
        LoginAt
    }
    
    public enum NotificationStatus
    {
        Requested = 1,
        Send = 2,
        Unsent = 3
    }
    public enum NotifyType
    {
        EMAIL,
        SMS,
        BOTH
    }
    public enum LayoutMode
    {
        dark = 1,
        light = 2
    }
    public enum GenderType
    {
        Male = 1,
        Female = 2
    }
    public enum Result
    {
        Success = 1,
        Failure = 2
    }
}
