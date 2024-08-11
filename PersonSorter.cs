using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMechanism_Static
{
    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for(int j = i + 1; j < people.Length; j++)
                {
                    // Comparing people[i] and people[j] using the delegate method
                    if (comparison(people[i], people[j]) > 0)
                    {
                        // Swapping people[i] with people[j] if they are in the wrong order
                        Person temporary = people[i];
                        people[i] = people[j];
                        people[j] = temporary;
                    }
                }
            }
        }
    }
}
