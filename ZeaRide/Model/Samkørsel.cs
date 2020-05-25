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
        private int _samkorselId;
        private string _fraDestination;
        private string _tilDestination;
        private string _bemaerkninger;
        //private DateTime _dato;
        private CalendarDatePicker _dato;
        private TimePicker _tid;

        // Nikolaj ændret til deltagerID
        private int _deltagerID;
        #endregion

        #region Constructor
        public Samkørsel(int samkorselId, string fra, string til, string bemaerkninger, CalendarDatePicker dato, TimePicker tid, int deltagerID)
        {
            _samkorselId = samkorselId;
            _fraDestination = fra;
            _tilDestination = til;
            _bemaerkninger = bemaerkninger;
            _dato = dato;
            _tid = tid;
            _deltagerID = deltagerID;
        }
        #endregion

        #region Constructor Default
        public Samkørsel()
        {

        }
        #endregion

        #region Properties
        public int samkorselId
        {
            get { return _samkorselId; }
            set { _samkorselId = value; }
        }

        public string fraDestination
        {
            get { return _fraDestination; }
            set { _fraDestination = value; }
        }

        public string tilDestination
        {
            get { return _tilDestination; }
            set { _tilDestination = value; }
        }

        public string bemaerkninger
        {
            get { return _bemaerkninger; }
            set { _bemaerkninger = value; }
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

        public int deltagerID
        {
            get { return _deltagerID; }
            set { _deltagerID = value; }
        }
        #endregion

        #region Method

        public override string ToString()
        {
            return $"Samkørsel ID: {_samkorselId}, Fra: {_fraDestination}, Til: {_tilDestination}, Bemærkninger: {_bemaerkninger}, Dato: {_dato}, Tid: {_tid}, Deltager ID: {_deltagerID}.";
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
