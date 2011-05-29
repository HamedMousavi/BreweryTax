using System;


namespace Entities
{

    public class MoneyCurrency
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }


        public MoneyCurrency(int id, string name, string symbol)
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
        }
    }
}
