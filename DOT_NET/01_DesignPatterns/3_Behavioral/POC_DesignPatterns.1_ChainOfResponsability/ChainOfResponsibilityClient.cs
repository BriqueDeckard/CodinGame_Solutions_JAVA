namespace POC_DesignPatterns._1_ChainOfResponsability
{
    using POC_DesignPatterns._1_ChainOfResponsability.Handler;

    using System;

    using System.Collections.Generic;

    /// <summary>
    /// ChainOfResponsibility client class.
    /// </summary>
    public class ChainOfResponsibilityClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            AbstractHandler mainHandler = InitializeHandlers();
            IEnumerable<Request.Request> requests = InitializeRequests();
            foreach (Request.Request request in requests)
            {
                mainHandler.HandleRequest(request);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Initializes the handlers.
        /// </summary>
        /// <returns></returns>
        public AbstractHandler InitializeHandlers()
        {
            AbstractHandler mainHandler = new ConcreteHandler1();
            AbstractHandler secondHandler = new ConcreteHandler2();
            AbstractHandler thirdHandler = new ConcreteHandler3();

            secondHandler.Successor = thirdHandler;
            mainHandler.Successor = secondHandler;
            return mainHandler;
        }

        /// <summary>
        /// Initializes the requests.
        /// </summary>
        /// <returns></returns>
        public IList<Request.Request> InitializeRequests()
        {
            Request.Request request1 = new Request.Request { Name = "Request 1", Value = 100 };

            Request.Request request2 = new Request.Request { Name = "Request 2", Value = 200 };

            List<Request.Request> requests = new List<Request.Request> { request1, request2 };

            return requests;
        }
    }
}