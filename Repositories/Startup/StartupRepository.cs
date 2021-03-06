﻿using Models.Models;
using Repository.Startup;
using System.IO;
using System;

namespace Repository
{
    public class StartupRepository : IStartupRepository
    {
        private static StartupConfigurations startupConfigurations = new StartupConfigurations();

        public StartupConfigurations GetStartupConfig()
        {
            return startupConfigurations;
        }

        public void SetModelWorkSystemFirst(bool flag)
        {
            if (startupConfigurations.ModelWorkSystem != flag)
            {
                startupConfigurations.ModelWorkSystem = flag;
            }
        }

        public void SetModelWorkSystemSecond(bool flag)
        {
            if (startupConfigurations.ModelWorkSystem != flag)
            {
                startupConfigurations.ModelWorkSystem = flag;
            }
        }

        public void ChangeAmountOfAccelerationOfLiftsUp(int amount)
        {
            if (startupConfigurations.AccelerationOfLifts + amount <= 2)
            {
                startupConfigurations.AccelerationOfLifts += amount;
            }
        }

        public void ChangeAmountOfAccelerationOfLiftsDown(int amount)
        {
            if (startupConfigurations.AccelerationOfLifts - amount >= 1)
            {
                startupConfigurations.AccelerationOfLifts -= amount;
            }
        }

        public void ChangeAmountOfFloorsUp(int amount)
        {
            if (startupConfigurations.Floors + amount <= 20)
            {
                startupConfigurations.Floors += amount;
            }
        }

        public void ChangeAmountOfFloorsDowm(int amount)
        {
            if (startupConfigurations.Floors - amount >= 9)
            {
                startupConfigurations.Floors -= amount;
            }
        }

        public void ChangeAmountOfLiftsUp(int amount)
        {
            if (startupConfigurations.Lifts + amount <= 5)
            {
                startupConfigurations.Lifts += amount;
            }
        }

        public void ChangeAmountOfLiftsDown(int amount)
        {
            if (startupConfigurations.Lifts - amount >= 1)
            {
                startupConfigurations.Lifts -= amount;
            }
        }

        public void ChangeAmountOfPeopleInLiftsUp(int amount)
        {
            if (startupConfigurations.PeopleInLifts + amount <= 5)
            {
                startupConfigurations.PeopleInLifts += amount;
            }
        }

        public void ChangeAmountOfPeopleInLiftsDown(int amount)
        {
            if (startupConfigurations.PeopleInLifts - amount >= 3)
            {
                startupConfigurations.PeopleInLifts -= amount;
            }
        }

        public void ChangeAmountOfSpeedOfLiftsUp(int amount)
        {
            if (startupConfigurations.SpeedOfLifts + amount <= 3)
            {
                startupConfigurations.SpeedOfLifts += amount;
            }
        }

        public void ChangeAmountOfSpeedOfLiftsDown(int amount)
        {
            if (startupConfigurations.SpeedOfLifts - amount >= 1)
            {
                startupConfigurations.SpeedOfLifts -= amount;
            }
        }

        public void DownloadConfig()
        {
            StreamWriter f = new StreamWriter("Config.txt", false);
            f.WriteLine("Mode of work: " + startupConfigurations.ModelWorkSystem);
            f.WriteLine("Number of lifts: " + startupConfigurations.Lifts);
            f.WriteLine("Number of floors: " + startupConfigurations.Floors);
            f.WriteLine("Number of people in lifts: " + startupConfigurations.PeopleInLifts);
            f.WriteLine("Value of speed of lifts: " + startupConfigurations.SpeedOfLifts);
            f.WriteLine("Value of acceleration of lifts: " + startupConfigurations.AccelerationOfLifts);
            f.Close();
        }

        public void UploadConfig()
        {
            StreamReader f = new StreamReader("Config.txt");
            string ModeWork = f.ReadLine();
            ModeWork = ModeWork.Substring(14);
            string Compare = "True";
            startupConfigurations.ModelWorkSystem = ModeWork.Equals(Compare);
            string NumberLifts = f.ReadLine();
            NumberLifts = NumberLifts.Substring(17);
            startupConfigurations.Lifts = Convert.ToInt32(NumberLifts);
            string NumberFloors = f.ReadLine();
            NumberFloors = NumberFloors.Substring(18);
            startupConfigurations.Floors = Convert.ToInt32(NumberFloors);
            string NumberPeople = f.ReadLine();
            NumberPeople = NumberPeople.Substring(27);
            startupConfigurations.PeopleInLifts = Convert.ToInt32(NumberPeople);
            string ValueSpeed = f.ReadLine();
            ValueSpeed = ValueSpeed.Substring(25);
            startupConfigurations.SpeedOfLifts = Convert.ToInt32(ValueSpeed);
            string ValueAcceleration = f.ReadLine();
            ValueAcceleration = ValueAcceleration.Substring(32);
            startupConfigurations.AccelerationOfLifts = Convert.ToInt32(ValueAcceleration);
            f.Close();
        }

        public void DownloadRes()
        {
            StreamWriter f = new StreamWriter("Result.txt", false);
            f.WriteLine("INPUT DATA:");
            f.WriteLine("");
            f.WriteLine("Number of lifts: " + startupConfigurations.Lifts);
            f.WriteLine("Number of floors: " + startupConfigurations.Floors);
            f.WriteLine("Number of people in lifts: " + startupConfigurations.PeopleInLifts);
            f.WriteLine("Value of speed of lifts: " + startupConfigurations.SpeedOfLifts);
            f.WriteLine("Value of acceleration of lifts: " + startupConfigurations.AccelerationOfLifts);
            f.WriteLine("");
            f.WriteLine("");
            f.WriteLine("OUTPUT DATA:");
            f.WriteLine("");
            for (int i = 1; i <= startupConfigurations.Lifts; ++i)
            {
                f.WriteLine("Lift number " + i);
                f.WriteLine("Common number of trips: ");
                f.WriteLine("Percent of free trips: ");
                f.WriteLine("Number of tripped people: ");
                f.WriteLine("");
            }
            f.WriteLine("");
            f.WriteLine("");
            f.WriteLine("Common numbers of trips: ");
            f.WriteLine("Middle time of waiting: ");
            f.WriteLine("Max time of waiting: ");
            f.WriteLine("Total time of waiting: ");
            f.WriteLine("Number of emergencies: ");
            f.WriteLine("Total time of emergencies: ");
            f.WriteLine("");
            f.Close();
        }
    }
}
