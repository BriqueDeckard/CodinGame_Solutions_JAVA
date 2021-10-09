namespace POC_DesignPatterns._11_Visitor
{
    using POC_DesignPatterns._11_Visitor.Model.Composites;
    using POC_DesignPatterns._11_Visitor.Model.Leaf;
    using POC_DesignPatterns._11_Visitor.Model.Nodes;
    using POC_DesignPatterns._11_Visitor.Model.Visitors;

    using System;

    public class VisitorClient
    {
        public void Demo()
        {
            AbstractNode root = new ConcreteComposite1("root : ConcreteComposite1");
            AbstractNode node1_1 = new ConcreteComposite2("node1_1 : ConcreteComposite2");
            AbstractNode node1_1_1 = new ConcreteLeaf("node1_1_1 : ConcreteLeaf");
            AbstractNode node1_1_2 = new ConcreteLeaf("node1_1_2 : ConcreteLeaf");

            AbstractNode node1_2 = new ConcreteComposite1("node1_2 : ConcreteComposite1");
            AbstractNode node1_2_1 = new ConcreteLeaf("node1_2_1 : ConcreteLeaf");
            AbstractNode node1_2_2 = new ConcreteLeaf("node1_2_2 : ConcreteLeaf");

            AbstractNode node1_3 = new ConcreteComposite1("node1_3 : ConcreteComposite1");
            AbstractNode node1_3_1 = new ConcreteLeaf("node1_3_1 : ConcreteLeaf");
            AbstractNode node1_3_2 = new ConcreteLeaf("node1_3_2 : ConcreteLeaf");

            root.AddChild(node1_1);
            node1_1.AddChild(node1_1_1);
            node1_1.AddChild(node1_1_2);
            root.AddChild(node1_2);
            node1_2.AddChild(node1_2_1);
            node1_2.AddChild(node1_2_2);
            root.AddChild(node1_3);
            node1_3.AddChild(node1_3_1);
            node1_3.AddChild(node1_3_2);

            root.DoOperation();
            root.AcceptVisitor(new ConcreteVisitor());

            Console.ReadLine();
        }
    }
}