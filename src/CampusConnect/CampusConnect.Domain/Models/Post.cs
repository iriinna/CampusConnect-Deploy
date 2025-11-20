using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusConnect.Domain.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date_created { get; set; }
    public DateTime Date_updated { get; set; }
    public int AuthorId { get; set; }
    public User? Author { get; set; }
}
