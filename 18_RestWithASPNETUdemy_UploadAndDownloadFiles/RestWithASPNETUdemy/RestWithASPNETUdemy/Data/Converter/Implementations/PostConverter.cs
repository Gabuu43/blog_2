﻿using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class PostConverter : IParser<PostVO, Post>, IParser<Post, PostVO>
    {
        public Post Parse(PostVO origin)
        {
            if (origin == null) return null;
            return new Post
            {
                Id = origin.Id,
                Description = origin.Description,
                Title = origin.Title,
                Image = origin.Image
            };
        }

        public PostVO Parse(Post origin)
        {
            if (origin == null) return null;
            return new PostVO
            {
                Id = origin.Id,
                Description = origin.Description,
                Title = origin.Title,
                Image = origin.Image
            };
        }

        public List<Post> Parse(List<PostVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PostVO> Parse(List<Post> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}