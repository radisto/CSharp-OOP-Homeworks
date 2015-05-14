using System;

class Project
{
    public string ProjectName { get; private set; }

    public DateTime ProjectStartDate { get; private set; }

    public string Details { get; private set; }

    public State State { get; private set; }

    void CloseProject()
    {
        this.State = State.Closed;
    }

    public Project(string projectName, DateTime projectStartDate, string details, State state)
    {
        this.ProjectName = projectName;
        this.ProjectStartDate = projectStartDate;
        this.Details = details;
        this.State = state;
    }
}