// DataStructures.cs


using System;

public abstract class LinkedStructure
{
    private int _data;
    public int Data
    {
        get { return _data; }
        set { _data = value; }
    }
    public abstract void insertElement(int data);
    public abstract void printData();
    public abstract uint getSize ();
    public abstract LinkedList findElement (int Data);
}

public class LinkedList : LinkedStructure
{
    private LinkedList head;
    private LinkedList tail;
    private LinkedList next;
    public LinkedList ()
    {
        ;
    }
    public static LinkedList newList(int val)
    {
        LinkedList list = new LinkedList ();
        list.createLinkedList (val);
        return list;
    }
    public LinkedList createLinkedList (int data)
    {
        head = new LinkedList ();
        tail = new LinkedList ();
        LinkedList newNode = new LinkedList ();
        newNode.Data = data;
        head.next = newNode;
        tail.next = newNode;
        newNode.next = null;
        return head;
    }
    public override void insertElement(int data)
    {
        LinkedList newNode = new LinkedList();
        newNode.Data = data;
        tail.next.next = newNode;
        tail.next = newNode;
    }
    public override void printData()
    {
        LinkedList currentNode = head.next;
        int i = 0;
        while (currentNode != null)
        {
            Console.WriteLine("Data of node {0}: {1}.", i, currentNode.Data);
            i ++;
            currentNode = currentNode.next;
        }
    }
    public override LinkedList findElement(int data)
    {
        LinkedList currentNode = head;
        LinkedList temp;
        while (currentNode.next != null)
        {
            if (currentNode.next.Data == data)
            {
                if (currentNode.next.next != null)
                {
                    temp = currentNode.next;
                    currentNode.next = currentNode.next.next;
                }
                else
                {                    
                    tail.next = currentNode;
                    temp = currentNode.next;
                    currentNode.next = null;
                }
                temp.next = null;
                return temp;                
            }
            currentNode = currentNode.next;
        }
        return null;
    }
    public override uint getSize ()
    {
        return 0;
    }
}