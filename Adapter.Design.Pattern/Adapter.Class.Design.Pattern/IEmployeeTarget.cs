namespace Adapter.Class.Design.Pattern
{
    /// <summary>
    /// A 'Target' interface
    /// It is an interface and this interface needs to be implemented by the Adapter and the client can see only this interface.
    /// </summary>
    public interface IEmployeeTarget
    {
        string GetAllEmployee();
    }
}
