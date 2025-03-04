namespace Helpers.Interface
{
    public interface ISingleInstance
    {
        bool IsSingleInstance();
        void ReleaseInstance();
        void ShowExistingInstance();
        void ShowExistingForm();
    }
}
