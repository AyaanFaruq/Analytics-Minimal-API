namespace Minimal_API
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; }
        public string ErrorMessage { get; }
        public T Data { get; }

        private ServiceResult(bool isSuccess, string errorMessage, T data)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Data = data;
        }

        public static ServiceResult<T> Success(T data)
        {
            return new ServiceResult<T>(true, string.Empty, data);
        }

        public static ServiceResult<T> Failure(string errorMessage)
        {
            return new ServiceResult<T>(false, errorMessage, default);
        }
    }

}
