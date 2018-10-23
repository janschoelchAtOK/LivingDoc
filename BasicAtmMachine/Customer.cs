using System;

namespace BasicAtmMachine
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
            CardNo = Guid.NewGuid().ToString();
        }

        #region Properties

        public Guid Id { get; set; }

        public string CardNo { get; set; }
        
        #endregion
    }
}
