using AutoMapper;
using TeDuBlog.Core.Domain.Content;

namespace TeDuBlog.Core.Models.Content
{
    public class PostInListDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; }
        public string? Description { get; set; }
        public string? Thumbnail { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }

        public class PostInListDtoMappingProfile  : Profile
        {
            public PostInListDtoMappingProfile ()
            {
                CreateMap<Post, PostInListDto>();
            }
        }
    }
}