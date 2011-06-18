using System;


namespace Entities
{

    public class MoneyCurrency : EntityBase
    {

        #region Fields

        protected Int32 id;
        protected string name;
        protected string symbol;

        #endregion Fields


        #region Properties

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string Symbol
        {
            get
            {
                return this.symbol;
            }

            set
            {
                if (this.symbol != value)
                {
                    this.symbol = value;
                    RaisePropertyChanged("Symbol");
                }
            }
        }

        public Int32 Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        #endregion Properties


        public MoneyCurrency(int id, string name, string symbol)
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
        }
    }
}
