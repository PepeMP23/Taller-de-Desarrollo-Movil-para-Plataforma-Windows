using System.ComponentModel;

namespace TDMPW_3P_PR01;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{

	string nombreImagen = "";
	string listaIngredientes = "Lista de ingredientes:";
	string procedimiento = "";
	string nivelDificultad = "Nivel de dificultad: ";
	string clasificacion = "Clasificacion: ";

	public string NombreImagen
	{
		get => nombreImagen;
		set
		{
			nombreImagen = value;
			OnPropertyChanged();
		}
	}

    public string ListaIngredientes
    {
        get => listaIngredientes;
        set
        {
            listaIngredientes = value;
            OnPropertyChanged();
        }
    }

    public string Procedimiento
    {
        get => procedimiento;
        set
        {
            procedimiento = value;
            OnPropertyChanged();
        }
    }

    public string NivelDificultad
    {
        get => nivelDificultad;
        set
        {
            nivelDificultad = value;
            OnPropertyChanged();
        }
    }

    public string Clasificacion
    {
        get => clasificacion;
        set
        {
            clasificacion = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    void RecetaUno_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta_uno.png";
        ListaIngredientes = "Ingredientes:\n\nLechuga romana\nPan crujiente (como crutones)\nPechuga de pollo a la parrilla\nQueso parmesano\nSalsa César\nSal y pimienta";
        Procedimiento = "Procedimiento:\n\nLavar y picar la lechuga romana.\nCortar el pan crujiente en trozos pequeños.\nCocinar la pechuga de pollo a la parrilla y luego cortarla en tiras.\nMezclar todos los ingredientes en un tazón grande y agregar la salsa César.\nEspolvorear con queso parmesano, sal y pimienta al gusto.";
        NivelDificultad = "Nivel de Dificultad: 2";
        Clasificacion = "Clasificación: Fácil y saludable.";
    }

    void RecetaDos_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta_dos.png";
        ListaIngredientes = "Ingredientes:\n\nArroz Arborio\nChampiñones\nCebolla\nCaldo de verduras\nVino blanco\nQueso parmesano\nMantequilla\nAceite de oliva\nSal y pimienta";
        Procedimiento = "Procedimiento:\n\nSaltear la cebolla y los champiñones en aceite de oliva hasta que estén tiernos.\nAgregar el arroz y cocinar durante unos minutos.\nVerter el vino blanco y dejar que se absorba.\nAgregar caldo de verduras caliente gradualmente, removiendo constantemente.\nCocinar hasta que el arroz esté al dente y cremoso. Luego, mezclar con mantequilla y queso parmesano.\nSazonar con sal y pimienta al gusto.";
        NivelDificultad = "Nivel de Dificultad: 4";
        Clasificacion = "Clasificación: Delicioso pero requiere paciencia.";
    }

    void RecetaTres_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta_tres.png";
        ListaIngredientes = "Ingredientes:\n\nPechugas de pollo\nCebolla\nAjo\nJengibre\nTomate\nLeche de coco\nCurry en polvo\nAceite de cocina\nSal y pimienta";
        Procedimiento = "Procedimiento:\n\nDorar el pollo en una sartén con aceite.\nEn una olla aparte, sofreír cebolla, ajo y jengibre.\nAgregar tomate y cocinar hasta que esté suave.\nAñadir curry en polvo y leche de coco, cocinar a fuego lento.\nAgregar el pollo cocido y cocinar a fuego lento hasta que esté bien cocido.\nSazonar con sal y pimienta al gusto.";
        NivelDificultad = "Nivel de Dificultad: 3";
        Clasificacion = "Clasificación: Sabroso y reconfortante.";
    }

    void RecetaCuatro_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta_cuatro.png";
        ListaIngredientes = "Ingredientes:\n\nAlgas nori\nArroz para sushi\nSalmón fresco\nPepino\nAguacate\nVinagre de arroz\nAzúcar\nSal\nSalsa de soja\nWasabi";
        Procedimiento = "Procedimiento:\n\nCocinar el arroz y mezclarlo con vinagre, azúcar y sal.\nCortar el salmón, pepino y aguacate en tiras delgadas.\nColocar una hoja de alga nori en una esterilla de bambú, esparcir arroz y añadir los ingredientes.\nEnrollar cuidadosamente el sushi con la ayuda de la esterilla.\nCortar en rodajas y servir con salsa de soja y wasabi.";
        NivelDificultad = "Nivel de Dificultad: 4";
        Clasificacion = "Clasificación: Delicado y artístico.";
    }

    void RecetaCinco_Clicked(System.Object sender, System.EventArgs e)
    {
        NombreImagen = "receta_cinco.png";
        ListaIngredientes = "Ingredientes:\n\nQueso mascarpone\nCafé fuerte\nBizcochos de soletilla\nYemas de huevo\nAzúcar\nCacao en polvo\nLicor de café (opcional)";
        Procedimiento = "Procedimiento:\n\nMezclar las yemas con el azúcar hasta obtener una crema.\nAgregar el queso mascarpone y mezclar hasta que quede suave.\nMojar los bizcochos en café y licor (si se desea) y colocar una capa en un recipiente.\nAgregar una capa de la mezcla de queso.\nRepetir hasta llenar el recipiente. Espolvorear con cacao en polvo.\nDejar reposar en el refrigerador durante unas horas antes de servir.";
        NivelDificultad = "Nivel de Dificultad: 3";
        Clasificacion = "Clasificación: Delicioso y adictivo.";
    }
}


