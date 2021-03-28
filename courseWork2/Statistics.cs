using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace courseWork2
{
    public partial class Statistics : Form
    {
        public static string prodAddressID;

        DateTime dateOne;
        DateTime dateTwo;

        string date;

        public Statistics()
        {
            InitializeComponent();

        }

        #region Фильтр по периоду

        private void DateFirst_ValueChanged(object sender, EventArgs e)
        {
            dateOne = dateFirst.Value.Date;
            date += dateFirst.Value.Day.ToString() + "." + dateFirst.Value.Month.ToString() + "." + dateFirst.Value.Year.ToString() + " - ";

            dateSecond.Enabled = true;
        }

        private void DateSecond_ValueChanged(object sender, EventArgs e)
        {
            dateTwo = dateSecond.Value;

            if (dateTwo < dateOne)
            {
                MessageBox.Show("Неверно выбран промежуток");
            }
            else
            {
                applyFilterButton.Enabled = true;
                date += dateSecond.Value.Day.ToString() + "." + dateSecond.Value.Month.ToString() + "." + dateSecond.Value.Year.ToString();
            }
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = "GetStats";

            int i = 0;

            statGrid.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(SignIn.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;  // указание, что команда представляет хранимую процедуру

                command.Parameters.Add("@store_id", SqlDbType.Int).Value = SignIn.userID;
                command.Parameters.Add("@date_one", SqlDbType.DateTime).Value = dateOne;
                command.Parameters.Add("@date_two", SqlDbType.DateTime).Value = dateTwo;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        statGrid.Rows.Add();

                        for (int j = 0; j < statGrid.Columns.Count; j++)
                        {
                            statGrid.Rows[i].Cells[j].Value = reader.GetValue(j).ToString();
                        }

                        i++;
                    }
                }
                connection.Close();
                reader.Close();
            }

            if (statGrid.Rows.Count != 0)
            {
                uploadWordButton.Enabled = true;
                uploadExcelButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Записи не найдены, выберите другой период.");

                uploadWordButton.Enabled = false;
                uploadExcelButton.Enabled = false;
            }
        }

        #endregion
        #region Выгрузка в Word, Excel

        private void UploadWordButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = date + ".docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(statGrid, sfd.FileName);
                MessageBox.Show("Файл " + date + ".docx сохранен");
            }
        }

        private void UploadExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Export To Excel";
            sfd.Filter = "To Excel (Xlsx)|*.xlsx";
            sfd.FileName = date + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_DataGridView_To_Excel(statGrid, sfd.FileName);
                MessageBox.Show("Файл " + date + ".xlsx сохранен");
            }
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                int r = 0;

                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                object style = WdBuiltinStyle.wdStyleTableLightGridAccent1;
                oDoc.Application.Selection.Tables[1].set_Style(ref style);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Отчет за период " + date;
                    headerRange.Font.Size = 20;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                oDoc.SaveAs2(filename);
            }
        }

        public void Export_DataGridView_To_Excel(DataGridView DGV, string filename)
        {
            string[] Alphabit = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                              "N", "O","P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            string Range_Letter = Alphabit[DGV.Columns.Count];
            string Range_Row = (DGV.Rows.Count + 1).ToString();

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;

            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);


            for (int x = 0; x < DGV.Columns.Count; x++)
            {
                oSheet.Cells[1, x + 2] = DGV.Columns[x].HeaderText;
            }

            for (int i = 0; i < DGV.Columns.Count; i++)
            {
                for (int j = 0; j < DGV.Rows.Count; j++)
                {
                    oSheet.Cells[j + 2, i + 2] = DGV.Rows[j].Cells[i].Value;
                }
            }

            Excel.Range rng1 = oSheet.get_Range("B1", Range_Letter + "1");
            rng1.Font.Size = 14;
            rng1.Font.Bold = true;
            rng1.Font.Color = System.Drawing.Color.Black;
            rng1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Range rng2 = oSheet.get_Range("B2", Range_Letter + Range_Row);
            rng2.WrapText = false;
            rng2.Font.Size = 12;
            rng2.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            rng2.EntireColumn.AutoFit();
            rng2.EntireRow.AutoFit();

            oSheet.get_Range("B1", Range_Letter + "2").EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Missing.Value);
            oSheet.Cells[1, 3] = "Отчет за период " + date;
            Excel.Range rng3 = oSheet.get_Range("B1", Range_Letter + "2");
            rng3.Merge(Missing.Value);
            rng3.Font.Size = 20;
            rng3.Font.Bold = true;
            rng3.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;


            oBook.SaveAs(filename);
            oApp.Quit();
        }


        #endregion

        private void GoBackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
