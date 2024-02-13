namespace Basics;

public class Repository<T> {
    private readonly List<T> _data = new List<T>();
    public void Add(T entity) {
        _data.Add(entity);
    }

    public void Remove(T entity) {
        _data.Remove(entity);
    }

    public T Get (int index) {
        return _data[index];
    }

    public IEnumerable<T> All() {
        return _data;
    }



}