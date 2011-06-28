using System;
using Entities;


namespace DomainModel
{

    public class JobProgressController
    {

        public JobProgressCollection Jobs { get; private set; }


        public JobProgressController()
        {
            this.Jobs = new JobProgressCollection();
        }


        public JobProgress CreateJob(decimal minValue, decimal maxValue, string name)
        {
            JobProgress job;
            try
            {
                lock (this)
                {
                    job = new JobProgress(Jobs.Count, name, minValue, maxValue);
                    this.Jobs.Add(job);
                }
            }
            catch (Exception ex)
            {
                job = null;
            }

            return job;
        }


        public void IncrementValue(int jobId)
        {
            try
            {
                JobProgress jp = this.Jobs.GetById(jobId);
                if (jp != null)
                {
                    SetValue(jp, jp.Value + 1);
                }
            }
            catch (Exception ex)
            {
            }
        }


        public void IncrementValue(string jobName)
        {
            try
            {
                JobProgress jp = this.Jobs.GetByName(jobName);
                if (jp != null)
                {
                    SetValue(jp, jp.Value + 1.0M);
                }
            }
            catch (Exception ex)
            {
            }
        }


        public void SetValue(int jobId, decimal value)
        {
            try
            {
                JobProgress jp = this.Jobs.GetById(jobId);
                if (jp != null)
                {
                    SetValue(jp, value);
                }
            }
            catch (Exception ex)
            {
            }
        }


        public void SetValue(string jobName, decimal value)
        {
            try
            {
                JobProgress jp = this.Jobs.GetByName(jobName);
                if (jp != null)
                {
                    SetValue(jp, value);
                }
            }
            catch (Exception ex)
            {
            }
        }


        private void SetValue(JobProgress jp, decimal value)
        {
            jp.Value = value;
        }


        public void RemoveJob(int jobId)
        {
            try
            {
                JobProgress jp = this.Jobs.GetById(jobId);
                if (jp != null)
                {
                    this.Jobs.Remove(jp);
                }
            }
            catch (Exception ex)
            {
            }
        }


        public void RemoveJob(string jobName)
        {
            try
            {
                JobProgress jp = this.Jobs.GetByName(jobName);
                if (jp != null)
                {
                    this.Jobs.Remove(jp);
                }
            }
            catch (Exception ex)
            {
            }
        }


        internal bool UpdateJob(decimal minValue, decimal maxValue, string name)
        {
            bool res = false;

            try
            {
                JobProgress jp = this.Jobs.GetByName(name);
                if (jp != null)
                {
                    jp.MinValue = minValue;
                    jp.MaxValue = maxValue;

                    res = true;
                }
            }
            catch (Exception ex)
            {
                res = false;
            }

            return res;
        }
    }
}
