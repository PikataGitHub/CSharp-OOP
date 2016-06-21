namespace StudentGroups_09_19
{
    class Group
    {
        //Constructors
        public Group(int groupNumber, string departamentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departamentName;
        }

        //Properties
        public int GroupNumber { get; private set; }

        public string DepartmentName { get; private set; }

    }
}
