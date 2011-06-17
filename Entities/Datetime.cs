using System;
using System.ComponentModel;


namespace Entities
{

    public class Datetime : EntityBase
    {

        protected DateTime value;
        protected string format;


        [BrowsableAttribute(false)]
        [DisplayName("Time")]
        public DateTime Value
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
                    RaisePropertyChanged("Value");
                }
            }
        }


        [BrowsableAttribute(false)]
        public string Format
        {
            get
            {
                return this.format;
            }

            set
            {
                if (this.format != value)
                {
                    this.format = value;
                    RaisePropertyChanged("Format");
                }
            }
        }



        public DateTime Time
        {
            get
            {
                return this.Value;
            }

            set
            {
                this.Value = this.Value.Date.Add(value.TimeOfDay);
            }
        }


        public DateTime Date
        {
            get
            {
                return this.Value;
            }

            set
            {
                this.Value = value.Date.Add(this.Value.TimeOfDay);
            }
        }


        public Datetime(string format)
        {
            this.value = DateTime.UtcNow;
            this.format = format;
        }


        public override string ToString()
        {
            return this.Value.ToString(Format);
        }


        internal void CopyTo(Datetime datetime)
        {
            datetime.Value = this.Value;
            datetime.Format = this.Format;
        }
    }
}
