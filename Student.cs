namespace OOBasics
{
   class Student
    {
        public string Name ;
        public string grade;
        public long id;
        public string registrationNumber;

        public Student(string name, string grade, long id, string registrationNumber)
        {
            this.Name = name;
            this.grade = grade;
            this.id = id;
            this.registrationNumber = registrationNumber;
        }

        public void study()
        {
            Console.WriteLine("Student " + this.Name + " is study");
        }

        public void studentDatils()

        {
            Console.WriteLine("Student Name " + this.Name + ", registration Number is " + this.registrationNumber);
        }

    }
}
