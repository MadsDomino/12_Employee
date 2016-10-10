namespace _12_Employee
{
    internal interface IEmployeeRepository
    {
        int CountEmployees();
        Employee CreateEmployee(string Name, string Occupation);
        void Clear();
    }
}