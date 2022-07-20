namespace SongsProfile
{
    class  Fancy : SongsProfile
    {
        public Fancy(string songTitle, string language, int yearReleased, string album)
        {
            SongTitle = songTitle;
            Language = language;
            YearReleased = yearReleased;
            Album = album;
        }
    }
}