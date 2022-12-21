using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Composite
{
    public class CompositeApp
    {
        public CompositeApp() {
            Client client = new Client();

            // This way the client code can support the simple leaf
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ...as well as the complex composites.
            CompositeComposite tree = new CompositeComposite();
            CompositeComposite branch1 = new CompositeComposite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            CompositeComposite branch2 = new CompositeComposite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
