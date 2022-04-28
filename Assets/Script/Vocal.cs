using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System;
using System.Linq;

public class Vocal : MonoBehaviour
{
    private Dictionary<string, Action> keyWordActions = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;
    private PhraseRecognizer phraseRecognizer;
    public GameObject character;
    private DictationRecognizer dictationRecognizer;
    // Start is called before the first frame update
    void Start()
    {
        //dictationRecognizer = new DictationRecognizer();
       // dictationRecognizer.DictationResult += DictationRecognizer_DictationResult;
        keyWordActions.Add("Enflamme toi", Flamme);
        

        keywordRecognizer = new KeywordRecognizer(keyWordActions.Keys.ToArray(), ConfidenceLevel.High);
        keywordRecognizer.OnPhraseRecognized += OnPhraseRecognized;
        keywordRecognizer.Start();
        //dictationRecognizer.Start();
        //dictationRecognizer.DictationResult -= DictationRecognizer_DictationResult;
        //dictationRecognizer.Dispose();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keyWordActions.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
        /*keyWordActions[args.text].Invoke();
        Debug.Log(args.text);*/
    }

    /*private void DictationRecognizer_DictationResult(string text, ConfidenceLevel confidence)
    {
        Debug.Log(text);
        if (text == "enflamme toi")
        {
            Flamme();
        }
        
    }*/

    void Flamme()
    {
        Debug.Log("wtfSaFonctionne");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
