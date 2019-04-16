using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Server
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        public struct AppState {
            public int integer;
            public string str;
        }

        [WebMethod]
        public string RegisterSession ()
        {
            string sessionName = RandomString(5);

            Application[sessionName] = new AppState()
            {
                integer = 0,
                str = ""
            };

            return sessionName;
        }

        [WebMethod]
        public AppState GetState (string sessionName)
        {
            return (AppState)Application[sessionName];
        }

        [WebMethod]
        public string SaveState (AppState appState, string sessionName)
        {
            Application[sessionName] = appState;

            if (Application[sessionName] != null)
                return "Data saved";
            else
                return "Data not saved";
        }
        
        private static Random random = new Random();
        private string RandomString (int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
