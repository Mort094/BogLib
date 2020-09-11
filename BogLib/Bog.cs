using System;
using System.Collections.Generic;
using System.Text;

namespace BogLib
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _lsbn13;

        public Bog()
        {
        }

        public string Titel
        {
            get => _titel;
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException("Skal være på minimum 2 bogstaver");
                _titel = value;
            }
        }

        public string Forfatter
        {
            get => _forfatter;
            set => _forfatter = value;
        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value < 10 || 1000 < value) throw new ArgumentOutOfRangeException( "Skal være mellem 10 og 100");
                _sidetal = value;
            }
        }

        public string Lsbn13
        {
            get => _lsbn13;
            set
            {
                if (value.Length != 13) throw new ArgumentOutOfRangeException("Skal være 13 tegn lang");
                 _lsbn13 = value;
            }

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
