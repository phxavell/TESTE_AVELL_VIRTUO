using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

using Spire.Xls;
using Spire.Xls.Core;
using Spire.Xls.Core.Spreadsheet;

//Referencias de Pesquisa
//https://www.devmedia.com.br/criando-copiando-movendo-e-excluindo-arquivos-em-net/24494 - referencia
//https://balta.io/blog/csharp-manipulacao-arquivos
//https://social.msdn.microsoft.com/Forums/pt-BR/a3d2fec1-590b-4ce2-b54f-f95d3e90cf11/como-ler-um-arquivo-txt-e-procurar-uma-linha-por-palavra-chave?forum=vscsharppt

namespace TESTE_MAQUINAS
{
    internal class RelatorioExcel
    {

        ////Ajustar este método que trouxe do form
        //public void RelatorioExcel()
        //{
        //    ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
        //    ManagementObjectCollection collection = mSearcher.Get();
        //    foreach (ManagementObject obj in collection)
        //    {
        //        //Dll: System.Management.dll - Para conseguir informações da BIOS
        //        string NomeArquivo = (string)obj["SerialNumber"];

        //        //Aqui cria o arquivo Excel com todos os efeitos.
        //        Workbook workbook = new Workbook();
        //        workbook.Worksheets.Clear();
        //        Worksheet worksheet = workbook.Worksheets.Add("RELATORIO");
        //        string[] oneDimensionalArray = new string[] { "RELATÓRIO AVELL DE SISTEMA DE TESTES FUNCIONAIS" };
        //        worksheet.InsertArray(oneDimensionalArray, 2, 4, false);

        //        //Somente para inserir o seria da máquina
        //        string[,] SERIALDimensionalArray = new string[,]{
        //        {"NÚMERO DE SÉRIE: __" + NomeArquivo}
        //    };
        //        worksheet.InsertArray(SERIALDimensionalArray, 2, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] twoDimensionalArray = new string[,]{
        //        {"TESTE 1 - FURMARK/BURN-IN:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(twoDimensionalArray, 5, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] threeDimensionalArray = new string[,]{
        //        {"TESTE 2 - TECLADO:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(threeDimensionalArray, 10, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] fourDimensionalArray = new string[,]{
        //        {"TESTE 3 - CUSTOM CONTROL:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(fourDimensionalArray, 15, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] fiveDimensionalArray = new string[,]{
        //        {"TESTE 4 - TOUCH PAD:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(fiveDimensionalArray, 20, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] sixDimensionalArray = new string[,]{
        //        {"TESTE 5 - USB:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(sixDimensionalArray, 25, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] sevenDimensionalArray = new string[,]{
        //        {"TESTE 6 - WEBCAM:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(sevenDimensionalArray, 30, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] eightDimensionalArray = new string[,]{
        //        {"TESTE 7 - LCD:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(eightDimensionalArray, 35, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] nineDimensionalArray = new string[,]{
        //        {"TESTE 8 - AUDIO:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(nineDimensionalArray, 40, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] tenDimensionalArray = new string[,]{
        //        {"TESTE 9 - WI-FI:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(tenDimensionalArray, 45, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] elevenDimensionalArray = new string[,]{
        //        {"TESTE 10 - HDMI:"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(elevenDimensionalArray, 50, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        string[,] twelveDimensionalArray = new string[,]{
        //        {"TESTE 11 - WINAUDIT:"},
        //        {"OBS: ÚLTIMO TESTE"},
        //        {"APROVADO:"},
        //        {"RETESTADO:"},
        //        {"REPROVADO:"}
        //    };
        //        worksheet.InsertArray(twelveDimensionalArray, 55, 1);
        //        worksheet.AllocatedRange.AutoFitColumns();

        //        //Aqui são as bordas das células:
        //        Worksheet sheet = workbook.Worksheets[0];
        //        worksheet.Range["A2:E2"].Style.Color = Color.DarkGray;

        //        CellRange range1 = sheet.Range["A2"];
        //        IBorder topBorder1 = range1.Borders[BordersLineType.EdgeTop];
        //        topBorder1.LineStyle = LineStyleType.Medium;
        //        topBorder1.Color = Color.DarkBlue;
        //        IBorder leftBorder1 = range1.Borders[BordersLineType.EdgeLeft];
        //        leftBorder1.LineStyle = LineStyleType.Medium;
        //        leftBorder1.Color = Color.DarkBlue;
        //        IBorder bottomBorder1 = range1.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder1.LineStyle = LineStyleType.Medium;
        //        bottomBorder1.Color = Color.DarkBlue;
        //        CellRange range2 = sheet.Range["B2"];
        //        IBorder topBorder2 = range2.Borders[BordersLineType.EdgeTop];
        //        topBorder2.LineStyle = LineStyleType.Medium;
        //        topBorder2.Color = Color.DarkBlue;
        //        IBorder bottomBorder2 = range2.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder2.LineStyle = LineStyleType.Medium;
        //        bottomBorder2.Color = Color.DarkBlue;
        //        CellRange range3 = sheet.Range["C2"];
        //        IBorder topBorder3 = range3.Borders[BordersLineType.EdgeTop];
        //        topBorder3.LineStyle = LineStyleType.Medium;
        //        topBorder3.Color = Color.DarkBlue;
        //        IBorder bottomBorder3 = range3.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder3.LineStyle = LineStyleType.Medium;
        //        bottomBorder3.Color = Color.DarkBlue;
        //        CellRange range4 = sheet.Range["D2"];
        //        IBorder topBorder4 = range4.Borders[BordersLineType.EdgeTop];
        //        topBorder4.LineStyle = LineStyleType.Medium;
        //        topBorder4.Color = Color.DarkBlue;
        //        IBorder bottomBorder4 = range4.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder4.LineStyle = LineStyleType.Medium;
        //        bottomBorder4.Color = Color.DarkBlue;
        //        CellRange range5 = sheet.Range["E2"];
        //        IBorder topBorder5 = range5.Borders[BordersLineType.EdgeTop];
        //        topBorder5.LineStyle = LineStyleType.Medium;
        //        topBorder5.Color = Color.DarkBlue;
        //        IBorder rightBorder5 = range5.Borders[BordersLineType.EdgeRight];
        //        rightBorder5.LineStyle = LineStyleType.Medium;
        //        rightBorder5.Color = Color.DarkBlue;
        //        IBorder bottomBorder5 = range5.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder5.LineStyle = LineStyleType.Medium;
        //        bottomBorder5.Color = Color.DarkBlue;

        //        CellRange range6 = sheet.Range["A5"];
        //        IBorder leftBorder6 = range6.Borders[BordersLineType.EdgeLeft];
        //        leftBorder6.LineStyle = LineStyleType.Medium;
        //        leftBorder6.Color = Color.DarkOrange;
        //        IBorder rightBorder6 = range6.Borders[BordersLineType.EdgeRight];
        //        rightBorder6.LineStyle = LineStyleType.Medium;
        //        rightBorder6.Color = Color.DarkOrange;
        //        IBorder topBorder6 = range6.Borders[BordersLineType.EdgeTop];
        //        topBorder6.LineStyle = LineStyleType.Medium;
        //        topBorder6.Color = Color.DarkOrange;
        //        IBorder bottomBorder6 = range6.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder6.LineStyle = LineStyleType.Medium;
        //        bottomBorder6.Color = Color.DarkOrange;

        //        CellRange range7 = sheet.Range["A10"];
        //        IBorder leftBorder7 = range7.Borders[BordersLineType.EdgeLeft];
        //        leftBorder7.LineStyle = LineStyleType.Medium;
        //        leftBorder7.Color = Color.DarkOliveGreen;
        //        IBorder rightBorder7 = range7.Borders[BordersLineType.EdgeRight];
        //        rightBorder7.LineStyle = LineStyleType.Medium;
        //        rightBorder7.Color = Color.DarkOliveGreen;
        //        IBorder topBorder7 = range7.Borders[BordersLineType.EdgeTop];
        //        topBorder7.LineStyle = LineStyleType.Medium;
        //        topBorder7.Color = Color.DarkOliveGreen;
        //        IBorder bottomBorder7 = range7.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder7.LineStyle = LineStyleType.Medium;
        //        bottomBorder7.Color = Color.DarkOliveGreen;

        //        CellRange range8 = sheet.Range["A15"];
        //        IBorder leftBorder8 = range8.Borders[BordersLineType.EdgeLeft];
        //        leftBorder8.LineStyle = LineStyleType.Medium;
        //        leftBorder8.Color = Color.DarkOrchid;
        //        IBorder rightBorder8 = range8.Borders[BordersLineType.EdgeRight];
        //        rightBorder8.LineStyle = LineStyleType.Medium;
        //        rightBorder8.Color = Color.DarkOrchid;
        //        IBorder topBorder8 = range8.Borders[BordersLineType.EdgeTop];
        //        topBorder8.LineStyle = LineStyleType.Medium;
        //        topBorder8.Color = Color.DarkOrchid;
        //        IBorder bottomBorder8 = range8.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder8.LineStyle = LineStyleType.Medium;
        //        bottomBorder8.Color = Color.DarkOrchid;

        //        CellRange range9 = sheet.Range["A20"];
        //        IBorder leftBorder9 = range9.Borders[BordersLineType.EdgeLeft];
        //        leftBorder9.LineStyle = LineStyleType.Medium;
        //        leftBorder9.Color = Color.DarkTurquoise;
        //        IBorder rightBorder9 = range9.Borders[BordersLineType.EdgeRight];
        //        rightBorder9.LineStyle = LineStyleType.Medium;
        //        rightBorder9.Color = Color.DarkTurquoise;
        //        IBorder topBorder9 = range9.Borders[BordersLineType.EdgeTop];
        //        topBorder9.LineStyle = LineStyleType.Medium;
        //        topBorder9.Color = Color.DarkTurquoise;
        //        IBorder bottomBorder9 = range9.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder9.LineStyle = LineStyleType.Medium;
        //        bottomBorder9.Color = Color.DarkTurquoise;

        //        CellRange range10 = sheet.Range["A25"];
        //        IBorder leftBorder10 = range10.Borders[BordersLineType.EdgeLeft];
        //        leftBorder10.LineStyle = LineStyleType.Medium;
        //        leftBorder10.Color = Color.DarkRed;
        //        IBorder rightBorder10 = range10.Borders[BordersLineType.EdgeRight];
        //        rightBorder10.LineStyle = LineStyleType.Medium;
        //        rightBorder10.Color = Color.DarkRed;
        //        IBorder topBorder10 = range10.Borders[BordersLineType.EdgeTop];
        //        topBorder10.LineStyle = LineStyleType.Medium;
        //        topBorder10.Color = Color.DarkRed;
        //        IBorder bottomBorder10 = range10.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder10.LineStyle = LineStyleType.Medium;
        //        bottomBorder10.Color = Color.DarkRed;

        //        CellRange range11 = sheet.Range["A30"];
        //        IBorder leftBorder11 = range11.Borders[BordersLineType.EdgeLeft];
        //        leftBorder11.LineStyle = LineStyleType.Medium;
        //        leftBorder11.Color = Color.DarkGoldenrod;
        //        IBorder rightBorder11 = range11.Borders[BordersLineType.EdgeRight];
        //        rightBorder11.LineStyle = LineStyleType.Medium;
        //        rightBorder11.Color = Color.DarkGoldenrod;
        //        IBorder topBorder11 = range11.Borders[BordersLineType.EdgeTop];
        //        topBorder11.LineStyle = LineStyleType.Medium;
        //        topBorder11.Color = Color.DarkGoldenrod;
        //        IBorder bottomBorder11 = range11.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder11.LineStyle = LineStyleType.Medium;
        //        bottomBorder11.Color = Color.DarkGoldenrod;

        //        CellRange range12 = sheet.Range["A35"];
        //        IBorder leftBorder12 = range12.Borders[BordersLineType.EdgeLeft];
        //        leftBorder12.LineStyle = LineStyleType.Medium;
        //        leftBorder12.Color = Color.DarkGray;
        //        IBorder rightBorder12 = range12.Borders[BordersLineType.EdgeRight];
        //        rightBorder12.LineStyle = LineStyleType.Medium;
        //        rightBorder12.Color = Color.DarkGray;
        //        IBorder topBorder12 = range12.Borders[BordersLineType.EdgeTop];
        //        topBorder12.LineStyle = LineStyleType.Medium;
        //        topBorder12.Color = Color.DarkGray;
        //        IBorder bottomBorder12 = range12.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder12.LineStyle = LineStyleType.Medium;
        //        bottomBorder12.Color = Color.DarkGray;

        //        CellRange range13 = sheet.Range["A40"];
        //        IBorder leftBorder13 = range13.Borders[BordersLineType.EdgeLeft];
        //        leftBorder13.LineStyle = LineStyleType.Medium;
        //        leftBorder13.Color = Color.DarkKhaki;
        //        IBorder rightBorder13 = range13.Borders[BordersLineType.EdgeRight];
        //        rightBorder13.LineStyle = LineStyleType.Medium;
        //        rightBorder13.Color = Color.DarkKhaki;
        //        IBorder topBorder13 = range13.Borders[BordersLineType.EdgeTop];
        //        topBorder13.LineStyle = LineStyleType.Medium;
        //        topBorder13.Color = Color.DarkKhaki;
        //        IBorder bottomBorder13 = range13.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder13.LineStyle = LineStyleType.Medium;
        //        bottomBorder13.Color = Color.DarkKhaki;

        //        CellRange range14 = sheet.Range["A45"];
        //        IBorder leftBorder14 = range14.Borders[BordersLineType.EdgeLeft];
        //        leftBorder14.LineStyle = LineStyleType.Medium;
        //        leftBorder14.Color = Color.DarkMagenta;
        //        IBorder rightBorder14 = range14.Borders[BordersLineType.EdgeRight];
        //        rightBorder14.LineStyle = LineStyleType.Medium;
        //        rightBorder14.Color = Color.DarkMagenta;
        //        IBorder topBorder14 = range14.Borders[BordersLineType.EdgeTop];
        //        topBorder14.LineStyle = LineStyleType.Medium;
        //        topBorder14.Color = Color.DarkMagenta;
        //        IBorder bottomBorder14 = range14.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder14.LineStyle = LineStyleType.Medium;
        //        bottomBorder14.Color = Color.DarkMagenta;

        //        CellRange range15 = sheet.Range["A50"];
        //        IBorder leftBorder15 = range15.Borders[BordersLineType.EdgeLeft];
        //        leftBorder15.LineStyle = LineStyleType.Medium;
        //        leftBorder15.Color = Color.DarkSeaGreen;
        //        IBorder rightBorder15 = range15.Borders[BordersLineType.EdgeRight];
        //        rightBorder15.LineStyle = LineStyleType.Medium;
        //        rightBorder15.Color = Color.DarkSeaGreen;
        //        IBorder topBorder15 = range15.Borders[BordersLineType.EdgeTop];
        //        topBorder15.LineStyle = LineStyleType.Medium;
        //        topBorder15.Color = Color.DarkSeaGreen;
        //        IBorder bottomBorder15 = range15.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder15.LineStyle = LineStyleType.Medium;
        //        bottomBorder15.Color = Color.DarkSeaGreen;

        //        CellRange range16 = sheet.Range["A55"];
        //        IBorder leftBorder16 = range16.Borders[BordersLineType.EdgeLeft];
        //        leftBorder16.LineStyle = LineStyleType.Medium;
        //        leftBorder16.Color = Color.DarkSalmon;
        //        IBorder rightBorder16 = range16.Borders[BordersLineType.EdgeRight];
        //        rightBorder16.LineStyle = LineStyleType.Medium;
        //        rightBorder16.Color = Color.DarkSalmon;
        //        IBorder topBorder16 = range16.Borders[BordersLineType.EdgeTop];
        //        topBorder16.LineStyle = LineStyleType.Medium;
        //        topBorder16.Color = Color.DarkSalmon;
        //        IBorder bottomBorder16 = range16.Borders[BordersLineType.EdgeBottom];
        //        bottomBorder16.LineStyle = LineStyleType.Medium;
        //        bottomBorder16.Color = Color.DarkSalmon;


        //        CellRange range17 = sheet.Range["A61"];
        //        IBorder topBorder17 = range17.Borders[BordersLineType.EdgeTop];
        //        topBorder17.LineStyle = LineStyleType.Medium;
        //        topBorder17.Color = Color.DarkBlue;

        //        CellRange range20 = sheet.Range["B61"];
        //        IBorder topBorder20 = range20.Borders[BordersLineType.EdgeTop];
        //        topBorder20.LineStyle = LineStyleType.Medium;
        //        topBorder20.Color = Color.DarkBlue;

        //        CellRange range30 = sheet.Range["C61"];
        //        IBorder topBorder30 = range30.Borders[BordersLineType.EdgeTop];
        //        topBorder30.LineStyle = LineStyleType.Medium;
        //        topBorder30.Color = Color.DarkBlue;

        //        CellRange range40 = sheet.Range["D61"];
        //        IBorder topBorder40 = range40.Borders[BordersLineType.EdgeTop];
        //        topBorder40.LineStyle = LineStyleType.Medium;
        //        topBorder40.Color = Color.DarkBlue;

        //        CellRange range50 = sheet.Range["E61"];
        //        IBorder topBorder50 = range50.Borders[BordersLineType.EdgeTop];
        //        topBorder50.LineStyle = LineStyleType.Medium;
        //        topBorder50.Color = Color.DarkBlue;

        //        //Cria e Salva o arquivo
        //        workbook.SaveToFile(@"C:\TESTES_AVELL\MySqlData\" + NomeArquivo + ".xlsx", ExcelVersion.Version2016);
        //    }
        //}
    }
}
