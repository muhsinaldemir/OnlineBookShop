using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public enum magazine_type
    {
        Actual,
        News,
        Sports,
        Computer,
        Technology
    };

    class MagazineClass : ProductClass
    {
        public string issue { get; set; }
        public magazine_type magazineType { get; set; }

        public override void printProperties()
        {
            throw new NotImplementedException();
        }

        public MagazineClass(string Name,string Id,double Price,string Issue,magazine_type MagazineType):base(Name,Id,Price)
        {
            issue = Issue;
            magazineType = MagazineType;
        }
    }
}
