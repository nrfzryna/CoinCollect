using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float duration = 1f;

    private TextMeshProUGUI text;
    private Vector3 flaotDirection = new Vector3(0, 1, 0);

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        Destroy(gameObject, duration);
    }

    void Update()
    {
        // Move the text upwards
        transform.position += flaotDirection * floatSpeed * Time.deltaTime;
    }
}
