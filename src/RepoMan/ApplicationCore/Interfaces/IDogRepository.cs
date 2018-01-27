using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IDogRepository
    {
        // int NextId { get; set; }  
                                         // @49:32, Jeff got an error because all interfaces were public              
                                         //  Bill did not get the same error
        List<Dog> ListAll();      // @50:42, got the squiggly under ListAll with our without public

        Dog GetById(int id);            //@51:43, various problems ...

        void Add(Dog newDog);           // ibid

        void Edit(Dog updateDog);       // ibid

        void Delete(Dog dogToDelete);   // ibid (could choose to pass in an Id here instead of an object

        //  @52 ... originally had Dog.cs outside of directory 'Entity'
    }
}
