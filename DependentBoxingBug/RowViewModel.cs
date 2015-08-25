using System;

namespace DependentBoxingBug
{
    public class RowViewModel
    {
        public RowViewModel()
        {
            Property1 = Guid.NewGuid().ToString();
            Property2 = Guid.NewGuid().ToString();
            Property3 = Guid.NewGuid().ToString();
            Property4 = Guid.NewGuid().ToString();
            Property5 = Guid.NewGuid().ToString();
            Property6 = Guid.NewGuid().ToString();
            Property7 = Guid.NewGuid().ToString();
            Property8 = Guid.NewGuid().ToString();
            Property9 = Guid.NewGuid().ToString();
            Property10 = Guid.NewGuid().ToString();
        }

        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public string Property4 { get; set; }
        public string Property5 { get; set; }
        public string Property6 { get; set; }
        public string Property7 { get; set; }
        public string Property8 { get; set; }
        public string Property9 { get; set; }
        public string Property10 { get; set; }
    }
}