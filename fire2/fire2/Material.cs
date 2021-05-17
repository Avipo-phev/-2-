using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace fire2
{
    public enum NameMaterial {GRASS, WATER, FIRE, COAL, NONE};
    public class Material
    {
        /// <summary>
        /// Коэффициетн возгарания
        /// </summary>
        public double fireCof;

        /// <summary>
        /// Цвет материала
        /// </summary>
        public Color colorMaterial;

        /// <summary>
        /// Название материала
        /// </summary>
        public NameMaterial nameMaterial;

        /// <summary>
        /// Время через которое материал из угля превратится в уголь
        /// </summary>
        public double maxTimeFire;

    }


    public class Grass : Material
    {
        public Grass()
        {
            this.colorMaterial = Color.Green;
            this.fireCof = 1;
            this.maxTimeFire = 10;
            this.nameMaterial = NameMaterial.GRASS;
        }
    }

    public class Water : Material
    {
        public Water()
        {
            this.colorMaterial = Color.Blue;
            this.fireCof = 0;
            this.nameMaterial = NameMaterial.WATER;
        }
    }

    public class NoneMaterial : Material
    {
        public NoneMaterial()
        {
            this.colorMaterial = Color.White;
            this.fireCof = 0;
            this.nameMaterial = NameMaterial.NONE;
        }
    }
    

    public class Fire : Material
    {
        public Fire()
        {
            this.colorMaterial = Color.Orange;
            this.nameMaterial = NameMaterial.FIRE;
            double timeFire = 0;
        }

    }
}
