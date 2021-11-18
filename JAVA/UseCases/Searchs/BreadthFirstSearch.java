import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

/**
 * Breadth first search is graph traversal algorithm. In this algorithm, lets
 * say we start with node i, then we will visit neighbours of i, then neighbours
 * of neighbours of i and so on.
 * 
 * It is very much similar to which is used in binary tree. We use queue to
 * traverse graph. We put first node in queue . It repeatedly extracts node and
 * put its neighbours in the queue. Only difference with respect to binary tree
 * is that we need to track if node have been visited before or not. It can be
 * easily done with help of boolean variable visited in the node. If node have
 * been already visited then we won’t visit it again. Steps for Breadth first
 * search:
 * 
 * 1- Create empty queue and push root node to it.
 * 
 * 2- Do the following when queue is not empty
 * 
 * 3- Pop a node from queue and print it.
 * 
 * 4- Find neighbours of node with the help of adjacency matrix and check if
 * node is already visited or not.
 * 
 * 5- Push neighbours of node into queue if not null
 */
public class BreadthFirstSearch {

    private Queue<Node> queue;
    static ArrayList<Node> nodes = new ArrayList<Node>();

    static class Node {
        String value;
        /**
         * Data corresponding to the node
         */
        int data;
        /**
         * Determines whether a node was visited or not
         */
        boolean wasVisited;
        /**
         * The neighbours
         */
        List<Node> neighbours;

        Node(int data, String value) {
            this.data = data;
            this.neighbours = new ArrayList<>();
            this.value = value;
        }

        public void addNeighbour(Node neighbourNode) {
            this.neighbours.add(neighbourNode);
        }

        public List<Node> getNeighbours() {
            return neighbours;
        }

        public void setNeighbours(List<Node> neighbours) {
            this.neighbours = neighbours;
        }

    }

    public BreadthFirstSearch() {
        queue = new LinkedList<Node>();
    }

    public Node bFS(Node node, int data) {
        Node index = null;

        // Add the node to the queue
        queue.add(node);
        // Set the node to visited
        node.wasVisited = true;
        // Iterates through the nodes
        while (!queue.isEmpty()) {
            // Get the first element and remove it from the queue
            Node element = queue.remove();
            System.out.print(element.data + "\t");
            if (element.data == data) {
                index = element;
            }
            // Get the neighbours
            List<Node> neighbours = element.getNeighbours();

            // Iterates through the neighbours
            for (int i = 0; i < neighbours.size(); i++) {
                // Get the current node
                Node current = neighbours.get(i);
                System.out.println("\t\ti: " + i + " current: " + current.data);
                boolean currentIsNotNull = current != null;
                boolean currentWasNotVisited = !current.wasVisited;
                if (currentIsNotNull && currentWasNotVisited) {
                    queue.add(current);
                    current.wasVisited = true;
                }
            }
        }
        return index;
    }

    public static void main(String[] args) {
        Node node10 = new Node(10, "A");
        Node node15 = new Node(15, "B");
        Node node20 = new Node(20, "C");
        Node node25 = new Node(25, "D");
        Node node30 = new Node(30, "E");
        Node node35 = new Node(35, "F");
        Node node40 = new Node(40, "G");
        Node node45 = new Node(45, "H");
        Node node50 = new Node(50, "I");
        // ---- 10 ----
        node10.addNeighbour(node15);
        node10.addNeighbour(node20);
        node10.addNeighbour(node25);
        // ---- 15 ----
        node15.addNeighbour(node10);
        node15.addNeighbour(node20);
        node15.addNeighbour(node30);
        // ---- 20 ----
        node20.addNeighbour(node25);
        node20.addNeighbour(node30);
        node20.addNeighbour(node40);
        // ---- 25 ----
        node25.addNeighbour(node30);
        node25.addNeighbour(node35);
        node25.addNeighbour(node20);
        node25.addNeighbour(node50);
        // ---- 30 ----
        node30.addNeighbour(node45);
        // ---- 40 ----
        node40.addNeighbour(node45);
        // ---- 45 ----
        node45.addNeighbour(node50);

        System.out.println("The BFS traversal of the tgraph is: ");
        BreadthFirstSearch bfsExample = new BreadthFirstSearch();
        Node result = bfsExample.bFS(node25, 45);
        System.out.println("Result: " + result.data);
        result = bfsExample.bFS(node25, 50);
        System.out.println("Result: " + result.data);

    }

}
