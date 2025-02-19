﻿using DesignPatterns.Behavioral.ChainOfResponsibility.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// design pattern is a behavioral design pattern used to process requests through a chain of handlers.
// Each handler decides whether to process the request or pass it along to the next handler in the chain.
namespace DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample
{
    internal abstract class Handler
    {
        private Handler _nextHandler; // the next handler to call in the chain (after this one)


        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;

            // returning handler allows us to link handlers in a convenient way, e.g. handler1.SetNext(handler2).SetNext(handler3)
            return handler;
        }

        // Handle template method.
        public void Handle(HttpRequest request)
        {
            // if DoHandle() returns true, we return early and the request processing ends
            if (DoHandle(request))
                return;

            // DoHandle is false, so check if there is a next handler, and if so, call its Handle() method.

            if (_nextHandler != null)
                _nextHandler.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}
