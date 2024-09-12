using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Blogpost
{
  public  interface IBlogPostService
    {
        IEnumerable<object> GetAll();
        Task<IEnumerable<BlogPostGetAll>> GetAllAsync(CancellationToken cancellationToken = default); 

    }
}
