// What is our goal?
// To have an set of validators that collectively deteremin if Person is valid or not

using System.Xml.XPath;

public class Person {
    public string FistName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

public class ValidationHelper {
    public static bool ValidatePerson(Person person) {
        if (string.IsNullOrEmpty(person.FistName )) {
            return false;
        }
        if (person.FistName.Length < 3) {
            return false;
        }
        return true;
    }



}