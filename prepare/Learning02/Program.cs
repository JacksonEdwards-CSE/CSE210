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

        myFirstJob.DisplayJob();

        Job mySecondJob = new Job();

        mySecondJob._companyName = "Brigham Young University - Idaho";

        mySecondJob._jobTitle = "Teacher's Assistant";

        mySecondJob._startYear = 2024;

        mySecondJob._endYear = 2025;

        mySecondJob.DisplayJob();
    }
}