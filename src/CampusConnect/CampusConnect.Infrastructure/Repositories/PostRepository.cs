using CampusConnect.Domain.Models;
using CampusConnect.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusConnect.Domain.Repositories;

namespace CampusConnect.Infrastructure.Repositories;


public class PostRepository: IPostRepository
{
    private readonly ApplicationDbContext _context;

    public PostRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> AddPostAsync(Post post)
    {
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
        return post.Id; // Returnează ID-ul generat de baza de date
    }

    public async Task<Post> GetByIdAsync(int postid)
    {
        return await _context.Posts.FindAsync(postid);
    }

    public async Task UpdatePostAsync(Post post)
    {
        _context.Posts.Update(post);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePostAsync(int postid)
    {
        var post = await _context.Posts.FindAsync(postid);
        if (post != null)
        {
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }
    }
}
