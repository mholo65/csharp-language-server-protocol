namespace OmniSharp.Extensions.LanguageServer.Protocol.Models
{
    public struct BooleanString
    {
        private string _string;
        private bool? _bool;
        public BooleanString(string value)
        {
            _string = value;
            _bool = null;
        }
        public BooleanString(bool value)
        {
            _string = null;
            _bool = value;
        }

        public bool IsString => _string != null;
        public string String
        {
            get => _string;
            set
            {
                _string = value;
                _bool = null;
            }
        }

        public bool IsBool => _bool.HasValue;
        public bool Bool
        {
            get => _bool.HasValue && _bool.Value;
            set
            {
                String = null;
                _bool = value;
            }
        }

        public static implicit operator BooleanString(string value)
        {
            return new BooleanString(value);
        }

        public static implicit operator BooleanString(bool value)
        {
            return new BooleanString(value);
        }
    }
}
