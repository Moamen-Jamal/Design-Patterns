using Builder.Before;

Report pdfReport = new Report("PDF","PDF Header", "PDF Footer", "PDF Content Section");
pdfReport.DisplayReport();
Console.WriteLine("------------------");

Report excelReport = new Report("Excel", "Excel Header", "Excel Footer", "Excel Content Section");
excelReport.DisplayReport();
Console.ReadKey();

//Pros of Builder Design Pattern
//You can construct objects step-by-step, defer construction steps or run steps recursively.
// You can reuse the same construction code when building various representations of products.
// Single Responsibility Principle. You can isolate complex construction code from the business logic of the product.

//Cons of Builder Design Pattern
//The overall complexity of the code increases since the pattern requires creating multiple new classes.

