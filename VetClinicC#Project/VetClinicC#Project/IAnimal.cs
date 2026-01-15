using System;

namespace VetClinicC_Project
{
    public enum Status
    {
        Adopted,
        NotAdopted
    }

    public interface IAnimal
    {
        string Name { get; set; }
        DateTime Birthday { get; set; }
        string Breed { get; set; }
        double Weight { get; set; }
        string MedicalHistory { get; set; }
        string Color { get; set; }
        string Image { get; set; }
        Status Status { get; set; }
    }

    public class Cat : IAnimal
    {
        public Cat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color, string favoriteToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
           
            FavoriteToy = favoriteToy;
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
        public string FavoriteToy { get; set; }
    }

    public class Dog : IAnimal
    {
        public Dog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color,  string favoriteToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            
            FavoriteToy = favoriteToy;
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
        public string FavoriteToy { get; set; }
    }
}
