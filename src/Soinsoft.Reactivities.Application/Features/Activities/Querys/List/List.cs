using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore; //is not what the pattern expect. Avoid Orms references in this thier
using Soinsoft.Reactivities.Domain; //is not correct, just DTOs
using Soinsoft.Reactivities.Persistence; //should be called by Application thier

namespace Soinsoft.Reactivities.Application.Features.Activities.Querys.List
{
    public class ListQuery: IRequest<List<Activity>>{}

    public class ListQueryHandler : IRequestHandler<ListQuery, List<Activity>>
    {
        private readonly DataContext _context;
      
        public ListQueryHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Activity>> Handle(ListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Activities.ToListAsync();
        }
    }

    public class ListQueryValidator{

    }


}