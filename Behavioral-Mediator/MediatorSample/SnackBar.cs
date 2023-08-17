using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorSample
{
   /// <summary>
    /// The SnackBar abstract class represents an
    /// entity involved in the conversation which 
    /// should receive messages.
    /// </summary>
    public abstract class SnackBar
    {
        protected IMediator _mediator;

        public SnackBar(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
}