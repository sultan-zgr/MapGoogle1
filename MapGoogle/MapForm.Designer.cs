
namespace MapGoogle
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bRemove = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bPolygon = new System.Windows.Forms.Button();
            this.bRoute = new System.Windows.Forms.Button();
            this.tLongitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tLatitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(518, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // bRemove
            // 
            this.bRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRemove.Location = new System.Drawing.Point(646, 181);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 21;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAdd.Location = new System.Drawing.Point(518, 181);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 20;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bPolygon
            // 
            this.bPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bPolygon.Location = new System.Drawing.Point(646, 106);
            this.bPolygon.Name = "bPolygon";
            this.bPolygon.Size = new System.Drawing.Size(75, 39);
            this.bPolygon.TabIndex = 19;
            this.bPolygon.Text = "Polygon";
            this.bPolygon.UseVisualStyleBackColor = true;
            this.bPolygon.Click += new System.EventHandler(this.bPolygon_Click);
            // 
            // bRoute
            // 
            this.bRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRoute.Location = new System.Drawing.Point(646, 40);
            this.bRoute.Name = "bRoute";
            this.bRoute.Size = new System.Drawing.Size(75, 37);
            this.bRoute.TabIndex = 18;
            this.bRoute.Text = "Route";
            this.bRoute.UseVisualStyleBackColor = true;
            this.bRoute.Click += new System.EventHandler(this.bRoute_Click);
            // 
            // tLongitude
            // 
            this.tLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tLongitude.Location = new System.Drawing.Point(518, 133);
            this.tLongitude.Name = "tLongitude";
            this.tLongitude.Size = new System.Drawing.Size(100, 22);
            this.tLongitude.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(515, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Longitude";
            // 
            // tLatitude
            // 
            this.tLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tLatitude.Location = new System.Drawing.Point(518, 83);
            this.tLatitude.Name = "tLatitude";
            this.tLatitude.Size = new System.Drawing.Size(100, 22);
            this.tLatitude.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(515, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Latitude";
            // 
            // tDescription
            // 
            this.tDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tDescription.Location = new System.Drawing.Point(518, 37);
            this.tDescription.Name = "tDescription";
            this.tDescription.Size = new System.Drawing.Size(100, 22);
            this.tDescription.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(515, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Description";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(321, 393);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(177, 45);
            this.trackBar1.TabIndex = 23;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 23);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(486, 351);
            this.gMapControl1.TabIndex = 24;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(272, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Zoom";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bPolygon);
            this.Controls.Add(this.bRoute);
            this.Controls.Add(this.tLongitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tLatitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tDescription);
            this.Controls.Add(this.label1);
            this.Name = "MapForm";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.MapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bPolygon;
        private System.Windows.Forms.Button bRoute;
        private System.Windows.Forms.TextBox tLongitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tLatitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

