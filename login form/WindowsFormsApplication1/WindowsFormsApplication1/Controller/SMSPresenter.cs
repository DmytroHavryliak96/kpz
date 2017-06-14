using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.CRUD;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.ValidateInput;

namespace WindowsFormsApplication1.Controller
{
    public class SMSPresenter
    {
        private const string username = "dmytro.havryliak@gmail.com";
        private const string password = "9hxq2";
        private const string msgsender = "4700";
        private SMS view;
        
        public SMSPresenter(SMS view)
        {
            this.view = view;
        }

        public bool CheckUserLogin(string login)
        {
            if (!ValidateUser.CheckNullOrEmpty(login))
            {
                MessageBox.Show("login must not be empty");
                return false;
            }

            return true;
        }

        public bool ChechUserSMSCode(string sms)
        {
            if (!ValidateUser.CheckNullOrEmpty(sms))
            {
                MessageBox.Show("sms code must not be empty");
                return false;
            }

            return true;
        }

        public bool CkeckSystemSMSCode()
        {
            if(view.SMSCode == null || view.SMSCode.Equals(""))
            {
                MessageBox.Show("You must get firstly the sms code");
                return false;
            }
            return true;
        }

        public bool SetSMSCode()
        {
            var login = view.getLogin();
            if (!CheckUserLogin(login))
                return false;

            CRUDBuilder builder = new CRUDBuilder();
            var instance = builder.GetCRUDByLogin(login);
            if (instance == null)
            {
                MessageBox.Show("There is no user with current login");
                return false;
            }

            Human human = instance.GetByLogin(login);
            string mobileNumber = human.Phone;

            view.SMSCode = GenerateSMSMessage().ToString();

            if(!SendSMS(mobileNumber, view.SMSCode))
            {
                view.SMSCode = null;
                MessageBox.Show("Please, retry later");
                return false;
            }

            return true;

        }

        private bool SendSMS(string destinationaddr, string message)
        {
  
            // Create ViaNettSMS object with username and password
            ViaNettSMS s = new ViaNettSMS(username, password);
            // Declare Result object returned by the SendSMS function
            ViaNettSMS.Result result;
            try
            {
                // Send SMS through HTTP API
                result = s.sendSMS(msgsender, destinationaddr, message);
                // Show Send SMS response
                if (result.Success)
                {
                    MessageBox.Show("Message successfully sent");
                    return true;
                }
                else
                {
                    MessageBox.Show("Received error: " + result.ErrorCode + " " + result.ErrorMessage);
                    return false;
                }
            }
            catch (System.Net.WebException ex)
            {
                //Catch error occurred while connecting to server.
                MessageBox.Show(ex.Message);
            }
            return true;
        }
        
        private int GenerateSMSMessage()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 101);
            return randomNumber;
        }


        public Human CheckSMSInput()
        {
            string userInputSMS = view.getSMSCode();
            string login = view.getLogin();

            if (!CkeckSystemSMSCode())
                return null;

            if (!ChechUserSMSCode(userInputSMS))
                return null;

            if (!userInputSMS.Equals(view.SMSCode))
            {
                MessageBox.Show("You enter the wrong sms text");
                return null;
            }

            CRUDBuilder builder = new CRUDBuilder();
            var instance = builder.GetCRUDByLogin(login);
            if (instance == null)
            {
                MessageBox.Show("There is no user with current login");
                return null;
            }

            Human human = instance.GetByLogin(login);

            return human;
        }
    }
}
