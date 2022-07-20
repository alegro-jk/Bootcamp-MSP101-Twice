namespace SongsProfile
{
    class  Scientist : SongsProfile
    {
        public Scientist(string songTitle, string language, int yearReleased, string album)
        {
            SongTitle = songTitle;
            Language = language;
            YearReleased = yearReleased;
            Album = album;
        }
    }
}