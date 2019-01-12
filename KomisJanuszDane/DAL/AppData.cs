using KomisJanuszDane.Pojazdy.Samochody.Fordy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisJanuszDane.DAL
{
    public class AppData
    {
        public List<Pojazd> Pojazdy { get; set; }

        public AppData() { Pojazdy = new List<Pojazd>(); }

        public void SeedDefaultData()
        {
            this.Pojazdy.Add(new Mustang(1972, 2000, 25));
            this.Pojazdy.Add(new Mustang(1990, 900, 30));
            this.Pojazdy.Add(new Mustang(1985, 1300, 10));
            this.Pojazdy.Add(new Mustang(2015, 1450, 10));
            this.Pojazdy.Add(new Mustang(1999, 2000, 25));

            this.Pojazdy.Add(new Ranger(1999, 200, 25));
            this.Pojazdy.Add(new Ranger(1945, 900, 30));
            this.Pojazdy.Add(new Ranger(1985, 1000, 30));
            this.Pojazdy.Add(new Ranger(2000, 1500, 80));
            this.Pojazdy.Add(new Ranger(1970, 200, 25));
        }
    }
}
