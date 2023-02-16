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
    public LinkedList next;
    public override void insertElement(int data)
    {
        LinkedList newNode = new LinkedList();
        newNode.Data = data;
        newNode.next = this.next;
        this.next = newNode;
    }
    public override void printData()
    {
        LinkedList currentNode = this;
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
        LinkedList temp = this;
        LinkedList currentNode = this;
        /*if(temp.Data == data && temp.next == null) // The special case when the head has the value searched must be accounted for.
        {
            this = this.next;
            return temp;
        }
        else*/
        {
            while(temp.next != null)
            {
                if(temp.next.Data == data)
                {
                    currentNode = temp.next;
                    temp.next = temp.next.next;
                    return currentNode;
                }
                temp = temp.next;
            }
            return null;
        }
    }
    public override uint getSize ()
    {
        return 0;
    }
}