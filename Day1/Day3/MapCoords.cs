using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Day3
{
    public class MapCoords
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public static int LineLength { get; set; }

        public MapCoords(int xPos, int yPos)
        {
            while (xPos >= LineLength)
            {
                xPos -= LineLength;
            }
            XPos = xPos;
            YPos = yPos;
        }
        
    }
}
