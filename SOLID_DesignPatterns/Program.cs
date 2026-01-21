using System;

namespace SOLID_DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =====================================================
            // SINGLE RESPONSIBILITY PRINCIPLE (SRP)
            // =====================================================
            ReportGenerator generator = new ReportGenerator();
            Report report = generator.GenerateReport();

            ReportSaver saver = new ReportSaver();
            saver.SaveReport(report);

            // =====================================================
            // OPEN / CLOSED PRINCIPLE (OCP)
            // =====================================================
            IReportFormatter formatter = new PdfReportFormatter();
            string formattedReport = formatter.Format(report);
            Console.WriteLine(formattedReport);

            // =====================================================
            // LISKOV SUBSTITUTION PRINCIPLE (LSP)
            // =====================================================
            BaseReport salesReport = new SalesReport();
            BaseReport financeReport = new FinanceReport();

            Console.WriteLine(salesReport.GetReportType());
            Console.WriteLine(financeReport.GetReportType());

            // =====================================================
            // INTERFACE SEGREGATION PRINCIPLE (ISP)
            // =====================================================
            IPrintableReport printable = new PrintableReport();
            printable.Print();

            IExportableReport exportable = new ExportableReport();
            exportable.Export();

            // =====================================================
            // DEPENDENCY INVERSION PRINCIPLE (DIP)
            // =====================================================
            IReportService reportService = new ReportService(formatter);
            reportService.ProcessReport();

            // =====================================================
            // SINGLETON PATTERN
            // =====================================================
            Logger logger = Logger.Instance;
            logger.Log("Logger singleton is working");

            // =====================================================
            // FACTORY PATTERN
            // =====================================================
            DocumentFactory factory = new DocumentFactory();

            IDocument pdfDoc = factory.CreateDocument("PDF");
            Console.WriteLine(pdfDoc.GetDocumentType());

            IDocument wordDoc = factory.CreateDocument("WORD");
            Console.WriteLine(wordDoc.GetDocumentType());

            // =====================================================
            // OBSERVER PATTERN
            // =====================================================
            WeatherStation station = new WeatherStation();

            IObserver display1 = new WeatherDisplay();
            IObserver display2 = new WeatherDisplay();

            station.Register(display1);
            station.Register(display2);

            station.SetTemperature(28);
            station.SetTemperature(32);
        }
    }
}

