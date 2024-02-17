using System;
using System.Collections;

namespace Generic_Linked_List;

public class Person : IEquatable<Person>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Id {get; }

    public Person(string id)
    {
        Id = id;
    }

    public bool Equals(Person? other)
    {
        if (other is null) {
            return false;
        }
        return Id == other.Id;
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName} {Id}";
    }
}