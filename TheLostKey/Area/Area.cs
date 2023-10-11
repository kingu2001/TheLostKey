using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Spectre.Console;
using Spectre.Console.Rendering;

namespace TheLostKey.Area
{
    public class Area
    {
        string name;
        string description;
        public string Name => name;

        public string Description => description;

        public Area(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void BuildArea(int row, int column)
        {
            var table = new Table();
            for (int i = 0; i < column; i++)
            {
                table.AddColumn(new TableColumn(" "));
            }

            for (int i = 0; i < row; i++)
            {
                table.AddEmptyRow();
            }

            table.HideHeaders();
            table.Width = 100;



            AnsiConsole.Write(table);
        }
    }
}
