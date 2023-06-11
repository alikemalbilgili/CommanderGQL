using CommanderGQL.Data;
using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Platform> GetPlatform(AppDbContext context)
        {
            return context.Platforms;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Command> GetCommand(AppDbContext context)
        {
            return context.Commands;
        }
    }

}