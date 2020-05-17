using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model
{
    class Samkørsel
    {
        #region Instance field
        private int _samkørselId;
        private string _fra;
        private string _til;
        private string _bemærkninger;
        private DateTime _dato;
        private TimeSpan _tid;
        private bool _passager;
        #endregion

        #region Constructor
        public Samkørsel(int SamkørselId, string Fra, string Til, string Bemærkninger, DateTime Dato, TimeSpan Tid, bool Passager)
        {
            _samkørselId = SamkørselId;
            _fra = Fra;
            _til = Til;
            _bemærkninger = Bemærkninger;
            _dato = Dato;
            _tid = Tid;
            _passager = Passager;
        }
        #endregion

        #region Properties
        public int samkørselId
        {
            get { return _samkørselId; }
            set { _samkørselId = value; }
        }

        public string fra
        {
            get { return _fra; }
            set { _fra = value; }
        }

        public string til
        {
            get { return _til; }
            set { _til = value; }
        }

        public string bemærkninger
        {
            get { return _bemærkninger; }
            set { _bemærkninger = value; }
        }

        public DateTime dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public TimeSpan tid
        {
            get { return _tid; }
            set { _tid = value; }
        }

        public bool passager
        {
            get { return _passager; }
            set { _passager = value; }
        }
        #endregion

        #region Method
        //public string OpretSamkørsel()
        //    // Det her er metoden hvor brugeren kan oprette en samkørsel
        //{
        //    // her skal koden stå
        //}

        //public List<Samkørsel> ListSamkørsel()
        //    // Når en samkørsel bliver oprettet vil det blive overført til en liste med andre samkørsler
        //{
        //    // her skal koden stå
        //}

        public void SletSamkørsel()
            // Hvis brugeren gerne vil have, at der skal slettes en samkørsel, så vil denne funktion hjælpe med det
        {
            // her skal koden stå
        }
        #endregion 
    }
}
