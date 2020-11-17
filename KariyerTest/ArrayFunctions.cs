using System.Collections.Generic;
using System.Linq;

namespace KariyerTest
{
    public class ArrayFunctions
    {
        public List<DublicateModel> GetDublicateCount(int[] arrayList)
        {
            //FindUniq
            var searchList = arrayList.ToList().Distinct();

            //SearchUniq
            int count = 0;
            List<DublicateModel> countList = new List<DublicateModel>();
            foreach (var item in searchList)
            {
                count = arrayList.ToList().Where(w => w.Equals(item)).Count();
                countList.Add(new DublicateModel()
                {
                    Item = item,
                    Count = count
                });
            }

            return countList.OrderBy(o=>o.Item).ToList();
        }
    }



}
