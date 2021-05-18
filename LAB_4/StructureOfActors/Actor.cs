using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfActors
{
    public enum Role
    {
        hero,//герой
        passionate,//закоханний
        urchin,//пустун
        buffoon,//блазень
        villain,//лиходій
        incognito,//невідомий
        renegade,//відпущенець
        coxcomb,//самозакоханий
        outrunner,//вістник
        friend,//друг або подруга
        scientist,//вчений
        lawEnforcement,//страж закону
        mass//масовка
    }
    public class Actor
    {
        public string fullName { get; set; }
        public Role role { get; set; }
        public int yearOfBirth { get; set; }
        public override string ToString()
        {
            return "Full name is "+fullName+"; Role is "+role+ "; Year of birth is "+yearOfBirth;
        }
    }
}
