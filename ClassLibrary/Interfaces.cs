namespace ClassLibrary
{
    public interface IReadWrite<T>
    {
        public T[] ReadFrom(params StreamReader[] readers);
        public void WriteTo(StreamWriter writer, params StreamReader[] readers);

    }

    public interface ICRUD<T>
    {
        public void Create(StreamWriter writer);
        public T Read(StreamReader reader);
        public void Update(StreamReader reader, StreamWriter writer);
        public void Delete(string path);
    }
}