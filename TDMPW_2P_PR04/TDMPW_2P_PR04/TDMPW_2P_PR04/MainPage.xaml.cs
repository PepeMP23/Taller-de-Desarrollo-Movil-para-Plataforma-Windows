using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace TDMPW_2P_PR04;

public partial class MainPage : ContentPage
{
    
    Random random = new Random();
    private int contador = 1;
    private int puntos = 0;
    private int intentos = 2;
    private List<Pregunta> preguntas;

    public MainPage()
    {
        InitializeComponent();
        InicializarPreguntas();
        MostrarSiguientePregunta();
    }

    private void InicializarPreguntas()
    {
        preguntas = new List<Pregunta>
        {
            new Pregunta("¿Cuál es el río más largo del mundo?", "Nilo"),
            new Pregunta("¿Cuál es la capital de Italia?", "Roma"),
            new Pregunta("¿Cuál es el océano más grande del mundo?", "Pacífico"),
            new Pregunta("¿Cuál es la capital de Japón?", "Tokio"),
            new Pregunta("¿Qué elemento químico tiene el símbolo -Fe- en la tabla periódica?", "Hierro"),
            new Pregunta("¿Cuál es el símbolo químico del oxígeno?", "O"),
            new Pregunta("¿En qué país se encuentra la Torre Eiffel?", "Francia"),
            new Pregunta("¿En qué país se encuentra la Gran Muralla China?", "China"),
            new Pregunta("¿Cuál es la moneda oficial de Japón?", "Yen"),
            new Pregunta("¿Cuál es el nombre de la primera mujer astronauta?", "Valentina")
        };
    }

    private void MostrarSiguientePregunta()
    {
        if (contador < 6 && puntos < 3)
        {
            int randomIndex;
            do
            {
                randomIndex = random.Next(preguntas.Count);
            } while (preguntas[randomIndex].HasBeenAsked);

            Pregunta pregunta = preguntas[randomIndex];
            pregunta.HasBeenAsked = true;

            lblPregunta.Text = pregunta.QText;
            entRespuesta.Text = "";
            intentos = 2;
            lblIntentos.Text = $"Intentos: {intentos}";
            lblResultado.Text = "";
        }
        else
        {
            if (puntos >= 3)
            {
                lblResultado.Text = "¡Ganaste!";
                //btnContinuar.Text = "Reiniciar";
                entRespuesta.IsEnabled = false;
                imgResultado.Source = "correct.png";
                
            }
            else
            {
                lblResultado.Text = "¡Perdiste!";
                //btnContinuar.Text = "Volver a intentarlo";
                entRespuesta.IsEnabled = false;
                imgResultado.Source = "incorrect.png";
                
            }
            
        }
    }

    void btnContinuar_Clicked(System.Object sender, System.EventArgs e)
    {
        if (contador < 6 && puntos < 3)
        {
            Pregunta pregunta = preguntas.Find(q => q.QText == lblPregunta.Text);
            string userAnswer = entRespuesta.Text;

            if (userAnswer.ToLower() == pregunta.Respuesta.ToLower())
            {
                puntos++;
                lblPuntos.Text = $"Puntos: {puntos}";
            }
            else
            {
                intentos--;
                lblIntentos.Text = $"Intentos: {intentos}";
            }

            if (intentos == 0 || userAnswer.ToLower() == pregunta.Respuesta.ToLower())
            {
                contador++;
                lblCantidad.Text = $"Pregunta: {contador}";
                MostrarSiguientePregunta();
            }
        }
    }

    void ReiniciarJuego()
    {
        contador = 1;
        puntos = 0;
        intentos = 2;
        InicializarPreguntas();
        MostrarSiguientePregunta();
        lblPuntos.Text = "Puntos: 0";
        lblIntentos.Text = "Intentos: 2";
        lblCantidad.Text = "Pregunta: 1";
        lblResultado.Text = "";
        entRespuesta.IsEnabled = true;
        imgResultado.Source = null;
        btnContinuar.Text = "Continuar";
    }

    public class Pregunta
    {
        public string QText { get; set; }
        public string Respuesta { get; set; }
        public bool HasBeenAsked { get; set; }

        public Pregunta(string pregunta, string answer)
        {
            QText = pregunta;
            Respuesta = answer;
            HasBeenAsked = false;
        }
    }
}
