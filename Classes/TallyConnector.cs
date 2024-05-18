using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TallyConnector;

//namespace HoltecTallyConn.Classes
//{
//    public class TallyConnector
//    {
       

//public class DataRetriever
//    {
//        private TallyConnector tallyConnector;

//        public DataRetriever()
//        {
//            tallyConnector = new TallyConnector();
//        }

//        public void RetrieveVouchersData()
//        {
//            try
//            {
//                tallyConnector.; // Establish connection to Tally

//                // Query to retrieve vouchers data
//                string query = @"
//                [Vouchers]
//                Type: Sales
//                Columns: $Name, $VoucherNumber, $Amount
//                Filter: $Date >= 20230101";

//                var result = tallyConnector.Execute(query);

//                if (result.IsSuccess)
//                {
//                    var vouchersData = result.ResponseData;

//                    // Process the retrieved vouchers data
//                    foreach (var voucherData in vouchersData)
//                    {
//                        string voucherName = voucherData["$Name"].ToString();
//                        string voucherNumber = voucherData["$VoucherNumber"].ToString();
//                        decimal amount = (decimal)voucherData["$Amount"];

//                        // Do something with the voucher data
//                        Console.WriteLine($"Voucher Name: {voucherName}");
//                        Console.WriteLine($"Voucher Number: {voucherNumber}");
//                        Console.WriteLine($"Amount: {amount}");
//                        Console.WriteLine();
//                    }
//                }
//                else
//                {
//                    // Handle error response
//                    Console.WriteLine($"Error: {result.ErrorMessage}");
//                }
//            }
//            catch (Exception ex)
//            {
//                // Handle the exception here, such as logging or displaying an error message
//                // Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                tallyConnector.Disconnect(); // Disconnect from Tally
//            }
//        }
//    }

//}
//}