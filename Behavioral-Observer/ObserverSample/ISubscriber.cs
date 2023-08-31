using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverSample
{
    // The Observer Interface
    public interface ISubscriber
    {
        // Receive Notification from Subject
        void Update();
    }
}