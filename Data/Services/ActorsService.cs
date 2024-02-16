using eCinema.Data.Base;
using eCinema.Models;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
