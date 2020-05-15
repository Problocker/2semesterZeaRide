using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model
{
    class Bruger
    {
        #region Instance field
        private int _brugerId;
        private string _fornavn;
        private string _efternavn;
        private string _email;
        private string _password;
        private string _by;
        private int _postnummer;
        private string _bilmodel;
        private string _bilfarve;
        #endregion

        #region Constructor
        public Bruger(int BrugerId, string Fornavn, string Efternavn, string Email, string Password, string By, int Postnummer, string Bilmodel, string Bilfarve)
        {
            _brugerId = BrugerId;
            _fornavn = Fornavn;
            _efternavn = Efternavn;
            _email = Email;
            _password = Password;
            _by = By;
            _postnummer = Postnummer;
            _bilmodel = Bilmodel;
            _bilfarve = Bilfarve;
        }
        #endregion

        #region Properties
        public int brugerId
        {
            get { return _brugerId; }
            set { _brugerId = value; }
        }

        public string fornavn
        {
            get { return _fornavn; }
            set { _fornavn = value; }
        }

        public string efternavn
        {
            get { return _efternavn; }
            set { _efternavn = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string by
        {
            get { return _by; }
            set { _by = value; }
        }

        public int postnummer
        {
            get { return _postnummer; }
            set { _postnummer = value; }
        }

        public string bilmodel
        {
            get { return _bilmodel; }
            set { _bilmodel = value; }
        }

        public string bilfarve
        {
            get { return _bilfarve; }
            set { _bilfarve = value; }
        }
        #endregion

        #region Method
        public void OpdatereProfil()
            // Denne metode gør det muligt for brugeren at opdatere sin profil
        {
            // her skal metoden til at opdatere profilen stå
        }
        #endregion 
    }
}
