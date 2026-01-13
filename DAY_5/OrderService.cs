using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DAY_5
{
    class OrderService
    {
        public void PlaceOrder(int quantity)
        {
            // Case 1: Validation error
            if (quantity <= 0)
            {
                throw new ValidationException();
            }

            // Case 2: Successful order
            if (quantity > 0 && quantity <= 10)
            {
                Console.WriteLine("Order placed successfully with quantity: " + quantity);
                return;
            }

            // Case 3: Business-critical failure
            if (quantity > 10)
            {
                throw new BusinessCriticalException();
            }

            // Case 4: External failure (fallback)
            throw new IOException("External service failure: Database not reachable.");
        }
    }

    }
