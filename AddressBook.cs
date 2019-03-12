
using System;
using System.Collections.Generic;

namespace addressbook {
public class AddressBook
    {
        public Dictionary<string, Contact> addressBook {get; set;} = new Dictionary<string, Contact>();

         public void AddContact(Contact name) {
             try {
                addressBook.Add(name.Email, name);
                Console.WriteLine($"Contact Name: {name.FirstName}");
             } catch {
                 Console.WriteLine($"Contact {name.FirstName} already exists!");
             }
        }
        
       public Contact GetByEmail(string email){
            return addressBook[email];
        }
    }

}
