namespace BlazorWebApp_MeetingScheduler.Components.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }

        //creates a list of employees for the company
        //intializes a new instance of a list of employees
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Department(string departmentName)
        {
            DepartmentName = departmentName;

            switch (DepartmentName)
            {
                case "IT":
                    DepartmentId = 100;
                    break;
                case "Marketing":
                    DepartmentId = 101;
                    break;
                case "Management":
                    DepartmentId = 102;
                    break;
                case "Human Resources":
                    DepartmentId = 103;
                    break;
                case "Warehouse":
                    DepartmentId = 104;
                    break;
                default:

                    //handle unknown department name
                    throw new ArgumentException("Invalid department name");
            }

            if (DepartmentId == 0) 
            {
                throw new ArgumentException("Invalid department name");
            }

        }
    }

        

}

