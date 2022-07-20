namespace SongsProfile
{
    class  HeartShaker : SongsProfile
    {
        public HeartShaker(string songTitle, string language, int yearReleased, string album)
        {
            SongTitle = songTitle;
            Language = language;
            YearReleased = yearReleased;
            Album = album;
        }
    }
}