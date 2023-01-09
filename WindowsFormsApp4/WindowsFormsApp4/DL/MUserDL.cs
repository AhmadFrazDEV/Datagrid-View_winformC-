using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp4.BL;

namespace WindowsFormsApp4.DL
{
    class MUserDL
    {
        private static List<MUser> usersList = new List<MUser>();

        internal static List<MUser> UsersList { get => usersList; set => usersList = value; }

        public static void addUserIntoList(MUser user)
        {
            UsersList.Add(user);
        }

        //public static MUser SignIn(MUser user)
        //{
        //    foreach (MUser storedUser in UsersList)
        //    {
        //        if (storedUser.UserName == user.UserName && storedUser.UserPassword == user.UserPassword)
        //        {
        //            return storedUser;
        //        }
        //    }
        //    return null;
        //}

        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool readDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string date = parseData(record, 1);
                    string userName = parseData(record, 2);
                    string sector = parseData(record, 3);
                    string company = parseData(record, 4);
                    string QR_code = parseData(record, 5);
                    string In_Time = parseData(record, 6);
                    string Out_Time = parseData(record, 7);
                    MUser user = new MUser(date, userName, sector , company , QR_code , In_Time , Out_Time);
                    addUserIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeUserIntoFile(MUser user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.Data + "," + user.Username + "," + user.Sector + "," +user.Company + "," + user.QR_code1 + "," + user.In_Time1 + "," + user.Out_Time1);
            file.Flush();
            file.Close();

        }

        public static void deleteUserFromList(MUser user)
        {
            for (int index = 0; index < usersList.Count; index++)
            {
                if (usersList[index].Data == user.Data && usersList[index].Username == user.Username && usersList[index].Sector == user.Sector && usersList[index].Company == user.Company && usersList[index].QR_code1 == user.QR_code1 && usersList[index].In_Time1 == user.In_Time1 && usersList[index].Out_Time1 == user.Out_Time1)
                {
                    usersList.RemoveAt(index);
                }
            }

        }

        public static void EditUserFromList(MUser previous, MUser updated)
        {
            foreach (MUser user in usersList)
            {
                if (previous.Data == user.Data && previous.Username == user.Username && previous.Sector == user.Sector && previous.Company == user.Company && previous.QR_code1 == user.QR_code1 && previous.In_Time1 == user.In_Time1 && previous.Out_Time1 == user.Out_Time1)
                {
                    user.Data = updated.Data;
                    user.Username = updated.Username;
                    user.Sector = updated.Sector;
                    user.Company = updated.Company;
                    user.QR_code1 = updated.QR_code1;
                    user.In_Time1 = updated.In_Time1;
                    user.Out_Time1 = updated.Out_Time1;
                }
            }

        }
        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (MUser user in UsersList)
            {

                file.WriteLine(user.Data + "," + user.Username + "," + user.Sector + "," + user.Company + "," + user.QR_code1 + "," + user.In_Time1 + "," + user.Out_Time1);
            }
            file.Flush();
            file.Close();

        }
    }
}
