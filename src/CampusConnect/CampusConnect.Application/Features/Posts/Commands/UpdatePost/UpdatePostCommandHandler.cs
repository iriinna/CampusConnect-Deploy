using CampusConnect.Domain.Repositories;
using CampusConnect.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusConnect.Application.Features.Posts.Commands.UpdatePost;
public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, Unit>
{
    private readonly IPostRepository _postRepository;
    private readonly ICurrentUserService _currentUserService;

    public UpdatePostCommandHandler(IPostRepository postRepository, ICurrentUserService currentUserService)
    {
        _postRepository = postRepository;
        _currentUserService = currentUserService;
    }

    public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        var currentUserId = _currentUserService.GetCurrentUserId();

        if (currentUserId == null)
        {
            throw new UnauthorizedAccessException("Autentificarea este necesara pentru a edita o postare.");
        }

        var post = await _postRepository.GetByIdAsync(request.Id);

        if (post == null)
        {
            throw new KeyNotFoundException($"Postarea cu ID-ul {request.Id} nu a fost gasita.");
        }

        bool isOwner = post.AuthorId == currentUserId.Value;
        bool isAdmin = _currentUserService.IsInRole("Admin");

        if (!isOwner && !isAdmin)
        {
            throw new UnauthorizedAccessException("Doar autorul sau un admin poate edita o postare.");
        }

        post.Title = request.Title;
        post.Content = request.Content;
        post.Date_updated = DateTime.Now;

        await _postRepository.UpdatePostAsync(post);

        return Unit.Value;
    }
}