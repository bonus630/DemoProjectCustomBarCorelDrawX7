using System.Windows.Controls;
using Corel.Interop.VGCore;
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
            btn_drawArrow.Click += (s, e) => { DrawArrow(app); };
            btn_curveArea.Click += (s, e) => { CurveArea(app); };
            
        }
        private void CurveArea(Corel.Interop.VGCore.Application app)
        {
            //Calcula área de um shape selecionado
            //tratamento de erro é necessário para evitar que o CorelDraw feche, exemplo: nenhum objeto selecionado
            global::System.Windows.MessageBox.Show(string.Format("Área: {0}",app.ActiveShape.Curve.Area));
        }
        public void DrawArrow(Corel.Interop.VGCore.Application app)
        {
            
           //Criando um segmento de linha com ponta de flecha
            Corel.Interop.VGCore.Shape line = app.ActiveDocument.ActiveLayer.CreateLineSegment(0, 0, 1.5, 0);
            line.Outline.EndArrow = app.ArrowHeads[2];
            //Inicio de flecha
            // line.Outline.StartArrow = app.ArrowHeads[2];
      
        }
    }
}
