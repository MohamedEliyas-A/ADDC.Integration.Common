using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace ADDC.Integration.Common.Helper.Utilities
{
    [Serializable]
    public class Utilities
    {
        public XmlDocument GetMyAccountForUserAggr(string ADDCOracleCon, string personID, string accountID, string RecommendedBillCycleDay)
        {

            XmlDocument xmlDoc = new XmlDocument();
            GetMyAccountsResponse getMyAccountsResponse = new GetMyAccountsResponse();
            List<MyAccounts> myAccounts = new List<MyAccounts>();
            StatusResponse statusResponse = new StatusResponse();
            string AcctID, PersonID, AccountRelationshipType, MainCustomer, AutoPayStatusFlag, AutoPayStartDate, SACount, BankName, IBANNumber, RejectReason, LastDDAActivityDate, PremiseID, PremiseTypeCD, PremiseTypeE, PremiseTypeA, PremiseAddress, NBBStatus, LastBillCycleDate, BillCycleDate, AutoPayDateSuggestion;

            string AggrAcctID = "";
            string queryString = string.Empty;

            try
            {
                string whereCondition = "";
                if (personID != System.String.Empty && accountID == System.String.Empty)
                {
                    whereCondition = "PER_ID = " + "'" + personID + "'";
                }
                else if (personID == System.String.Empty && accountID != System.String.Empty)
                {
                    whereCondition = "ACCT_ID = " + "'" + accountID + "'";
                }
                else if (personID != System.String.Empty && accountID != System.String.Empty)
                {
                    whereCondition = "PER_ID = " + "'" + personID + "' AND ACCT_ID = " + "'" + accountID + "'";
                }
                else
                {
                    whereCondition = "PER_ID = " + "'" + personID + "' ACCT_ID = " + "'" + accountID + "'";
                }

                queryString = "SELECT DISTINCT ACCT_ID,PER_ID,ACCT_REL_TYPE_CD,MAIN_CUST_SW, AUTOPAY_STATUS_FLG,AUTOPAY_START_DATE,SA_COUNT_NOT_CLOSE_AND_CANCEL,BANK_NAME,IBAN_NUMBER,REJECTED_REASONS," +
                    "LAST_DDA_ACTIVITY_DATE,PREM_ID,PREM_TYPE_CD,PREM_TYPE_E,PREM_TYPE_A,ADDRESS1,NBB_STATUS, (select LATEST_BILL_DATE from cm_acct_last_bill cm where cm.ACCOUNT_ID = CM_ACCT_FOR_ALLPER_APAY.ACCT_ID and rownum=1) " +
                    "AS LATEST_BILL_DATE FROM CM_ACCT_FOR_ALLPER_APAY WHERE " + whereCondition;

                using (OracleConnection connection = new OracleConnection(ADDCOracleCon))
                {
                    OracleCommand command = new OracleCommand(queryString, connection);
                    connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Always call Read before accessing data.
                            while (reader.Read())
                            {
                                //Retrieve data from Oracle DB
                                AutoPayDateSuggestion = "";
                                BillCycleDate = "";
                                string dayAutoPay = "";

                                AcctID = reader.IsDBNull(0) ? string.Empty : System.Convert.ToString(reader.GetString(0));
                                PersonID = reader.IsDBNull(1) ? string.Empty : System.Convert.ToString(reader.GetString(1));
                                AccountRelationshipType = reader.IsDBNull(2) ? string.Empty : System.Convert.ToString(reader.GetString(2));
                                MainCustomer = reader.IsDBNull(3) ? string.Empty : System.Convert.ToString(reader.GetString(3));
                                AutoPayStatusFlag = reader.IsDBNull(4) ? string.Empty : System.Convert.ToString(reader.GetString(4));
                                AutoPayStartDate = reader.IsDBNull(5) ? string.Empty : System.Convert.ToString(reader.GetString(5));
                                SACount = reader.IsDBNull(6) ? string.Empty : System.Convert.ToString(reader.GetString(6));
                                BankName = reader.IsDBNull(7) ? string.Empty : System.Convert.ToString(reader.GetString(7));
                                IBANNumber = reader.IsDBNull(8) ? string.Empty : System.Convert.ToString(reader.GetString(8));
                                RejectReason = reader.IsDBNull(9) ? string.Empty : System.Convert.ToString(reader.GetString(9));
                                //LastDDAActivityDate = reader.IsDBNull(10) ? string.Empty : System.Convert.ToString(reader.GetString(10)); -> Not Used.
                                PremiseID = reader.IsDBNull(11) ? string.Empty : System.Convert.ToString(reader.GetString(11));
                                PremiseTypeCD = reader.IsDBNull(12) ? string.Empty : System.Convert.ToString(reader.GetString(12));
                                PremiseTypeE = reader.IsDBNull(13) ? string.Empty : System.Convert.ToString(reader.GetString(13));
                                PremiseTypeA = reader.IsDBNull(14) ? string.Empty : System.Convert.ToString(reader.GetString(14));
                                PremiseAddress = reader.IsDBNull(15) ? string.Empty : System.Convert.ToString(reader.GetString(15));
                                NBBStatus = reader.IsDBNull(16) ? string.Empty : System.Convert.ToString(reader.GetString(16));
                                LastBillCycleDate = reader.IsDBNull(17) ? string.Empty : System.Convert.ToString(reader.GetString(17));

                                if (LastBillCycleDate != null && LastBillCycleDate != System.String.Empty)
                                {
                                    DateTime dtvalue = System.Convert.ToDateTime(LastBillCycleDate);
                                    BillCycleDate = dtvalue.Day.ToString();
                                    if (RecommendedBillCycleDay != System.String.Empty) { dtvalue = dtvalue.AddDays(System.Convert.ToInt32(RecommendedBillCycleDay)); }

                                    AutoPayDateSuggestion = dtvalue.Day.ToString();

                                }

                                //Create AccountList
                                if (AggrAcctID == "")
                                {
                                    AggrAcctID = "'" + AcctID + "'";
                                }
                                else
                                {
                                    AggrAcctID = AggrAcctID + "," + "'" + AcctID + "'";
                                }
                                this.AccountLists = AggrAcctID;


                                dayAutoPay = "";
                                AutoPayStatusFlag = "InActive";
                                string AutoPayAmount = "";
                                string dayOfMonth = "";
                                AutoPayStatusFlag = "InActive";

                                MyAccounts myAccount = new MyAccounts();
                                myAccount.AccountID = AcctID;
                                myAccount.PersonID = PersonID;
                                PremiseDetails premiseDetails = new PremiseDetails();
                                premiseDetails.PremiseID = PremiseID;
                                premiseDetails.PremiseAddress = PremiseAddress;
                                premiseDetails.PremiseTypeA = PremiseTypeA;
                                premiseDetails.PremiseTypeCD = PremiseTypeCD;
                                premiseDetails.PremiseTypeE = PremiseTypeE;
                                myAccount.AutoPayStatus = AutoPayStatusFlag;
                                myAccount.AutoPaySetByPersonID = PersonID;
                                myAccount.AutoPayDate = dayAutoPay;
                                myAccount.DayOfMonth = dayOfMonth;
                                myAccount.BillCycleDate = BillCycleDate;
                                myAccount.AutoPayDateSuggestion = AutoPayDateSuggestion;
                                myAccount.AutoPayAmount = AutoPayAmount;

                                myAccounts.Add(myAccount);
                            }

                        }
                        else
                        {
                            xmlDoc.LoadXml(@"<ns0:GetMyAccountsResponse xmlns:ns0='http://ADDC.Integration.Optimisation.Schemas.MyAccountsInternal'>
                                            <ns1:StatusResponse xmlns:ns1='http://ADDC.Integration.GetMyAccountsForUser.Schemas.StatusResponseInternal'>
                                            <Status>false</Status>
                                            <Code>99</Code>
                                            <Description>No Account Exists.</Description>
                                            </ns1:StatusResponse>
                                            </ns0:GetMyAccountsResponse>");
                        }
                     }
                }






                statusResponse.Code = "200";
                statusResponse.Description = "Success";


                getMyAccountsResponse.MyAccounts = myAccounts;
                getMyAccountsResponse.StatusResponse = statusResponse;



                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("GetMyAccountsResponse", "http://ADDC.Integration.GetMyAccountsForUser.Schemas.MyAccountsInternal");
                ns.Add("StatusResponse", "http://ADDC.Integration.GetMyAccountsForUser.Schemas.StatusResponseInternal");
                XPathNavigator nav = xmlDoc.CreateNavigator();
                using (XmlWriter w = nav.AppendChild())
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(GetMyAccountsResponse), new XmlRootAttribute("GetMyAccountsResponse"));
                    serializer.Serialize(w, getMyAccountsResponse, ns);
                }
                



            }
            catch (Exception)
            {

                xmlDoc.LoadXml(@"<ns0:GetMyAccountsResponse xmlns:ns0='http://ADDC.Integration.Optimisation.Schemas.MyAccountsInternal'>
                                            <ns1:StatusResponse xmlns:ns1='http://ADDC.Integration.GetMyAccountsForUser.Schemas.StatusResponseInternal'>
                                            <Status>false</Status>
                                            <Code>99</Code>
                                            <Description>InternalServiceFault</Description>
                                            </ns1:StatusResponse>
                                            </ns0:GetMyAccountsResponse>");
            }

            return xmlDoc;

        }


        #region AccountList Member
        private string accountLists;
        public string AccountLists
        {
            get
            {
                return this.accountLists;
            }
            set
            {
                this.accountLists = value;
            }
        }
        #endregion

        #region Oracle GetMyAccountsResponse Members
        public class GetMyAccountsResponse
        {
            [XmlArray("MyAccounts")]
            public List<MyAccounts> MyAccounts;
            public StatusResponse StatusResponse;
        }

        public class MyAccounts
        {
            public string AccountID;
            public string NickName;
            public string PersonID;
            public PremiseDetails PremiseDetails;
            public string AutoPayStatus;
            public string AutoPaySetByPersonID;
            public string AutoPayDate;
            public string DayOfMonth;
            public string BillCycleDate;
            public string AutoPayDateSuggestion;
            public string AutoPayAmount;
        }

        public class PremiseDetails
        {
            public string PremiseID;
            public string PremiseAddress;
            public string PremiseTypeA;
            public string PremiseTypeCD;
            public string PremiseTypeE;
            
        }
        public class StatusResponse
        {
            public string Status;
            public string Code;
            public string Description;
        }
        #endregion
    }
}
