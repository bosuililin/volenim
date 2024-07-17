public class Result
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; }

    // Private constructor to control instantiation from within the class.
    private Result(bool isSuccess, string message)
    {
        IsSuccess = isSuccess;
        Message = message;
    }

    // Factory method to create a successful result.
    public static Result Success() => new Result(true, "Operation succeeded.");

    // Factory method to create a failure result.
    public static Result Failure(string message) => new Result(false, message);
}
