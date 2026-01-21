using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // Add this using directive
using QRCoder;

namespace DAY_10._2
{
    public class QR_Code_Generator
    {
        static void Main(string[] args)
        {
            //Steps for QR Code Generation in .NET
            //Step 1: Install a QR code generation library like QRCoder via NuGet
            //Step 2: Add "using QRCoder;" directive
            //Step 3: Use the following code to generate a QR code

            //Create a QR code generator instance
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            //Create QR code data from a string
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://careers.wipro.com/", QRCodeGenerator.ECCLevel.Q);

            //Create a QR code from the QR code data
            QRCode qrCode = new QRCode(qrCodeData);

            //Generate QR code as a bitmap image
            var qrCodeImage =  qrCode.GetGraphic(20);

            //Save the QR code image to a file
            qrCodeImage.Save("Wipro_Careers_QRCode.png");
        }
    }
}
