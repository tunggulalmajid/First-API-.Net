namespace First_API_.Net.Models
{
    public class PersonContext
    {
        public List <Person> ListPerson()
        {
            List<Person> SebuahList = new List<Person>();
            object[,] arrayPerson = new object[,]
            {
                {1, "Budi", "Jember", "Budi@gmail.com"},
                {2, "Iwan", "BWI", "Iwan@gmail.com"},
                {3, "Wati", "Lumajang", "Wati@gmail.com"},
            };

            for (int i = 0; i < arrayPerson.GetLength(0); i++)
            {
                SebuahList.Add(new Person()
                {
                    IdPerson = int.Parse(arrayPerson[i, 0].ToString()),
                    Nama = arrayPerson[i, 1].ToString(),
                    Alamat = arrayPerson[i, 2].ToString(),
                    Email = arrayPerson[i, 3].ToString()
                });
            }

            return SebuahList;
        }

        public Person GetDataPerson(int id)
        {
            Person person = new Person();
            List<Person> ListPerson = this.ListPerson();
            Person TargetPerson = ListPerson.FirstOrDefault(p => p.IdPerson == id);

            return TargetPerson;
        }
    }
}
