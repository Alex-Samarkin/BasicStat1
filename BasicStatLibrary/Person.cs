using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatLibrary
{
    public class Person : IEquatable<Person>
    {
        [Category("Личные данные")]
        [DisplayName("Фамилия")]
        public string Name { get; set; } = "Иванов";
        [Category("Личные данные")]
        [DisplayName("Имя")]
        public string SurName { get; set; } = "Иван";
        [Category("Личные данные")]
        [DisplayName("Отчество")]
        public string LastName { get; set; } = "Иванович";
        [Category("Курс, группа")]
        [DisplayName("Курс")]
        public int Course { get; set; } = 2;
        [Category("Курс, группа")]
        [DisplayName("Группа")]
        public string Group { get; set; } = "0000-0000";
        [Category("Другое")]
        [DisplayName("Дата и время работы")]
        public DateTime dateTime { get; set; } = DateTime.Now;
        public int HashCode => GetHashCode();



        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   Name == other.Name &&
                   SurName == other.SurName &&
                   LastName == other.LastName &&
                   Course == other.Course &&
                   Group == other.Group &&
                   dateTime == other.dateTime;
        }

        public override int GetHashCode()
        {
            var hashCode = -356116846;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SurName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + Course.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Group);
            //hashCode = hashCode * -1521134295 + dateTime.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
