using iTextSharp.text;
using iTextSharp.text.pdf; 

Document doc = new Document(iTextSharp.text.PageSize.LETTER);

//pdf 생성 위치 : 프로젝트 경로\bin\Debug\net6.0
PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream("simple.pdf", FileMode.Create));

doc.Open();

doc.AddTitle("Simple PDF 생성 예제");
doc.AddAuthor("Kelly");
doc.AddCreationDate();

doc.Add(new Paragraph("It's been a loooooong time"));

//string batangttf = System.IO.Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), @"Fonts\BatangChe.TTF");

doc.Close();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Doc file Created!");
