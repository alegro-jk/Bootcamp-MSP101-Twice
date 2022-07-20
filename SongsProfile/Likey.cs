namespace SongsProfile
{
    class  Likey : SongsProfile
    {
        public Likey(string songTitle, string language, int yearReleased, string album)
        {
            SongTitle = songTitle;
            Language = language;
            YearReleased = yearReleased;
            Album = album;
        }
    }
}