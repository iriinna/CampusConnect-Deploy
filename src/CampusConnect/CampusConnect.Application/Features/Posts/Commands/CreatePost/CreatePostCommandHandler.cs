using CampusConnect.Application.Features.Posts.Commands.AddPost;
using CampusConnect.Domain.Models;
using CampusConnect.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CampusConnect.Application.Features.Posts.Commands.CreatePost;
public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
{
    private readonly IPostRepository _postRepository;

    public CreatePostCommandHandler(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Content))
        {
            throw new Exception("Conținutul postării nu poate fi gol.");
        }

        var newPost = new Post
        {
            Content = request.Content,
            AuthorId = request.AuthorId,
            Date_created = DateTime.Now,
            Date_updated = DateTime.Now
        };
        
        return await _postRepository.AddPostAsync(newPost);
    }
}
