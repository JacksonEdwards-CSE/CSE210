using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job();

        myFirstJob._companyName = "Walgreens";

        myFirstJob._jobTitle = "Customer Service Associate";

        myFirstJob._startYear = 2022;

        myFirstJob._endYear = 2024;



        Job mySecondJob = new Job();

        mySecondJob._companyName = "Brigham Young University - Idaho";

        mySecondJob._jobTitle = "Teacher's Assistant";

        mySecondJob._startYear = 2024;

        mySecondJob._endYear = 2025;



        Resume myResume = new Resume();

        myResume._name = "Jackson Edwards";

        myResume._jobs = new List<Job>();
        myResume._jobs.Add(myFirstJob);
        myResume._jobs.Add(mySecondJob);

        myResume.DisplayResume();
    }
}