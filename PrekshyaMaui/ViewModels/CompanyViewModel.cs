using CommunityToolkit.Mvvm.ComponentModel;
using PrekshyaMaui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekshyaMaui.ViewModels
{
    public partial class CompanyViewModel: ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Company> _Companies;

        public CompanyViewModel()
        {
            _Companies = new ObservableCollection<Company>
            {
                new Company
                {
                    Name = "TechCorp",
                    Departments = new List<Department>
                    {
                        new Department
                        {
                            Name = "Human Resources",
                            Employees = new List<Employee>
                            {
                                new Employee { Name = "Prekshya", Position = "Dotnet" },
                                new Employee { Name = "Ajay", Position = "Lead" }
                            }
                        },
                        new Department
                        {
                            Name = "Development",
                            Employees = new List<Employee>
                            {
                                new Employee { Name = "Suyan", Position = "Developer" },
                                new Employee { Name = "Bitisha", Position = "Co-lead" }
                            }
                        }
                    }
                },
                new Company
                {
                    Name = "Random",
                    Departments = new List<Department>
                    {
                        new Department
                        {
                            Name = "Sales",
                            Employees = new List<Employee>
                            {
                                new Employee { Name = "Sambandha", Position = "Pilot" },
                                new Employee { Name = "Asbin", Position = "Stylist" }
                            }
                        },
                        new Department
                        {
                            Name = "Support",
                            Employees = new List<Employee>
                            {
                                new Employee { Name = "Manish", Position = "Singer" },
                                new Employee { Name = "Swornim", Position = "Designer" }
                            }
                        }
                    }
                }
            };
        }
    }
}
