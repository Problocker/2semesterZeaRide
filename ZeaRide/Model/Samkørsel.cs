using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ZeaRide.Model
{
    class Samkørsel
    {
        #region Instance field
        private int _samkørselId;
        private string _fra;
        private string _til;
        private string _bemærkninger;
        //private DateTime _dato;
        private CalendarDatePicker _dato;
        private TimePicker _tid;

        // Nikolaj ændret til deltagerID
        private int _deltagerID;
        #endregion

        #region Constructor
        public Samkørsel(int SamkørselId, string Fra, string Til, string Bemærkninger, CalendarDatePicker Dato, TimePicker Tid, int deltagerID)
        {
            _samkørselId = SamkørselId;
            _fra = Fra;
            _til = Til;
            _bemærkninger = Bemærkninger;
            _dato = Dato;
            _tid = Tid;
            _deltagerID = DeltagerID;
        }
        #endregion

        #region Constructor Default
        public Samkørsel()
        {

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

        public CalendarDatePicker dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public TimePicker tid
        {
            get { return _tid; }
            set { _tid = value; }
        }

        public int DeltagerID
        {
            get { return _deltagerID; }
            set { _deltagerID = value; }
        }
        #endregion

        #region Method

        public override string ToString()
        {
            return $"Samkørsel ID: {_samkørselId}, Fra: {_fra}, Til: {_til}, Bemærkninger: {_bemærkninger}, Dato: {_dato}, Tid: {_tid}, Deltager ID: {_deltagerID}.";
        }
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

        //public void SletSamkørsel()
            // Hvis brugeren gerne vil have, at der skal slettes en samkørsel, så vil denne funktion hjælpe med det
        //{
            // her skal koden stå
        //}
        #endregion 
    }
}
