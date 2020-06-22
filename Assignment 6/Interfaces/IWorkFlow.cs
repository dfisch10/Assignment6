using System.Collections;
using System.Collections.Generic;
using Assignment_6.activities;

namespace Assignment_6.interfaces
{
    public interface IWorkFlow
    {
        void RegisterActivity(IActivity activity)
        {
        }

        IEnumerable<IActivity> ActivitiesList();
    }
}