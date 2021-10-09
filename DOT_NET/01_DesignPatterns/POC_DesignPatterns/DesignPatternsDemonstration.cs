namespace POC_DesignPatterns
{
    using _1_AbstractFactory;

    using _1_Adapter;

    using _1_ChainOfResponsability;

    using _10_TemplateMethod;

    using _11_Visitor;

    using _2_Bridge;

    using _2_Builder;

    using _2_Command;

    using _3_Composite;

    using _3_FactoryMethod;

    using _3_Interpreter;

    using _4_Decorator;

    using _4_Iterator;

    using _4_Prototype;

    using _5_Facade;

    using _5_Mediator;

    using _5_Singleton;

    using _6_Flyweight;

    using _6_Memento;

    using _7_Observer;

    using _7_Proxy;

    using _8_State;

    using _9_Strategy;

    using System;

    using static DesignPatternsTags;

    /// <summary>
    /// DesignPatternsDemonstration class.
    /// </summary>
    public class DesignPatternsDemonstration
    {
        /// <summary>
        /// Does the demonstration.
        /// </summary>
        /// <param name="designPatternsTag">The designPatternsTag.</param>
        public static void DoDemonstration(DesignPatternsTags designPatternsTag)
        {
            switch (designPatternsTag)
            {
                case ABF:
                    {
                        DoAbstractFactoryDemonstration();
                    }
                    break;

                case ADA:
                    {
                        DoAdapterDemonstration();
                    }
                    break;

                case BRI:
                    {
                        DoBridgeDemonstration();
                    }
                    break;

                case BUI:
                    {
                        DoBuilderDemonstration();
                    }
                    break;

                case CHA:
                    {
                        DoChainOfResponsibilityDemonstration();
                    }
                    break;

                case COM:
                    {
                        DoCommandDemonstration();
                    }
                    break;

                case COP:
                    {
                        DoCompositeDemonstration();
                    }
                    break;

                case DEC:
                    {
                        DoDecoratorDemonstration();
                    }
                    break;

                case DEP:
                    {
                        DoDependencyInjectionDemonstration();
                    }
                    break;

                case FAC:
                    {
                        DoFacadeDemonstration();
                    }
                    break;

                case FAM:
                    {
                        DoFactoryMethodDemonstration();
                    }
                    break;

                case FLY:
                    {
                        DoFlyweightDemonstration();
                    }
                    break;

                case INT:
                    {
                        DoInterpreterDemonstration();
                    }
                    break;

                case ITE:
                    {
                        DoIteratorDemonstration();
                    }
                    break;

                case PRO:
                    {
                        DoPrototypeDemonstration();
                    }
                    break;

                case SIN:
                    {
                        DoSingletonDemonstration();
                    }
                    break;

                case PRX:
                    {
                        DoProxyDemonstration();
                    }
                    break;

                case MED:
                    {
                        DoMediatorDemonstration();
                    }
                    break;

                case MEM:
                    {
                        DoMementoDemonstration();
                    }
                    break;

                case OBS:
                    {
                        DoObserverDemonstration();
                    }
                    break;

                case STA:
                    {
                        DoStateDemonstration();
                    }
                    break;

                case STR:
                    {
                        DoStrategyDemonstration();
                    }
                    break;

                case TMP:
                    {
                        DoTemplateMethodDemonstration();
                    }
                    break;

                case VST:
                    {
                        DoVisitorDemonstration();
                    }
                    break;
            }
        }

        /// <summary>
        /// Does the abstract factory demonstration.
        /// </summary>
        private static void DoAbstractFactoryDemonstration()
        {
            AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient();
            abstractFactoryClient.Demo();
        }

        /// <summary>
        /// Does the adapter demonstration.
        /// </summary>
        private static void DoAdapterDemonstration()
        {
            AdapterClient adapterClient = new AdapterClient();
            adapterClient.Demo();
        }

        /// <summary>
        /// Does the bridge demonstration.
        /// </summary>
        private static void DoBridgeDemonstration()
        {
            BridgeClient bridgeClient = new BridgeClient();
            bridgeClient.Demo();
        }

        /// <summary>
        /// Does the builder demonstration.
        /// </summary>
        private static void DoBuilderDemonstration()
        {
            BuilderClient builderClient = new BuilderClient();
            builderClient.Demo();
        }

        /// <summary>
        /// Does the chain of responsibility demonstration.
        /// </summary>
        private static void DoChainOfResponsibilityDemonstration()
        {
            ChainOfResponsibilityClient chainOfResponsibilityClient = new ChainOfResponsibilityClient();
            chainOfResponsibilityClient.Demo();
        }

        /// <summary>
        /// Does the command demonstration.
        /// </summary>
        private static void DoCommandDemonstration()
        {
            CommandClient commandClient = new CommandClient();
            commandClient.Demo();
        }

        /// <summary>
        /// Does the composite demonstration.
        /// </summary>
        private static void DoCompositeDemonstration()
        {
            CompositeClient compositeClient = new CompositeClient();
            compositeClient.Demo();
        }

        /// <summary>
        /// Does the decorator demonstration.
        /// </summary>
        private static void DoDecoratorDemonstration()
        {
            DecoratorClient decoratorClient = new DecoratorClient();
            decoratorClient.Demo();
        }

        /// <summary>
        /// Does the dependency injection demonstration.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        private static void DoDependencyInjectionDemonstration()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Does the facade demonstration.
        /// </summary>
        private static void DoFacadeDemonstration()
        {
            FacadeClient facadeClient = new FacadeClient();
            facadeClient.Demo();
        }

        /// <summary>
        /// Does the factory method demonstration.
        /// </summary>
        private static void DoFactoryMethodDemonstration()
        {
            FactoryMethodClient factoryMethodClient = new FactoryMethodClient();
            factoryMethodClient.Demo();
        }

        /// <summary>
        /// Does the flyweight demonstration.
        /// </summary>
        private static void DoFlyweightDemonstration()
        {
            FlyweightClient flyweightClient = new FlyweightClient();
            flyweightClient.Demo();
        }

        /// <summary>
        /// Does the interpreter demonstration.
        /// </summary>
        private static void DoInterpreterDemonstration()
        {
            InterpreterClient interpreterClient = new InterpreterClient();
            interpreterClient.Demo();
        }

        /// <summary>
        /// Does the iterator demonstration.
        /// </summary>
        private static void DoIteratorDemonstration()
        {
            IteratorClient iteratorClient = new IteratorClient();
            iteratorClient.Demo();
        }

        /// <summary>
        /// Does the mediator demonstration.
        /// </summary>
        private static void DoMediatorDemonstration()
        {
            MediatorClient mediatorClient = new MediatorClient();
            mediatorClient.Demo();
        }

        /// <summary>
        /// Does the memento demonstration.
        /// </summary>
        private static void DoMementoDemonstration()
        {
            MementoClient mementoClient = new MementoClient();
            mementoClient.Demo();
        }

        /// <summary>
        /// Does the observer demonstration.
        /// </summary>
        private static void DoObserverDemonstration()
        {
            ObserverClient observerClient = new ObserverClient();
            observerClient.Demo();
        }

        /// <summary>
        /// Does the prototype demonstration.
        /// </summary>
        private static void DoPrototypeDemonstration()
        {
            PrototypeClient prototypeClient = new PrototypeClient();
            prototypeClient.Demo();
        }

        /// <summary>
        /// Does the proxy demonstration.
        /// </summary>
        private static void DoProxyDemonstration()
        {
            ProxyClient proxyClient = new ProxyClient();
            proxyClient.Demo();
        }

        /// <summary>
        /// Does the singleton demonstration.
        /// </summary>
        private static void DoSingletonDemonstration()
        {
            SingletonClient singletonClient = new SingletonClient();
            singletonClient.Demo();
        }

        /// <summary>
        /// Does the state demonstration.
        /// </summary>
        private static void DoStateDemonstration()
        {
            StateClient stateClient = new StateClient();
            stateClient.Demo();
        }

        /// <summary>
        /// Does the strategy demonstration.
        /// </summary>
        private static void DoStrategyDemonstration()
        {
            StrategyClient strategyClient = new StrategyClient();
            strategyClient.Demo();
        }

        /// <summary>
        /// Does the template method demonstration.
        /// </summary>
        private static void DoTemplateMethodDemonstration()
        {
            TemplateMethodClient templateMethodClient = new TemplateMethodClient();
            templateMethodClient.Demo();
        }

        /// <summary>
        /// Does the visitor demonstration.
        /// </summary>
        private static void DoVisitorDemonstration()
        {
            VisitorClient visitorClient = new VisitorClient();
            visitorClient.Demo();
        }
    }
}