namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this(success) bu metodla success medodunu da çalıştırmak için yapıyoruz
        //böylelikle 2 metod birden çalışmış oluyor base metot
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
