using System;




namespace StatusController.Abstract
{
    public interface IStatusObserver
    {
        void OnStatusChanged(IStatus newState);
    }
}
