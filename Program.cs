
using StudentManagementInfo;

int choice = 0;
StudetManagement studentManagementInfo = new StudetManagement();
do
{

    Console.WriteLine("Please select Choice");
    Console.WriteLine("Please Select 1 For Add");
    Console.WriteLine("Please Select 2 for Display");
    choice = Convert.ToInt32(Console.ReadLine());

    

    switch (choice)
    {
        case 1:

           StudentInfo studentInfo = new StudentInfo(); 
            Console.WriteLine("Please Enter Name");
            studentInfo.Name = Console.ReadLine();

            Console.WriteLine("Please Enter Marks");
            studentInfo.Mark1 =  Convert.ToInt32(Console.ReadLine());


            studentManagementInfo.AddStudent(studentInfo);  

            break;

            case 2:

            studentManagementInfo.DisplayStudent();
            break;

            default:

            return;
            break;

    }

}while (choice >0);
