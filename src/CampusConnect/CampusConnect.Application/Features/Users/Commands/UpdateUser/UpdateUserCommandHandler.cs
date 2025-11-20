using CampusConnect.Domain.Repositories;
using CampusConnect.Domain.Services;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using CampusConnect.Domain.Services;

namespace CampusConnect.Application.Features.Users.Commands.UpdateUser;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
{
    private readonly IUserRepository _userRepository;
    private readonly ICurrentUserService _currentUserService;

    public UpdateUserCommandHandler(IUserRepository userRepository, ICurrentUserService currentUserService)
    {
        _userRepository = userRepository;
        _currentUserService = currentUserService;

    }

    public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByIdAsync(request.UserId);
        if (user == null) throw new KeyNotFoundException();
        var userToUpdateId = request.UserId;
        var currentUserId = _currentUserService.GetCurrentUserId();

        if (currentUserId.HasValue && currentUserId.Value != userToUpdateId)
        {
            throw new UnauthorizedAccessException("Nu puteti edita profilul altui utilizator.");
        }

        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.Email = request.Email;
        user.About = request.About;
        user.ProfilePictureUrl = request.ProfilePictureUrl;

        await _userRepository.UpdateUserAsync(user);
        return Unit.Value;
    }
}