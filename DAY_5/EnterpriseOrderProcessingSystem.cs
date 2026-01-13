using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DAY_5
{
    class EnterpriseOrderProcessingSystem
    {
        public static void Main(String[] args)
        {
            OrderService service = new OrderService();

            try
            {
                Console.WriteLine("Enter order quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                service.PlaceOrder(quantity);
            }
            // Skip logging for validation errors
            catch (ValidationException ex)
            {
                Console.WriteLine("Validation Error: " + ex.Message);
            }
            // Log only business-critical errors
            catch (BusinessCriticalException ex) when (ex.Message.Contains("stock"))
            {
                Logger.Log(ex);
                Console.WriteLine("Business Critical Error logged.");
            }
            // Log external service failures
            catch (IOException ex)
            {
                Logger.Log(ex);
                Console.WriteLine("External Service Failure logged." + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Error: " + ex.Message);
            }
        }
    }
}
