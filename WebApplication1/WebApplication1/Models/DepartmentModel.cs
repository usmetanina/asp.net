using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InfoModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class EmployeeModel : InfoModel
    {
        public int Age { get; set; }

        public EmployeeModel(string name, int age, string phone)
        {
            Name = name;
            Age = age;
            Phone = phone;
        }
    }

    public class DepartmentModel : InfoModel
    {
        public int СountEmployees { get { return DepartmentsWithEmployees.Count; }}
        public string Address { get; set; }
        public List<InfoModel> DepartmentsWithEmployees { get; set; }

        public DepartmentModel(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public static DepartmentModel TmpData()
        {
            return new DepartmentModel("Main office", "Chelyabinsk", "93515245698")
            {
                DepartmentsWithEmployees = new List<InfoModel>()
                {
                    new DepartmentModel("Derartment#1", "Miass", "93515269845")
                    {
                        DepartmentsWithEmployees = new List<InfoModel>()
                        {
                            new EmployeeModel("Charly", 31, "8800888242"),
                            new DepartmentModel("Derartment#1.1", "Spb", "93515269845")
                            {
                                DepartmentsWithEmployees = new List<InfoModel>()
                                {
                                    new EmployeeModel("Piter", 21, "88008889263"),
                                    new EmployeeModel("Oly", 39, "8800896322")
                                }
                            },
                            new DepartmentModel("Derartment#1.2", "Miass", "93515269845")
                            {
                                DepartmentsWithEmployees = new List<InfoModel>()
                                {
                                    new EmployeeModel("Kate", 25, "88008889263")
                                }
                            }
                        }
                    },

                     new DepartmentModel("Derartment#2", "Msk", "93515269845")
                    {
                        DepartmentsWithEmployees = new List<InfoModel>()
                        {
                            new EmployeeModel("Charly", 31, "8800888242"),
                            new EmployeeModel("Charly", 31, "8800888242"),
                            new EmployeeModel("Charly", 31, "8800888242"),
                            new DepartmentModel("Derartment#2.1", "Spb", "93515269845")
                            {
                                DepartmentsWithEmployees = new List<InfoModel>()
                                {
                                    new EmployeeModel("Piter", 21, "88008889263"),
                                    new EmployeeModel("Oly", 39, "8800896322")
                                }
                            },
                            new DepartmentModel("Derartment#2.2", "Miass", "93515269845")
                            {
                                DepartmentsWithEmployees = new List<InfoModel>()
                                {
                                    new EmployeeModel("Kate", 25, "88008889263")
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}