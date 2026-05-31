using System;

namespace PGISLauncher.Interfaces
{
    public interface ISingleInstance
    {
        void Init(string appId, Action showFormCallback = null);
        bool IsSingleInstance();
        void ReleaseInstance();
        void ShowExistingInstance();
        void ShowExistingForm();
    }
}
