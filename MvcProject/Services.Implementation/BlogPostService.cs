using Services.Blogpost;
using Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostService blogPostRepository;

        public BlogPostService(IBlogPostService blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BlogPostGetAll>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await IBlogPostRepository.GetAll()
                .Select(blogPost => new BlogPostGetAll
                {
                    Id = blogPost.Id,
                    Title = blogPost.Title,
                    CategoryId = blogPost.CategoryId,
                    Body = blogPost.Body,
                    ImagePath = blogPost.ImagePath,
                    PublishDate = blogPost.PublishDate,
                    PublisherId = blogPost.PublisherId
                })
                .ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
