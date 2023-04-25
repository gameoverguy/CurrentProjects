using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Parameters : MonoBehaviour
{
	// MainMenu Items
	//All Categories UI scene
	public GameObject GuessTheLogoCategory;
	public GameObject Settings;
	
	
	//public bool LevelCompletedBool;
	public GameObject MuteIcon;
	
	
	public GameObject[] BlankLevels;
	public TextMeshProUGUI[] LevelNumberText;
	
	//Category Level UI scene
	public GameObject CategoryLevel;
	
	//MainMenu UI scene
	public GameObject MainMenu;
	
	//UI shown after Remove oneoption
	public GameObject RemoveOptionDialog;
	
	//UI shown after ShowAnswer
	public GameObject ShowAnswerDialog;
	
	//Reward icon/button
	public GameObject RewardButton;
	
	//UI shown after ShowAnswer
	public GameObject RewardAdsDialog;
	
	//Show Answer button
	public GameObject ShowAnswerButton;
	
	//Remove Option button
	public GameObject RemoveOptionButton;
	
	//UI shown after Reset Game Option
	public GameObject ResetGameDialog;
	
	
	
	//All the choices/options in the game scene
	public GameObject[] Choices;
	
	//Sprite state of the choices
	public SpriteState[] sprState;
	
	
	public GameObject[] temp;
	
	//Game UI scene
	public GameObject CurrentlevelView;
	
	//Level completed UI scene
	public GameObject LevelCompletedView;
	
	//store if the option[i] is correct
	public bool[] CorrectAnswer;
	
	//store if the option[i] is INcorrect
	public bool[] InCorrectAnswer;
	
	//wait till the answer is verified
	public float waittime;
	
	//time until the next question is shown
	public float TransitionTime;
	
	//Level completed text
	public TextMeshProUGUI LevelCompletedText;
	
	//Shows the Logo question image
	public Image QuestionImage;
	
	//Level Total question text and slider
	public TextMeshProUGUI ProgressText;
	public Slider Progressslider;
	
	//Level correct Answers text and slider
	public TextMeshProUGUI[] QuestionProgressText;
	public Slider[] Questionslider;
	
	
	//Used for image change, lvltxt and retry text also the bg image of levels
	public Image[] CategoryLevelImageObject;
	public Sprite[] LevelBackgroundImage;
	
	public GameObject[] PackCheckMark;

	
	//Contains only the correct answers count
	public int[] ActorsPackCorrectAnswers;
	public int[] AppsPackCorrectAnswers;
	public int[] CartoonsPackCorrectAnswers;
	public int[] FamousPackCorrectAnswers;
	public int[] FlagsPackCorrectAnswers;
	public int[] LandmarksPackCorrectAnswers;
	public int[] SoftwaresPackCorrectAnswers;
	public int[] SuperheroesPackCorrectAnswers;
	public int[] VehiclesPackCorrectAnswers;
	
	//Play Button in the levels object
	public TextMeshProUGUI[] LevelButtonText;
	
	//the text to place in the level play button
	public string[] ActorsPackButtonText;
	public string[] AppsPackButtonText;
	public string[] CartoonsPackButtonText;
	public string[] FamousPackButtonText;
	public string[] FlagsPackButtonText;
	public string[] LandmarksPackButtonText;
	public string[] SoftwaresPackButtonText;
	public string[] SuperheroesPackButtonText;
	public string[] VehiclesPackButtonText;
	
	//unlock bool for all category
	public bool[] ActorsPackBool;
	public bool[] AppsPackBool;
	public bool[] CartoonsPackBool;
	public bool[] FamousPackBool;
	public bool[] FlagsPackBool;
	public bool[] LandmarksPackBool;
	public bool[] SoftwaresPackBool;
	public bool[] SuperheroesPackBool;
	public bool[] VehiclesPackBool;
	
	//Checkimage bool for all category levels
	public bool[] ActorsPackCheckBool;
	public bool[] AppsPackCheckBool;
	public bool[] CartoonsPackCheckBool;
	public bool[] FamousPackCheckBool;
	public bool[] FlagsPackCheckBool;
	public bool[] LandmarksPackCheckBool;
	public bool[] SoftwaresPackCheckBool;
	public bool[] SuperheroesPackCheckBool;
	public bool[] VehiclesPackCheckBool;
	
	//Green Image for Pack partial or full completion
	public Sprite[] ActorsPackPanelImage;
	public Sprite[] AppsPackPanelImage;
	public Sprite[] CartoonsPackPanelImage;
	public Sprite[] FamousPackPanelImage;
	public Sprite[] FlagsPackPanelImage;
	public Sprite[] LandmarksPackPanelImage;
	public Sprite[] SoftwaresPackPanelImage;
	public Sprite[] SuperheroesPackPanelImage;
	public Sprite[] VehiclesPackPanelImage;
	
	
	public GameObject[] LevelLock;
	
	
	
	//contains logo question category
	public Category[] category;
	
	//Contains basic component like colors
	public BasicData BasicGuessData;
	
	//Contains question choices and image
	public GuessData QuestionData;
	
	public TextMeshProUGUI CoinsText;
	public TextMeshProUGUI Scoretext;
	
	//Total levels in the that category
	//public TextMeshProUGUI Leveltext;
	
	//shows the ChoicesButtonText
	public TextMeshProUGUI[] ChoicesButtonText;
	
	//Contains the 4 choice buttons in the question
	public Button[] ChoicesButton;
	
	//font
	public TMP_FontAsset[] font;
	
	//store the Incorrect choices for the Remove random option button
	public ArrayList IncorrectChoice;
	
	//Category Levels
	public CategoryLevel[] ActorsPack;
	public CategoryLevel[] AppsPack;
	public CategoryLevel[] CartoonsPack;
	public CategoryLevel[] FamousPack;
	public CategoryLevel[] FlagsPack;
	public CategoryLevel[] LandmarksPack;
	public CategoryLevel[] SoftwaresPack;
	public CategoryLevel[] SuperheroesPack;
	public CategoryLevel[] VehiclesPack;

	//Level Question counter for the text slider in game menu
	public int[] ActorsPackQuestion;
	public int[] AppsPackQuestion;
	public int[] CartoonsPackQuestion;
	public int[] FamousPackQuestion;
	public int[] FlagsPackQuestion;
	public int[] LandmarksPackQuestion;
	public int[] SoftwaresPackQuestion;
	public int[] SuperheroesPackQuestion;
	public int[] VehiclesPackQuestion;
	
	public int CurrentGold;
	public int MaxScore;
	public int CurrentScore;
	public int Lvl;
	public int CategoryNumber;
	public int RandomNumber;
	public int yesclick;
	
	public bool MaxScoreBool;

}
