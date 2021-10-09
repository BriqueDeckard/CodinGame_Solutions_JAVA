namespace POC_DesignPatterns._1_Adapter
{
    using POC_DesignPatterns._1_Adapter.Adapter.Composition;
    using POC_DesignPatterns._1_Adapter.Adapter.Inheritance;
    using POC_DesignPatterns._1_Adapter.Targets;

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Client class.
    /// </summary>
    public class AdapterClient
    {
        /// <summary>
        /// Composite demo.
        /// </summary>
        public void CompositeDemo()
        {
            Logger.Logger.Log(TAG + "CompositeDemo");
            ITarget target1 = new Target();
            ITarget target2 = new CompositeAdapter();
            IList<ITarget> targets = new List<ITarget> { target1, target2 };
            foreach (ITarget target in targets)
            {
                target.Request();
            }
        }

        /// <summary>
        /// Demos.
        /// </summary>
        public void Demo()
        {
            Logger.Logger.Log(TAG + "Demo");
            CompositeDemo();
            InheritanceDemo();

            Console.ReadLine();
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "AdapterClient ";

        /// <summary>
        /// Inheritance demo.
        /// </summary>
        private void InheritanceDemo()
        {
            Logger.Logger.Log(TAG + "InheritanceDemo");
            ITarget target1 = new Target();
            ITarget target2 = new InheritanceAdapter();
            IList<ITarget> targets = new List<ITarget> { target1, target2 };
            foreach (ITarget target in targets)
            {
                target.Request();
            }
        }
    }
}