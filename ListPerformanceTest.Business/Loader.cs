using System;

namespace ListPerformanceTest.Business
{
    public class Loader
    {
        public DataItem[] LoadData()
        {
            var itemCounts = 10000;
            var res = new DataItem[itemCounts];
            var rnd = new Random();
            for (int i = 0; i < itemCounts; i++)
            {
                res[i] = new DataItem()
                {
                    Name = "Item " + i,
                    ImageId = rnd.Next(1, 46)
                };
            }
            return res;
        }
    }
}