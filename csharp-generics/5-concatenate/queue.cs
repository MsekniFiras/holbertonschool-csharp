using System;
///<summary>
/// class Queue.
/// </summary>
/// <typeparam name="T"></typeparam>//

class Queue<T>
{
    public Type CheckType()
    {
        return (typeof(T));
    }

    public class Node
    {
        public Node next = null;
        public T value = default(T);
        public Node(T var)
        {
            value = var;
        }
    }

    public Node head = null;
    public Node tail = null;
    public int count;

    public void Enqueue(T value)
    {
        Node new_node = new Node(value);

        if (head == null)
        {
            head = new_node;
            tail = new_node;
        }
        else
        {
            tail.next = new_node;
            tail = new_node;
        }
        count++;
    }
    

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        else
        {
            Node rm = head;
            head = head.next;
            count--;
            return (rm.value);
        }
    }

    public T Peek(){
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        else
            return (head.value);
    }

    public void Print(){
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.next;
            }
        }

    }

     /// <summary>
    /// Concatenates all values in the queue only if the queue is of type String or Char.
    /// </summary>
    public String Concatenate(){
        if (head == null){
            Console.WriteLine("Queue is empty ");
            return (null);
        }
        if (typeof(T) == typeof(String) || typeof(T) == typeof(Char)){
            var concatString = new StringBuilder("");
            while (head != null){
                concatString.Append(head.value);
                if (typeof(T) == typeof(String)){
                    concatString.Append(" ");
                }
                head = head.next;
            }
            return (concatString.ToString());
        }
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return (null);
    }
    /// <summary>
    /// Gets the count of nodes in the queue.
    /// </summary>
    /// <returns>Returns the number of queued elements.</returns>
    public int Count(){
        return (this.count);
    }
    /// <summary>
    /// Node of the queue.
    /// </summary>
    public class Node{
        /// <summary>
        /// Node's value
        /// </summary>
        /// <value>Get or set the node's value</value>
        public T value { get; set; } = default(T);


        /// <summary>
        /// Next node
        /// </summary>
        /// <value>Get or set the next node</value>
        public Node next { get; set; } = null;


        /// <summary>
        /// Default constructor for node class.
        /// </summary>
        /// <param name="value">Setting up the node value on initialisation.</param>
        public Node(T value){
            this.value = value;
        }
    }
}
       
