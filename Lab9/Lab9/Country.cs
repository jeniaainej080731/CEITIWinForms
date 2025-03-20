using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Country
    {
        // required - необходимо для заполнения
        // он будет использоваться для валидации и не позволит создать объект без этих данных
        public required string Name { get; set; }
        public required string Capital { get; set; }
        public required int Population { get; set; }
        public required string GovernmentType { get; set; }
        public required string FlagPath { get; set; }
    }
}
