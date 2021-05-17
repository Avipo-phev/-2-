using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fire2
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///     Размер сетки
        /// </summary>
        Size gridSize;
        /// <summary>
        /// Размер одной ячейки
        /// </summary>
        Size cellSize;
        Graphics g;
        Pen p = new Pen(Color.Black);
        /// <summary>
        /// Флаг для рисования карты
        /// </summary>
        bool drawMap = false;

        /// <summary>
        /// Список ячеек
        /// </summary>
        List<TerritoryCell> cells;
        /// <summary>
        /// Материал рисования карты
        /// </summary>
        Material nowMaterial = new NoneMaterial();

        public Form1()
        {
            InitializeComponent();
        }

        void Init()
        {
            //ScriptEngine engine = Python.CreateEngine();
            //engine.ExecuteFile("");

            cellSize = new Size(Convert.ToInt32(ScaleUpDown.Value), Convert.ToInt32(ScaleUpDown.Value));
            gridSize = new Size(this.Width - panel1.Width, this.Height);

            cells = new List<TerritoryCell>();

            // Рисование сетки
            g = this.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < gridSize.Width; i++)
            {
                g.DrawLine(p, i * cellSize.Width, 0, i * cellSize.Width, gridSize.Height);
            }
            for (int i = 0; i < gridSize.Width; i++)
            {
                g.DrawLine(p, 0, i * cellSize.Height, gridSize.Width, i * cellSize.Width);
            }
            // Заполнение списка ячеек ячейками
            for (int i = 0; i < gridSize.Width / cellSize.Width; i++)
            {
                for (int j = 0; j < gridSize.Height / cellSize.Height; j++)
                {
                    Point point = new Point(i * cellSize.Width, j * cellSize.Height);
                    TerritoryCell cell = new TerritoryCell(nowMaterial, point, cellSize.Width);
                    cells.Add(cell);
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDrawGrid_Click(object sender, EventArgs e)
        {
            Init();
            panelDrawMap.Visible = true;
        }

        private void buttonDrawMap_Click(object sender, EventArgs e)
        {
            panelMaterial.Visible = true;
        }

        // Выбор материала для рисования карты
        #region
        private void buttonGrass_Click(object sender, EventArgs e)
        {
            nowMaterial = new Grass();
            drawMap = true;
            DrawTimer.Enabled = true;
            DrawTimer.Start();
        }

        private void buttonWater_Click(object sender, EventArgs e)
        {
            nowMaterial = new Water();
            drawMap = true;
            DrawTimer.Enabled = true;
            DrawTimer.Start();
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            nowMaterial = new Fire();
            drawMap = true;
        }

        #endregion

        // Рисование карты
        #region
        bool flag = false;
        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                Point mousePosition = PointToClient(MousePosition);
                if (drawMap)
                {
                    if (mousePosition.X > 0 && mousePosition.Y > 0 && mousePosition.X < this.Width - panel1.Width && mousePosition.Y < this.Height)
                    {
                        for (int i = 0; i < (gridSize.Width / cellSize.Width) * (gridSize.Height / cellSize.Height); i++)
                        {
                            if (mousePosition.X < cells[i].location.X + cellSize.Width && mousePosition.X > cells[i].location.X &&
                            mousePosition.Y < cells[i].location.Y + cellSize.Height && mousePosition.Y > cells[i].location.Y)
                            {
                                if (cells[i].material != nowMaterial)
                                {
                                    Pen pen = new Pen(nowMaterial.colorMaterial);
                                    Brush brush = new SolidBrush(nowMaterial.colorMaterial);
                                    cells[i].material = nowMaterial;
                                    
                                    var rect = new Rectangle(cells[i].location, cellSize);
                                    g.DrawRectangle(pen,rect);
                                    g.FillRectangle(brush, rect);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        #endregion
    }
}
