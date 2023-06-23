namespace WebSitem.Repositories.BaseClasses
{
    public class BaseResponse<T>
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public T Result { get; set; }

    }
}
