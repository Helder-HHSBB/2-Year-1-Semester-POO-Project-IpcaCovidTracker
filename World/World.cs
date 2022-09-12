using IpcaCovidTracker.Entities;
using IpcaCovidTracker.Material;
using IpcaCovidTracker.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace IpcaCovidTracker.World
{
    internal class World
    {
        public World(List<Person> persons, List<Team> teams, List<Equipment> equipments)
        {
            this.Persons = persons;
            this.Teams = teams;
            this.Equipments = equipments;
            this.Tests = new List<Test>();
        }

        public List<Equipment> Equipments { get; set; }
        private List<Person> Persons { get; set; }
        public List<Team> Teams { get; set; }
        public List<Test> Tests { get; set; }

        // AddAdministrative(), AddCitizen(), AddDoctor(), AddNurse(), AddDriver();

        #region Add Persons

        /// <summary>
        /// Use this method to add an administrative to the List of Persons..
        /// </summary>
        public void AddAdministrative()

        {
            try
            {
                Console.WriteLine("Administrative CC: ");
                int administrativeCc = Convert.ToInt32(Console.ReadLine());

                if (this.Persons.Exists(person => person.Cc.Equals(administrativeCc)))
                {
                    Console.WriteLine("There is already a Person with this CC ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Administrative Name: ");
                    string administrativeName = Console.ReadLine();

                    Console.WriteLine("Administrative Email: ");
                    string administrativeEmail = Console.ReadLine();

                    Console.WriteLine("year of Birth: ");
                    int administrativeYearBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Monht of Birth: ");
                    int administrativeMonthBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Day of Birth: ");
                    int administrativeDayBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Administrative Gender: ");
                    string administrativeGender = Console.ReadLine();

                    Console.WriteLine("Administrative Wage: ");
                    float administrativeWage = Convert.ToSingle(Console.ReadLine());

                    Persons.Add(new Administrative(administrativeCc, administrativeName, administrativeEmail, new DateTime(administrativeYearBirth, administrativeMonthBirth, administrativeDayBirth), administrativeGender, administrativeWage, 0, false));
                    Console.WriteLine("Administrative added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to add an citizen to the main List of Persons
        /// </summary>
        public void AddCitizen()

        {
            Console.WriteLine("Citizen CC: ");
            try
            {
                int citizenCc = Convert.ToInt32(Console.ReadLine());
                if (this.Persons.Exists(person => person.Cc.Equals(citizenCc)))
                {
                    Console.WriteLine("There is already a Person with this CC ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Citizen Name: ");
                    string citizenName = Console.ReadLine();

                    Console.WriteLine("Citizen Email: ");
                    string citizenEmail = Console.ReadLine();

                    Console.WriteLine("year of Birth: ");
                    int citizenYearBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Monht of Birth: ");
                    int citizenMonthBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Day of Birth: ");
                    int citizenDayBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Citizen Gender: ");
                    string citizenGender = Console.ReadLine();

                    Persons.Add(new Citizen(citizenCc, citizenName, citizenEmail, new DateTime(citizenYearBirth, citizenMonthBirth, citizenDayBirth), citizenGender, 0, false));
                    Console.WriteLine("Citizen added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to add an doctor to the program
        /// </summary>
        public void AddDoctor()

        {
            try
            {
                Console.WriteLine("Doctor CC: ");
                int doctorCc = Convert.ToInt32(Console.ReadLine());

                if (this.Persons.Exists(person => person.Cc.Equals(doctorCc)))
                {
                    Console.WriteLine("There is already a Person with this CC ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Doctor License: ");
                    int doctorLicense = Convert.ToInt32(Console.ReadLine());

                    List<Doctor> doctors = GetDoctors();

                    if (doctors.Exists(doctor => doctor.DoctorLicense.Equals(doctorLicense)))
                    {
                        Console.WriteLine("There is already a Doctor with this License ");
                        Console.ReadKey();
                        return;
                    }

                    Console.WriteLine("Doctor Name: ");
                    string doctorName = Console.ReadLine();

                    Console.WriteLine("Doctor Email: ");
                    string doctorEmail = Console.ReadLine();

                    Console.WriteLine("year of Birth: ");
                    int doctorYearBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Monht of Birth: ");
                    int doctorMonthBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Day of Birth: ");
                    int doctorDayBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Doctor Gender: ");
                    string doctorGender = Console.ReadLine();

                    Console.WriteLine("Doctor Wage: ");
                    float doctorWage = Convert.ToSingle(Console.ReadLine());

                    Persons.Add(new Doctor(doctorLicense, doctorCc, doctorName, doctorEmail, new DateTime(doctorYearBirth, doctorMonthBirth, doctorDayBirth), doctorGender, doctorWage, 0, false));
                    Console.WriteLine("Doctor added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to add a new nurse to the program.
        /// </summary>
        public void AddNurse()

        {
            try
            {
                Console.WriteLine("Nurse CC: ");
                int nurseCc = Convert.ToInt32(Console.ReadLine());

                if (this.Persons.Exists(person => person.Cc.Equals(nurseCc)))
                {
                    Console.WriteLine("There is already a Person with this CC ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Nurse License: ");
                    int nurseLicense = Convert.ToInt32(Console.ReadLine());

                    List<Nurse> nurses = GetNurses();

                    if (nurses.Exists(nurse => nurse.NurseLicense.Equals(nurseLicense)))
                    {
                        Console.WriteLine("There is already a Nurse with this License ");
                        Console.ReadKey();
                        return;
                    }

                    Console.WriteLine("Nurse Name: ");
                    string nurseName = Console.ReadLine();

                    Console.WriteLine("Nurse Email: ");
                    string nurseEmail = Console.ReadLine();

                    Console.WriteLine("year of Birth: ");
                    int nurseYearBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Monht of Birth: ");
                    int nurseMonthBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Day of Birth: ");
                    int nurseDayBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Doctor Gender: ");
                    string nurseGender = Console.ReadLine();

                    Console.WriteLine("Doctor Wage: ");
                    float nurseWage = Convert.ToSingle(Console.ReadLine());

                    Persons.Add(new Doctor(nurseLicense, nurseCc, nurseName, nurseEmail, new DateTime(nurseYearBirth, nurseMonthBirth, nurseDayBirth), nurseGender, nurseWage, 0, false));
                    Console.WriteLine("Doctor added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to add an driver to the program
        /// </summary>
        public void AddDriver()

        {
            try
            {
                Console.WriteLine("Driver CC: ");
                int driverCc = Convert.ToInt32(Console.ReadLine());

                if (this.Persons.Exists(person => person.Cc.Equals(driverCc)))
                {
                    Console.WriteLine("There is already a Person with this CC ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Driver License: ");
                    int driverLicense = Convert.ToInt32(Console.ReadLine());

                    List<Driver> drivers = GetDrivers();

                    if (drivers.Exists(driver => driver.DriverLicense.Equals(driverLicense)))
                    {
                        Console.WriteLine("There is already a Driver with this License ");
                        Console.ReadKey();
                        return;
                    }

                    Console.WriteLine("Driver Category: ");
                    string driverCategory = Console.ReadLine();

                    Console.WriteLine("Driver Name: ");
                    string driverName = Console.ReadLine();

                    Console.WriteLine("Driver Email: ");
                    string driverEmail = Console.ReadLine();

                    Console.WriteLine("year of Birth: ");
                    int driverYearBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Monht of Birth: ");
                    int driverMonthBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Day of Birth: ");
                    int driverDayBirth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Driver Gender: ");
                    string driverGender = Console.ReadLine();

                    Console.WriteLine("Driver Wage: ");
                    float driverWage = Convert.ToSingle(Console.ReadLine());

                    Persons.Add(new Driver(driverLicense, driverCategory, driverCc, driverName, driverEmail, new DateTime(driverYearBirth, driverMonthBirth, driverDayBirth), driverGender, driverWage, 0, false));
                    Console.WriteLine("Driver added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        #endregion Add Persons

        // Method to RemovePerson();

        #region Remove/Unsign Persons

        /// <summary>
        /// Use this method to remove a Person from List, and unsing them if they have a team.
        /// </summary>
        public void RemovePerson()
        {
            int cc;

            try
            {
                Console.WriteLine("CC number of the person to remove: ");
                cc = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }

            Person person = GetThisPerson(cc);
            if (person == null)
            {
                Console.WriteLine($"There is no Person with this CC number {cc}");
                Console.ReadKey();
            }
            else
            {
                if (person.IsAssigned == true)
                {
                    Console.WriteLine("This Person is currently assigned to a team, you really want to remove him? ");
                    Console.WriteLine("1 - Yes Remove");
                    Console.WriteLine("2- No, dont Remove");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            {
                                person.IsAssigned = false;
                                Persons.Remove(person);

                                if (person is Doctor)
                                {
                                    Team team = Teams.Find(teamMember => teamMember.Doctor == person);
                                    team.Doctor = null;
                                    Console.WriteLine($"On Team {team.TeamName} Doctor was setted has Null ");
                                    Console.ReadKey();
                                }
                                else if (person is Nurse)
                                {
                                    Team team = Teams.Find(teamMember => teamMember.Nurse == person);
                                    team.Nurse = null;
                                    Console.WriteLine($"On Team {team.TeamName} Nurse was setted has Null ");
                                    Console.ReadKey();
                                }
                                else if (person is Driver)
                                {
                                    Team team = Teams.Find(teamMember => teamMember.Driver == person);
                                    team.Driver = null;
                                    Console.WriteLine($"On Team {team.TeamName} Driver was setted has Null ");
                                    Console.ReadKey();
                                }
                                else if (person is Administrative)
                                {
                                    Team team = Teams.Find(teamMember => teamMember.Administrative == person);
                                    team.Administrative = null;
                                    Console.WriteLine($"On Team {team.TeamName} Administrative was setted has Null ");
                                    Console.ReadKey();
                                }

                                Console.WriteLine("This Person was removed.");
                            }

                            break;

                        case 2:
                            {
                                Console.WriteLine("Aborted, person was not removed");
                                Console.ReadKey();
                            }

                            break;
                    }
                }
                else
                {
                    Persons.Remove(person);
                    Console.WriteLine("This Person was removed.");
                    Console.ReadKey();
                }
            }
        }

        #endregion Remove/Unsign Persons

        // GetAdministratives(), GetCitizens(), GetDoctors(), GetDrivers(), GetNurses(),
        // GetThisAdministrative(), GetThisNurse(), GetThisPerson(), GetThisDoctor(), GetThisDriver();

        #region Get Persons

        /// <summary>
        /// Use this method to get a list of only administratives from persons list
        /// </summary>

        public List<Administrative> GetAdministratives()
        {
            List<Administrative> administratives = new List<Administrative>();

            foreach (var citizen in Persons)
            {
                if (citizen is Administrative)
                {
                    administratives.Add(citizen as Administrative);
                }
            }
            return administratives;
        }

        /// <summary>
        /// Use this method to get a list of only Citizens from persons list
        /// </summary>
        /// <returns></returns>

        public List<Citizen> GetCitizens()
        {
            List<Citizen> citizens = new List<Citizen>();

            foreach (var citizen in Persons)
            {
                if (citizen is Citizen)
                {
                    citizens.Add(citizen as Citizen);
                }
            }
            return citizens;
        }

        /// <summary>
        /// Use this method to get a list of only doctors from persons list
        /// </summary>

        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            foreach (var citizen in Persons)
            {
                if (citizen is Doctor)
                {
                    doctors.Add(citizen as Doctor);
                }
            }
            return doctors;
        }

        /// <summary>
        /// Use this method to get a list of only Drivers from persons list
        /// </summary>
        /// <returns></returns>
        public List<Driver> GetDrivers()
        {
            List<Driver> drivers = new List<Driver>();

            foreach (var citizen in Persons)
            {
                if (citizen is Driver)
                {
                    drivers.Add(citizen as Driver);
                }
            }
            return drivers;
        }

        /// <summary>
        /// Use this method to get a list of only Nurses from persons list
        /// </summary>
        /// <returns></returns>
        public List<Nurse> GetNurses()
        {
            List<Nurse> nurses = new List<Nurse>();

            foreach (var citizen in Persons)
            {
                if (citizen is Nurse)
                {
                    nurses.Add(citizen as Nurse);
                }
            }
            return nurses;
        }

        /// <summary>
        /// Use this method to search and return the Administrative you are Looking by cc number
        /// </summary>
        public Administrative GetThisAdministrative(int cc)
        {
            Person person = Persons.Find(i => i.Cc == cc);
            return (person as Administrative);
        }

        /// <summary>
        /// Use this method to search and return the Nurse you are Looking by cc number
        /// </summary>
        public Nurse GetThisNurse(int cc)
        {
            Person person = Persons.Find(i => i.Cc == cc);
            return (person as Nurse);
        }

        /// <summary>
        /// Use this method to search and return the Person you are Looking for
        /// </summary>
        public Person GetThisPerson(int cc)
        {
            Person person = Persons.Find(i => i.Cc == cc);
            return (person);
        }

        /// <summary>
        /// Use this method to search and return the Doctor you are Looking for by cc number
        /// </summary>
        public Doctor GetThisDoctor(int cc)
        {
            Person person = Persons.Find(i => i.Cc == cc);
            return (person as Doctor);
        }

        /// <summary>
        /// Use this method to search and return the Driver you are Looking for by cc number
        /// </summary>
        public Driver GetThisDriver(int cc)
        {
            Person person = Persons.Find(i => i.Cc == cc);
            return (person as Driver);
        }

        #endregion Get Persons

        //GetThisTeam(), AddElementToTeam(), ShowIfTeamHasElements(), TeamStatus(), ListElementsInformationByTeam(), ListEquipmentsAssinedToTeam(),
        //RemoveElementFromTeam(), AddEmptyTeam(), GetTeams(), RemoveTeam();

        #region Team Management

        /// <summary>
        /// Use this Method to get the team you are looking for from Teams List.
        /// </summary>
        public Team GetThisTeam(string teamName)
        {
            Team team = Teams.Find(i => i.TeamName == teamName);
            return (team);
        }

        /// <summary>
        /// Use this method to add an element (without a team) to a free team.
        /// </summary>
        public void AddElementToTeam()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Team name where you want to add an element?");
                string teamName = Console.ReadLine();

                Team team = Teams.Find(i => i.TeamName == teamName);

                if (team != null)
                {
                    int option = 1;
                    Console.WriteLine("The team was found");
                    Console.ReadKey();

                    ShowIfTeamHasElements(team);

                    if (team.Doctor != null && team.Nurse != null && team.Driver != null && team.Administrative != null)
                    {
                        Console.WriteLine("This team is full, you cant add anyone else, please remove someone first.");
                        Console.ReadKey();
                        return;
                    }

                    while (option != 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"Team {team.TeamName}");
                        Console.WriteLine("1- to Add a doctor to this team");
                        Console.WriteLine("2- to Add a nurse to this team");
                        Console.WriteLine("3- to Add a doctor to this team");
                        Console.WriteLine("4- to Add a administrative to this team");
                        Console.WriteLine("0- Return");

                        option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                {
                                    if (team.Doctor != null)
                                    {
                                        Console.WriteLine("You cant add a Doctor, you need to remove the doctor assigned first");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                        Console.WriteLine($"Say the CC of the doctor you want to add to {team.TeamName}");
                                    int cc = Convert.ToInt32(Console.ReadLine());
                                    Doctor doctor = GetThisDoctor(cc);
                                    if (doctor != null)
                                    {
                                        if (doctor.IsAssigned == true)
                                        {
                                            Console.WriteLine($"{doctor.Name} Is already assigned to a team, you need to free him first.");
                                            Console.ReadKey();
                                            break;
                                        }

                                        team.Doctor = doctor;
                                        team.Doctor.IsAssigned = true;

                                        Console.WriteLine($"Doctor{doctor.Name} Added to {team.TeamName}");
                                    }
                                    else Console.WriteLine("This CC number does not correspond to a Doctor in our List");
                                }
                                break;

                            case 2:
                                {
                                    if (team.Nurse != null)
                                    {
                                        Console.WriteLine("You cant add a Nurse, you need to remove the nurse assigned first");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                        Console.WriteLine($"Say the CC of the nurse you want to add to {team.TeamName}");
                                    int cc = Convert.ToInt32(Console.ReadLine());
                                    Nurse nurse = GetThisNurse(cc);
                                    if (nurse != null)
                                    {
                                        if (nurse.IsAssigned == true)
                                        {
                                            Console.WriteLine($"{nurse.Name} Is already assigned to a team, you need to free him first.");
                                            Console.ReadKey();
                                            break;
                                        }

                                        team.Nurse = nurse;
                                        team.Nurse.IsAssigned = true;

                                        Console.WriteLine($"Nurse{nurse.Name} Added to {team.TeamName}");
                                    }
                                    else Console.WriteLine("This CC number does not correspond to a Nurse in our List");
                                }
                                break;

                            case 3:
                                {
                                    if (team.Driver != null)
                                    {
                                        Console.WriteLine("You cant add a Driver, you need to remove the driver assigned first");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                        Console.WriteLine($"Say the CC of the driver you want to add to {team.TeamName}");
                                    int cc = Convert.ToInt32(Console.ReadLine());
                                    Driver driver = GetThisDriver(cc);
                                    if (driver != null)
                                    {
                                        if (driver.IsAssigned == true)
                                        {
                                            Console.WriteLine($"{driver.Name} Is already assigned to a team, you need to free him first.");
                                            Console.ReadKey();
                                            break;
                                        }

                                        team.Driver = driver;
                                        team.Driver.IsAssigned = true;

                                        Console.WriteLine($"Driver{driver.Name} Added to {team.TeamName}");
                                    }
                                    else Console.WriteLine("This CC number does not correspond to a Driver in our List");
                                }
                                break;

                            case 4:
                                {
                                    if (team.Administrative != null)
                                    {
                                        Console.WriteLine("You cant add a Administrative, you need to remove the administrative assigned first");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                        Console.WriteLine($"Say the CC of the administrative you want to add to {team.TeamName}");
                                    int cc = Convert.ToInt32(Console.ReadLine());
                                    Administrative administrative = GetThisAdministrative(cc);
                                    if (administrative != null)
                                    {
                                        if (administrative.IsAssigned == true)
                                        {
                                            Console.WriteLine($"{administrative.Name} Is already assigned to a team, you need to free him first.");
                                            Console.ReadKey();
                                            break;
                                        }

                                        team.Administrative = administrative;
                                        team.Administrative.IsAssigned = true;

                                        Console.WriteLine($"Administrative{administrative.Name} Added to {team.TeamName}");
                                    }
                                    else Console.WriteLine("This CC number does not correspond to a Administrative in our List");
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Couldnt find this team");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to know who has a role in that team or if that position is unfulfilled
        /// </summary>

        public void ShowIfTeamHasElements(Team team)
        {
            if (team.Doctor == null)
            {
                Console.WriteLine($"{team.TeamName} has no Doctor Assigned");
            }
            else if (team.Doctor != null)
            {
                Console.WriteLine($"{team.Doctor.Name} is the Doctor in this team");
            }

            if (team.Nurse == null)
            {
                Console.WriteLine($"{team.TeamName} has no Nurse Assigned");
            }
            else if (team.Nurse != null)
            {
                Console.WriteLine($"{team.Nurse.Name} is the Nurse in this team");
            }

            if (team.Driver == null)
            {
                Console.WriteLine($"{team.TeamName} has no Driver Assigned");
            }
            else if (team.Driver != null)
            {
                Console.WriteLine($"{team.Driver.Name} is the Driver in this team");
            }

            if (team.Administrative == null)
            {
                Console.WriteLine($"{team.TeamName} has no Administrative Assigned");
            }
            else if (team.Administrative != null)
            {
                Console.WriteLine($"{team.Administrative.Name} is the Administrative in this team");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Use this method to get the team status, if the team has no equipments or all elements to perform the work assigned, they couldn't do tests
        /// </summary>

        public bool TeamStatus(Team team)
        {
            try
            {
                if (team.Doctor != null && team.Nurse != null && team.Car != null && (team.KitCleanings.Count() > 0) && (team.KitIndividualProtections.Count() > 0) && (team.KitScreenings.Count() > 0))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.EmptyOrNull);
                Console.ReadKey();
                return false;
            }
        }

        public void ListElementsInformationByTeam()
        {
            Console.Clear();
            foreach (var team in Teams)
            {
                Console.WriteLine($"Team: {team.TeamName}");
                Console.WriteLine($"Region: {team.TeamRegion}");
                if (team.Doctor == null)
                {
                    Console.WriteLine("No Doctor Assigned");
                }
                else if (team.Doctor != null)
                {
                    Console.WriteLine($"Name : {team.Doctor.Name} is Doctor with Wage: {team.Doctor.DoctorWage}");
                }

                if (team.Nurse == null)
                {
                    Console.WriteLine("No Nurse Assigned");
                }
                else if (team.Nurse != null)
                {
                    Console.WriteLine($"Name : {team.Nurse.Name} is Nurse with Wage: {team.Nurse.NurseWage}");
                }

                if (team.Driver == null)
                {
                    Console.WriteLine("No Driver Assigned");
                }
                else if (team.Driver != null)
                {
                    Console.WriteLine($"Name : {team.Driver.Name} is Driver with Wage: {team.Driver.DriverWage}");
                }

                if (team.Administrative == null)
                {
                    Console.WriteLine("No Administrative Assigned");
                }
                else if (team.Administrative != null)
                {
                    Console.WriteLine($"Name : {team.Administrative.Name} is Administrative with Wage: {team.Administrative.AdministrativeWage}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Use this method to get the report of the equipments assigned to a particular team
        /// </summary>
        public void ListEquipmentsAssignedToTeam()
        {
            try
            {
                Console.WriteLine("Team name where you wich to list all equipment assigned: ");
                string teamName = Console.ReadLine();

                Team team = GetThisTeam(teamName);
                if (team != null)
                {
                    if (team.Car == null) Console.WriteLine("No veichle assigned. ");
                    else Console.WriteLine($"1 Veichle {team.Car.LicensePlate}");

                    if (team.KitCleanings == null) Console.WriteLine("No Cleaning Kits. ");

                    int countKitCleaning = 0;
                    foreach (var kitCleaning in team.KitCleanings)
                    {
                        countKitCleaning++;
                        Console.WriteLine($"Cleaning Kit: {kitCleaning.EquipmentCode} ");
                    }
                    Console.WriteLine($"Total Cleaning kitt {countKitCleaning}");

                    int countKitIndividualProtection = 0;
                    foreach (var kitIndividualProtection in team.KitIndividualProtections)
                    {
                        countKitIndividualProtection++;
                        Console.WriteLine($"IndividualProtection Kit: {kitIndividualProtection.EquipmentCode} ");
                    }
                    Console.WriteLine($"Total IndividualProtection kitt {countKitIndividualProtection}");

                    int countKitScreening = 0;
                    foreach (var kitScreening in team.KitScreenings)
                    {
                        countKitScreening++;
                        Console.WriteLine($"Screening Kit: {kitScreening.EquipmentCode} ");
                    }
                    Console.WriteLine($"Total Screening kitt {countKitScreening}");

                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to Unsing an Element from a team.
        /// </summary>

        public void RemoveElementFromTeam()
        {
            Console.Clear();
            try
            {
                int option = 1;

                Console.WriteLine("Name of the team where you want to remove an element: ");
                string teamName = Console.ReadLine();
                Team team = GetThisTeam(teamName);

                if (team != null)
                {
                    ShowIfTeamHasElements(team);

                    if (team.Doctor == null && team.Nurse == null && team.Driver == null && team.Administrative == null)
                    {
                        Console.WriteLine("This team is Has no elements, plz add someone first.");
                        Console.ReadKey();
                        return;
                    }

                    while (option != 0)
                    {
                        Console.WriteLine("1- to Remove the Doctor ");
                        Console.WriteLine("2- to Remove the Nurse ");
                        Console.WriteLine("3- to Remove the Driver ");
                        Console.WriteLine("4- to Remove the Administrative ");
                        Console.WriteLine("0- Return");

                        option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                {
                                    if (team.Doctor == null)
                                    {
                                        Console.WriteLine("There's no Doctor in this Team");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        Doctor doctor = GetThisDoctor(team.Doctor.Cc);
                                        doctor.IsAssigned = false;
                                        team.Doctor = null;

                                        Console.WriteLine("The Doctor was removed from this team.");
                                        Console.ReadKey();
                                    }
                                }
                                break;

                            case 2:
                                {
                                    if (team.Nurse == null)
                                    {
                                        Console.WriteLine("There's no Nurse in this Team");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        Nurse nurse = GetThisNurse(team.Nurse.Cc);
                                        nurse.IsAssigned = false;
                                        team.Nurse = null;

                                        Console.WriteLine("The Nurse was removed from this team.");
                                        Console.ReadKey();
                                    }
                                }
                                break;

                            case 3:
                                {
                                    if (team.Driver == null)
                                    {
                                        Console.WriteLine("There's no Driver in this Team");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        Driver driver = GetThisDriver(team.Driver.Cc);
                                        driver.IsAssigned = false;
                                        team.Driver = null;

                                        Console.WriteLine("The Driver was removed from this team.");
                                        Console.ReadKey();
                                    }
                                }
                                break;

                            case 4:
                                {
                                    if (team.Administrative == null)
                                    {
                                        Console.WriteLine("There's no Administrative in this team");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        Administrative administrative = GetThisAdministrative(team.Administrative.Cc);
                                        administrative.IsAssigned = false;
                                        team.Administrative = null;

                                        Console.WriteLine("The Administrative was removed from this team.");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Team was not found, ");
                    Console.ReadKey();
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        public void AddEmptyTeam()
        {
            try
            {
                Console.WriteLine("Name for the new team: ");
                string teamName = Console.ReadLine();

                Console.WriteLine("Region assigned to team: ");
                string teamRegion = Console.ReadLine();

                Teams.Add(new Team(teamName, teamRegion));
                Console.WriteLine("New Empty team was created");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        public List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();

            foreach (var team in Teams)
            {
                teams.Add(team as Team);
            }
            return teams;
        }

        /// <summary>
        ///  Use this method to remove a team and free the Equipment and Elements that was there.
        /// </summary>
        public void RemoveTeam()
        {
            try
            {
                Console.WriteLine("Team name you wich to remove");
                string teamName = Console.ReadLine().Trim();

                Team team = GetThisTeam(teamName);

                if (team != null)
                {
                    if (team.Doctor != null) team.Doctor.IsAssigned = false;
                    if (team.Nurse != null) team.Nurse.IsAssigned = false;
                    if (team.Driver != null) team.Driver.IsAssigned = false;
                    if (team.Administrative != null) team.Administrative.IsAssigned = false;
                    if (team.Car != null) team.Car.IsAssigned = false;

                    if (team.KitCleanings.Count() > 0)
                    {
                        foreach (var kitCleaning in team.KitCleanings)
                        {
                            kitCleaning.IsAssigned = false;
                        }
                    }

                    if (team.KitIndividualProtections.Count() > 0)
                    {
                        foreach (var kitIndividualProtection in team.KitIndividualProtections)
                        {
                            kitIndividualProtection.IsAssigned = false;
                        }
                    }
                    if (team.KitScreenings.Count() > 0)
                    {
                        foreach (var kitScreening in team.KitScreenings)
                        {
                            kitScreening.IsAssigned = false;
                        }
                    }
                    Teams.Remove(team);
                    Console.WriteLine("Team removed and persons unsigned");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Team was not found.. returning");
                    Console.ReadKey();
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        #endregion Team Management

        // AddEquipment(), AddKitCleaning(), AddKitIndividualProtection(), AddKitScreening(), AddVeichle();

        #region Add Equipments

        /// <summary>
        /// Use this method to add equipments to Equipments List
        /// </summary>
        public void AddEquipment()
        {
            int option = 1;

            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine("Type of equipment you wich to add:");
                Console.WriteLine("1- Add a Veichle");
                Console.WriteLine("2- Add a Cleaning Kit");
                Console.WriteLine("3- Add a Individual Protection Kit");
                Console.WriteLine("4- Add a Screening Kit");
                Console.WriteLine("0- To Return.");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(Exceptions.Messages.InvalidData);
                    Console.ReadKey();
                    option = 9;
                }

                switch (option)
                {
                    case 1:
                        AddVeichle();
                        break;

                    case 2:
                        AddKitCleaning();
                        break;

                    case 3:
                        AddKitIndividualProtection();
                        break;

                    case 4:
                        AddKitScreening();
                        break;
                }
            }
        }

        /// <summary>
        /// Use this method to add a new kit of cleaning material to Equipments List.
        /// </summary>
        public void AddKitCleaning()
        {
            try
            {
                Console.WriteLine("Kit Code: ");
                int kitCode = Convert.ToInt32(Console.ReadLine());

                if (Equipments.Exists(equipment => equipment.EquipmentCode.Equals(kitCode)))
                {
                    Console.WriteLine("There is already a Equipment with this Code ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Year of expiration: ");
                    int YearExpiration = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Month of expirition: ");
                    int MonthExpiration = Convert.ToInt32(Console.ReadLine());

                    Equipments.Add(new KitCleaning(kitCode, new DateTime(YearExpiration, MonthExpiration, 1)));
                    Console.WriteLine("kit Cleaning added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to add a new kit of individual protection material to Equipments List.
        /// </summary>
        public void AddKitIndividualProtection()
        {
            try
            {
                Console.WriteLine("Kit Code: ");
                int kitCode = Convert.ToInt32(Console.ReadLine());

                if (Equipments.Exists(equipment => equipment.EquipmentCode.Equals(kitCode)))
                {
                    Console.WriteLine("There is already a Equipment with this Code ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Year of expiration: ");
                    int YearExpiration = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Month of expirition: ");
                    int MonthExpiration = Convert.ToInt32(Console.ReadLine());

                    Equipments.Add(new KitIndividualProtection(kitCode, new DateTime(YearExpiration, MonthExpiration, 1)));
                    Console.WriteLine("kit IndividualProtection added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to add a new kit of screening material to equipments List.
        /// </summary>
        public void AddKitScreening()
        {
            try
            {
                Console.WriteLine("Kit Code: ");
                int kitCode = Convert.ToInt32(Console.ReadLine());

                if (Equipments.Exists(equipment => equipment.EquipmentCode.Equals(kitCode)))
                {
                    Console.WriteLine("There is already a Equipment with this Code ");
                    Console.ReadKey();
                    return;
                }
                else

                {
                    Console.WriteLine("Year of expiration: ");
                    int YearExpiration = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Month of expirition: ");
                    int MonthExpiration = Convert.ToInt32(Console.ReadLine());

                    Equipments.Add(new KitScreening(kitCode, new DateTime(YearExpiration, MonthExpiration, 1)));
                    Console.WriteLine("kit Screening added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to add a new veichle to equipments List
        /// </summary>
        public void AddVeichle()
        {
            try
            {
                Console.WriteLine("New car license plate? ");
                string licensePlate = Console.ReadLine();

                List<Veichle> veichles = GetVeichles();

                if (veichles.Exists(veichle => veichle.LicensePlate.Equals(licensePlate)))
                {
                    Console.WriteLine("There's already a car with this license plate");
                    return;
                }
                else

                {
                    Console.WriteLine("Car equipment code: ");
                    int equipmentCode = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Model Car: ");
                    string ModelCar = Console.ReadLine();

                    Console.WriteLine("year of Revision: ");
                    int RevisionYear = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Monht of Revision: ");
                    int RevisionMonth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Starting KM for this veichle");
                    int startingKm = Convert.ToInt32(Console.ReadLine());

                    Equipments.Add(new Veichle(licensePlate, equipmentCode, new DateTime(RevisionYear, RevisionMonth, 1), ModelCar, startingKm, startingKm));
                    Console.WriteLine("Veichle added");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        #endregion Add Equipments

        //GetEquipments(), GetThisEquipment(), GetThisKitCleaning(), GetThisKitIndividualProtection(), GetThisKitScreening(),
        //GetThisVeichle(), GetVeichles(), GetVeichles();

        #region Get Equipments

        /// <summary>
        /// Use this method go get an auxiliar list of all Equipments availabe in Equipments.
        /// </summary>

        public List<Equipment> GetEquipments()
        {
            List<Equipment> equipments = new List<Equipment>();

            foreach (var equipment in Equipments)
            {
                equipments.Add(equipment as Equipment);
            }
            return Equipments;
        }

        /// <summary>
        /// Use this method to get the equipment you are looking for by is equipmentCode
        /// </summary>

        public Equipment GetThisEquipment(int equipmentCode)
        {
            Equipment equipment = Equipments.Find(i => i.EquipmentCode == equipmentCode);
            return (equipment);
        }

        /// <summary>
        /// Use this method to search for the cleaning kit you are looking for in Equipments List, by equipmentCode
        /// </summary>

        public KitCleaning GetThisKitCleaning(int equipmentCode)
        {
            Equipment kitCleaning = Equipments.Find(kit => kit.EquipmentCode == equipmentCode);

            return (kitCleaning as KitCleaning);
        }

        /// <summary>
        /// Use this method to search for the Individual Protection Kit you are looking for in Equipments List, by equipmentCode
        /// </summary>

        public KitIndividualProtection GetThisKitIndividualProtection(int equipmentCode)
        {
            Equipment kitIndividualProtection = Equipments.Find(kit => kit.EquipmentCode == equipmentCode);
            return (kitIndividualProtection as KitIndividualProtection);
        }

        /// <summary>
        /// Use this method to search for the Screening Kit you are looking for in Equipments List, by equipmentCode
        /// </summary>

        public KitScreening GetThisKitScreening(int equipmentCode)
        {
            Equipment kitScreening = Equipments.Find(kit => kit.EquipmentCode == equipmentCode);
            return (kitScreening as KitScreening);
        }

        /// <summary>
        /// Use this method to search for the Veichle you are looking for in Equipments List, by License Plate
        /// </summary>
        public Veichle GetThisVeichle(string licensePlate)
        {
            List<Veichle> veichles = GetVeichles();

            Veichle veichle = veichles.Find(car => car.LicensePlate.Equals(licensePlate));

            return (veichle);
        }

        /// <summary>
        /// Use this method to get auxiliar list of all veichles in Equipments List
        /// </summary>

        public List<Veichle> GetVeichles()
        {
            List<Veichle> Car = new List<Veichle>();
            foreach (var equipment in Equipments)
            {
                if (equipment is Veichle)
                {
                    Car.Add(equipment as Veichle);
                }
            }
            return Car;
        }

        #endregion Get Equipments

        //AssignEquipmentToTeam(), RemoveEquipmentFromList(), UnsingEquipmentFromTeam();

        #region Equipments Management

        /// <summary>
        /// Use this method to assign a free equipment from equipments list to a team.
        /// </summary>
        public void AssignEquipmentToTeam()
        {
            int option = 1;
            Team team;
            try
            {
                Console.WriteLine("In wich team you want to assign equiment?");
                string teamName = Console.ReadLine();

                team = GetThisTeam(teamName);
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }

            if (team != null)
            {
                Console.WriteLine($"Team {team.TeamName} found");
                Console.ReadKey();
                while (option != 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Team: {team.TeamName}");
                    Console.WriteLine($"Type of equipment you wich to Assign on Team: {team.TeamName}");
                    Console.WriteLine("1- Assign a Veichle");
                    Console.WriteLine("2- Assign a Cleaning Kit");
                    Console.WriteLine("3- Assign a Individual Protection Kit");
                    Console.WriteLine("4- Assign a Screening Kit");
                    Console.WriteLine("0- To Return.");
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(Exceptions.Messages.InvalidData);
                        Console.ReadKey();
                        option = 9;
                    }

                    switch (option)
                    {
                        case 1:
                            {
                                try
                                {
                                    if (team.Car != null)
                                    {
                                        Console.WriteLine($"There's already a car {team.Car.LicensePlate} assigned to this team, you need to unsigne it first");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Veichle License Plate? ");
                                        string licensePlate = Console.ReadLine();

                                        Veichle veichle = GetThisVeichle(licensePlate);
                                        if (veichle != null && veichle.IsAssigned == false && team.Car == null)
                                        {
                                            veichle.IsAssigned = true;
                                            team.Car = veichle;
                                            Console.WriteLine($"Veichle {veichle.LicensePlate} added to team {team.TeamName}.");
                                            Console.ReadKey();
                                        }
                                        else if (veichle == null || veichle.IsAssigned == false)
                                        {
                                            Console.WriteLine("This license place does not correspond to a veichle");
                                            Console.ReadKey();
                                            break;
                                        }
                                        else if (veichle != null && veichle.IsAssigned == true)
                                        {
                                            Console.WriteLine("This Veichle is already assigned to a team, you need to unsign him first");
                                            Console.ReadKey();
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(Exceptions.Messages.InvalidData);
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;

                        case 2:
                            {
                                try
                                {
                                    Console.WriteLine($"Code of the Cleaning Kit you wich to add to team {team.TeamName}");
                                    int kitCode = Convert.ToInt32(Console.ReadLine());

                                    KitCleaning kitCleaning = GetThisKitCleaning(kitCode);
                                    if (kitCleaning != null && kitCleaning.IsAssigned == false)
                                    {
                                        kitCleaning.IsAssigned = true;

                                        team.KitCleanings.Add(kitCleaning);

                                        Console.WriteLine($"KitCleaning {kitCleaning.EquipmentCode} added to team {team.TeamName}.");
                                        Console.ReadKey();
                                    }
                                    else if (kitCleaning == null || kitCleaning.IsAssigned == false)
                                    {
                                        Console.WriteLine("This kit code does not correspond to any kitCleaning");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else if (kitCleaning != null && kitCleaning.IsAssigned == true)
                                    {
                                        Console.WriteLine("This KitCleaning is already assigned to a team, you need to unsign him first");
                                        Console.ReadKey();
                                        return;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(Exceptions.Messages.InvalidData);
                                    Console.ReadKey();
                                    break; ;
                                }
                            }
                            break;

                        case 3:
                            {
                                try
                                {
                                    Console.WriteLine($"Code of the Indinvidual Protection Kit you wich to add to team {team.TeamName}");
                                    int kitCode = Convert.ToInt32(Console.ReadLine());

                                    KitIndividualProtection kitIndividualProtection = GetThisKitIndividualProtection(kitCode);
                                    if (kitIndividualProtection != null && kitIndividualProtection.IsAssigned == false)
                                    {
                                        kitIndividualProtection.IsAssigned = true;

                                        team.KitIndividualProtections.Add(kitIndividualProtection);

                                        Console.WriteLine($"KitIndividualProtection {kitIndividualProtection.EquipmentCode} added to team {team.TeamName}.");
                                        Console.ReadKey();
                                    }
                                    else if (kitIndividualProtection == null || kitIndividualProtection.IsAssigned == false)
                                    {
                                        Console.WriteLine("This kit code does not correspond to any kitIndividualProtection");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else if (kitIndividualProtection != null && kitIndividualProtection.IsAssigned == true)
                                    {
                                        Console.WriteLine("This KitIndividualProtection is already assigned to a team, you need to unsign him first");
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(Exceptions.Messages.InvalidData);
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;

                        case 4:
                            {
                                try
                                {
                                    Console.WriteLine($"Code of the Screening Kit you wich to add to team {team.TeamName}");
                                    int kitCode = Convert.ToInt32(Console.ReadLine());

                                    KitScreening kitScreening = GetThisKitScreening(kitCode);
                                    if (kitScreening != null && kitScreening.IsAssigned == false)
                                    {
                                        kitScreening.IsAssigned = true;

                                        team.KitScreenings.Add(kitScreening);

                                        Console.WriteLine($"KitScreening {kitScreening.EquipmentCode} added to team {team.TeamName}.");
                                        Console.ReadKey();
                                    }
                                    else if (kitScreening == null || kitScreening.IsAssigned == false)
                                    {
                                        Console.WriteLine("This kit code does not correspond to any kitScreening");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else if (kitScreening != null && kitScreening.IsAssigned == true)
                                    {
                                        Console.WriteLine("This KitScreening is already assigned to a team, you need to unsign him first");
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(Exceptions.Messages.InvalidData);
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Team was not Found, returning...");
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to Remove an equipment from Equipments List
        /// </summary>

        public void RemoveEquipmentFromList()
        {
            try
            {
                Console.WriteLine("Code of the equipment to remove: ");
                int equipmentCode = Convert.ToInt32(Console.ReadLine());

                Equipment equipment = GetThisEquipment(equipmentCode);

                if (equipment == null)
                {
                    Console.WriteLine($"There is no Equipment with this code number {equipmentCode}");
                    Console.ReadKey();
                }
                else
                {
                    if (equipment.IsAssigned == true)
                    {
                        Console.WriteLine("This Equipment is currently assigned to a team, you really want to remove it? ");
                        Console.WriteLine("1 - Yes Remove");
                        Console.WriteLine("2- No, dont Remove");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                {
                                    if (equipment is Veichle)
                                    {
                                        Team team = Teams.Find(teamEquipment => teamEquipment.Car == equipment);
                                        team.Car = null;
                                        Console.WriteLine($"On Team {team.TeamName} Veichle was setted has Null ");
                                        Console.ReadKey();
                                    }
                                    else if (equipment is KitCleaning)
                                    {
                                        foreach (var team in Teams)
                                        {
                                            KitCleaning kitCleaning = team.KitCleanings.Find(kit => kit.EquipmentCode == equipment.EquipmentCode);
                                            if (kitCleaning != null)
                                            {
                                                team.KitCleanings.Remove(kitCleaning);
                                                Console.WriteLine($"Kit removed from Team {team.TeamName} ");
                                            }
                                        }
                                        Console.ReadKey();
                                    }
                                    else if (equipment is KitIndividualProtection)
                                    {
                                        foreach (var team in Teams)
                                        {
                                            KitIndividualProtection kitIndividualProtection = team.KitIndividualProtections.Find(kit => kit.EquipmentCode == equipment.EquipmentCode);
                                            if (kitIndividualProtection != null)
                                            {
                                                team.KitIndividualProtections.Remove(kitIndividualProtection);
                                                Console.WriteLine($"Kit removed from Team {team.TeamName} ");
                                            }
                                        }
                                        Console.ReadKey();
                                    }
                                    else if (equipment is KitScreening)
                                    {
                                        foreach (var team in Teams)
                                        {
                                            KitScreening kitScreening = team.KitScreenings.Find(kit => kit.EquipmentCode == equipment.EquipmentCode);
                                            if (kitScreening != null)
                                            {
                                                team.KitScreenings.Remove(kitScreening);
                                                Console.WriteLine($"Kit removed from Team {team.TeamName} ");
                                            }
                                        }
                                        Console.ReadKey();
                                    }

                                    equipment.IsAssigned = false;
                                    Equipments.Remove(equipment);
                                    Console.WriteLine("This Equipment was removed.");
                                }

                                break;

                            case 2:
                                {
                                    Console.WriteLine("Aborted, equipment was not removed");
                                    Console.ReadKey();
                                }

                                break;
                        }
                    }
                    else
                    {
                        Equipments.Remove(equipment);
                        Console.WriteLine("This Equipment was removed.");
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to unsign an equipment from a team, in order to free it.
        /// </summary>
        public void UnsingEquipmentFromTeam()

        {
            try
            {
                Console.WriteLine("Code of the equipment to Unsing: ");
                int equipmentCode = Convert.ToInt32(Console.ReadLine());

                Equipment equipment = GetThisEquipment(equipmentCode);

                if (equipment == null || equipment.IsAssigned == false)
                {
                    Console.WriteLine($"There is no Equipment with this code number {equipmentCode}, or it's not assigned to any team.");
                    Console.ReadKey();
                }
                else
                {
                    if (equipment is Veichle)
                    {
                        Team team = Teams.Find(teamEquipment => teamEquipment.Car == equipment);
                        team.Car = null;
                        Console.WriteLine($"On Team {team.TeamName} Veichle was setted has Null ");
                        Console.ReadKey();
                    }
                    else if (equipment is KitCleaning)
                    {
                        foreach (var team in Teams)
                        {
                            KitCleaning kitCleaning = team.KitCleanings.Find(kit => kit.EquipmentCode == equipment.EquipmentCode);
                            if (kitCleaning != null)
                            {
                                team.KitCleanings.Remove(kitCleaning);

                                Console.WriteLine($"Kit removed from Team {team.TeamName} ");
                            }
                        }

                        Console.ReadKey();
                    }
                    else if (equipment is KitIndividualProtection)
                    {
                        foreach (var team in Teams)
                        {
                            KitIndividualProtection kitIndividualProtection = team.KitIndividualProtections.Find(kit => kit.EquipmentCode == equipment.EquipmentCode);
                            if (kitIndividualProtection != null)
                            {
                                team.KitIndividualProtections.Remove(kitIndividualProtection);

                                Console.WriteLine($"Kit removed from Team {team.TeamName} ");
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (equipment is KitScreening)
                    {
                        foreach (var team in Teams)
                        {
                            KitScreening kitScreening = team.KitScreenings.Find(kit => kit.EquipmentCode == equipment.EquipmentCode);
                            if (kitScreening != null)
                            {
                                team.KitScreenings.Remove(kitScreening);

                                Console.WriteLine($"Kit removed from Team {team.TeamName} ");
                            }
                        }
                        Console.ReadKey();
                    }

                    equipment.IsAssigned = false;
                    Console.WriteLine("This Equipment was Unsiged with success.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        #endregion Equipments Management

        // NumberOfPersonsPositiveInXDays(), NumberOfTestsXDays(), PrintAllTests(), PrintAllTestsByRegion(), PercentageYesterday(), PercentageOneWeek(), PercentageOneMonth();

        #region Covid19 Reports / Stats

        /// <summary>
        /// Use this method to get information about the number of positive tests in especific day
        /// </summary>
        public void NumberOfPersonsPositiveInXDays()
        {
            try
            {
                Console.WriteLine("How many days ago:  ");
                int daysAgo = Convert.ToInt32(Console.ReadLine());

                DateTime startingDay = DateTime.Today.AddDays(-daysAgo);
                DateTime thisDay = DateTime.Today;

                var personsPositiveBetweenDates = from person in Persons
                                                  where person.IsPositive == true && (person.PositiveDate >= startingDay) && (person.PositiveDate <= thisDay)
                                                  select person;

                Console.WriteLine($"Between {startingDay.Day}/{startingDay.Month}/{startingDay.Year} & {thisDay.Day}/{thisDay.Month}/{thisDay.Year} ");
                Console.WriteLine($"{personsPositiveBetweenDates.Count()} Persons Tested Positive.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to get information about the number of Covid19 tests performed in especific day
        /// </summary>
        public void NumberOfTestsXDays()
        {
            try
            {
                Console.WriteLine("How many days ago:  ");
                int daysAgo = Convert.ToInt32(Console.ReadLine());

                DateTime startingDay = DateTime.Today.AddDays(-daysAgo);
                DateTime thisDay = DateTime.Today;

                var numberOfTestsBetweenDates = from test in Tests
                                                where (test.DateOfTest >= startingDay) && (test.DateOfTest <= thisDay)
                                                select test;

                var numberOfPositiveTestsBetweenDates = from test in numberOfTestsBetweenDates
                                                        where test.IsPositive == true && (test.DateOfTest >= startingDay) && (test.DateOfTest <= thisDay)
                                                        select test;

                Console.WriteLine($"Between {startingDay.Day}/{startingDay.Month}/{startingDay.Year} & {thisDay.Day}/{thisDay.Month}/{thisDay.Year} ");
                Console.WriteLine($"Tests: {numberOfTestsBetweenDates.Count()}");
                Console.WriteLine($"Positives:  {numberOfPositiveTestsBetweenDates.Count()}");
                Console.WriteLine($"Negatives:  {numberOfTestsBetweenDates.Count() - numberOfPositiveTestsBetweenDates.Count()}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to get information about the total of Covid19 tests performed
        /// </summary>
        public void PrintAllTests()
        {
            Console.Clear();
            Console.WriteLine("List of all Tests perfromed until today: ");
            Console.WriteLine();
            if (Tests.Count() > 0)
            {
                foreach (var test in Tests)
                {
                    Console.WriteLine($"{test.DateOfTest.Day}/{test.DateOfTest.Month}/{test.DateOfTest.Year} Tested : {test.PersonTested.Name} Cc: {test.PersonTested.Cc} Result: {test.IsPositive} Performed by Team: {test.TeamName}, {test.Doctor.Name} & {test.Nurse.Name} in {test.Region}");
                }
            }
            else Console.WriteLine("No Tests were performed yet");
            Console.ReadKey();
        }

        /// <summary>
        /// Use this method to get information about the total of Covid19 tests performed in particular region
        /// </summary>
        public void PrintAllTestsByRegion()
        {
            Console.WriteLine("Region Name: ");
            string regionName = Console.ReadLine();

            List<Test> tests = Tests.FindAll(region => region.Region.Equals(regionName));

            if (tests.Count() > 0)
            {
                foreach (var test in tests)
                {
                    Console.WriteLine($"{test.DateOfTest.Day}/{test.DateOfTest.Month}/{test.DateOfTest.Year} Tested : {test.PersonTested.Name} Cc: {test.PersonTested.Cc} Result: {test.IsPositive} Performed by Team: {test.TeamName}, {test.Doctor.Name} & {test.Nurse.Name} in {test.Region}");
                }
                Console.WriteLine($"Total tests in this Region: {tests.Count()}");
            }
            else
            {
                Console.WriteLine("There's no Tests in this Region.");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Use this method to get the report from the percantage growth from yesterday for today.
        /// </summary>
        public void PercentageYesterday()
        {
            int diference;
            int division;
            int percentage;
            int diference1;
            int divison1;
            int percentage1;

            try
            {
                DateTime startingDay = DateTime.Today.AddDays(-1);
                DateTime thisDay = DateTime.Today;

                var numbersyesterday = from test in Tests
                                       where (test.DateOfTest == startingDay)
                                       select test;
                var numberstoday = from test in Tests
                                   where (test.DateOfTest == thisDay)
                                   select test;
                var numberOfPositiveyesterday = from test in numbersyesterday
                                                where test.IsPositive == true && (test.DateOfTest == startingDay)
                                                select test;
                var numberOfPositveToday = from test in numberstoday
                                           where test.IsPositive == true && (test.DateOfTest == thisDay)
                                           select test;

                Console.WriteLine($"Yesterday {startingDay.Day}/{startingDay.Month}/{startingDay.Year} ");
                Console.WriteLine($"Tests: {numbersyesterday.Count()}");
                Console.WriteLine($"today: {thisDay.Day}/{thisDay.Month}/{thisDay.Year}");
                Console.WriteLine($"Tests: {numberstoday.Count()}");

                diference = numbersyesterday.Count() - numberstoday.Count();
                division = diference / numberstoday.Count();
                percentage = division * 100;

                diference1 = numberOfPositiveyesterday.Count() - numberOfPositveToday.Count();
                divison1 = diference1 / numberOfPositveToday.Count();
                percentage1 = divison1 * 100;
                Console.WriteLine($"Percentage of tests in yesterday and today:{percentage}%");
                Console.WriteLine($"Percentage of indiduals that test positive:{percentage1}%");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.DivisionByZero);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to get the percentage of cases from today to 1week ago
        /// </summary>
        public void PercentageOneWeek()
        {
            int diference;
            int division;
            int percentage;
            int diference1;
            int divison1;
            int percentage1;

            try
            {
                DateTime startingDay = DateTime.Today.AddDays(-7);
                DateTime thisDay = DateTime.Today;

                var numbersoneweek = from test in Tests
                                     where (test.DateOfTest == startingDay)
                                     select test;
                var numberstoday = from test in Tests
                                   where (test.DateOfTest == thisDay)
                                   select test;
                var numberOfPositiveoneweek = from test in numbersoneweek
                                              where test.IsPositive == true && (test.DateOfTest == startingDay)
                                              select test;
                var numberOfPositveToday = from test in numberstoday
                                           where test.IsPositive == true && (test.DateOfTest == thisDay)
                                           select test;

                Console.WriteLine($"yestarday {startingDay.Day}/{startingDay.Month}/{startingDay.Year} ");
                Console.WriteLine($"Tests: {numbersoneweek.Count()}");
                Console.WriteLine($"today: {thisDay.Day}/{thisDay.Month}/{thisDay.Year}");
                Console.WriteLine($"Tests: {numberstoday.Count()}");

                diference = numbersoneweek.Count() - numberstoday.Count();
                division = diference / numberstoday.Count();
                percentage = division * 100;

                diference1 = numberOfPositiveoneweek.Count() - numberOfPositveToday.Count();
                divison1 = diference1 / numberOfPositveToday.Count();
                percentage1 = divison1 * 100;
                Console.WriteLine($"percentage of tests in one week and today:{percentage}%");
                Console.WriteLine($"percentage of indiduals that test positive into seven days:{percentage1}%");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.DivisionByZero);
                Console.ReadKey();
                return;
            }
        }

        /// <summary>
        /// Use this method to get the percentage of cases from today to 1week ago
        /// </summary>
        public void PercentageOneMonth()
        {
            int diference;
            int division;
            int percentage;
            int diference1;
            int divison1;
            int percentage1;

            try
            {
                DateTime startingDay = DateTime.Today.AddDays(-30);
                DateTime thisDay = DateTime.Today;

                var numbersonemonth = from test in Tests
                                      where (test.DateOfTest == startingDay)
                                      select test;
                var numberstoday = from test in Tests
                                   where (test.DateOfTest == thisDay)
                                   select test;
                var numberOfPositiveonemonth = from test in numbersonemonth
                                               where test.IsPositive == true && (test.DateOfTest == startingDay)
                                               select test;
                var numberOfPositveToday = from test in numberstoday
                                           where test.IsPositive == true && (test.DateOfTest == thisDay)
                                           select test;

                Console.WriteLine($"yestarday {startingDay.Day}/{startingDay.Month}/{startingDay.Year} ");
                Console.WriteLine($"Tests: {numbersonemonth.Count()}");
                Console.WriteLine($"today: {thisDay.Day}/{thisDay.Month}/{thisDay.Year}");
                Console.WriteLine($"Tests: {numberstoday.Count()}");

                diference = numbersonemonth.Count() - numberstoday.Count();
                division = diference / numberstoday.Count();
                percentage = division * 100;

                diference1 = numberOfPositiveonemonth.Count() - numberOfPositveToday.Count();
                divison1 = diference1 / numberOfPositveToday.Count();
                percentage1 = divison1 * 100;
                Console.WriteLine($"percentage of tests in one month and today:{percentage}%");
                Console.WriteLine($"percentage of indiduals that test positive into 30 days:{percentage1}%");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.DivisionByZero);
                Console.ReadKey();
                return;
            }
        }

        #endregion Covid19 Reports / Stats

        // DoTest();

        #region Do Tests

        /// <summary>
        /// use this method to perform covid test on a person, using a team.
        /// </summary>
        public void DoTest()
        {
            try
            {
                bool isPositive;
                string answer;

                Console.WriteLine("Name of the team wich will perform Tests");
                string teamName = Console.ReadLine();

                Team team = GetThisTeam(teamName);
                if (team != null)
                {
                    bool teamStatus = TeamStatus(team);

                    if (teamStatus == true && team != null)
                    {
                        Console.Clear();
                        Console.WriteLine($"Team {team.TeamName} , Doctor Testing : {team.Doctor.Name}, Nurse: {team.Nurse.Name} ");

                        Console.WriteLine("Cc of the Person being Tested: ");
                        int cc = Convert.ToInt32(Console.ReadLine());

                        Person person = GetThisPerson(cc);
                        if (person == null)
                        {
                            Console.WriteLine("There's no Person with this Cc number... returning.");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            DateTime thisDay = DateTime.Today;
                            Console.WriteLine("This Person tested Positive? yes / no ");
                            answer = Console.ReadLine().ToLower();

                            if (answer == "yes")
                            {
                                person.PositiveDate = (new DateTime(thisDay.Year, thisDay.Month, thisDay.Day));
                                person.NumberOfTimesTestCovid++;
                                person.IsPositive = true;
                                isPositive = true;
                                SendEmail(person);
                            }
                            else if (answer == "no")
                            {
                                person.NumberOfTimesTestCovid++;
                                person.IsPositive = false;
                                isPositive = false;
                            }
                            else
                            {
                                Console.WriteLine("Not a valid answer...returning for now");
                                Console.ReadKey();
                                return;
                            }

                            Tests.Add(new Test(person, team.TeamRegion, new DateTime(thisDay.Year, thisDay.Month, thisDay.Day), team.Doctor, team.Nurse, isPositive, team.TeamName));
                            Console.WriteLine("New Test was added :)");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Team has not all Elements or Equipment assigned to perform Tests.");
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Exceptions.Messages.InvalidData);
                Console.ReadKey();
                return;
            }
        }

        #endregion Do Tests

        // SendEmail();

        #region Send Email

        /// <summary>
        ///  Use this method to send an email to inform if he/she tested Positive
        /// </summary>

        public void SendEmail(Person person)
        {
            using (SmtpClient smtpClient = new SmtpClient())
            {
                var basicCredential = new NetworkCredential("ipcacovid19tracker@gmail.com", "POOipcacovid19"); //authentication
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress("ipcacovid19tracker@gmail.com");

                    smtpClient.EnableSsl = true;
                    smtpClient.Host = "smtp.gmail.com";   //Gmail web client
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = "Run, 4 Your Life";
                    // Set IsBodyHtml to true means we can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = "<h1>YOU JUST TESTED POSITIVE TO COVID19</h1>";
                    message.To.Add(person.Email);

                    try
                    {
                        smtpClient.Send(message);
                        Console.WriteLine("Email Sent, informing this person tested positive to covid19");
                        Console.ReadKey();
                    }
                    catch (Exception ex)
                    {
                        //Error, could not send the message
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                }
            }

            #endregion Send Email
        }
    }
}