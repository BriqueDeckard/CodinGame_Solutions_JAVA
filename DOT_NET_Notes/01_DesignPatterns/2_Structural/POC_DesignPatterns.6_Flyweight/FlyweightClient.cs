namespace POC_DesignPatterns._6_Flyweight
{
    using POC_DesignPatterns.Core;

    using System;

    /// <summary>
    /// Flyweight client, maintains a reference to flyweight(s) and computes or stores the extrinsic state of flyweight(s).
    /// </summary>
    /// <seealso cref="POC_DesignPatterns.Core.IClient" />
    public class FlyweightClient : IClient
    {
        public void Demo()
        {
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight flyweight1 = factory.GetFlyweight("X");
            flyweight1.Operation(--extrinsicstate);

            IFlyweight flyweight2 = factory.GetFlyweight("Y");
            flyweight1.Operation(--extrinsicstate);

            IFlyweight flyweight3 = factory.GetFlyweight("Z");
            flyweight1.Operation(--extrinsicstate);

            Console.ReadLine();
        }
    }
}