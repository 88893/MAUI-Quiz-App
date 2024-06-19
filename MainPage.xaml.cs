using patrick.Models;

namespace patrick;

public partial class MainPage : ContentPage
{
	private List<vragen> vragen;
	private int currentQuestionIndex;
	private vragen currentquestion;


	

    public MainPage()
	{
		InitializeComponent();
		vragen = new List<vragen>();
		vragen vraag1 = new vragen(1, "Wat is de naam van de kleine zeemeermin in de Disney-film \"De Kleine Zeemeermin\"?", "Ariel", "Belle", "Elsa", "A");
        vragen vraag2 = new vragen(2, "Wie is de hoofdpersoon in de Disney-film \"The Lion King\"?", "Simba", "Aladdin", "Mulan", "A");
        vragen vraag3 = new vragen(3, "Welk personage uit \"Beauty and the Beast\" is betoverd in een beker?", "Belle", "Het Beest", "Lumiere", "C");
        vragen vraag4 = new vragen(4, "In welke Disney-film ontmoeten we het personage Genie, dat wordt vertolkt door Robin Williams?\n\n", "Aladdin", "de kleine zeemeermin", "Doornoosje", "A");
        vragen vraag5 = new vragen(5, " Wie is de kwaadaardige tovenares in \"Sneeuwwitje en de Zeven Dwergen\"?", "Sneeuwwitje", "Assepoester", "De boze koning", "goedanwtoord");

        vragen.Add(vraag1);
        vragen.Add(vraag2);
        vragen.Add(vraag3);
        vragen.Add(vraag4);
        vragen.Add(vraag5);

        currentQuestionIndex = 0;
        loadquestion();
    }

    private void loadquestion()
    {
        if (currentQuestionIndex >= 0 && currentQuestionIndex < vragen.Count)
        {
            currentquestion = vragen[currentQuestionIndex];
            vraag.Text = "Vraag " + currentquestion.id + ": " + currentquestion.vraag;
            optiea.Text = "A: " + currentquestion.antwoordA;
            optieb.Text = "B: " + currentquestion.antwoordB;
            optiec.Text = "C: " + currentquestion.antwoordC;
        }
        else
        {
            vraag.Text = "Geen vragen meer";
            optiea.Text = string.Empty;
            optieb.Text = string.Empty;
            optiec.Text = string.Empty;
        }
    }




    private int score;

   public void Antwoord_Clicked(System.Object sender, System.EventArgs e) 
    {
        string answer = vraaginvoer.Text;
        answer = answer.Trim().ToUpper();

        if (currentquestion != null && answer == currentquestion.goedeantwoord)
        {
            score++;
            Score.Text = "Score: " + score.ToString();

        }
        currentQuestionIndex++;
        loadquestion();

        vraaginvoer.Text = "";

    }

   

void reset_Clicked(System.Object sender, System.EventArgs e)
    {
        currentQuestionIndex = 0;
        loadquestion();
        Score.Text = "Score 0";
        score = 0;

    }

    void verwijderScores_Clicked(System.Object sender, System.EventArgs e)
    {
        Score.Text = "Score 0";
        score = 0;
    }
}


