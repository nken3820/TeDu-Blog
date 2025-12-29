using AutoMapper;
using TeDuBlog.Core.Domain.Content;

namespace TeDuBlog.Core.Models.Content
{
    public class CreateUpdatePostRequest
    {
        public required string Name { get; set; }
        public required string Slug { get; set; }
        public string? Description { get; set; }
        public string? Thumbnail { get; set; }
        public Guid CategoryId { get; set; }
        public string? Content { get; set; }
        public string? Source { get; set; }
        public string? Tags { get; set; }
        public string? SeoDescription { get; set; }
         public class CreateUpdatePostRequestMappingProfile  : Profile
        {
            public CreateUpdatePostRequestMappingProfile ()
            {
                CreateMap<CreateUpdatePostRequest, Post>();
            }
        }
    }
}