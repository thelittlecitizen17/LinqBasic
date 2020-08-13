using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqBasic.Abstract;


namespace LinqBasic
{
    class PersonRetriver: IPersonRetriver 
    {

        public IEnumerable<int> GetMalesId(IEnumerable<Person> persons)
        {
            var result = persons.Where(person => person.PersonGender == Gender.Male).Select(id=>id.Id);


            return result;
        }

        public IEnumerable<Person> GetOddIds(IEnumerable<Person> persons)
        {
            var result = persons.Where(person => person.Id % 2 != 0);
            return result;
        }

        public IEnumerable<Person> OrderById(IEnumerable<Person> persons)
        {
            var result = persons.OrderBy(person => (person.Id)*(-1));
            return result;
        }

    }
}
