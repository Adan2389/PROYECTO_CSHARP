using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBRANZAS.Funciones
{
    class TDataGridViewExportExcel
    {
        public Color HeaderColor = Color.Empty;
        public List<String> ColumnsHide = new List<String>();

        System.Drawing.Font Font;
        DataGridView dgv;


        //constructor 
        public TDataGridViewExportExcel(DataGridView vDgv, System.Drawing.Font vFont)
        {
            dgv = vDgv;
            Font = vFont;
        }

        // Exporta a Excel el contenido de un DataGridView
        public void ExporToExcel()
        {
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            object oldValue = System.Reflection.Missing.Value;

            Clipboard.SetText(ConvertDataGridViewToHTMLWithFormatting());

            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();


            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Range)xlWorkSheet.Cells[2, 2];


            CR.Select();
            xlWorkSheet.Paste(CR, false);
            xlWorkSheet.UsedRange.WrapText = false;
            xlWorkSheet.UsedRange.Columns.EntireColumn.AutoFit();
            xlWorkSheet.UsedRange.Columns.EntireRow.AutoFit();
            xlWorkSheet.ListObjects.AddEx(XlListObjectSourceType.xlSrcRange, xlWorkSheet.UsedRange, Type.Missing, XlYesNoGuess.xlYes, Type.Missing).Name = "TestTable";
            xlexcel.Visible = true;

            Clipboard.SetDataObject(oldValue);
        }

        public string ConvertDataGridViewToHTMLWithFormatting()
        {
            StringBuilder sb = new StringBuilder();

            //create html & table
            sb.AppendLine("<html><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            sb.AppendLine("<tr>");

            //create table header
            foreach (DataGridViewColumn vCol in dgv.Columns)
            {
                if (vCol.Visible == true && !ColumnsHide.Contains(vCol.Name))
                {
                    sb.Append(DGVHeaderCellToHTMLWithFormatting(vCol));
                    sb.Append(DGVCellFontAndValueToHTML(vCol.HeaderText, vCol.HeaderCell.Style.Font));
                    sb.AppendLine("</td>");
                }
            }
            sb.AppendLine("</tr>");



            //create table body
            foreach (DataGridViewRow vRow in dgv.Rows)
            {
                sb.AppendLine("<tr>");
                foreach (DataGridViewCell vCell in vRow.Cells)
                {

                    if (dgv.Columns[vCell.ColumnIndex].Visible == true && !ColumnsHide.Contains(dgv.Columns[vCell.ColumnIndex].Name))
                    {
                        sb.AppendLine(DGVCellToHTMLWithFormatting(vCell));
                        string cellValue = vCell.Value == null ? string.Empty : vCell.Value.ToString();
                        sb.AppendLine(DGVCellFontAndValueToHTML(cellValue, vCell.Style.Font));
                        sb.AppendLine("</td>");
                    }
                }
                sb.AppendLine("</tr>");
            }
            //table footer & end of html file
            sb.AppendLine("</table></center></body></html>");
            return sb.ToString();
        }

        //TODO: Add more cell styles described here:
        private string DGVHeaderCellToHTMLWithFormatting(DataGridViewColumn pCol)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<td style=\" ");
            Color vBc = this.HeaderColor != Color.Empty ? this.HeaderColor : pCol.HeaderCell.InheritedStyle.BackColor;
            Color vFc = pCol.HeaderCell.InheritedStyle.ForeColor;

            sb.Append(DGVCellColorToHTML(vFc, vBc));
            sb.Append(DGVCellAlignmentToHTML(pCol.HeaderCell.Style.Alignment));
            sb.Append(" \" >");

            return sb.ToString();
        }

        private string DGVCellToHTMLWithFormatting(DataGridViewCell pCell)
        {
            StringBuilder sb = new StringBuilder();

            Color vBc = pCell.InheritedStyle.BackColor;
            Color vFc = pCell.InheritedStyle.ForeColor;



            sb.Append("<td style=\" ");
            sb.Append(DGVCellFormatTypeToHTML(pCell));
            sb.Append(DGVCellColorToHTML(vFc, vBc));
            sb.Append(DGVCellAlignmentToHTML(pCell.Style.Alignment));
            sb.Append(" \" >");

            return sb.ToString();
        }

        private string DGVCellFormatTypeToHTML(DataGridViewCell pCell)
        {

            if (pCell.Value == null)
                return string.Empty;

            string scopy = "";
            if (pCell.ValueType == typeof(DateTime))
            {
                scopy += " mso-number-format:'dd/MM/yyyy'; ";
                //scopy += " mso-number-format:'dd/MM/yyyy HH:mm'; ";
            }
            else if (pCell.ValueType == typeof(int) || pCell.ValueType == typeof(long))
            {
                scopy += " mso-number-format:'0'; ";
            }
            else if (pCell.ValueType == typeof(float) || pCell.ValueType == typeof(double) || pCell.ValueType == typeof(decimal))
            {
                scopy += " mso-number-format:'#,##0.000'; ";
            }
            else
            {
                scopy += " style=mso-number-format:'@'; ";
            }

            return scopy;
        }

        private string DGVCellColorToHTML(Color pForeColor, Color pBackColor)
        {
            if (pForeColor.Name == "0" && pBackColor.Name == "0") return string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            if (pForeColor.Name != "0" && pBackColor.Name != "0")
            {
                sb.Append("color:#");
                sb.Append(pForeColor.R.ToString("X2") + pForeColor.G.ToString("X2") + pForeColor.B.ToString("X2"));
                sb.Append("; background-color:#");
                sb.Append(pBackColor.R.ToString("X2") + pBackColor.G.ToString("X2") + pBackColor.B.ToString("X2"));
            }
            else if (pForeColor.Name != "0" && pBackColor.Name == "0")
            {
                sb.Append("color:#");
                sb.Append(pForeColor.R.ToString("X2") + pForeColor.G.ToString("X2") + pForeColor.B.ToString("X2"));
            }
            else //if (pForeColor.Name == "0" &&  pBackColor.Name != "0")
            {
                sb.Append("background-color:#");
                sb.Append(pBackColor.R.ToString("X2") + pBackColor.G.ToString("X2") + pBackColor.B.ToString("X2"));
            }

            sb.Append(";");
            return sb.ToString();
        }

        private string DGVCellFontAndValueToHTML(string pValue, System.Drawing.Font pFont)
        {
            //If no font has been set then assume its the default as someone would be expected in HTML or Excel
            if (pFont == null || pFont == this.Font && !(pFont.Bold | pFont.Italic | pFont.Underline | pFont.Strikeout)) return pValue;
            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            if (pFont.Bold) sb.Append("<b>");
            if (pFont.Italic) sb.Append("<i>");
            if (pFont.Strikeout) sb.Append("<strike>");

            //The <u> element was deprecated in HTML 4.01. The new HTML 5 tag is: text-decoration: underline
            if (pFont.Underline) sb.Append("<u>");

            string size = string.Empty;
            if (pFont.Size != this.Font.Size) size = "font-size: " + pFont.Size + "pt;";

            //The <font> tag is not supported in HTML5. Use CSS or a span instead. 
            if (pFont.FontFamily.Name != this.Font.Name)
            {
                sb.Append("<span style=\"font-family: ");
                sb.Append(pFont.FontFamily.Name);
                sb.Append("; ");
                sb.Append(size);
                sb.Append("\">");
            }
            sb.Append(pValue);
            if (pFont.FontFamily.Name != this.Font.Name) sb.Append("</span>");

            if (pFont.Underline) sb.Append("</u>");
            if (pFont.Strikeout) sb.Append("</strike>");
            if (pFont.Italic) sb.Append("</i>");
            if (pFont.Bold) sb.Append("</b>");

            return sb.ToString();
        }

        private string DGVCellAlignmentToHTML(DataGridViewContentAlignment pAlign)
        {
            if (pAlign == DataGridViewContentAlignment.NotSet) return string.Empty;

            string horizontalAlignment = string.Empty;
            string verticalAlignment = string.Empty;
            CellAlignment(pAlign, ref horizontalAlignment, ref verticalAlignment);
            StringBuilder sb = new StringBuilder();
            sb.Append(" align='");
            sb.Append(horizontalAlignment);
            sb.Append("' valign='");
            sb.Append(verticalAlignment);
            sb.Append("'");
            return sb.ToString();
        }

        private void CellAlignment(DataGridViewContentAlignment pAlign, ref string horizontalAlignment, ref string verticalAlignment)
        {
            switch (pAlign)
            {
                case DataGridViewContentAlignment.MiddleRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "middle";
                    break;
                case DataGridViewContentAlignment.MiddleLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "middle";
                    break;
                case DataGridViewContentAlignment.MiddleCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "middle";
                    break;
                case DataGridViewContentAlignment.TopCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "top";
                    break;
                case DataGridViewContentAlignment.BottomCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "bottom";
                    break;
                case DataGridViewContentAlignment.TopLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "top";
                    break;
                case DataGridViewContentAlignment.BottomLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "bottom";
                    break;
                case DataGridViewContentAlignment.TopRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "top";
                    break;
                case DataGridViewContentAlignment.BottomRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "bottom";
                    break;

                default: //DataGridViewContentAlignment.NotSet
                    horizontalAlignment = "left";
                    verticalAlignment = "middle";
                    break;
            }
        }
    }
}
