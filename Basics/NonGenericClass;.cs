namespace Basics;

public class NonGenericClass {
    public static void Swap<T>(ref T first, ref T second) {
        var temp = first;
        first = second;
        second = temp;
    }


}