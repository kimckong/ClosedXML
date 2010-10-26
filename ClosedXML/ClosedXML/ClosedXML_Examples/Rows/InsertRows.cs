﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;

using System.Drawing;

namespace ClosedXML_Examples.Rows
{
    public class InsertRows
    {
        #region Variables

        // Public

        // Private


        #endregion

        #region Properties

        // Public

        // Private

        // Override


        #endregion

        #region Events

        // Public

        // Private

        // Override


        #endregion

        #region Methods

        // Public
        public void Create(String filePath)
        {
            var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Inserting Rows");

            // Color the entire spreadsheet using rows
            ws.Rows().Style.Fill.BackgroundColor = Color.LightCyan;

            // Put a value in a few cells
            foreach (var r in Enumerable.Range(1, 5))
                foreach (var c in Enumerable.Range(1, 5))
                    ws.Cell(r, c).Value = "X";

            var blueRow = ws.Row(2);
            var redRow = ws.Row(5);

            blueRow.Style.Fill.BackgroundColor = Color.Blue;
            blueRow.InsertRowsBelow(2);


            redRow.Style.Fill.BackgroundColor = Color.Red;
            redRow.InsertRowsAbove(2);

            ws.Columns(3, 4).Style.Fill.BackgroundColor = Color.Orange;
            ws.Range("A2:A4").InsertRowsBelow(2);
            ws.Range("B2:B4").InsertRowsAbove(2);
            ws.Range("C2:C4").InsertRowsBelow(2);
            ws.Range("D2:D4").InsertRowsAbove(2);

            workbook.SaveAs(filePath);
        }

        // Private

        // Override


        #endregion
    }
}
