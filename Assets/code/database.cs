using System.Collections.Generic;
using UnityEngine;

public class database : MonoBehaviour
{
    
    /*public List<string> syllables = new List<string>
    {
    "a",
    "gneau",
    "bi",
    "by",
    "bie",
    "jou",
    "hi",
    "bou",
    "ai",
    "der",
    "as",
    "soir",
    "poi",
    "sson",
    "son",
    "boi",
    "bou",
    "chon"
    }; */

    public List<string> phonemes = new List<string>
    {
        "a",
        "gn",
        "ni",
        "o",
        "eau",
        "au",
        "bi",
        "by",
        "bie",
        "g",
        "j",
        "ju",
        "ou",
        "u",
        "hou",
        "hi",
        "hie",
        "hy",
        "b",
        "ai",
        "é",
        "et",
        "d",
        "er",
        "ez",
        "s",
        "ss",
        "sw",
        "oi",
        "oua",
        "r"
    };
    
public class Word
{
    public string name;
    public List<string> phonemes;

    public Word(string name, List<string> phonemes)
    {
        this.name = name;
        this.phonemes = phonemes;
    }
}
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
