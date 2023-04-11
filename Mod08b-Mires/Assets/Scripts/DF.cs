using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class DF : MonoBehaviour
{
    Renderer rend;
    Shader shader;
    Texture texture;
    Color color;


    //public Material mat;
    public float waitTime = 1.0f;
    public float time = 0.0f;
    public float rn;
    
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        rend = GetComponent<Renderer>();

        //mat = this.GetComponent<Material>();
        rend.material = new Material(shader);
        rend.material.mainTexture = texture;
        rend.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (time < Time.time)
        {
            //Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            //mat.SetColor("_Color", newColor);
            //rend.material.color = new Color(Random.Range(0.0f+rn, 0.9f + rn), Random.Range(0.0f + rn, 0.9f + rn), Random.Range(0.0f + rn, 0.9f + rn));
            rend.material.color = Random.ColorHSV(0.0f, 1.0f, 0.9f, 1.0f, 0.8f, 1.0f);

            time = waitTime + Time.time;
        }
    }
}
