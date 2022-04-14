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
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        keyWordActions.Add("Enflamme toi", Flamme);

        keywordRecognizer = new KeywordRecognizer(keyWordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        keyWordActions[args.text].Invoke();
    }

    void Flamme()
    {
        Debug.Log("wtfSaFonctionne");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
