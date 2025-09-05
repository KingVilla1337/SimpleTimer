using System.Configuration;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls; 

namespace SimpleTimer
{
    public partial class StopWatch : MaterialForm
    {
        private int seconds = 0;
        private Stopwatch stopwatch;
        private int lapcount = 0;
        private TimeSpan lastLapTime = TimeSpan.Zero;




        private void UpdateDisplay()
        {
            TimeSpan ts = stopwatch.Elapsed;
            lblTime.Text = ts.ToString(@"hh\:mm\:ss\.fff");
        }


        public StopWatch()
        {
            InitializeComponent();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
          Primary.Blue600, Primary.Blue700,
          Primary.Blue200, Accent.LightBlue200,
          TextShade.WHITE);




            stopwatch = new Stopwatch();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDisplay();


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            timer1.Stop();
            lblTime.Text = "00:00:00.000";
            lastLapTime = TimeSpan.Zero;




        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            lapcount++;
            TimeSpan ts = stopwatch.Elapsed;
            string round = lapcount.ToString();

            string laptime = ts.ToString(@"hh\:mm\:ss\.fff");
            string diff = (ts - lastLapTime).ToString(@"hh\:mm\:ss\.fff");

            ListViewItem item = new ListViewItem(new[] { round, laptime, diff });
            lstLabs.Items.Add(item);

            lastLapTime = ts;


            lstLabs.Items[lstLabs.Items.Count - 1].EnsureVisible();

        }

        private void lstLabs_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            lstLabs.View = View.Details;
            lstLabs.FullRowSelect = true;
            lstLabs.Columns.Add("Runde", 160);
            lstLabs.Columns.Add("Gesamtzahl", 160);
            lstLabs.Columns.Add("Rundenzeit", 160);

            StyleButtonFlat(btnStart, Color.FromArgb(56, 132, 255));   // Blau
            StyleButtonFlat(btnStop, Color.FromArgb(56, 132, 255));      // Grau
            StyleButtonFlat(btnReset, Color.FromArgb(56, 132, 255));     // Grau
            StyleButtonFlat(btnLab, Color.FromArgb(56, 132, 255));     // Blau
            StyleButtonFlat(btnListClear, Color.FromArgb(56, 132, 255)); // Grau


            // Dezente Farbwahl (modern & ruhig)
            ApplyButtonColors();


        }
        private void StyleButtonFlat(Button b, Color back)
        {
            b.UseVisualStyleBackColor = false;     // wichtig: sonst ignoriert er BackColor
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;       // kein weiﬂer Rand
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            b.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);

            b.BackColor = back;                    // deine Farbe
            b.ForeColor = Color.White;
            b.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            b.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void ApplyButtonColors()
        {
            // dezentes, einheitliches Schema
            var accent = Color.FromArgb(56, 132, 255); // Blau
            var neutral = Color.FromArgb(72, 72, 72);  // Dunkelgrau

            StyleButtonFlat(btnStart, accent);
            StyleButtonFlat(btnLab, accent);

            StyleButtonFlat(btnStop, accent);
            StyleButtonFlat(btnReset, accent);
            StyleButtonFlat(btnListClear, accent);
        }

        private void btnListClear_Click(object sender, EventArgs e)
        {
            lapcount = 0;
            lstLabs.Items.Clear();

        }

       


    }
}
