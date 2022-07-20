namespace SongsProfile
{
    class  AlcoholFree : SongsProfile
    {
        public AlcoholFree(string songTitle, string language, int yearReleased, string album)
        {
            SongTitle = songTitle;
            Language = language;
            YearReleased = yearReleased;
            Album = album;
        }
    }
}