using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PrekshyaMaui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekshyaMaui.ViewsModels
{
    public partial class PersonalInfomationViewModel: ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Person> _People;

        public PersonalInfomationViewModel()
        {
            _People = new ObservableCollection<Person>()
            {
                new Person()
                {
                    FirstName = "Prekshya",
                    LastName = "Dali",
                    Age = 20,
                    Hobbies = new List<Hobby>
                    {
                        new Hobby { Name = "Singing" },
                        new Hobby { Name = "Dancing" }
                    }
                },
                new Person
                {
                    FirstName = "Suyan",
                    LastName = "Shrestha",
                    Age = 28,
                    Hobbies = new List<Hobby>
                    {
                        new Hobby { Name = "Coding" },
                        new Hobby { Name = "Comedy" }
                    }
                }
            };
        }

        [RelayCommand]
        public async Task ShowPersonDetails(Hobby hobby)
        {
            // Finding the person associated with the hobby
            var person = People.FirstOrDefault(p => p.Hobbies.Contains(hobby));

            if (person != null)
            {
                string personDetails = $"Name: {person.FirstName} {person.LastName}\n" +
                                       $"Age: {person.Age}\n" +
                                       $"Hobbies: {string.Join(", ", person.Hobbies.Select(h => h.Name))}";

                await App.Current.MainPage.DisplayAlert("Person Details", personDetails, "OK");
            }
        }
    }
}
