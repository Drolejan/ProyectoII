using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class simpleFollow : MonoBehaviour
{
    public Transform toFollow;
    TextMeshProUGUI textMeshProUGUI;
    void Start()
    {
        textMeshProUGUI=GetComponent <TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = toFollow.position;
        textMeshProUGUI.text = Random.Range(0, 100).ToString();
    }
}
