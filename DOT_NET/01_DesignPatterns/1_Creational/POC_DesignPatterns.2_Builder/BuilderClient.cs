namespace POC_DesignPatterns._2_Builder
{
    using POC_DesignPatterns._2_Builder.Builder;
    using POC_DesignPatterns._2_Builder.Model;

    using System;

    /// <summary>
    /// BuilderClient class.
    /// </summary>
    public class BuilderClient
    {
        /// <summary>
        /// Demo.
        /// </summary>
        public void Demo()
        {
            Director director = new Director();
            director.Structure.Add(new ConcreteBuilderA());
            director.Structure.Add(new ConcreteBuilderB());
            director.Construct();
            director.Inspect();
            Console.ReadLine();
        }
    }
}