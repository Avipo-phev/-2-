using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace fire2
{
    public class TerritoryCell
    {
        /// <summary>
        /// Координаты ячейки
        /// </summary>
        public Point location;

        public int size;

        Rectangle cell;

        /// <summary>
        /// Материал ячейки
        /// </summary>
        public Material material;

        /// <summary>
        /// Время протекания пожара в ячейке
        /// </summary>
        public double timeFire = 0;

        /// <summary>
        /// Время нагревания материала до возгарания
        /// </summary>
        public double timeHeating = 0;

        /// <summary>
        /// Состояние горения 0 - не горит, 1 - горит, 2 - сгорел
        /// </summary>
        public short isFire = 0;
        Graphics g;

        public TerritoryCell(Material _material, Point _location, int _size)
        {
            this.material = _material;
            this.location = _location;
            this.size = _size;
        }

        public void DrawCell()
        {

        }
    }


}
