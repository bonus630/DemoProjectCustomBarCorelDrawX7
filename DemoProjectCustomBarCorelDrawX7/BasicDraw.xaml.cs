using System.Windows.Controls;

namespace br.corp.bonus630.DemoProjectCustomBarCorelDrawX7
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BasicDraw : UserControl
    {
        public BasicDraw(Corel.Interop.VGCore.Application app)
        {
            InitializeComponent();
            btn_drawCicle.Click += (s, e) => { app.ActiveDocument.ActiveLayer.CreateEllipse(0, 0, 1.5, 1.5); };
            btn_drawSquad.Click += (s, e) => { app.ActiveDocument.ActiveLayer.CreateRectangle(0, 0, 1.5, 1.5); };
            btn_drawLine.Click += (s, e) => { app.ActiveDocument.ActiveLayer.CreateLineSegment(0,0,1.5,0); };
            btn_drawText.Click += (s, e) => { app.ActiveDocument.ActiveLayer.CreateArtisticText(0,0,"Hello, this is a test"); };
        }
    }
}
