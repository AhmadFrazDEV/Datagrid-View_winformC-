namespace WindowsFormsApp4.BL
{
    public class MUser
    {
        private string data;
        private string username;
        private string sector;
        private string company;
        private string QR_code;
        private string In_Time;
        private string Out_Time;

        public MUser(string data, string username, string sector, string company, string qR_code, string in_Time, string out_Time)
        {
            this.Data = data;
            this.Username = username;
            this.Sector = sector;
            this.Company = company;
            QR_code1 = qR_code;
            In_Time1 = in_Time;
            Out_Time1 = out_Time;
        }

        public string Data { get => data; set => data = value; }
        public string Username { get => username; set => username = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Company { get => company; set => company = value; }
        public string QR_code1 { get => QR_code; set => QR_code = value; }
        public string In_Time1 { get => In_Time; set => In_Time = value; }
        public string Out_Time1 { get => Out_Time; set => Out_Time = value; }



        //private string userName;
        //private string userPassword;
        //private string userRole;

        //public string UserName { get => userName; set => userName = value; }
        //public string UserPassword { get => userPassword; set => userPassword = value; }
        //public string UserRole { get => userRole; set => userRole = value; }

        //public MUser(string userName, string userPassword, string userRole)
        //{
        //    this.UserName = userName;
        //    this.UserPassword = userPassword;
        //    this.UserRole = userRole;
        //}

        //public MUser(string userName, string userPassword)
        //{
        //    this.UserName = userName;
        //    this.UserPassword = userPassword;
        //    this.UserRole = "NA";
        //    this.UserRole = userRole;
        //}
        //public bool isAdmin()
        //{
        //    if (UserRole == "Admin")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


    }
}
