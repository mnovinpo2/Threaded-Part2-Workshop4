namespace TravelExpertsData;

public class DataAccessException : Exception
{
    public DataAccessException(string msg, string type) : base(msg) =>
        ErrorType = type;

    public string ErrorType { get; init; }

    // if there is concurrency
    public bool IsConcurrencyError =>
        ErrorType.ToLower().Contains("concurrency");

    public bool IsDeleted => Message.ToLower().Contains("deleted");
}