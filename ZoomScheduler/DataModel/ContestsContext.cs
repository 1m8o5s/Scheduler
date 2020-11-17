namespace ZoomScheduler.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContestsContext : DbContext
    {
        public ContestsContext()
            : base("name=ContestsContext")
        {
        }
    }
}