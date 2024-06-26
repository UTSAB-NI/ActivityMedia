﻿using Domain;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using AutoMapper;


namespace Application.Activities
{
    public class Edit
    {
        public class Command : IRequest<Unit>
        {
            public Activity Activity { get; set; }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context,IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity =await _context.Activities.FindAsync(request.Activity.Id);

                _mapper.Map(request.Activity, activity);
                
                await _context.SaveChangesAsync();  
                
                return Unit.Value;

            }
        }
    }
}
