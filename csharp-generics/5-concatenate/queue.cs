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

     public T Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        if (CheckType() == typeof(Char))
        {
            string res ="";
            while (head != null)
            {
                res += head.value;
                head = head.next;
            }
            Console.Write(res);
        }

        if (CheckType() == typeof(String))
        {
            string res ="";
            while (head != null)
            {
                res += head.value;
                if (head.next != null)
                {
                    res += " " ;
                }
                head = head.next;
            }
            Console.Write(res);
        }
        else
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
        }
        return(default(T));
    }

    public int Count()
    {
        return(count);
    }

}
