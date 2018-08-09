using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Class1
    {
		public List<Blog> GetAll()
		{
			List<Blog> blogList = new List<Blog>();
			Blog obj = new Blog();
			obj.Id = 1;
			obj.Description = "lol";
			blogList.Add(obj);
			return blogList.ToList();
		}
    }
}
