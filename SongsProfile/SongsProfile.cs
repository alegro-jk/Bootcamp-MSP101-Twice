namespace SongsProfile
{
    class  SongsProfile
    {
        private string _songTitle = "";
        private string _language = "";
        private int _yearReleased = 0;
        private string _album = "";

        public string SongTitle
        {
            get { return _songTitle; }
            set { _songTitle = value; }
        }
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        public int YearReleased
        {
            get { return _yearReleased; }
            set { _yearReleased = value; }
        }
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }
        public override string ToString()
        {
            return("\nSong Title: " + SongTitle + "\nLanguage: " + Language + "\nYear Released: " + YearReleased + "\nFrom Album: " + Album + "\n");
        }
    }
}