namespace TwiceProfile 
{
    class  TwiceProfile
    {
        private string _stageName = "";
        private string _birthName = "";
        private string _nationality = "";
        private string _birthPlace = "";
        private string _position = "";
        private string _birthDate = "";
        private int _age = 0;
        private int _height = 0;
        private string _bloodType = "";
        private string _typeMbti = "";

        public string StageName
        {
            get { return _stageName; }
            set { _stageName = value; }
        }
        public string BirthName
        {
            get { return _birthName; }
            set { _birthName = value; }
        }
        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }
        public string BirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public string BloodType
        {
            get { return _bloodType; }
            set { _bloodType = value; }
        }
        public string TypeMbti
        {
            get { return _typeMbti; }
            set { _typeMbti = value; }
        }
        public override string ToString()
        {
            return("\nStage Name: " + StageName + "\nBirth Name: " + BirthName + "\nNationality: " + Nationality + "\nBirth Place: " + BirthPlace + "\nPosition: " + Position + "\nBirth Date: " + BirthDate + "\nAge: " + Age + "\nHeight (in cm): " + Height + "\nBlood Type: " + BloodType + "\nMBTI Type: " + TypeMbti + "\n");
        }
    }
}