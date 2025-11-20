using CampusConnect.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusConnect.Domain.Repositories;

    public interface IPostRepository
    {
        Task<int> AddPostAsync(Post post);
        Task<Post> GetByIdAsync(int postid);
        Task UpdatePostAsync(Post post);
        Task DeletePostAsync(int postid);
    }

