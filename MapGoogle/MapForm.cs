using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MapGoogle
{
    public partial class MapForm : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        bool Traceroute = false;
        int RouteIndicatorCounter;
        PointLatLng start;
        PointLatLng final;


        int SelectedRow = 0;
        double FirstLatitude = 38.9935720582095;  // İlk Enlem
        double FirstLongitude = 35.244140625; // İlk Boylam

        public MapForm()
        {
            InitializeComponent();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("Latitude", typeof(double))); //enlem
            dt.Columns.Add(new DataColumn("Longitude", typeof(double))); //boylam

            //listede görüntülemek için dt'ye veri ekleme
            dt.Rows.Add("Location", FirstLatitude, FirstLongitude);
            dataGridView1.DataSource = dt; // Data Source ile veri kaynağının neresi olduğunu belirtiyoruz.

            //Enlem ve uzun sütunları devre dışı
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true; // Map üstünde çizim işlemleri için
            gMapControl1.MapProvider = GMapProviders.GoogleMap; // Harita Sağlayıcımızı belirliyoruz.
            gMapControl1.Position = new PointLatLng(FirstLatitude, FirstLatitude);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 5;
            gMapControl1.AutoScroll = true;

            //Highlighter
            markerOverlay = new GMapOverlay("Highlighter");
            marker = new GMarkerGoogle(new PointLatLng(FirstLatitude, FirstLongitude), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker); // Haritaları ekliyoruz.

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Location:\n Latituade:{0}\n Longitude:{1}\n", FirstLatitude, FirstLongitude);


            //haritayı ve işaretçiyi harita kontrolüne ekliyoruz
            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedRow = e.RowIndex; // Seçili row 
            tDescription.Text = dataGridView1.Rows[SelectedRow].Cells[0].Value.ToString();
            tLatitude.Text = dataGridView1.Rows[SelectedRow].Cells[1].Value.ToString();
            tLongitude.Text = dataGridView1.Rows[SelectedRow].Cells[2].Value.ToString();

            marker.Position = new PointLatLng(Convert.ToDouble(tLatitude.Text), Convert.ToDouble(tLongitude.Text));
            gMapControl1.Position = marker.Position;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Haritada tıklanan yerin boylam-enlemini alıyoruz. (Lat,Lng)
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            tLatitude.Text = lat.ToString();
            tLongitude.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng); // kullanıcının seçtiği markeri ayarlıyoruz
            marker.ToolTipText = String.Format("Location:\n Latituade:{0}\n Longitude:{1}\n", lat, lng); // kullanıcıdan alınan yeni enlem boylam bilgisi

            CreateDirectionTraceroute(lat, lng);

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(tDescription.Text, tLatitude.Text, tLongitude.Text); // datagride ekleme
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(SelectedRow);
        }

        private void bPolygon_Click(object sender, EventArgs e)
        {
            GMapOverlay Polygon = new GMapOverlay("Polygon");
            List<PointLatLng> points = new List<PointLatLng>();

            double lng, lat;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value);
                points.Add(new PointLatLng(lat, lng));
            }
            GMapPolygon PolygonPoints = new GMapPolygon(points, "Polygon");
            Polygon.Polygons.Add(PolygonPoints);
            gMapControl1.Overlays.Add(Polygon);

            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }

        private void bRoute_Click(object sender, EventArgs e)
        {
            GMapOverlay Route = new GMapOverlay("Path Layer"); //Yol Katmanı

            List<PointLatLng> points = new List<PointLatLng>();
            double lat, lng;  //Verileri tutmak için
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++) //Sütunları dolduruyoruz
            {
                lat = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value);
                points.Add(new PointLatLng(lat, lng));
            }
            GMapRoute RoutePoints = new GMapRoute(points, "Route");
            Route.Routes.Add(RoutePoints);
            gMapControl1.Overlays.Add(Route);

            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }
        public void CreateDirectionTraceroute(double lat, double lng) //Yöz izleme rotası oluşturuyoruzç
        {
            if (Traceroute)
            {
                switch (RouteIndicatorCounter)
                {
                    case 0:  //first start
                        RouteIndicatorCounter++;
                        start = new PointLatLng(lat, lng);
                        break;
                    case 1:
                        RouteIndicatorCounter++;
                        final = new PointLatLng(lat, lng);
                        GDirections direction;
                        var RouteDirection = GMapProviders.GoogleMap.GetDirections(out direction, start, final, false, false, false, false, false);
                        GMapRoute RouteObtained = new GMapRoute(direction.Route, "Route Location"); //Elde edilen rota
                        GMapOverlay RouteLayer = new GMapOverlay("Routes Layer");
                        RouteLayer.Routes.Add(RouteObtained);
                        gMapControl1.Overlays.Add(RouteLayer);
                        gMapControl1.Zoom = gMapControl1.Zoom + 1;
                        gMapControl1.Zoom = gMapControl1.Zoom - 1;
                        RouteIndicatorCounter = 0;
                        Traceroute = false;
                        break;

                }
            }
        }

    }

}
