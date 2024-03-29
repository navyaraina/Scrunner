using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Windows.Speech;



public class VoiceInput : MonoBehaviour
{
    // Voice command vars
    private Dictionary<string, Action> keyActs = new Dictionary<string, Action>();
    private KeywordRecognizer recognizer;

    public Rigidbody rb;
    public Vector3 scaleChange, originalScale;

    //public Animator animator;

    [SerializeField] GameObject lane1Cube;
    [SerializeField] GameObject lane2Cube;
    [SerializeField] GameObject lane3Cube;
    private Vector3[] lanePos;
    int currentLaneIndex;
    int targetIndex;
    public float forceMag;

    public anim an;


    void Start()
    {

        keyActs.Add("left", Left);
        keyActs.Add("jump", Jump);
        keyActs.Add("write", Right);
        keyActs.Add("right", Right);
        keyActs.Add("crawl", Slide);
        keyActs.Add("center", Center);


        recognizer = new KeywordRecognizer(keyActs.Keys.ToArray(), ConfidenceLevel.Low);
        recognizer.Start();

        //assigning lanes

        Debug.Log("Start");
        forceMag = 0;
        lanePos = new Vector3[3];
        lanePos[0] = lane1Cube.transform.position;
        lanePos[1] = lane2Cube.transform.position;
        lanePos[2] = lane3Cube.transform.position;

        scaleChange = new Vector3(0.5f, 0.5f, 1f);
        originalScale=new Vector3(1f,1f, 1f);  

  
    }

    // Update is called once per frame
    void Update()
    {

        recognizer.OnPhraseRecognized += OnKeywordsRecognized;
        
    }

    void Center()
    {
        targetIndex = 1;
        Debug.Log(lanePos[1]);

        currentLaneIndex = targetIndex;

        var step = 500f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, lanePos[targetIndex], step);
    }
    void Left()
    {
        if (currentLaneIndex != 0)
        {
            targetIndex = currentLaneIndex - 2;
            Debug.Log(lanePos[0]);
        }

        
        currentLaneIndex = targetIndex;

        var step = 500f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, lanePos[targetIndex], step);
    }

    void Right()
    {

        if (currentLaneIndex != 2)
        {
            targetIndex = currentLaneIndex + 2;
            Debug.Log(lanePos[2]);
        }

        
        currentLaneIndex = targetIndex;

        var step = 500f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, lanePos[targetIndex], step);
    }

    public void Jump() 
    {
        rb.AddForce(Vector3.up * forceMag);
        Debug.Log(rb);

        an.jump();
        Debug.Log("jumping");
        StartCoroutine(Example());

    }

    public void Slide()    
    {
        an.slide();
        Debug.Log("crawling");
        StartCoroutine(Example());
    }

    void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Command: " + args.text);
        keyActs[args.text].Invoke();
    }
    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(2);
        Debug.Log("Wait");
        an.running();
    }
}