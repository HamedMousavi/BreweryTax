using System;



namespace StatusController.Abstract
{
    public interface IStatusController
    {
        void UpdateStatus(IStatus status);
        void RegisterForEvents(IStatusObserver observer);
        void UnregisterFromEvents(IStatusObserver observer);
    }
}
