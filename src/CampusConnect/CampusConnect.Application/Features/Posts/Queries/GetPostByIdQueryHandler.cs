using CampusConnect.Domain.Models;
using CampusConnect.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusConnect.Application.Features.Posts.Queries;
public class GetPostByIdQueryHandler : IRequestHandler<GetPostByIdQuery, Post>
{
    private readonly IPostRepository _postRepository;

    public GetPostByIdQueryHandler(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }
    public async Task<Post> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
    {
        // preluare date postare din repository
        var post = await _postRepository.GetByIdAsync(request.Id);

        if (post == null)
        {
            // expectie daca postarea nu este gasita
            throw new KeyNotFoundException($"Postarea cu ID-ul {request.Id} nu a fost gasita.");
        }

        return post;
    }
}