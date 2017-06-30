using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                NickName = "昵称",
                RealName = "真实姓名",
                Address = "地区",
                Phone = "手机号码",
                Zip = "邮编"
            };

            Product productA = new Product { Id = 1, Name = "小米5", Price = 1899 };
            Product productB = new Product { Id = 2, Name = "小米5手机防爆膜", Price = 29 };
            Product productC = new Product { Id = 3, Name = "小米5手机保护套", Price = 69 };


        }
    }
}
