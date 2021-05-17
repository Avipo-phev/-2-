
namespace fire2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDrawMap = new System.Windows.Forms.Panel();
            this.panelMaterial = new System.Windows.Forms.Panel();
            this.buttonGrass = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonWater = new System.Windows.Forms.Button();
            this.buttonDrawMap = new System.Windows.Forms.Button();
            this.buttonDrawGrid = new System.Windows.Forms.Button();
            this.ScaleUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelDrawMap.SuspendLayout();
            this.panelMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDrawMap);
            this.panel1.Controls.Add(this.buttonDrawGrid);
            this.panel1.Controls.Add(this.ScaleUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(670, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelDrawMap
            // 
            this.panelDrawMap.Controls.Add(this.panelMaterial);
            this.panelDrawMap.Controls.Add(this.buttonDrawMap);
            this.panelDrawMap.Location = new System.Drawing.Point(4, 97);
            this.panelDrawMap.Name = "panelDrawMap";
            this.panelDrawMap.Size = new System.Drawing.Size(130, 277);
            this.panelDrawMap.TabIndex = 1;
            this.panelDrawMap.Visible = false;
            // 
            // panelMaterial
            // 
            this.panelMaterial.Controls.Add(this.buttonGrass);
            this.panelMaterial.Controls.Add(this.buttonFire);
            this.panelMaterial.Controls.Add(this.buttonWater);
            this.panelMaterial.Location = new System.Drawing.Point(1, 58);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(126, 165);
            this.panelMaterial.TabIndex = 1;
            this.panelMaterial.Visible = false;
            // 
            // buttonGrass
            // 
            this.buttonGrass.Location = new System.Drawing.Point(0, 0);
            this.buttonGrass.Name = "buttonGrass";
            this.buttonGrass.Size = new System.Drawing.Size(120, 49);
            this.buttonGrass.TabIndex = 2;
            this.buttonGrass.Text = "Трава";
            this.buttonGrass.UseVisualStyleBackColor = true;
            this.buttonGrass.Click += new System.EventHandler(this.buttonGrass_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Location = new System.Drawing.Point(0, 110);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(120, 49);
            this.buttonFire.TabIndex = 4;
            this.buttonFire.Text = "Огонь";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonWater
            // 
            this.buttonWater.Location = new System.Drawing.Point(0, 55);
            this.buttonWater.Name = "buttonWater";
            this.buttonWater.Size = new System.Drawing.Size(120, 49);
            this.buttonWater.TabIndex = 3;
            this.buttonWater.Text = "Вода";
            this.buttonWater.UseVisualStyleBackColor = true;
            this.buttonWater.Click += new System.EventHandler(this.buttonWater_Click);
            // 
            // buttonDrawMap
            // 
            this.buttonDrawMap.Location = new System.Drawing.Point(-1, 3);
            this.buttonDrawMap.Name = "buttonDrawMap";
            this.buttonDrawMap.Size = new System.Drawing.Size(120, 49);
            this.buttonDrawMap.TabIndex = 5;
            this.buttonDrawMap.Text = "Рисовать карту";
            this.buttonDrawMap.UseVisualStyleBackColor = true;
            this.buttonDrawMap.Click += new System.EventHandler(this.buttonDrawMap_Click);
            // 
            // buttonDrawGrid
            // 
            this.buttonDrawGrid.Location = new System.Drawing.Point(4, 42);
            this.buttonDrawGrid.Name = "buttonDrawGrid";
            this.buttonDrawGrid.Size = new System.Drawing.Size(120, 49);
            this.buttonDrawGrid.TabIndex = 1;
            this.buttonDrawGrid.Text = "Рисовать сетку";
            this.buttonDrawGrid.UseVisualStyleBackColor = true;
            this.buttonDrawGrid.Click += new System.EventHandler(this.buttonDrawGrid_Click);
            // 
            // ScaleUpDown
            // 
            this.ScaleUpDown.Location = new System.Drawing.Point(4, 13);
            this.ScaleUpDown.Name = "ScaleUpDown";
            this.ScaleUpDown.Size = new System.Drawing.Size(120, 22);
            this.ScaleUpDown.TabIndex = 0;
            // 
            // DrawTimer
            // 
            this.DrawTimer.Interval = 10;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panelDrawMap.ResumeLayout(false);
            this.panelMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDrawGrid;
        private System.Windows.Forms.NumericUpDown ScaleUpDown;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonWater;
        private System.Windows.Forms.Button buttonGrass;
        private System.Windows.Forms.Button buttonDrawMap;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Panel panelDrawMap;
        private System.Windows.Forms.Panel panelMaterial;
    }
}

