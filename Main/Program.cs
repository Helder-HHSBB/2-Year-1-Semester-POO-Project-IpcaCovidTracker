using IpcaCovidTracker.Entities;
using IpcaCovidTracker.Material;
using IpcaCovidTracker.Teams;
using System;
using System.Collections.Generic;

namespace IpcaCovidTracker.Main

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int option = 1;

            //Here we iniatialize our world, some persons, teams, and equipments. Also some tests

            #region Initialazations

            World.World world = new World.World(new List<Person>()
            {
                new Doctor(999,1000,"Alex Medicinal", "alex@hotmail.com", new DateTime(1969,01,01), "male", 1600, 1, false),
                new Doctor(151,1001, "Virginia Medical", "Virginia@hotmail.com", new DateTime(1975,12,12),"female", 1666, 1, false),
                new Doctor(131,1002, "Robert Heart Man", "Robheart@gmail.com", new DateTime(1971,12,12),"male", 1750, 1, false),
                new Doctor(121,1003, "Lopes Fatdoc", "lopes@hotmail.com", new DateTime(1975,12,12),"female", 1620, 1, false),

                new Citizen(5000, "Hélder","email@asas.com", new DateTime(1992, 05, 22), "Male", 0, false),
                new Citizen(5001, "John Pretovsky","easdail@asas.com", new DateTime(1992, 05, 22), "Male", 0, false),
                new Citizen(5002, "João Pedro","Joaoyes@gmail.com", new DateTime(1987, 05, 22), "Male", 0, false),
                new Citizen(5003, "Gull bill","gullbill@outlook.com", new DateTime(1988, 05, 22), "Male", 0, false),

                new Driver(123,"B",3000, "Schummaker", "lovecars@uber.com", new DateTime(1987, 12, 22), "Male",800, 0, false),
                new Driver(1113,"B",3001, "Peter Faustino", "FaustoRacer@speed.com", new DateTime(1977, 01, 1), "Male",750, 0, false),
                new Driver(1114,"B",3002, "Ayrton Senas", "F1forlife@speed.com", new DateTime(1987, 01, 1), "Male",750, 0, false),
                new Driver(1115,"B",3003, "Random Name", "Superfast@tunning.pt", new DateTime(1988, 01, 1), "Male",750, 0, false),

                new Administrative(4000,"Secretary1", "Secretary@scretaria.com", new DateTime(1984,04,18),"Female", 800, 0, false),
                new Administrative(4001,"Secretary2", "SC@Secretary.com", new DateTime(1974,04,18),"Female",925, 0, false),
                new Administrative(4002,"Secretary3", "ana@gmail.com", new DateTime(1984,04,18),"Female", 800, 0, false),
                new Administrative(4003,"Secretary4", "Secretary@asdas.com", new DateTime(1984,04,18),"Female", 833, 0, false),

                new Nurse(69, 2000, "Laura Cardoso", "Laura91@iol.pt", new DateTime(1991, 09, 19), "Female",2500, 0, false),
                new Nurse(77, 2001, "Laurix", "Laurix@iol.pt", new DateTime(1991, 03, 19), "Female",2500, 0, false),
                new Nurse(7212, 2002, "Eiras L.", "l.eiras91@iol.pt", new DateTime(1991, 03, 19), "Female",2500, 0, false),
                new Nurse(12319, 2003, "Laurinda", "Laurinda@iol.pt", new DateTime(1971, 02, 19), "Male",2500, 0, false)
            }, new List<Team>()
            {
                new Team ("Alfa", "Braga"),
                new Team ("Bravo", "Viana"),
                new Team ("Charlie", "Porto"),
                new Team ("Delta", "Braga"),
                new Team ("Foxtrot", "Porto")
            }, new List<Equipment>()
            {
                new KitCleaning(100,new DateTime(2025,09,01)),
                new KitCleaning(101,new DateTime(2025,09,01)),
                new KitCleaning(102,new DateTime(2025,09,01)),
                new KitCleaning(103,new DateTime(2025,09,01)),
                new KitCleaning(104,new DateTime(2025,09,01)),
                new KitCleaning(105,new DateTime(2025,09,01)),
                new KitCleaning(106,new DateTime(2025,09,01)),

                new KitIndividualProtection(200, new DateTime(2025,10,01)),
                new KitIndividualProtection(201, new DateTime(2025,10,01)),
                new KitIndividualProtection(202, new DateTime(2025,10,01)),
                new KitIndividualProtection(203, new DateTime(2025,10,01)),
                new KitIndividualProtection(204, new DateTime(2025,10,01)),
                new KitIndividualProtection(205, new DateTime(2025,10,01)),
                new KitIndividualProtection(206, new DateTime(2025,10,01)),

                new KitScreening(300, new DateTime(2025,10,01)),
                new KitScreening(301, new DateTime(2025,10,01)),
                new KitScreening(302, new DateTime(2025,10,01)),
                new KitScreening(303, new DateTime(2025,10,01)),
                new KitScreening(304, new DateTime(2025,10,01)),
                new KitScreening(305, new DateTime(2025,10,01)),
                new KitScreening(306, new DateTime(2025,10,01)),
                new KitScreening(307, new DateTime(2025,10,01)),

                new Veichle("AA-01-AA", 1, new DateTime(2000,10,09), "Ambulance", 123000, 123500),
                new Veichle("AA-02-AA", 2, new DateTime(2000,10,09), "Ambulance", 123000, 123500),
                new Veichle("AA-03-AA", 3, new DateTime(2000,10,09), "Ambulance", 123000, 123500),
                new Veichle("AA-04-AA", 4, new DateTime(2000,10,09), "Ambulance", 123000, 123500),
                new Veichle("AA-05-AA", 5, new DateTime(2000,10,09), "Ambulance", 123000, 123500),
                new Veichle("AA-06-AA", 6, new DateTime(2000,10,09), "Ambulance", 123000, 123500),
            }

                );

            Doctor doctorForTeamStartup = world.GetThisDoctor(1000);
            doctorForTeamStartup.IsAssigned = true;

            Nurse nurseForTeamStartup = world.GetThisNurse(2000);
            nurseForTeamStartup.IsAssigned = true;

            Driver driverForTeamStartup = world.GetThisDriver(3000);
            driverForTeamStartup.IsAssigned = true;

            Administrative administrativeForTeamStartup = world.GetThisAdministrative(4000);
            administrativeForTeamStartup.IsAssigned = true;

            Team team = world.GetThisTeam("Alfa");
            team.Doctor = doctorForTeamStartup;
            team.Nurse = nurseForTeamStartup;
            team.Driver = driverForTeamStartup;
            team.Administrative = administrativeForTeamStartup;

            KitCleaning kitCleaning = world.GetThisKitCleaning(100);
            kitCleaning.IsAssigned = true;
            team.KitCleanings.Add(kitCleaning);

            KitIndividualProtection kitIndividualProtection = world.GetThisKitIndividualProtection(200);
            kitIndividualProtection.IsAssigned = true;
            team.KitIndividualProtections.Add(kitIndividualProtection);

            KitScreening kitScreening = world.GetThisKitScreening(300);
            kitScreening.IsAssigned = true;
            team.KitScreenings.Add(kitScreening);

            Veichle veichle = world.GetThisVeichle("AA-01-AA");
            veichle.IsAssigned = true;
            team.Car = veichle;

            world.Tests.Add(new World.Test(world.GetThisPerson(5000), "Braga", new DateTime(2021, 01, 12), world.GetThisDoctor(1000), world.GetThisNurse(2001), true, "Alfa"));
            world.Tests.Add(new World.Test(world.GetThisPerson(5000), "Braga", new DateTime(2021, 01, 12), world.GetThisDoctor(1001), world.GetThisNurse(2000), true, "Alfa"));
            world.Tests.Add(new World.Test(world.GetThisPerson(5000), "Braga", new DateTime(2021, 01, 12), world.GetThisDoctor(1000), world.GetThisNurse(2003), true, "Alfa"));
            Person person1 = world.GetThisPerson(5000);
            person1.PositiveDate = (new DateTime(2021, 01, 12));
            person1.IsPositive = true;

            world.Tests.Add(new World.Test(world.GetThisPerson(5001), "Barcelos", new DateTime(2021, 01, 13), world.GetThisDoctor(1000), world.GetThisNurse(2000), true, "Bravo"));
            world.Tests.Add(new World.Test(world.GetThisPerson(5001), "Barcelos", new DateTime(2021, 01, 13), world.GetThisDoctor(1002), world.GetThisNurse(2001), true, "Alfa"));
            world.Tests.Add(new World.Test(world.GetThisPerson(5001), "Barcelos", new DateTime(2021, 01, 14), world.GetThisDoctor(1003), world.GetThisNurse(2000), true, "Alfa"));
            Person person2 = world.GetThisPerson(5001);
            person2.PositiveDate = (new DateTime(2021, 01, 16));
            person2.IsPositive = true;

            world.Tests.Add(new World.Test(world.GetThisPerson(5002), "Porto", new DateTime(2021, 01, 15), world.GetThisDoctor(1000), world.GetThisNurse(2000), true, "Alfa"));
            world.Tests.Add(new World.Test(world.GetThisPerson(5002), "Porto", new DateTime(2021, 01, 15), world.GetThisDoctor(1001), world.GetThisNurse(2001), true, "Bravo"));
            world.Tests.Add(new World.Test(world.GetThisPerson(5002), "Porto", new DateTime(2021, 01, 15), world.GetThisDoctor(1003), world.GetThisNurse(2000), true, "Alfa"));
            world.Tests.Add(new World.Test(world.GetThisPerson(5002), "Porto", new DateTime(2021, 01, 15), world.GetThisDoctor(1002), world.GetThisNurse(2002), true, "Alfa"));
            Person person3 = world.GetThisPerson(5002);
            person3.PositiveDate = (new DateTime(2021, 01, 15));
            person3.IsPositive = true;

            #endregion Initialazations

            //Main Menu of the application

            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine(" Wellcome to IPCA Covid-19 Tracker Application");
                Console.WriteLine();
                Console.WriteLine(" 1- Manage Persons List ");
                Console.WriteLine(" 2- Teams Management & Tracking ");
                Console.WriteLine(" 3- To Equipment Management ");
                Console.WriteLine(" 4- Covid-19 Related Statistics ");
                Console.WriteLine(" 0- Exit Application");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(Exceptions.Messages.InvalidData);
                    Console.ReadKey();
                    option = 9; // to continue the menu without choosing any valid case
                }

                switch (option)
                {
                    case 1:
                        {
                            int optionCase = 9;
                            while (optionCase != 0)
                            {
                                Console.Clear();
                                Console.WriteLine("1 - To Add an Citizen");
                                Console.WriteLine("2 - To Add an Doctor");
                                Console.WriteLine("3 - To Add an Nurse");
                                Console.WriteLine("4 - To Add an Driver");
                                Console.WriteLine("5 - To Add an Administratite");
                                Console.WriteLine("6 - To Remove a Person from the List");
                                Console.WriteLine();
                                Console.WriteLine("0 - To Return to Main Menu:");
                                try
                                {
                                    optionCase = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(Exceptions.Messages.InvalidData);
                                    Console.ReadKey();
                                    option = 9; // to continue the menu without choosing any valid case
                                }

                                if (optionCase == 1)
                                {
                                    world.AddCitizen();
                                }

                                if (optionCase == 2)
                                {
                                    world.AddDoctor();
                                }

                                if (optionCase == 3)
                                {
                                    world.AddNurse();
                                }

                                if (optionCase == 4)
                                {
                                    world.AddDriver();
                                }

                                if (optionCase == 5)
                                {
                                    world.AddAdministrative();
                                }

                                if (optionCase == 6)
                                {
                                    world.RemovePerson();
                                }
                            }
                        }
                        break;

                    case 2:
                        {
                            int optionCase = 1;
                            while (optionCase != 0)
                            {
                                Console.Clear();
                                Console.WriteLine("1 - To Add an New Team");
                                Console.WriteLine("2 - To Add an Element to an existing team");
                                Console.WriteLine("3 - To Remove an Element from an existing team");
                                Console.WriteLine("4 - To List Elements info sorted by team");
                                Console.WriteLine("5 - Choose a team todo Tests ");
                                Console.WriteLine("6 - To Remove a Team ");
                                Console.WriteLine();
                                Console.WriteLine("0 - To Return to Main Menu:");

                                try
                                {
                                    optionCase = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(Exceptions.Messages.InvalidData);
                                    Console.ReadKey();
                                    optionCase = 9;
                                }

                                if (optionCase == 1)
                                {
                                    world.AddEmptyTeam();
                                }
                                else if (optionCase == 2)
                                {
                                    world.AddElementToTeam();
                                }
                                else if (optionCase == 3)
                                {
                                    world.RemoveElementFromTeam();
                                }
                                else if (optionCase == 4)
                                {
                                    world.ListElementsInformationByTeam();
                                }
                                else if (optionCase == 5)
                                {
                                    world.DoTest();
                                }
                                else if (optionCase == 6)
                                {
                                    world.RemoveTeam();
                                }
                            }
                        }

                        break;

                    case 3:
                        {
                            int optionCase = 1;
                            while (optionCase != 0)
                            {
                                Console.Clear();
                                Console.WriteLine("1 - To Add new equipment to generic list ");
                                Console.WriteLine("2 - To assign an existing equipment to a team ");
                                Console.WriteLine("3 - To unssing an equipment from a team ");
                                Console.WriteLine("4 - To remove an equipment from generic list");
                                Console.WriteLine("5 - To list all equipments assigned to a team: ");
                                Console.WriteLine();
                                Console.WriteLine("0 - To Return to Main Menu:");

                                optionCase = Convert.ToInt32(Console.ReadLine());

                                if (optionCase == 1)
                                {
                                    world.AddEquipment();
                                }
                                else if (optionCase == 2)
                                {
                                    world.AssignEquipmentToTeam();
                                }
                                else if (optionCase == 3)
                                {
                                    world.UnsingEquipmentFromTeam();
                                }
                                else if (optionCase == 4)
                                {
                                    world.RemoveEquipmentFromList();
                                }
                                else if (optionCase == 5)
                                {
                                    world.ListEquipmentsAssignedToTeam();
                                }
                            }
                        }
                        break;

                    case 4:
                        {
                            int optionCase = 1;
                            while (optionCase != 0)
                            {
                                Console.Clear();
                                Console.WriteLine("1 - To Print all Tests ");
                                Console.WriteLine("2 - To Print all Tests by Region");
                                Console.WriteLine("3 - Number of Tests in the Last X days");
                                Console.WriteLine("4 - Number of Positives in the Last X days");

                                Console.WriteLine("5 - Growth % from yesterday to Today ");
                                Console.WriteLine("6 - Growth % from 1 Week to Today ");
                                Console.WriteLine("7 - Growth % from 1 Month to Today");
                                Console.WriteLine();
                                Console.WriteLine("0 - To Return to Main Menu:");

                                optionCase = Convert.ToInt32(Console.ReadLine());

                                if (optionCase == 1)
                                {
                                    world.PrintAllTests();
                                }
                                else if (optionCase == 2)
                                {
                                    world.PrintAllTestsByRegion();
                                }
                                else if (optionCase == 3)
                                {
                                    world.NumberOfTestsXDays();
                                }
                                else if (optionCase == 4)
                                {
                                    world.NumberOfPersonsPositiveInXDays();
                                }
                                else if (optionCase == 5)
                                {
                                    world.PercentageYesterday();
                                }
                                else if (optionCase == 6)
                                {
                                    world.PercentageOneWeek();
                                }
                                else if (optionCase == 7)
                                {
                                    world.PercentageOneMonth();
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}