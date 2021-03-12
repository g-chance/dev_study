using System.Collections;
using System.Collections.Generic;

namespace cs_sandbox
{
    class WorkflowEngine
    {
        private readonly List<IActivity> _activities;

        public WorkflowEngine()
        {
            _activities = new List<IActivity>();
        }
        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
        public void QueueActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
