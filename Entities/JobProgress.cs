using System;


namespace Entities
{

    public class JobProgress : EntityBase
    {

        public enum JobStatus
        {
            Idle,
            InProgress,
            Done
        };


        private decimal minValue;
        private decimal maxValue;
        private decimal value;
        private Int32 jobId;
        private string jobName;
        private JobStatus status;
        private string message;


        public decimal MinValue
        {
            get
            {
                return this.minValue;
            }

            set
            {
                if (this.minValue != value)
                {
                    this.minValue = value;
                    RaisePropertyChanged("MinValue");
                }
            }
        }

        public decimal MaxValue
        {
            get
            {
                return this.maxValue;
            }

            set
            {
                if (this.maxValue != value)
                {
                    this.maxValue = value;
                    RaisePropertyChanged("MaxValue");
                }
            }
        }

        public decimal Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (this.value != value)
                {
                    this.value = value;

                    try
                    {
                        RaisePropertyChanged("Value");
                    }
                    catch { }

                    if (this.value >= this.MaxValue)
                    {
                        this.value = this.minValue;
                        this.Status = JobProgress.JobStatus.Done;
                    }
                    else if (this.value >= this.MinValue)
                    {
                        this.Status = JobProgress.JobStatus.InProgress;
                    }
                }
            }
        }

        public JobStatus Status
        {
            get
            {
                return this.status;
            }

            set
            {
                if (this.status != value)
                {
                    this.status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }

        public Int32 JobId
        {
            get
            {
                return this.jobId;
            }

            set
            {
                if (this.jobId != value)
                {
                    this.jobId = value;
                    RaisePropertyChanged("JobId");
                }
            }
        }

        public string JobName
        {
            get
            {
                return this.jobName;
            }

            set
            {
                if (this.jobName != value)
                {
                    this.jobName = value;
                    RaisePropertyChanged("JobName");
                }
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                if (this.message != value)
                {
                    this.message = value;
                    RaisePropertyChanged("Message");
                }
            }
        }


        public Int32 Percent
        {
            get
            {
                return Convert.ToInt32((Value * 100.0M) / (MaxValue - MinValue));
            }
        }

        
        public JobProgress()
        {
            this.Status = JobStatus.Idle;
            this.MinValue = 0;
            this.MaxValue = 100;
            this.Value = 0;
        }


        public JobProgress(int id, string name, decimal maxValue)
            : this()
        {
            this.Status = JobStatus.Idle;
            this.jobName = name;
            this.jobId = id;

            this.MinValue = 0;
            this.MaxValue = maxValue;
            this.Value = 0;
        }


        public JobProgress(int id, string name, decimal minValue, decimal maxValue)
            : this(id, name, maxValue)
        {
            this.MinValue = minValue;
            this.Value = minValue;
        }
    }
}
