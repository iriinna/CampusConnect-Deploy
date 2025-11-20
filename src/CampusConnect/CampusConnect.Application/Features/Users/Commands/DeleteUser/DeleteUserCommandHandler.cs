using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusConnect.Domain.Services; 

namespace CampusConnect.Application.Features.Users.Commands.DeleteUser;
public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IUserRepository _userRepository;
    private readonly ICurrentUserService _currentUserService;

    public DeleteUserCommandHandler(IUserRepository userRepository, ICurrentUserService currentUserService)
    {
        _userRepository = userRepository;
        _currentUserService = currentUserService;
    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        if (_currentUserService.GetCurrentUserId() != request.Id)
        {
             throw new UnauthorizedAccessException("Contul poate fi sters decat de persoana care il detine.");
        }

        await _userRepository.DeleteUserAsync(request.Id);
        return Unit.Value;
    }
}