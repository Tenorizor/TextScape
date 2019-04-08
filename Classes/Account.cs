using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextScape
{
    class Account
    {
        private string user;
        private string pass;

        public Account(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public string getUser()
        {
            return user;
        }
        public string getPass()
        {
            return pass;
        }


        public bool findAccount()
        {
            string path = @"\\swgdevdc01\student_data\ACITTADINO\Documents\Year 2\End of Year Project\TextScape\TextScape\UserData.txt";
            var list = new List<String>();
            using (StreamReader file = File.OpenText(path))
            {
                string s = "";
                while ((s = file.ReadLine()) != null)
                {
                    list.Add(s);
                }
            }
            char parse = ' ';
            for(int a = 0; a < list.Count; a++)
            {
                string[] temp = list[a].Split(parse);
                if(user == temp[0] && pass == temp[1])
                    return true;
            }
            return false;
        }
    }
}
