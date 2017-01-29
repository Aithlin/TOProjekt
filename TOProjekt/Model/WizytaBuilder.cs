using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOProjekt
{
    class WizytaBuilder
    {
        private Wizyta wizyta;

        public Wizyta Build { get { return wizyta; } }

        public WizytaBuilder()
        {
            wizyta = new Wizyta();
        }

        public WizytaBuilder SetGodzina(DateTime datetime)
        {
            wizyta.godzina = datetime;

            return this;
        }

        public WizytaBuilder SetLekarz(Lekarz lekarz)
        {
            wizyta.lekarz = lekarz;

            return this;
        }

        public WizytaBuilder SetPacjent(Pacjent pacjent)
        {
            wizyta.pacjent = pacjent;

            return this;
        }
    }
}
