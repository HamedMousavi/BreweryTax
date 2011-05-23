using System;
using System.ComponentModel;


namespace Entities
{

    public class Datetime
    {
        [BrowsableAttribute(false)]
        [DisplayName("Time")]
        public DateTime Value { get; set; }

        [BrowsableAttribute(false)]
        public string Format { get; set; }


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


        public Datetime(string format)
        {
            this.Value = DateTime.UtcNow;
            this.Format = format;
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


        public override string ToString()
        {
            //return base.ToString();
            return this.Value.ToString(Format);
        }


        internal void CopyTo(Datetime datetime)
        {
            datetime.Value = this.Value;
            datetime.Format = this.Format;
        }
    }
}
