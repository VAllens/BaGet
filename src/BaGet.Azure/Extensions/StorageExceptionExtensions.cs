namespace BaGet.Azure;

internal static class StorageExceptionExtensions
{
    public static bool IsAlreadyExistsException(this StorageException_ e)
    {
        return e?.RequestInformation?.HttpStatusCode == (int?)HttpStatusCode.Conflict;
    }

    public static bool IsNotFoundException(this TableStorageException e)
    {
        return e?.RequestInformation?.HttpStatusCode == (int?)HttpStatusCode.NotFound;
    }

    public static bool IsAlreadyExistsException(this TableStorageException e)
    {
        return e?.RequestInformation?.HttpStatusCode == (int?)HttpStatusCode.Conflict;
    }

    public static bool IsPreconditionFailedException(this TableStorageException e)
    {
        return e?.RequestInformation?.HttpStatusCode == (int?)HttpStatusCode.PreconditionFailed;
    }
}
