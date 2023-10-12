using Spectre.Console;

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
            
        }
    }
}
