// DataStructures.cs

public abstract class LinkedStructure
{
    protected int intData;
    public static void printData(LinkedStructure head) {}
    public static void insertElement(LinkedStructure head, int data) {}
    public abstract uint getSize (LinkedStructure head);
}

public class LinkedList : LinkedStructure
{
    public int data;
    public LinkedList next;
    public static new void insertElement(LinkedStructure head, int Data)
    {
        LinkedList newNode = new LinkedList();
        newNode.data = Data;
        newNode.next = head.next;
        head.next = newNode;
    }
    public static new void printData(LinkedStructure head)
    {
        LinkedList currentNode = head;
        int i = 0;
        while (currentNode != null)
        {
            Console.WriteLine("Data of node {0}: {1}.", i, currentNode.data);
            i ++;
            currentNode = currentNode.next;
        }
    }
    public static LinkedList findNode(LinkedList head, int Data)
    {
        LinkedList temp = head;
        LinkedList currentNode = head;
        if(temp.data == Data && temp.next == null)
        {
            head = head.next;
            return temp;
        }
        else
        {
            while(temp.next != null)
            {
                if(temp.next.data == Data)
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
    public override uint getSize (LinkedStructure head)
    {
        ;
    }
}