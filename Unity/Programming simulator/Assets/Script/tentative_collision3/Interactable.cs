using UnityEngine;
using UnityEngine.UI;
public class Interactable : MonoBehaviour
{
    private float _points = 0;
    public static Score_systeme instance;
    public Text scoreText;
    public float radius = 3f;
    public float maxSelectDistance = 25f;
    bool isFocus = false;
    public AudioSource click;
    public AudioSource Musique;

    //étapes scores
    float targetScore = 100;
    float targetScore200 = 200;
    float targetScore300 = 300;
    float targetScore400 = 400;
    float targetScore500 = 500;
    float targetScore600 = 600;
    float targetScore666 = 666;
    float targetScore850 = 850;
    float targetScore1000 = 1000;
   



Transform player;
    bool hasInteracted = false;
    public GameObject cursorImage;
    public GameObject mainCameraObject;
    public Renderer selectedObject;


     //étapes 1
    public GameObject écran_base;
    public GameObject écran_1;

    //étapes 2
    public GameObject écran_base2;
    public GameObject écran_base3;
    public GameObject écran_2;
    public GameObject écran_3;
    //étapes 3
    public GameObject Light;
    public GameObject celling;
    public GameObject celling_off;

    //étapes 4
    public GameObject bugwindows;


    //étapes 5
    public GameObject son;

    //étapes 6
    public GameObject neige;

    //étapes 7
    public GameObject intruder;

    //étapes 8
    
   

    //étapes 9

    public GameObject intruder_2;
    public GameObject intruder_3;

    //étapes fin 10
    public GameObject GameOver;





    Camera cam;
    Vector3 heightOffsetPos;
    Vector3 screenPos;
    Vector3 twoDimPos;
    int score = 0;


    void Start()
    {
        isFocus = false;
        player = GameObject.Find("MouseKnight").transform;
        cursorImage = GameObject.FindWithTag("Select Cursor");
        cursorImage.SetActive(true);
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        //selected object should be whatever the player has focused.
    }



    public virtual void Interact()
    {
        AddPoint();
        
    }
    void Update()
    {
        scoreText.text = score.ToString() + " POINTS";
        //used to test the status of isFocus
        if (isFocus)
        {
            print(player.GetComponent<PlayerInteraction>().focus.name);
        }
        //used for tracking object's position
        selectedObject = GetComponent<Renderer>();

        initInteract();
        //placeCursor();
    }

    //checks if we're close enough to interact & if we've already interacted
    public void initInteract()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.transform.position, transform.position);
            if (distance <= radius)
            {
                Interact();

            }
        }
        hasInteracted = true;
    }

    //turns on isFocus and is used in the PlayerInteraction Script
    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        AddPoint();
        print("isFocus : " + isFocus);
        player = playerTransform;
        hasInteracted = false;



    }

    //turns off isFocus and is used in the PlayerInteraction Script
   
    public void OnDefocused()
    {
        isFocus = false;
        print("isFocus : " + isFocus);
        player = null;
        hasInteracted = false;
    }
    void bugscore()
    {
        score++;
    }
    void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
 
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        click.Play();

        if (score >= targetScore)
            
        {
            // Do something
            targetScore += 100;
            écran_1.SetActive(true);
            écran_base.SetActive(false);
        }
        if (score >= targetScore200)
        {
            targetScore += 200;
            écran_base2.SetActive(false);
            écran_base3.SetActive(false);
            écran_2.SetActive(true);
            écran_3.SetActive(true);
        }
        if (score >= targetScore300)
        {
            targetScore += 300;
            Light.SetActive(false);
            celling.SetActive(false);
            celling_off.SetActive(true);
        }
        if (score >= targetScore400)
        {
            targetScore += 400;
            écran_1.SetActive(false);
            écran_2.SetActive(false);
            écran_3.SetActive(false);

            bugwindows.SetActive(true);
        }
        if (score >= targetScore500)
        {
            targetScore += 500;
            bugwindows.SetActive(false);
        }
        if (score >= targetScore600)
        {
            targetScore += 600;
            neige.SetActive(true);
            son.SetActive(false);
        }
        if (score >= targetScore666)
        {
            targetScore += 666;

            neige.SetActive(false);
            intruder.SetActive(true);
            InvokeRepeating("bugscore", 1, 1);
            Musique.Play();

        }
         if (score >= targetScore850)
        {
            intruder_2.SetActive(true);
            intruder_3.SetActive(true);
        }
        if (score >= targetScore1000)
        {

            GameOver.SetActive(true);
            Invoke("Quit", 1);


        }
        

       



        //void lol()
        //{
        // InvokeRepeating((lol_2), 1, 1);

        // }
        //void lol_2()
        // {
        //     score++;
        // }

    }
      

    }

