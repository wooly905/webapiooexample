namespace WebAPIOO.contracts
{
    public interface IRootGroup
    {
        ISubGroup GetSubGroup<T>();
    }
}
