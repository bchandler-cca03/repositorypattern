using ApplicationCore;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class DogRepositoryFs : IDogRepository
    {   
        public static int NextId = 1;
        
        private static List<Dog> _dogs;

        public DogRepositoryFs()
        {
            if(_dogs == null)
            {
                _dogs = new List<Dog>();
            }
        }
        
        public void Add(Dog newDog)
        {

            newDog.Id = NextId++;
            _dogs.Add(newDog);
        }

        public void Delete(Dog dogToDelete)
        {
            var dog = _dogs.Find(d => d.Id == dogToDelete.Id);
            _dogs.Remove(dog);

        }

        public void Edit(Dog updateDog)
        {

            var dog = _dogs.Find(d => d.Id == updateDog.Id);

            dog.Breed = updateDog.Breed;
            dog.Name = updateDog.Name;
            dog.Id = updateDog.Id;

        }

        public Dog GetById(int id)
        {
            // return to 1:26
            return _dogs.Find(d => d.Id == id);

        }

        public List<Dog> ListAll()
        {
            return _dogs;
        }
    }
}
