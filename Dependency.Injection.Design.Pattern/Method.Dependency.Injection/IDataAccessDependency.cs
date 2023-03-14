namespace Method.Dependency.Injection
{
    public interface IDataAccessDependency
    {
        void SetDependency(IEmployeeDAL employeeDAL);
    }
}
