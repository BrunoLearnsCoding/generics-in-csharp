using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Generic_Linked_List;

public class LinkedList<T> where T : IEquatable<T>
{
    private Node<T>? _head = null;

    public void Insert(T value)
    {
        var node = new Node<T>(value);
        node.Next = _head;
        _head = node;
    }

    public void Delete(T value)
    {
        var current = _head;
        Node<T>? prev = null;

        while (current is not null)
        {
            if (current.Value.Equals(value))
            {
                if (prev is not null)
                {
                    prev.Next = current.Next;
                    current.Next = null;
                }
                else
                {
                    _head = current.Next;
                }
            }
            prev = current;
            current = current.Next;
        }
    }

    public IEnumerable<T> GetAll()
    {
        var current = _head;
        while (current is not null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    public IEnumerable<T> GetWhere(Func<T, bool> condition)
    {
        var current = _head;
        while (current is not null)
        {
            if (condition(current.Value) == true)
            {
                yield return current.Value;
            }
            current = current.Next;
        }


    }
    public void Print()
    {
        var current = _head;
        while (current is not null)
        {
            Console.WriteLine(current.Value.ToString());
            current = current.Next;
        }
    }
}

internal class Node<T>
{
    private T _value;
    public Node<T>? Next { get; set; } = null;
    public T Value
    {
        get => _value;
    }
    public Node(T value)
    {
        _value = value;
    }
}

