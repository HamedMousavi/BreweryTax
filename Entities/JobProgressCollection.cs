using System.ComponentModel;


namespace Entities
{

    public class JobProgressCollection : BindingList<JobProgress>
    {

        public JobProgress GetById(int jobId)
        {
            foreach(JobProgress job in this)
            {
                if (job.JobId == jobId)
                {
                    return job;
                }
            }

            return null;
        }


        public JobProgress GetByName(string jobName)
        {
            foreach (JobProgress job in this)
            {
                if (string.Equals(job.JobName, jobName, System.StringComparison.InvariantCulture))
                {
                    return job;
                }
            }

            return null;
        }
    }
}
