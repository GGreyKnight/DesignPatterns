using TemplateMethod;

var pdfGenerator = new PdfGenerator();

Console.WriteLine("** PDF **");
pdfGenerator.GenerateReport();

Console.WriteLine("** CSV **");
var csvGenerator = new CsvGenerator();
csvGenerator.GenerateReport();