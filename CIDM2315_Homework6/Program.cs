using System;
namespace CIDM2315_Homework6;
     class Program
    {
        public static void Main(string[] args)
        {
			// define our objects and set parameters
            Professor Alice = new Professor(initName:"Alice", initClass:"Java", initSalary:9000);
			Alice.GetInfo();
            Professor Bob = new Professor(initName:"Bob", initClass:"Math", initSalary:8000);
			Bob.GetInfo();
            Student Lisa = new Student(initName:"Lisa", initClass:"Java", initGrade:90);
			Lisa.GetInfo();
            Student Tom = new Student(initName:"Tom", initClass:"Java", initGrade:80);
			Tom.GetInfo();
			Console.WriteLine($"The salary difference between {Alice.profName} and {Bob.profName} is {Alice.Salary - Bob.Salary}"); // calculate salary difference between these objects
			Console.WriteLine($"The total grade between {Lisa.studentName} and {Tom.studentName} is {Lisa.StudentGrade + Tom.StudentGrade}"); // calculate grade sum between these objects
        }
class Professor
    {
		private double salary; // to be modified later
		public string profName;
        public string classTeach;

		public Professor(double initSalary, string initName, string initClass) // provide variables so we can modify our Object fields using overloading, on object instantation
		{
			this.Salary = initSalary; // access private Salary field and set equal to our salary input
			profName = initName;
			classTeach = initClass;
		}
		// commented is the way of doing Salary with extra methods instead of overloading the constructor
		// public void SetSalary(double setSalary) {
		// 	this.Salary = setSalary;
		// }
		// public double GetSalary(double getSalary) {
		// 	getSalary = this.Salary;
		// 	return getSalary;
		// }
		public void GetInfo() {
			Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is {this.Salary}"); // call our info for each Object and also get the info from Salary parameter
		}
		public double Salary // Salary parameter
		{ 
			get { return salary; }
			set { salary = value;}
		}
	}
    class Student
    {
		private double studentGrade;
		public string studentName;
        public string classEnroll;

		public Student(int initGrade, string initName, string initClass)
// provide variables so we can modify our Object fields using overloading 
		{
		this.StudentGrade = initGrade;
		studentName = initName;
		classEnroll = initClass;
		}
		// public void SetGrade(double setGrade) {
		// 	this.StudentGrade = setGrade;
		// }
		// public double GetGrade(double getGrade) {
		// 	getGrade = this.StudentGrade;
		// 	return getGrade;
		// }
		public void GetInfo() {
			Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is {this.StudentGrade}");
		} // displaying object parameters to console
		
		public double StudentGrade
		{ 
			get { return studentGrade; }
			set { studentGrade = value;}
		} // access our private studentGrade field
	}
}
