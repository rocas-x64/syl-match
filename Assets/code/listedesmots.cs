using System.Collections.Generic;
using UnityEngine;

public class listedesmots : MonoBehaviour
{
    [SerializeField]
    List<string> list = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string GetRandomWord()
    {
        int index = Random.Range(0, list.Count);
        return list[index];
    }

 
    public GameObject wordPrefab;
    public Transform spawnPoint;

    public void SpawnRandomWord()
    {
        if (words.Count == 0) return;

        int randomIndex = Random.Range(0, words.Count);
        string selectedWord = words[randomIndex];

        GameObject newWord = Instantiate(wordPrefab, spawnPoint.position, Quaternion.identity);

        TextMeshPro tmp = newWord.GetComponent<TextMeshPro>();
        tmp.text = selectedWord;

    }
