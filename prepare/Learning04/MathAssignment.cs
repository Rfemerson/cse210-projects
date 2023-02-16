using System;

class MathAssignment : Assignment {

    private string _section;
    private string _problem;

    public  MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problem = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_section} Problems {_problem}";
    }


}