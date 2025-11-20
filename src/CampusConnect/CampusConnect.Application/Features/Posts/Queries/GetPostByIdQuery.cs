using CampusConnect.Domain.Models;
using CampusConnect.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusConnect.Application.Features.Posts.Queries;
public class GetPostByIdQuery : IRequest<Post>
{
    public int Id { get; set; }
}